using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace KrispyKreme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadLatestBillID();
        }

        private void LoadLatestBillID()
        {
            int latestBillID = DatabaseHelper.GetLatestBillID();
            lbl_billid.Text = "Bill ID: " + (latestBillID + 1);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int unitPriceA = 100;
            int unitPriceB = 135;
            int unitPriceC = 150;
            int unitPriceD = 155;

            int qtyA = GetQuantity(txtQtyProductA);
            int qtyB = GetQuantity(txtQtyProductB);
            int qtyC = GetQuantity(txtQtyProductC);
            int qtyD = GetQuantity(txtQtyProductD);

            if (qtyA == -1 && qtyB == -1 && qtyC == -1 && qtyD == -1)
            {
                MessageBox.Show("Please enter at least one valid quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int totalA = unitPriceA * Math.Max(0, qtyA);
            int totalB = unitPriceB * Math.Max(0, qtyB);
            int totalC = unitPriceC * Math.Max(0, qtyC);
            int totalD = unitPriceD * Math.Max(0, qtyD);

            lblTotalProductA.Text = "₹" + totalA;
            lblTotalProductB.Text = "₹" + totalB;
            lblTotalProductC.Text = "₹" + totalC;
            lblTotalProductD.Text = "₹" + totalD;

            int overallTotal = totalA + totalB + totalC + totalD;
            lblOverallTotal.Text = "₹" + overallTotal;

            double discount = CalculateDiscount(overallTotal);
            double finalPrice = overallTotal - discount;

            lblDiscount.Text = "₹" + discount;
            lblFinalPrice.Text = "₹" + finalPrice;
        }

        private int GetQuantity(TextBox textBox)
        {
            if (int.TryParse(textBox.Text, out int quantity) && quantity >= 0)
            {
                return quantity;
            }
            return -1;
        }

        private double CalculateDiscount(int total)
        {
            if (total > 2000) return total * 0.20;
            if (total > 1500) return total * 0.15;
            if (total > 1000) return total * 0.10;
            if (total > 500) return total * 0.05;
            return 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerName.Clear();
            txtCustomerPhone.Clear();
            txtQtyProductA.Clear();
            txtQtyProductB.Clear();
            txtQtyProductC.Clear();
            txtQtyProductD.Clear();

            lblTotalProductA.Text = "₹0";
            lblTotalProductB.Text = "₹0";
            lblTotalProductC.Text = "₹0";
            lblTotalProductD.Text = "₹0";
            lblOverallTotal.Text = "₹0";
            lblDiscount.Text = "₹0";
            lblFinalPrice.Text = "₹0";
        }

        private void btnNext_Click_Click(object sender, EventArgs e)
        {
            string customerName = txtCustomerName.Text.Trim();
            string customerPhone = txtCustomerPhone.Text.Trim();

            if (string.IsNullOrEmpty(customerName))
            {
                MessageBox.Show("Please enter the customer name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(customerPhone, @"^\d{10}$"))
            {
                MessageBox.Show("Please enter a valid 10-digit phone number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string billID = lbl_billid.Text.Replace("Bill ID: ", "");
            StringBuilder billDetails = new StringBuilder();
            billDetails.AppendLine("----- KRISPY KREME BILL -----");
            billDetails.AppendLine($"Bill ID: {billID}");
            billDetails.AppendLine($"Customer Name: {customerName}");
            billDetails.AppendLine($"Phone: {customerPhone}");
            billDetails.AppendLine("----------------------------------");

            int unitPriceA = 100, unitPriceB = 135, unitPriceC = 150, unitPriceD = 155;
            int qtyA = GetQuantity(txtQtyProductA), qtyB = GetQuantity(txtQtyProductB),
                qtyC = GetQuantity(txtQtyProductC), qtyD = GetQuantity(txtQtyProductD);

            if (qtyA > 0) billDetails.AppendLine($"Original Glaze: {qtyA} x ₹{unitPriceA} = ₹{qtyA * unitPriceA}");
            if (qtyB > 0) billDetails.AppendLine($"Caramel Glazed: {qtyB} x ₹{unitPriceB} = ₹{qtyB * unitPriceB}");
            if (qtyC > 0) billDetails.AppendLine($"Sparkle: {qtyC} x ₹{unitPriceC} = ₹{qtyC * unitPriceC}");
            if (qtyD > 0) billDetails.AppendLine($"Chocolate Sprinkle: {qtyD} x ₹{unitPriceD} = ₹{qtyD * unitPriceD}");

            billDetails.AppendLine("----------------------------------");
            billDetails.AppendLine($"Overall Total: {lblOverallTotal.Text}");
            billDetails.AppendLine($"Discount: {lblDiscount.Text}");
            billDetails.AppendLine($"Final Price: {lblFinalPrice.Text}");
            billDetails.AppendLine("----------------------------------");
            billDetails.AppendLine("Thank you for visiting Krispy Kreme!");

            // Save bill to the database
            DatabaseHelper.SaveBill(
                customerName,
                customerPhone,
                billDetails.ToString(),
                Convert.ToDecimal(lblOverallTotal.Text.Replace("₹", "")),
                Convert.ToDecimal(lblDiscount.Text.Replace("₹", "")),
                Convert.ToDecimal(lblFinalPrice.Text.Replace("₹", ""))
            );

            this.Hide();
            Form2 form2 = new Form2(billDetails.ToString());
            form2.Show();
        }
    }
}