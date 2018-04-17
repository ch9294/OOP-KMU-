namespace AutoSellingMachine
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.money = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pocari_num = new System.Windows.Forms.TextBox();
            this.soda_num = new System.Windows.Forms.TextBox();
            this.coke_num = new System.Windows.Forms.TextBox();
            this.Select_Pocari = new System.Windows.Forms.Button();
            this.Select_Soda = new System.Windows.Forms.Button();
            this.Select_Coke = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Pay = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.change = new System.Windows.Forms.TextBox();
            this.Complite = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.StartOrStop = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // money
            // 
            this.money.Location = new System.Drawing.Point(43, 40);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(155, 25);
            this.money.TabIndex = 0;
            this.money.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.pocari_num);
            this.groupBox1.Controls.Add(this.soda_num);
            this.groupBox1.Controls.Add(this.coke_num);
            this.groupBox1.Controls.Add(this.Select_Pocari);
            this.groupBox1.Controls.Add(this.Select_Soda);
            this.groupBox1.Controls.Add(this.Select_Coke);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(12, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 281);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "음료";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(578, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "1000원";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(330, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "700원";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(84, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "700원";
            // 
            // pocari_num
            // 
            this.pocari_num.Location = new System.Drawing.Point(549, 140);
            this.pocari_num.Name = "pocari_num";
            this.pocari_num.Size = new System.Drawing.Size(100, 25);
            this.pocari_num.TabIndex = 9;
            this.pocari_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pocari_num.TextChanged += new System.EventHandler(this.pocari_num_TextChanged);
            // 
            // soda_num
            // 
            this.soda_num.Location = new System.Drawing.Point(305, 140);
            this.soda_num.Name = "soda_num";
            this.soda_num.Size = new System.Drawing.Size(100, 25);
            this.soda_num.TabIndex = 8;
            this.soda_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.soda_num.TextChanged += new System.EventHandler(this.soda_num_TextChanged);
            // 
            // coke_num
            // 
            this.coke_num.Location = new System.Drawing.Point(60, 140);
            this.coke_num.Name = "coke_num";
            this.coke_num.Size = new System.Drawing.Size(100, 25);
            this.coke_num.TabIndex = 7;
            this.coke_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.coke_num.TextChanged += new System.EventHandler(this.coke_num_TextChanged);
            // 
            // Select_Pocari
            // 
            this.Select_Pocari.Location = new System.Drawing.Point(557, 206);
            this.Select_Pocari.Name = "Select_Pocari";
            this.Select_Pocari.Size = new System.Drawing.Size(75, 23);
            this.Select_Pocari.TabIndex = 6;
            this.Select_Pocari.Text = "선택";
            this.Select_Pocari.UseVisualStyleBackColor = true;
            this.Select_Pocari.Click += new System.EventHandler(this.Select_Pocari_Click);
            // 
            // Select_Soda
            // 
            this.Select_Soda.Location = new System.Drawing.Point(314, 206);
            this.Select_Soda.Name = "Select_Soda";
            this.Select_Soda.Size = new System.Drawing.Size(75, 23);
            this.Select_Soda.TabIndex = 5;
            this.Select_Soda.Text = "선택";
            this.Select_Soda.UseVisualStyleBackColor = true;
            this.Select_Soda.Click += new System.EventHandler(this.Select_Soda_Click);
            // 
            // Select_Coke
            // 
            this.Select_Coke.Location = new System.Drawing.Point(69, 206);
            this.Select_Coke.Name = "Select_Coke";
            this.Select_Coke.Size = new System.Drawing.Size(75, 23);
            this.Select_Coke.TabIndex = 4;
            this.Select_Coke.Text = "선택";
            this.Select_Coke.UseVisualStyleBackColor = true;
            this.Select_Coke.Click += new System.EventHandler(this.Select_Coke_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(493, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "사이다";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(552, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "포카리스웨트";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "콜라";
            // 
            // Pay
            // 
            this.Pay.Location = new System.Drawing.Point(204, 41);
            this.Pay.Name = "Pay";
            this.Pay.Size = new System.Drawing.Size(87, 23);
            this.Pay.TabIndex = 2;
            this.Pay.Text = "삽입";
            this.Pay.UseVisualStyleBackColor = true;
            this.Pay.Click += new System.EventHandler(this.Pay_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "돈 넣는곳";
            // 
            // change
            // 
            this.change.Location = new System.Drawing.Point(393, 39);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(155, 25);
            this.change.TabIndex = 10;
            this.change.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.change.TextChanged += new System.EventHandler(this.change_TextChanged);
            // 
            // Complite
            // 
            this.Complite.Location = new System.Drawing.Point(554, 40);
            this.Complite.Name = "Complite";
            this.Complite.Size = new System.Drawing.Size(90, 24);
            this.Complite.TabIndex = 11;
            this.Complite.Text = "계산 완료";
            this.Complite.UseVisualStyleBackColor = true;
            this.Complite.Click += new System.EventHandler(this.Complite_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(390, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "거스름돈";
            // 
            // StartOrStop
            // 
            this.StartOrStop.Location = new System.Drawing.Point(301, 126);
            this.StartOrStop.Name = "StartOrStop";
            this.StartOrStop.Size = new System.Drawing.Size(177, 25);
            this.StartOrStop.TabIndex = 13;
            this.StartOrStop.Text = "Stop";
            this.StartOrStop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StartOrStop);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Complite);
            this.Controls.Add(this.change);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Pay);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.money);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox money;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox pocari_num;
        private System.Windows.Forms.TextBox soda_num;
        private System.Windows.Forms.TextBox coke_num;
        private System.Windows.Forms.Button Select_Pocari;
        private System.Windows.Forms.Button Select_Soda;
        private System.Windows.Forms.Button Select_Coke;
        private System.Windows.Forms.Button Pay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox change;
        private System.Windows.Forms.Button Complite;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox StartOrStop;
    }
}

