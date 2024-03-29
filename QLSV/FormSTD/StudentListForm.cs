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
    public partial class StudentListForm : Form
    {
        public StudentListForm()
        {
            InitializeComponent();
        }
        STUDENT student = new STUDENT();
        private void StudentListForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDBDataSet.std' table. You can move, or remove it, as needed.
            this.stdTableAdapter.Fill(this.myDBDataSet.std);
            SqlCommand command = new SqlCommand("SELECT * FROM std");
            dataGridViewStudentList.ReadOnly = true;
            // xu ly hình anh, code co tham khao msdn
            DataGridViewImageColumn picCol = new DataGridViewImageColumn(); // doi tuong lam viec voi dang picture cua datagridview DataGridView1.RowTemplate.Height = 80; // dong nay tham khao tren MSDN ngay 10/03/2019, co gian de pic dep, dang tim auto-si
            dataGridViewStudentList.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)dataGridViewStudentList.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewStudentList.AllowUserToAddRows = false;
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            this.stdTableAdapter.Fill(this.myDBDataSet.std);
            SqlCommand command = new SqlCommand("SELECT * FROM std");
            dataGridViewStudentList.ReadOnly = true;
            // xu ly hình anh, code co tham khao msdn
            DataGridViewImageColumn picCol = new DataGridViewImageColumn(); // doi tuong lam viec voi dang picture cua datagridview DataGridView1.RowTemplate.Height = 80; // dong nay tham khao tren MSDN ngay 10/03/2019, co gian de pic dep, dang tim auto-si
            dataGridViewStudentList.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)dataGridViewStudentList.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewStudentList.AllowUserToAddRows = false;
        }
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            UpdateStudentForm updateStudent = new UpdateStudentForm();
            updateStudent.txtStdID.Text = dataGridViewStudentList.CurrentRow.Cells[0].Value.ToString();
            updateStudent.txtFname.Text = dataGridViewStudentList.CurrentRow.Cells[1].Value.ToString();
            updateStudent.txtLname.Text = dataGridViewStudentList.CurrentRow.Cells[2].Value.ToString();
            updateStudent.dtpkBDate.Value = (DateTime)dataGridViewStudentList.CurrentRow.Cells[3].Value;
            if (dataGridViewStudentList.CurrentRow.Cells[4].Value.ToString() == "Female")
            {
                updateStudent.radFemale.Checked = true;
            }
            updateStudent.txtPhone.Text = dataGridViewStudentList.CurrentRow.Cells[5].Value.ToString();
            updateStudent.txtAddress.Text = dataGridViewStudentList.CurrentRow.Cells[6].Value.ToString();
            byte[] pic;
            pic = (byte[])dataGridViewStudentList.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            updateStudent.picAvt.Image = Image.FromStream(picture);
            updateStudent.Show();
        }
    }
}
