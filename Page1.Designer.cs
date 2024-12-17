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
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle1 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle2 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle3 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle4 = new Wisej.Web.DataGridViewCellStyle();
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
            this.StaffFirstNameEntry = new Wisej.Web.TextBox();
            this.StaffLastNameEntry = new Wisej.Web.TextBox();
            this.StaffPhoneNumEntry = new Wisej.Web.TextBox();
            this.StaffEmailEntry = new Wisej.Web.TextBox();
            this.AddNewStaffButton = new Wisej.Web.Button();
            this.StaffLockButton = new Wisej.Web.Button();
            this.StaffView = new Wisej.Web.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.OrganizationsView)).BeginInit();
            this.flexLayoutPanel1.SuspendLayout();
            this.AddNewOrgEntry.SuspendLayout();
            this.AddNewStaffEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffView)).BeginInit();
            this.SuspendLayout();
            // 
            // OrganizationsView
            // 
            this.OrganizationsView.AllowUserToAddRows = true;
            this.OrganizationsView.AllowUserToDeleteRows = true;
            this.OrganizationsView.AutoSize = true;
            this.OrganizationsView.AutoSizeColumnsMode = Wisej.Web.DataGridViewAutoSizeColumnsMode.AllCells;
            this.OrganizationsView.AutoSizeRowsMode = Wisej.Web.DataGridViewAutoSizeRowsMode.AllCells;
            this.OrganizationsView.CellBorderStyle = Wisej.Web.DataGridViewCellBorderStyle.Vertical;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(224, 133, 0);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OrganizationsView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Padding = new Wisej.Web.Padding(8);
            this.OrganizationsView.DefaultCellStyle = dataGridViewCellStyle2;
            this.OrganizationsView.EditMode = Wisej.Web.DataGridViewEditMode.EditOnF2;
            this.OrganizationsView.Font = new System.Drawing.Font("default, Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.OrganizationsView.Location = new System.Drawing.Point(20, 193);
            this.OrganizationsView.Margin = new Wisej.Web.Padding(20, 1, 20, 1);
            this.OrganizationsView.Name = "OrganizationsView";
            this.OrganizationsView.ReadOnly = true;
            this.OrganizationsView.Size = new System.Drawing.Size(1777, 36);
            this.OrganizationsView.TabIndex = 0;
            this.OrganizationsView.CellValueChanged += new Wisej.Web.DataGridViewCellEventHandler(this.OrganizationsView_CellValueChanged);
            // 
            // flexLayoutPanel1
            // 
            this.flexLayoutPanel1.Controls.Add(this.OrgLabel);
            this.flexLayoutPanel1.Controls.Add(this.AddNewOrgEntry);
            this.flexLayoutPanel1.Controls.Add(this.OrgLockButton);
            this.flexLayoutPanel1.Controls.Add(this.OrganizationsView);
            this.flexLayoutPanel1.Controls.Add(this.StaffLabel);
            this.flexLayoutPanel1.Controls.Add(this.AddNewStaffEntry);
            this.flexLayoutPanel1.Controls.Add(this.StaffLockButton);
            this.flexLayoutPanel1.Controls.Add(this.StaffView);
            this.flexLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
            this.flexLayoutPanel1.LayoutStyle = Wisej.Web.FlexLayoutStyle.Vertical;
            this.flexLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flexLayoutPanel1.Name = "flexLayoutPanel1";
            this.flexLayoutPanel1.Size = new System.Drawing.Size(1817, 1001);
            this.flexLayoutPanel1.TabIndex = 1;
            // 
            // OrgLabel
            // 
            this.OrgLabel.AutoSize = true;
            this.OrgLabel.Font = new System.Drawing.Font("default, Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.OrgLabel.Location = new System.Drawing.Point(20, 3);
            this.OrgLabel.Margin = new Wisej.Web.Padding(20, 3, 3, 1);
            this.OrgLabel.Name = "OrgLabel";
            this.OrgLabel.Size = new System.Drawing.Size(1794, 23);
            this.OrgLabel.TabIndex = 2;
            this.OrgLabel.Text = "Organizations:";
            // 
            // AddNewOrgEntry
            // 
            this.AddNewOrgEntry.AutoSize = true;
            this.AddNewOrgEntry.Controls.Add(this.OrgNameEntry);
            this.AddNewOrgEntry.Controls.Add(this.OrgStreetEntry);
            this.AddNewOrgEntry.Controls.Add(this.OrgZipEntry);
            this.AddNewOrgEntry.Controls.Add(this.OrgCityEntry);
            this.AddNewOrgEntry.Controls.Add(this.OrgCountryEntry);
            this.AddNewOrgEntry.Controls.Add(this.AddNewOrgButton);
            this.AddNewOrgEntry.Font = new System.Drawing.Font("default, Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.AddNewOrgEntry.LayoutStyle = Wisej.Web.FlexLayoutStyle.Horizontal;
            this.AddNewOrgEntry.Location = new System.Drawing.Point(20, 38);
            this.AddNewOrgEntry.Margin = new Wisej.Web.Padding(20, 1, 20, 3);
            this.AddNewOrgEntry.Name = "AddNewOrgEntry";
            this.AddNewOrgEntry.ShowHeader = true;
            this.AddNewOrgEntry.Size = new System.Drawing.Size(1777, 88);
            this.AddNewOrgEntry.TabIndex = 5;
            this.AddNewOrgEntry.Text = "Add New Organization";
            // 
            // OrgNameEntry
            // 
            this.OrgNameEntry.LabelText = "Name:";
            this.OrgNameEntry.Location = new System.Drawing.Point(3, 3);
            this.OrgNameEntry.Name = "OrgNameEntry";
            this.OrgNameEntry.Size = new System.Drawing.Size(100, 54);
            this.OrgNameEntry.TabIndex = 3;
            // 
            // OrgStreetEntry
            // 
            this.OrgStreetEntry.LabelText = "Street:";
            this.OrgStreetEntry.Location = new System.Drawing.Point(119, 3);
            this.OrgStreetEntry.Name = "OrgStreetEntry";
            this.OrgStreetEntry.Size = new System.Drawing.Size(100, 54);
            this.OrgStreetEntry.TabIndex = 5;
            // 
            // OrgZipEntry
            // 
            this.OrgZipEntry.LabelText = "Zip:";
            this.OrgZipEntry.Location = new System.Drawing.Point(235, 3);
            this.OrgZipEntry.Name = "OrgZipEntry";
            this.OrgZipEntry.Size = new System.Drawing.Size(100, 54);
            this.OrgZipEntry.TabIndex = 7;
            // 
            // OrgCityEntry
            // 
            this.OrgCityEntry.LabelText = "City:";
            this.OrgCityEntry.Location = new System.Drawing.Point(351, 3);
            this.OrgCityEntry.Name = "OrgCityEntry";
            this.OrgCityEntry.Size = new System.Drawing.Size(100, 54);
            this.OrgCityEntry.TabIndex = 9;
            // 
            // OrgCountryEntry
            // 
            this.OrgCountryEntry.LabelText = "Country:";
            this.OrgCountryEntry.Location = new System.Drawing.Point(467, 3);
            this.OrgCountryEntry.Name = "OrgCountryEntry";
            this.OrgCountryEntry.Size = new System.Drawing.Size(100, 54);
            this.OrgCountryEntry.TabIndex = 11;
            // 
            // AddNewOrgButton
            // 
            this.AddNewOrgButton.Location = new System.Drawing.Point(583, 26);
            this.AddNewOrgButton.Margin = new Wisej.Web.Padding(3, 26, 3, 3);
            this.AddNewOrgButton.Name = "AddNewOrgButton";
            this.AddNewOrgButton.Size = new System.Drawing.Size(100, 31);
            this.AddNewOrgButton.TabIndex = 13;
            this.AddNewOrgButton.Text = "Add";
            this.AddNewOrgButton.Click += new System.EventHandler(this.AddNewOrgButton_Click);
            // 
            // OrgLockButton
            // 
            this.OrgLockButton.AutoSize = true;
            this.OrgLockButton.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink;
            this.OrgLockButton.Location = new System.Drawing.Point(20, 142);
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
            this.StaffLabel.Font = new System.Drawing.Font("default, Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.StaffLabel.Location = new System.Drawing.Point(20, 243);
            this.StaffLabel.Margin = new Wisej.Web.Padding(20, 3, 3, 1);
            this.StaffLabel.Name = "StaffLabel";
            this.StaffLabel.Size = new System.Drawing.Size(1794, 23);
            this.StaffLabel.TabIndex = 3;
            this.StaffLabel.Text = "Staff:";
            // 
            // AddNewStaffEntry
            // 
            this.AddNewStaffEntry.AutoSize = true;
            this.AddNewStaffEntry.Controls.Add(this.StaffOrgEntry);
            this.AddNewStaffEntry.Controls.Add(this.StaffTitleEntry);
            this.AddNewStaffEntry.Controls.Add(this.StaffFirstNameEntry);
            this.AddNewStaffEntry.Controls.Add(this.StaffLastNameEntry);
            this.AddNewStaffEntry.Controls.Add(this.StaffPhoneNumEntry);
            this.AddNewStaffEntry.Controls.Add(this.StaffEmailEntry);
            this.AddNewStaffEntry.Controls.Add(this.AddNewStaffButton);
            this.AddNewStaffEntry.Font = new System.Drawing.Font("default, Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.AddNewStaffEntry.LayoutStyle = Wisej.Web.FlexLayoutStyle.Horizontal;
            this.AddNewStaffEntry.Location = new System.Drawing.Point(20, 278);
            this.AddNewStaffEntry.Margin = new Wisej.Web.Padding(20, 1, 20, 3);
            this.AddNewStaffEntry.Name = "AddNewStaffEntry";
            this.AddNewStaffEntry.ShowHeader = true;
            this.AddNewStaffEntry.Size = new System.Drawing.Size(1777, 106);
            this.AddNewStaffEntry.TabIndex = 6;
            this.AddNewStaffEntry.Text = "Add New Staff";
            // 
            // StaffOrgEntry
            // 
            this.StaffOrgEntry.AutoSize = true;
            this.StaffOrgEntry.Location = new System.Drawing.Point(3, 42);
            this.StaffOrgEntry.Margin = new Wisej.Web.Padding(3, 42, 3, 3);
            this.StaffOrgEntry.Name = "StaffOrgEntry";
            this.StaffOrgEntry.Size = new System.Drawing.Size(138, 33);
            this.StaffOrgEntry.TabIndex = 16;
            this.StaffOrgEntry.Text = "Organization:";
            this.StaffOrgEntry.ItemClicked += new Wisej.Web.MenuButtonItemClickedEventHandler(this.StaffOrgEntry_ItemClicked);
            // 
            // StaffTitleEntry
            // 
            this.StaffTitleEntry.LabelText = "Title:";
            this.StaffTitleEntry.Location = new System.Drawing.Point(157, 3);
            this.StaffTitleEntry.Name = "StaffTitleEntry";
            this.StaffTitleEntry.Size = new System.Drawing.Size(100, 72);
            this.StaffTitleEntry.TabIndex = 14;
            // 
            // StaffFirstNameEntry
            // 
            this.StaffFirstNameEntry.LabelText = "First Name:";
            this.StaffFirstNameEntry.Location = new System.Drawing.Point(273, 3);
            this.StaffFirstNameEntry.Name = "StaffFirstNameEntry";
            this.StaffFirstNameEntry.Size = new System.Drawing.Size(100, 72);
            this.StaffFirstNameEntry.TabIndex = 5;
            // 
            // StaffLastNameEntry
            // 
            this.StaffLastNameEntry.LabelText = "Last Name:";
            this.StaffLastNameEntry.Location = new System.Drawing.Point(389, 3);
            this.StaffLastNameEntry.Name = "StaffLastNameEntry";
            this.StaffLastNameEntry.Size = new System.Drawing.Size(100, 72);
            this.StaffLastNameEntry.TabIndex = 7;
            // 
            // StaffPhoneNumEntry
            // 
            this.StaffPhoneNumEntry.LabelText = "Phone Number:";
            this.StaffPhoneNumEntry.Location = new System.Drawing.Point(505, 3);
            this.StaffPhoneNumEntry.Name = "StaffPhoneNumEntry";
            this.StaffPhoneNumEntry.Size = new System.Drawing.Size(100, 72);
            this.StaffPhoneNumEntry.TabIndex = 9;
            // 
            // StaffEmailEntry
            // 
            this.StaffEmailEntry.LabelText = "Email Address:";
            this.StaffEmailEntry.Location = new System.Drawing.Point(621, 3);
            this.StaffEmailEntry.Name = "StaffEmailEntry";
            this.StaffEmailEntry.Size = new System.Drawing.Size(100, 72);
            this.StaffEmailEntry.TabIndex = 11;
            // 
            // AddNewStaffButton
            // 
            this.AddNewStaffButton.Location = new System.Drawing.Point(737, 45);
            this.AddNewStaffButton.Margin = new Wisej.Web.Padding(3, 45, 3, 3);
            this.AddNewStaffButton.Name = "AddNewStaffButton";
            this.AddNewStaffButton.Size = new System.Drawing.Size(100, 30);
            this.AddNewStaffButton.TabIndex = 13;
            this.AddNewStaffButton.Text = "Add";
            this.AddNewStaffButton.Click += new System.EventHandler(this.AddNewStaffButton_Click);
            // 
            // StaffLockButton
            // 
            this.StaffLockButton.AutoSize = true;
            this.StaffLockButton.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink;
            this.StaffLockButton.Location = new System.Drawing.Point(20, 400);
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
            this.StaffView.AllowUserToAddRows = true;
            this.StaffView.AllowUserToDeleteRows = true;
            this.StaffView.AutoSize = true;
            this.StaffView.AutoSizeColumnsMode = Wisej.Web.DataGridViewAutoSizeColumnsMode.AllCells;
            this.StaffView.AutoSizeRowsMode = Wisej.Web.DataGridViewAutoSizeRowsMode.AllCells;
            this.StaffView.CellBorderStyle = Wisej.Web.DataGridViewCellBorderStyle.Vertical;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(224, 133, 0);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StaffView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Padding = new Wisej.Web.Padding(8);
            this.StaffView.DefaultCellStyle = dataGridViewCellStyle4;
            this.StaffView.EditMode = Wisej.Web.DataGridViewEditMode.EditOnF2;
            this.StaffView.Font = new System.Drawing.Font("default, Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.StaffView.Location = new System.Drawing.Point(20, 451);
            this.StaffView.Margin = new Wisej.Web.Padding(20, 1, 20, 1);
            this.StaffView.Name = "StaffView";
            this.StaffView.ReadOnly = true;
            this.StaffView.Size = new System.Drawing.Size(1777, 36);
            this.StaffView.TabIndex = 10;
            this.StaffView.CellValueChanged += new Wisej.Web.DataGridViewCellEventHandler(this.StaffView_CellValueChanged);
            // 
            // Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.flexLayoutPanel1);
            this.Name = "Page1";
            this.Size = new System.Drawing.Size(1817, 1001);
            this.Load += new System.EventHandler(this.Page1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrganizationsView)).EndInit();
            this.flexLayoutPanel1.ResumeLayout(false);
            this.flexLayoutPanel1.PerformLayout();
            this.AddNewOrgEntry.ResumeLayout(false);
            this.AddNewOrgEntry.PerformLayout();
            this.AddNewStaffEntry.ResumeLayout(false);
            this.AddNewStaffEntry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffView)).EndInit();
            this.ResumeLayout(false);

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
    }
}

