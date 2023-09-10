using EveDash3.backend.httpclient;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Timers;
using System.Web;

//NONE OF THIS IS PRODUCTION GRADE. DO NOT SHIP. 

// DO  NOT  SHIP

//REVAMP USING https://docs.esi.evetech.net/docs/sso/native_sso_flow.html and DO NOT SHIP WITH SECRET KEY
namespace EveDash3.backend.sso
{

    //public delegate void SSOCharacterUpdateEvent(object sender, EventArgs e); //Called when the SSO handler changes refresh and access tokens. 

    public static class SSO_Handler
    {
        public static string clientID = "ee56faf99857468f982b281d9b00e725";
        static string secretkey = "atv499wdw39fVDv4G0fvXno7j3pyWKpfdAzefDi3";
        public static string refreshToken;
        public static string accessToken;

        public static string presentCharacter = "";
        public static string presentCharacterID = "";
        public static int expireStamp = 0;

        /// <summary>
        /// called on startup to do the following
        /// 1. check if we have logged in before and if so, verify and load the access key from file
        /// </summary>
        public static async Task InitializeSSO_Handler()
        {

            /* DEV NOTE, MOVE THE CODE BELOW FOR READING charinfo.txt INTO OWN FUNCTION. 
             * TESTING FOR REFRESH TOKEN AND UPDATING THE ACCESS TOKENS SHOULD BE HANDLED LOCALLY.
            */

            //see if we have logged in before
            StreamReader charRecord = new StreamReader(MiscFunctions.TryGetSolutionDirectoryInfo() + "/EveDash3/data/charinfo.txt");
            //Debug.WriteLine(MiscFunctions.TryGetSolutionDirectoryInfo() + "/EveDash3/data/charinfo.txt");
            string line = charRecord.ReadLine();
            int linenum = 0;

            //Debug.WriteLine(line);
            if (line == null || line == "")
            {
                Debug.WriteLine("Nothing in file!");
                //no data was found, get the user to do SSO
                SendInitialAuth();
            }
            else
            {
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the line to console window
                    Console.WriteLine(line);
                    switch (linenum)
                    {
                        case 0:
                            // Name
                            presentCharacter = line;
                            break;
                        case 1:
                            // CharID
                            presentCharacterID = line;
                            break;
                        case 2:
                            //refresh token
                            //Debug.WriteLine($"LINE : {line}");
                            var authComplete = getAccessFromRefreshToken(line);
                            if (authComplete.Result == false)
                            {
                                SendInitialAuth(); //reauthenticate.

                            }
                            else
                            {
                                var authdecoded = decodeAuth(accessToken);
                                SaveCharDetails(authdecoded["name"], authdecoded["charID"], refreshToken);

                            }


                            break;

                    }
                    //Read the next line
                    line = charRecord.ReadLine();
                    linenum++;
                }
            }

            // At this point, the AccessToken and RefershAuth should be populatedd
            if (accessToken.IsNullOrEmpty() || refreshToken.IsNullOrEmpty())
            {
                throw new MissingFieldException("Access Token or Refresh Token not yet loaded after file has been read.");
            }

            Timer refreshAccessTimer = new Timer(TimeSpan.FromMinutes(19.5).TotalMilliseconds); // Set the time (5 mins in this case)
            refreshAccessTimer.AutoReset = true;
            refreshAccessTimer.Elapsed += new ElapsedEventHandler(refreshTokenPeriodic);
            refreshAccessTimer.Start();


        }



        /// <summary>
        /// This function redirects the user to the Eve Online oauth site to get their auth code. 
        /// It then sends a post request to the token provider and stores the refresh and access token.
        /// </summary>
        static string BuildQueryString(Dictionary<string, string> parameters)
        {
            var encodedParameters = new List<string>();
            foreach (var kvp in parameters)
            {
                string key = HttpUtility.UrlEncode(kvp.Key); // Or WebUtility.UrlEncode in .NET Core
                string value = HttpUtility.UrlEncode(kvp.Value); // Or WebUtility.UrlEncode in .NET Core
                encodedParameters.Add($"{key}={value}");
            }
            return string.Join("&", encodedParameters);
        }

