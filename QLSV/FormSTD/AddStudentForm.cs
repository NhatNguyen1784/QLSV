using QLSV.OOP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            STUDENT student = new STUDENT();
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


        //  chuc nang kiem tra du lieu input
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

        // button browse image
        private void btUpImage_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                picAvt.Image = Image.FromFile(opf.FileName);
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
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
            int dem = 0;
            foreach (char c in input)
            {
                dem++;
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            if(dem == 10)
                return true;
            return false;
        }
    }
}
