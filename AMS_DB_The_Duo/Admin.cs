using System;
using System.Windows.Forms;

namespace AMS_DB_The_Duo
{
    public partial class Admin : Form
    {
        Form form1;
        public Admin(Form form)
        {
            form1 = form;
            InitializeComponent();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Hide();
        }
    }
}
