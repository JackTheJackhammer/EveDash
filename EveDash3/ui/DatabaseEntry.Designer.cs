
namespace EveDash3.ui
{
    partial class DatabaseEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseEntry));
            this.StaticTitleTab = new System.Windows.Forms.TabControl();
            this.DatabaseEntryTab = new System.Windows.Forms.TabPage();
            this.MarketGroupBx = new System.Windows.Forms.GroupBox();
            this.MarketGroupTree = new System.Windows.Forms.TreeView();
            this.SkillsBx = new System.Windows.Forms.GroupBox();
            this.SkillsView = new System.Windows.Forms.TreeView();
            this.IndustryBx = new System.Windows.Forms.GroupBox();
            this.ProducedByLbl = new System.Windows.Forms.LinkLabel();
            this.CargoBox = new System.Windows.Forms.GroupBox();
            this.CapacityLbl = new System.Windows.Forms.Label();
            this.basicinfobx = new System.Windows.Forms.GroupBox();
            this.BasePricelbl = new System.Windows.Forms.Label();
            this.volumelbl = new System.Windows.Forms.Label();
            this.Masslbl = new System.Windows.Forms.Label();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.TypeIDLabel = new System.Windows.Forms.Label();
            this.ItemName = new System.Windows.Forms.Label();
            this.StaticTitleTab.SuspendLayout();
            this.DatabaseEntryTab.SuspendLayout();
            this.MarketGroupBx.SuspendLayout();
            this.SkillsBx.SuspendLayout();
            this.IndustryBx.SuspendLayout();
            this.CargoBox.SuspendLayout();
            this.basicinfobx.SuspendLayout();
            this.SuspendLayout();
            // 
            // StaticTitleTab
            // 
            this.StaticTitleTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StaticTitleTab.Controls.Add(this.DatabaseEntryTab);
            this.StaticTitleTab.Location = new System.Drawing.Point(12, 19);
            this.StaticTitleTab.Name = "StaticTitleTab";
            this.StaticTitleTab.SelectedIndex = 0;
            this.StaticTitleTab.Size = new System.Drawing.Size(1112, 570);
            this.StaticTitleTab.TabIndex = 3;
            // 
            // DatabaseEntryTab
            // 
            this.DatabaseEntryTab.Controls.Add(this.MarketGroupBx);
            this.DatabaseEntryTab.Controls.Add(this.SkillsBx);
            this.DatabaseEntryTab.Controls.Add(this.IndustryBx);
            this.DatabaseEntryTab.Controls.Add(this.CargoBox);
            this.DatabaseEntryTab.Controls.Add(this.basicinfobx);
            this.DatabaseEntryTab.Location = new System.Drawing.Point(4, 22);
            this.DatabaseEntryTab.Name = "DatabaseEntryTab";
            this.DatabaseEntryTab.Padding = new System.Windows.Forms.Padding(3);
            this.DatabaseEntryTab.Size = new System.Drawing.Size(1104, 544);
            this.DatabaseEntryTab.TabIndex = 0;
            this.DatabaseEntryTab.Text = "Database Entry";
            this.DatabaseEntryTab.UseVisualStyleBackColor = true;
            // 
            // MarketGroupBx
            // 
            this.MarketGroupBx.Controls.Add(this.MarketGroupTree);
            this.MarketGroupBx.Location = new System.Drawing.Point(516, 282);
            this.MarketGroupBx.Name = "MarketGroupBx";
            this.MarketGroupBx.Size = new System.Drawing.Size(431, 156);
            this.MarketGroupBx.TabIndex = 6;
            this.MarketGroupBx.TabStop = false;
            this.MarketGroupBx.Text = "Market Group";
            // 
            // MarketGroupTree
            // 
            this.MarketGroupTree.Location = new System.Drawing.Point(6, 19);
            this.MarketGroupTree.Name = "MarketGroupTree";
            this.MarketGroupTree.Size = new System.Drawing.Size(419, 131);
            this.MarketGroupTree.TabIndex = 0;
            // 
            // SkillsBx
            // 
            this.SkillsBx.Controls.Add(this.SkillsView);
            this.SkillsBx.Location = new System.Drawing.Point(516, 120);
            this.SkillsBx.Name = "SkillsBx";
            this.SkillsBx.Size = new System.Drawing.Size(431, 156);
            this.SkillsBx.TabIndex = 5;
            this.SkillsBx.TabStop = false;
            this.SkillsBx.Text = "Skills";
            // 
            // SkillsView
            // 
            this.SkillsView.Location = new System.Drawing.Point(6, 19);
            this.SkillsView.Name = "SkillsView";
            this.SkillsView.Size = new System.Drawing.Size(419, 131);
            this.SkillsView.TabIndex = 0;
            // 
            // IndustryBx
            // 
            this.IndustryBx.Controls.Add(this.ProducedByLbl);
            this.IndustryBx.Location = new System.Drawing.Point(735, 6);
            this.IndustryBx.Name = "IndustryBx";
            this.IndustryBx.Size = new System.Drawing.Size(212, 107);
            this.IndustryBx.TabIndex = 5;
            this.IndustryBx.TabStop = false;
            this.IndustryBx.Text = "Industry";
            // 
            // ProducedByLbl
            // 
            this.ProducedByLbl.AutoSize = true;
            this.ProducedByLbl.Location = new System.Drawing.Point(6, 50);
            this.ProducedByLbl.MaximumSize = new System.Drawing.Size(200, 0);
            this.ProducedByLbl.Name = "ProducedByLbl";
            this.ProducedByLbl.Size = new System.Drawing.Size(199, 39);
            this.ProducedByLbl.TabIndex = 5;
            this.ProducedByLbl.TabStop = true;
            this.ProducedByLbl.Text = "Produced By : ddddddddddddddddddddddddddddddddddd";
            this.ProducedByLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ProducedByLbl_LinkClicked);
            // 
            // CargoBox
            // 
            this.CargoBox.Controls.Add(this.CapacityLbl);
            this.CargoBox.Location = new System.Drawing.Point(517, 7);
            this.CargoBox.Name = "CargoBox";
            this.CargoBox.Size = new System.Drawing.Size(212, 107);
            this.CargoBox.TabIndex = 1;
            this.CargoBox.TabStop = false;
            this.CargoBox.Text = "Cargo";
            // 
            // CapacityLbl
            // 
            this.CapacityLbl.AutoSize = true;
            this.CapacityLbl.Location = new System.Drawing.Point(6, 49);
            this.CapacityLbl.Name = "CapacityLbl";
            this.CapacityLbl.Size = new System.Drawing.Size(97, 13);
            this.CapacityLbl.TabIndex = 4;
            this.CapacityLbl.Text = "Capacity : 10 cm/3";
            // 
            // basicinfobx
            // 
            this.basicinfobx.Controls.Add(this.BasePricelbl);
            this.basicinfobx.Controls.Add(this.volumelbl);
            this.basicinfobx.Controls.Add(this.Masslbl);
            this.basicinfobx.Controls.Add(this.DescriptionLbl);
            this.basicinfobx.Controls.Add(this.TypeIDLabel);
            this.basicinfobx.Controls.Add(this.ItemName);
            this.basicinfobx.Location = new System.Drawing.Point(7, 7);
            this.basicinfobx.Name = "basicinfobx";
            this.basicinfobx.Size = new System.Drawing.Size(503, 269);
            this.basicinfobx.TabIndex = 0;
            this.basicinfobx.TabStop = false;
            this.basicinfobx.Text = "Basic";
            // 
            // BasePricelbl
            // 
            this.BasePricelbl.AutoSize = true;
            this.BasePricelbl.Location = new System.Drawing.Point(333, 121);
            this.BasePricelbl.Name = "BasePricelbl";
            this.BasePricelbl.Size = new System.Drawing.Size(122, 13);
            this.BasePricelbl.TabIndex = 5;
            this.BasePricelbl.Text = "Base Price : 100,000 isk";
            // 
            // volumelbl
            // 
            this.volumelbl.AutoSize = true;
            this.volumelbl.Location = new System.Drawing.Point(333, 97);
            this.volumelbl.Name = "volumelbl";
            this.volumelbl.Size = new System.Drawing.Size(97, 13);
            this.volumelbl.TabIndex = 4;
            this.volumelbl.Text = "Volume : 0.01cm/3";
            // 
            // Masslbl
            // 
            this.Masslbl.AutoSize = true;
            this.Masslbl.Location = new System.Drawing.Point(333, 72);
            this.Masslbl.Name = "Masslbl";
            this.Masslbl.Size = new System.Drawing.Size(71, 13);
            this.Masslbl.TabIndex = 3;
            this.Masslbl.Text = "Mass : 100kg";
            // 
            // DescriptionLbl
            // 
            this.DescriptionLbl.AutoSize = true;
            this.DescriptionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLbl.Location = new System.Drawing.Point(10, 72);
            this.DescriptionLbl.MaximumSize = new System.Drawing.Size(300, 0);
            this.DescriptionLbl.Name = "DescriptionLbl";
            this.DescriptionLbl.Size = new System.Drawing.Size(300, 52);
            this.DescriptionLbl.TabIndex = 2;
            this.DescriptionLbl.Text = resources.GetString("DescriptionLbl.Text");
            // 
            // TypeIDLabel
            // 
            this.TypeIDLabel.AutoSize = true;
            this.TypeIDLabel.Location = new System.Drawing.Point(12, 49);
            this.TypeIDLabel.Name = "TypeIDLabel";
            this.TypeIDLabel.Size = new System.Drawing.Size(37, 13);
            this.TypeIDLabel.TabIndex = 1;
            this.TypeIDLabel.Text = "42830";
            // 
            // ItemName
            // 
            this.ItemName.AutoSize = true;
            this.ItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemName.Location = new System.Drawing.Point(7, 20);
            this.ItemName.Name = "ItemName";
            this.ItemName.Size = new System.Drawing.Size(339, 25);
            this.ItemName.TabIndex = 0;
            this.ItemName.Text = "Mining Laser Optimization Charge";
            // 
            // DatabaseEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 609);
            this.Controls.Add(this.StaticTitleTab);
            this.Name = "DatabaseEntry";
            this.Text = "DatabaseEntry";
            this.StaticTitleTab.ResumeLayout(false);
            this.DatabaseEntryTab.ResumeLayout(false);
            this.MarketGroupBx.ResumeLayout(false);
            this.SkillsBx.ResumeLayout(false);
            this.IndustryBx.ResumeLayout(false);
            this.IndustryBx.PerformLayout();
            this.CargoBox.ResumeLayout(false);
            this.CargoBox.PerformLayout();
            this.basicinfobx.ResumeLayout(false);
            this.basicinfobx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl StaticTitleTab;
        private System.Windows.Forms.TabPage DatabaseEntryTab;
        private System.Windows.Forms.GroupBox basicinfobx;
        private System.Windows.Forms.Label TypeIDLabel;
        private System.Windows.Forms.Label ItemName;
        private System.Windows.Forms.Label DescriptionLbl;
        private System.Windows.Forms.Label volumelbl;
        private System.Windows.Forms.Label Masslbl;
        private System.Windows.Forms.GroupBox SkillsBx;
        private System.Windows.Forms.GroupBox IndustryBx;
        private System.Windows.Forms.LinkLabel ProducedByLbl;
        private System.Windows.Forms.GroupBox CargoBox;
        private System.Windows.Forms.Label CapacityLbl;
        private System.Windows.Forms.Label BasePricelbl;
        private System.Windows.Forms.TreeView SkillsView;
        private System.Windows.Forms.GroupBox MarketGroupBx;
        private System.Windows.Forms.TreeView MarketGroupTree;
    }
}