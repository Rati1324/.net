
namespace MidTermClient {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.importBtn = new System.Windows.Forms.Button();
			this.phonesGrid = new System.Windows.Forms.DataGridView();
			this.addBtn = new System.Windows.Forms.Button();
			this.deleteBtn = new System.Windows.Forms.Button();
			this.editBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.phonesGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// importBtn
			// 
			this.importBtn.Location = new System.Drawing.Point(41, 35);
			this.importBtn.Name = "importBtn";
			this.importBtn.Size = new System.Drawing.Size(75, 23);
			this.importBtn.TabIndex = 0;
			this.importBtn.Text = "Import";
			this.importBtn.UseVisualStyleBackColor = true;
			this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
			// 
			// phonesGrid
			// 
			this.phonesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.phonesGrid.Location = new System.Drawing.Point(41, 74);
			this.phonesGrid.Name = "phonesGrid";
			this.phonesGrid.Size = new System.Drawing.Size(573, 281);
			this.phonesGrid.TabIndex = 1;
			// 
			// addBtn
			// 
			this.addBtn.Location = new System.Drawing.Point(539, 35);
			this.addBtn.Name = "addBtn";
			this.addBtn.Size = new System.Drawing.Size(75, 23);
			this.addBtn.TabIndex = 2;
			this.addBtn.Text = "Add";
			this.addBtn.UseVisualStyleBackColor = true;
			this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
			// 
			// deleteBtn
			// 
			this.deleteBtn.Location = new System.Drawing.Point(445, 35);
			this.deleteBtn.Name = "deleteBtn";
			this.deleteBtn.Size = new System.Drawing.Size(75, 23);
			this.deleteBtn.TabIndex = 3;
			this.deleteBtn.Text = "Delete";
			this.deleteBtn.UseVisualStyleBackColor = true;
			this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
			// 
			// editBtn
			// 
			this.editBtn.Location = new System.Drawing.Point(354, 35);
			this.editBtn.Name = "editBtn";
			this.editBtn.Size = new System.Drawing.Size(75, 23);
			this.editBtn.TabIndex = 4;
			this.editBtn.Text = "Edit";
			this.editBtn.UseVisualStyleBackColor = true;
			this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.editBtn);
			this.Controls.Add(this.deleteBtn);
			this.Controls.Add(this.addBtn);
			this.Controls.Add(this.phonesGrid);
			this.Controls.Add(this.importBtn);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.phonesGrid)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button importBtn;
		private System.Windows.Forms.DataGridView phonesGrid;
		private System.Windows.Forms.Button addBtn;
		private System.Windows.Forms.Button deleteBtn;
		private System.Windows.Forms.Button editBtn;
	}
}

