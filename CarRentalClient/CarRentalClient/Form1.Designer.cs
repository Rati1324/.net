
namespace CarRentalClient {
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
			this.carsGrid = new System.Windows.Forms.DataGridView();
			this.importBtn = new System.Windows.Forms.Button();
			this.insertBtn = new System.Windows.Forms.Button();
			this.editBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.carsGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// carsGrid
			// 
			this.carsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.carsGrid.Location = new System.Drawing.Point(53, 81);
			this.carsGrid.Name = "carsGrid";
			this.carsGrid.Size = new System.Drawing.Size(458, 265);
			this.carsGrid.TabIndex = 0;
			// 
			// importBtn
			// 
			this.importBtn.Location = new System.Drawing.Point(53, 26);
			this.importBtn.Name = "importBtn";
			this.importBtn.Size = new System.Drawing.Size(75, 23);
			this.importBtn.TabIndex = 1;
			this.importBtn.Text = "Import";
			this.importBtn.UseVisualStyleBackColor = true;
			this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
			// 
			// insertBtn
			// 
			this.insertBtn.Location = new System.Drawing.Point(154, 26);
			this.insertBtn.Name = "insertBtn";
			this.insertBtn.Size = new System.Drawing.Size(75, 23);
			this.insertBtn.TabIndex = 2;
			this.insertBtn.Text = "Insert";
			this.insertBtn.UseVisualStyleBackColor = true;
			this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
			// 
			// editBtn
			// 
			this.editBtn.Location = new System.Drawing.Point(255, 26);
			this.editBtn.Name = "editBtn";
			this.editBtn.Size = new System.Drawing.Size(75, 23);
			this.editBtn.TabIndex = 3;
			this.editBtn.Text = "Edit";
			this.editBtn.UseVisualStyleBackColor = true;
			this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(730, 428);
			this.Controls.Add(this.editBtn);
			this.Controls.Add(this.insertBtn);
			this.Controls.Add(this.importBtn);
			this.Controls.Add(this.carsGrid);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.carsGrid)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView carsGrid;
		private System.Windows.Forms.Button importBtn;
		private System.Windows.Forms.Button insertBtn;
		private System.Windows.Forms.Button editBtn;
	}
}

