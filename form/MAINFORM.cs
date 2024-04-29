using System;
using System.Windows.Forms;

namespace UserAuthenticationApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnOpenLogin_Click(object sender, EventArgs e)
        {
            // Open LoginForm when the "Login" button is clicked
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
