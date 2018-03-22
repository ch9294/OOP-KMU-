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
        static public Stack<Form> forms = new Stack<Form>();

        public Form1()
        {
            InitializeComponent();
            Button FirstBtn = new Button();
            Controls.Add(FirstBtn);
            forms.Push(this);

            FirstBtn.Text = "첫번째 버튼";
            FirstBtn.Location = new Point(350, 250);
            
            FirstBtn.Click += FirstBtn_Click;
        }

        private void FirstBtn_Click(object sender, EventArgs e)
        {
            
            Form2 form2 = new Form2();
            forms.Push(form2);
            form2.Show();
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
            forms.Push(form2);
            form2.Show();
        }

        private void 제거ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(forms.Count != 0)
            {
                Form pre_form = forms.Peek();
                forms.Pop().Close();
                pre_form.Dispose();
                
            }
        }
    }
}
