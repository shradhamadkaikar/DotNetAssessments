using System;
using System.IO;
using System.Windows.Forms;

namespace SerializationAssesment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string cityName = txtCity.Text.Trim();

                if (listBox1.Items.Contains(cityName))
                {
                    MessageBox.Show("City already exists.");
                    return;
                }

                listBox1.Items.Add(cityName);

                string path = @"C:\Users\HP\source\repos\Employee2\cities.dat";
                using (StreamWriter writer = new StreamWriter(path, true))
                {
                    writer.WriteLine(cityName);
                }

                MessageBox.Show("City added.");
                txtCity.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedItem != null)
                {
                    listBox1.Items.Remove(listBox1.SelectedItem);
                    MessageBox.Show("City removed ");
                }
                else
                {
                    MessageBox.Show("enter city.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
