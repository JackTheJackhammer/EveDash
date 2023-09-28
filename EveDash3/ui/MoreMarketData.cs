using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EveDash3.backend.api.sql;
using System.Data;
using System.Diagnostics;
using ScottPlot;

namespace EveDash3.ui
{
    public partial class MoreMarketData : Form
    {
        public string selecteditemID;
        string itemName;
        DataTable sqlget;
        FormsPlot[] linkedPlots;
        public MoreMarketData(string CurrentSelectedItemID)
        {
            sqlget = SQLHandler.QueryAsDtDB($"call marketdata.gethistprices({CurrentSelectedItemID}, 10000002);", "marketdb");
            //calculateMovingAverage
            InitializeComponent();
            selecteditemID = CurrentSelectedItemID;
            itemName = SQLHandler.QueryAsDtDB($"SELECT typeName FROM evesde.invtypes where typeID = {CurrentSelectedItemID};", "evesde").Rows[0][0].ToString();
            this.Text = $"Extended Market Data - {itemName}";
            linkedPlots = new FormsPlot[] { PricePlot, volumeplot, stochasticOscillator };
            foreach (var fp in linkedPlots)
                fp.AxesChanged += OnAxesChanged;
        }

        private void OnAxesChanged(object sender, EventArgs e)
        {
            FormsPlot changedPlot = (FormsPlot)sender;
            var newAxisLimits = changedPlot.Plot.GetAxisLimits();

            foreach (var fp in linkedPlots)
            {
                if (fp == changedPlot)
                    continue;

                // disable events briefly to avoid an infinite loop
                fp.Configuration.AxesChangedEventEnabled = false;
                fp.Plot.SetAxisLimits(xMin:newAxisLimits.XMin, xMax:newAxisLimits.XMax);
                
                fp.Render();
                fp.Configuration.AxesChangedEventEnabled = true;
            }
        }

        private void PricePlot_Load(object sender, EventArgs e)
        {
            //var sqlget = SQLHandler.QueryAsDtDB($"call marketdb.gethistprices({selecteditemID}, 10000002);", "marketdb");
            List<DateTime> dates = new List<DateTime> { };
            List<double> average = new List<double> { };
            List<double> high = new List<double> { };
            List<double> low = new List<double> { };

            foreach (DataRow row in sqlget.Rows)
            {

                dates.Add(DateTime.Parse(row[0].ToString()));
                average.Add(double.Parse(row[3].ToString()));
                high.Add(double.Parse(row[5].ToString()));
                low.Add(double.Parse(row[4].ToString()));
            }
            
            double[] xs = dates.Select(x => x.ToOADate()).ToArray();
            PricePlot.Plot.AddScatter(xs, average.ToArray(), markerSize: 0, markerShape:MarkerShape.none); //average price
            var highlowCleveland = PricePlot.Plot.AddClevelandDot(high.ToArray(), low.ToArray(), xs);
            highlowCleveland.SetPoint1Style(label: "High", markerShape: MarkerShape.triDown) ;
            highlowCleveland.SetPoint2Style(label: "Low", markerShape: MarkerShape.triUp);
            


            PricePlot.Plot.Style(Style.Gray1);


            PricePlot.Plot.XAxis.DateTimeFormat(true);
            //PricePlot.Plot.Style(figureBackground: Color.Black, dataBackground: Color.White);
            PricePlot.Refresh();

        }

        private void volumePlot_load(object sender, EventArgs e)
        {
            List<DateTime> dates = new List<DateTime> { };
            List<double> volume = new List<double> { };
            foreach (DataRow row in sqlget.Rows)
            {

                dates.Add(DateTime.Parse(row[2].ToString()));
                Debug.WriteLine($"volume : {row[6].ToString()}");
                volume.Add(double.Parse(row[6].ToString()));

            }
            double[] xs = dates.Select(x => x.ToOADate()).ToArray();
            volumeplot.Plot.AddBar(volume.ToArray(), xs);
            volumeplot.Plot.XAxis.DateTimeFormat(true);

            volumeplot.Plot.SetAxisLimits(yMin: 0);
            
            volumeplot.Plot.Style(Style.Gray1);
        }
        //stochasticOscillator
        private void volumeplot_Load_1(object sender, EventArgs e)
        {

            
        }
    }   
}
