using Microsoft.VisualBasic;
using System.Diagnostics;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a; // первая переменная
        int b; // вторая переменная
        int otvet;
        int type; // для свитча 

        private void buttonOne_Click(object sender, EventArgs e)
        {
            textBoxOtvet.Text = textBoxOtvet.Text + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxOtvet.Text = textBoxOtvet.Text + 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxOtvet.Text = textBoxOtvet.Text + 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxOtvet.Text = textBoxOtvet.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxOtvet.Text = textBoxOtvet.Text + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxOtvet.Text = textBoxOtvet.Text + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxOtvet.Text = textBoxOtvet.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxOtvet.Text = textBoxOtvet.Text + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxOtvet.Text = textBoxOtvet.Text + 9;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBoxOtvet.Text = textBoxOtvet.Text + 0;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBoxOtvet.Text);
            textBoxOtvet.Clear();
            type = 1;
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBoxOtvet.Text);
            textBoxOtvet.Clear();
            type = 2;
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBoxOtvet.Text);
            textBoxOtvet.Clear();
            type = 3;
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBoxOtvet.Text);
            textBoxOtvet.Clear();
            type = 4;
        }

        private void buttonTotal_Click(object sender, EventArgs e)
        {
            b = Convert.ToInt32(textBoxOtvet.Text); // Вторая переменная
            textBoxOtvet.Clear();
            calculator(); // Выполняем операцию
        }

        private void textBoxOtvet_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            textBoxOtvet.Text = null;
        }
        public void calculator()
        {
            switch (type)
            {
                case 1:
                    otvet = a + b; break;
                case 2:
                    otvet = a - b; break;
                case 3:
                    otvet = a * b; break;
                case 4:
                    otvet = a / b; break;
                default: break;
            }
            textBoxOtvet.Text = otvet.ToString(); // Показываем результат
        }

    }
}
