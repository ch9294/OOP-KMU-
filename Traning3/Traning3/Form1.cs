using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traning3
{
    public partial class Form1 : Form
    {
        static private Queue<string> number = new Queue<string>(); // 숫자 문자열 큐
        static private Queue<double> makeNum = new Queue<double>(); // 완성된 숫자 큐
        static private Queue<string> operatorKey = new Queue<string>(); // 연산자 큐
        bool clear = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void inputNumber(Button num)
        {
            number.Enqueue(num.Text);
            if (clear)
            {
                textBox1.Clear();
                textBox1.Text = num.Text;
                clear = false; // 변화 없음
            }
            else
            {
                textBox1.Text += num.Text;
            }

        }

        private void inputOperator(Button op)
        {
            if (makeNum.Count == 0 && number.Count == 0) // 피연산자 큐가 공백일 경우
            {
                MessageBox.Show("피연산자가 없습니다.");
                return;
            }

            else // 피연산자 큐가 공백이 아닐 경우
            {
                operatorKey.Enqueue(op.Text);
                
                textBox2.Text = operatorKey.Peek();

                if (operatorKey.Count == 1) // 연산자가 하나 입력 되었을 경우
                {
                    if (operatorKey.Peek().Equals("=")) // = 이 입력되었을 겨우
                    {
                        textBox1.Text = makeNum.Dequeue().ToString();
                        return; // 계산 완료
                    }
                    if (number.Count != 0)
                    {
                        makeNumber();
                        return;
                    }
                }
                else // 연산자가 두 개 입력 되었을 경우
                {
                    if(number.Count != 0) // 연산자가 두개째 입력되었을 때 number 큐에 조각이 있는경우
                    {
                        makeNumber();
                    }
                    
                    if (makeNum.Count == 1) // 
                    {
                        MessageBox.Show("연산자를 연속으로 입력하였습니다.");
                        operatorKey = new Queue<string>(operatorKey.Reverse());
                        operatorKey.Dequeue();
                        return;
                    }
                    else
                    {
                        Calculate(); // 계산
                        operatorKey.Clear(); // 사용한 연산자 삭제
                    }

                }
            }
        }

        private void makeNumber() // 숫자 만들기
        {
            // 실수 만들기
            string sum = null;
            int iteration = number.Count; // 큐가 지워지면 반복 횟수가 맞지 않을 수 있음

            for(int i = 0; i < iteration; i++)
            {
                sum += number.Dequeue();
            }
            makeNum.Enqueue(double.Parse(sum));
            clear = true; // 변화가 생김
        }

        private void Calculate() // 계산하기
        {
            double result = 0;
            switch (operatorKey.Peek())
            {
                case "+": result = makeNum.Dequeue() + makeNum.Dequeue(); break;
                case "-": result = makeNum.Dequeue() - makeNum.Dequeue(); break;
                    
                case "*": result = makeNum.Dequeue() * makeNum.Dequeue(); break;
                case "/": result = makeNum.Dequeue() / makeNum.Dequeue();break;
            }
            makeNum.Enqueue(result); // 완성된 숫자를 저장
            textBox1.Text = makeNum.Peek().ToString();
        }

        private void button1_Click(object sender, EventArgs e) // 0
        {
            inputNumber((Button)sender);
        }

        private void button2_Click(object sender, EventArgs e) //1
        {
            inputNumber((Button)sender);
        }

        private void button3_Click(object sender, EventArgs e) //2
        {
            inputNumber((Button)sender);
        }

        private void button4_Click(object sender, EventArgs e) //3
        {
            inputNumber((Button)sender);
        }

        private void button5_Click(object sender, EventArgs e) //4
        {
            inputNumber((Button)sender);
        }

        private void button6_Click(object sender, EventArgs e) //5
        {
            inputNumber((Button)sender);
        }

        private void button7_Click(object sender, EventArgs e) //6
        {
            inputNumber((Button)sender);
        }

        private void button8_Click(object sender, EventArgs e) //7
        {
            inputNumber((Button)sender);
        }

        private void button9_Click(object sender, EventArgs e) //8
        {
            inputNumber((Button)sender);
        }

        private void button10_Click(object sender, EventArgs e) //9
        {
            inputNumber((Button)sender);
        }

        private void button11_Click(object sender, EventArgs e) // .
        {
            inputNumber((Button)sender);
        }

        private void button12_Click(object sender, EventArgs e) // +
        {
            inputOperator((Button)sender);
        }

        private void button13_Click(object sender, EventArgs e) // -
        {
            inputOperator((Button)sender);
        }

        private void button14_Click(object sender, EventArgs e) // *
        {
            inputOperator((Button)sender);
        }

        private void button15_Click(object sender, EventArgs e) // /
        {
            inputOperator((Button)sender);
        }

        private void button16_Click(object sender, EventArgs e) // =
        {
            inputOperator((Button)sender);
        }

        private void button17_Click(object sender, EventArgs e) // 1/x
        {

        }

        private void button18_Click(object sender, EventArgs e) // C
        {
            number.Clear();
            makeNum.Clear();
            operatorKey.Clear();
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button19_Click(object sender, EventArgs e) //CE
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
