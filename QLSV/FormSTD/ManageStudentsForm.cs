using QLSV.OOP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class ManageStudentsForm : Form
    {
        STUDENT student = new STUDENT();
        MyDB db = new MyDB();   
        public ManageStudentsForm()
        {
            InitializeComponent();
        }

        private void ManageStudentsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDBDataSet1.std' table. You can move, or remove it, as needed.
            this.stdTableAdapter.Fill(this.myDBDataSet1.std);

        }
        private bool ContainsNumeric(string input)
        {
            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }
        private bool IsNumeric(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
        bool verif()
        {
            if ((txtFirstName.Text.Trim() == "")
                        || (txtLastName.Text.Trim() == "")
                        || (txtAddress.Text.Trim() == "")
                        || (txtPhone.Text.Trim() == "")
                        || (picAvt.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            string fname = txtFirstName.Text;
            string lname = txtLastName.Text;
            if (ContainsNumeric(fname) || ContainsNumeric(lname))
            {
                MessageBox.Show("First name and last name cannot contain numeric characters", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Stop further execution
            }
            DateTime bdate = dtpkBirthDate.Value;
            string phone = txtPhone.Text;
            if (!IsNumeric(phone))
            {
                MessageBox.Show("Phone number í error", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Stop further execution
            }
            else if (!int.TryParse(txtID.Text, out id) || id <= 0)
            {
                MessageBox.Show("Student ID should be a positive integer.");
            }
            else
            {
                string address = txtAddress.Text;
                string gender = "Male";
                if (radFemale.Checked)
                {
                    gender = "Female";
                }

                MemoryStream pic = new MemoryStream();
                int bornYear = dtpkBirthDate.Value.Year;
                int thisYear = DateTime.Now.Year;
                if (((thisYear - bornYear) < 10) || ((thisYear - bornYear) > 100))
                {
                    MessageBox.Show("The Student Age Must Be Between 10 and 100 year",
                        "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (verif())
                {
                    picAvt.Image.Save(pic, picAvt.Image.RawFormat);

                    try
                    {
                        student.InsertStudent(id, fname, lname, bdate, gender, phone, address, pic);
                        MessageBox.Show("New Student Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    catch
                    {
                        MessageBox.Show("Student exist", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("please enter again", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            int id;
            string fname = txtFirstName.Text;
            string lname = txtLastName.Text;
            if (ContainsNumeric(fname) || ContainsNumeric(lname))
            {
                MessageBox.Show("First name and last name cannot contain numeric characters", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Stop further execution
            }
            DateTime bdate = dtpkBirthDate.Value;
            string phone = txtPhone.Text;
            if (!IsNumeric(phone))
            {
                MessageBox.Show("Phone number must contain only numeric characters", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Stop further execution
            }
            string address = txtAddress.Text;
            string gender = "Male";
            if (radFemale.Checked)
            {
                gender = "Female";
            }

            MemoryStream pic = new MemoryStream();
            int bornYear = dtpkBirthDate.Value.Year;
            int thisYear = DateTime.Now.Year;
            if (((thisYear - bornYear) < 10) || ((thisYear - bornYear) > 100))
            {
                MessageBox.Show("The Student Age Must Be Between 10 and 100 year",
                    "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verif())
            {
                try
                {
                    id = Convert.ToInt32(txtID.Text);
                    picAvt.Image.Save(pic, picAvt.Image.RawFormat);
                    if (student.updateStudent(id, fname, lname, bdate, gender, phone, address, pic))
                    {
                        MessageBox.Show("Student be updated", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Error", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Edit student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("Please enter again", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            try
            {

                int StudentID = Convert.ToInt32(txtID.Text);
                if (MessageBox.Show("Are you sure want to delete this student ?", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (student.deleteStudent(StudentID))
                    {
                        MessageBox.Show("Student deleted", "Delete student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtID.Text = "";
                        txtFirstName.Text = "";
                        txtLastName.Text = "";
                        txtAddress.Text = "";
                        txtPhone.Text = "";
                        dtpkBirthDate.Value = DateTime.Now;
                        picAvt.Image = null;
                    }
                    else
                    {
                        MessageBox.Show("Student not be Deleted", "Delete student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a valid id", "Delete student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            dtpkBirthDate.Value = DateTime.Now;
            txtAddress.Text = "";
            txtPhone.Text = "";
            picAvt.Image = null;
            radMale.Checked = true;

        }

        private void btUpImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg; *.png; *.gif)| *.jpg; *.png; *.gif";
            if((opf.ShowDialog() == DialogResult.OK))
            {
                picAvt.Image = Image.FromFile(opf.FileName);    
            }
        }

        private void btTotalStudent_Click(object sender, EventArgs e)
        {
            lbTotalStudent.Text = ("" + dataGridViewStudentList.Rows.Count);
        }

        private void btDownload_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.FileName = ("student_" + txtID.Text);
            if(picAvt.Image == null) 
            {
                MessageBox.Show("No image in the PictureBox");
                
            }
            else if(svf.ShowDialog() == DialogResult.OK)
            {
                picAvt.Image.Save((svf.FileName + ("." + ImageFormat.Jpeg.ToString())));
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Search empty", "Errror");
            }
            else
            {
                string searchText = txtSearch.Text.Trim();
                SqlCommand command = new SqlCommand("SELECT * FROM std WHERE CONCAT(lname,' ',fname,address,phone) LIKE @searchText", db.getConnection);
                command.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridViewStudentList.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
