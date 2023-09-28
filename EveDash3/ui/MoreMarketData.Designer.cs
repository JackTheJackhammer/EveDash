
namespace EveDash3.ui
{
    partial class MoreMarketData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateSSOKeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDatabaseValuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marketBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StaticTitleTab = new System.Windows.Forms.TabControl();
            this.GraphTab = new System.Windows.Forms.TabPage();
            this.volumeplot = new ScottPlot.FormsPlot();
            this.stochasticOscillator = new ScottPlot.FormsPlot();
            this.PricePlot = new ScottPlot.FormsPlot();
            this.tabletab = new System.Windows.Forms.TabPage();
            this.MenuStrip.SuspendLayout();
            this.StaticTitleTab.SuspendLayout();
            this.GraphTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.tabToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(1136, 24);
            this.MenuStrip.TabIndex = 2;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeCharacterToolStripMenuItem,
            this.updateSSOKeysToolStripMenuItem,
            this.updateDatabaseValuesToolStripMenuItem});
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.updateToolStripMenuItem.Text = "Update";
            // 
            // ChangeCharacterToolStripMenuItem
            // 
            this.ChangeCharacterToolStripMenuItem.Name = "ChangeCharacterToolStripMenuItem";
            this.ChangeCharacterToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.ChangeCharacterToolStripMenuItem.Text = "Change Character";
            // 
            // updateSSOKeysToolStripMenuItem
            // 
            this.updateSSOKeysToolStripMenuItem.Name = "updateSSOKeysToolStripMenuItem";
            this.updateSSOKeysToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.updateSSOKeysToolStripMenuItem.Text = "Update SSO Keys ";
            // 
            // updateDatabaseValuesToolStripMenuItem
            // 
            this.updateDatabaseValuesToolStripMenuItem.Name = "updateDatabaseValuesToolStripMenuItem";
            this.updateDatabaseValuesToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.updateDatabaseValuesToolStripMenuItem.Text = "Update Database Values";
            // 
            // tabToolStripMenuItem
            // 
            this.tabToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marketBrowserToolStripMenuItem});
            this.tabToolStripMenuItem.Name = "tabToolStripMenuItem";
            this.tabToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.tabToolStripMenuItem.Text = "Tabs";
            // 
            // marketBrowserToolStripMenuItem
            // 
            this.marketBrowserToolStripMenuItem.Name = "marketBrowserToolStripMenuItem";
            this.marketBrowserToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.marketBrowserToolStripMenuItem.Text = "Market Browser";
            // 
            // StaticTitleTab
            // 
            this.StaticTitleTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StaticTitleTab.Controls.Add(this.GraphTab);
            this.StaticTitleTab.Controls.Add(this.tabletab);
            this.StaticTitleTab.Location = new System.Drawing.Point(12, 19);
            this.StaticTitleTab.Name = "StaticTitleTab";
            this.StaticTitleTab.SelectedIndex = 0;
            this.StaticTitleTab.Size = new System.Drawing.Size(1112, 666);
            this.StaticTitleTab.TabIndex = 3;
            // 
            // GraphTab
            // 
            this.GraphTab.Controls.Add(this.volumeplot);
            this.GraphTab.Controls.Add(this.stochasticOscillator);
            this.GraphTab.Controls.Add(this.PricePlot);
            this.GraphTab.Location = new System.Drawing.Point(4, 22);
            this.GraphTab.Name = "GraphTab";
            this.GraphTab.Padding = new System.Windows.Forms.Padding(3);
            this.GraphTab.Size = new System.Drawing.Size(1104, 640);
            this.GraphTab.TabIndex = 0;
            this.GraphTab.Text = "Graphs";
            this.GraphTab.UseVisualStyleBackColor = true;
            // 
            // volumeplot
            // 
            this.volumeplot.Location = new System.Drawing.Point(6, 329);
            this.volumeplot.Name = "volumeplot";
            this.volumeplot.Size = new System.Drawing.Size(1092, 137);
            this.volumeplot.TabIndex = 2;
            this.volumeplot.Load += new System.EventHandler(this.volumeplot_Load_1);
            // 
            // stochasticOscillator
            // 
            this.stochasticOscillator.Location = new System.Drawing.Point(6, 458);
            this.stochasticOscillator.Name = "stochasticOscillator";
            this.stochasticOscillator.Size = new System.Drawing.Size(1092, 137);
            this.stochasticOscillator.TabIndex = 1;
            this.stochasticOscillator.Load += new System.EventHandler(this.volumePlot_load);
            // 
            // PricePlot
            // 
            this.PricePlot.Location = new System.Drawing.Point(6, 6);
            this.PricePlot.Name = "PricePlot";
            this.PricePlot.Size = new System.Drawing.Size(1092, 333);
            this.PricePlot.TabIndex = 0;
            this.PricePlot.Load += new System.EventHandler(this.PricePlot_Load);
            // 
            // tabletab
            // 
            this.tabletab.Location = new System.Drawing.Point(4, 22);
            this.tabletab.Name = "tabletab";
            this.tabletab.Size = new System.Drawing.Size(1104, 544);
            this.tabletab.TabIndex = 1;
            this.tabletab.Text = "Tables";
            this.tabletab.UseVisualStyleBackColor = true;
            // 
            // MoreMarketData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 705);
            this.Controls.Add(this.StaticTitleTab);
            this.Controls.Add(this.MenuStrip);
            this.Name = "MoreMarketData";
            this.Text = "MoreMarketData";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.StaticTitleTab.ResumeLayout(false);
            this.GraphTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeCharacterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateSSOKeysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDatabaseValuesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marketBrowserToolStripMenuItem;
        private System.Windows.Forms.TabControl StaticTitleTab;
        private System.Windows.Forms.TabPage GraphTab;
        private System.Windows.Forms.TabPage tabletab;
        private ScottPlot.FormsPlot PricePlot;
        private ScottPlot.FormsPlot stochasticOscillator;
        private ScottPlot.FormsPlot volumeplot;
    }
}