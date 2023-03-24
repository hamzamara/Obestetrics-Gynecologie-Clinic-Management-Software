using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obstetrics_GynecologieClinicManagementSoftware
{
    public partial class Appointements : Form
    {
        Functions con;
        DataTable dt = new DataTable();
        public Appointements()
        {
            InitializeComponent();
            con = new Functions();
            ShowAppointement();
            appointementlistgrdview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void ShowAppointement()
        {
            try
            {
                string query = "Select * from Appointement";
                dt = con.GetData(query);
                appointementlistgrdview.DataSource = dt;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void logoutlbl_Click(object sender, EventArgs e)
        {
            Functions.logout(this);
        }

        private void Dashboardbtn_Click(object sender, EventArgs e)
        {
            Functions.dashboard_show(this);
        }

        private void patientsbtn_Click(object sender, EventArgs e)
        {
            Functions.patient_show(this);
        }

        private void addnewbtn_Click(object sender, EventArgs e)
        {
            var new_app = new appointements_crud();
            new_app.Show();
        }
        private void healthrecordbtn_Click_1(object sender, EventArgs e)
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
            try
            {
                var up_app = new appointements_crud();
                up_app.personcombobx.Text = appointementlistgrdview.CurrentRow.Cells["FullName"].Value.ToString();
                up_app.dateTimePicker.Text = appointementlistgrdview.CurrentRow.Cells["AppDate"].Value.ToString();
                up_app.timerangecombobx.Text = appointementlistgrdview.CurrentRow.Cells["TimeRange"].Value.ToString();
                up_app.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are You Sure To Delete This Appointement?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string query = "Delete from Appointement Where AppID = '{0}'";
                query = string.Format(query, appointementlistgrdview.CurrentRow.Cells["AppID"].Value.ToString());
                con.SetData(query);
                MessageBox.Show("Appointement Deleted Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ShowAppointement();

        }

        private void srchtxtbx_TextChanged(object sender, EventArgs e)
        {
            var dv = dt.DefaultView;
            if (srchtxtbx.Text!= "Eg. Name")
            {
                dv.RowFilter = "FullName Like '%" + srchtxtbx.Text + "%'";
            }
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            var dv = dt.DefaultView;
            string filter = "AppDate = #{0}#";
            filter = string.Format(filter, dateTimePicker1.Value.Date);
            dv.RowFilter = filter;
            
        }

        private void srchtxtbx_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(srchtxtbx.Text))
            {
                srchtxtbx.Text = "Eg. Name";
                srchtxtbx.ForeColor = Color.Gray;
            }
        }

        private void srchtxtbx_Enter(object sender, EventArgs e)
        {
            if (srchtxtbx.Text == "Eg. Name")
            {
                srchtxtbx.Text = "";
            }
            srchtxtbx.ForeColor = Color.Black;
        }
    }
}
