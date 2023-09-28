using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Data;
using System.Net.Http;
using EveDash3.backend.api.sql;
using EveDash3.backend.httpclient;
using EveDash3.backend;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.Json;
namespace EveDash3.backend.api
{
    /// <summary>
    /// creates temporary tables for program function
    /// 
    /// DONT FORGET TO DROP ALL TABLES AT END
    /// 
    /// </summary>
    public static class PrecomputedValuesGenerator
    {
        public static int marketerAPIRequestsLeft; //impliment me!

        //Does this count as MULTITHREADING?
        private static async Task distributedAsk(List<string> packages, string regionidlimit)
        {
            string typeidquery;
            typeidquery = String.Join(",", packages.ToArray());
            Debug.WriteLine($"query : {typeidquery}");
            var postResponse = await LocalWebClient.client.GetAsync($"https://api.evemarketer.com/ec/marketstat/json?typeid={typeidquery}&regionlimit={regionidlimit}");

            var postResponseStr = await postResponse.Content.ReadAsStringAsync();

            Debug.WriteLine(postResponseStr);
            using (JsonDocument doc = JsonDocument.Parse(postResponseStr))
            {
                // Access JSON properties
                JsonElement root = doc.RootElement;
                //LocationLabel.Text = SQLHandler.LegacyQueryevesde($"SELECT stationName FROM stastations WHERE (stationID = {root.GetProperty("station_id").GetInt32().ToString()})")[0][0].ToString();
                for (int i = 0; i < root.GetArrayLength(); i++)
                {

                    int id = Int32.Parse(root[i].GetProperty("buy").GetProperty("forQuery").GetProperty("types")[0].GetRawText());
                    double buyavg = Double.Parse(root[i].GetProperty("buy").GetProperty("avg").GetRawText());
                    double sellavg = Double.Parse(root[i].GetProperty("sell").GetProperty("avg").GetRawText());

                    Int64 sellvolume = Int64.Parse(root[i].GetProperty("sell").GetProperty("volume").GetRawText());
                    Int64 buyvolume = Int64.Parse(root[i].GetProperty("buy").GetProperty("volume").GetRawText());
                    SQLHandler.QueryWithoutReturn($@"
                            INSERT INTO marketdata.quickpricereference (type_id, buyavg, sellavg, sellvolume, buyvolume)
                            VALUES ({id}, {buyavg}, {sellavg}, {sellvolume}, {buyvolume});");
                }


            } 
            
        }
        public static void UpdateQuickPriceReferenceTable(string regionidlimit= "10000002")
        {

            //DialogResult dialogResult = MessageBox.Show("Don't do this too often. Maybe once an Hour", "Get Latest Prices for Reference Table?", MessageBoxButtons.YesNo);
            long now = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            long lastupdated = long.Parse(SQLHandler.QueryAsDtDB("SELECT value FROM public.metadata where datatype = 'quickreferencelastupdate';", "marketdb").Rows[0][0].ToString());
            if (now - lastupdated > 3600) //once every hour
            {
                DataTable sqlAllTypeIDs = SQLHandler.QueryAsDtDB("SELECT typeID FROM evesde.invTypes where marketGroupID is not null;", "evesde");
                List<string> allTypeIDs = new List<string> { };
                foreach (DataRow row in sqlAllTypeIDs.Rows)
                {
                    allTypeIDs.Add(row[0].ToString());
                }
                SQLHandler.QueryWithoutReturn("TRUNCATE marketdata.quickpricereference");
                List<List<string>> partitions = allTypeIDs.partition(200);//only 200 type ids in aa request allowed
                List<Task> threads = new List<Task> { };
                foreach (List<string> packages in partitions)
                {

                    Task Thread = distributedAsk(packages, regionidlimit);
                    threads.Add(Thread);
                    //Thread.Start();
                    

                }
                SQLHandler.QueryWithoutReturn("UPDATE public.metadata SET value = 3 WHERE datatype = 'quickreferencelastupdate';");
            }
            return;
            
           
        }



    }
}
