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
            int num1 = 0;
            int num2 = 0;

            if(string.IsNullOrWhiteSpace(Sum1.Text))
            {
                MessageBox.Show("숫자를 입력해주세요");
                Sum1.Focus();
                return;
            }

          
           if (int.TryParse(Sum1.Text,out num1) == false)
            {
                MessageBox.Show("문자가 들어왔습니다.");
                Sum1.SelectAll();
                
                return;
            }

            if (string.IsNullOrWhiteSpace(Sum2.Text))
            {
                MessageBox.Show("숫자를 입력해주세요");
                return;
            }

            if(int.TryParse(Sum2.Text,out num2))
            {
                MessageBox.Show("문자가 들어왔습니다.");
                return;
            }
            num1 = Convert.ToInt32(Sum1.Text);
            num2 = Convert.ToInt32(Sum2.Text);
            SumResult.Text = Add(num1,num2).ToString();
        }
        
        // 메소드 오버로딩에 영향을 미치는 것은 매개변수의 갯수와 타입이다.
        // 반환 형식은 오버로딩의 조건에 부합하지 않는다.
        int Add(int num1,int num2)
        {
            
            int sum = num1 + num2;
            return sum;
        }

        public float Add(float num1, float num2)
        {
            float sum = num1 + num2;
            return sum;
        }

        public int Sub(int num1,int num2)
        {
            int sub = num1 - num2;
            return sub;
        }
    }
}
