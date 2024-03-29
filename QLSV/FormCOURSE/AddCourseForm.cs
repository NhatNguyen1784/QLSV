using Org.BouncyCastle.Pqc.Crypto.Lms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QLSV
{
    public partial class AddCourseForm : Form
    {
        public AddCourseForm()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                COURSE course = new COURSE();
                string name = txtLabel.Text;
                int id = int.Parse(txtCourseID.Text);
                int hrs = int.Parse(txtPeriod.Text);
                string descr = txtDescription.Text;
                if (name.Trim() == "")// lam việc voi string xoa het cac khoang trang, truoc sau chi lay ten
                {

                    MessageBox.Show("Please enter a course name", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (course.checkCourseName(name))
                {
                    if (hrs >= 10)
                    {
                        if (course.insertCourse(id, name, hrs, descr))
                        {

                            MessageBox.Show("New Course successfully Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {

                            MessageBox.Show("Course is incorrect informmation for Inserted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Time Course is not enough for add", "Time Course", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                }
                else
                {

                    MessageBox.Show("This Course Name Already Exists", "Add Course", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }
    }
}
