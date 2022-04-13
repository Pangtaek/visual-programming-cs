namespace _021_Label
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
            this.btn_explain = new System.Windows.Forms.Button();
            this.lbl_explain1 = new System.Windows.Forms.Label();
            this.lbl_explain2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_explain
            // 
            this.btn_explain.Location = new System.Drawing.Point(124, 52);
            this.btn_explain.Name = "btn_explain";
            this.btn_explain.Size = new System.Drawing.Size(75, 33);
            this.btn_explain.TabIndex = 0;
            this.btn_explain.Text = "explain";
            this.btn_explain.UseVisualStyleBackColor = true;
            this.btn_explain.Click += new System.EventHandler(this.btn_explain_Click);
            // 
            // lbl_explain1
            // 
            this.lbl_explain1.AutoSize = true;
            this.lbl_explain1.Location = new System.Drawing.Point(124, 114);
            this.lbl_explain1.Name = "lbl_explain1";
            this.lbl_explain1.Size = new System.Drawing.Size(0, 18);
            this.lbl_explain1.TabIndex = 1;
            // 
            // lbl_explain2
            // 
            this.lbl_explain2.AutoSize = true;
            this.lbl_explain2.Location = new System.Drawing.Point(127, 203);
            this.lbl_explain2.Name = "lbl_explain2";
            this.lbl_explain2.Size = new System.Drawing.Size(0, 18);
            this.lbl_explain2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_explain2);
            this.Controls.Add(this.lbl_explain1);
            this.Controls.Add(this.btn_explain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_explain;
        private System.Windows.Forms.Label lbl_explain1;
        private System.Windows.Forms.Label lbl_explain2;
    }
}

