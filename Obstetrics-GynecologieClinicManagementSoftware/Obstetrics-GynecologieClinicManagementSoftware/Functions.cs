using Obstetrics_GynecologieClinicManagementSoftware.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obstetrics_GynecologieClinicManagementSoftware
{
    public class Functions
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private DataTable dt;
        public Functions() 
        {
            con= new SqlConnection("Data Source = .\\SQLEXPRESS; Initial Catalog = Ob_GynClinicMangSoft; Integrated Security = true");
            cmd = new SqlCommand();
            cmd.Connection = con;
            
        }
        public DataTable GetData(string query)
        {
            dt = new DataTable();
            da = new SqlDataAdapter(query, con);
            da.Fill(dt);
            return dt;
        }

        public int SetData(string query)
        {
            int cnt = 0;
            if (con.State == ConnectionState.Closed) { con.Open(); }
            cmd.CommandText = query;
            cnt = cmd.ExecuteNonQuery();
            con.Close();
            return cnt;
        }

        public static void logout(Form fr)
        {
            var lg = new Login();
            lg.Show();
            fr.Hide();
        }
        public static void dashboard_show(Form fr)
        {
            var ds = new Dashboard();
            ds.Show();
            fr.Hide();
        }
        public static void patient_show(Form fr)
        {
            var ps = new Patients();
            ps.Show();
            fr.Hide();
        }
        public static void appointements_show(Form fr)
        {
            var ap = new Appointements();
            ap.Show();
            fr.Hide();
        }
        public static void healthrcrds_show(Form fr)
        {
            var h = new HealthRecords();
            h.Show();
            fr.Hide();
        }
        public static void prescription_show(Form fr)
        {
            var prscrp = new Prescription();
            prscrp.Show();
            fr.Hide();
        }
        public static void communication_show(Form fr)
        {
            var comm = new Communication();
            comm.Show();
            fr.Hide();
        }
    }
}
