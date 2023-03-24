namespace Obstetrics_GynecologieClinicManagementSoftware
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (UserTb.Text == "" || passwordTb.Text == "")
            {
                MessageBox.Show("Fill the Empty Fields!!", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UserTb.Focus();
            }
            else if (UserTb.Text == "hamza_amara" && passwordTb.Text == "azerty")
            {
                this.Hide();
                Dashboard ds = new Dashboard();
                ds.Show();
            }
            else
            {
                MessageBox.Show("Invalid Credentials!!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UserTb.Focus();
            }
        }
    }
}