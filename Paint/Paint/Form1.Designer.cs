namespace Paint
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
            this.redButton = new System.Windows.Forms.RadioButton();
            this.greenButton = new System.Windows.Forms.RadioButton();
            this.blueButon = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // redButton
            // 
            this.redButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.redButton.AutoSize = true;
            this.redButton.Location = new System.Drawing.Point(104, 284);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(47, 16);
            this.redButton.TabIndex = 0;
            this.redButton.TabStop = true;
            this.redButton.Text = "紅色";
            this.redButton.UseVisualStyleBackColor = true;
            // 
            // greenButton
            // 
            this.greenButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.greenButton.AutoSize = true;
            this.greenButton.Location = new System.Drawing.Point(209, 284);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(47, 16);
            this.greenButton.TabIndex = 1;
            this.greenButton.TabStop = true;
            this.greenButton.Text = "綠色";
            this.greenButton.UseVisualStyleBackColor = true;
            // 
            // blueButon
            // 
            this.blueButon.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.blueButon.AutoSize = true;
            this.blueButon.Location = new System.Drawing.Point(313, 284);
            this.blueButon.Name = "blueButon";
            this.blueButon.Size = new System.Drawing.Size(47, 16);
            this.blueButon.TabIndex = 2;
            this.blueButon.TabStop = true;
            this.blueButon.Text = "藍色";
            this.blueButon.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 338);
            this.Controls.Add(this.blueButon);
            this.Controls.Add(this.greenButton);
            this.Controls.Add(this.redButton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "三色繪圖程式";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton redButton;
        private System.Windows.Forms.RadioButton greenButton;
        private System.Windows.Forms.RadioButton blueButon;
    }
}

