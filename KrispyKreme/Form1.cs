using System;
using System.Text;
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
            // No message box, directly load the app
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Unit prices
            int unitPriceA = 100;
            int unitPriceB = 135;
            int unitPriceC = 150;
            int unitPriceD = 155;

            // Quantities
            int qtyA = GetQuantity(txtQtyProductA);
            int qtyB = GetQuantity(txtQtyProductB);
            int qtyC = GetQuantity(txtQtyProductC);
            int qtyD = GetQuantity(txtQtyProductD);

            // If all fields are invalid (empty or negative), show an error message
            if (qtyA == -1 && qtyB == -1 && qtyC == -1 && qtyD == -1)
            {
                MessageBox.Show("Please enter at least one valid quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calculate product totals
            int totalA = unitPriceA * Math.Max(0, qtyA);
            int totalB = unitPriceB * Math.Max(0, qtyB);
            int totalC = unitPriceC * Math.Max(0, qtyC);
            int totalD = unitPriceD * Math.Max(0, qtyD);

            // Display product totals
            lblTotalProductA.Text = "₹" + totalA.ToString();
            lblTotalProductB.Text = "₹" + totalB.ToString();
            lblTotalProductC.Text = "₹" + totalC.ToString();
            lblTotalProductD.Text = "₹" + totalD.ToString();

            // Calculate overall total
            int overallTotal = totalA + totalB + totalC + totalD;
            lblOverallTotal.Text = "₹" + overallTotal.ToString();

            // Apply discount
            double discount = CalculateDiscount(overallTotal);
            double finalPrice = overallTotal - discount;

            // Display discount and final price
            lblDiscount.Text = "₹" + discount.ToString();
            lblFinalPrice.Text = "₹" + finalPrice.ToString();
        }

        private int GetQuantity(TextBox textBox)
        {
            if (int.TryParse(textBox.Text, out int quantity) && quantity >= 0)
            {
                return quantity;
            }
            else
            {
                return -1;
            }
        }

        private double CalculateDiscount(int total)
        {
            double discount = 0;

            if (total > 2000)
            {
                discount = total * 0.20;
            }
            else if (total > 1500)
            {
                discount = total * 0.15;
            }
            else if (total > 1000)
            {
                discount = total * 0.10;
            }
            else if (total > 500)
            {
                discount = total * 0.05;
            }

            return discount;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear all input fields and labels
            txtCustomerName.Text = "";
            txtCustomerID.Text = "";
            txtCustomerPhone.Text = "";
            txtQtyProductA.Text = "";
            txtQtyProductB.Text = "";
            txtQtyProductC.Text = "";
            txtQtyProductD.Text = "";

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
            // Validate customer details (Name, ID, and Phone)
            if (string.IsNullOrEmpty(txtCustomerName.Text) || string.IsNullOrEmpty(txtCustomerID.Text) || string.IsNullOrEmpty(txtCustomerPhone.Text))
            {
                MessageBox.Show("Please fill in all customer details before proceeding.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Retrieve customer details
            string customerName = txtCustomerName.Text;
            string customerID = txtCustomerID.Text;
            string customerPhone = txtCustomerPhone.Text;

            // Initialize the bill details string
            StringBuilder billDetails = new StringBuilder();
            billDetails.AppendLine("----- KRISPY KREME BILL -----");
            billDetails.AppendLine($"Customer Name: {customerName}");
            billDetails.AppendLine($"Customer ID: {customerID}");
            billDetails.AppendLine($"Phone: {customerPhone}");
            billDetails.AppendLine("----------------------------------");

            // Unit prices
            int unitPriceA = 100;
            int unitPriceB = 135;
            int unitPriceC = 150;
            int unitPriceD = 155;

            // Calculate and add products to the bill
            int qtyA = GetQuantity(txtQtyProductA);
            int qtyB = GetQuantity(txtQtyProductB);
            int qtyC = GetQuantity(txtQtyProductC);
            int qtyD = GetQuantity(txtQtyProductD);

            if (qtyA > 0)
            {
                int totalA = qtyA * unitPriceA;
                billDetails.AppendLine($"Original Glaze: {qtyA} x ₹{unitPriceA} = ₹{totalA}");
            }
            if (qtyB > 0)
            {
                int totalB = qtyB * unitPriceB;
                billDetails.AppendLine($"Caramel Glazed: {qtyB} x ₹{unitPriceB} = ₹{totalB}");
            }
            if (qtyC > 0)
            {
                int totalC = qtyC * unitPriceC;
                billDetails.AppendLine($"Sparkle: {qtyC} x ₹{unitPriceC} = ₹{totalC}");
            }
            if (qtyD > 0)
            {
                int totalD = qtyD * unitPriceD;
                billDetails.AppendLine($"Chocolate Sprinkle: {qtyD} x ₹{unitPriceD} = ₹{totalD}");
            }

            // Include overall totals and discount
            billDetails.AppendLine("----------------------------------");
            billDetails.AppendLine($"Overall Total: {lblOverallTotal.Text}");
            billDetails.AppendLine($"Discount: {lblDiscount.Text}");
            billDetails.AppendLine($"Final Price: {lblFinalPrice.Text}");
            billDetails.AppendLine("----------------------------------");
            billDetails.AppendLine("Thank you for visiting Krispy Kreme!");

            this.Hide();
            Form2 form2 = new Form2(billDetails.ToString());
            form2.Show();
        }
    }
}
