namespace _023_Radiobox
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtn_kor = new System.Windows.Forms.RadioButton();
            this.rbtn_cha = new System.Windows.Forms.RadioButton();
            this.rbtn_jp = new System.Windows.Forms.RadioButton();
            this.rbtn_another = new System.Windows.Forms.RadioButton();
            this.rbtn_male = new System.Windows.Forms.RadioButton();
            this.rbtn_female = new System.Windows.Forms.RadioButton();
            this.btn_choose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtn_another);
            this.groupBox1.Controls.Add(this.rbtn_jp);
            this.groupBox1.Controls.Add(this.rbtn_cha);
            this.groupBox1.Controls.Add(this.rbtn_kor);
            this.groupBox1.Location = new System.Drawing.Point(121, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 149);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "국적";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbtn_female);
            this.groupBox3.Controls.Add(this.rbtn_male);
            this.groupBox3.Location = new System.Drawing.Point(361, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 106);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "성별";
            // 
            // rbtn_kor
            // 
            this.rbtn_kor.AutoSize = true;
            this.rbtn_kor.Location = new System.Drawing.Point(7, 28);
            this.rbtn_kor.Name = "rbtn_kor";
            this.rbtn_kor.Size = new System.Drawing.Size(69, 22);
            this.rbtn_kor.TabIndex = 0;
            this.rbtn_kor.TabStop = true;
            this.rbtn_kor.Text = "한국";
            this.rbtn_kor.UseVisualStyleBackColor = true;
            // 
            // rbtn_cha
            // 
            this.rbtn_cha.AutoSize = true;
            this.rbtn_cha.Location = new System.Drawing.Point(7, 56);
            this.rbtn_cha.Name = "rbtn_cha";
            this.rbtn_cha.Size = new System.Drawing.Size(69, 22);
            this.rbtn_cha.TabIndex = 1;
            this.rbtn_cha.TabStop = true;
            this.rbtn_cha.Text = "중국";
            this.rbtn_cha.UseVisualStyleBackColor = true;
            // 
            // rbtn_jp
            // 
            this.rbtn_jp.AutoSize = true;
            this.rbtn_jp.Location = new System.Drawing.Point(7, 84);
            this.rbtn_jp.Name = "rbtn_jp";
            this.rbtn_jp.Size = new System.Drawing.Size(69, 22);
            this.rbtn_jp.TabIndex = 2;
            this.rbtn_jp.TabStop = true;
            this.rbtn_jp.Text = "일본";
            this.rbtn_jp.UseVisualStyleBackColor = true;
            // 
            // rbtn_another
            // 
            this.rbtn_another.AutoSize = true;
            this.rbtn_another.Location = new System.Drawing.Point(7, 112);
            this.rbtn_another.Name = "rbtn_another";
            this.rbtn_another.Size = new System.Drawing.Size(75, 22);
            this.rbtn_another.TabIndex = 3;
            this.rbtn_another.TabStop = true;
            this.rbtn_another.Text = "그 외";
            this.rbtn_another.UseVisualStyleBackColor = true;
            // 
            // rbtn_male
            // 
            this.rbtn_male.AutoSize = true;
            this.rbtn_male.Location = new System.Drawing.Point(0, 28);
            this.rbtn_male.Name = "rbtn_male";
            this.rbtn_male.Size = new System.Drawing.Size(69, 22);
            this.rbtn_male.TabIndex = 4;
            this.rbtn_male.TabStop = true;
            this.rbtn_male.Text = "남성";
            this.rbtn_male.UseVisualStyleBackColor = true;
            // 
            // rbtn_female
            // 
            this.rbtn_female.AutoSize = true;
            this.rbtn_female.Location = new System.Drawing.Point(0, 56);
            this.rbtn_female.Name = "rbtn_female";
            this.rbtn_female.Size = new System.Drawing.Size(69, 22);
            this.rbtn_female.TabIndex = 5;
            this.rbtn_female.TabStop = true;
            this.rbtn_female.Text = "여성";
            this.rbtn_female.UseVisualStyleBackColor = true;
            // 
            // btn_choose
            // 
            this.btn_choose.Location = new System.Drawing.Point(128, 256);
            this.btn_choose.Name = "btn_choose";
            this.btn_choose.Size = new System.Drawing.Size(433, 38);
            this.btn_choose.TabIndex = 2;
            this.btn_choose.Text = "choose";
            this.btn_choose.UseVisualStyleBackColor = true;
            this.btn_choose.Click += new System.EventHandler(this.btn_choose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_choose);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtn_another;
        private System.Windows.Forms.RadioButton rbtn_jp;
        private System.Windows.Forms.RadioButton rbtn_cha;
        private System.Windows.Forms.RadioButton rbtn_kor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbtn_female;
        private System.Windows.Forms.RadioButton rbtn_male;
        private System.Windows.Forms.Button btn_choose;
    }
}

