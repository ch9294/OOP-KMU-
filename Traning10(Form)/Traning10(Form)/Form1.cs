using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traning10_Form_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Button btnForm = new Button();
            btnForm.Text = "폼 생성";
            Controls.Add(btnForm);
            //btnForm.Click += BtnForm_Click;
            btnForm.Click += (s,e)=> {
                EventForm eventForm = new EventForm();
                eventForm.Show();
            };
        }

        //private void BtnForm_Click(object sender, EventArgs e)
        //{
        //    EventForm eventForm = new EventForm();
        //    eventForm.Show();
        //}

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    class EventForm : Form
    {
        public EventForm()
        {
            this.Click += (s, e) => { MessageBox.Show("Hello world"); };
        }

        //private void ClickReceive(object sender, EventArgs e)
        //{
        //    MessageBox.Show("hello world");
        //}
    }
}
