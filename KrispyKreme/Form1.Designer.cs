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
            txtCustomerPhone = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            btnNext = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lbl_billid = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic);
            lblCustomerName.Location = new Point(405, 193);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Padding = new Padding(10);
            lblCustomerName.Size = new Size(330, 71);
            lblCustomerName.TabIndex = 0;
            lblCustomerName.Text = "Customer Name";
            // 
            // lblCustomerPhone
            // 
            lblCustomerPhone.AutoSize = true;
            lblCustomerPhone.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic);
            lblCustomerPhone.Location = new Point(405, 288);
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
            lblTotalProductA.Location = new Point(1013, 582);
            lblTotalProductA.Name = "lblTotalProductA";
            lblTotalProductA.Size = new Size(56, 45);
            lblTotalProductA.TabIndex = 4;
            lblTotalProductA.Text = "₹0";
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
            lblTotalProductB.Location = new Point(1013, 732);
            lblTotalProductB.Name = "lblTotalProductB";
            lblTotalProductB.Size = new Size(56, 45);
            lblTotalProductB.TabIndex = 6;
            lblTotalProductB.Text = "₹0";
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
            lblTotalProductC.Location = new Point(1013, 882);
            lblTotalProductC.Name = "lblTotalProductC";
            lblTotalProductC.Size = new Size(56, 45);
            lblTotalProductC.TabIndex = 8;
            lblTotalProductC.Text = "₹0";
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
            lblTotalProductD.Location = new Point(1013, 1017);
            lblTotalProductD.Name = "lblTotalProductD";
            lblTotalProductD.Size = new Size(56, 45);
            lblTotalProductD.TabIndex = 10;
            lblTotalProductD.Text = "₹0";
            lblTotalProductD.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOverallTotal
            // 
            lblOverallTotal.AutoSize = true;
            lblOverallTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            lblOverallTotal.ForeColor = Color.FromArgb(255, 128, 128);
            lblOverallTotal.Location = new Point(447, 1134);
            lblOverallTotal.Name = "lblOverallTotal";
            lblOverallTotal.Size = new Size(56, 45);
            lblOverallTotal.TabIndex = 11;
            lblOverallTotal.Text = "₹0";
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            lblDiscount.ForeColor = Color.LightGray;
            lblDiscount.Location = new Point(869, 1134);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(56, 45);
            lblDiscount.TabIndex = 12;
            lblDiscount.Text = "₹0";
            // 
            // lblFinalPrice
            // 
            lblFinalPrice.AutoSize = true;
            lblFinalPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            lblFinalPrice.ForeColor = Color.LightGreen;
            lblFinalPrice.Location = new Point(1350, 1134);
            lblFinalPrice.Name = "lblFinalPrice";
            lblFinalPrice.Size = new Size(56, 45);
            lblFinalPrice.TabIndex = 13;
            lblFinalPrice.Text = "₹0";
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.FromArgb(0, 160, 70);
            btnCalculate.FlatAppearance.BorderColor = Color.FromArgb(0, 160, 70);
            btnCalculate.FlatStyle = FlatStyle.Flat;
            btnCalculate.ForeColor = Color.White;
            btnCalculate.Location = new Point(494, 1219);
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
            btnClear.Location = new Point(949, 1219);
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
            // txtCustomerPhone
            // 
            txtCustomerPhone.BackColor = Color.LightGreen;
            txtCustomerPhone.BorderStyle = BorderStyle.FixedSingle;
            txtCustomerPhone.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtCustomerPhone.Location = new Point(885, 290);
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
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.BackgroundImageLayout = ImageLayout.Center;
            pictureBox6.ErrorImage = Properties.Resources.doughnuts;
            pictureBox6.Image = Properties.Resources.doughnuts;
            pictureBox6.InitialImage = Properties.Resources.doughnuts;
            pictureBox6.Location = new Point(405, 425);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(664, 120);
            pictureBox6.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox6.TabIndex = 28;
            pictureBox6.TabStop = false;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.Transparent;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Location = new Point(712, 1219);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(150, 46);
            btnNext.TabIndex = 29;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(343, 1134);
            label1.Name = "label1";
            label1.Size = new Size(98, 45);
            label1.TabIndex = 30;
            label1.Text = "Total";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(712, 1134);
            label2.Name = "label2";
            label2.Size = new Size(151, 45);
            label2.TabIndex = 31;
            label2.Text = "Discount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(1249, 1134);
            label3.Name = "label3";
            label3.Size = new Size(95, 45);
            label3.TabIndex = 32;
            label3.Text = "Final";
            // 
            // lbl_billid
            // 
            lbl_billid.AutoSize = true;
            lbl_billid.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic);
            lbl_billid.Location = new Point(885, 96);
            lbl_billid.Name = "lbl_billid";
            lbl_billid.Size = new Size(44, 51);
            lbl_billid.TabIndex = 4;
            lbl_billid.Text = "0";
            lbl_billid.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1554, 1329);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnNext);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(txtCustomerPhone);
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
            Controls.Add(lbl_billid);
            Controls.Add(lblTotalProductA);
            Controls.Add(lblProductA);
            Controls.Add(lblCustomerPhone);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCustomerName;
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
        private TextBox txtCustomerPhone;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Button btnNext;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lbl_billid;
    }
}