namespace GuessNumberGame
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
            this.minText = new System.Windows.Forms.TextBox();
            this.guessText = new System.Windows.Forms.TextBox();
            this.maxText = new System.Windows.Forms.TextBox();
            this.minLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.chanceLabel = new System.Windows.Forms.Label();
            this.guessButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // minText
            // 
            this.minText.Enabled = false;
            this.minText.Location = new System.Drawing.Point(12, 41);
            this.minText.Name = "minText";
            this.minText.Size = new System.Drawing.Size(100, 22);
            this.minText.TabIndex = 0;
            this.minText.Text = "0";
            this.minText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guessText
            // 
            this.guessText.Location = new System.Drawing.Point(177, 41);
            this.guessText.Name = "guessText";
            this.guessText.Size = new System.Drawing.Size(148, 22);
            this.guessText.TabIndex = 1;
            this.guessText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guessText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.guessText_KeyDown);
            // 
            // maxText
            // 
            this.maxText.Enabled = false;
            this.maxText.Location = new System.Drawing.Point(392, 41);
            this.maxText.Name = "maxText";
            this.maxText.Size = new System.Drawing.Size(100, 22);
            this.maxText.TabIndex = 2;
            this.maxText.Text = "1000";
            this.maxText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(136, 44);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(11, 12);
            this.minLabel.TabIndex = 3;
            this.minLabel.Text = "<";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(353, 44);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(11, 12);
            this.maxLabel.TabIndex = 4;
            this.maxLabel.Text = "<";
            // 
            // chanceLabel
            // 
            this.chanceLabel.AutoSize = true;
            this.chanceLabel.Location = new System.Drawing.Point(390, 98);
            this.chanceLabel.Name = "chanceLabel";
            this.chanceLabel.Size = new System.Drawing.Size(77, 12);
            this.chanceLabel.TabIndex = 5;
            this.chanceLabel.Text = "還有10次機會";
            // 
            // guessButton
            // 
            this.guessButton.Location = new System.Drawing.Point(177, 90);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(148, 29);
            this.guessButton.TabIndex = 6;
            this.guessButton.Text = "猜測";
            this.guessButton.UseVisualStyleBackColor = true;
            this.guessButton.Click += new System.EventHandler(this.guessButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 131);
            this.Controls.Add(this.guessButton);
            this.Controls.Add(this.chanceLabel);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.maxText);
            this.Controls.Add(this.guessText);
            this.Controls.Add(this.minText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "猜數字";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox minText;
        private System.Windows.Forms.TextBox guessText;
        private System.Windows.Forms.TextBox maxText;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label chanceLabel;
        private System.Windows.Forms.Button guessButton;
    }
}

