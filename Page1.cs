using Wisej.Web;
using Dapper;
using System;
using System.Data.Entity;
using Microsoft.Ajax.Utilities;
using System.Data;
using System.Linq;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Text;
using Wisej.Core;
using System.Drawing.Text;

namespace WisejWebPageApplication1
{
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Page1_Load(object sender, System.EventArgs e)
        {
            LoadDatabaseViews();

            foreach (var row in StaffView.Rows)
                row["Remove"].Control.Enabled = false;
            foreach (var row in OrganizationsView.Rows)
                row["Remove"].Control.Enabled = false;

            OrganizationsView.Columns["OrgID"].Visible = false;
            StaffView.Columns["OrgID"].Visible = false;
            StaffView.Columns["StaffID"].Visible = false;
            AddNewOrgEntry.Collapsed = true;
            AddNewStaffEntry.Collapsed = true;
        }

        private void LoadOrgStaff()
        {
            if (!StaffView.Columns.Contains("Organization"))
                StaffView.Columns.Add(new DataGridViewColumn() { Name = "Organization", HeaderText = "Organization" });
            StaffView.Columns["Organization"].DisplayIndex = 0;
            using (var db = DB.GetConnection())
            {
                if (OrganizationsView.SelectedRows.Count > 0)
                    StaffView.DataSource = db.Query<Staff>("SELECT * FROM Staff WHERE OrgID = @id", new { id = OrganizationsView.CurrentRow["OrgID"].Value });
                else
                    StaffView.DataSource = db.Query<Staff>("SELECT * FROM Staff");
                foreach (var r in StaffView.Rows)
                {
                    string name;
                    name = db.Query<string>("SELECT Name FROM Organization WHERE OrgID = @id", new { id = r["OrgID"].Value }).First();
                    r["Organization"].Value = name;
                }
            }
            //Add Delete Button Column in StaffView
            if (!StaffView.Columns.Contains("Remove"))
                StaffView.Columns.Add(new DataGridViewColumn() { Name = "Remove", HeaderText = "Remove", MinimumWidth = 100 });
            foreach (var r in StaffView.Rows)
            {
                var delbutton = new Button() { Text = "Delete", Dock = DockStyle.Fill, BackColor = Color.Red, Enabled = false };
                delbutton.Click += DeleteStaffRow_Click;
                r["Remove"].Control = delbutton;
            }
        }

        private void LoadDatabaseViews()
        {
            using (var db = DB.GetConnection())
            {
                OrganizationsView.DataSource = db.Query<Organization>("SELECT * FROM Organization");

                //Update org list drop down for adding new staff
                var orgnamequery = db.Query<string>("SELECT Name FROM Organization");
                StaffOrgEntry.MenuItems.Clear();
                foreach (string s in orgnamequery)
                    StaffOrgEntry.MenuItems.Add(s);
                foreach (MenuItem v in StaffOrgEntry.MenuItems)
                    v.Font = new System.Drawing.Font(new FontFamily("Arial"), 13, FontStyle.Regular);
            }

            //Show staff of currently selected Organization
            LoadOrgStaff();

            //Add Delete Button Column in OrgView
            if (!OrganizationsView.Columns.Contains("Remove"))
                OrganizationsView.Columns.Add(new DataGridViewColumn() { Name = "Remove", HeaderText = "Remove", MinimumWidth = 100 });
            foreach (var r in OrganizationsView.Rows)
            {
                var delbutton = new Button() { Text = "Delete", Dock = DockStyle.Fill, BackColor = Color.Red, Enabled = false };
                delbutton.Click += DeleteOrganizationRow_Click;
                r["Remove"].Control = delbutton;
            }
        }

