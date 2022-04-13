namespace _025_Scroll
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.hScrollBar_Red = new System.Windows.Forms.HScrollBar();
            this.txt_red = new System.Windows.Forms.TextBox();
            this.txt_green = new System.Windows.Forms.TextBox();
            this.hScrollBar_Green = new System.Windows.Forms.HScrollBar();
            this.txt_blue = new System.Windows.Forms.TextBox();
            this.hScrollBar_Blue = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(182, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 145);
            this.panel1.TabIndex = 0;
            // 
            // hScrollBar_Red
            // 
            this.hScrollBar_Red.Location = new System.Drawing.Point(182, 244);
            this.hScrollBar_Red.Name = "hScrollBar_Red";
            this.hScrollBar_Red.Size = new System.Drawing.Size(427, 26);
            this.hScrollBar_Red.TabIndex = 1;
            this.hScrollBar_Red.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scr_Scroll);
            // 
            // txt_red
            // 
            this.txt_red.Location = new System.Drawing.Point(612, 242);
            this.txt_red.Name = "txt_red";
            this.txt_red.Size = new System.Drawing.Size(100, 28);
            this.txt_red.TabIndex = 2;
            this.txt_red.TextChanged += new System.EventHandler(this.txt_blue_TextChanged);
            // 
            // txt_green
            // 
            this.txt_green.Location = new System.Drawing.Point(612, 296);
            this.txt_green.Name = "txt_green";
            this.txt_green.Size = new System.Drawing.Size(100, 28);
            this.txt_green.TabIndex = 4;
            this.txt_green.TextChanged += new System.EventHandler(this.txt_blue_TextChanged);
            // 
            // hScrollBar_Green
            // 
            this.hScrollBar_Green.Location = new System.Drawing.Point(182, 298);
            this.hScrollBar_Green.Name = "hScrollBar_Green";
            this.hScrollBar_Green.Size = new System.Drawing.Size(427, 26);
            this.hScrollBar_Green.TabIndex = 3;
            this.hScrollBar_Green.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scr_Scroll);
            // 
            // txt_blue
            // 
            this.txt_blue.Location = new System.Drawing.Point(612, 350);
            this.txt_blue.Name = "txt_blue";
            this.txt_blue.Size = new System.Drawing.Size(100, 28);
            this.txt_blue.TabIndex = 6;
            this.txt_blue.TextChanged += new System.EventHandler(this.txt_blue_TextChanged);
            // 
            // hScrollBar_Blue
            // 
            this.hScrollBar_Blue.Location = new System.Drawing.Point(182, 352);
            this.hScrollBar_Blue.Name = "hScrollBar_Blue";
            this.hScrollBar_Blue.Size = new System.Drawing.Size(427, 26);
            this.hScrollBar_Blue.TabIndex = 5;
            this.hScrollBar_Blue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scr_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Green";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Blue";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_blue);
            this.Controls.Add(this.hScrollBar_Blue);
            this.Controls.Add(this.txt_green);
            this.Controls.Add(this.hScrollBar_Green);
            this.Controls.Add(this.txt_red);
            this.Controls.Add(this.hScrollBar_Red);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.HScrollBar hScrollBar_Red;
        private System.Windows.Forms.TextBox txt_red;
        private System.Windows.Forms.TextBox txt_green;
        private System.Windows.Forms.HScrollBar hScrollBar_Green;
        private System.Windows.Forms.TextBox txt_blue;
        private System.Windows.Forms.HScrollBar hScrollBar_Blue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

