namespace QLSV
{
    partial class AddStudentForm
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
            this.lbID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dtpkBirthDate = new System.Windows.Forms.DateTimePicker();
            this.grbGender = new System.Windows.Forms.GroupBox();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lbLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lbBirthDate = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lbpicture = new System.Windows.Forms.Label();
            this.btUpImage = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.picAvt = new System.Windows.Forms.PictureBox();
            this.grbGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvt)).BeginInit();
            this.SuspendLayout();
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbID.ForeColor = System.Drawing.Color.White;
            this.lbID.Location = new System.Drawing.Point(37, 32);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(134, 29);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "Student ID";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtID.Location = new System.Drawing.Point(234, 27);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(312, 30);
            this.txtID.TabIndex = 0;
            // 
            // dtpkBirthDate
            // 
            this.dtpkBirthDate.CustomFormat = "dd/MM/yyyy";
            this.dtpkBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkBirthDate.Location = new System.Drawing.Point(240, 198);
            this.dtpkBirthDate.Name = "dtpkBirthDate";
            this.dtpkBirthDate.Size = new System.Drawing.Size(306, 22);
            this.dtpkBirthDate.TabIndex = 3;
            // 
            // grbGender
            // 
            this.grbGender.Controls.Add(this.radFemale);
            this.grbGender.Controls.Add(this.radMale);
            this.grbGender.Location = new System.Drawing.Point(234, 240);
            this.grbGender.Name = "grbGender";
            this.grbGender.Size = new System.Drawing.Size(312, 51);
            this.grbGender.TabIndex = 4;
            this.grbGender.TabStop = false;
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Location = new System.Drawing.Point(164, 21);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(74, 20);
            this.radFemale.TabIndex = 1;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "Female";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Location = new System.Drawing.Point(6, 21);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(58, 20);
            this.radMale.TabIndex = 0;
            this.radMale.TabStop = true;
            this.radMale.Text = "Male";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(346, 642);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbFirstName.ForeColor = System.Drawing.Color.White;
            this.lbFirstName.Location = new System.Drawing.Point(37, 91);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(136, 29);
            this.lbFirstName.TabIndex = 0;
            this.lbFirstName.Text = "First name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtFirstName.Location = new System.Drawing.Point(234, 86);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(312, 30);
            this.txtFirstName.TabIndex = 1;
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbLastName.ForeColor = System.Drawing.Color.White;
            this.lbLastName.Location = new System.Drawing.Point(37, 146);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(132, 29);
            this.lbLastName.TabIndex = 0;
            this.lbLastName.Text = "Last name";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtLastName.Location = new System.Drawing.Point(234, 141);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(312, 30);
            this.txtLastName.TabIndex = 2;
            // 
            // lbBirthDate
            // 
            this.lbBirthDate.AutoSize = true;
            this.lbBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbBirthDate.ForeColor = System.Drawing.Color.White;
            this.lbBirthDate.Location = new System.Drawing.Point(37, 191);
            this.lbBirthDate.Name = "lbBirthDate";
            this.lbBirthDate.Size = new System.Drawing.Size(125, 29);
            this.lbBirthDate.TabIndex = 0;
            this.lbBirthDate.Text = "Birth date";
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbGender.ForeColor = System.Drawing.Color.White;
            this.lbGender.Location = new System.Drawing.Point(37, 252);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(100, 29);
            this.lbGender.TabIndex = 0;
            this.lbGender.Text = "Gender";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbPhone.ForeColor = System.Drawing.Color.White;
            this.lbPhone.Location = new System.Drawing.Point(37, 336);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(88, 29);
            this.lbPhone.TabIndex = 0;
            this.lbPhone.Text = "Phone";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPhone.Location = new System.Drawing.Point(234, 331);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(312, 30);
            this.txtPhone.TabIndex = 4;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbAddress.ForeColor = System.Drawing.Color.White;
            this.lbAddress.Location = new System.Drawing.Point(37, 391);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(109, 29);
            this.lbAddress.TabIndex = 0;
            this.lbAddress.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtAddress.Location = new System.Drawing.Point(234, 386);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(312, 74);
            this.txtAddress.TabIndex = 5;
            // 
            // lbpicture
            // 
            this.lbpicture.AutoSize = true;
            this.lbpicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbpicture.ForeColor = System.Drawing.Color.White;
            this.lbpicture.Location = new System.Drawing.Point(37, 514);
            this.lbpicture.Name = "lbpicture";
            this.lbpicture.Size = new System.Drawing.Size(95, 29);
            this.lbpicture.TabIndex = 0;
            this.lbpicture.Text = "Picture";
            // 
            // btUpImage
            // 
            this.btUpImage.ForeColor = System.Drawing.Color.Black;
            this.btUpImage.Location = new System.Drawing.Point(234, 642);
            this.btUpImage.Name = "btUpImage";
            this.btUpImage.Size = new System.Drawing.Size(312, 23);
            this.btUpImage.TabIndex = 6;
            this.btUpImage.Text = "Upload Image";
            this.btUpImage.UseVisualStyleBackColor = true;
            this.btUpImage.Click += new System.EventHandler(this.btUpImage_Click_1);
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.Red;
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btCancel.ForeColor = System.Drawing.Color.White;
            this.btCancel.Location = new System.Drawing.Point(65, 702);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(139, 36);
            this.btCancel.TabIndex = 9;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btAdd.ForeColor = System.Drawing.Color.White;
            this.btAdd.Location = new System.Drawing.Point(398, 702);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(139, 36);
            this.btAdd.TabIndex = 8;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // picAvt
            // 
            this.picAvt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.picAvt.Location = new System.Drawing.Point(234, 477);
            this.picAvt.Name = "picAvt";
            this.picAvt.Size = new System.Drawing.Size(312, 159);
            this.picAvt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvt.TabIndex = 3;
            this.picAvt.TabStop = false;
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(635, 750);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btUpImage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grbGender);
            this.Controls.Add(this.picAvt);
            this.Controls.Add(this.dtpkBirthDate);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lbGender);
            this.Controls.Add(this.lbBirthDate);
            this.Controls.Add(this.lbpicture);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.lbFirstName);
            this.Controls.Add(this.lbID);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "AddStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddStudentForm";
            this.grbGender.ResumeLayout(false);
            this.grbGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DateTimePicker dtpkBirthDate;
        private System.Windows.Forms.PictureBox picAvt;
        private System.Windows.Forms.GroupBox grbGender;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lbBirthDate;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lbpicture;
        private System.Windows.Forms.Button btUpImage;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.RadioButton radFemale;
    }
}