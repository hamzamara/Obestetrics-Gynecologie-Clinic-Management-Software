using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Obstetrics_GynecologieClinicManagementSoftware
{
    public partial class Patients : Form
    {
        Functions con;
        public Patients()
        {
            InitializeComponent();
            con = new Functions();
            Showpatients();
        }

        public void Showpatients()
        {
            try
            {
                string query = "Select * from Patient";
                patientslistgrid.DataSource = con.GetData(query);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        
        private void logoutlbl_Click_1(object sender, EventArgs e)
        {
            Functions.logout(this);
        }

        private void appointementbtn_Click_1(object sender, EventArgs e)
        {
            Functions.appointements_show(this);
        }

        private void Dashboardbtn_Click(object sender, EventArgs e)
        {
            Functions.dashboard_show(this);
        }

        private void addnewbtn_Click(object sender, EventArgs e)
        {
            var new_pat = new patients_infoCRUD();
            new_pat.Show();
        }
        private void healthrecordbtn_Click(object sender, EventArgs e)
        {
            Functions.healthrcrds_show(this);
        }

        private void prescriptionbtn_Click(object sender, EventArgs e)
        {
            Functions.prescription_show(this);
        }

        private void communicationbtn_Click(object sender, EventArgs e)
        {
            Functions.communication_show(this);
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            var up_pat = new patients_infoCRUD();
            up_pat.Show();
            up_pat.fullnametb.Text = patientslistgrid.CurrentRow.Cells["FullName"].Value.ToString();
            up_pat.DOBpicker.Text = patientslistgrid.CurrentRow.Cells["DateOfBirth"].Value.ToString();
            up_pat.bloodgroupcombobx.Text = patientslistgrid.CurrentRow.Cells["BloodGroup"].Value.ToString();
            up_pat.rhdcombobx.Text = patientslistgrid.CurrentRow.Cells["RhD"].Value.ToString();
            up_pat.husbandnamecombobx.Text = patientslistgrid.CurrentRow.Cells["HusbandName"].Value.ToString();
            up_pat.phonecombobx.Text = patientslistgrid.CurrentRow.Cells["PhoneNumber"].Value.ToString();
            up_pat.addressecombobx.Text = patientslistgrid.CurrentRow.Cells["Addresse"].Value.ToString();
            up_pat.emailtxtbx.Text = patientslistgrid.CurrentRow.Cells["Email"].Value.ToString();
            up_pat.allergiescombobx.Text = patientslistgrid.CurrentRow.Cells["Allergies"].Value.ToString();
            up_pat.LMPDate.Text = patientslistgrid.CurrentRow.Cells["LMP"].Value.ToString();
            up_pat.EDDDate.Text = patientslistgrid.CurrentRow.Cells["EDD"].Value.ToString();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are You Sure To Delete This Patient?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string query = "Delete from Patient Where PatID = '{0}'";
                query = string.Format(query, patientslistgrid.CurrentRow.Cells["PatID"].Value.ToString());
                con.SetData(query);
                MessageBox.Show("Patient Deleted Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Showpatients();
        }
    }
}
