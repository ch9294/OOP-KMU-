﻿using System;
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
            FormClosed += Form1_FormClosed; // 프로그램 종료 버튼을 누를시 발생할 이벤트 핸들러 연결
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("버튼을 지울까요?", "종료", MessageBoxButtons.YesNo))
                {
                foreach (var item in Controls)
                {
                    if (item is Button) // item이 Button 타입이라면?
                    {
                        Controls.Clear(); // 버튼 삭제
                    }
                }
            }
            MessageBox.Show(elapsedTime + "초 경과", "종료",MessageBoxButtons.YesNo);
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
            btnCntNew++;
            Button button = new Button(); // 버튼 객체 생성
            Controls.Add(button); // 버튼 객체를 디자이너에 등록
            button.Location = new Point(527, 61 + (25 * btnCntNew)); // 생성된 버튼 객체의 위치 지정
            button.Text = "동적생성" + btnCntNew + "번째"; // 버튼 텍스트 변경

            button.Click += Button_Click; // 버튼 이벤트 동적 연결
        }

        private void Button_Click(object sender, EventArgs e)
        {
            button3_Click(sender, new EventArgs()); // 버튼을 클릭 할 때마다 button3의 이벤트 핸들러 호출
        }

        private int elapsedTime = 0; // 타이머
        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedTime++; // 1초씩 증가함
        }
    }
}
