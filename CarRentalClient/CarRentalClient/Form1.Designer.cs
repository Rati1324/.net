
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
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
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
	}
}

