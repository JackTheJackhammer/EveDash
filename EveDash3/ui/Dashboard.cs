using EveDash3.backend;
using EveDash3.backend.api.sql;
using EveDash3.backend.httpclient;
using EveDash3.backend.sso;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;
using EveDash3.ui;
namespace UIHandler
{
    /// <summary>
    /// This is the Class for the Main window.
    /// Unless you are creating pop-ups, you will be referencing this class and/or its tabs
    /// </summary>
    public partial class DashboardWindow : Form
    {

        // Human Defined Variables

        bool portraitToggle = true; // if we want to show the portrait

        public DashboardWindow()
        {

            InitializeComponent();
            UiUpdateHandler.dashboardWindow = this;
            UpdateWindow();
        }
        public void UpdateWindow()
        {
            UpdateCharacterBox();

            UpdateFinanceBox();
        }
        public async Task UpdateCharacterBox()
        {
            if (SSO_Handler.presentCharacter == "")
            {
                Debug.Write("No Character Loaded!");
                SSO_Handler.SendInitialAuth();
            }

            //update name

            NameLabel.Text = SSO_Handler.presentCharacter;

            //get corporation 

            var charresponse = await LocalWebClient.client.GetAsync($"https://esi.evetech.net/latest/characters/{SSO_Handler.presentCharacterID}/?datasource=tranquility");

            var charresponseStr = await charresponse.Content.ReadAsStringAsync();

            string corpid;

            using (JsonDocument doc = JsonDocument.Parse(charresponseStr))
            {
                // Access JSON properties
                JsonElement root = doc.RootElement;

                corpid = root.GetProperty("corporation_id").GetInt32().ToString();
            }

            var corpresponse = await LocalWebClient.client.GetAsync($"https://esi.evetech.net/latest/corporations/{corpid}/?datasource=tranquility");
            var corpresponseStr = await corpresponse.Content.ReadAsStringAsync();
            using (JsonDocument doc = JsonDocument.Parse(corpresponseStr))
            {
                // Access JSON properties
                JsonElement root = doc.RootElement;

                Corporationlabel.Text = root.GetProperty("name").GetString();
            }

            var locresponse = await LocalWebClient.client.GetAsync($"https://esi.evetech.net/latest/characters/{SSO_Handler.presentCharacterID}/location/?datasource=tranquility&token={SSO_Handler.accessToken}");
            var locresponsestr = await locresponse.Content.ReadAsStringAsync();
            using (JsonDocument doc = JsonDocument.Parse(locresponsestr))
            {
                // Access JSON properties
                JsonElement root = doc.RootElement;
                Debug.WriteLine(locresponsestr);
                Debug.WriteLine($"test {root.GetProperty("station_id").GetInt32()}");

                LocationLabel.Text = "FIX";// FIX SQLHandler.LegacyQueryevesde($"SELECT stationName FROM stastations WHERE (stationID = {root.GetProperty("station_id").GetInt32().ToString()})")[0][0].ToString();


            } //crossrefrence with sde database
            UpdatePortrait();

        }

