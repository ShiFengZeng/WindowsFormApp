namespace PieChart
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.candidateButton1 = new System.Windows.Forms.Button();
            this.candidateButton2 = new System.Windows.Forms.Button();
            this.candidateButton3 = new System.Windows.Forms.Button();
            this.candidateText1 = new System.Windows.Forms.TextBox();
            this.candidateText2 = new System.Windows.Forms.TextBox();
            this.candidateText3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // candidateButton1
            // 
            this.candidateButton1.Location = new System.Drawing.Point(12, 247);
            this.candidateButton1.Name = "candidateButton1";
            this.candidateButton1.Size = new System.Drawing.Size(75, 23);
            this.candidateButton1.TabIndex = 0;
            this.candidateButton1.Text = "候選人1號";
            this.candidateButton1.UseVisualStyleBackColor = true;
            this.candidateButton1.Click += new System.EventHandler(this.candidateButton1_Click);
            // 
            // candidateButton2
            // 
            this.candidateButton2.Location = new System.Drawing.Point(115, 247);
            this.candidateButton2.Name = "candidateButton2";
            this.candidateButton2.Size = new System.Drawing.Size(75, 23);
            this.candidateButton2.TabIndex = 1;
            this.candidateButton2.Text = "候選人2號";
            this.candidateButton2.UseVisualStyleBackColor = true;
            this.candidateButton2.Click += new System.EventHandler(this.candidateButton2_Click);
            // 
            // candidateButton3
            // 
            this.candidateButton3.Location = new System.Drawing.Point(213, 247);
            this.candidateButton3.Name = "candidateButton3";
            this.candidateButton3.Size = new System.Drawing.Size(75, 23);
            this.candidateButton3.TabIndex = 2;
            this.candidateButton3.Text = "候選人3號";
            this.candidateButton3.UseVisualStyleBackColor = true;
            this.candidateButton3.Click += new System.EventHandler(this.candidateButton3_Click);
            // 
            // candidateText1
            // 
            this.candidateText1.BackColor = System.Drawing.Color.Yellow;
            this.candidateText1.Location = new System.Drawing.Point(13, 276);
            this.candidateText1.Name = "candidateText1";
            this.candidateText1.Size = new System.Drawing.Size(74, 22);
            this.candidateText1.TabIndex = 3;
            this.candidateText1.Text = "0";
            this.candidateText1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.candidateText1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.candidateText1_KeyDown);
            this.candidateText1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.candidateText1_KeyPress);
            // 
            // candidateText2
            // 
            this.candidateText2.BackColor = System.Drawing.Color.Lime;
            this.candidateText2.Location = new System.Drawing.Point(115, 276);
            this.candidateText2.Name = "candidateText2";
            this.candidateText2.Size = new System.Drawing.Size(75, 22);
            this.candidateText2.TabIndex = 4;
            this.candidateText2.Text = "0";
            this.candidateText2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.candidateText2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.candidateText1_KeyDown);
            this.candidateText2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.candidateText1_KeyPress);
            // 
            // candidateText3
            // 
            this.candidateText3.BackColor = System.Drawing.Color.Red;
            this.candidateText3.Location = new System.Drawing.Point(213, 276);
            this.candidateText3.Name = "candidateText3";
            this.candidateText3.Size = new System.Drawing.Size(75, 22);
            this.candidateText3.TabIndex = 5;
            this.candidateText3.Text = "0";
            this.candidateText3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.candidateText3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.candidateText1_KeyDown);
            this.candidateText3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.candidateText1_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.candidateText3);
            this.Controls.Add(this.candidateText2);
            this.Controls.Add(this.candidateText1);
            this.Controls.Add(this.candidateButton3);
            this.Controls.Add(this.candidateButton2);
            this.Controls.Add(this.candidateButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "投票比例繪圖程式";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button candidateButton1;
        private System.Windows.Forms.Button candidateButton2;
        private System.Windows.Forms.Button candidateButton3;
        private System.Windows.Forms.TextBox candidateText1;
        private System.Windows.Forms.TextBox candidateText2;
        private System.Windows.Forms.TextBox candidateText3;
    }
}

