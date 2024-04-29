using System;
using System.Windows.Forms;

namespace UserAuthenticationApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Example: Perform authentication (replace with your logic)
            if (username == "admin" && password == "admin123")
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Open RegistrationForm when the "Register" link is clicked
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
        }
    }
}
