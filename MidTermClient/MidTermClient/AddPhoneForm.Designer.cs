
namespace MidTermClient {
	partial class AddPhoneForm {
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
			this.nameInput = new System.Windows.Forms.TextBox();
			this.priceInput = new System.Windows.Forms.TextBox();
			this.ramInput = new System.Windows.Forms.TextBox();
			this.cpuInput = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.brandInput = new System.Windows.Forms.ComboBox();
			this.simTypeInput = new System.Windows.Forms.ComboBox();
			this.updateBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// addBtn
			// 
			this.addBtn.Location = new System.Drawing.Point(399, 292);
			this.addBtn.Name = "addBtn";
			this.addBtn.Size = new System.Drawing.Size(75, 23);
			this.addBtn.TabIndex = 0;
			this.addBtn.Text = "Add";
			this.addBtn.UseVisualStyleBackColor = true;
			this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
			// 
			// nameInput
			// 
			this.nameInput.Location = new System.Drawing.Point(304, 71);
			this.nameInput.Name = "nameInput";
			this.nameInput.Size = new System.Drawing.Size(170, 20);
			this.nameInput.TabIndex = 1;
			// 
			// priceInput
			// 
			this.priceInput.Location = new System.Drawing.Point(304, 144);
			this.priceInput.Name = "priceInput";
			this.priceInput.Size = new System.Drawing.Size(170, 20);
			this.priceInput.TabIndex = 1;
			// 
			// ramInput
			// 
			this.ramInput.Location = new System.Drawing.Point(304, 181);
			this.ramInput.Name = "ramInput";
			this.ramInput.Size = new System.Drawing.Size(170, 20);
			this.ramInput.TabIndex = 1;
			// 
			// cpuInput
			// 
			this.cpuInput.Location = new System.Drawing.Point(304, 220);
			this.cpuInput.Name = "cpuInput";
			this.cpuInput.Size = new System.Drawing.Size(170, 20);
			this.cpuInput.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(257, 73);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Name:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(257, 108);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Brand:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(259, 150);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Price:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(259, 187);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(34, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "RAM:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(235, 225);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(61, 13);
			this.label5.TabIndex = 2;
			this.label5.Text = "Cpu speed:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(222, 261);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(74, 13);
			this.label7.TabIndex = 2;
			this.label7.Text = "Sim card type:";
			// 
			// brandInput
			// 
			this.brandInput.FormattingEnabled = true;
			this.brandInput.Location = new System.Drawing.Point(304, 105);
			this.brandInput.Name = "brandInput";
			this.brandInput.Size = new System.Drawing.Size(170, 21);
			this.brandInput.TabIndex = 3;
			// 
			// simTypeInput
			// 
			this.simTypeInput.FormattingEnabled = true;
			this.simTypeInput.Location = new System.Drawing.Point(303, 256);
			this.simTypeInput.Name = "simTypeInput";
			this.simTypeInput.Size = new System.Drawing.Size(170, 21);
			this.simTypeInput.TabIndex = 3;
			// 
			// updateBtn
			// 
			this.updateBtn.Location = new System.Drawing.Point(399, 292);
			this.updateBtn.Name = "updateBtn";
			this.updateBtn.Size = new System.Drawing.Size(75, 23);
			this.updateBtn.TabIndex = 4;
			this.updateBtn.Text = "Update";
			this.updateBtn.UseVisualStyleBackColor = true;
			this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
			// 
			// AddPhoneForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.updateBtn);
			this.Controls.Add(this.simTypeInput);
			this.Controls.Add(this.brandInput);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cpuInput);
			this.Controls.Add(this.ramInput);
			this.Controls.Add(this.priceInput);
			this.Controls.Add(this.nameInput);
			this.Controls.Add(this.addBtn);
			this.Name = "AddPhoneForm";
			this.Text = "AddPhoneForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button addBtn;
		private System.Windows.Forms.TextBox nameInput;
		private System.Windows.Forms.TextBox priceInput;
		private System.Windows.Forms.TextBox ramInput;
		private System.Windows.Forms.TextBox cpuInput;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox brandInput;
		private System.Windows.Forms.ComboBox simTypeInput;
		private System.Windows.Forms.Button updateBtn;
	}
}