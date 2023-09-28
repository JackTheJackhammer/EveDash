using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EveDash3.backend;
using EveDash3.backend.api.sql;
using EveDash3.backend.httpclient;
using EveDash3.backend.sso;
using System.ComponentModel;
using System.Diagnostics;

namespace EveDash3.ui
{
    public partial class MarketBrowser : Form
    {

        public string CurrentSelectedItemID;

        public Dictionary<string, string> filters;

        public MarketBrowser()
        {
            InitializeComponent();
            //itemBrowser.NodeMouseClick += itemBrowser_NodeMouseClick;
            itemBrowser.AfterSelect += itemBrowser_NodeMouseClick;
            SearchTable.CellClick += SearchTable_CellClick;
            itemBrowserload();
        }

        private void itemBrowser_NodeMouseClick(object sender, TreeViewEventArgs e)
        {

            TreeNode clickedNode = e.Node;
            // Now you can work with the clicked node.
            Debug.WriteLine($"node {clickedNode.Tag}");
            BindingList<SearchEntry> SearchTerms = new BindingList<SearchEntry> { };
            if (clickedNode.Tag.ToString().Split(':')[0] == "1")
            {
                //clickedNode.Nodes
                foreach (TreeNode node in clickedNode.Nodes)
                {
                    Debug.WriteLine(node.Text.Split(':'));
                    bool item;
                    if(node.Tag.ToString().Split(':')[0] == "0") { item = true; } else { item = false; }
                    SearchTerms.Add(new SearchEntry
                    {
                        Name = node.Text,
                        ID = node.Tag.ToString().Split(':')[1],
                        Description = "",
                        isitem = item
                    });
                }
                MarketTabs.SelectedTab = SearchTab;
                SetSearchBrowserItems(SearchTerms);

            }
            else
            {
                //this is an item, its now selected!
                UpdateSelectedItem(clickedNode.Tag.ToString().Split(':')[1]);
                //CurrentSelectedItemID = clickedNode.Tag.ToString().Split(':')[1];
            }

            
        }

        public async Task UpdateSelectedItem(string id)
        {
            CurrentSelectedItemID = id;

            //update ui elements

            TypeIDLabel.Text = id;
            SelectedItemNameLabel.Text = SQLHandler.QueryAsDtDB($"SELECT typeName FROM evesde.invtypes where typeID = {id};", "evesde").Rows[0][0].ToString();
            //get row from sql database
            DataTable pricedata = SQLHandler.QueryAsDtDB($"SELECT * FROM marketdata.quickpricereference where type_ID = {CurrentSelectedItemID}", "marketdb");

            buyLabel.Text = pricedata.Rows[0][1].ToString();
            sellLabel.Text = pricedata.Rows[0][2].ToString();

            sellvolumelbl.Text = pricedata.Rows[0][3].ToString();
            buyvolumelbl.Text = pricedata.Rows[0][4].ToString();

        }

        /// <summary>
        /// gets all taabs from a tabcontrol object
        /// </summary>
        /// <param name="control"></param>
        /// <param name="tabPages"></param>
        private void GetAllTabPagesRecursive(TreeNode control, List<TreeNode> tabPages)
        {
            //Debug.WriteLine($"control {control.Text} has {control.Controls.Count.ToString()} controls");
            foreach(TreeNode tab in control.Nodes)
            {
                tabPages.Add(tab);
                GetAllTabPagesRecursive(tab, tabPages);
            }

            /*
            if (control is TabPage tabPage)
            {

                tabPages.Add(tabPage);
            }
            else
            {
                foreach (Control childControl in control.Controls)
                {
                    GetAllTabPagesRecursive(childControl, tabPages);
                }
            }
            */
        }

        private void SearchTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = SearchTable.Rows[e.RowIndex];
            if ((bool) row.Cells[3].Value == true)
            {

                UpdateSelectedItem(row.Cells[1].Value.ToString());
            }
            else
            {
                //make it so that it opens the tab of the item you clickedd on the side, changing both the control and the search table

                List<TreeNode> allTabPages = new List<TreeNode>();
                foreach(TreeNode tab in itemBrowser.Nodes)
                {
                    GetAllTabPagesRecursive(tab, allTabPages);
                }
                Debug.WriteLine(row.Cells[0].Value);
                string rowname = row.Cells[0].Value.ToString();
                foreach (TreeNode tabPage in allTabPages)
                { 

                    if (tabPage.Text.ToString() == rowname)
                    {

                        itemBrowser.SelectedNode = tabPage;
                    }

                }
            }   

        }

