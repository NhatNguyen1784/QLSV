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
    public partial class SearchForm : Form
    {
        MyDB db = new MyDB();
        private int tmp = 0;
        public SearchForm()
        {
            InitializeComponent();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            string searchText = search_txt.Text.Trim();
            if (tmp == 1)
            {
                SqlCommand command = new SqlCommand("SELECT * FROM std WHERE fname LIKE @search", db.getConnection);
                command.Parameters.AddWithValue("@search","%" + searchText + "%");
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridViewSearch.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error! " + ex.Message);
                }
            }
            else if (tmp == 2)
            {
                SqlCommand command = new SqlCommand("SELECT * FROM std WHERE lname LIKE @searchValue", db.getConnection);
                command.Parameters.AddWithValue("@searchValue", "%" + searchText + "%");
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridViewSearch.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error! " + ex.Message);
                }
            }
            else if(tmp == 3)
            {
                SqlCommand command = new SqlCommand("SELECT * FROM std WHERE phone LIKE @searchValue", db.getConnection);
                command.Parameters.AddWithValue("@searchValue", "%" + searchText + "%");
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridViewSearch.DataSource = dt;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error! " + ex.Message);
                }

            }
            //else 
            //{
                
            //    MessageBox.Show("Please choose mode!");
            //}
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDBDataSet.std' table. You can move, or remove it, as needed.
            this.stdTableAdapter.Fill(this.myDBDataSet.std);
            dataGridViewSearch.ReadOnly = true;

        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox.SelectedIndex == 0)
            {
                tmp = 1;
            }
            else if(comboBox.SelectedIndex == 1)
            {
                tmp = 2;
            }
            else if(comboBox.SelectedIndex == 2)
            {
                tmp = 3;
            }
        }
    }
}
