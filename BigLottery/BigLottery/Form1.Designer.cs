namespace BigLottery
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
            this.nunText1 = new System.Windows.Forms.TextBox();
            this.nunText2 = new System.Windows.Forms.TextBox();
            this.nunText3 = new System.Windows.Forms.TextBox();
            this.nunText4 = new System.Windows.Forms.TextBox();
            this.nunText5 = new System.Windows.Forms.TextBox();
            this.nunText6 = new System.Windows.Forms.TextBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.continuousCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // nunText1
            // 
            this.nunText1.Location = new System.Drawing.Point(28, 42);
            this.nunText1.Name = "nunText1";
            this.nunText1.Size = new System.Drawing.Size(28, 22);
            this.nunText1.TabIndex = 0;
            // 
            // nunText2
            // 
            this.nunText2.Location = new System.Drawing.Point(77, 42);
            this.nunText2.Name = "nunText2";
            this.nunText2.Size = new System.Drawing.Size(28, 22);
            this.nunText2.TabIndex = 1;
            // 
            // nunText3
            // 
            this.nunText3.Location = new System.Drawing.Point(124, 42);
            this.nunText3.Name = "nunText3";
            this.nunText3.Size = new System.Drawing.Size(28, 22);
            this.nunText3.TabIndex = 2;
            // 
            // nunText4
            // 
            this.nunText4.Location = new System.Drawing.Point(171, 42);
            this.nunText4.Name = "nunText4";
            this.nunText4.Size = new System.Drawing.Size(28, 22);
            this.nunText4.TabIndex = 3;
            // 
            // nunText5
            // 
            this.nunText5.Location = new System.Drawing.Point(220, 42);
            this.nunText5.Name = "nunText5";
            this.nunText5.Size = new System.Drawing.Size(28, 22);
            this.nunText5.TabIndex = 4;
            // 
            // nunText6
            // 
            this.nunText6.Location = new System.Drawing.Point(268, 42);
            this.nunText6.Name = "nunText6";
            this.nunText6.Size = new System.Drawing.Size(28, 22);
            this.nunText6.TabIndex = 5;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(312, 41);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(70, 23);
            this.generateButton.TabIndex = 6;
            this.generateButton.Text = "產生號碼";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // continuousCheck
            // 
            this.continuousCheck.AutoSize = true;
            this.continuousCheck.Location = new System.Drawing.Point(388, 44);
            this.continuousCheck.Name = "continuousCheck";
            this.continuousCheck.Size = new System.Drawing.Size(84, 16);
            this.continuousCheck.TabIndex = 7;
            this.continuousCheck.Text = "允許連號？";
            this.continuousCheck.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 93);
            this.Controls.Add(this.continuousCheck);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.nunText6);
            this.Controls.Add(this.nunText5);
            this.Controls.Add(this.nunText4);
            this.Controls.Add(this.nunText3);
            this.Controls.Add(this.nunText2);
            this.Controls.Add(this.nunText1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "樂透電腦選號程式";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nunText1;
        private System.Windows.Forms.TextBox nunText2;
        private System.Windows.Forms.TextBox nunText3;
        private System.Windows.Forms.TextBox nunText4;
        private System.Windows.Forms.TextBox nunText5;
        private System.Windows.Forms.TextBox nunText6;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.CheckBox continuousCheck;
    }
}

