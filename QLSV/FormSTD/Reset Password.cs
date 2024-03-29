using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;
using System.Data.SqlClient;

namespace QLSV
{
    public partial class ResetPassword : Form
    {
        public ResetPassword()
        {
            InitializeComponent();
        }
        private int code;
        private Random rd = new Random();
        private void btSendCode_Click(object sender, EventArgs e)
        {
            errorMail.Clear();

            if (txtEmail.Text == "")
            {
                errorMail.SetError(txtEmail, "Email address is null");
            }
            else
            {
                try
                {
                    btSendCode.Visible = true;
                    // tạo mã code  6 số
                    code = rd.Next(100000, 1000000);
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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            if(code.ToString().Equals(txtCode.Text.Trim()))
            {
                pnMail.Visible = false;
                pnEnterPass.Visible = true;
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if(txtRePass.Text == txtPass.Text)
            {
                MyDB db = new MyDB();
                db.openConnection();
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Login WHERE username = @User", db.getConnection);
                command.Parameters.AddWithValue("@User", txtUser.Text);
                int userCount = (int)command.ExecuteScalar();
                if (userCount == 0)
                {
                    MessageBox.Show("User not exists, please try another.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (userCount == 1)
                {
                    // Cập nhật mật khẩu cho người dùng
                    SqlCommand updatePasswordCommand = new SqlCommand("UPDATE Login SET password = @Pass WHERE username = @User", db.getConnection);
                    updatePasswordCommand.Parameters.AddWithValue("@User", txtUser.Text);
                    updatePasswordCommand.Parameters.AddWithValue("@Pass", txtPass.Text);
                    try
                    {
                        int rowsAffected = updatePasswordCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password changed successfully!!!", "Message");
                            Close(); // Đóng form sau khi cập nhật mật khẩu thành công
                        }
                        else
                        {
                            MessageBox.Show("Failed to change password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Error!", "Message");
                }
                db.closeConnection();
            }
        }
    }
}
