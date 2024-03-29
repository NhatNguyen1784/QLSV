using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class NewUserForm : Form
    {
        public NewUserForm()
        {
            InitializeComponent();

        }
        private int code = 0;
        private Random rd = new Random();
        private void btSendCode_Click(object sender, EventArgs e)
        {
            errorEmail.Clear();

            if(txtEmail.Text == "")
            {
                errorEmail.SetError(txtEmail, "Email address is null");
            }
            else
            {
                try
                {
                    btSendCode.Visible = true;
                    // tạo mã code  6 số
                    code = rd.Next(100000,1000000);
                    // mail để gửi
                    var fromAddrres = new MailAddress("nguyennhatnguyen1782004@gmail.com");
                    // address mail nhận code
                    var toAddress = new MailAddress(txtEmail.Text);
                    const string fromPass = "qrtf cahy byip yktz";
                    const string subject = "Code";
                    string body = code.ToString();
                    var smtp = new SmtpClient()
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(fromAddrres.Address, fromPass)
                    };
                    using (var message = new MailMessage(fromAddrres, toAddress)
                    {
                        Subject = subject,
                        Body = body
                    })
                    {
                        smtp.Send(message);
                    }
                    MessageBox.Show("Code sent your email", "Message");

                }
                catch(Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            errorPass.Clear();
            if (code.ToString().Equals(txtCode.Text))
            {
                if (txtUser.Text != "")
                {
                    if (txtPass.Text != "")
                    {
                        if(txtPass.Text == txtRePass.Text)
                        {
                            MyDB mydb = new MyDB();
                            SqlCommand command1 = new SqlCommand("SELECT COUNT(*) FROM login WHERE username = @user", mydb.getConnection);
                            command1.Parameters.Add("@user", SqlDbType.VarChar).Value = txtUser.Text;
                            mydb.openConnection();
                            if ((int)command1.ExecuteScalar() == 0)
                            {
                                command1 = new SqlCommand("SELECT COUNT(*) FROM login", mydb.getConnection);
                                int id = (int)(command1.ExecuteScalar());
                                SqlCommand command2 = new SqlCommand("INSERT INTO login (id, username, password) VALUES (@id, @user, @pass)", mydb.getConnection);
                                command2.Parameters.Add("@id", SqlDbType.Int).Value = id + 1;
                                command2.Parameters.Add("@user", SqlDbType.VarChar).Value = txtUser.Text;
                                command2.Parameters.Add("@pass", SqlDbType.VarChar).Value = txtPass.Text;
                                command2.ExecuteNonQuery(); //Lệnh để thực thi command
                                MessageBox.Show("User Registered");
                                Close();
                            }
                            else
                            {
                                MessageBox.Show("User already exists", "Register Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            mydb.closeConnection();
                        }
                        else
                        {
                            errorPass.SetError(txtRePass, "Incorrect Password");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password error!");
                    }
                }
            }
            else
            {
                MessageBox.Show("incorrect code", "Warning");
            }
        }
    }
}
