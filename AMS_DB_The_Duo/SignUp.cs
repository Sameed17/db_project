using System.Windows.Forms;

namespace AMS_DB_The_Duo
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void btn_signin_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            var form = new login();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
    }
}
