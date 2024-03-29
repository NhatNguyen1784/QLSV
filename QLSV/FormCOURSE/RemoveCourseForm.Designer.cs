namespace QLSV
{
    partial class RemoveCourseForm
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
            this.btRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(12, 109);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(179, 20);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "ENTER A COURSE ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(218, 103);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(265, 27);
            this.txtID.TabIndex = 1;
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(345, 214);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(138, 33);
            this.btRemove.TabIndex = 2;
            this.btRemove.Text = "REMOVE";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // RemoveCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 317);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lbID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RemoveCourseForm";
            this.Text = "RemoveCourseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btRemove;
    }
}