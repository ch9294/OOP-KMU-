using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traning4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void operate_Shift(object direction) // 시프트 연산 메소드
        {
            // 10진수 -> 2진수
            binary1.Text = Convert.ToString(int.Parse(number.Text), 2);

            // 10진수 -> 16진수
            hexa1.Text = Convert.ToString(int.Parse(number.Text), 16);

            // 10진수
            natural1.Text = number.Text;

            int result = 0; // 시프트 연산 결과
            if (direction.Equals(LeftShift))
            {
                result = int.Parse(Convert.ToString((int.Parse(number.Text)
                    << int.Parse(textBox2.Text)), 10));
            }
            else
            {
                result = int.Parse(Convert.ToString((int.Parse(number.Text)
                     >> int.Parse(textBox2.Text)), 10));
            }

            binary2.Text = Convert.ToString(result, 2);
            hexa2.Text = Convert.ToString(result, 16);
            natural2.Text = result.ToString();
        }
        private void LeftShift_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(number.Text+"를 "+textBox2.Text+"bit\nShiftLeft\n합니다.","Shift",
                MessageBoxButtons.OK) == DialogResult.OK)
            {
                operate_Shift(sender);
            }
        }

        private void RightShift_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(number.Text + "를 " + textBox2.Text + "bit\nShiftRight\n합니다.", "Shift", 
                MessageBoxButtons.OK) == DialogResult.OK)
            {
                operate_Shift(sender);
            }
        }

        private void number_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
