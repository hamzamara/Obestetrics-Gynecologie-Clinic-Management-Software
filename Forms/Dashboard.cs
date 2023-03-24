using Obstetrics_GynecologieClinicManagementSoftware.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obstetrics_GynecologieClinicManagementSoftware
{
    public partial class Dashboard : Form
    {
        Functions con;
        public int chkd_in;
        public int ended;
        public int cncld;
        public Dashboard()
        {
            InitializeComponent();
            con = new Functions();
            Show_dash_appointement();
            appsgridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ttlapointementslbl.Text = (con.GetData("Select * From Appointement").Rows.Count.ToString());
            todayappslbl.Text = appsgridview.Rows.Count.ToString();
            chkd_in = appsgridview.Rows.Cast<DataGridViewRow>()
               .Count(row => row.Cells["Status"].Value.ToString() == "Checked-In");
            ended = appsgridview.Rows.Cast<DataGridViewRow>()
                .Count(row => row.Cells["Status"].Value.ToString() == "Ended");
            cncld = appsgridview.Rows.Cast<DataGridViewRow>()
                .Count(row => row.Cells["Status"].Value.ToString() == "Canceled");
            checkedinlbl.Text = chkd_in.ToString();
            endedvisitslbl.Text = ended.ToString();
            canceledlbl.Text = cncld.ToString();
        }

        public void Show_dash_appointement()
        {
            try
            {
                string query = "Select * from Appointement Where AppDate = '{0}'";
                query = string.Format(query, DateTime.Today.ToString());
                appsgridview.DataSource = con.GetData(query);

            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.Message);
            }
        }
        private void logoutlbl_Click(object sender, EventArgs e)
        {
            Functions.logout(this);
        }

        private void patientsbtn_Click(object sender, EventArgs e)
        {
            Functions.patient_show(this);
        }

        private void appointementbtn_Click(object sender, EventArgs e)
        {
            Functions.appointements_show(this);
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

        private void Checkinbtn_Click(object sender, EventArgs e)
        {
            var new_rcrd = new new_health_record();
            string chk_in = "Update Appointement set Status = '{0}' where AppID = '{1}'";
            string app_id = appsgridview.CurrentRow.Cells["AppID"].Value.ToString();
            chk_in = string.Format(chk_in, "Checked-In", app_id);
            con.SetData(chk_in);
            Refresh();
            MessageBox.Show("New Patient Checked-In", "Checked-In", MessageBoxButtons.OK, MessageBoxIcon.Information);
            new_rcrd.Show();
            new_rcrd.patientshstTB.Text = appsgridview.CurrentRow.Cells["FullName"].Value.ToString();
            Show_dash_appointement();
        }

        private void Endedbtn_Click(object sender, EventArgs e)
        {
            string ended = "Update Appointement set Status = '{0}' where AppID = '{1}'";
            string app_id = appsgridview.CurrentRow.Cells["AppID"].Value.ToString();
            ended = string.Format(ended, "Ended", app_id);
            con.SetData(ended);
            MessageBox.Show("Visit Ended", "Ended", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Show_dash_appointement();
        }

        private void Postponebtn_Click(object sender, EventArgs e)
        {
            try
            {
                var up_app = new appointements_crud();
                up_app.personcombobx.Text = appsgridview.CurrentRow.Cells["FullName"].Value.ToString();
                up_app.dateTimePicker.Text = appsgridview.CurrentRow.Cells["AppDate"].Value.ToString();
                up_app.timerangecombobx.Text = appsgridview.CurrentRow.Cells["TimeRange"].Value.ToString();
                up_app.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Show_dash_appointement();
        }

        private void cnclbtn_Click(object sender, EventArgs e)
        {
            string canceled = "Update Appointement set Status = '{0}' where AppID = '{1}'";
            string app_id = appsgridview.CurrentRow.Cells["AppID"].Value.ToString();
            canceled = string.Format(canceled, "Canceled", app_id);
            con.SetData(canceled);
            MessageBox.Show("Visit Canceled", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Show_dash_appointement();
        }
    }
}
