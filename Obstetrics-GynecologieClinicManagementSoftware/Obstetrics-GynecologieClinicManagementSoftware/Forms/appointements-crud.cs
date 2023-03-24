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
    public partial class appointements_crud : Form
    {
        Functions con;
        public appointements_crud()
        {
            InitializeComponent();
            con = new Functions();
            DataTable dat = new DataTable();
            string s = "Select * from Patient";
            dat = con.GetData(s);
            personcombobx.DataSource = dat;
            personcombobx.DisplayMember = "FullName";
            personcombobx.ValueMember = "FullName";
        }

        private void ClosePctrBx_Click(object sender, EventArgs e)
        {
            var app = new Appointements();
            Close();
            app.Show();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                var app = new Appointements();
                string date_app = dateTimePicker.Text;
                string time_rng = timerangecombobx.SelectedItem.ToString();
                string person = personcombobx.SelectedValue.ToString();
                string status = "Waiting for Arrival";
                string s = "Select * From Appointement where FullName = '{0}'";
                s = string.Format(s, personcombobx.SelectedValue.ToString());
                var dat_check = con.GetData(s);
                if (dat_check.Rows.Count == 0 ) 
                {
                    string query = "Insert Into Appointement values ('{0}', '{1}', '{2}', '{3}')";
                    query = string.Format(query, person, date_app, time_rng, status);
                    con.SetData(query);
                    MessageBox.Show("Appointement Set Seccussfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else if (dat_check.Rows.Count > 0)
                {
                    string query = "Update Appointement set AppDate = '{0}', TimeRange = '{1}' Where FullName = '{2}'";
                    query = string.Format(query, date_app, time_rng, person);
                    con.SetData(query);
                    MessageBox.Show("Appointement Updated Seccussfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                app.ShowAppointement();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
