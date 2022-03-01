
namespace WindowsFormsClientApp {
	partial class addStudentForm {
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
			this.label1 = new System.Windows.Forms.Label();
			this.fNameInput = new System.Windows.Forms.TextBox();
			this.lNameInput = new System.Windows.Forms.MaskedTextBox();
			this.gpaInput = new System.Windows.Forms.TextBox();
			this.dobInput = new System.Windows.Forms.DateTimePicker();
			this.addBtn = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(168, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(111, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Add student";
			// 
			// fNameInput
			// 
			this.fNameInput.Location = new System.Drawing.Point(120, 82);
			this.fNameInput.Name = "fNameInput";
			this.fNameInput.Size = new System.Drawing.Size(200, 20);
			this.fNameInput.TabIndex = 1;
			// 
			// lNameInput
			// 
			this.lNameInput.Location = new System.Drawing.Point(120, 120);
			this.lNameInput.Name = "lNameInput";
			this.lNameInput.Size = new System.Drawing.Size(200, 20);
			this.lNameInput.TabIndex = 2;
			// 
			// gpaInput
			// 
			this.gpaInput.Location = new System.Drawing.Point(120, 157);
			this.gpaInput.Name = "gpaInput";
			this.gpaInput.Size = new System.Drawing.Size(200, 20);
			this.gpaInput.TabIndex = 1;
			// 
			// dobInput
			// 
			this.dobInput.Location = new System.Drawing.Point(120, 195);
			this.dobInput.Name = "dobInput";
			this.dobInput.Size = new System.Drawing.Size(200, 20);
			this.dobInput.TabIndex = 3;
			// 
			// addBtn
			// 
			this.addBtn.Location = new System.Drawing.Point(245, 244);
			this.addBtn.Name = "addBtn";
			this.addBtn.Size = new System.Drawing.Size(75, 23);
			this.addBtn.TabIndex = 4;
			this.addBtn.Text = "Add";
			this.addBtn.UseVisualStyleBackColor = true;
			this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(44, 85);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "First name:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(44, 123);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Last name:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(45, 160);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 13);
			this.label4.TabIndex = 5;
			this.label4.Text = "GPA:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(44, 198);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(68, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "Date of birth:";
			// 
			// addStudentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(467, 369);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.addBtn);
			this.Controls.Add(this.dobInput);
			this.Controls.Add(this.lNameInput);
			this.Controls.Add(this.gpaInput);
			this.Controls.Add(this.fNameInput);
			this.Controls.Add(this.label1);
			this.Name = "addStudentForm";
			this.Text = "addStudentForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox fNameInput;
		private System.Windows.Forms.MaskedTextBox lNameInput;
		private System.Windows.Forms.TextBox gpaInput;
		private System.Windows.Forms.DateTimePicker dobInput;
		private System.Windows.Forms.Button addBtn;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
	}
}