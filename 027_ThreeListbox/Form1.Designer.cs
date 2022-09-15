namespace _027_ThreeListbox
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_SIndex1 = new System.Windows.Forms.TextBox();
            this.txt_SItem1 = new System.Windows.Forms.TextBox();
            this.txt_SItem2 = new System.Windows.Forms.TextBox();
            this.txt_SIndex2 = new System.Windows.Forms.TextBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_SItem3 = new System.Windows.Forms.TextBox();
            this.txt_SIndex3 = new System.Windows.Forms.TextBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Items.AddRange(new object[] {
            "미국",
            "러시아",
            "중국",
            "영국",
            "독일",
            "프랑스",
            "일본",
            "이스라엘",
            "사우디아라비아",
            "UAE",
            "대한민국"});
            this.listBox1.Location = new System.Drawing.Point(161, 92);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 184);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
            // 
            // txt_SIndex1
            // 
            this.txt_SIndex1.Location = new System.Drawing.Point(161, 291);
            this.txt_SIndex1.Name = "txt_SIndex1";
            this.txt_SIndex1.Size = new System.Drawing.Size(120, 28);
            this.txt_SIndex1.TabIndex = 5;
            // 
            // txt_SItem1
            // 
            this.txt_SItem1.Location = new System.Drawing.Point(161, 348);
            this.txt_SItem1.Name = "txt_SItem1";
            this.txt_SItem1.Size = new System.Drawing.Size(120, 28);
            this.txt_SItem1.TabIndex = 6;
            // 
            // txt_SItem2
            // 
            this.txt_SItem2.Location = new System.Drawing.Point(325, 348);
            this.txt_SItem2.Name = "txt_SItem2";
            this.txt_SItem2.Size = new System.Drawing.Size(120, 28);
            this.txt_SItem2.TabIndex = 10;
            // 
            // txt_SIndex2
            // 
            this.txt_SIndex2.Location = new System.Drawing.Point(325, 291);
            this.txt_SIndex2.Name = "txt_SIndex2";
            this.txt_SIndex2.Size = new System.Drawing.Size(120, 28);
            this.txt_SIndex2.TabIndex = 9;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 18;
            this.listBox2.Location = new System.Drawing.Point(325, 92);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 184);
            this.listBox2.TabIndex = 8;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(359, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "label5";
            // 
            // txt_SItem3
            // 
            this.txt_SItem3.Location = new System.Drawing.Point(492, 348);
            this.txt_SItem3.Name = "txt_SItem3";
            this.txt_SItem3.Size = new System.Drawing.Size(120, 28);
            this.txt_SItem3.TabIndex = 14;
            // 
            // txt_SIndex3
            // 
            this.txt_SIndex3.Location = new System.Drawing.Point(492, 291);
            this.txt_SIndex3.Name = "txt_SIndex3";
            this.txt_SIndex3.Size = new System.Drawing.Size(120, 28);
            this.txt_SIndex3.TabIndex = 13;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 18;
            this.listBox3.Location = new System.Drawing.Point(492, 92);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(120, 184);
            this.listBox3.TabIndex = 12;
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(526, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_SItem3);
            this.Controls.Add(this.txt_SIndex3);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_SItem2);
            this.Controls.Add(this.txt_SIndex2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_SItem1);
            this.Controls.Add(this.txt_SIndex1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_SIndex1;
        private System.Windows.Forms.TextBox txt_SItem1;
        private System.Windows.Forms.TextBox txt_SItem2;
        private System.Windows.Forms.TextBox txt_SIndex2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_SItem3;
        private System.Windows.Forms.TextBox txt_SIndex3;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label6;
    }
}

