
namespace EduClientApp {
	partial class AddStudentForm {
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
			this.addBtn = new System.Windows.Forms.Button();
			this.fNameInput = new System.Windows.Forms.TextBox();
			this.lNameInput = new System.Windows.Forms.TextBox();
			this.gpaInput = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.dobInput = new System.Windows.Forms.DateTimePicker();
			this.updateBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// addBtn
			// 
			this.addBtn.Location = new System.Drawing.Point(380, 270);
			this.addBtn.Name = "addBtn";
			this.addBtn.Size = new System.Drawing.Size(75, 23);
			this.addBtn.TabIndex = 0;
			this.addBtn.Text = "Add";
			this.addBtn.UseVisualStyleBackColor = true;
			this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
			// 
			// fNameInput
			// 
			this.fNameInput.Location = new System.Drawing.Point(254, 112);
			this.fNameInput.Name = "fNameInput";
			this.fNameInput.Size = new System.Drawing.Size(201, 20);
			this.fNameInput.TabIndex = 1;
			// 
			// lNameInput
			// 
			this.lNameInput.Location = new System.Drawing.Point(254, 152);
			this.lNameInput.Name = "lNameInput";
			this.lNameInput.Size = new System.Drawing.Size(201, 20);
			this.lNameInput.TabIndex = 1;
			// 
			// gpaInput
			// 
			this.gpaInput.Location = new System.Drawing.Point(254, 191);
			this.gpaInput.Name = "gpaInput";
			this.gpaInput.Size = new System.Drawing.Size(201, 20);
			this.gpaInput.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(180, 115);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "First name:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(180, 155);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Last name:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(180, 194);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "GPA:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(180, 238);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(68, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "Date of birth:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(291, 71);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(127, 25);
			this.label5.TabIndex = 2;
			this.label5.Text = "Add student";
			// 
			// dobInput
			// 
			this.dobInput.Location = new System.Drawing.Point(255, 233);
			this.dobInput.Name = "dobInput";
			this.dobInput.Size = new System.Drawing.Size(200, 20);
			this.dobInput.TabIndex = 3;
			// 
			// updateBtn
			// 
			this.updateBtn.Location = new System.Drawing.Point(380, 270);
			this.updateBtn.Name = "updateBtn";
			this.updateBtn.Size = new System.Drawing.Size(75, 23);
			this.updateBtn.TabIndex = 4;
			this.updateBtn.Text = "Update";
			this.updateBtn.UseVisualStyleBackColor = true;
			this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
			// 
			// AddStudentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(714, 471);
			this.Controls.Add(this.updateBtn);
			this.Controls.Add(this.dobInput);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.gpaInput);
			this.Controls.Add(this.lNameInput);
			this.Controls.Add(this.fNameInput);
			this.Controls.Add(this.addBtn);
			this.Name = "AddStudentForm";
			this.Text = "AddStudentForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button addBtn;
		private System.Windows.Forms.TextBox fNameInput;
		private System.Windows.Forms.TextBox lNameInput;
		private System.Windows.Forms.TextBox gpaInput;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dobInput;
		private System.Windows.Forms.Button updateBtn;
	}
}