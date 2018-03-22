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
    public partial class Form2 : Form
    {
        class CustomForm : Form
        {
            public CustomForm()
            {
                ClientSize = new System.Drawing.Size(800,450);
                Button ThirdBtn = new Button();
                ThirdBtn.Text = "세번째 버튼";
                ThirdBtn.Location = new Point(350, 250);
                Controls.Add(ThirdBtn);
                ThirdBtn.Click += ThirdBtn_Click;
            }

            private void ThirdBtn_Click(object sender, EventArgs e)
            {
                MessageBox.Show("마지막 폼입니다.","다중 폼 테스트",MessageBoxButtons.OK);
            }
        }

        public Form2()
        {
            InitializeComponent();
            Button SecondBtn = new Button();
            SecondBtn.Text = "두번째 버튼";
            SecondBtn.Location = new Point(350, 250);
            Controls.Add(SecondBtn);
            SecondBtn.Click += SecondBtn_Click;
        }

        private void SecondBtn_Click(object sender, EventArgs e)
        {
            CustomForm custom = new CustomForm();
            Form1.forms.Push(custom);
            custom.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