        public void itemBrowserload()
        {

            DataTable itemgroups = SQLHandler.QueryAsDtDB("SELECT * FROM evesde.invmarketgroups;", "evesde");
            DataTable items = SQLHandler.QueryAsDtDB("SELECT * FROM evesde.invtypes WHERE (marketGroupID IS NOT NULL)","evesde");
            foreach (DataRow row in itemgroups.AsEnumerable())
            {
                //Debug.WriteLine(row[1].GetType());
                if (DBNull.Value.Equals(row[1]))
                {
                    var node = itemBrowser.Nodes.Add(row[2].ToString());
                    node.Tag = $"1:{row[0].ToString()}";
                    findChildren(row, itemgroups, node, items);
                }

            }

        }
        
        void findChildren(DataRow rowidm, DataTable itemgroups, TreeNode treeNode, DataTable items)
        {
            //Tags are the type of node (item or group, 0 or 1 respectively) and the ID or marketgroup of the node, seperated by a colon
            if (rowidm[5].ToString() == "True")
            {
                foreach (DataRow row in items.AsEnumerable())
                {
                    if (row[11].ToString() == rowidm[0].ToString())
                    {

                        var node = treeNode.Nodes.Add(row[2].ToString());
                        node.Tag = $"0:{row[0].ToString()}";
                    }
                }


            }
            else
            {
                //if this doesnt contain actual items
                foreach (DataRow row in itemgroups.AsEnumerable())
                {
                    if(row[1].ToString() == rowidm[0].ToString())
                    {
                        var node = treeNode.Nodes.Add(row[2].ToString());
                        node.Tag = $"1:{row[0].ToString()}";
                        findChildren(row, itemgroups, node, items);
                    }
                }
            }

        }
        public class SearchEntry
        {
            public string Name { get; set; }
            public string ID { get; set; }
            public string Description { get; set; }
            public bool isitem { get; set; }
            //public string Amount { get; set; }

        }

        /// <summary>
        /// updates search browser with items
        /// </summary>
        /// <param name="SearchTerms">Leave empty if you want all items</param>
        public void SetSearchBrowserItems(BindingList<SearchEntry> SearchTerms)
        {
            //filter using filters
            if (!SearchTerms.Any())
            {
                //grab a list of all items, filter using sql cause faster
                List<string> sqlfiltercmds = new List<string> { "SELECT * FROM evesde.invtypes WHERE marketGroupID IS NOT NULL " }; //join and between each list

                // if stack to add filters

                if (filters.ContainsKey("minPrice"))
                {
                    //sqlfiltercmds.Add("")
                }

            }
            SearchTable.DataSource = SearchTerms;
        }

        private void marketBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ChangeCharacterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SSO_Handler.SendInitialAuth();
        }

        private void updateSSOKeysToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Dash1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filters"> A dictionary with the property of the filter as the key (see switch) and the valaue as the value</param>
        public void UpdateSearchTable(Dictionary<string,string> filters)
        {
            /*
            string querystring = "";
            if (filters.ContainsKey("priceMax"))
            {
                
            }
            if (filters.ContainsKey("priceMin"))
            {

            }
            */
        }

        private void OpenDBEntryButton_Click(object sender, EventArgs e)
        {
            
            if(CurrentSelectedItemID != null)
            {
                DatabaseEntry entry = new DatabaseEntry(CurrentSelectedItemID);
                entry.Show();
            }
            
        }

        private void GraphButton_Click(object sender, EventArgs e)
        {
            if (CurrentSelectedItemID != null)
            {
                MoreMarketData moredatapanel = new MoreMarketData(CurrentSelectedItemID);
                moredatapanel.Show();

                moredatapanel.selecteditemID = CurrentSelectedItemID;
            }
        }

        private void itemBrowser_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
