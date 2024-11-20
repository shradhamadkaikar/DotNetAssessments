using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace Ado.netAssessemt
{
    public partial class StudentDisconnectedForm : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder scb;
        public StudentDisconnectedForm()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["defaultConn"].ConnectionString);

        }
        private DataSet GetStudents()
        {
            da = new SqlDataAdapter("select * from student", con);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            scb = new SqlCommandBuilder(da);// track DataSet & generate qry & assign to da object
            ds = new DataSet();
            da.Fill(ds, "stud");// emp is a table name given to DataSet table
            return ds;
        }

        private void ClearFormFields()
        {
            txtId.Clear();
            txtName.Clear();
            txtEmail.Clear();
        }
        private void StudentDisconnectedForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetStudents();
                // need to add new object in the DataSet
                DataRow row = ds.Tables["stud"].NewRow();
                row["name"] = txtName.Text;
                row["email"] = txtEmail.Text;
                // attach /load the row to the DataSet
                ds.Tables["stud"].Rows.Add(row);
                // reflect the changes to the DB
                int result = da.Update(ds.Tables["stud"]);
                if (result >= 1)
                {
                    MessageBox.Show("Record inserted");
                    ClearFormFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetStudents();
                DataRow row = ds.Tables["stud"].Rows.Find(txtId.Text);
                if (row != null)
                {
                    txtName.Text = row["name"].ToString();
                    txtEmail.Text = row["email"].ToString();
                }
                else
                {
                    MessageBox.Show("Record not found");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetStudents();
                // find the object in the DataSet
                DataRow row = ds.Tables["stud"].Rows.Find(txtId.Text);
                if (row != null)
                {
                    row["name"] = txtName.Text;
                    row["email"] = txtEmail.Text;
                    // reflect the changes to the DB
                    int result = da.Update(ds.Tables["stud"]);
                    if (result >= 1)
                    {
                        MessageBox.Show("Record updated");
                        ClearFormFields();
                    }
                }
                else
                {
                    MessageBox.Show("Record not found for Id");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetStudents();
                // find the object in the DataSet
                DataRow row = ds.Tables["stud"].Rows.Find(txtId.Text);
                if (row != null)
                {
                    row.Delete();
                    int result = da.Update(ds.Tables["stud"]);
                    if (result >= 1)
                    {
                        MessageBox.Show("Record deleted");
                        ClearFormFields();
                    }
                }
                else
                {
                    MessageBox.Show("Record not found for Id");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            ds = GetStudents();
            dataGridView1.DataSource = ds.Tables["stud"];

        }
    }
}
