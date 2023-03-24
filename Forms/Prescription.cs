using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Obstetrics_GynecologieClinicManagementSoftware.Forms
{
    public partial class Prescription : Form
    {
        Functions con;
        DataTable dat1;
     
        public Prescription()
        {
            InitializeComponent();
            con = new Functions();
            dat1 = new DataTable();
            string query1 = "Select * from Patient";
            dat1 = con.GetData(query1);
            namecmbBX.DataSource = dat1;
            namecmbBX.DisplayMember= "FullName";
            namecmbBX.ValueMember= "FullName";
        }
        public void ClearControls()
        {
            mednametxtbx.Clear();
            medtypecmbobox.Select();
            qtytxtbx.Clear();
            dosageTB.Clear();
            var controls1 = new List<System.Windows.Forms.CheckBox>();
            controls1.Add(mrngcb);
            controls1.Add(nooncb);
            controls1.Add(evenngcb);
            controls1.Add(nightcb);
            foreach (var c in controls1)
            {
                if (c.Checked)
                {
                    c.Checked = false;
                }
            }
            var controls2 = new List<System.Windows.Forms.CheckBox>();
            controls2.Add(AFcb);
            controls2.Add(EScb);
            controls2.Add(Bedtmcb);
            controls2.Add(BFcb);
            foreach (var c in controls2)
            {
                if (c.Checked)
                {
                    c.Checked = false;
                }
            }
            foreach (System.Windows.Forms.RadioButton c in durationpanel.Controls)
            {
                if (c.Checked) { c.Checked = false; }
            }
            namecmbBX.Focus();
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

        private void healthrecordbtn_Click(object sender, EventArgs e)
        {
            Functions.healthrcrds_show(this);
        }

        private void logoutlbl_Click(object sender, EventArgs e)
        {
            Functions.logout(this);
        }

        private void communicationbtn_Click(object sender, EventArgs e)
        {
            Functions.communication_show(this);
        }

        private void removemedbtn_Click(object sender, EventArgs e)
        {
            if (presgridview.CurrentRow != null)
            {
                presgridview.Rows.Remove(presgridview.CurrentRow);
            }
            else
            {
                MessageBox.Show("No Medecine Selected!", "Non Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void addmedbtn_Click(object sender, EventArgs e)
        {
            string med_name = mednametxtbx.Text;
            string med_type = medtypecmbobox.Text;
            int qty = Convert.ToInt32(qtytxtbx.Text);
            string dosage = dosageTB.Text;
            string routine = "";
            string pref_time = "";
            string duration = "";
            var controls1 = new List<System.Windows.Forms.CheckBox>();
            controls1.Add(mrngcb);
            controls1.Add(nooncb);
            controls1.Add(evenngcb);
            controls1.Add(nightcb);
            foreach (var c in controls1)
            {
                if (c.Checked)
                {
                    routine += c.Text + "/";
                }
            }
            var controls2 = new List<System.Windows.Forms.CheckBox>();
            controls2.Add(AFcb);
            controls2.Add(EScb);
            controls2.Add(Bedtmcb);
            controls2.Add(BFcb);
            foreach (var c in controls2)
            {
                if (c.Checked)
                {
                    pref_time += c.Text + "/";
                }
            }
            foreach (System.Windows.Forms.RadioButton c in durationpanel.Controls)
            {
                if (c.Checked) { duration = c.Text; }
            }
            presgridview.Rows.Add(med_name, med_type, qty, dosage, routine, pref_time, duration);
            MessageBox.Show("Medecine Added Successfully", "done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearControls();
        }

        private void printbtn_Click(object sender, EventArgs e)
        {
            ((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;
            if (printPreviewDialog1.ShowDialog()== DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string address = "Address";
            string line = "Line, Street Name";
            string country = "Country, Pin Code";
            string tel = "Tel: 123456789";
            string date = "Date :" + DateTime.Now.ToShortDateString();
            string name = namecmbBX.SelectedValue.ToString();
            string dob = "D.O.B : " + dobTB.Text;
            string prescrp = "Prescription";
            string clinic_name = "Eva's Paradise Clinic";
            string signature = "[Signature]";
            var im = pictureBox1.Image;
            int margin = 0;
            Font f1 = new Font("Sylfean", 25, FontStyle.Underline);
            Font f2 = new Font("Sylfean", 20, FontStyle.Regular);
            Font f3 = new Font("Sylfean", 22, FontStyle.Underline);
            Font f4 = new Font("Sylfean", 18, FontStyle.Regular);
            SizeF name_size = e.Graphics.MeasureString(clinic_name, f1);
            SizeF add_size = e.Graphics.MeasureString(address, f2);
            SizeF line_size = e.Graphics.MeasureString(line, f2);
            SizeF cntry_size = e.Graphics.MeasureString(country, f2);
            SizeF tel_size = e.Graphics.MeasureString(tel, f2);
            SizeF signature_size = e.Graphics.MeasureString(signature, f2);
            SizeF presq_size = e.Graphics.MeasureString(prescrp, f3);
            e.Graphics.DrawString(clinic_name, f1, Brushes.CornflowerBlue, (e.PageBounds.Width - name_size.Width)/2, 10);
            e.Graphics.DrawImage(im, 10, 60, 100, 200);
            im.RotateFlip(RotateFlipType.RotateNoneFlipX);
            e.Graphics.DrawImage(im, (e.PageBounds.Width-110), 60, 100, 200);
            im.RotateFlip(RotateFlipType.RotateNoneFlipX);
            e.Graphics.DrawString(address, f2, Brushes.Black, (e.PageBounds.Width - add_size.Width) / 2, 80);
            e.Graphics.DrawString(line, f2, Brushes.Black, (e.PageBounds.Width - line_size.Width) / 2, 120);
            e.Graphics.DrawString(country, f2, Brushes.Black, (e.PageBounds.Width - cntry_size.Width) / 2, 160);
            e.Graphics.DrawString(tel, f2, Brushes.Black, (e.PageBounds.Width - tel_size.Width) / 2, 200);
            e.Graphics.DrawString(name, f2, Brushes.Black, 40 , 300);
            e.Graphics.DrawString(dob, f2, Brushes.Black, 280, 300);
            e.Graphics.DrawString(date, f2, Brushes.Black, e.PageBounds.Width - 250, 300);
            e.Graphics.DrawString(signature, f2, Brushes.Black, (e.PageBounds.Width - signature_size.Width) / 2, e.PageBounds.Height - 50);
            e.Graphics.DrawString(prescrp, f3, Brushes.Black, (e.PageBounds.Width - presq_size.Width) / 2, 380);
            foreach (DataGridViewRow row in presgridview.Rows)
            {
                string med_name = row.Cells["MedecineName"].Value.ToString();
                string qty = row.Cells["Qty"].Value.ToString();
                string dosage = row.Cells["Dosage"].Value.ToString();
                string routine = row.Cells["Routine"].Value.ToString();
                string pref_time = row.Cells["PreferredTime"].Value.ToString();
                string duration = row.Cells["Duration"].Value.ToString();
                e.Graphics.DrawString("- " + med_name + "   " + dosage, f4, Brushes.Black, 40, 500+margin);
                e.Graphics.DrawString("x" + qty, f4, Brushes.Black, 700, 500+margin);
                e.Graphics.DrawString(routine + "***" + pref_time + "***" + duration, f4, Brushes.Black, 80, 540 + margin);
                margin += 150;
            }
            margin = 0;
        }
    }
}