        /// <summary>
        /// performs SSO by requesting the access key and refresh key.
        /// </summary>
        public static void SendInitialAuth()
        {
            // generate pcke
            //generate code verifier
            string codeverifier;
            string codechallenge = string.Empty;

            const string chars = "abcdefghijklmnopqrstuvwxyz123456789";
            var random = new Random();
            var nonce = new char[128];
            for (int i = 0; i < nonce.Length; i++)
            {
                nonce[i] = chars[random.Next(chars.Length)];
            }

            codeverifier = new string(nonce);
            // Debug.WriteLine($"CodeVerifier : {codeverifier}");

            //generate code challenge

            using (SHA256 challengeGen = SHA256.Create())
            {
                byte[] hashValue = challengeGen.ComputeHash(Encoding.UTF8.GetBytes(codeverifier));
                /*
                // Convert the byte array to string format
                foreach (byte b in hashValue)
                {
                    codechallenge += $"{b:X2}";
                }
                */
                codechallenge = Convert.ToBase64String(hashValue)
                    .Replace('+', '-')
                    .Replace('/', '_')
                    .TrimEnd('=');
            }

            //Debug.WriteLine($"codechallenge : {codechallenge}");

            string url = "https://login.eveonline.com/v2/oauth/authorize/";
            Dictionary<string, string> parameters = new Dictionary<string, string>
            {
                { "response_type", "code" },
                { "redirect_uri", "http://localhost:8080/callback/" },
                { "client_id", clientID },
                { "scope", "esi-location.read_location.v1 esi-wallet.read_character_wallet.v1 esi-assets.read_assets.v1 esi-characters.read_loyalty.v1 esi-wallet.read_corporation_wallets.v1" },
                { "state", "unique-state" },
                { "code_challenge", codechallenge },
                { "code_challenge_method", "S256" }

                // Add more parameters as needed
            };
            string queryString = BuildQueryString(parameters);
            //Debug.WriteLine(queryString);
            //Console.WriteLine(queryString);
            url = url + "?" + queryString;
            //Debug.WriteLine(url);



            //redirect to auth
            Process direct = new Process();
            direct.StartInfo = new ProcessStartInfo(url);
            direct.Start();
            awaitCallback(codeverifier);
        }
        /// <summary>
        /// Awaits callback from SSO to localhost:8080/callback
        /// </summary>
        /// <returns></returns>
        static async Task awaitCallback(string codeverifier)
        {
            string listenback = "http://localhost:8080/callback/";
            using (HttpListener listener = new HttpListener())
            {
                listener.Prefixes.Add(listenback);
                listener.Start();
                //Debug.WriteLine($"Listening for requests on {listenback}");

                while (true)
                {
                    HttpListenerContext context = await listener.GetContextAsync();
                    await finalizeResponse(context, codeverifier);
                }
            }

        }
        /// <summary>
        /// Called when localhost:8080 has a response.
        /// It then parses the get request and POSTS for the refresh and access token.
        /// </summary>
        /// <param name="context"></param>
        static async Task finalizeResponse(HttpListenerContext context, string codeverifier)
        {

            HttpListenerRequest request = context.Request;
            HttpListenerResponse response = context.Response;

            // Process the request and generate a response
            string responseString = "Return to the program.";
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseString);
            response.ContentLength64 = buffer.Length;
            response.ContentType = "text/plain";

            using (var output = response.OutputStream)
            {
                await output.WriteAsync(buffer, 0, buffer.Length);
            }

            response.Close();
            //Debug.WriteLine(request.RawUrl);

            string authorizationCode = request.RawUrl.Remove(0, 16).Remove(22);

            //send post
            var values = new Dictionary<string, string>
            {
                { "grant_type", "authorization_code" },
                { "client_id", clientID },
                { "code", authorizationCode },
                { "code_verifier", codeverifier },
            };


