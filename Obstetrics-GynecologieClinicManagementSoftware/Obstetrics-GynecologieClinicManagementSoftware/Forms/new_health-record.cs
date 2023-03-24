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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Obstetrics_GynecologieClinicManagementSoftware.Forms
{
    public partial class new_health_record : Form
    {
        Functions con;
        public new_health_record()
        {
            InitializeComponent();
            con = new Functions();
            DataTable dat = new DataTable();
            string s = "Select * from Patient";
            dat = con.GetData(s);
            patientshstTB.DataSource = dat;
            patientshstTB.DisplayMember = "FullName";
            patientshstTB.ValueMember = "FullName";
        }

        private void ClosePctrBx_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            DataTable dat = new DataTable();
            
            try
            {
                string tbl_name = patientshstTB.SelectedValue.ToString();
                string qr;
                try 
                { 
                string query = "select * from [{0}]";
                query = string.Format(query, tbl_name);
                dat = con.GetData(query);
                }
                catch (SqlException)
                {
                    qr = "Create Table [{0}] (Visit_Date date NOT NULL PRIMARY KEY, Weight_Kg float(10) NOT NULL, Height_cm float(10) NOT NULL," +
                         "Heart_Rate_bpm bigint NOT NULL, Temperature_C float(10) NOT NULL,"+
                         "Blood_Pressure_mmHg float(10) NOT NULL, Heart_Blood_Pressure_mmHg float(10) NOT NULL)";
                    qr = string.Format(qr, tbl_name);
                    con.SetData(qr);
                    MessageBox.Show("New Table For Patient Created Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                string qer = "INSERT INTO [{0}] VALUES ('{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')";
                qer = string.Format(qer, tbl_name, dateTimePicker.Text, whighttb.Text, heighttb.Text, heartratetb.Text, temptb.Text, bptb.Text, hbptb.Text);
                con.SetData(qer);
                MessageBox.Show("Record Added Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
