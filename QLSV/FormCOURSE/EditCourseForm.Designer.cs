namespace QLSV
{
    partial class EditCourseForm
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
            this.btEdit = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtLabel = new System.Windows.Forms.TextBox();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbPeriod = new System.Windows.Forms.Label();
            this.lbLabel = new System.Windows.Forms.Label();
            this.lbCourseID = new System.Windows.Forms.Label();
            this.cbSelectCourse = new System.Windows.Forms.ComboBox();
            this.nrHours = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nrHours)).BeginInit();
            this.SuspendLayout();
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(161, 396);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(284, 55);
            this.btEdit.TabIndex = 11;
            this.btEdit.Text = "EDIT";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(205, 248);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(304, 98);
            this.txtDescription.TabIndex = 7;
            // 
            // txtLabel
            // 
            this.txtLabel.Location = new System.Drawing.Point(205, 130);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Size = new System.Drawing.Size(304, 22);
            this.txtLabel.TabIndex = 9;
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(71, 251);
            this.lbDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(75, 16);
            this.lbDescription.TabIndex = 3;
            this.lbDescription.Text = "Description";
            // 
            // lbPeriod
            // 
            this.lbPeriod.AutoSize = true;
            this.lbPeriod.Location = new System.Drawing.Point(71, 191);
            this.lbPeriod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPeriod.Name = "lbPeriod";
            this.lbPeriod.Size = new System.Drawing.Size(47, 16);
            this.lbPeriod.TabIndex = 4;
            this.lbPeriod.Text = "Period";
            // 
            // lbLabel
            // 
            this.lbLabel.AutoSize = true;
            this.lbLabel.Location = new System.Drawing.Point(71, 133);
            this.lbLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLabel.Name = "lbLabel";
            this.lbLabel.Size = new System.Drawing.Size(41, 16);
            this.lbLabel.TabIndex = 5;
            this.lbLabel.Text = "Label";
            // 
            // lbCourseID
            // 
            this.lbCourseID.AutoSize = true;
            this.lbCourseID.Location = new System.Drawing.Point(71, 77);
            this.lbCourseID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCourseID.Name = "lbCourseID";
            this.lbCourseID.Size = new System.Drawing.Size(89, 16);
            this.lbCourseID.TabIndex = 6;
            this.lbCourseID.Text = "Select course";
            // 
            // cbSelectCourse
            // 
            this.cbSelectCourse.FormattingEnabled = true;
            this.cbSelectCourse.Location = new System.Drawing.Point(205, 68);
            this.cbSelectCourse.Name = "cbSelectCourse";
            this.cbSelectCourse.Size = new System.Drawing.Size(304, 24);
            this.cbSelectCourse.TabIndex = 12;
            this.cbSelectCourse.SelectedIndexChanged += new System.EventHandler(this.cbSelectCourse_SelectedIndexChanged);
            // 
            // nrHours
            // 
            this.nrHours.Location = new System.Drawing.Point(205, 191);
            this.nrHours.Name = "nrHours";
            this.nrHours.Size = new System.Drawing.Size(120, 22);
            this.nrHours.TabIndex = 13;
            // 
            // EditCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 500);
            this.Controls.Add(this.nrHours);
            this.Controls.Add(this.cbSelectCourse);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtLabel);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.lbPeriod);
            this.Controls.Add(this.lbLabel);
            this.Controls.Add(this.lbCourseID);
            this.Name = "EditCourseForm";
            this.Text = "EditCourseForm";
            this.Load += new System.EventHandler(this.EditCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nrHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtLabel;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbPeriod;
        private System.Windows.Forms.Label lbLabel;
        private System.Windows.Forms.Label lbCourseID;
        private System.Windows.Forms.ComboBox cbSelectCourse;
        private System.Windows.Forms.NumericUpDown nrHours;
    }
}