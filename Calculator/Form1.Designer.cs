namespace Calculator
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
			this.Num1 = new System.Windows.Forms.TextBox();
			this.Num2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.Option = new System.Windows.Forms.ComboBox();
			this.Calculate = new System.Windows.Forms.Button();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.calResult = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Num1
			// 
			this.Num1.Location = new System.Drawing.Point(283, 50);
			this.Num1.Multiline = true;
			this.Num1.Name = "Num1";
			this.Num1.Size = new System.Drawing.Size(345, 35);
			this.Num1.TabIndex = 0;
			this.Num1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// Num2
			// 
			this.Num2.Location = new System.Drawing.Point(283, 124);
			this.Num2.Multiline = true;
			this.Num2.Name = "Num2";
			this.Num2.Size = new System.Drawing.Size(345, 35);
			this.Num2.TabIndex = 1;
			this.Num2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("JetBrains Mono", 10F);
			this.label1.Location = new System.Drawing.Point(280, 24);
			this.label1.MaximumSize = new System.Drawing.Size(150, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 18);
			this.label1.TabIndex = 2;
			this.label1.Text = "Number1";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("JetBrains Mono", 10F);
			this.label2.Location = new System.Drawing.Point(280, 103);
			this.label2.MaximumSize = new System.Drawing.Size(150, 30);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 18);
			this.label2.TabIndex = 4;
			this.label2.Text = "Number2";
			this.label2.Click += new System.EventHandler(this.label3_Click);
			// 
			// Option
			// 
			this.Option.AccessibleName = "";
			this.Option.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Option.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Option.Font = new System.Drawing.Font("JetBrains Mono", 10F);
			this.Option.FormattingEnabled = true;
			this.Option.Items.AddRange(new object[] {
            "Addition",
            "Subtraction",
            "Multiplication",
            "Division"});
			this.Option.Location = new System.Drawing.Point(388, 246);
			this.Option.Name = "Option";
			this.Option.Size = new System.Drawing.Size(152, 25);
			this.Option.TabIndex = 5;
			this.Option.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// Calculate
			// 
			this.Calculate.Font = new System.Drawing.Font("JetBrains Mono", 10F);
			this.Calculate.Location = new System.Drawing.Point(408, 312);
			this.Calculate.Name = "Calculate";
			this.Calculate.Size = new System.Drawing.Size(120, 36);
			this.Calculate.TabIndex = 6;
			this.Calculate.Text = "Calculate";
			this.Calculate.UseVisualStyleBackColor = true;
			this.Calculate.Click += new System.EventHandler(this.button1_Click);
			// 
			// calResult
			// 
			this.calResult.Location = new System.Drawing.Point(283, 195);
			this.calResult.Multiline = true;
			this.calResult.Name = "calResult";
			this.calResult.ReadOnly = true;
			this.calResult.Size = new System.Drawing.Size(345, 35);
			this.calResult.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("JetBrains Mono", 10F);
			this.label3.Location = new System.Drawing.Point(280, 174);
			this.label3.MaximumSize = new System.Drawing.Size(150, 30);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 18);
			this.label3.TabIndex = 8;
			this.label3.Text = "Result";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.label3.Click += new System.EventHandler(this.label2_Click_1);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(864, 541);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.calResult);
			this.Controls.Add(this.Calculate);
			this.Controls.Add(this.Option);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Num2);
			this.Controls.Add(this.Num1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Form1";
			this.Text = "Calculator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox Num1;
		private System.Windows.Forms.TextBox Num2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox Option;
		private System.Windows.Forms.Button Calculate;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.TextBox calResult;
		private System.Windows.Forms.Label label3;
	}
}

