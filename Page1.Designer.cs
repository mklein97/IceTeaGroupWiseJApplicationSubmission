namespace WisejWebPageApplication1
{
    partial class Page1
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

        #region Wisej.NET Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle9 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle10 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle11 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle12 = new Wisej.Web.DataGridViewCellStyle();
            this.OrganizationsView = new Wisej.Web.DataGridView();
            this.flexLayoutPanel1 = new Wisej.Web.FlexLayoutPanel();
            this.OrgLabel = new Wisej.Web.Label();
            this.AddNewOrgEntry = new Wisej.Web.FlexLayoutPanel();
            this.OrgNameEntry = new Wisej.Web.TextBox();
            this.OrgStreetEntry = new Wisej.Web.TextBox();
            this.OrgZipEntry = new Wisej.Web.TextBox();
            this.OrgCityEntry = new Wisej.Web.TextBox();
            this.OrgCountryEntry = new Wisej.Web.TextBox();
            this.AddNewOrgButton = new Wisej.Web.Button();
            this.OrgLockButton = new Wisej.Web.Button();
            this.StaffLabel = new Wisej.Web.Label();
            this.AddNewStaffEntry = new Wisej.Web.FlexLayoutPanel();
            this.StaffOrgEntry = new Wisej.Web.SplitButton();
            this.StaffTitleEntry = new Wisej.Web.TextBox();
            this.StaffEmailEntry = new Wisej.Web.TextBox();
            this.StaffPhoneNumEntry = new Wisej.Web.TextBox();
            this.StaffFirstNameEntry = new Wisej.Web.TextBox();
            this.StaffLastNameEntry = new Wisej.Web.TextBox();
            this.AddNewStaffButton = new Wisej.Web.Button();
            this.StaffLockButton = new Wisej.Web.Button();
            this.StaffView = new Wisej.Web.DataGridView();
            this.flexLayoutPanel2 = new Wisej.Web.FlexLayoutPanel();
            this.flexLayoutPanel3 = new Wisej.Web.FlexLayoutPanel();
            this.panel1 = new Wisej.Web.Panel();
            this.panel2 = new Wisej.Web.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.OrganizationsView)).BeginInit();
            this.flexLayoutPanel1.SuspendLayout();
            this.AddNewOrgEntry.SuspendLayout();
            this.AddNewStaffEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffView)).BeginInit();
            this.flexLayoutPanel2.SuspendLayout();
            this.flexLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrganizationsView
            // 
            this.OrganizationsView.AllowUserToAddRows = true;
            this.OrganizationsView.AllowUserToDeleteRows = true;
            this.OrganizationsView.AutoSelectFirstRow = false;
            this.OrganizationsView.AutoSize = true;
            this.OrganizationsView.AutoSizeColumnsMode = Wisej.Web.DataGridViewAutoSizeColumnsMode.AllCells;
            this.OrganizationsView.AutoSizeRowsMode = Wisej.Web.DataGridViewAutoSizeRowsMode.AllCells;
            this.OrganizationsView.CellBorderStyle = Wisej.Web.DataGridViewCellBorderStyle.Vertical;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(224, 133, 0);
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OrganizationsView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.Padding = new Wisej.Web.Padding(8);
            this.OrganizationsView.DefaultCellStyle = dataGridViewCellStyle10;
            this.OrganizationsView.EditMode = Wisej.Web.DataGridViewEditMode.EditOnF2;
            this.OrganizationsView.Font = new System.Drawing.Font("default, Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.OrganizationsView.Location = new System.Drawing.Point(0, 0);
            this.OrganizationsView.Margin = new Wisej.Web.Padding(20, 1, 20, 1);
            this.OrganizationsView.Name = "OrganizationsView";
            this.OrganizationsView.ReadOnly = true;
            this.OrganizationsView.Size = new System.Drawing.Size(42, 36);
            this.OrganizationsView.TabIndex = 0;
            this.OrganizationsView.CellValueChanged += new Wisej.Web.DataGridViewCellEventHandler(this.OrganizationsView_CellValueChanged);
            this.OrganizationsView.SelectionChanged += new System.EventHandler(this.OrganizationsView_SelectionChanged);
            // 
            // flexLayoutPanel1
            // 
            this.flexLayoutPanel1.AutoScroll = true;
            this.flexLayoutPanel1.AutoSize = true;
            this.flexLayoutPanel1.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink;
            this.flexLayoutPanel1.Controls.Add(this.flexLayoutPanel2);
            this.flexLayoutPanel1.Controls.Add(this.flexLayoutPanel3);
            this.flexLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
            this.flexLayoutPanel1.LayoutStyle = Wisej.Web.FlexLayoutStyle.Vertical;
            this.flexLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flexLayoutPanel1.Name = "flexLayoutPanel1";
            this.flexLayoutPanel1.Size = new System.Drawing.Size(1817, 1188);
            this.flexLayoutPanel1.Spacing = 20;
            this.flexLayoutPanel1.TabIndex = 1;
            // 
            // OrgLabel
            // 
            this.OrgLabel.AutoSize = true;
            this.OrgLabel.CssStyle = "border-bottom: solid";
            this.OrgLabel.Font = new System.Drawing.Font("default, Arial", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.OrgLabel.Location = new System.Drawing.Point(20, 3);
            this.OrgLabel.Margin = new Wisej.Web.Padding(20, 3, 22, 1);
            this.OrgLabel.Name = "OrgLabel";
            this.OrgLabel.Size = new System.Drawing.Size(1767, 29);
            this.OrgLabel.TabIndex = 2;
            this.OrgLabel.Text = "Organizations:";
            // 
            // AddNewOrgEntry
            // 
            this.AddNewOrgEntry.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left)));
            this.AddNewOrgEntry.AutoScroll = true;
            this.AddNewOrgEntry.AutoSize = true;
            this.AddNewOrgEntry.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink;
            this.AddNewOrgEntry.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.AddNewOrgEntry.CollapseSide = Wisej.Web.HeaderPosition.Bottom;
            this.AddNewOrgEntry.Controls.Add(this.OrgNameEntry);
            this.AddNewOrgEntry.Controls.Add(this.OrgStreetEntry);
            this.AddNewOrgEntry.Controls.Add(this.OrgZipEntry);
            this.AddNewOrgEntry.Controls.Add(this.OrgCityEntry);
            this.AddNewOrgEntry.Controls.Add(this.OrgCountryEntry);
            this.AddNewOrgEntry.Controls.Add(this.AddNewOrgButton);
            this.AddNewOrgEntry.Font = new System.Drawing.Font("default, Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.AddNewOrgEntry.LayoutStyle = Wisej.Web.FlexLayoutStyle.Horizontal;
            this.AddNewOrgEntry.Location = new System.Drawing.Point(20, 44);
            this.AddNewOrgEntry.Margin = new Wisej.Web.Padding(20, 1, 20, 2);
            this.AddNewOrgEntry.Name = "AddNewOrgEntry";
            this.AddNewOrgEntry.ShowHeader = true;
            this.AddNewOrgEntry.Size = new System.Drawing.Size(1769, 119);
            this.AddNewOrgEntry.Spacing = 20;
            this.AddNewOrgEntry.TabIndex = 5;
            this.AddNewOrgEntry.Text = "Add New Organization";
            // 
            // OrgNameEntry
            // 
            this.OrgNameEntry.LabelText = "Name:";
            this.OrgNameEntry.Location = new System.Drawing.Point(3, 3);
            this.OrgNameEntry.Name = "OrgNameEntry";
            this.OrgNameEntry.Padding = new Wisej.Web.Padding(0, 30, 0, 0);
            this.OrgNameEntry.Size = new System.Drawing.Size(180, 83);
            this.OrgNameEntry.TabIndex = 3;
            // 
            // OrgStreetEntry
            // 
            this.OrgStreetEntry.LabelText = "Street:";
            this.OrgStreetEntry.Location = new System.Drawing.Point(209, 3);
            this.OrgStreetEntry.Name = "OrgStreetEntry";
            this.OrgStreetEntry.Size = new System.Drawing.Size(180, 83);
            this.OrgStreetEntry.TabIndex = 5;
            // 
            // OrgZipEntry
            // 
            this.OrgZipEntry.LabelText = "Zip:";
            this.OrgZipEntry.Location = new System.Drawing.Point(415, 3);
            this.OrgZipEntry.Name = "OrgZipEntry";
            this.OrgZipEntry.Size = new System.Drawing.Size(180, 83);
            this.OrgZipEntry.TabIndex = 7;
            // 
            // OrgCityEntry
            // 
            this.OrgCityEntry.LabelText = "City:";
            this.OrgCityEntry.Location = new System.Drawing.Point(621, 3);
            this.OrgCityEntry.Name = "OrgCityEntry";
            this.OrgCityEntry.Size = new System.Drawing.Size(180, 83);
            this.OrgCityEntry.TabIndex = 9;
            // 
            // OrgCountryEntry
            // 
            this.OrgCountryEntry.LabelText = "Country:";
            this.OrgCountryEntry.Location = new System.Drawing.Point(827, 3);
            this.OrgCountryEntry.Name = "OrgCountryEntry";
            this.OrgCountryEntry.Size = new System.Drawing.Size(180, 83);
            this.OrgCountryEntry.TabIndex = 11;
            // 
            // AddNewOrgButton
            // 
            this.AddNewOrgButton.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink;
            this.AddNewOrgButton.Location = new System.Drawing.Point(1033, 45);
            this.AddNewOrgButton.Margin = new Wisej.Web.Padding(3, 45, 3, 3);
            this.AddNewOrgButton.Name = "AddNewOrgButton";
            this.AddNewOrgButton.Size = new System.Drawing.Size(100, 41);
            this.AddNewOrgButton.TabIndex = 13;
            this.AddNewOrgButton.Text = "Add";
            this.AddNewOrgButton.Click += new System.EventHandler(this.AddNewOrgButton_Click);
            // 
            // OrgLockButton
            // 
            this.OrgLockButton.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.OrgLockButton.AutoSize = true;
            this.OrgLockButton.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink;
            this.OrgLockButton.BackColor = System.Drawing.Color.DarkRed;
            this.OrgLockButton.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.OrgLockButton.Location = new System.Drawing.Point(20, 178);
            this.OrgLockButton.Margin = new Wisej.Web.Padding(20, 3, 20, 3);
            this.OrgLockButton.MaximumSize = new System.Drawing.Size(120, 0);
            this.OrgLockButton.Name = "OrgLockButton";
            this.OrgLockButton.Size = new System.Drawing.Size(120, 37);
            this.OrgLockButton.TabIndex = 8;
            this.OrgLockButton.Text = "Table: Locked 🔒";
            this.OrgLockButton.Click += new System.EventHandler(this.OrgLockButton_Click);
            // 
            // StaffLabel
            // 
            this.StaffLabel.AutoSize = true;
            this.StaffLabel.CssStyle = "border-bottom: solid";
            this.StaffLabel.Font = new System.Drawing.Font("default, Arial", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.StaffLabel.Location = new System.Drawing.Point(20, 3);
            this.StaffLabel.Margin = new Wisej.Web.Padding(20, 3, 22, 1);
            this.StaffLabel.Name = "StaffLabel";
            this.StaffLabel.Size = new System.Drawing.Size(1767, 29);
            this.StaffLabel.TabIndex = 3;
            this.StaffLabel.Text = "Staff:";
            // 
            // AddNewStaffEntry
            // 
            this.AddNewStaffEntry.AutoScroll = true;
            this.AddNewStaffEntry.AutoSize = true;
            this.AddNewStaffEntry.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink;
            this.AddNewStaffEntry.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.AddNewStaffEntry.Controls.Add(this.StaffOrgEntry);
            this.AddNewStaffEntry.Controls.Add(this.StaffTitleEntry);
            this.AddNewStaffEntry.Controls.Add(this.StaffFirstNameEntry);
            this.AddNewStaffEntry.Controls.Add(this.StaffLastNameEntry);
            this.AddNewStaffEntry.Controls.Add(this.StaffPhoneNumEntry);
            this.AddNewStaffEntry.Controls.Add(this.StaffEmailEntry);
            this.AddNewStaffEntry.Controls.Add(this.AddNewStaffButton);
            this.AddNewStaffEntry.Font = new System.Drawing.Font("default, Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.AddNewStaffEntry.LayoutStyle = Wisej.Web.FlexLayoutStyle.Horizontal;
            this.AddNewStaffEntry.Location = new System.Drawing.Point(20, 44);
            this.AddNewStaffEntry.Margin = new Wisej.Web.Padding(20, 1, 20, 3);
            this.AddNewStaffEntry.Name = "AddNewStaffEntry";
            this.AddNewStaffEntry.ShowHeader = true;
            this.AddNewStaffEntry.Size = new System.Drawing.Size(1769, 124);
            this.AddNewStaffEntry.Spacing = 20;
            this.AddNewStaffEntry.TabIndex = 6;
            this.AddNewStaffEntry.Text = "Add New Staff";
            // 
            // StaffOrgEntry
            // 
            this.StaffOrgEntry.AutoSize = true;
            this.StaffOrgEntry.Location = new System.Drawing.Point(3, 45);
            this.StaffOrgEntry.Margin = new Wisej.Web.Padding(3, 45, 3, 3);
            this.StaffOrgEntry.Name = "StaffOrgEntry";
            this.StaffOrgEntry.Size = new System.Drawing.Size(162, 46);
            this.StaffOrgEntry.TabIndex = 16;
            this.StaffOrgEntry.Text = "Organization:";
            this.StaffOrgEntry.ItemClicked += new Wisej.Web.MenuButtonItemClickedEventHandler(this.StaffOrgEntry_ItemClicked);
            // 
            // StaffTitleEntry
            // 
            this.StaffTitleEntry.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.StaffTitleEntry.AutoSize = false;
            this.StaffTitleEntry.Font = new System.Drawing.Font("default, Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.StaffTitleEntry.LabelText = "Title:";
            this.StaffTitleEntry.Location = new System.Drawing.Point(191, 3);
            this.StaffTitleEntry.Name = "StaffTitleEntry";
            this.StaffTitleEntry.Size = new System.Drawing.Size(180, 88);
            this.StaffTitleEntry.TabIndex = 14;
            // 
            // StaffEmailEntry
            // 
            this.StaffEmailEntry.LabelText = "Email Address:";
            this.StaffEmailEntry.Location = new System.Drawing.Point(1015, 3);
            this.StaffEmailEntry.Name = "StaffEmailEntry";
            this.StaffEmailEntry.Padding = new Wisej.Web.Padding(0, 35, 0, 0);
            this.StaffEmailEntry.Size = new System.Drawing.Size(180, 88);
            this.StaffEmailEntry.TabIndex = 11;
            // 
            // StaffPhoneNumEntry
            // 
            this.StaffPhoneNumEntry.LabelText = "Phone Number:";
            this.StaffPhoneNumEntry.Location = new System.Drawing.Point(809, 3);
            this.StaffPhoneNumEntry.Name = "StaffPhoneNumEntry";
            this.StaffPhoneNumEntry.Size = new System.Drawing.Size(180, 88);
            this.StaffPhoneNumEntry.TabIndex = 9;
            // 
            // StaffFirstNameEntry
            // 
            this.StaffFirstNameEntry.LabelText = "First Name:";
            this.StaffFirstNameEntry.Location = new System.Drawing.Point(397, 3);
            this.StaffFirstNameEntry.Name = "StaffFirstNameEntry";
            this.StaffFirstNameEntry.Size = new System.Drawing.Size(180, 88);
            this.StaffFirstNameEntry.TabIndex = 5;
            // 
            // StaffLastNameEntry
            // 
            this.StaffLastNameEntry.LabelText = "Last Name:";
            this.StaffLastNameEntry.Location = new System.Drawing.Point(603, 3);
            this.StaffLastNameEntry.Name = "StaffLastNameEntry";
            this.StaffLastNameEntry.Size = new System.Drawing.Size(180, 88);
            this.StaffLastNameEntry.TabIndex = 7;
            // 
            // AddNewStaffButton
            // 
            this.AddNewStaffButton.Location = new System.Drawing.Point(1221, 50);
            this.AddNewStaffButton.Margin = new Wisej.Web.Padding(3, 50, 3, 3);
            this.AddNewStaffButton.Name = "AddNewStaffButton";
            this.AddNewStaffButton.Size = new System.Drawing.Size(100, 41);
            this.AddNewStaffButton.TabIndex = 13;
            this.AddNewStaffButton.Text = "Add";
            this.AddNewStaffButton.Click += new System.EventHandler(this.AddNewStaffButton_Click);
            // 
            // StaffLockButton
            // 
            this.StaffLockButton.AutoSize = true;
            this.StaffLockButton.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink;
            this.StaffLockButton.BackColor = System.Drawing.Color.DarkRed;
            this.StaffLockButton.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.StaffLockButton.Location = new System.Drawing.Point(20, 184);
            this.StaffLockButton.Margin = new Wisej.Web.Padding(20, 3, 20, 3);
            this.StaffLockButton.MaximumSize = new System.Drawing.Size(120, 0);
            this.StaffLockButton.Name = "StaffLockButton";
            this.StaffLockButton.Size = new System.Drawing.Size(120, 37);
            this.StaffLockButton.TabIndex = 9;
            this.StaffLockButton.Text = "Table: Locked 🔒";
            this.StaffLockButton.Click += new System.EventHandler(this.StaffLockButton_Click);
            // 
            // StaffView
            // 
            this.StaffView.AutoSelectFirstRow = false;
            this.StaffView.AutoSize = true;
            this.StaffView.AutoSizeColumnsMode = Wisej.Web.DataGridViewAutoSizeColumnsMode.AllCells;
            this.StaffView.AutoSizeRowsMode = Wisej.Web.DataGridViewAutoSizeRowsMode.AllCells;
            this.StaffView.CellBorderStyle = Wisej.Web.DataGridViewCellBorderStyle.Vertical;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(224, 133, 0);
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StaffView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.Padding = new Wisej.Web.Padding(8);
            this.StaffView.DefaultCellStyle = dataGridViewCellStyle12;
            this.StaffView.EditMode = Wisej.Web.DataGridViewEditMode.EditOnF2;
            this.StaffView.Font = new System.Drawing.Font("default, Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.StaffView.Location = new System.Drawing.Point(0, 0);
            this.StaffView.Margin = new Wisej.Web.Padding(20, 1, 20, 1);
            this.StaffView.Name = "StaffView";
            this.StaffView.ReadOnly = true;
            this.StaffView.Size = new System.Drawing.Size(42, 36);
            this.StaffView.TabIndex = 10;
            this.StaffView.CellValueChanged += new Wisej.Web.DataGridViewCellEventHandler(this.StaffView_CellValueChanged);
            // 
            // flexLayoutPanel2
            // 
            this.flexLayoutPanel2.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.flexLayoutPanel2.Controls.Add(this.OrgLabel);
            this.flexLayoutPanel2.Controls.Add(this.AddNewOrgEntry);
            this.flexLayoutPanel2.Controls.Add(this.OrgLockButton);
            this.flexLayoutPanel2.Controls.Add(this.panel2);
            this.flexLayoutPanel2.CssStyle = "border-width: 3px";
            this.flexLayoutPanel2.LayoutStyle = Wisej.Web.FlexLayoutStyle.Vertical;
            this.flexLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flexLayoutPanel2.Name = "flexLayoutPanel2";
            this.flexLayoutPanel2.ResizableEdges = Wisej.Web.AnchorStyles.Bottom;
            this.flexLayoutPanel2.Size = new System.Drawing.Size(1811, 550);
            this.flexLayoutPanel2.TabIndex = 11;
            // 
            // flexLayoutPanel3
            // 
            this.flexLayoutPanel3.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink;
            this.flexLayoutPanel3.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.flexLayoutPanel3.Controls.Add(this.StaffLabel);
            this.flexLayoutPanel3.Controls.Add(this.AddNewStaffEntry);
            this.flexLayoutPanel3.Controls.Add(this.StaffLockButton);
            this.flexLayoutPanel3.Controls.Add(this.panel1);
            this.flexLayoutPanel3.CssStyle = "border-width: 3px";
            this.flexLayoutPanel1.SetFillWeight(this.flexLayoutPanel3, 1);
            this.flexLayoutPanel3.LayoutStyle = Wisej.Web.FlexLayoutStyle.Vertical;
            this.flexLayoutPanel3.Location = new System.Drawing.Point(3, 579);
            this.flexLayoutPanel3.Name = "flexLayoutPanel3";
            this.flexLayoutPanel3.ResizableEdges = Wisej.Web.AnchorStyles.Bottom;
            this.flexLayoutPanel3.Size = new System.Drawing.Size(1811, 606);
            this.flexLayoutPanel3.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.StaffView);
            this.panel1.Dock = Wisej.Web.DockStyle.Bottom;
            this.flexLayoutPanel3.SetFillWeight(this.panel1, 1);
            this.panel1.Location = new System.Drawing.Point(20, 237);
            this.panel1.Margin = new Wisej.Web.Padding(20, 3, 20, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1769, 364);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.OrganizationsView);
            this.flexLayoutPanel2.SetFillWeight(this.panel2, 1);
            this.panel2.Location = new System.Drawing.Point(20, 231);
            this.panel2.Margin = new Wisej.Web.Padding(20, 3, 20, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1769, 314);
            this.panel2.TabIndex = 9;
            // 
            // Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.flexLayoutPanel1);
            this.Name = "Page1";
            this.Size = new System.Drawing.Size(1817, 1188);
            this.Load += new System.EventHandler(this.Page1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrganizationsView)).EndInit();
            this.flexLayoutPanel1.ResumeLayout(false);
            this.AddNewOrgEntry.ResumeLayout(false);
            this.AddNewOrgEntry.PerformLayout();
            this.AddNewStaffEntry.ResumeLayout(false);
            this.AddNewStaffEntry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffView)).EndInit();
            this.flexLayoutPanel2.ResumeLayout(false);
            this.flexLayoutPanel2.PerformLayout();
            this.flexLayoutPanel3.ResumeLayout(false);
            this.flexLayoutPanel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Wisej.Web.DataGridView OrganizationsView;
        private Wisej.Web.FlexLayoutPanel flexLayoutPanel1;
        private Wisej.Web.Label StaffLabel;
        private Wisej.Web.FlexLayoutPanel AddNewOrgEntry;
        private Wisej.Web.Label OrgLabel;
        private Wisej.Web.TextBox OrgNameEntry;
        private Wisej.Web.TextBox OrgStreetEntry;
        private Wisej.Web.TextBox OrgZipEntry;
        private Wisej.Web.TextBox OrgCityEntry;
        private Wisej.Web.TextBox OrgCountryEntry;
        private Wisej.Web.Button AddNewOrgButton;
        private Wisej.Web.FlexLayoutPanel AddNewStaffEntry;
        private Wisej.Web.TextBox StaffFirstNameEntry;
        private Wisej.Web.TextBox StaffLastNameEntry;
        private Wisej.Web.TextBox StaffPhoneNumEntry;
        private Wisej.Web.TextBox StaffEmailEntry;
        private Wisej.Web.Button AddNewStaffButton;
        private Wisej.Web.TextBox StaffTitleEntry;
        private Wisej.Web.Button OrgLockButton;
        private Wisej.Web.Button StaffLockButton;
        private Wisej.Web.DataGridView StaffView;
        private Wisej.Web.SplitButton StaffOrgEntry;
        private Wisej.Web.FlexLayoutPanel flexLayoutPanel2;
        private Wisej.Web.FlexLayoutPanel flexLayoutPanel3;
        private Wisej.Web.Panel panel1;
        private Wisej.Web.Panel panel2;
    }
}

