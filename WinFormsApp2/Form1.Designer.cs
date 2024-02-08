namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            textBoxOtvet = new TextBox();
            buttonPlus = new Button();
            buttonMinus = new Button();
            buttonMultiply = new Button();
            buttonDivide = new Button();
            buttonTotal = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold);
            button1.Location = new Point(29, 128);
            button1.Name = "button1";
            button1.Size = new Size(50, 50);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonOne_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold);
            button2.Location = new Point(94, 128);
            button2.Name = "button2";
            button2.Size = new Size(50, 50);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold);
            button3.Location = new Point(29, 198);
            button3.Name = "button3";
            button3.Size = new Size(50, 48);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold);
            button4.Location = new Point(94, 198);
            button4.Name = "button4";
            button4.Size = new Size(50, 48);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold);
            button5.Location = new Point(29, 264);
            button5.Name = "button5";
            button5.Size = new Size(50, 48);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold);
            button6.Location = new Point(94, 264);
            button6.Name = "button6";
            button6.Size = new Size(50, 48);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold);
            button7.Location = new Point(29, 330);
            button7.Name = "button7";
            button7.Size = new Size(51, 48);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold);
            button8.Location = new Point(94, 330);
            button8.Name = "button8";
            button8.Size = new Size(50, 48);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold);
            button9.Location = new Point(29, 390);
            button9.Name = "button9";
            button9.Size = new Size(50, 48);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button0
            // 
            button0.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold);
            button0.Location = new Point(94, 390);
            button0.Name = "button0";
            button0.Size = new Size(50, 49);
            button0.TabIndex = 9;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // textBoxOtvet
            // 
            textBoxOtvet.Font = new Font("Segoe UI", 30F);
            textBoxOtvet.Location = new Point(29, 36);
            textBoxOtvet.Name = "textBoxOtvet";
            textBoxOtvet.Size = new Size(733, 74);
            textBoxOtvet.TabIndex = 10;
            textBoxOtvet.TextChanged += textBoxOtvet_TextChanged;
            // 
            // buttonPlus
            // 
            buttonPlus.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold);
            buttonPlus.Location = new Point(284, 144);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(125, 100);
            buttonPlus.TabIndex = 11;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = true;
            buttonPlus.Click += buttonPlus_Click;
            // 
            // buttonMinus
            // 
            buttonMinus.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold);
            buttonMinus.Location = new Point(385, 144);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(125, 100);
            buttonMinus.TabIndex = 12;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = true;
            buttonMinus.Click += buttonMinus_Click;
            // 
            // buttonMultiply
            // 
            buttonMultiply.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold);
            buttonMultiply.Location = new Point(283, 236);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(126, 100);
            buttonMultiply.TabIndex = 13;
            buttonMultiply.Text = "*";
            buttonMultiply.UseVisualStyleBackColor = true;
            buttonMultiply.Click += buttonMultiply_Click;
            // 
            // buttonDivide
            // 
            buttonDivide.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold);
            buttonDivide.Location = new Point(385, 236);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(125, 100);
            buttonDivide.TabIndex = 14;
            buttonDivide.Text = "/";
            buttonDivide.UseVisualStyleBackColor = true;
            buttonDivide.Click += buttonDivide_Click;
            // 
            // buttonTotal
            // 
            buttonTotal.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold);
            buttonTotal.Location = new Point(283, 331);
            buttonTotal.Name = "buttonTotal";
            buttonTotal.Size = new Size(227, 82);
            buttonTotal.TabIndex = 15;
            buttonTotal.Text = "=";
            buttonTotal.UseVisualStyleBackColor = true;
            buttonTotal.Click += buttonTotal_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 45F);
            label1.Location = new Point(537, 224);
            label1.Name = "label1";
            label1.Size = new Size(63, 100);
            label1.TabIndex = 16;
            label1.Text = " ";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(buttonTotal);
            Controls.Add(buttonDivide);
            Controls.Add(buttonMultiply);
            Controls.Add(buttonMinus);
            Controls.Add(buttonPlus);
            Controls.Add(textBoxOtvet);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private TextBox textBoxOtvet;
        private Button buttonPlus;
        private Button buttonMinus;
        private Button buttonMultiply;
        private Button buttonDivide;
        private Button buttonTotal;
        private Label label1;
    }
}
