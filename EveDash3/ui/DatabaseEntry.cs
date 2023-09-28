using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EveDash3.backend.api.sql;
using System.Windows.Forms;

namespace EveDash3.ui
{
    public partial class DatabaseEntry : Form
    {
        string id;
        string currentBPID;
        public DatabaseEntry(string type_id)
        {
            InitializeComponent();
            id = type_id;
            UpdateUI();
        }

        public void skillsload()
        {

            

        }
        public void UpdateUI()
        {
            //getsql
            DataTable sqlget = SQLHandler.QueryAsDtDB($"SELECT * FROM evesde.invtypes where typeID = {id};", "evesde");
            TypeIDLabel.Text = sqlget.Rows[0][0].ToString();
            ItemName.Text = sqlget.Rows[0][2].ToString();
            DescriptionLbl.Text = sqlget.Rows[0][3].ToString();
            Masslbl.Text = "Mass : " + sqlget.Rows[0][4].ToString() + " kg";
            volumelbl.Text = "Volume : " + sqlget.Rows[0][5].ToString() + " m3";
            CapacityLbl.Text = sqlget.Rows[0][6].ToString() + " m3";
            var sqlresult = SQLHandler.QueryAsDtDB($"SELECT typeID FROM evesde.industryactivityproducts where productTypeID = {id};", "evesde");
            if (sqlresult.Rows.Count != 0)
            {
                ProducedByLbl.Text = $"Produced by : {SQLHandler.TypeIDToName(sqlresult.Rows[0][0].ToString())}";
                currentBPID = sqlresult.Rows[0][0].ToString();
            }
            else
            {
                ProducedByLbl.Text = $"Produced by : NONE";
                currentBPID = null;
            }
            this.Text = $"Database Entry - {SQLHandler.TypeIDToName(id)}";


        }

        private void ProducedByLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(currentBPID != null)
            {
                DatabaseEntry entry = new DatabaseEntry(currentBPID);
                entry.Show();
            }
            
        }
    }
}
