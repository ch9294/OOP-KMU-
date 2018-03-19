using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCSharpWin
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void HelloLabel_Click(object sender, EventArgs e)
        {
            int num1 = 1;
            int num2 = 2;
            int sum = num1 + num2;
            HelloLabel.Text = sum.ToString();
        }

        private void Sum2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SumNumbers_Click(object sender, EventArgs e)
        {
            SumResult.Text = Add(Convert.ToInt32(Sum1.Text),Convert.ToInt32(Sum2.Text)).ToString();
        }

        int Add(int num1,int num2)
        {
            int sum = num1 + num2;
            return sum;
        }
    }
}
