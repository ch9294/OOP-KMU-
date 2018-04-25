using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            Controls.Add(btn);
            btn.Location = new Point(51, 43 +);
        }

        public int time = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
        }
    }
}
