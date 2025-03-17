namespace KrispyKreme
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            pictureBox1 = new PictureBox();
            lblBillDetails = new Label();
            btnBack = new Button();
            btnPrint = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.KrispyKreme;
            pictureBox1.Location = new Point(179, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(735, 287);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblBillDetails
            // 
            lblBillDetails.AutoSize = true;
            lblBillDetails.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblBillDetails.Location = new Point(179, 408);
            lblBillDetails.Name = "lblBillDetails";
            lblBillDetails.Padding = new Padding(10);
            lblBillDetails.Size = new Size(474, 65);
            lblBillDetails.TabIndex = 1;
            lblBillDetails.Text = "Bill Details will appear here";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(255, 128, 128);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(190, 1337);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(287, 83);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.FromArgb(128, 255, 128);
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrint.Location = new Point(627, 1337);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(287, 83);
            btnPrint.TabIndex = 3;
            btnPrint.Text = "Print Bill";
            btnPrint.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1127, 1451);
            Controls.Add(btnPrint);
            Controls.Add(btnBack);
            Controls.Add(lblBillDetails);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KrispyKreme";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblBillDetails;
        private Button btnBack;
        private Button btnPrint;
    }
}