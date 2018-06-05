namespace PrimeNumber
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
            this.inputLebel = new System.Windows.Forms.Label();
            this.inputText = new System.Windows.Forms.TextBox();
            this.resultText = new System.Windows.Forms.TextBox();
            this.judgeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputLebel
            // 
            this.inputLebel.AutoSize = true;
            this.inputLebel.Location = new System.Drawing.Point(12, 39);
            this.inputLebel.Name = "inputLebel";
            this.inputLebel.Size = new System.Drawing.Size(41, 12);
            this.inputLebel.TabIndex = 0;
            this.inputLebel.Text = "數字：";
            // 
            // inputText
            // 
            this.inputText.Location = new System.Drawing.Point(51, 34);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(100, 22);
            this.inputText.TabIndex = 1;
            this.inputText.Text = "0";
            this.inputText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputText_KeyPress);
            // 
            // resultText
            // 
            this.resultText.Location = new System.Drawing.Point(238, 34);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(100, 22);
            this.resultText.TabIndex = 2;
            this.resultText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // judgeButton
            // 
            this.judgeButton.Location = new System.Drawing.Point(157, 34);
            this.judgeButton.Name = "judgeButton";
            this.judgeButton.Size = new System.Drawing.Size(75, 23);
            this.judgeButton.TabIndex = 3;
            this.judgeButton.Text = "判斷！";
            this.judgeButton.UseVisualStyleBackColor = true;
            this.judgeButton.Click += new System.EventHandler(this.judgeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 95);
            this.Controls.Add(this.judgeButton);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.inputLebel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "質數判斷";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputLebel;
        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.TextBox resultText;
        private System.Windows.Forms.Button judgeButton;
    }
}

