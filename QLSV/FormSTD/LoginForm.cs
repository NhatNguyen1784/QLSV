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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            // bat loi voi error provider
            errorProviderUser.Clear();
            errorProviderPass.Clear();
            if (txtUsername.Text == "" && txtPassword.Text != "")
            {
                errorProviderUser.SetError(txtUsername, "Please enter user name");
            }
            else if (txtPassword.Text == "" && txtUsername.Text != "")
                errorProviderPass.SetError(txtPassword, "Please enter password");
            else if (txtUsername.Text == "" && txtPassword.Text == "")
            {
                errorProviderUser.SetError(txtUsername, "Please enter user name");
                errorProviderPass.SetError(txtPassword, "Please enter password");
            }
            else
            {
                MyDB db = new MyDB();

                SqlDataAdapter adapter = new SqlDataAdapter();

                DataTable table = new DataTable();

                SqlCommand command = new SqlCommand("SELECT * FROM Login WHERE username = @User AND password = @Pass", db.getConnection);

                command.Parameters.Add("@User", SqlDbType.VarChar).Value = txtUsername.Text.Trim();
                command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = txtPassword.Text.Trim();

                adapter.SelectCommand = command;

                adapter.Fill(table);
                if ((table.Rows.Count > 0))
                {
                    //MessageBox.Show("Ok, next time will be go to Main Menu of App");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Invalid Username Or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Thoát chương trình ?", "Exit", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                this.Close();
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            /*
            if (txtUsername.Text == "" && txtPassword.Text != "")
            {
                errorProviderUser.SetError(txtUsername, "Please enter user name");
            }
            else if (txtPassword.Text == "" && txtUsername.Text != "")
                errorProviderPass.SetError(txtPassword, "Please enter password");
            else if (txtUsername.Text == "" && txtPassword.Text == "")
            {
                errorProviderUser.SetError(txtUsername, "Please enter user name");
                errorProviderPass.SetError(txtPassword, "Please enter password");
            }
            if (txtUsername.Text!= "")
            {
                if (txtPassword.Text != "")
                {
                    MyDB mydb = new MyDB();
                    SqlCommand command1 = new SqlCommand("SELECT COUNT(*) FROM login WHERE username = @user", mydb.getConnection);
                    command1.Parameters.Add("@user", SqlDbType.VarChar).Value = txtUsername.Text;
                    mydb.openConnection();
                    if ((int)command1.ExecuteScalar() == 0)
                    {
                        command1 = new SqlCommand("SELECT COUNT(*) FROM login", mydb.getConnection);
                        int id = (int)(command1.ExecuteScalar());
                        SqlCommand command2 = new SqlCommand("INSERT INTO login (id, username, password) VALUES (@id, @user, @pass)", mydb.getConnection);
                        command2.Parameters.Add("@id", SqlDbType.Int).Value = id + 1;
                        command2.Parameters.Add("@user", SqlDbType.VarChar).Value = txtUsername.Text;
                        command2.Parameters.Add("@pass", SqlDbType.VarChar).Value = txtPassword.Text;
                        command2.ExecuteNonQuery(); //Lệnh để thực thi command
                        MessageBox.Show("User Registered");
                        //Close();
                    }
                    else
                    {
                        MessageBox.Show("User already exists", "Register Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    mydb.closeConnection();
                }
                else
                {
                    MessageBox.Show("Password error!");
                }
            }
            else
            {
                MessageBox.Show("Username error!");
            }*/
            NewUserForm newUserForm = new NewUserForm();
            newUserForm.Show();                }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void chkPass_CheckedChanged(object sender, EventArgs e)
        {
            if(chkPass.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else { txtPassword.UseSystemPasswordChar = true; }
        }

        private void linkLbPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResetPassword reset = new ResetPassword();
            reset.Show();
        }
    }
}
