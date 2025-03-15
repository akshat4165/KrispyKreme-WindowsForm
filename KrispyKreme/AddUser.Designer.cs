namespace KrispyKreme
{
    partial class AddUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            pictureBox1 = new PictureBox();
            btn_adduser = new Button();
            btnLogin = new Button();
            lblPassword = new Label();
            lblUsername = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Krispy_Kreme;
            pictureBox1.Location = new Point(-4, -8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1655, 360);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btn_adduser
            // 
            btn_adduser.BackColor = Color.DarkGreen;
            btn_adduser.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold);
            btn_adduser.ForeColor = Color.White;
            btn_adduser.Location = new Point(853, 738);
            btn_adduser.Margin = new Padding(5, 6, 5, 6);
            btn_adduser.Name = "btn_adduser";
            btn_adduser.Size = new Size(193, 80);
            btn_adduser.TabIndex = 9;
            btn_adduser.Text = "Add User";
            btn_adduser.UseVisualStyleBackColor = false;
            btn_adduser.Click += btn_adduser_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DarkGreen;
            btnLogin.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(599, 738);
            btnLogin.Margin = new Padding(5, 6, 5, 6);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(193, 80);
            btnLogin.TabIndex = 10;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold | FontStyle.Italic);
            lblPassword.ForeColor = Color.White;
            lblPassword.Location = new Point(515, 607);
            lblPassword.Margin = new Padding(5, 0, 5, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(196, 50);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Password:";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold | FontStyle.Italic);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(515, 512);
            lblUsername.Margin = new Padding(5, 0, 5, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(206, 50);
            lblUsername.TabIndex = 7;
            lblUsername.Text = "Username:";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtPassword.Location = new Point(791, 609);
            txtPassword.Margin = new Padding(5, 6, 5, 6);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(322, 50);
            txtPassword.TabIndex = 6;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtUsername.Location = new Point(791, 514);
            txtUsername.Margin = new Padding(5, 6, 5, 6);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(322, 50);
            txtUsername.TabIndex = 5;
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(1648, 1034);
            Controls.Add(btn_adduser);
            Controls.Add(btnLogin);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Krispy Kreme Add User";
            Load += AddUser_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btn_adduser;
        private Button btnLogin;
        private Label lblPassword;
        private Label lblUsername;
        private TextBox txtPassword;
        private TextBox txtUsername;

    }
}