        private void OrganizationsView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var col = OrganizationsView.Columns[e.ColumnIndex].Name;
            using (var db = DB.GetConnection())
            {
                string sql = $"UPDATE Organization SET {col} = @valinput WHERE OrgID = @idinput";
                db.Execute(sql,
                    new { valinput = OrganizationsView.Rows[e.RowIndex][e.ColumnIndex].Value, idinput = OrganizationsView.Rows[e.RowIndex]["OrgID"].Value });
            }
            AlertBox.Show("Organization Table Updated!");
        }

        private void AddNewOrgButton_Click(object sender, EventArgs e)
        {
            int num;
            if (!int.TryParse(OrgZipEntry.Text, out num))
            {
                AlertBox.Show("Zip Code must be a number!", MessageBoxIcon.Error);
                return;
            }
            if (OrgNameEntry.Text == "" || OrgStreetEntry.Text == "" || OrgZipEntry.Text == "" || OrgCityEntry.Text == "" || OrgCountryEntry.Text == "")
            {
                AlertBox.Show("All entries must be filled!", MessageBoxIcon.Error);
                return;
            }

            using (var db = DB.GetConnection())
            {
                db.Execute("INSERT INTO Organization (Name, Street, Zip, City, Country) VALUES (@orgname, @orgstreet, @orgzip, @orgcity, @orgcountry)", 
                    new { orgname = OrgNameEntry.Text, orgstreet = OrgStreetEntry.Text, orgzip = OrgZipEntry.Text, orgcity = OrgCityEntry.Text, orgcountry = OrgCountryEntry.Text });
            }
            LoadDatabaseViews();
            AlertBox.Show("New Organization Entry Added!");
        }

        private void AddNewStaffButton_Click(object sender, EventArgs e)
        {
            int num;
            if (!int.TryParse(StaffPhoneNumEntry.Text, out num))
            {
                AlertBox.Show("Phone Number must be a number!", MessageBoxIcon.Error);
                return;
            }
            if (!StaffEmailEntry.Text.Contains("@"))
            {
                AlertBox.Show("Must enter a valid email address!", MessageBoxIcon.Error);
                return;
            }
            if (StaffOrgEntry.Text == "Organization:")
            {
                AlertBox.Show("Must select an organization from the dropdown!", MessageBoxIcon.Error);
                return;
            }

            using (var db = DB.GetConnection())
            {
                var orgidquery = db.Query<int>("SELECT OrgID FROM Organization WHERE Name = @n", new { n = StaffOrgEntry.Text });
                int orgid = orgidquery.First();

                db.Execute("INSERT INTO Staff (OrgID, Title, FirstName, LastName, PhoneNumber, EmailAddress) VALUES (@oid, @stafftitle, @stafffirstname, @stafflastname, @staffphone, @staffemail)",
                    new { oid = orgid, stafftitle = StaffTitleEntry.Text, stafffirstname = StaffFirstNameEntry.Text, stafflastname = StaffLastNameEntry.Text, staffphone = StaffPhoneNumEntry.Text, staffemail = StaffEmailEntry.Text });
            }
            LoadDatabaseViews();
            AlertBox.Show("New Staff Entry Added!");
        }

        private void StaffView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (StaffView.Columns[e.ColumnIndex].Name == "Organization")
                return;

            var col = StaffView.Columns[e.ColumnIndex].Name;
            using (var db = DB.GetConnection())
            {
                string sql = $"UPDATE Staff SET {col} = @valinput WHERE StaffID = @idinput";
                db.Execute(sql,
                    new { valinput = StaffView.Rows[e.RowIndex][e.ColumnIndex].Value, idinput = (int)StaffView.Rows[e.RowIndex]["StaffID"].Value });
            }
            AlertBox.Show("Staff Table Updated!");
        }

        private void OrgLockButton_Click(object sender, EventArgs e)
        {
            if (OrganizationsView.ReadOnly)
            {
                OrganizationsView.ReadOnly = false;
                OrgLockButton.Text = "Table: Unlocked 🔓";
                OrgLockButton.BackColor = SystemColors.ButtonFace;
                foreach (var row in OrganizationsView.Rows)
                    row["Remove"].Control.Enabled = true;
            }
            else
            { 
                OrganizationsView.ReadOnly = true;
                OrgLockButton.Text = "Table: Locked 🔒";
                OrgLockButton.BackColor = Color.DarkRed;
                foreach (var row in OrganizationsView.Rows)
                    row["Remove"].Control.Enabled = false;
            }
        }

        private void StaffLockButton_Click(object sender, EventArgs e)
        {
            if (StaffView.ReadOnly)
            {
                StaffView.ReadOnly = false;
                StaffLockButton.Text = "Table: Unlocked 🔓";
                StaffLockButton.BackColor = SystemColors.ButtonFace;
                foreach (var row in StaffView.Rows)
                    row["Remove"].Control.Enabled = true;
            }
            else
            {
                StaffView.ReadOnly = true;
                StaffLockButton.Text = "Table: Locked 🔒";
                StaffLockButton.BackColor = Color.DarkRed;
                foreach (var row in StaffView.Rows)
                    row["Remove"].Control.Enabled = false;
            }
        }

        private void StaffOrgEntry_ItemClicked(object sender, MenuButtonItemClickedEventArgs e)
        {
            StaffOrgEntry.Text = e.Item.Text;
        }

        private void DeleteStaffRow_Click(object sender, EventArgs e)
        {
            using (var db = DB.GetConnection())
            {
                foreach (var r in StaffView.Rows)
                {
                    if (r["Remove"].Control == (Button)sender)
                    {
                        db.Execute("DELETE FROM Staff WHERE StaffID = @id", new { id = r["StaffID"].Value });
                        break;
                    }
                }
            }
            LoadDatabaseViews();
            AlertBox.Show("Staff Entry Deleted");
        }

        private void DeleteOrganizationRow_Click(object sender, EventArgs e)
        {
            using (var db = DB.GetConnection())
            {
                foreach (var r in OrganizationsView.Rows)
                {
                    if (r["Remove"].Control == (Button)sender)
                    {
                        var staffids = db.Query<int>("SELECT OrgID FROM Staff");
                        foreach (int i in staffids)
                        {
                            if (i == (int)r["OrgID"].Value)
                            {
                                AlertBox.Show("Cannot Delete Organzation, Dependent Staff Present", MessageBoxIcon.Warning);
                                return;
                            }
                        }
                        db.Execute("DELETE FROM Organization WHERE OrgID = @id", new { id = r["OrgID"].Value });
                        LoadDatabaseViews();
                        AlertBox.Show("Organization Deleted");
                        return;
                    }
                }
            }
        }

        private void OrganizationsView_SelectionChanged(object sender, EventArgs e)
        {
            LoadOrgStaff();

            if (OrganizationsView.CurrentRow is null)
                StaffLabel.Text = "Staff:";
            else
                StaffLabel.Text = (string)OrganizationsView.CurrentRow["Name"].Value + " Staff:";

            if (StaffLockButton.Text.Contains("🔓"))
                StaffLockButton.PerformClick();
        }
    }
}
