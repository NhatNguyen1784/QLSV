using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class RemoveCourseForm : Form
    {
        public RemoveCourseForm()
        {
            InitializeComponent();
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            COURSE course = new COURSE();
            int id = int.Parse(txtID.Text);
            if(MessageBox.Show("Are you sure to delete this course?","Warning",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if(course.deleteCourse(id))
                {
                    MessageBox.Show("A course removed successfull","Deleted", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Invalid ID", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
        }
    }
}
