namespace BinarySearchShow
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
            this.numText5 = new System.Windows.Forms.TextBox();
            this.numText6 = new System.Windows.Forms.TextBox();
            this.numText7 = new System.Windows.Forms.TextBox();
            this.numText8 = new System.Windows.Forms.TextBox();
            this.targetLabel = new System.Windows.Forms.Label();
            this.targetText = new System.Windows.Forms.TextBox();
            this.stepButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numText1
            // 
            this.numText1.Location = new System.Drawing.Point(13, 31);
            this.numText1.Name = "numText1";
            this.numText1.Size = new System.Drawing.Size(34, 22);
            this.numText1.TabIndex = 0;
            this.numText1.Text = "0";
            this.numText1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numText2
            // 
            this.numText2.Location = new System.Drawing.Point(53, 31);
            this.numText2.Name = "numText2";
            this.numText2.Size = new System.Drawing.Size(34, 22);
            this.numText2.TabIndex = 1;
            this.numText2.Text = "0";
            this.numText2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numText3
            // 
            this.numText3.Location = new System.Drawing.Point(93, 31);
            this.numText3.Name = "numText3";
            this.numText3.Size = new System.Drawing.Size(34, 22);
            this.numText3.TabIndex = 2;
            this.numText3.Text = "0";
            this.numText3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numText4
            // 
            this.numText4.Location = new System.Drawing.Point(133, 31);
            this.numText4.Name = "numText4";
            this.numText4.Size = new System.Drawing.Size(34, 22);
            this.numText4.TabIndex = 3;
            this.numText4.Text = "0";
            this.numText4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numText5
            // 
            this.numText5.Location = new System.Drawing.Point(173, 31);
            this.numText5.Name = "numText5";
            this.numText5.Size = new System.Drawing.Size(34, 22);
            this.numText5.TabIndex = 4;
            this.numText5.Text = "0";
            this.numText5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numText6
            // 
            this.numText6.Location = new System.Drawing.Point(213, 31);
            this.numText6.Name = "numText6";
            this.numText6.Size = new System.Drawing.Size(34, 22);
            this.numText6.TabIndex = 5;
            this.numText6.Text = "0";
            this.numText6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numText7
            // 
            this.numText7.Location = new System.Drawing.Point(253, 31);
            this.numText7.Name = "numText7";
            this.numText7.Size = new System.Drawing.Size(34, 22);
            this.numText7.TabIndex = 6;
            this.numText7.Text = "0";
            this.numText7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numText8
            // 
            this.numText8.Location = new System.Drawing.Point(293, 31);
            this.numText8.Name = "numText8";
            this.numText8.Size = new System.Drawing.Size(34, 22);
            this.numText8.TabIndex = 7;
            this.numText8.Text = "0";
            this.numText8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // targetLabel
            // 
            this.targetLabel.AutoSize = true;
            this.targetLabel.Location = new System.Drawing.Point(333, 34);
            this.targetLabel.Name = "targetLabel";
            this.targetLabel.Size = new System.Drawing.Size(77, 12);
            this.targetLabel.TabIndex = 9;
            this.targetLabel.Text = "搜尋目標是：";
            // 
            // targetText
            // 
            this.targetText.Location = new System.Drawing.Point(416, 30);
            this.targetText.Name = "targetText";
            this.targetText.Size = new System.Drawing.Size(34, 22);
            this.targetText.TabIndex = 10;
            this.targetText.Text = "0";
            this.targetText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // stepButton
            // 
            this.stepButton.Location = new System.Drawing.Point(456, 29);
            this.stepButton.Name = "stepButton";
            this.stepButton.Size = new System.Drawing.Size(75, 23);
            this.stepButton.TabIndex = 11;
            this.stepButton.Text = "開始";
            this.stepButton.UseVisualStyleBackColor = true;
            this.stepButton.Click += new System.EventHandler(this.stepButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 77);
            this.Controls.Add(this.stepButton);
            this.Controls.Add(this.targetText);
            this.Controls.Add(this.targetLabel);
            this.Controls.Add(this.numText8);
            this.Controls.Add(this.numText7);
            this.Controls.Add(this.numText6);
            this.Controls.Add(this.numText5);
            this.Controls.Add(this.numText4);
            this.Controls.Add(this.numText3);
            this.Controls.Add(this.numText2);
            this.Controls.Add(this.numText1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numText1;
        private System.Windows.Forms.TextBox numText2;
        private System.Windows.Forms.TextBox numText3;
        private System.Windows.Forms.TextBox numText4;
        private System.Windows.Forms.TextBox numText5;
        private System.Windows.Forms.TextBox numText6;
        private System.Windows.Forms.TextBox numText7;
        private System.Windows.Forms.TextBox numText8;
        private System.Windows.Forms.Label targetLabel;
        private System.Windows.Forms.TextBox targetText;
        private System.Windows.Forms.Button stepButton;
    }
}

