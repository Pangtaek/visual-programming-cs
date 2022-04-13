namespace _022_FavoriteFruit
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
            this.cbox_strawberry = new System.Windows.Forms.CheckBox();
            this.cbox_pear = new System.Windows.Forms.CheckBox();
            this.cbox_apple = new System.Windows.Forms.CheckBox();
            this.cbox_mango = new System.Windows.Forms.CheckBox();
            this.cbox_banana = new System.Windows.Forms.CheckBox();
            this.btn_choose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "What\'s your favorite Fruit?";
            // 
            // cbox_strawberry
            // 
            this.cbox_strawberry.AutoSize = true;
            this.cbox_strawberry.Location = new System.Drawing.Point(75, 89);
            this.cbox_strawberry.Name = "cbox_strawberry";
            this.cbox_strawberry.Size = new System.Drawing.Size(70, 22);
            this.cbox_strawberry.TabIndex = 1;
            this.cbox_strawberry.Text = "딸기";
            this.cbox_strawberry.UseVisualStyleBackColor = true;
            // 
            // cbox_pear
            // 
            this.cbox_pear.AutoSize = true;
            this.cbox_pear.Location = new System.Drawing.Point(75, 134);
            this.cbox_pear.Name = "cbox_pear";
            this.cbox_pear.Size = new System.Drawing.Size(52, 22);
            this.cbox_pear.TabIndex = 2;
            this.cbox_pear.Text = "배";
            this.cbox_pear.UseVisualStyleBackColor = true;
            // 
            // cbox_apple
            // 
            this.cbox_apple.AutoSize = true;
            this.cbox_apple.Location = new System.Drawing.Point(75, 179);
            this.cbox_apple.Name = "cbox_apple";
            this.cbox_apple.Size = new System.Drawing.Size(70, 22);
            this.cbox_apple.TabIndex = 3;
            this.cbox_apple.Text = "사과";
            this.cbox_apple.UseVisualStyleBackColor = true;
            // 
            // cbox_mango
            // 
            this.cbox_mango.AutoSize = true;
            this.cbox_mango.Location = new System.Drawing.Point(75, 224);
            this.cbox_mango.Name = "cbox_mango";
            this.cbox_mango.Size = new System.Drawing.Size(70, 22);
            this.cbox_mango.TabIndex = 4;
            this.cbox_mango.Text = "망고";
            this.cbox_mango.UseVisualStyleBackColor = true;
            // 
            // cbox_banana
            // 
            this.cbox_banana.AutoSize = true;
            this.cbox_banana.Location = new System.Drawing.Point(75, 269);
            this.cbox_banana.Name = "cbox_banana";
            this.cbox_banana.Size = new System.Drawing.Size(88, 22);
            this.cbox_banana.TabIndex = 5;
            this.cbox_banana.Text = "바나나";
            this.cbox_banana.UseVisualStyleBackColor = true;
            // 
            // btn_choose
            // 
            this.btn_choose.Location = new System.Drawing.Point(255, 32);
            this.btn_choose.Name = "btn_choose";
            this.btn_choose.Size = new System.Drawing.Size(104, 49);
            this.btn_choose.TabIndex = 6;
            this.btn_choose.Text = "선택";
            this.btn_choose.UseVisualStyleBackColor = true;
            this.btn_choose.Click += new System.EventHandler(this.btn_choose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_choose);
            this.Controls.Add(this.cbox_banana);
            this.Controls.Add(this.cbox_mango);
            this.Controls.Add(this.cbox_apple);
            this.Controls.Add(this.cbox_pear);
            this.Controls.Add(this.cbox_strawberry);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "33";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbox_strawberry;
        private System.Windows.Forms.CheckBox cbox_pear;
        private System.Windows.Forms.CheckBox cbox_apple;
        private System.Windows.Forms.CheckBox cbox_mango;
        private System.Windows.Forms.CheckBox cbox_banana;
        private System.Windows.Forms.Button btn_choose;
    }
}

