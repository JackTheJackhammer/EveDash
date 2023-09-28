
namespace UIHandler
{
    /// <summary>
    /// Main Dashboard Class. All Methods that change the main dashboard tab will be called here.
    /// </summary>
    partial class DashboardWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardWindow));
            this.StaticTitleTab = new System.Windows.Forms.TabControl();
            this.DashboardTab = new System.Windows.Forms.TabPage();
            this.FinancePanelGroupBox = new System.Windows.Forms.GroupBox();
            this.LPBox = new System.Windows.Forms.GroupBox();
            this.LPTable = new System.Windows.Forms.DataGridView();
            this.TotalIskBox = new System.Windows.Forms.GroupBox();
            this.TotalIskLabel = new System.Windows.Forms.Label();
            this.CorpIskPanel = new System.Windows.Forms.GroupBox();
            this.CorpIskLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ISKCounter = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TransactionsGroupBox = new System.Windows.Forms.GroupBox();
            this.TradingItemsTable = new System.Windows.Forms.DataGridView();
            this.CharacterPanel = new System.Windows.Forms.GroupBox();
            this.CorporationBox = new System.Windows.Forms.GroupBox();
            this.Corporationlabel = new System.Windows.Forms.Label();
            this.LocationBox = new System.Windows.Forms.GroupBox();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.GroupBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.TogglePortraitButton = new System.Windows.Forms.Button();
            this.PortraitBox = new System.Windows.Forms.PictureBox();
            this.CurrentlyInvestedGroupBox = new System.Windows.Forms.GroupBox();
            this.TrackedItemsTable = new System.Windows.Forms.DataGridView();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateSSOKeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marketBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDatabaseValuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StaticTitleTab.SuspendLayout();
            this.DashboardTab.SuspendLayout();
            this.FinancePanelGroupBox.SuspendLayout();
            this.LPBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LPTable)).BeginInit();
            this.TotalIskBox.SuspendLayout();
            this.CorpIskPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.TransactionsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TradingItemsTable)).BeginInit();
            this.CharacterPanel.SuspendLayout();
            this.CorporationBox.SuspendLayout();
            this.LocationBox.SuspendLayout();
            this.nameBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PortraitBox)).BeginInit();
            this.CurrentlyInvestedGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackedItemsTable)).BeginInit();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // StaticTitleTab
            // 
            this.StaticTitleTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StaticTitleTab.Controls.Add(this.DashboardTab);
            this.StaticTitleTab.Location = new System.Drawing.Point(12, 27);
            this.StaticTitleTab.Name = "StaticTitleTab";
            this.StaticTitleTab.SelectedIndex = 0;
            this.StaticTitleTab.Size = new System.Drawing.Size(1112, 570);
            this.StaticTitleTab.TabIndex = 0;
            // 
            // DashboardTab
            // 
            this.DashboardTab.Controls.Add(this.FinancePanelGroupBox);
            this.DashboardTab.Controls.Add(this.groupBox2);
            this.DashboardTab.Controls.Add(this.TransactionsGroupBox);
            this.DashboardTab.Controls.Add(this.CharacterPanel);
            this.DashboardTab.Controls.Add(this.CurrentlyInvestedGroupBox);
            this.DashboardTab.Location = new System.Drawing.Point(4, 22);
            this.DashboardTab.Name = "DashboardTab";
            this.DashboardTab.Padding = new System.Windows.Forms.Padding(3);
            this.DashboardTab.Size = new System.Drawing.Size(1104, 544);
            this.DashboardTab.TabIndex = 0;
            this.DashboardTab.Text = "Dashboard";
            this.DashboardTab.UseVisualStyleBackColor = true;
            this.DashboardTab.Click += new System.EventHandler(this.Dashboard_Click);
            // 
            // FinancePanelGroupBox
            // 
            this.FinancePanelGroupBox.Controls.Add(this.LPBox);
            this.FinancePanelGroupBox.Controls.Add(this.TotalIskBox);
            this.FinancePanelGroupBox.Controls.Add(this.CorpIskPanel);
            this.FinancePanelGroupBox.Controls.Add(this.groupBox1);
            this.FinancePanelGroupBox.Location = new System.Drawing.Point(502, 7);
            this.FinancePanelGroupBox.Name = "FinancePanelGroupBox";
            this.FinancePanelGroupBox.Size = new System.Drawing.Size(457, 257);
            this.FinancePanelGroupBox.TabIndex = 0;
            this.FinancePanelGroupBox.TabStop = false;
            this.FinancePanelGroupBox.Text = "Finances";
            this.FinancePanelGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // LPBox
            // 
            this.LPBox.Controls.Add(this.LPTable);
            this.LPBox.Location = new System.Drawing.Point(262, 25);
            this.LPBox.Name = "LPBox";
            this.LPBox.Size = new System.Drawing.Size(189, 182);
            this.LPBox.TabIndex = 1;
            this.LPBox.TabStop = false;
            this.LPBox.Text = "Loyalty Points";
            // 
            // LPTable
            // 
            this.LPTable.AllowUserToAddRows = false;
            this.LPTable.AllowUserToDeleteRows = false;
            this.LPTable.AllowUserToResizeColumns = false;
            this.LPTable.AllowUserToResizeRows = false;
            this.LPTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LPTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.LPTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LPTable.Location = new System.Drawing.Point(6, 19);
            this.LPTable.Name = "LPTable";
            this.LPTable.RowHeadersVisible = false;
            this.LPTable.Size = new System.Drawing.Size(177, 157);
            this.LPTable.TabIndex = 3;
            this.LPTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LPTable_CellContentClick);
            // 
            // TotalIskBox
            // 
            this.TotalIskBox.Controls.Add(this.TotalIskLabel);
            this.TotalIskBox.Location = new System.Drawing.Point(6, 166);
            this.TotalIskBox.Name = "TotalIskBox";
            this.TotalIskBox.Size = new System.Drawing.Size(250, 41);
            this.TotalIskBox.TabIndex = 2;
            this.TotalIskBox.TabStop = false;
            this.TotalIskBox.Text = "Total (Not including Other Toons)";
            // 
            // TotalIskLabel
            // 
            this.TotalIskLabel.BackColor = System.Drawing.Color.Transparent;
            this.TotalIskLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TotalIskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalIskLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TotalIskLabel.Location = new System.Drawing.Point(3, 16);
            this.TotalIskLabel.Name = "TotalIskLabel";
            this.TotalIskLabel.Size = new System.Drawing.Size(244, 22);
            this.TotalIskLabel.TabIndex = 1;
            this.TotalIskLabel.Text = "9,000,000,000.00 ISK";
            this.TotalIskLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TotalIskLabel.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // CorpIskPanel
            // 
            this.CorpIskPanel.Controls.Add(this.CorpIskLabel);
            this.CorpIskPanel.Location = new System.Drawing.Point(9, 89);
            this.CorpIskPanel.Name = "CorpIskPanel";
            this.CorpIskPanel.Size = new System.Drawing.Size(250, 71);
            this.CorpIskPanel.TabIndex = 1;
            this.CorpIskPanel.TabStop = false;
            this.CorpIskPanel.Text = "Corporation Master Wallet";
            // 
            // CorpIskLabel
            // 
            this.CorpIskLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CorpIskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorpIskLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CorpIskLabel.Location = new System.Drawing.Point(3, 16);
            this.CorpIskLabel.Name = "CorpIskLabel";
            this.CorpIskLabel.Size = new System.Drawing.Size(244, 52);
            this.CorpIskLabel.TabIndex = 1;
            this.CorpIskLabel.Text = "9,000,000,000.00 ISK";
            this.CorpIskLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ISKCounter);
            this.groupBox1.Location = new System.Drawing.Point(9, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ISK";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // ISKCounter
            // 
            this.ISKCounter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ISKCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISKCounter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ISKCounter.Location = new System.Drawing.Point(3, 16);
            this.ISKCounter.Name = "ISKCounter";
            this.ISKCounter.Size = new System.Drawing.Size(244, 52);
            this.ISKCounter.TabIndex = 0;
            this.ISKCounter.Text = "9,000,000,000.00 ISK";
            this.ISKCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ISKCounter.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(965, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(133, 531);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter_1);
            // 
            // TransactionsGroupBox
            // 
            this.TransactionsGroupBox.Controls.Add(this.TradingItemsTable);
            this.TransactionsGroupBox.Location = new System.Drawing.Point(6, 270);
            this.TransactionsGroupBox.Name = "TransactionsGroupBox";
            this.TransactionsGroupBox.Size = new System.Drawing.Size(490, 268);
            this.TransactionsGroupBox.TabIndex = 1;
            this.TransactionsGroupBox.TabStop = false;
            this.TransactionsGroupBox.Text = "Transactions";
            this.TransactionsGroupBox.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // TradingItemsTable
            // 
            this.TradingItemsTable.AllowUserToDeleteRows = false;
            this.TradingItemsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TradingItemsTable.Location = new System.Drawing.Point(6, 19);
            this.TradingItemsTable.Name = "TradingItemsTable";
            this.TradingItemsTable.Size = new System.Drawing.Size(478, 243);
            this.TradingItemsTable.TabIndex = 0;
            // 
            // CharacterPanel
            // 
            this.CharacterPanel.Controls.Add(this.CorporationBox);
            this.CharacterPanel.Controls.Add(this.LocationBox);
            this.CharacterPanel.Controls.Add(this.nameBox);
            this.CharacterPanel.Controls.Add(this.TogglePortraitButton);
            this.CharacterPanel.Controls.Add(this.PortraitBox);
            this.CharacterPanel.Location = new System.Drawing.Point(6, 3);
            this.CharacterPanel.Name = "CharacterPanel";
            this.CharacterPanel.Size = new System.Drawing.Size(490, 261);
            this.CharacterPanel.TabIndex = 1;
            this.CharacterPanel.TabStop = false;
            this.CharacterPanel.Text = "Character";
            this.CharacterPanel.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // CorporationBox
            // 
            this.CorporationBox.Controls.Add(this.Corporationlabel);
            this.CorporationBox.Location = new System.Drawing.Point(300, 22);
            this.CorporationBox.Name = "CorporationBox";
            this.CorporationBox.Size = new System.Drawing.Size(154, 36);
            this.CorporationBox.TabIndex = 3;
            this.CorporationBox.TabStop = false;
            this.CorporationBox.Text = "Corporation";
            // 
            // Corporationlabel
            // 
            this.Corporationlabel.AutoSize = true;
            this.Corporationlabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Corporationlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Corporationlabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Corporationlabel.Location = new System.Drawing.Point(3, 16);
            this.Corporationlabel.Name = "Corporationlabel";
            this.Corporationlabel.Size = new System.Drawing.Size(69, 12);
            this.Corporationlabel.TabIndex = 0;
            this.Corporationlabel.Text = "CorporationBox";
            this.Corporationlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LocationBox
            // 
            this.LocationBox.Controls.Add(this.LocationLabel);
            this.LocationBox.Location = new System.Drawing.Point(140, 64);
            this.LocationBox.Name = "LocationBox";
            this.LocationBox.Size = new System.Drawing.Size(314, 36);
            this.LocationBox.TabIndex = 2;
            this.LocationBox.TabStop = false;
            this.LocationBox.Text = "Location";
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LocationLabel.Location = new System.Drawing.Point(3, 16);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(45, 12);
            this.LocationLabel.TabIndex = 0;
            this.LocationLabel.Text = "lorum Lup";
            this.LocationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LocationLabel.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // nameBox
            // 
            this.nameBox.Controls.Add(this.NameLabel);
            this.nameBox.Location = new System.Drawing.Point(140, 22);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(154, 36);
            this.nameBox.TabIndex = 1;
            this.nameBox.TabStop = false;
            this.nameBox.Text = "Name";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NameLabel.Location = new System.Drawing.Point(3, 16);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(45, 12);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "lorum Lup";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TogglePortraitButton
            // 
            this.TogglePortraitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TogglePortraitButton.Location = new System.Drawing.Point(59, 153);
            this.TogglePortraitButton.Name = "TogglePortraitButton";
            this.TogglePortraitButton.Size = new System.Drawing.Size(75, 23);
            this.TogglePortraitButton.TabIndex = 1;
            this.TogglePortraitButton.Text = "Toggle Portrait";
            this.TogglePortraitButton.UseVisualStyleBackColor = true;
            this.TogglePortraitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // PortraitBox
            // 
            this.PortraitBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PortraitBox.BackgroundImage")));
            this.PortraitBox.Location = new System.Drawing.Point(6, 19);
            this.PortraitBox.Name = "PortraitBox";
            this.PortraitBox.Size = new System.Drawing.Size(128, 128);
            this.PortraitBox.TabIndex = 0;
            this.PortraitBox.TabStop = false;
            // 
            // CurrentlyInvestedGroupBox
            // 
            this.CurrentlyInvestedGroupBox.Controls.Add(this.TrackedItemsTable);
            this.CurrentlyInvestedGroupBox.Location = new System.Drawing.Point(502, 270);
            this.CurrentlyInvestedGroupBox.Name = "CurrentlyInvestedGroupBox";
            this.CurrentlyInvestedGroupBox.Size = new System.Drawing.Size(457, 268);
            this.CurrentlyInvestedGroupBox.TabIndex = 1;
            this.CurrentlyInvestedGroupBox.TabStop = false;
            this.CurrentlyInvestedGroupBox.Text = "Item Positions";
            this.CurrentlyInvestedGroupBox.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // TrackedItemsTable
            // 
            this.TrackedItemsTable.AllowUserToDeleteRows = false;
            this.TrackedItemsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TrackedItemsTable.Location = new System.Drawing.Point(6, 19);
            this.TrackedItemsTable.Name = "TrackedItemsTable";
            this.TrackedItemsTable.Size = new System.Drawing.Size(439, 243);
            this.TrackedItemsTable.TabIndex = 1;
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
            this.MenuStrip.TabIndex = 1;
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
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // ChangeCharacterToolStripMenuItem
            // 
            this.ChangeCharacterToolStripMenuItem.Name = "ChangeCharacterToolStripMenuItem";
            this.ChangeCharacterToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.ChangeCharacterToolStripMenuItem.Text = "Change Character";
            this.ChangeCharacterToolStripMenuItem.Click += new System.EventHandler(this.updateSSOToolStripMenuItem_Click);
            // 
            // updateSSOKeysToolStripMenuItem
            // 
            this.updateSSOKeysToolStripMenuItem.Name = "updateSSOKeysToolStripMenuItem";
            this.updateSSOKeysToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.updateSSOKeysToolStripMenuItem.Text = "Update SSO Keys ";
            // 
            // tabToolStripMenuItem
            // 
            this.tabToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marketBrowserToolStripMenuItem});
            this.tabToolStripMenuItem.Name = "tabToolStripMenuItem";
            this.tabToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.tabToolStripMenuItem.Text = "Tabs";
            this.tabToolStripMenuItem.Click += new System.EventHandler(this.tabToolStripMenuItem_Click);
            // 
            // marketBrowserToolStripMenuItem
            // 
            this.marketBrowserToolStripMenuItem.Name = "marketBrowserToolStripMenuItem";
            this.marketBrowserToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.marketBrowserToolStripMenuItem.Text = "Market Browser";
            this.marketBrowserToolStripMenuItem.Click += new System.EventHandler(this.marketBrowserToolStripMenuItem_Click);
            // 
            // updateDatabaseValuesToolStripMenuItem
            // 
            this.updateDatabaseValuesToolStripMenuItem.Name = "updateDatabaseValuesToolStripMenuItem";
            this.updateDatabaseValuesToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.updateDatabaseValuesToolStripMenuItem.Text = "Update Database Values";
            // 
            // DashboardWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1136, 609);
            this.Controls.Add(this.StaticTitleTab);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "DashboardWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.StaticTitleTab.ResumeLayout(false);
            this.DashboardTab.ResumeLayout(false);
            this.FinancePanelGroupBox.ResumeLayout(false);
            this.LPBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LPTable)).EndInit();
            this.TotalIskBox.ResumeLayout(false);
            this.CorpIskPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.TransactionsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TradingItemsTable)).EndInit();
            this.CharacterPanel.ResumeLayout(false);
            this.CorporationBox.ResumeLayout(false);
            this.CorporationBox.PerformLayout();
            this.LocationBox.ResumeLayout(false);
            this.LocationBox.PerformLayout();
            this.nameBox.ResumeLayout(false);
            this.nameBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PortraitBox)).EndInit();
            this.CurrentlyInvestedGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TrackedItemsTable)).EndInit();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl StaticTitleTab;
        private System.Windows.Forms.TabPage DashboardTab;
        private System.Windows.Forms.GroupBox TransactionsGroupBox;
        private System.Windows.Forms.GroupBox CharacterPanel;
        private System.Windows.Forms.GroupBox CurrentlyInvestedGroupBox;
        private System.Windows.Forms.GroupBox FinancePanelGroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox CorpIskPanel;
        private System.Windows.Forms.Label ISKCounter;
        private System.Windows.Forms.Label CorpIskLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeCharacterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateSSOKeysToolStripMenuItem;
        private System.Windows.Forms.PictureBox PortraitBox;
        private System.Windows.Forms.Button TogglePortraitButton;
        private System.Windows.Forms.GroupBox CorporationBox;
        private System.Windows.Forms.Label Corporationlabel;
        private System.Windows.Forms.GroupBox LocationBox;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.GroupBox nameBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.GroupBox TotalIskBox;
        private System.Windows.Forms.Label TotalIskLabel;
        private System.Windows.Forms.GroupBox LPBox;
        private System.Windows.Forms.DataGridView LPTable;
        private System.Windows.Forms.DataGridView TradingItemsTable;
        private System.Windows.Forms.DataGridView TrackedItemsTable;
        private System.Windows.Forms.ToolStripMenuItem tabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marketBrowserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDatabaseValuesToolStripMenuItem;
    }
}

