using System;
using System.Drawing.Printing;
using System.Windows.Forms;



namespace KrispyKreme
{
    public partial class Form2 : Form
    {
        private string billDetails;  // Declare a string to store bill details

        // Constructor that accepts the bill details string
        public Form2(string billDetails)
        {
            InitializeComponent();
            this.billDetails = billDetails;
            btnBack.Click += new EventHandler(btnBack_Click);
            btnPrint.Click += new System.EventHandler(btnPrint_Click);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Display the bill details in the label
            lblBillDetails.Text = billDetails;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to go back?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();  // Close Form2
                // Show Form1
                Form1 form1 = new Form1();
                form1.Show();
            }
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog
            {
                Document = printDocument
            };

            if (printPreviewDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font billFont = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic);
            Brush billBrush = Brushes.Black;

            // Calculate the page width and height
            float pageWidth = e.PageBounds.Width;
            float pageHeight = e.PageBounds.Height;

            // Set the margin for the image and text
            float margin = 20f;

            // Calculate the center of the page
            float centerX = pageWidth / 2;

            // Draw the logo image at the top of the page (centered horizontally)
            float logoWidth = 400;
            float logoHeight = 200;
            float logoX = centerX - (logoWidth / 2);
            e.Graphics.DrawImage(Properties.Resources.KrispyKreme, logoX, margin, logoWidth, logoHeight);

            // Adjust the Y position for the bill details below the logo
            float billDetailsY = margin + logoHeight + 10;  // Add space below the logo

            // Draw the bill details, center the text horizontally
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center; // Center the text horizontally
            e.Graphics.DrawString(lblBillDetails.Text, billFont, billBrush, centerX, billDetailsY, stringFormat);

            // If needed, you can add more details below the bill (like totals, etc.), adjust Y position accordingly.
        }


    }
}