        private class LPEntry
        {
            public string CorpName { get; set; }
            public string Amount { get; set; }

        }
        public async Task UpdateFinanceBox()
        {



            //get isk first
            var walletresponse = await LocalWebClient.client.GetAsync($"https://esi.evetech.net/latest/characters/{SSO_Handler.presentCharacterID}/wallet/?datasource=tranquility&token={SSO_Handler.accessToken}");
            float personalIskAmt = float.Parse(await walletresponse.Content.ReadAsStringAsync());

            ISKCounter.Text = $"{personalIskAmt.ToString("n")} ISK";

            //get corp id
            var charresponse = await LocalWebClient.client.GetAsync($"https://esi.evetech.net/latest/characters/{SSO_Handler.presentCharacterID}/?datasource=tranquility");

            var charresponseStr = await charresponse.Content.ReadAsStringAsync();

            string corpid;

            using (JsonDocument doc = JsonDocument.Parse(charresponseStr))
            {
                // Access JSON properties
                JsonElement root = doc.RootElement;

                corpid = root.GetProperty("corporation_id").GetInt32().ToString();
            }
            var corpwalletresponse = await LocalWebClient.client.GetAsync($"https://esi.evetech.net/latest/corporations/{corpid}/wallets/?datasource=tranquility&token={SSO_Handler.accessToken}");
            float corpIskAmt;
            using (JsonDocument doc = JsonDocument.Parse(await corpwalletresponse.Content.ReadAsStringAsync()))
            {
                // Access JSON properties
                JsonElement root = doc.RootElement;
                //Debug.WriteLine($"rooot {root[0].GetProperty("balance").GetString()}");
                //corpid = root.GetProperty("corporation_id").GetInt32().ToString();
                if (!corpwalletresponse.IsSuccessStatusCode)
                {
                    CorpIskLabel.Text = "Not Available";
                    TotalIskLabel.Text = personalIskAmt.ToString("n") + " ISK";
                }
                else
                {
                    corpIskAmt = float.Parse(root[0].GetProperty("balance").ToString());
                    CorpIskLabel.Text = $"{corpIskAmt.ToString("n")} ISK";
                    TotalIskLabel.Text = (corpIskAmt + personalIskAmt).ToString("n") + " ISK";
                }
                
            }

            

            /// LP ///
            var lpresponse = await LocalWebClient.client.GetAsync($"https://esi.evetech.net/latest/characters/{SSO_Handler.presentCharacterID}/loyalty/points/?datasource=tranquility&token={SSO_Handler.accessToken}");
            var lpresponseStr = await lpresponse.Content.ReadAsStringAsync();


            var EntryList = new BindingList<LPEntry> { };
            using (JsonDocument doc = JsonDocument.Parse(lpresponseStr))
            {
                // Access JSON properties
                JsonElement root = doc.RootElement;
                for(int i=0; i < root.GetArrayLength(); i++)
                {

                    var corpname = "FIX"; // FIX SQLHandler.LegacyQueryevesde($"SELECT itemName FROM evesde.invuniquenames WHERE (itemID = {root[i].GetProperty("corporation_id").GetInt32().ToString()})")[0][0];
                    EntryList.Add(new LPEntry { CorpName = corpname.ToString(),  Amount = root[i].GetProperty("loyalty_points").GetInt32().ToString("n")});
                    //tableData.Add(root[i].GetProperty("corporation_id").ToString(), root[i].GetProperty("loyalty_points").ToString());
                }

            }
            LPTable.DataSource = EntryList;
            LPTable.Refresh();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Dashboard_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            Debug.WriteLine("groupbox1");
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Called when update is clicked in the Menu Bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        /// <summary>
        /// Called when update is clicked in the Menu Bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateSSOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SSO_Handler.SendInitialAuth();
        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            portraitToggle = !portraitToggle;
            UpdatePortrait();
        }
        async Task UpdatePortrait()
        {

            //This should be in its own function

            if (portraitToggle)
            {
                //DEBUG, PLACEHOLDER
                // REPLACE BELOW WITH ACTUAL SOURCED IMAGE FROM API, 128x128 IMAGE
                try // this try - catch hasn't been tested!
                {
                    //see if the image actually exists
                    //get image link from server
                    //https://esi.evetech.net/latest/characters/2119735039/portrait/?datasource=tranquility
                    if (File.Exists(MiscFunctions.TryGetSolutionDirectoryInfo() + "/EveDash3/ui/img/portrait" + SSO_Handler.presentCharacterID.ToString()))
                    {
                        Debug.WriteLine("Portrait File Exists. Will not request new one");
                    }
                    else
                    {


                        var response = await LocalWebClient.client.GetAsync($"https://esi.evetech.net/latest/characters/{SSO_Handler.presentCharacterID}/portrait/?datasource=tranquility");
                        var responcestr = await response.Content.ReadAsStringAsync();
                        string imguri;
                        using (JsonDocument doc = JsonDocument.Parse(responcestr))
                        {
                            // Access JSON properties
                            JsonElement root = doc.RootElement;
                            imguri = root.GetProperty("px128x128").GetString();

                        }

                        var imgresponse = await LocalWebClient.client.GetAsync(imguri);

                        string filepath = MiscFunctions.TryGetSolutionDirectoryInfo() + "/EveDash3/ui/img/portrait" + SSO_Handler.presentCharacterID.ToString();

                        using (Stream imageStream = await imgresponse.Content.ReadAsStreamAsync())
                        {
                            using (FileStream fileStream = File.Create(filepath))
                            {
                                await imageStream.CopyToAsync(fileStream);
                            }

                            Console.WriteLine("Image saved to: " + filepath);
                        }

                    }

                    PortraitBox.Image = Image.FromFile(MiscFunctions.TryGetSolutionDirectoryInfo() + "/EveDash3/ui/img/portrait" + SSO_Handler.presentCharacterID.ToString());


                }
                catch (Exception e)
                {
                    //if not, throw the placeholder on up
                    portraitToggle = false;
                    PortraitBox.Image = Image.FromFile(MiscFunctions.TryGetSolutionDirectoryInfo() + "/EveDash3/ui/img/portrait/emptyPortrait.png");

                }

                //get current portrait
            }
            else
            {
                //if no portrait, use placeholder
                PortraitBox.Image = Image.FromFile(MiscFunctions.TryGetSolutionDirectoryInfo() + "/EveDash3/ui/img/portrait/emptyPortrait.png");
            }
        }

        private void groupBox3_Enter_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void label1_Click_4(object sender, EventArgs e)
        {

        }

        private void LPTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void marketBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarketBrowser marketBrowser = new MarketBrowser();
            marketBrowser.Show();
        }

        

    }


}
