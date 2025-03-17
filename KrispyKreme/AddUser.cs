using System;
using System.Windows.Forms;
using KrispyKreme;

namespace KrispyKreme
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }
        private void AddUser_Load(object sender, EventArgs e)
        {
            // This can be empty or contain setup code for the form
        }


        private void btn_adduser_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username and password cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (DatabaseHelper.AddUser(username, password))
            {
                MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();  // Close AddUser form
            }
            else
            {
                MessageBox.Show("Failed to add user. Username might already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }




    }
}
