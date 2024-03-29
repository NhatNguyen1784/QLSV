namespace QLSV
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sTUDENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRemoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOURSEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDCOURSEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEMOVECOURSEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITCOURSEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mANAGECOURSEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRINTToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sCORCEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sTUDENTToolStripMenuItem,
            this.cOURSEToolStripMenuItem,
            this.sCORCEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(891, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sTUDENTToolStripMenuItem
            // 
            this.sTUDENTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewStudentToolStripMenuItem,
            this.studentsListToolStripMenuItem,
            this.staticToolStripMenuItem,
            this.editRemoveToolStripMenuItem,
            this.manageToolStripMenuItem,
            this.printToolStripMenuItem});
            this.sTUDENTToolStripMenuItem.Name = "sTUDENTToolStripMenuItem";
            this.sTUDENTToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.sTUDENTToolStripMenuItem.Text = "&STUDENT";
            // 
            // addNewStudentToolStripMenuItem
            // 
            this.addNewStudentToolStripMenuItem.Name = "addNewStudentToolStripMenuItem";
            this.addNewStudentToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.addNewStudentToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.addNewStudentToolStripMenuItem.Text = "Add New Student";
            this.addNewStudentToolStripMenuItem.Click += new System.EventHandler(this.addNewStudentToolStripMenuItem_Click);
            // 
            // studentsListToolStripMenuItem
            // 
            this.studentsListToolStripMenuItem.Name = "studentsListToolStripMenuItem";
            this.studentsListToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.studentsListToolStripMenuItem.Text = "Students List";
            this.studentsListToolStripMenuItem.Click += new System.EventHandler(this.studentsListToolStripMenuItem_Click);
            // 
            // staticToolStripMenuItem
            // 
            this.staticToolStripMenuItem.Name = "staticToolStripMenuItem";
            this.staticToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.staticToolStripMenuItem.Text = "Static";
            // 
            // editRemoveToolStripMenuItem
            // 
            this.editRemoveToolStripMenuItem.Name = "editRemoveToolStripMenuItem";
            this.editRemoveToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.editRemoveToolStripMenuItem.Text = "Edit/Remove";
            this.editRemoveToolStripMenuItem.Click += new System.EventHandler(this.editRemoveToolStripMenuItem_Click);
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.manageToolStripMenuItem.Text = "Manage Student Form";
            this.manageToolStripMenuItem.Click += new System.EventHandler(this.manageToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // cOURSEToolStripMenuItem
            // 
            this.cOURSEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDCOURSEToolStripMenuItem,
            this.rEMOVECOURSEToolStripMenuItem,
            this.eDITCOURSEToolStripMenuItem,
            this.mANAGECOURSEToolStripMenuItem,
            this.pRINTToolStripMenuItem1});
            this.cOURSEToolStripMenuItem.Name = "cOURSEToolStripMenuItem";
            this.cOURSEToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.cOURSEToolStripMenuItem.Text = "COURSE";
            // 
            // aDDCOURSEToolStripMenuItem
            // 
            this.aDDCOURSEToolStripMenuItem.Name = "aDDCOURSEToolStripMenuItem";
            this.aDDCOURSEToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aDDCOURSEToolStripMenuItem.Text = "ADD COURSE";
            this.aDDCOURSEToolStripMenuItem.Click += new System.EventHandler(this.aDDCOURSEToolStripMenuItem_Click);
            // 
            // rEMOVECOURSEToolStripMenuItem
            // 
            this.rEMOVECOURSEToolStripMenuItem.Name = "rEMOVECOURSEToolStripMenuItem";
            this.rEMOVECOURSEToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.rEMOVECOURSEToolStripMenuItem.Text = "REMOVE COURSE";
            this.rEMOVECOURSEToolStripMenuItem.Click += new System.EventHandler(this.rEMOVECOURSEToolStripMenuItem_Click);
            // 
            // eDITCOURSEToolStripMenuItem
            // 
            this.eDITCOURSEToolStripMenuItem.Name = "eDITCOURSEToolStripMenuItem";
            this.eDITCOURSEToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.eDITCOURSEToolStripMenuItem.Text = "EDIT COURSE";
            this.eDITCOURSEToolStripMenuItem.Click += new System.EventHandler(this.eDITCOURSEToolStripMenuItem_Click);
            // 
            // mANAGECOURSEToolStripMenuItem
            // 
            this.mANAGECOURSEToolStripMenuItem.Name = "mANAGECOURSEToolStripMenuItem";
            this.mANAGECOURSEToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.mANAGECOURSEToolStripMenuItem.Text = "MANAGE COURSE";
            // 
            // pRINTToolStripMenuItem1
            // 
            this.pRINTToolStripMenuItem1.Name = "pRINTToolStripMenuItem1";
            this.pRINTToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.pRINTToolStripMenuItem1.Text = "PRINT";
            // 
            // sCORCEToolStripMenuItem
            // 
            this.sCORCEToolStripMenuItem.Name = "sCORCEToolStripMenuItem";
            this.sCORCEToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.sCORCEToolStripMenuItem.Text = "SCORCE";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainFormcs";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sTUDENTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOURSEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sCORCEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staticToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editRemoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDCOURSEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEMOVECOURSEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITCOURSEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mANAGECOURSEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRINTToolStripMenuItem1;
    }
}