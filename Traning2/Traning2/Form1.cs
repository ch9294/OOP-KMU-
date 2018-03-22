using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traning2
{
    public partial class Form1 : Form
    {
        /*
         * 폼을 스택에 저장함
         */

        static public Stack<Form> S_form = new Stack<Form>();

        public Form1()
        {
            InitializeComponent();
            Button FirstBtn = new Button();
            Controls.Add(FirstBtn);
            S_form.Push(this); // Form1이 생성될때 스택에 넣기

            FirstBtn.Text = "첫번째 버튼";
            FirstBtn.Location = new Point(350, 250);
            FirstBtn.Click += FirstBtn_Click; // 첫번째 버튼의 이벤트 핸들러 연결
        }

        private void FirstBtn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); // Form2 생성
            S_form.Push(form2); // 스택에 넣기
            form2.Show(); // 폼 열기
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }


        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            S_form.Push(form2);
            form2.Show();
        }

        private void 제거ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(S_form.Count != 0) // 공백 스택이 아닐 때 조건문 실행
            {
                //S_form.Peek().Close();
                S_form.Pop().Dispose();
                
            }
        }
    }
}
