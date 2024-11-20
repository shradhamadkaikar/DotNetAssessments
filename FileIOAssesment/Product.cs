using System;
using System.IO;
using System.Windows.Forms;

namespace FileIOAssesment
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                // BinaryWriter
                string path = @"E:\DotNetTraining\FileIOAssesment\product.dat"; // .dat - data file for product
                FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);

                // Writing Product data to the file
                bw.Write(Convert.ToInt32(txtProductId.Text)); // Product ID
                bw.Write(txtProductName.Text); // Product Name
                bw.Write(Convert.ToDouble(txtProductPrice.Text)); // Product Price

                bw.Close();
                fs.Close(); // Ensure the data is stored properly in secondary storage
                MessageBox.Show("Product data added to file");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"E:\DotNetTraining\FileIOAssesment\product.dat"; // .dat - data file for product
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);

         
                txtProductId.Text = br.ReadInt32().ToString(); // Product ID
                txtProductName.Text = br.ReadString(); // Product Name
                txtProductPrice.Text = br.ReadDouble().ToString(); // Product Price

                br.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtProductId.Clear();
            txtProductName.Clear();
            txtProductPrice.Clear();
        }
    }
}
