namespace TriangleAreaForm
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
            this.styleLabel = new System.Windows.Forms.Label();
            this.aText = new System.Windows.Forms.TextBox();
            this.bText = new System.Windows.Forms.TextBox();
            this.cText = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.areaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // styleLabel
            // 
            this.styleLabel.AutoSize = true;
            this.styleLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.styleLabel.Location = new System.Drawing.Point(40, 119);
            this.styleLabel.Name = "styleLabel";
            this.styleLabel.Size = new System.Drawing.Size(0, 16);
            this.styleLabel.TabIndex = 0;
            // 
            // aText
            // 
            this.aText.Location = new System.Drawing.Point(43, 65);
            this.aText.Name = "aText";
            this.aText.Size = new System.Drawing.Size(59, 22);
            this.aText.TabIndex = 1;
            // 
            // bText
            // 
            this.bText.Location = new System.Drawing.Point(162, 65);
            this.bText.Name = "bText";
            this.bText.Size = new System.Drawing.Size(59, 22);
            this.bText.TabIndex = 2;
            // 
            // cText
            // 
            this.cText.Location = new System.Drawing.Point(287, 65);
            this.cText.Name = "cText";
            this.cText.Size = new System.Drawing.Size(59, 22);
            this.cText.TabIndex = 3;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(142, 217);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(108, 29);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "執行";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // areaLabel
            // 
            this.areaLabel.AutoSize = true;
            this.areaLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.areaLabel.Location = new System.Drawing.Point(40, 170);
            this.areaLabel.Name = "areaLabel";
            this.areaLabel.Size = new System.Drawing.Size(0, 16);
            this.areaLabel.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 286);
            this.Controls.Add(this.areaLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.cText);
            this.Controls.Add(this.bText);
            this.Controls.Add(this.aText);
            this.Controls.Add(this.styleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "三角形面積";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label styleLabel;
        private System.Windows.Forms.TextBox aText;
        private System.Windows.Forms.TextBox bText;
        private System.Windows.Forms.TextBox cText;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label areaLabel;
    }
}

