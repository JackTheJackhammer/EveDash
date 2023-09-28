
namespace EveDash3.ui
{
    partial class MarketBrowser
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
            this.StaticTitleTab = new System.Windows.Forms.TabControl();
            this.MarketBrowserTab = new System.Windows.Forms.TabPage();
            this.GraphButton = new System.Windows.Forms.Button();
            this.OpenDBEntryButton = new System.Windows.Forms.Button();
            this.IconPicture = new System.Windows.Forms.PictureBox();
            this.MarketTabs = new System.Windows.Forms.TabControl();
            this.BuyPAge = new System.Windows.Forms.TabPage();
            this.BuyTable = new System.Windows.Forms.DataGridView();
            this.SellPage = new System.Windows.Forms.TabPage();
            this.SellTable = new System.Windows.Forms.DataGridView();
            this.SearchTab = new System.Windows.Forms.TabPage();
            this.SearchTable = new System.Windows.Forms.DataGridView();
            this.FiltersBox = new System.Windows.Forms.GroupBox();
            this.resetItemBrowser = new System.Windows.Forms.Button();
            this.itemBrowser = new System.Windows.Forms.TreeView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.QTYMin = new System.Windows.Forms.NumericUpDown();
            this.QTYMax = new System.Windows.Forms.NumericUpDown();
            this.Dash1 = new System.Windows.Forms.Label();
            this.PriceMinInput = new System.Windows.Forms.NumericUpDown();
            this.PriceMaxInput = new System.Windows.Forms.NumericUpDown();
            this.LocationCheck = new System.Windows.Forms.CheckBox();
            this.QuantityBox = new System.Windows.Forms.CheckBox();
            this.PriceCheck = new System.Windows.Forms.CheckBox();
            this.SelectedItemBox = new System.Windows.Forms.GroupBox();
            this.TypeIDLabel = new System.Windows.Forms.Label();
            this.weekmAVGBx = new System.Windows.Forms.GroupBox();
            this.BuyAverageBx = new System.Windows.Forms.GroupBox();
            this.monthmAVGBx = new System.Windows.Forms.GroupBox();
            this.SellAverageBx = new System.Windows.Forms.GroupBox();
            this.SellVolumeBx = new System.Windows.Forms.GroupBox();
            this.SelectedItemNameLabel = new System.Windows.Forms.Label();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateSSOKeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marketBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buyLabel = new System.Windows.Forms.Label();
            this.sellLabel = new System.Windows.Forms.Label();
            this.sellvolumelbl = new System.Windows.Forms.Label();
            this.mAVGMonthLabel = new System.Windows.Forms.Label();
            this.weekmAVGLabel = new System.Windows.Forms.Label();
            this.BuyVolumeBx = new System.Windows.Forms.GroupBox();
            this.buyvolumelbl = new System.Windows.Forms.Label();
            this.StaticTitleTab.SuspendLayout();
            this.MarketBrowserTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPicture)).BeginInit();
            this.MarketTabs.SuspendLayout();
            this.BuyPAge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BuyTable)).BeginInit();
            this.SellPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SellTable)).BeginInit();
            this.SearchTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchTable)).BeginInit();
            this.FiltersBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QTYMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QTYMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceMinInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceMaxInput)).BeginInit();
            this.SelectedItemBox.SuspendLayout();
            this.weekmAVGBx.SuspendLayout();
            this.BuyAverageBx.SuspendLayout();
            this.monthmAVGBx.SuspendLayout();
            this.SellAverageBx.SuspendLayout();
            this.SellVolumeBx.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.BuyVolumeBx.SuspendLayout();
            this.SuspendLayout();
            // 
            // StaticTitleTab
            // 
            this.StaticTitleTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StaticTitleTab.Controls.Add(this.MarketBrowserTab);
            this.StaticTitleTab.Location = new System.Drawing.Point(12, 33);
            this.StaticTitleTab.Name = "StaticTitleTab";
            this.StaticTitleTab.SelectedIndex = 0;
            this.StaticTitleTab.Size = new System.Drawing.Size(1112, 570);
            this.StaticTitleTab.TabIndex = 2;
            // 
            // MarketBrowserTab
            // 
            this.MarketBrowserTab.Controls.Add(this.GraphButton);
            this.MarketBrowserTab.Controls.Add(this.OpenDBEntryButton);
            this.MarketBrowserTab.Controls.Add(this.IconPicture);
            this.MarketBrowserTab.Controls.Add(this.MarketTabs);
            this.MarketBrowserTab.Controls.Add(this.FiltersBox);
            this.MarketBrowserTab.Controls.Add(this.SelectedItemBox);
            this.MarketBrowserTab.Location = new System.Drawing.Point(4, 22);
            this.MarketBrowserTab.Name = "MarketBrowserTab";
            this.MarketBrowserTab.Padding = new System.Windows.Forms.Padding(3);
            this.MarketBrowserTab.Size = new System.Drawing.Size(1104, 544);
            this.MarketBrowserTab.TabIndex = 0;
            this.MarketBrowserTab.Text = "Market Browser";
            this.MarketBrowserTab.UseVisualStyleBackColor = true;
            // 
            // GraphButton
            // 
            this.GraphButton.Location = new System.Drawing.Point(972, 34);
            this.GraphButton.Name = "GraphButton";
            this.GraphButton.Size = new System.Drawing.Size(121, 23);
            this.GraphButton.TabIndex = 5;
            this.GraphButton.Text = "Open Graphs";
            this.GraphButton.UseVisualStyleBackColor = true;
            this.GraphButton.Click += new System.EventHandler(this.GraphButton_Click);
            // 
            // OpenDBEntryButton
            // 
            this.OpenDBEntryButton.Location = new System.Drawing.Point(972, 6);
            this.OpenDBEntryButton.Name = "OpenDBEntryButton";
            this.OpenDBEntryButton.Size = new System.Drawing.Size(121, 23);
            this.OpenDBEntryButton.TabIndex = 4;
            this.OpenDBEntryButton.Text = "Open DB Entry";
            this.OpenDBEntryButton.UseVisualStyleBackColor = true;
            this.OpenDBEntryButton.Click += new System.EventHandler(this.OpenDBEntryButton_Click);
            // 
            // IconPicture
            // 
            this.IconPicture.Location = new System.Drawing.Point(866, 6);
            this.IconPicture.Name = "IconPicture";
            this.IconPicture.Size = new System.Drawing.Size(100, 100);
            this.IconPicture.TabIndex = 3;
            this.IconPicture.TabStop = false;
            // 
            // MarketTabs
            // 
            this.MarketTabs.Controls.Add(this.BuyPAge);
            this.MarketTabs.Controls.Add(this.SellPage);
            this.MarketTabs.Controls.Add(this.SearchTab);
            this.MarketTabs.Location = new System.Drawing.Point(240, 112);
            this.MarketTabs.Name = "MarketTabs";
            this.MarketTabs.SelectedIndex = 0;
            this.MarketTabs.Size = new System.Drawing.Size(858, 426);
            this.MarketTabs.TabIndex = 2;
            // 
            // BuyPAge
            // 
            this.BuyPAge.Controls.Add(this.BuyTable);
            this.BuyPAge.Location = new System.Drawing.Point(4, 22);
            this.BuyPAge.Name = "BuyPAge";
            this.BuyPAge.Padding = new System.Windows.Forms.Padding(3);
            this.BuyPAge.Size = new System.Drawing.Size(850, 400);
            this.BuyPAge.TabIndex = 0;
            this.BuyPAge.Text = "Buy";
            this.BuyPAge.UseVisualStyleBackColor = true;
            // 
            // BuyTable
            // 
            this.BuyTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BuyTable.Location = new System.Drawing.Point(7, 7);
            this.BuyTable.Name = "BuyTable";
            this.BuyTable.Size = new System.Drawing.Size(837, 387);
            this.BuyTable.TabIndex = 1;
            // 
            // SellPage
            // 
            this.SellPage.Controls.Add(this.SellTable);
            this.SellPage.Location = new System.Drawing.Point(4, 22);
            this.SellPage.Name = "SellPage";
            this.SellPage.Padding = new System.Windows.Forms.Padding(3);
            this.SellPage.Size = new System.Drawing.Size(850, 400);
            this.SellPage.TabIndex = 1;
            this.SellPage.Text = "Sell";
            this.SellPage.UseVisualStyleBackColor = true;
            // 
            // SellTable
            // 
            this.SellTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SellTable.Location = new System.Drawing.Point(7, 7);
            this.SellTable.Name = "SellTable";
            this.SellTable.Size = new System.Drawing.Size(837, 387);
            this.SellTable.TabIndex = 1;
            // 
            // SearchTab
            // 
            this.SearchTab.Controls.Add(this.SearchTable);
            this.SearchTab.Location = new System.Drawing.Point(4, 22);
            this.SearchTab.Name = "SearchTab";
            this.SearchTab.Padding = new System.Windows.Forms.Padding(3);
            this.SearchTab.Size = new System.Drawing.Size(850, 400);
            this.SearchTab.TabIndex = 2;
            this.SearchTab.Text = "Search ";
            this.SearchTab.UseVisualStyleBackColor = true;
            // 
            // SearchTable
            // 
            this.SearchTable.AllowUserToAddRows = false;
            this.SearchTable.AllowUserToDeleteRows = false;
            this.SearchTable.AllowUserToResizeColumns = false;
            this.SearchTable.AllowUserToResizeRows = false;
            this.SearchTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SearchTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchTable.Location = new System.Drawing.Point(7, 7);
            this.SearchTable.Name = "SearchTable";
            this.SearchTable.ReadOnly = true;
            this.SearchTable.RowHeadersVisible = false;
            this.SearchTable.Size = new System.Drawing.Size(837, 387);
            this.SearchTable.TabIndex = 0;
            // 
            // FiltersBox
            // 
            this.FiltersBox.Controls.Add(this.resetItemBrowser);
            this.FiltersBox.Controls.Add(this.itemBrowser);
            this.FiltersBox.Controls.Add(this.comboBox1);
            this.FiltersBox.Controls.Add(this.label1);
            this.FiltersBox.Controls.Add(this.QTYMin);
            this.FiltersBox.Controls.Add(this.QTYMax);
            this.FiltersBox.Controls.Add(this.Dash1);
            this.FiltersBox.Controls.Add(this.PriceMinInput);
            this.FiltersBox.Controls.Add(this.PriceMaxInput);
            this.FiltersBox.Controls.Add(this.LocationCheck);
            this.FiltersBox.Controls.Add(this.QuantityBox);
            this.FiltersBox.Controls.Add(this.PriceCheck);
            this.FiltersBox.Location = new System.Drawing.Point(6, 112);
            this.FiltersBox.Name = "FiltersBox";
            this.FiltersBox.Size = new System.Drawing.Size(228, 426);
            this.FiltersBox.TabIndex = 1;
            this.FiltersBox.TabStop = false;
            this.FiltersBox.Text = "Filters";
            // 
            // resetItemBrowser
            // 
            this.resetItemBrowser.Location = new System.Drawing.Point(147, 397);
            this.resetItemBrowser.Name = "resetItemBrowser";
            this.resetItemBrowser.Size = new System.Drawing.Size(75, 23);
            this.resetItemBrowser.TabIndex = 9;
            this.resetItemBrowser.Text = "Reset";
            this.resetItemBrowser.UseVisualStyleBackColor = true;
            // 
            // itemBrowser
            // 
            this.itemBrowser.Location = new System.Drawing.Point(6, 178);
            this.itemBrowser.Name = "itemBrowser";
            this.itemBrowser.Size = new System.Drawing.Size(215, 213);
            this.itemBrowser.TabIndex = 8;
            this.itemBrowser.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.itemBrowser_AfterSelect);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(74, 153);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "To";
            // 
            // QTYMin
            // 
            this.QTYMin.Location = new System.Drawing.Point(75, 109);
            this.QTYMin.Name = "QTYMin";
            this.QTYMin.Size = new System.Drawing.Size(120, 20);
            this.QTYMin.TabIndex = 6;
            // 
            // QTYMax
            // 
            this.QTYMax.Location = new System.Drawing.Point(75, 83);
            this.QTYMax.Name = "QTYMax";
            this.QTYMax.Size = new System.Drawing.Size(120, 20);
            this.QTYMax.TabIndex = 5;
            // 
            // Dash1
            // 
            this.Dash1.AutoSize = true;
            this.Dash1.Location = new System.Drawing.Point(201, 39);
            this.Dash1.Name = "Dash1";
            this.Dash1.Size = new System.Drawing.Size(20, 13);
            this.Dash1.TabIndex = 4;
            this.Dash1.Text = "To";
            this.Dash1.Click += new System.EventHandler(this.Dash1_Click);
            // 
            // PriceMinInput
            // 
            this.PriceMinInput.Location = new System.Drawing.Point(75, 48);
            this.PriceMinInput.Name = "PriceMinInput";
            this.PriceMinInput.Size = new System.Drawing.Size(120, 20);
            this.PriceMinInput.TabIndex = 3;
            // 
            // PriceMaxInput
            // 
            this.PriceMaxInput.Location = new System.Drawing.Point(75, 22);
            this.PriceMaxInput.Name = "PriceMaxInput";
            this.PriceMaxInput.Size = new System.Drawing.Size(120, 20);
            this.PriceMaxInput.TabIndex = 0;
            // 
            // LocationCheck
            // 
            this.LocationCheck.AutoSize = true;
            this.LocationCheck.Location = new System.Drawing.Point(6, 155);
            this.LocationCheck.Name = "LocationCheck";
            this.LocationCheck.Size = new System.Drawing.Size(67, 17);
            this.LocationCheck.TabIndex = 2;
            this.LocationCheck.Text = "Location";
            this.LocationCheck.UseVisualStyleBackColor = true;
            // 
            // QuantityBox
            // 
            this.QuantityBox.AutoSize = true;
            this.QuantityBox.Location = new System.Drawing.Point(6, 96);
            this.QuantityBox.Name = "QuantityBox";
            this.QuantityBox.Size = new System.Drawing.Size(65, 17);
            this.QuantityBox.TabIndex = 1;
            this.QuantityBox.Text = "Quantity";
            this.QuantityBox.UseVisualStyleBackColor = true;
            // 
            // PriceCheck
            // 
            this.PriceCheck.AutoSize = true;
            this.PriceCheck.Location = new System.Drawing.Point(6, 35);
            this.PriceCheck.Name = "PriceCheck";
            this.PriceCheck.Size = new System.Drawing.Size(50, 17);
            this.PriceCheck.TabIndex = 0;
            this.PriceCheck.Text = "Price";
            this.PriceCheck.UseVisualStyleBackColor = true;
            this.PriceCheck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // SelectedItemBox
            // 
            this.SelectedItemBox.Controls.Add(this.BuyVolumeBx);
            this.SelectedItemBox.Controls.Add(this.TypeIDLabel);
            this.SelectedItemBox.Controls.Add(this.weekmAVGBx);
            this.SelectedItemBox.Controls.Add(this.BuyAverageBx);
            this.SelectedItemBox.Controls.Add(this.monthmAVGBx);
            this.SelectedItemBox.Controls.Add(this.SellAverageBx);
            this.SelectedItemBox.Controls.Add(this.SellVolumeBx);
            this.SelectedItemBox.Controls.Add(this.SelectedItemNameLabel);
            this.SelectedItemBox.Location = new System.Drawing.Point(6, 6);
            this.SelectedItemBox.Name = "SelectedItemBox";
            this.SelectedItemBox.Size = new System.Drawing.Size(854, 100);
            this.SelectedItemBox.TabIndex = 0;
            this.SelectedItemBox.TabStop = false;
            this.SelectedItemBox.Text = "Selected Item";
            // 
            // TypeIDLabel
            // 
            this.TypeIDLabel.AutoSize = true;
            this.TypeIDLabel.Location = new System.Drawing.Point(7, 38);
            this.TypeIDLabel.Name = "TypeIDLabel";
            this.TypeIDLabel.Size = new System.Drawing.Size(78, 13);
            this.TypeIDLabel.TabIndex = 9;
            this.TypeIDLabel.Text = "None Selected";
            // 
            // weekmAVGBx
            // 
            this.weekmAVGBx.Controls.Add(this.weekmAVGLabel);
            this.weekmAVGBx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.weekmAVGBx.Location = new System.Drawing.Point(709, 57);
            this.weekmAVGBx.Name = "weekmAVGBx";
            this.weekmAVGBx.Size = new System.Drawing.Size(138, 39);
            this.weekmAVGBx.TabIndex = 8;
            this.weekmAVGBx.TabStop = false;
            this.weekmAVGBx.Text = "7d mAVG";
            // 
            // BuyAverageBx
            // 
            this.BuyAverageBx.Controls.Add(this.buyLabel);
            this.BuyAverageBx.Location = new System.Drawing.Point(421, 12);
            this.BuyAverageBx.Name = "BuyAverageBx";
            this.BuyAverageBx.Size = new System.Drawing.Size(138, 39);
            this.BuyAverageBx.TabIndex = 3;
            this.BuyAverageBx.TabStop = false;
            this.BuyAverageBx.Text = "Buy Average";
            // 
            // monthmAVGBx
            // 
            this.monthmAVGBx.Controls.Add(this.mAVGMonthLabel);
            this.monthmAVGBx.Location = new System.Drawing.Point(709, 12);
            this.monthmAVGBx.Name = "monthmAVGBx";
            this.monthmAVGBx.Size = new System.Drawing.Size(138, 39);
            this.monthmAVGBx.TabIndex = 7;
            this.monthmAVGBx.TabStop = false;
            this.monthmAVGBx.Text = "30d mAVG";
            // 
            // SellAverageBx
            // 
            this.SellAverageBx.Controls.Add(this.sellLabel);
            this.SellAverageBx.Location = new System.Drawing.Point(565, 12);
            this.SellAverageBx.Name = "SellAverageBx";
            this.SellAverageBx.Size = new System.Drawing.Size(138, 39);
            this.SellAverageBx.TabIndex = 2;
            this.SellAverageBx.TabStop = false;
            this.SellAverageBx.Text = "Sell Average";
            // 
            // SellVolumeBx
            // 
            this.SellVolumeBx.Controls.Add(this.sellvolumelbl);
            this.SellVolumeBx.Location = new System.Drawing.Point(565, 57);
            this.SellVolumeBx.Name = "SellVolumeBx";
            this.SellVolumeBx.Size = new System.Drawing.Size(138, 39);
            this.SellVolumeBx.TabIndex = 6;
            this.SellVolumeBx.TabStop = false;
            this.SellVolumeBx.Text = "SellVolume";
            // 
            // SelectedItemNameLabel
            // 
            this.SelectedItemNameLabel.AutoSize = true;
            this.SelectedItemNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedItemNameLabel.Location = new System.Drawing.Point(7, 20);
            this.SelectedItemNameLabel.Name = "SelectedItemNameLabel";
            this.SelectedItemNameLabel.Size = new System.Drawing.Size(114, 17);
            this.SelectedItemNameLabel.TabIndex = 0;
            this.SelectedItemNameLabel.Text = "None Selected";
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
            this.MenuStrip.TabIndex = 3;
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
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeCharacterToolStripMenuItem,
            this.updateSSOKeysToolStripMenuItem});
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.updateToolStripMenuItem.Text = "Update";
            // 
            // ChangeCharacterToolStripMenuItem
            // 
            this.ChangeCharacterToolStripMenuItem.Name = "ChangeCharacterToolStripMenuItem";
            this.ChangeCharacterToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.ChangeCharacterToolStripMenuItem.Text = "Change Character";
            this.ChangeCharacterToolStripMenuItem.Click += new System.EventHandler(this.ChangeCharacterToolStripMenuItem_Click);
            // 
            // updateSSOKeysToolStripMenuItem
            // 
            this.updateSSOKeysToolStripMenuItem.Name = "updateSSOKeysToolStripMenuItem";
            this.updateSSOKeysToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.updateSSOKeysToolStripMenuItem.Text = "Update SSO Keys ";
            this.updateSSOKeysToolStripMenuItem.Click += new System.EventHandler(this.updateSSOKeysToolStripMenuItem_Click);
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
            this.marketBrowserToolStripMenuItem.Click += new System.EventHandler(this.marketBrowserToolStripMenuItem_Click);
            // 
            // buyLabel
            // 
            this.buyLabel.AutoSize = true;
            this.buyLabel.Location = new System.Drawing.Point(7, 16);
            this.buyLabel.Name = "buyLabel";
            this.buyLabel.Size = new System.Drawing.Size(73, 13);
            this.buyLabel.TabIndex = 0;
            this.buyLabel.Text = "AverageLabel";
            // 
            // sellLabel
            // 
            this.sellLabel.AutoSize = true;
            this.sellLabel.Location = new System.Drawing.Point(7, 16);
            this.sellLabel.Name = "sellLabel";
            this.sellLabel.Size = new System.Drawing.Size(35, 13);
            this.sellLabel.TabIndex = 0;
            this.sellLabel.Text = "label2";
            // 
            // sellvolumelbl
            // 
            this.sellvolumelbl.AutoSize = true;
            this.sellvolumelbl.Location = new System.Drawing.Point(7, 16);
            this.sellvolumelbl.Name = "sellvolumelbl";
            this.sellvolumelbl.Size = new System.Drawing.Size(35, 13);
            this.sellvolumelbl.TabIndex = 0;
            this.sellvolumelbl.Text = "label2";
            // 
            // mAVGMonthLabel
            // 
            this.mAVGMonthLabel.AutoSize = true;
            this.mAVGMonthLabel.Location = new System.Drawing.Point(7, 16);
            this.mAVGMonthLabel.Name = "mAVGMonthLabel";
            this.mAVGMonthLabel.Size = new System.Drawing.Size(35, 13);
            this.mAVGMonthLabel.TabIndex = 0;
            this.mAVGMonthLabel.Text = "label2";
            // 
            // weekmAVGLabel
            // 
            this.weekmAVGLabel.AutoSize = true;
            this.weekmAVGLabel.Location = new System.Drawing.Point(10, 16);
            this.weekmAVGLabel.Name = "weekmAVGLabel";
            this.weekmAVGLabel.Size = new System.Drawing.Size(35, 13);
            this.weekmAVGLabel.TabIndex = 0;
            this.weekmAVGLabel.Text = "label2";
            // 
            // BuyVolumeBx
            // 
            this.BuyVolumeBx.Controls.Add(this.buyvolumelbl);
            this.BuyVolumeBx.Location = new System.Drawing.Point(421, 57);
            this.BuyVolumeBx.Name = "BuyVolumeBx";
            this.BuyVolumeBx.Size = new System.Drawing.Size(138, 39);
            this.BuyVolumeBx.TabIndex = 7;
            this.BuyVolumeBx.TabStop = false;
            this.BuyVolumeBx.Text = "Buy Volume";
            // 
            // buyvolumelbl
            // 
            this.buyvolumelbl.AutoSize = true;
            this.buyvolumelbl.Location = new System.Drawing.Point(7, 16);
            this.buyvolumelbl.Name = "buyvolumelbl";
            this.buyvolumelbl.Size = new System.Drawing.Size(35, 13);
            this.buyvolumelbl.TabIndex = 0;
            this.buyvolumelbl.Text = "label2";
            // 
            // MarketBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 609);
            this.Controls.Add(this.StaticTitleTab);
            this.Controls.Add(this.MenuStrip);
            this.Name = "MarketBrowser";
            this.Text = "Market Browser";
            this.StaticTitleTab.ResumeLayout(false);
            this.MarketBrowserTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IconPicture)).EndInit();
            this.MarketTabs.ResumeLayout(false);
            this.BuyPAge.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BuyTable)).EndInit();
            this.SellPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SellTable)).EndInit();
            this.SearchTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SearchTable)).EndInit();
            this.FiltersBox.ResumeLayout(false);
            this.FiltersBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QTYMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QTYMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceMinInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceMaxInput)).EndInit();
            this.SelectedItemBox.ResumeLayout(false);
            this.SelectedItemBox.PerformLayout();
            this.weekmAVGBx.ResumeLayout(false);
            this.weekmAVGBx.PerformLayout();
            this.BuyAverageBx.ResumeLayout(false);
            this.BuyAverageBx.PerformLayout();
            this.monthmAVGBx.ResumeLayout(false);
            this.monthmAVGBx.PerformLayout();
            this.SellAverageBx.ResumeLayout(false);
            this.SellAverageBx.PerformLayout();
            this.SellVolumeBx.ResumeLayout(false);
            this.SellVolumeBx.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.BuyVolumeBx.ResumeLayout(false);
            this.BuyVolumeBx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl StaticTitleTab;
        private System.Windows.Forms.TabPage MarketBrowserTab;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeCharacterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateSSOKeysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marketBrowserToolStripMenuItem;
        private System.Windows.Forms.TabControl MarketTabs;
        private System.Windows.Forms.TabPage BuyPAge;
        private System.Windows.Forms.TabPage SellPage;
        private System.Windows.Forms.TabPage SearchTab;
        private System.Windows.Forms.GroupBox FiltersBox;
        private System.Windows.Forms.GroupBox SelectedItemBox;
        private System.Windows.Forms.CheckBox PriceCheck;
        private System.Windows.Forms.Label Dash1;
        private System.Windows.Forms.NumericUpDown PriceMinInput;
        private System.Windows.Forms.NumericUpDown PriceMaxInput;
        private System.Windows.Forms.CheckBox LocationCheck;
        private System.Windows.Forms.CheckBox QuantityBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown QTYMin;
        private System.Windows.Forms.NumericUpDown QTYMax;
        private System.Windows.Forms.PictureBox IconPicture;
        private System.Windows.Forms.DataGridView BuyTable;
        private System.Windows.Forms.DataGridView SellTable;
        private System.Windows.Forms.DataGridView SearchTable;
        private System.Windows.Forms.Label SelectedItemNameLabel;
        private System.Windows.Forms.TreeView itemBrowser;
        private System.Windows.Forms.Button resetItemBrowser;
        private System.Windows.Forms.Button GraphButton;
        private System.Windows.Forms.Button OpenDBEntryButton;
        private System.Windows.Forms.Label TypeIDLabel;
        private System.Windows.Forms.GroupBox weekmAVGBx;
        private System.Windows.Forms.GroupBox BuyAverageBx;
        private System.Windows.Forms.GroupBox monthmAVGBx;
        private System.Windows.Forms.GroupBox SellAverageBx;
        private System.Windows.Forms.GroupBox SellVolumeBx;
        private System.Windows.Forms.Label weekmAVGLabel;
        private System.Windows.Forms.Label buyLabel;
        private System.Windows.Forms.Label mAVGMonthLabel;
        private System.Windows.Forms.Label sellLabel;
        private System.Windows.Forms.Label sellvolumelbl;
        private System.Windows.Forms.GroupBox BuyVolumeBx;
        private System.Windows.Forms.Label buyvolumelbl;
    }
}