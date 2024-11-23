using Wisej.Web;
using Dapper;
using System;
using System.Data.Entity;
using Microsoft.Ajax.Utilities;
using System.Data;
using System.Linq;

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
            using(var db = DB.GetConnection())
            {
                OrganizationsView.DataSource = db.Query<Organization>("SELECT * FROM Organization");
                StaffView.DataSource = db.Query<Staff>("SELECT * FROM Staff");

                var orgnamequery = db.Query<string>("SELECT Name FROM Organization");
                foreach (string s in orgnamequery)
                    StaffOrgEntry.MenuItems.Add(s);
            }
            OrganizationsView.Columns["OrgID"].Visible = false;
            StaffView.Columns["OrgID"].Visible = false;
            StaffView.Columns["StaffID"].Visible = false;
            AddNewOrgEntry.Collapsed = true;
            AddNewStaffEntry.Collapsed = true;
        }

        private void OrganizationsView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var val = "'" + OrganizationsView.Rows[e.RowIndex][e.ColumnIndex].Value.ToString() + "'";
            var col = OrganizationsView.Columns[e.ColumnIndex].Name;
            var id = (int)OrganizationsView.Rows[e.RowIndex]["OrgID"].Value;
            using(var db = DB.GetConnection())
            {
                db.Execute("UPDATE Organization SET " + col + " = " + val + " WHERE OrgID = " + id);
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
        
            using (var db = DB.GetConnection())
            {
                db.Execute("INSERT INTO Organization (Name, Street, Zip, City, Country) VALUES (" 
                    + "'" + OrgNameEntry.Text + "'" + ','
                    + "'" + OrgStreetEntry.Text + "'" + ','
                    + "'" + OrgZipEntry.Text + "'" + ','
                    + "'" + OrgCityEntry.Text + "'" + ','
                    + "'" + OrgCountryEntry.Text + "'" + ")");
                OrganizationsView.DataSource = db.Query<Organization>("SELECT * FROM Organization");

                var orgnamequery = db.Query<string>("SELECT Name FROM Organization");
                StaffOrgEntry.MenuItems.Clear();
                foreach (string s in orgnamequery)
                    StaffOrgEntry.MenuItems.Add(s);
            }
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

            using (var db = DB.GetConnection())
            {
                var orgidquery = db.Query<int>("SELECT OrgID FROM Organization WHERE Name = '" + StaffOrgEntry.Text + "'");
                int orgid = 0;
                if (!orgidquery.Any())
                {
                    AlertBox.Show("Organization " + StaffOrgEntry.Text + " does not exist", MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    foreach (int i in orgidquery)
                        orgid = i;
                }

                db.Execute("INSERT INTO Staff (OrgID, Title, FirstName, LastName, PhoneNumber, EmailAddress) VALUES ("
                    + "'" + orgid.ToString() + "'" + ','
                    + "'" + StaffTitleEntry.Text + "'" + ','
                    + "'" + StaffFirstNameEntry.Text + "'" + ','
                    + "'" + StaffLastNameEntry.Text + "'" + ','
                    + "'" + StaffPhoneNumEntry.Text + "'" + ','
                    + "'" + StaffEmailEntry.Text + "'" + ")");
                StaffView.DataSource = db.Query<Staff>("SELECT * FROM Staff");
            }
            AlertBox.Show("New Staff Entry Added!");
        }

        private void StaffView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var val = "'" + StaffView.Rows[e.RowIndex][e.ColumnIndex].Value.ToString() + "'";
            var col = StaffView.Columns[e.ColumnIndex].Name;
            var id = (int)StaffView.Rows[e.RowIndex]["StaffID"].Value;
            using (var db = DB.GetConnection())
            {
                db.Execute("UPDATE Staff SET " + col + " = " + val + " WHERE StaffID = " + id);
            }
            AlertBox.Show("Staff Table Updated!");
        }

        private void OrgLockButton_Click(object sender, EventArgs e)
        {
            if (OrganizationsView.ReadOnly)
            {
                OrganizationsView.ReadOnly = false;
                OrgLockButton.Text = "Table: Unlocked 🔓";
            }
            else
            { 
                OrganizationsView.ReadOnly = true;
                OrgLockButton.Text = "Table: Locked 🔒";
            }
        }

        private void StaffLockButton_Click(object sender, EventArgs e)
        {
            if (StaffView.ReadOnly)
            {
                StaffView.ReadOnly = false;
                StaffLockButton.Text = "Table: Unlocked 🔓";
            }
            else
            {
                StaffView.ReadOnly = true;
                StaffLockButton.Text = "Table: Locked 🔒";
            }
        }

        private void StaffOrgEntry_ItemClicked(object sender, MenuButtonItemClickedEventArgs e)
        {
            StaffOrgEntry.Text = e.Item.Text;
        }
    }
}
