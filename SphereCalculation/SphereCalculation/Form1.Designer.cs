namespace SphereCalculation
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
            this.radiusText = new System.Windows.Forms.TextBox();
            this.resultText = new System.Windows.Forms.TextBox();
            this.radiusLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.surfaceButton = new System.Windows.Forms.Button();
            this.volumeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radiusText
            // 
            this.radiusText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radiusText.Location = new System.Drawing.Point(92, 34);
            this.radiusText.Name = "radiusText";
            this.radiusText.Size = new System.Drawing.Size(182, 22);
            this.radiusText.TabIndex = 0;
            this.radiusText.Text = "0";
            this.radiusText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.radiusText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.radiusText_KeyPress);
            // 
            // resultText
            // 
            this.resultText.Enabled = false;
            this.resultText.Location = new System.Drawing.Point(92, 153);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(182, 22);
            this.resultText.TabIndex = 1;
            this.resultText.Text = "0";
            this.resultText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radiusLabel
            // 
            this.radiusLabel.AutoSize = true;
            this.radiusLabel.Location = new System.Drawing.Point(12, 37);
            this.radiusLabel.Name = "radiusLabel";
            this.radiusLabel.Size = new System.Drawing.Size(77, 12);
            this.radiusLabel.TabIndex = 2;
            this.radiusLabel.Text = "請輸入半徑：";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(12, 156);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(77, 12);
            this.resultLabel.TabIndex = 3;
            this.resultLabel.Text = "計算結果為：";
            // 
            // surfaceButton
            // 
            this.surfaceButton.Location = new System.Drawing.Point(6, 90);
            this.surfaceButton.Name = "surfaceButton";
            this.surfaceButton.Size = new System.Drawing.Size(131, 23);
            this.surfaceButton.TabIndex = 4;
            this.surfaceButton.Text = "計算球體面積";
            this.surfaceButton.UseVisualStyleBackColor = true;
            this.surfaceButton.Click += new System.EventHandler(this.surfaceButton_Click);
            // 
            // volumeButton
            // 
            this.volumeButton.Location = new System.Drawing.Point(143, 90);
            this.volumeButton.Name = "volumeButton";
            this.volumeButton.Size = new System.Drawing.Size(131, 23);
            this.volumeButton.TabIndex = 5;
            this.volumeButton.Text = "計算球體體積";
            this.volumeButton.UseVisualStyleBackColor = true;
            this.volumeButton.Click += new System.EventHandler(this.volumeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 199);
            this.Controls.Add(this.volumeButton);
            this.Controls.Add(this.surfaceButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.radiusLabel);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.radiusText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "球體面積與體積計算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox radiusText;
        private System.Windows.Forms.TextBox resultText;
        private System.Windows.Forms.Label radiusLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button surfaceButton;
        private System.Windows.Forms.Button volumeButton;
    }
}