            /*
                "grant_type": "authorization_code",
                "client_id": client_id,
                "code": auth_code,
                "code_verifier": code_verifier
            */
            var content = new FormUrlEncodedContent(values);

            var postResponse = await LocalWebClient.client.PostAsync("https://login.eveonline.com/v2/oauth/token", content);

            var postResponseStr = await postResponse.Content.ReadAsStringAsync();

            //Debug.WriteLine($"Key Response is as follows: {postResponseStr}");
            using (JsonDocument doc = JsonDocument.Parse(postResponseStr))
            {
                // Access JSON properties
                JsonElement root = doc.RootElement;
                string accesstoken = root.GetProperty("access_token").GetString();
                string refreshtoken = root.GetProperty("refresh_token").GetString();


                accessToken = accesstoken;
                refreshToken = refreshtoken;
                /*
                 * THIS DOESNT WORK! FIX ME SO THAT I CAN CACHE REFRESH TOKENS
                using (StreamWriter writer = new StreamWriter("data/refreshtoken.txt"))
                {
                    writer.WriteLine(refreshtoken);
                }
                //Console.WriteLine($"City: {city}");
                */
            }
            Dictionary<string, string> authpayload = decodeAuth(accessToken);
            //Debug.WriteLine(authpayload);
            presentCharacter = authpayload["name"];
            presentCharacterID = authpayload["charID"];
            expireStamp = Int32.Parse(authpayload["expire"]);
            SaveCharDetails(presentCharacter, presentCharacterID, refreshToken);

