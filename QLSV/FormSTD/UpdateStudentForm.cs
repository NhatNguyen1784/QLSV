using QLSV.OOP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class UpdateStudentForm : Form
    {
        public UpdateStudentForm()
        {
            InitializeComponent();
        }
        STUDENT student = new STUDENT();
        private void btFind_Click(object sender, EventArgs e)
        {
            // tim theo id, phan mo rong se tim theo dien thoai. neu tim theo ten thi se xuat hien 1 form khac list toan bo ket qua trung ten private void buttonFind_Click(object sender, EventArgs e)
            if(IsNumeric(txtStdID.Text)==false) {
                MessageBox.Show("invalid ID","Find Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            int id = int.Parse(txtStdID.Text);
            SqlCommand command = new SqlCommand("SELECT id, fname, lname, bdate, gender, phone, address, picture FROM std WHERE id = " + id);
            DataTable table = student.getStudents(command);
            if (table.Rows.Count > 0)
            {
                txtFname.Text = table.Rows[0]["fname"].ToString();
                txtLname.Text = table.Rows[0]["lname"].ToString();
                dtpkBDate.Value = (DateTime)table.Rows[0]["bdate"];
                // gender
                if (table.Rows[0]["gender"].ToString() == "Female")
                    radFemale.Checked = true;
                else
                    radMale.Checked = true;
                txtPhone.Text = table.Rows[0]["phone"].ToString();
                txtAddress.Text = table.Rows[0]["address"].ToString();
                byte[] pic = (byte[])table.Rows[0]["picture"];
                MemoryStream picture = new MemoryStream(pic);
                picAvt.Image = Image.FromStream(picture);
            }
            else
            {
                MessageBox.Show("ID not exist", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            txtStdID.ReadOnly = true;
            int id;
            string fname = txtFname.Text;
            string lname = txtLname.Text;
            if (ContainsNumeric(fname) || ContainsNumeric(lname))
            {
                MessageBox.Show("First name and last name cannot contain numeric characters", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Stop further execution
            }
            DateTime bdate = dtpkBDate.Value;
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
            int bornYear = dtpkBDate.Value.Year;
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
                    id = Convert.ToInt32(txtStdID.Text);
                    picAvt.Image.Save(pic, picAvt.Image.RawFormat);
                    if (student.updateStudent(id, fname, lname, bdate, gender, phone, address, pic))
                    {
                        MessageBox.Show("Student be updated", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                    else
                    {
                        MessageBox.Show("Error", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtStdID.ReadOnly = false;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Edit student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("Please enter again", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        bool verif()
        {
            if ((txtFname.Text.Trim() == "")
                        || (txtLname.Text.Trim() == "")
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

        private void btRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int StudentID = Convert.ToInt32(txtStdID.Text);
                if (MessageBox.Show("Are you sure want to delete this student ?", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (student.deleteStudent(StudentID))
                    {
                        MessageBox.Show("Student deleted", "Delete student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtStdID.Text = "";
                        txtFname.Text = "";
                        txtLname.Text = "";
                        txtAddress.Text = "";
                        txtPhone.Text = "";
                        dtpkBDate.Value = DateTime.Now;
                        picAvt.Image = null;
                    }
                    else
                    {
                        MessageBox.Show("Student not be Deleted", "Delete student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please enter a valid id", "Delete student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.Show();
        }

        private void btUpImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                picAvt.Image = Image.FromFile(opf.FileName);
            }
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
    }

}
