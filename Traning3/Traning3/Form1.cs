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
        static private Queue<string> number = new Queue<string>();
        static private Queue<double> makeNum = new Queue<double>(); // 완성된 숫자를 다시 저장
        static private Queue<string> operatorKey = new Queue<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void inputNumber(Button num)
        {
            number.Enqueue(num.Text);
            textBox1.Text = num.Text;
        }

        private void inputOperator(Button op)
        {
            if(number.Count == 0) // 피연산자 큐가 공백일 경우
            {
                MessageBox.Show("피연산자가 없습니다.");
                return;
            }

            else // 피연산자 큐가 공백이 아닐 경우
            {
                
                if(operatorKey.Count == 1) // 연산자가 하나 입력 되었을 경우
                {
                    if(number.Count > 1)
                    {
                        makeNumber();
                        makeNum.Enqueue(double.Parse(number.Peek())); // 완성된 숫자를 별개의 큐에 다시 저장
                        number.Dequeue(); // 삭제
                    }
                }
                else // 연산자가 두개 입력 되었을 경우
                {
                    if(makeNum.Count == 1)
                    {
                        MessageBox.Show("연산자를 연속으로 입력하였습니다.");
                        
                        
                    }
                    Calculate();
                    operatorKey.Dequeue();
                }

            }
        }
        private void makeNumber() // 숫자 만들기
        {
            // 실수 만들기
            string realNum = number.ToString();
            if(double.TryParse(realNum,out double result))
            {
                number.Enqueue(result.ToString());
            }
            else
            {
                number.Enqueue(int.Parse(realNum).ToString());
            }
            // 두자리수 이상 정수 만들기
        }
        private void Calculate()
        {
            double result = 0;
            switch (operatorKey.Peek())
            {
                case "+": result = makeNum.Dequeue() + makeNum.Dequeue(); break;
                case "-": result = makeNum.Dequeue()-makeNum.Dequeue(); break;
                    
                case "*": result = makeNum.Dequeue()*makeNum.Dequeue(); break;
                case "/": try {
                        result = makeNum.Dequeue() / makeNum.Dequeue();
                    }
                    catch (Exception e)
                    {
                        makeNum.Clear(); // 큐 내용 비우기
                        MessageBox.Show("0을 나눌 수 없습니다.");
                        return;
                    }
                    break;
            }
            makeNum.Enqueue(result);
        }

        private void button1_Click(object sender, EventArgs e) // 0
        {
              
        }

        private void button2_Click(object sender, EventArgs e) //1
        {
            
        }

        private void button3_Click(object sender, EventArgs e) //2
        {
            
        }

        private void button4_Click(object sender, EventArgs e) //3
        {
            
        }

        private void button5_Click(object sender, EventArgs e) //4
        {
            
        }

        private void button6_Click(object sender, EventArgs e) //5
        {
            
        }

        private void button7_Click(object sender, EventArgs e) //6
        {
            
        }

        private void button8_Click(object sender, EventArgs e) //7
        {
            
        }

        private void button9_Click(object sender, EventArgs e) //8
        {
            
        }

        private void button10_Click(object sender, EventArgs e) //9
        {
           
        }

        private void button11_Click(object sender, EventArgs e) // .
        {

        }

        private void button12_Click(object sender, EventArgs e) // +
        {

        }

        private void button13_Click(object sender, EventArgs e) // -
        {

        }

        private void button14_Click(object sender, EventArgs e) // *
        {

        }

        private void button15_Click(object sender, EventArgs e) // /
        {

        }

        private void button16_Click(object sender, EventArgs e) // =
        {

        }

        private void button17_Click(object sender, EventArgs e) // 1/x
        {

        }

        private void button18_Click(object sender, EventArgs e) // C
        {
            number.Clear();
            makeNum.Clear();
            operatorKey.Clear();
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
