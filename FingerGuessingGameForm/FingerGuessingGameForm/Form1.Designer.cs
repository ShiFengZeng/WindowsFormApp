namespace FingerGuessingGameForm
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
            this.scissorsButton = new System.Windows.Forms.Button();
            this.stoneButton = new System.Windows.Forms.Button();
            this.papperBUtton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.playerWinLabel = new System.Windows.Forms.Label();
            this.computerWinLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // scissorsButton
            // 
            this.scissorsButton.Location = new System.Drawing.Point(36, 226);
            this.scissorsButton.Name = "scissorsButton";
            this.scissorsButton.Size = new System.Drawing.Size(62, 26);
            this.scissorsButton.TabIndex = 0;
            this.scissorsButton.Text = "剪刀";
            this.scissorsButton.UseVisualStyleBackColor = true;
            this.scissorsButton.Click += new System.EventHandler(this.scissorsButton_Click);
            // 
            // stoneButton
            // 
            this.stoneButton.Location = new System.Drawing.Point(181, 226);
            this.stoneButton.Name = "stoneButton";
            this.stoneButton.Size = new System.Drawing.Size(62, 26);
            this.stoneButton.TabIndex = 1;
            this.stoneButton.Text = "石頭";
            this.stoneButton.UseVisualStyleBackColor = true;
            this.stoneButton.Click += new System.EventHandler(this.stoneButton_Click);
            // 
            // papperBUtton
            // 
            this.papperBUtton.Location = new System.Drawing.Point(326, 226);
            this.papperBUtton.Name = "papperBUtton";
            this.papperBUtton.Size = new System.Drawing.Size(62, 26);
            this.papperBUtton.TabIndex = 2;
            this.papperBUtton.Text = "布";
            this.papperBUtton.UseVisualStyleBackColor = true;
            this.papperBUtton.Click += new System.EventHandler(this.papperBUtton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(44, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "玩家";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(309, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "電腦";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "玩家獲勝次數：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "電腦獲勝次數：";
            // 
            // playerWinLabel
            // 
            this.playerWinLabel.Location = new System.Drawing.Point(40, 154);
            this.playerWinLabel.Name = "playerWinLabel";
            this.playerWinLabel.Size = new System.Drawing.Size(82, 12);
            this.playerWinLabel.TabIndex = 7;
            this.playerWinLabel.Text = "0";
            this.playerWinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // computerWinLabel
            // 
            this.computerWinLabel.Location = new System.Drawing.Point(305, 154);
            this.computerWinLabel.Name = "computerWinLabel";
            this.computerWinLabel.Size = new System.Drawing.Size(82, 12);
            this.computerWinLabel.TabIndex = 8;
            this.computerWinLabel.Text = "0";
            this.computerWinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 287);
            this.Controls.Add(this.computerWinLabel);
            this.Controls.Add(this.playerWinLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.papperBUtton);
            this.Controls.Add(this.stoneButton);
            this.Controls.Add(this.scissorsButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "猜拳遊戲";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button scissorsButton;
        private System.Windows.Forms.Button stoneButton;
        private System.Windows.Forms.Button papperBUtton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label playerWinLabel;
        private System.Windows.Forms.Label computerWinLabel;
    }
}

