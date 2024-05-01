using System.Windows.Forms;

namespace AMS_DB_The_Duo
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, System.EventArgs e)
        {
            if (tb_email.Text == "s" && tb_password.Text == "s")
            {
                this.Hide();
                var form = new Admin(this);
                form.Closed += (s, args) => this.Close();
                form.Show();
            }
            else
            {
                MessageBox.Show("Invalid Credentials");
            }
        }
        private void OnMouseEnterButton1(object sender, System.EventArgs e)
        {
            this.btn_login.FlatAppearance.BorderSize = 5;
        }
        private void OnMouseLeaveButton1(object sender, System.EventArgs e)
        {
            this.btn_login.FlatAppearance.BorderSize = 0;
        }

        private void btn_signup_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            var form = new SignUp();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
    }
}
