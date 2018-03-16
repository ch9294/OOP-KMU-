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
            for(int i = 1; i <= 5; i++)
            {
                Button button = new Button(); // 버튼 객체 생성
                Controls.Add(button); // 버튼 객체를 디자이너에 등록
                button.Location = new Point(110,61+(25*i)); // 생성된 버튼 객체의 위치 지정
                button.Text = "동적생성" + i + "번째"; // 버튼 텍스트 변경

            }
        }

        private int btnCnt = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            btnCnt++;
            Button button = new Button(); // 버튼 객체 생성
            Controls.Add(button); // 버튼 객체를 디자이너에 등록
            button.Location = new Point(321, 61 + (25 * btnCnt)); // 생성된 버튼 객체의 위치 지정
            button.Text = "동적생성" + btnCnt + "번째"; // 버튼 텍스트 변경
        }

        private int btnCntNew = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            Button button = new Button(); // 버튼 객체 생성
            Controls.Add(button); // 버튼 객체를 디자이너에 등록
            button.Location = new Point(527, 61 + (25 * btnCntNew)); // 생성된 버튼 객체의 위치 지정
            button.Text = "동적생성" + btnCntNew + "번째"; // 버튼 텍스트 변경

            button.Click += Button_Click; // 버튼 이벤트 동적 연결
        }

        private void Button_Click(object sender, EventArgs e)
        {
            button3_Click(button3, new EventArgs());
        }
    }
}
