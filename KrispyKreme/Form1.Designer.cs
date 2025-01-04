namespace KrispyKreme
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblCustomerName = new Label();
            lblCustomerID = new Label();
            lblCustomerPhone = new Label();
            lblProductA = new Label();
            lblTotalProductA = new Label();
            lblProductB = new Label();
            lblTotalProductB = new Label();
            lblProductC = new Label();
            lblTotalProductC = new Label();
            lblProductD = new Label();
            lblTotalProductD = new Label();
            lblOverallTotal = new Label();
            lblDiscount = new Label();
            lblFinalPrice = new Label();
            btnCalculate = new Button();
            btnClear = new Button();
            txtQtyProductD = new TextBox();
            txtQtyProductC = new TextBox();
            txtQtyProductA = new TextBox();
            txtQtyProductB = new TextBox();
            txtCustomerName = new TextBox();
            txtCustomerID = new TextBox();
            txtCustomerPhone = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic);
            lblCustomerName.Location = new Point(405, 183);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Padding = new Padding(10);
            lblCustomerName.Size = new Size(150, 71);
            lblCustomerName.TabIndex = 0;
            lblCustomerName.Text = "Name";
            // 
            // lblCustomerID
            // 
            lblCustomerID.AutoSize = true;
            lblCustomerID.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic);
            lblCustomerID.Location = new Point(405, 256);
            lblCustomerID.Name = "lblCustomerID";
            lblCustomerID.Padding = new Padding(10);
            lblCustomerID.Size = new Size(263, 71);
            lblCustomerID.TabIndex = 1;
            lblCustomerID.Text = "Customer ID";
            // 
            // lblCustomerPhone
            // 
            lblCustomerPhone.AutoSize = true;
            lblCustomerPhone.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic);
            lblCustomerPhone.Location = new Point(405, 333);
            lblCustomerPhone.Name = "lblCustomerPhone";
            lblCustomerPhone.Padding = new Padding(10);
            lblCustomerPhone.Size = new Size(310, 71);
            lblCustomerPhone.TabIndex = 2;
            lblCustomerPhone.Text = "Phone Number";
            // 
            // lblProductA
            // 
            lblProductA.AutoSize = true;
            lblProductA.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            lblProductA.Location = new Point(266, 580);
            lblProductA.Name = "lblProductA";
            lblProductA.Size = new Size(363, 45);
            lblProductA.TabIndex = 3;
            lblProductA.Text = "Original Glazed – ₹100";
            // 
            // lblTotalProductA
            // 
            lblTotalProductA.AutoSize = true;
            lblTotalProductA.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            lblTotalProductA.Location = new Point(984, 583);
            lblTotalProductA.Name = "lblTotalProductA";
            lblTotalProductA.Size = new Size(182, 45);
            lblTotalProductA.TabIndex = 4;
            lblTotalProductA.Text = "Total Price";
            lblTotalProductA.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblProductB
            // 
            lblProductB.AutoSize = true;
            lblProductB.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            lblProductB.Location = new Point(266, 733);
            lblProductB.Name = "lblProductB";
            lblProductB.Size = new Size(366, 45);
            lblProductB.TabIndex = 5;
            lblProductB.Text = "Caramel Glazed – ₹135";
            // 
            // lblTotalProductB
            // 
            lblTotalProductB.AutoSize = true;
            lblTotalProductB.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            lblTotalProductB.Location = new Point(984, 733);
            lblTotalProductB.Name = "lblTotalProductB";
            lblTotalProductB.Size = new Size(182, 45);
            lblTotalProductB.TabIndex = 6;
            lblTotalProductB.Text = "Total Price";
            lblTotalProductB.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblProductC
            // 
            lblProductC.AutoSize = true;
            lblProductC.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            lblProductC.Location = new Point(266, 883);
            lblProductC.Name = "lblProductC";
            lblProductC.Size = new Size(236, 45);
            lblProductC.TabIndex = 7;
            lblProductC.Text = "Sparkle - ₹150";
            // 
            // lblTotalProductC
            // 
            lblTotalProductC.AutoSize = true;
            lblTotalProductC.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            lblTotalProductC.Location = new Point(984, 883);
            lblTotalProductC.Name = "lblTotalProductC";
            lblTotalProductC.Size = new Size(182, 45);
            lblTotalProductC.TabIndex = 8;
            lblTotalProductC.Text = "Total Price";
            lblTotalProductC.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblProductD
            // 
            lblProductD.AutoSize = true;
            lblProductD.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            lblProductD.Location = new Point(266, 1018);
            lblProductD.Name = "lblProductD";
            lblProductD.Size = new Size(403, 45);
            lblProductD.TabIndex = 9;
            lblProductD.Text = "Chocolate Sprinkle - ₹155";
            // 
            // lblTotalProductD
            // 
            lblTotalProductD.AutoSize = true;
            lblTotalProductD.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            lblTotalProductD.Location = new Point(984, 1018);
            lblTotalProductD.Name = "lblTotalProductD";
            lblTotalProductD.Size = new Size(182, 45);
            lblTotalProductD.TabIndex = 10;
            lblTotalProductD.Text = "Total Price";
            lblTotalProductD.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOverallTotal
            // 
            lblOverallTotal.AutoSize = true;
            lblOverallTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            lblOverallTotal.ForeColor = Color.Red;
            lblOverallTotal.Location = new Point(339, 1133);
            lblOverallTotal.Name = "lblOverallTotal";
            lblOverallTotal.Size = new Size(98, 45);
            lblOverallTotal.TabIndex = 11;
            lblOverallTotal.Text = "Total";
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            lblDiscount.ForeColor = Color.LightGray;
            lblDiscount.Location = new Point(761, 1133);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(151, 45);
            lblDiscount.TabIndex = 12;
            lblDiscount.Text = "Discount";
            // 
            // lblFinalPrice
            // 
            lblFinalPrice.AutoSize = true;
            lblFinalPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            lblFinalPrice.Location = new Point(1242, 1133);
            lblFinalPrice.Name = "lblFinalPrice";
            lblFinalPrice.Size = new Size(95, 45);
            lblFinalPrice.TabIndex = 13;
            lblFinalPrice.Text = "Final";
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.FromArgb(0, 160, 70);
            btnCalculate.FlatAppearance.BorderColor = Color.FromArgb(0, 160, 70);
            btnCalculate.FlatStyle = FlatStyle.Flat;
            btnCalculate.ForeColor = Color.White;
            btnCalculate.Location = new Point(529, 1221);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(150, 46);
            btnCalculate.TabIndex = 14;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Red;
            btnClear.FlatAppearance.BorderColor = Color.FromArgb(0, 160, 70);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(984, 1221);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(150, 46);
            btnClear.TabIndex = 15;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // txtQtyProductD
            // 
            txtQtyProductD.BackColor = Color.LightGreen;
            txtQtyProductD.BorderStyle = BorderStyle.FixedSingle;
            txtQtyProductD.Location = new Point(712, 1021);
            txtQtyProductD.Name = "txtQtyProductD";
            txtQtyProductD.Size = new Size(200, 39);
            txtQtyProductD.TabIndex = 16;
            // 
            // txtQtyProductC
            // 
            txtQtyProductC.BackColor = Color.LightGreen;
            txtQtyProductC.BorderStyle = BorderStyle.FixedSingle;
            txtQtyProductC.Location = new Point(712, 890);
            txtQtyProductC.Name = "txtQtyProductC";
            txtQtyProductC.Size = new Size(200, 39);
            txtQtyProductC.TabIndex = 17;
            // 
            // txtQtyProductA
            // 
            txtQtyProductA.BackColor = Color.LightGreen;
            txtQtyProductA.BorderStyle = BorderStyle.FixedSingle;
            txtQtyProductA.Location = new Point(712, 590);
            txtQtyProductA.Name = "txtQtyProductA";
            txtQtyProductA.Size = new Size(200, 39);
            txtQtyProductA.TabIndex = 18;
            // 
            // txtQtyProductB
            // 
            txtQtyProductB.BackColor = Color.LightGreen;
            txtQtyProductB.BorderStyle = BorderStyle.FixedSingle;
            txtQtyProductB.Location = new Point(712, 740);
            txtQtyProductB.Name = "txtQtyProductB";
            txtQtyProductB.Size = new Size(200, 39);
            txtQtyProductB.TabIndex = 19;
            // 
            // txtCustomerName
            // 
            txtCustomerName.BackColor = Color.LightGreen;
            txtCustomerName.BorderStyle = BorderStyle.FixedSingle;
            txtCustomerName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtCustomerName.Location = new Point(885, 195);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(200, 50);
            txtCustomerName.TabIndex = 20;
            // 
            // txtCustomerID
            // 
            txtCustomerID.BackColor = Color.LightGreen;
            txtCustomerID.BorderStyle = BorderStyle.FixedSingle;
            txtCustomerID.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtCustomerID.Location = new Point(885, 268);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(200, 50);
            txtCustomerID.TabIndex = 21;
            // 
            // txtCustomerPhone
            // 
            txtCustomerPhone.BackColor = Color.LightGreen;
            txtCustomerPhone.BorderStyle = BorderStyle.FixedSingle;
            txtCustomerPhone.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtCustomerPhone.Location = new Point(885, 345);
            txtCustomerPhone.Name = "txtCustomerPhone";
            txtCustomerPhone.Size = new Size(200, 50);
            txtCustomerPhone.TabIndex = 22;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.KrispyKreme;
            pictureBox1.Location = new Point(20, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(417, 118);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.original_glazed;
            pictureBox2.Location = new Point(51, 561);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(200, 100);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.caramel;
            pictureBox3.Location = new Point(51, 713);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(200, 100);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 25;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.sprinkles;
            pictureBox4.Location = new Point(51, 861);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(200, 100);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 26;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.chocolate_sprinkles_td;
            pictureBox5.Location = new Point(51, 995);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(200, 100);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 27;
            pictureBox5.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1554, 1329);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(txtCustomerPhone);
            Controls.Add(txtCustomerID);
            Controls.Add(txtCustomerName);
            Controls.Add(txtQtyProductB);
            Controls.Add(txtQtyProductA);
            Controls.Add(txtQtyProductC);
            Controls.Add(txtQtyProductD);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(lblFinalPrice);
            Controls.Add(lblDiscount);
            Controls.Add(lblOverallTotal);
            Controls.Add(lblTotalProductD);
            Controls.Add(lblProductD);
            Controls.Add(lblTotalProductC);
            Controls.Add(lblProductC);
            Controls.Add(lblTotalProductB);
            Controls.Add(lblProductB);
            Controls.Add(lblTotalProductA);
            Controls.Add(lblProductA);
            Controls.Add(lblCustomerPhone);
            Controls.Add(lblCustomerID);
            Controls.Add(lblCustomerName);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(0, 160, 70);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KrispyKreme";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCustomerName;
        private Label lblCustomerID;
        private Label lblCustomerPhone;
        private Label lblProductA;
        private Label lblTotalProductA;
        private Label lblProductB;
        private Label lblTotalProductB;
        private Label lblProductC;
        private Label lblTotalProductC;
        private Label lblProductD;
        private Label lblTotalProductD;
        private Label lblOverallTotal;
        private Label lblDiscount;
        private Label lblFinalPrice;
        private Button btnCalculate;
        private Button btnClear;
        private TextBox txtQtyProductD;
        private TextBox txtQtyProductC;
        private TextBox txtQtyProductA;
        private TextBox txtQtyProductB;
        private TextBox txtCustomerName;
        private TextBox txtCustomerID;
        private TextBox txtCustomerPhone;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
    }
}
