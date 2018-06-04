namespace _1A2B_Game
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
            this.numText1 = new System.Windows.Forms.TextBox();
            this.numText2 = new System.Windows.Forms.TextBox();
            this.numText3 = new System.Windows.Forms.TextBox();
            this.numText4 = new System.Windows.Forms.TextBox();
            this.guessButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.logList = new System.Windows.Forms.ListBox();
            this.logLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numText1
            // 
            this.numText1.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.numText1.Location = new System.Drawing.Point(26, 22);
            this.numText1.Name = "numText1";
            this.numText1.Size = new System.Drawing.Size(29, 23);
            this.numText1.TabIndex = 0;
            this.numText1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numText1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numText1_KeyPress);
            // 
            // numText2
            // 
            this.numText2.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.numText2.Location = new System.Drawing.Point(76, 22);
            this.numText2.Name = "numText2";
            this.numText2.Size = new System.Drawing.Size(29, 23);
            this.numText2.TabIndex = 1;
            this.numText2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numText2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numText1_KeyPress);
            // 
            // numText3
            // 
            this.numText3.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.numText3.Location = new System.Drawing.Point(127, 22);
            this.numText3.Name = "numText3";
            this.numText3.Size = new System.Drawing.Size(29, 23);
            this.numText3.TabIndex = 2;
            this.numText3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numText3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numText1_KeyPress);
            // 
            // numText4
            // 
            this.numText4.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.numText4.Location = new System.Drawing.Point(179, 22);
            this.numText4.Name = "numText4";
            this.numText4.Size = new System.Drawing.Size(29, 23);
            this.numText4.TabIndex = 3;
            this.numText4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numText4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numText1_KeyPress);
            // 
            // guessButton
            // 
            this.guessButton.Location = new System.Drawing.Point(26, 51);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(182, 23);
            this.guessButton.TabIndex = 4;
            this.guessButton.Text = "猜測";
            this.guessButton.UseVisualStyleBackColor = true;
            this.guessButton.Click += new System.EventHandler(this.guessButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(26, 300);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(182, 23);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "重開新局";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // logList
            // 
            this.logList.FormattingEnabled = true;
            this.logList.ItemHeight = 12;
            this.logList.Location = new System.Drawing.Point(26, 98);
            this.logList.Name = "logList";
            this.logList.Size = new System.Drawing.Size(182, 196);
            this.logList.TabIndex = 6;
            // 
            // logLabel
            // 
            this.logLabel.AutoSize = true;
            this.logLabel.Location = new System.Drawing.Point(26, 81);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(53, 12);
            this.logLabel.TabIndex = 7;
            this.logLabel.Text = "猜測記錄";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 335);
            this.Controls.Add(this.logLabel);
            this.Controls.Add(this.logList);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.guessButton);
            this.Controls.Add(this.numText4);
            this.Controls.Add(this.numText3);
            this.Controls.Add(this.numText2);
            this.Controls.Add(this.numText1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1A2B猜數字遊戲";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numText1;
        private System.Windows.Forms.TextBox numText2;
        private System.Windows.Forms.TextBox numText3;
        private System.Windows.Forms.TextBox numText4;
        private System.Windows.Forms.Button guessButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.ListBox logList;
        private System.Windows.Forms.Label logLabel;
    }
}