            UIHandler.UiUpdateHandler.DashboardWindowUpdate();
        }


        /// <summary>
        /// Decodes the accesstoken to get all the juicy info insidde
        /// </summary>
        public static Dictionary<string, string> decodeAuth(string token)
        {
            var JWK_ISSUERS = new List<string>()
            {
                "login.eveonline.com",
                "https://login.eveonline.com"
            };

            //get jwk uri
            string authuri;
            var urireq = LocalWebClient.client.GetStringAsync("https://login.eveonline.com/.well-known/oauth-authorization-server");
            //Debug.WriteLine($"Key Response is as follows: {urireq.Result}");
            using (JsonDocument doc = JsonDocument.Parse(urireq.Result))
            {
                // Access JSON properties
                JsonElement root = doc.RootElement;
                authuri = root.GetProperty("jwks_uri").GetString();
            }
            var jwk = LocalWebClient.client.GetStringAsync(authuri).Result;
            //Debug.WriteLine(jwk);


            string[] tokenParts = token.Split('.');
            //Debug.WriteLine(token);


            if (tokenParts.Length == 3)
            {
                //Debug.WriteLine(tokenParts[0].Length);
                //.WriteLine(tokenParts[0].Length % 4);
                for (int i = 0; i < 3; i++)
                {
                    if (tokenParts[i].Length % 4 != 0)
                    {
                        tokenParts[i] += new string('=', 4 - tokenParts[i].Length % 4);
                    }
                }

                //Debug.WriteLine(tokenParts[0].Length);
                //Debug.WriteLine(tokenParts[0].Length % 4);
                //.WriteLine("Decoding Token...");
                string header = DecodeBase64(tokenParts[0].ToString());
                string payload = DecodeBase64(tokenParts[1].ToString());

                //Debug.WriteLine("Decoded Header:");
                //Debug.WriteLine(header);

                //.WriteLine("Decoded Payload:");
                //.WriteLine(payload);
                //Debug.WriteLine($"Key Response is as follows: {payload}");
                using (JsonDocument payloadparse = JsonDocument.Parse(payload))
                {
                    // Access JSON properties
                    JsonElement root = payloadparse.RootElement;

                    //check payload for valid vals


                    //Debug.WriteLine($"charID: {root.GetProperty("sub").GetString().Split(':')[2].GetType()}");
                    //Debug.WriteLine($"expire: {root.GetProperty("exp").GetInt32().ToString}");
                    var payloadvalues = new Dictionary<string, string>
                    {
                        { "name", root.GetProperty("name").GetString().ToString()},
                        { "charID", root.GetProperty("sub").GetString().Split(':')[2].ToString() },
                        { "expire", root.GetProperty("exp").GetInt32().ToString()}
                    };
                    return payloadvalues;
                }
            }
            else
            {
                Debug.WriteLine("Invalid JWT token format");
            }


            return null;

        }
        static string DecodeBase64(string base64String)
        {
            byte[] bytes = Convert.FromBase64String(base64String);
            return Encoding.UTF8.GetString(bytes);
        }
        static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        /// <summary>
        /// Saves Character details to /EveDash3/data/charinfo.txt
        /// </summary>
        /// <param name="name"></param>
        /// <param name="charid"></param>
        /// <param name="refreshtoken"></param>
        public static void SaveCharDetails(string name, string charid, string refreshtoken)
        {

            //MiscFunctions.TryGetSolutionDirectoryInfo()+
            //Debug.WriteLine(MiscFunctions.TryGetSolutionDirectoryInfo() + "/EveDash3/data/charinfo.txt");

            using (StreamWriter writer = new StreamWriter(MiscFunctions.TryGetSolutionDirectoryInfo() + "/EveDash3/data/charinfo.txt", false))
            {

                writer.WriteLine(name);
                writer.WriteLine(charid);
                writer.WriteLine(refreshtoken);

            }
            //Debug.WriteLine(System.IO.Directory.GetCurrentDirectory());

        }
        /// <summary>
        /// called by the refreshAccessTimer to refresh Access and refresh tokens every 20 or so minutes (19.5min)
        /// </summary>
        public static void refreshTokenPeriodic(object sender, ElapsedEventArgs e)
        {

            bool accessRecieved = getAccessFromRefreshToken(refreshToken).Result;
            if (accessRecieved)
            {
                SaveCharDetails(presentCharacter, presentCharacterID, refreshToken);
            }
            else
            {
                Debug.WriteLine("Unable to get new access and refresh tokens from previous token. New SSO log on is probably needed.");
            }



        }

        /// <summary>
        /// Gets Access Token from Refresh Token provided.
        /// Access Token is automatically updated to global store (see top of class)
        /// </summary>
        /// <param name="refreshtoken"></param>
        /// <returns>Returns False if Refresh token is somehow unable to be used. True if Access Token has successfully been retrieve</returns>
        public static async Task<bool> getAccessFromRefreshToken(string refreshtoken)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                var pval = new Dictionary<string, string>
                    {
                        { "grant_type", "refresh_token"},
                        { "refresh_token", refreshtoken},
                        { "client_id", clientID}
                    };

                var content = new FormUrlEncodedContent(pval);

                httpClient.DefaultRequestHeaders.Add("Host", "login.eveonline.com");
                //var content = new FormUrlEncodedContent(pval);
                HttpResponseMessage response = await httpClient.PostAsync("https://login.eveonline.com/v2/oauth/token", content);
                var t = await content.ReadAsStringAsync();
                //Debug.WriteLine(t);
                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Request successful. Response:");
                    Console.WriteLine(responseContent);
                    using (JsonDocument payloadparse = JsonDocument.Parse(responseContent))
                    {
                        // Access JSON properties
                        JsonElement root = payloadparse.RootElement;

                        //check payload for valid vals


                        //Debug.WriteLine($"charID: {root.GetProperty("sub").GetString().Split(':')[2].GetType()}");
                        //Debug.WriteLine($"expire: {root.GetProperty("exp").GetInt32().ToString}");

                        refreshToken = root.GetProperty("refresh_token").GetString().ToString();
                        accessToken = root.GetProperty("access_token").GetString().ToString();

                    }
                    return true;
                }
                else
                {
                    Console.WriteLine("Request failed. Status code: " + response.StatusCode);
                    return false;
                }
            }

        }



    }
}
