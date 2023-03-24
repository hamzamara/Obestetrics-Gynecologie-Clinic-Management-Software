using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obstetrics_GynecologieClinicManagementSoftware.Forms
{
    public partial class HealthRecords : Form
    {
        Functions con;
        DataTable dt = new DataTable();
        public HealthRecords()
        {
            InitializeComponent();
            con = new Functions();
            dt = con.GetData("Select * from Patient");
            patientslstGridView.DataSource = dt;
        }

        private void Dashboardbtn_Click(object sender, EventArgs e)
        {
            Functions.dashboard_show(this);
        }

        private void patientsbtn_Click(object sender, EventArgs e)
        {
            Functions.patient_show(this);
        }

        private void appointementbtn_Click(object sender, EventArgs e)
        {
            Functions.appointements_show(this);
        }

        private void logoutlbl_Click(object sender, EventArgs e)
        {
            Functions.logout(this);
        }

        private void ShowHstrybtn_Click(object sender, EventArgs e)
        {
            var shw_hsr = new show_history();
            try
            {
                string tb_name = patientslstGridView.CurrentRow.Cells["FullName"].Value.ToString();
                string query = "Select * from [{0}]";
                query = string.Format(query, tb_name);
                shw_hsr.recrd_grdview.DataSource = con.GetData(query);
                shw_hsr.ShowDialog();
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("There is no records for this Patient", "Message",  MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void pregnncydetlsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var preg_dtls = new pregnancy_details();
                var lmp = ((DateTime)patientslstGridView.CurrentRow.Cells["LMP"].Value);
                var edd = ((DateTime)patientslstGridView.CurrentRow.Cells["EDD"].Value);
                var today = DateTime.Today;
                var diff_date = today.Subtract(lmp);
                int days = diff_date.Days;
                int weeks = days / 7;
                preg_dtls.pregprogressBar.Value = weeks;
                preg_dtls.weekssnmbrLBL.Text = weeks.ToString();
                preg_dtls.babyimg.Image = Image.FromFile("Babies\\" + weeks + ".jpg");
                preg_dtls.LMPLbl.Text += lmp.ToShortDateString();
                preg_dtls.EDDLbl.Text += edd.ToShortDateString();
                preg_dtls.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void addnewrcrdbtn_Click(object sender, EventArgs e)
        {
            var hr = new new_health_record();
            hr.patientshstTB.Text = patientslstGridView.CurrentRow.Cells["FullName"].Value.ToString();
            hr.ShowDialog();
        }

        private void prescriptionbtn_Click(object sender, EventArgs e)
        {
            Functions.prescription_show(this);
        }

        private void communicationbtn_Click(object sender, EventArgs e)
        {
            Functions.communication_show(this);
        }

        private void srchtxtbx_TextChanged(object sender, EventArgs e)
        {
            var dv = dt.DefaultView;
            if (srchtxtbx.Text!= "Eg. Name")
            {
                dv.RowFilter = "FullName Like '%" + srchtxtbx.Text + "%'";
            }
        }

        private void srchtxtbx_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(srchtxtbx.Text))
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
