namespace _002_BMI_Form
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
            this.txt_weight = new System.Windows.Forms.TextBox();
            this.txt_height = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_BMI = new System.Windows.Forms.Button();
            this.lbl_BMI = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "체중";
            // 
            // txt_weight
            // 
            this.txt_weight.Location = new System.Drawing.Point(205, 47);
            this.txt_weight.Name = "txt_weight";
            this.txt_weight.Size = new System.Drawing.Size(100, 28);
            this.txt_weight.TabIndex = 1;
            // 
            // txt_height
            // 
            this.txt_height.Location = new System.Drawing.Point(205, 101);
            this.txt_height.Name = "txt_height";
            this.txt_height.Size = new System.Drawing.Size(100, 28);
            this.txt_height.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "신장";
            // 
            // btn_BMI
            // 
            this.btn_BMI.Location = new System.Drawing.Point(114, 146);
            this.btn_BMI.Name = "btn_BMI";
            this.btn_BMI.Size = new System.Drawing.Size(191, 38);
            this.btn_BMI.TabIndex = 4;
            this.btn_BMI.Text = "BMI";
            this.btn_BMI.UseVisualStyleBackColor = true;
            this.btn_BMI.Click += new System.EventHandler(this.btn_BMI_Click);
            // 
            // lbl_BMI
            // 
            this.lbl_BMI.AutoSize = true;
            this.lbl_BMI.Location = new System.Drawing.Point(111, 187);
            this.lbl_BMI.Name = "lbl_BMI";
            this.lbl_BMI.Size = new System.Drawing.Size(0, 18);
            this.lbl_BMI.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 353);
            this.Controls.Add(this.lbl_BMI);
            this.Controls.Add(this.btn_BMI);
            this.Controls.Add(this.txt_height);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_weight);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_weight;
        private System.Windows.Forms.TextBox txt_height;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_BMI;
        private System.Windows.Forms.Label lbl_BMI;
    }
}

