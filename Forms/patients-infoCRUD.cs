using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obstetrics_GynecologieClinicManagementSoftware
{
    public partial class patients_infoCRUD : Form
    {
        Functions con;
        Patients p = new Patients();
        public patients_infoCRUD()
        {
            InitializeComponent();
            con = new Functions();
        }

        private void ClosePctrBx_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                string fullname = fullnametb.Text;
                string dob = DOBpicker.Text;
                string blood = bloodgroupcombobx.SelectedItem.ToString();
                string rh = rhdcombobx.SelectedItem.ToString();
                string hus_name = husbandnamecombobx.Text;
                string phone_num = phonecombobx.Text;
                string addresse = addressecombobx.Text;
                string email = emailtxtbx.Text;
                string allrg = allergiescombobx.Text;
                string lmp = LMPDate.Text;
                string edd = EDDDate.Text;
                string s = "Select * From Patient where FullName = '{0}'";
                s = string.Format(s, fullnametb.Text);
                var dat_check = con.GetData(s);
                if (dat_check.Rows.Count == 0)
                {
                    if (fullnametb.Text == "" || DOBpicker.Text == "" || bloodgroupcombobx.SelectedIndex == -1
                    || rhdcombobx.SelectedIndex == -1 || husbandnamecombobx.Text == ""
                    || phonecombobx.Text == "" || addressecombobx.Text == "" || emailtxtbx.Text == ""
                    || allergiescombobx.Text == "" || LMPDate.Text == "" || EDDDate.Text == "")
                    {
                        MessageBox.Show("Fill the Empty Boxes Please!!");
                    }
                    else
                    {
                        
                        string query = "Insert Into Patient values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')";
                        query = string.Format(query, fullname, dob, blood, rh, hus_name, phone_num, addresse, email, allrg, lmp, edd);
                        con.SetData(query);
                        MessageBox.Show("Patient Added Successfully", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (dat_check.Rows.Count > 0)
                { 
                    string query = "Update Patient Set FullName = '{0}',DateOfBirth = '{1}',BloodGroup = '{2}',RhD = '{3}',HusbandName = '{4}',PhoneNumber = '{5}',Addresse = '{6}',Email = '{7}',Allergies = '{8}',LMP = '{9}',EDD = '{10}' where FullName = '{11}'";
                    query = string.Format(query, fullname, dob, blood, rh, hus_name, phone_num, addresse, email, allrg, lmp, edd, fullname);
                    con.SetData(query);
                    MessageBox.Show("Patient Updated Successfully", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                p.Showpatients();
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
