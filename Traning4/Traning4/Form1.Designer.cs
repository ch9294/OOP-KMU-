namespace Traning4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.naturalNum = new System.Windows.Forms.Label();
            this.hexaNum = new System.Windows.Forms.Label();
            this.binaryNum = new System.Windows.Forms.Label();
            this.natural1 = new System.Windows.Forms.TextBox();
            this.hexa1 = new System.Windows.Forms.TextBox();
            this.binary1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.naturalResult = new System.Windows.Forms.Label();
            this.hexaResult = new System.Windows.Forms.Label();
            this.binaryResult = new System.Windows.Forms.Label();
            this.natural2 = new System.Windows.Forms.TextBox();
            this.binary2 = new System.Windows.Forms.TextBox();
            this.hexa2 = new System.Windows.Forms.TextBox();
            this.number = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.naturalNumber = new System.Windows.Forms.Label();
            this.ChangeBit = new System.Windows.Forms.Label();
            this.LeftShift = new System.Windows.Forms.Button();
            this.RightShift = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.naturalNum);
            this.groupBox1.Controls.Add(this.hexaNum);
            this.groupBox1.Controls.Add(this.binaryNum);
            this.groupBox1.Controls.Add(this.natural1);
            this.groupBox1.Controls.Add(this.hexa1);
            this.groupBox1.Controls.Add(this.binary1);
            this.groupBox1.Location = new System.Drawing.Point(290, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 225);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "원래 수";
            // 
            // naturalNum
            // 
            this.naturalNum.AutoSize = true;
            this.naturalNum.Location = new System.Drawing.Point(65, 184);
            this.naturalNum.Name = "naturalNum";
            this.naturalNum.Size = new System.Drawing.Size(41, 12);
            this.naturalNum.TabIndex = 10;
            this.naturalNum.Text = "10진수";
            // 
            // hexaNum
            // 
            this.hexaNum.AutoSize = true;
            this.hexaNum.Location = new System.Drawing.Point(65, 113);
            this.hexaNum.Name = "hexaNum";
            this.hexaNum.Size = new System.Drawing.Size(41, 12);
            this.hexaNum.TabIndex = 9;
            this.hexaNum.Text = "16진수";
            // 
            // binaryNum
            // 
            this.binaryNum.AutoSize = true;
            this.binaryNum.Location = new System.Drawing.Point(71, 45);
            this.binaryNum.Name = "binaryNum";
            this.binaryNum.Size = new System.Drawing.Size(35, 12);
            this.binaryNum.TabIndex = 8;
            this.binaryNum.Text = "2진수";
            // 
            // natural1
            // 
            this.natural1.Location = new System.Drawing.Point(109, 181);
            this.natural1.Name = "natural1";
            this.natural1.Size = new System.Drawing.Size(100, 21);
            this.natural1.TabIndex = 2;
            this.natural1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // hexa1
            // 
            this.hexa1.Location = new System.Drawing.Point(109, 110);
            this.hexa1.MaxLength = 16;
            this.hexa1.Name = "hexa1";
            this.hexa1.Size = new System.Drawing.Size(100, 21);
            this.hexa1.TabIndex = 1;
            this.hexa1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // binary1
            // 
            this.binary1.Location = new System.Drawing.Point(109, 42);
            this.binary1.MaxLength = 16;
            this.binary1.Name = "binary1";
            this.binary1.Size = new System.Drawing.Size(100, 21);
            this.binary1.TabIndex = 0;
            this.binary1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.naturalResult);
            this.groupBox2.Controls.Add(this.hexaResult);
            this.groupBox2.Controls.Add(this.binaryResult);
            this.groupBox2.Controls.Add(this.natural2);
            this.groupBox2.Controls.Add(this.binary2);
            this.groupBox2.Controls.Add(this.hexa2);
            this.groupBox2.Location = new System.Drawing.Point(553, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 225);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "결과";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // naturalResult
            // 
            this.naturalResult.AutoSize = true;
            this.naturalResult.Location = new System.Drawing.Point(65, 184);
            this.naturalResult.Name = "naturalResult";
            this.naturalResult.Size = new System.Drawing.Size(41, 12);
            this.naturalResult.TabIndex = 13;
            this.naturalResult.Text = "10진수";
            // 
            // hexaResult
            // 
            this.hexaResult.AutoSize = true;
            this.hexaResult.Location = new System.Drawing.Point(65, 113);
            this.hexaResult.Name = "hexaResult";
            this.hexaResult.Size = new System.Drawing.Size(41, 12);
            this.hexaResult.TabIndex = 12;
            this.hexaResult.Text = "16진수";
            // 
            // binaryResult
            // 
            this.binaryResult.AutoSize = true;
            this.binaryResult.Location = new System.Drawing.Point(65, 45);
            this.binaryResult.Name = "binaryResult";
            this.binaryResult.Size = new System.Drawing.Size(35, 12);
            this.binaryResult.TabIndex = 11;
            this.binaryResult.Text = "2진수";
            // 
            // natural2
            // 
            this.natural2.Location = new System.Drawing.Point(109, 181);
            this.natural2.Name = "natural2";
            this.natural2.Size = new System.Drawing.Size(100, 21);
            this.natural2.TabIndex = 5;
            this.natural2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // binary2
            // 
            this.binary2.Location = new System.Drawing.Point(109, 42);
            this.binary2.MaxLength = 16;
            this.binary2.Name = "binary2";
            this.binary2.Size = new System.Drawing.Size(100, 21);
            this.binary2.TabIndex = 3;
            this.binary2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // hexa2
            // 
            this.hexa2.Location = new System.Drawing.Point(109, 110);
            this.hexa2.MaxLength = 16;
            this.hexa2.Name = "hexa2";
            this.hexa2.Size = new System.Drawing.Size(100, 21);
            this.hexa2.TabIndex = 4;
            this.hexa2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(271, 36);
            this.number.MaxLength = 16;
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(157, 21);
            this.number.TabIndex = 2;
            this.number.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.number.TextChanged += new System.EventHandler(this.number_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(511, 36);
            this.textBox2.MaxLength = 16;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(157, 21);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // naturalNumber
            // 
            this.naturalNumber.AutoSize = true;
            this.naturalNumber.Location = new System.Drawing.Point(220, 39);
            this.naturalNumber.Name = "naturalNumber";
            this.naturalNumber.Size = new System.Drawing.Size(45, 12);
            this.naturalNumber.TabIndex = 4;
            this.naturalNumber.Text = "원래 수";
            // 
            // ChangeBit
            // 
            this.ChangeBit.AutoSize = true;
            this.ChangeBit.Location = new System.Drawing.Point(460, 39);
            this.ChangeBit.Name = "ChangeBit";
            this.ChangeBit.Size = new System.Drawing.Size(45, 12);
            this.ChangeBit.TabIndex = 5;
            this.ChangeBit.Text = "몇 비트";
            this.ChangeBit.Click += new System.EventHandler(this.label2_Click);
            // 
            // LeftShift
            // 
            this.LeftShift.Location = new System.Drawing.Point(693, 36);
            this.LeftShift.Name = "LeftShift";
            this.LeftShift.Size = new System.Drawing.Size(75, 40);
            this.LeftShift.TabIndex = 6;
            this.LeftShift.Text = "<<";
            this.LeftShift.UseVisualStyleBackColor = true;
            this.LeftShift.Click += new System.EventHandler(this.LeftShift_Click);
            // 
            // RightShift
            // 
            this.RightShift.Location = new System.Drawing.Point(693, 82);
            this.RightShift.Name = "RightShift";
            this.RightShift.Size = new System.Drawing.Size(75, 40);
            this.RightShift.TabIndex = 7;
            this.RightShift.Text = ">>";
            this.RightShift.UseVisualStyleBackColor = true;
            this.RightShift.Click += new System.EventHandler(this.RightShift_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RightShift);
            this.Controls.Add(this.LeftShift);
            this.Controls.Add(this.ChangeBit);
            this.Controls.Add(this.naturalNumber);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.number);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label naturalNumber;
        private System.Windows.Forms.Label ChangeBit;
        private System.Windows.Forms.Label naturalNum;
        private System.Windows.Forms.Label hexaNum;
        private System.Windows.Forms.Label binaryNum;
        private System.Windows.Forms.TextBox natural1;
        private System.Windows.Forms.TextBox hexa1;
        private System.Windows.Forms.TextBox binary1;
        private System.Windows.Forms.Label naturalResult;
        private System.Windows.Forms.Label hexaResult;
        private System.Windows.Forms.Label binaryResult;
        private System.Windows.Forms.TextBox natural2;
        private System.Windows.Forms.TextBox binary2;
        private System.Windows.Forms.TextBox hexa2;
        private System.Windows.Forms.Button LeftShift;
        private System.Windows.Forms.Button RightShift;
    }
}

