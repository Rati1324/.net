﻿
namespace WindowsFormsClientApp
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.butRequest = new System.Windows.Forms.Button();
			this.txtBoxID = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.addBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(8, 64);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 62;
			this.dataGridView1.RowTemplate.Height = 28;
			this.dataGridView1.Size = new System.Drawing.Size(681, 213);
			this.dataGridView1.TabIndex = 0;
			// 
			// butRequest
			// 
			this.butRequest.Location = new System.Drawing.Point(481, 21);
			this.butRequest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.butRequest.Name = "butRequest";
			this.butRequest.Size = new System.Drawing.Size(98, 27);
			this.butRequest.TabIndex = 1;
			this.butRequest.Text = "Make Request";
			this.butRequest.UseVisualStyleBackColor = true;
			this.butRequest.Click += new System.EventHandler(this.butRequest_Click);
			// 
			// txtBoxID
			// 
			this.txtBoxID.Location = new System.Drawing.Point(87, 27);
			this.txtBoxID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtBoxID.Name = "txtBoxID";
			this.txtBoxID.Size = new System.Drawing.Size(341, 20);
			this.txtBoxID.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 27);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Find by Id:";
			// 
			// addBtn
			// 
			this.addBtn.Location = new System.Drawing.Point(593, 21);
			this.addBtn.Name = "addBtn";
			this.addBtn.Size = new System.Drawing.Size(96, 27);
			this.addBtn.TabIndex = 4;
			this.addBtn.Text = "Add";
			this.addBtn.UseVisualStyleBackColor = true;
			this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(868, 381);
			this.Controls.Add(this.addBtn);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtBoxID);
			this.Controls.Add(this.butRequest);
			this.Controls.Add(this.dataGridView1);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button butRequest;
        private System.Windows.Forms.TextBox txtBoxID;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button addBtn;
	}
}

