
namespace EduClientApp
{
    partial class Form1
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
			this.studentManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.getAllStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.updateStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.studentGrid = new System.Windows.Forms.DataGridView();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.studentGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentManagementToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
			this.menuStrip1.Size = new System.Drawing.Size(731, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// studentManagementToolStripMenuItem
			// 
			this.studentManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getAllStudentsToolStripMenuItem,
            this.addStudentToolStripMenuItem,
            this.updateStudentToolStripMenuItem,
            this.deleteStudentToolStripMenuItem});
			this.studentManagementToolStripMenuItem.Name = "studentManagementToolStripMenuItem";
			this.studentManagementToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
			this.studentManagementToolStripMenuItem.Text = "StudentManagement";
			// 
			// getAllStudentsToolStripMenuItem
			// 
			this.getAllStudentsToolStripMenuItem.Name = "getAllStudentsToolStripMenuItem";
			this.getAllStudentsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.getAllStudentsToolStripMenuItem.Text = "Get All Students";
			this.getAllStudentsToolStripMenuItem.Click += new System.EventHandler(this.getAllStudentsToolStripMenuItem_Click);
			// 
			// addStudentToolStripMenuItem
			// 
			this.addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
			this.addStudentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.addStudentToolStripMenuItem.Text = "Add Student";
			this.addStudentToolStripMenuItem.Click += new System.EventHandler(this.addStudentToolStripMenuItem_Click);
			// 
			// updateStudentToolStripMenuItem
			// 
			this.updateStudentToolStripMenuItem.Name = "updateStudentToolStripMenuItem";
			this.updateStudentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.updateStudentToolStripMenuItem.Text = "Update Student";
			this.updateStudentToolStripMenuItem.Click += new System.EventHandler(this.updateStudentToolStripMenuItem_Click);
			// 
			// deleteStudentToolStripMenuItem
			// 
			this.deleteStudentToolStripMenuItem.Name = "deleteStudentToolStripMenuItem";
			this.deleteStudentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.deleteStudentToolStripMenuItem.Text = "Delete Student";
			this.deleteStudentToolStripMenuItem.Click += new System.EventHandler(this.deleteStudentToolStripMenuItem_Click);
			// 
			// studentGrid
			// 
			this.studentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.studentGrid.Location = new System.Drawing.Point(8, 38);
			this.studentGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.studentGrid.Name = "studentGrid";
			this.studentGrid.RowHeadersWidth = 62;
			this.studentGrid.RowTemplate.Height = 28;
			this.studentGrid.Size = new System.Drawing.Size(637, 307);
			this.studentGrid.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(731, 371);
			this.Controls.Add(this.studentGrid);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "Form1";
			this.Text = "Form1";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.studentGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem studentManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getAllStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteStudentToolStripMenuItem;
        private System.Windows.Forms.DataGridView studentGrid;
	}
}

