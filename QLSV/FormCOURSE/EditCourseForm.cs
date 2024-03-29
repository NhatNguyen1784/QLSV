using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class EditCourseForm : Form
    {
        COURSE course = new COURSE();
        MyDB db = new MyDB();
        public EditCourseForm()
        {
            InitializeComponent();

        }
        private void btEdit_Click(object sender, EventArgs e)
        {
            try
            {
                
                int id = Convert.ToInt32(cbSelectCourse.SelectedItem);
                string name = txtLabel.Text;
                int hrs = Convert.ToInt32(nrHours.Value);
                string descr = txtDescription.Text;
                if (!course.checkCourseName(name))
                {
                    MessageBox.Show("Course already Exist", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (course.updateCourse(id, name, hrs, descr))
                {
                    MessageBox.Show("This Course updated successfull", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Fail to Edit", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Notify", MessageBoxButtons.OK);
            }
        }

        private void EditCourseForm_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT Id FROM Course", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cbSelectCourse.Items.Add(dr["id"].ToString());
            }
            nrHours.Minimum = 10;
        }


        private void cbSelectCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public bool checkCourseName(string courseName, int courseId = 0)
        {
            // id <> @cID de phan biet xem co ton tai khong, chi la parameter
            SqlCommand command = new SqlCommand("SELECT * FROM Course WHERE label=@name And Id <> @id", db.getConnection);
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = courseName;
            command.Parameters.Add("@id", SqlDbType.Int).Value = courseId;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if ((table.Rows.Count > 0))
            {
                // neu phat hien co 1 dong ton tai trung ten
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
