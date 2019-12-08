namespace Calculator
{
	partial class Form1
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_multiplication = new System.Windows.Forms.Button();
            this.button_division = new System.Windows.Forms.Button();
            this.button_Lbracket = new System.Windows.Forms.Button();
            this.button_Rbracket = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button_result = new System.Windows.Forms.Button();
            this.C_Name = new System.Windows.Forms.Label();
            this.textBox_equation = new System.Windows.Forms.TextBox();
            this.button_backspace = new System.Windows.Forms.Button();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.button_ce = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_c = new System.Windows.Forms.Button();
            this.button_negate = new System.Windows.Forms.Button();
            this.label_bracket_count = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(202, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(287, 265);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 30);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(105, 216);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(65, 30);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(202, 216);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(65, 30);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(287, 216);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(65, 30);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(105, 173);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(65, 30);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(202, 173);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(65, 30);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(287, 173);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(65, 30);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button_plus
            // 
            this.button_plus.Location = new System.Drawing.Point(374, 265);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(65, 30);
            this.button_plus.TabIndex = 9;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = true;
            this.button_plus.Click += new System.EventHandler(this.button_plus_Click);
            // 
            // button_minus
            // 
            this.button_minus.Location = new System.Drawing.Point(374, 216);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(65, 30);
            this.button_minus.TabIndex = 10;
            this.button_minus.Text = "-";
            this.button_minus.UseVisualStyleBackColor = true;
            this.button_minus.Click += new System.EventHandler(this.button_minus_Click);
            // 
            // button_multiplication
            // 
            this.button_multiplication.Location = new System.Drawing.Point(374, 173);
            this.button_multiplication.Name = "button_multiplication";
            this.button_multiplication.Size = new System.Drawing.Size(65, 30);
            this.button_multiplication.TabIndex = 11;
            this.button_multiplication.Text = "*";
            this.button_multiplication.UseVisualStyleBackColor = true;
            this.button_multiplication.Click += new System.EventHandler(this.button_multiplication_Click);
            // 
            // button_division
            // 
            this.button_division.Location = new System.Drawing.Point(374, 125);
            this.button_division.Name = "button_division";
            this.button_division.Size = new System.Drawing.Size(65, 30);
            this.button_division.TabIndex = 12;
            this.button_division.Text = "/";
            this.button_division.UseVisualStyleBackColor = true;
            this.button_division.Click += new System.EventHandler(this.button_division_Click);
            // 
            // button_Lbracket
            // 
            this.button_Lbracket.Location = new System.Drawing.Point(21, 307);
            this.button_Lbracket.Name = "button_Lbracket";
            this.button_Lbracket.Size = new System.Drawing.Size(65, 30);
            this.button_Lbracket.TabIndex = 13;
            this.button_Lbracket.Text = "(";
            this.button_Lbracket.UseVisualStyleBackColor = true;
            this.button_Lbracket.Click += new System.EventHandler(this.button_Lbracket_Click);
            // 
            // button_Rbracket
            // 
            this.button_Rbracket.Location = new System.Drawing.Point(105, 307);
            this.button_Rbracket.Name = "button_Rbracket";
            this.button_Rbracket.Size = new System.Drawing.Size(65, 30);
            this.button_Rbracket.TabIndex = 14;
            this.button_Rbracket.Text = ")";
            this.button_Rbracket.UseVisualStyleBackColor = true;
            this.button_Rbracket.Click += new System.EventHandler(this.button_Rbracket_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(202, 307);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(65, 30);
            this.button0.TabIndex = 15;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // button_result
            // 
            this.button_result.Location = new System.Drawing.Point(374, 307);
            this.button_result.Name = "button_result";
            this.button_result.Size = new System.Drawing.Size(65, 30);
            this.button_result.TabIndex = 16;
            this.button_result.Text = "=";
            this.button_result.UseVisualStyleBackColor = true;
            this.button_result.Click += new System.EventHandler(this.button_result_Click);
            // 
            // C_Name
            // 
            this.C_Name.AutoSize = true;
            this.C_Name.Location = new System.Drawing.Point(225, 9);
            this.C_Name.Name = "C_Name";
            this.C_Name.Size = new System.Drawing.Size(41, 12);
            this.C_Name.TabIndex = 17;
            this.C_Name.Text = "계산기";
            // 
            // textBox_equation
            // 
            this.textBox_equation.Font = new System.Drawing.Font("굴림", 12F);
            this.textBox_equation.Location = new System.Drawing.Point(105, 53);
            this.textBox_equation.Name = "textBox_equation";
            this.textBox_equation.ReadOnly = true;
            this.textBox_equation.Size = new System.Drawing.Size(333, 26);
            this.textBox_equation.TabIndex = 18;
            this.textBox_equation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_equation.TextChanged += new System.EventHandler(this.textBox_equation_TextChanged);
            // 
            // button_backspace
            // 
            this.button_backspace.Location = new System.Drawing.Point(287, 125);
            this.button_backspace.Name = "button_backspace";
            this.button_backspace.Size = new System.Drawing.Size(65, 30);
            this.button_backspace.TabIndex = 19;
            this.button_backspace.Text = "Back";
            this.button_backspace.UseVisualStyleBackColor = true;
            this.button_backspace.Click += new System.EventHandler(this.button_backspace_Click);
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(105, 80);
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(333, 21);
            this.textBox_result.TabIndex = 20;
            this.textBox_result.Text = "0";
            this.textBox_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_result.TextChanged += new System.EventHandler(this.textBox_result_TextChanged);
            // 
            // button_ce
            // 
            this.button_ce.Location = new System.Drawing.Point(105, 125);
            this.button_ce.Name = "button_ce";
            this.button_ce.Size = new System.Drawing.Size(65, 30);
            this.button_ce.TabIndex = 21;
            this.button_ce.Text = "CE";
            this.button_ce.UseVisualStyleBackColor = true;
            this.button_ce.Click += new System.EventHandler(this.button_CE_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 23;
            this.label1.Text = "계산식";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 24;
            this.label2.Text = "입력/결과";
            // 
            // button_c
            // 
            this.button_c.Location = new System.Drawing.Point(202, 125);
            this.button_c.Name = "button_c";
            this.button_c.Size = new System.Drawing.Size(65, 30);
            this.button_c.TabIndex = 25;
            this.button_c.Text = "C";
            this.button_c.UseVisualStyleBackColor = true;
            this.button_c.Click += new System.EventHandler(this.button_C_Click);
            // 
            // button_negate
            // 
            this.button_negate.Location = new System.Drawing.Point(21, 263);
            this.button_negate.Name = "button_negate";
            this.button_negate.Size = new System.Drawing.Size(65, 30);
            this.button_negate.TabIndex = 26;
            this.button_negate.Text = "+/-";
            this.button_negate.UseVisualStyleBackColor = true;
            this.button_negate.Click += new System.EventHandler(this.button_negate_Click);
            // 
            // label_bracket_count
            // 
            this.label_bracket_count.AutoSize = true;
            this.label_bracket_count.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label_bracket_count.Location = new System.Drawing.Point(27, 313);
            this.label_bracket_count.Name = "label_bracket_count";
            this.label_bracket_count.Size = new System.Drawing.Size(0, 12);
            this.label_bracket_count.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 378);
            this.Controls.Add(this.label_bracket_count);
            this.Controls.Add(this.button_negate);
            this.Controls.Add(this.button_c);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_ce);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.button_backspace);
            this.Controls.Add(this.textBox_equation);
            this.Controls.Add(this.C_Name);
            this.Controls.Add(this.button_result);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button_Rbracket);
            this.Controls.Add(this.button_Lbracket);
            this.Controls.Add(this.button_division);
            this.Controls.Add(this.button_multiplication);
            this.Controls.Add(this.button_minus);
            this.Controls.Add(this.button_plus);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "계산기";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button_plus;
		private System.Windows.Forms.Button button_minus;
		private System.Windows.Forms.Button button_multiplication;
		private System.Windows.Forms.Button button_division;
		private System.Windows.Forms.Button button_Lbracket;
		private System.Windows.Forms.Button button_Rbracket;
		private System.Windows.Forms.Button button0;
		private System.Windows.Forms.Button button_result;
		private System.Windows.Forms.Label C_Name;
		private System.Windows.Forms.TextBox textBox_equation;
		private System.Windows.Forms.Button button_backspace;
		private System.Windows.Forms.TextBox textBox_result;
		private System.Windows.Forms.Button button_ce;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button_c;
        private System.Windows.Forms.Button button_negate;
        private System.Windows.Forms.Label label_bracket_count;
    }
}

