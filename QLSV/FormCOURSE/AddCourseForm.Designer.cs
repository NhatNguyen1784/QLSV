namespace QLSV
{
    partial class AddCourseForm
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
            this.lbCourseID = new System.Windows.Forms.Label();
            this.txtCourseID = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.lbLabel = new System.Windows.Forms.Label();
            this.txtLabel = new System.Windows.Forms.TextBox();
            this.lbPeriod = new System.Windows.Forms.Label();
            this.txtPeriod = new System.Windows.Forms.TextBox();
            this.lbDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbCourseID
            // 
            this.lbCourseID.AutoSize = true;
            this.lbCourseID.Location = new System.Drawing.Point(45, 58);
            this.lbCourseID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCourseID.Name = "lbCourseID";
            this.lbCourseID.Size = new System.Drawing.Size(85, 20);
            this.lbCourseID.TabIndex = 0;
            this.lbCourseID.Text = "Course ID";
            // 
            // txtCourseID
            // 
            this.txtCourseID.Location = new System.Drawing.Point(179, 55);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.Size = new System.Drawing.Size(304, 27);
            this.txtCourseID.TabIndex = 1;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(135, 377);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(284, 55);
            this.btAdd.TabIndex = 2;
            this.btAdd.Text = "ADD";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // lbLabel
            // 
            this.lbLabel.AutoSize = true;
            this.lbLabel.Location = new System.Drawing.Point(45, 114);
            this.lbLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLabel.Name = "lbLabel";
            this.lbLabel.Size = new System.Drawing.Size(50, 20);
            this.lbLabel.TabIndex = 0;
            this.lbLabel.Text = "Label";
            // 
            // txtLabel
            // 
            this.txtLabel.Location = new System.Drawing.Point(179, 111);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Size = new System.Drawing.Size(304, 27);
            this.txtLabel.TabIndex = 1;
            // 
            // lbPeriod
            // 
            this.lbPeriod.AutoSize = true;
            this.lbPeriod.Location = new System.Drawing.Point(45, 172);
            this.lbPeriod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPeriod.Name = "lbPeriod";
            this.lbPeriod.Size = new System.Drawing.Size(57, 20);
            this.lbPeriod.TabIndex = 0;
            this.lbPeriod.Text = "Period";
            // 
            // txtPeriod
            // 
            this.txtPeriod.Location = new System.Drawing.Point(179, 169);
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.Size = new System.Drawing.Size(304, 27);
            this.txtPeriod.TabIndex = 1;
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(45, 232);
            this.lbDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(95, 20);
            this.lbDescription.TabIndex = 0;
            this.lbDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(179, 229);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(304, 98);
            this.txtDescription.TabIndex = 1;
            // 
            // AddCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 467);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtPeriod);
            this.Controls.Add(this.txtLabel);
            this.Controls.Add(this.txtCourseID);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.lbPeriod);
            this.Controls.Add(this.lbLabel);
            this.Controls.Add(this.lbCourseID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddCourseForm";
            this.Text = "AddCourseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCourseID;
        private System.Windows.Forms.TextBox txtCourseID;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label lbLabel;
        private System.Windows.Forms.TextBox txtLabel;
        private System.Windows.Forms.Label lbPeriod;
        private System.Windows.Forms.TextBox txtPeriod;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.TextBox txtDescription;
    }
}