using System;
using System.Windows.Forms;
using KrispyKreme;

namespace KrispyKreme
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

            if (DatabaseHelper.ValidateUser(username, password))
            {
                MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // ✅ Store the logged-in username
                this.Tag = username;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_adduser_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide LoginForm
            AddUser addUserForm = new AddUser();
            addUserForm.ShowDialog(); // Show AddUser form as a modal dialog
            this.Show(); // Show LoginForm again when AddUser is closed
        }

    }
}
