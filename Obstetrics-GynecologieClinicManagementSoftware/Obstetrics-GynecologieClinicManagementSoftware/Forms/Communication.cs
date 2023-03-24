using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obstetrics_GynecologieClinicManagementSoftware.Forms
{
    public partial class Communication : Form
    {
        public Communication()
        {
            InitializeComponent();
        }

        private void logoutlbl_Click(object sender, EventArgs e)
        {
            Functions.logout(this);
        }

        private void prescriptionbtn_Click(object sender, EventArgs e)
        {
            Functions.prescription_show(this);
        }

        private void healthrecordbtn_Click(object sender, EventArgs e)
        {
            Functions.healthrcrds_show(this);
        }

        private void appointementbtn_Click(object sender, EventArgs e)
        {
            Functions.appointements_show(this);
        }

        private void patientsbtn_Click(object sender, EventArgs e)
        {
            Functions.patient_show(this);
        }

        private void Dashboardbtn_Click(object sender, EventArgs e)
        {
            Functions.dashboard_show(this);
        }

        private void sendbtn_Click(object sender, EventArgs e)
        {
            string fromMail = "evaparadiseclinic@gmail.com";
            string fromPass = "awhrixbfyupvxoeo";
            string recepient = recepienttxtbx.Text;
            string subject = sbjcttxtbx.Text;
            string body = msgrichTextBox.Text;

            var message = new MailMessage();
            message.From = new MailAddress(fromMail);
            message.To.Add(new MailAddress(recepient));
            message.Subject = subject;
            message.Body = body;

            var smtpclient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromMail, fromPass),
                EnableSsl = true
            };
            try
            {
                smtpclient.Send(message);
                MessageBox.Show("Email sent Successfully!", "Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
