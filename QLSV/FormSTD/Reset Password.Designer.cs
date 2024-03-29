namespace QLSV
{
    partial class ResetPassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnMail = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbMail = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btSendCode = new System.Windows.Forms.Button();
            this.btConfirm = new System.Windows.Forms.Button();
            this.errorMail = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnEnterPass = new System.Windows.Forms.Panel();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRePass = new System.Windows.Forms.TextBox();
            this.lbRepass = new System.Windows.Forms.Label();
            this.btOK = new System.Windows.Forms.Button();
            this.lbUser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.pnMail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorMail)).BeginInit();
            this.pnEnterPass.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMail
            // 
            this.pnMail.Controls.Add(this.btConfirm);
            this.pnMail.Controls.Add(this.btSendCode);
            this.pnMail.Controls.Add(this.txtCode);
            this.pnMail.Controls.Add(this.label2);
            this.pnMail.Controls.Add(this.txtEmail);
            this.pnMail.Controls.Add(this.lbMail);
            this.pnMail.Location = new System.Drawing.Point(28, 125);
            this.pnMail.Name = "pnMail";
            this.pnMail.Size = new System.Drawing.Size(770, 333);
            this.pnMail.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "RESET PASSWORD";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtEmail.Location = new System.Drawing.Point(200, 47);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(299, 30);
            this.txtEmail.TabIndex = 3;
            // 
            // lbMail
            // 
            this.lbMail.AutoSize = true;
            this.lbMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMail.Location = new System.Drawing.Point(67, 52);
            this.lbMail.Name = "lbMail";
            this.lbMail.Size = new System.Drawing.Size(67, 25);
            this.lbMail.TabIndex = 2;
            this.lbMail.Text = "E-mail";
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtCode.Location = new System.Drawing.Point(202, 112);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(299, 30);
            this.txtCode.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(67, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Code";
            // 
            // btSendCode
            // 
            this.btSendCode.AutoSize = true;
            this.btSendCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btSendCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btSendCode.Location = new System.Drawing.Point(545, 40);
            this.btSendCode.Name = "btSendCode";
            this.btSendCode.Size = new System.Drawing.Size(117, 37);
            this.btSendCode.TabIndex = 6;
            this.btSendCode.Text = "send code";
            this.btSendCode.UseVisualStyleBackColor = false;
            this.btSendCode.Click += new System.EventHandler(this.btSendCode_Click);
            // 
            // btConfirm
            // 
            this.btConfirm.AutoSize = true;
            this.btConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btConfirm.Location = new System.Drawing.Point(321, 174);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(125, 37);
            this.btConfirm.TabIndex = 6;
            this.btConfirm.Text = "Verify Code";
            this.btConfirm.UseVisualStyleBackColor = false;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // errorMail
            // 
            this.errorMail.ContainerControl = this;
            // 
            // pnEnterPass
            // 
            this.pnEnterPass.Controls.Add(this.btOK);
            this.pnEnterPass.Controls.Add(this.txtRePass);
            this.pnEnterPass.Controls.Add(this.lbRepass);
            this.pnEnterPass.Controls.Add(this.txtUser);
            this.pnEnterPass.Controls.Add(this.txtPass);
            this.pnEnterPass.Controls.Add(this.lbUser);
            this.pnEnterPass.Controls.Add(this.label3);
            this.pnEnterPass.Location = new System.Drawing.Point(31, 122);
            this.pnEnterPass.Name = "pnEnterPass";
            this.pnEnterPass.Size = new System.Drawing.Size(770, 333);
            this.pnEnterPass.TabIndex = 2;
            this.pnEnterPass.Visible = false;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPass.Location = new System.Drawing.Point(303, 75);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(299, 30);
            this.txtPass.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(168, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // txtRePass
            // 
            this.txtRePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtRePass.Location = new System.Drawing.Point(303, 157);
            this.txtRePass.Name = "txtRePass";
            this.txtRePass.Size = new System.Drawing.Size(299, 30);
            this.txtRePass.TabIndex = 5;
            // 
            // lbRepass
            // 
            this.lbRepass.AutoSize = true;
            this.lbRepass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbRepass.Location = new System.Drawing.Point(168, 162);
            this.lbRepass.Name = "lbRepass";
            this.lbRepass.Size = new System.Drawing.Size(129, 25);
            this.lbRepass.TabIndex = 4;
            this.lbRepass.Text = "Re-Password";
            // 
            // btOK
            // 
            this.btOK.AutoSize = true;
            this.btOK.BackColor = System.Drawing.Color.Chartreuse;
            this.btOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btOK.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btOK.Location = new System.Drawing.Point(321, 264);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(117, 37);
            this.btOK.TabIndex = 6;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = false;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbUser.Location = new System.Drawing.Point(168, 19);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(53, 25);
            this.lbUser.TabIndex = 2;
            this.lbUser.Text = "User";
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtUser.Location = new System.Drawing.Point(303, 14);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(299, 30);
            this.txtUser.TabIndex = 3;
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 487);
            this.Controls.Add(this.pnEnterPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnMail);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ResetPassword";
            this.Text = "ResetPassword";
            this.pnMail.ResumeLayout(false);
            this.pnMail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorMail)).EndInit();
            this.pnEnterPass.ResumeLayout(false);
            this.pnEnterPass.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbMail;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btConfirm;
        private System.Windows.Forms.Button btSendCode;
        private System.Windows.Forms.ErrorProvider errorMail;
        private System.Windows.Forms.Panel pnEnterPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRePass;
        private System.Windows.Forms.Label lbRepass;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lbUser;
    }
}