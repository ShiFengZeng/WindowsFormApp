﻿namespace BubbleSortShow
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
            this.components = new System.ComponentModel.Container();
            this.numText1 = new System.Windows.Forms.TextBox();
            this.numText2 = new System.Windows.Forms.TextBox();
            this.numText3 = new System.Windows.Forms.TextBox();
            this.numText4 = new System.Windows.Forms.TextBox();
            this.numText5 = new System.Windows.Forms.TextBox();
            this.numText6 = new System.Windows.Forms.TextBox();
            this.numText7 = new System.Windows.Forms.TextBox();
            this.numText8 = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // numText1
            // 
            this.numText1.Location = new System.Drawing.Point(12, 32);
            this.numText1.Name = "numText1";
            this.numText1.Size = new System.Drawing.Size(37, 22);
            this.numText1.TabIndex = 0;
            this.numText1.Text = "0";
            this.numText1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numText2
            // 
            this.numText2.Location = new System.Drawing.Point(64, 32);
            this.numText2.Name = "numText2";
            this.numText2.Size = new System.Drawing.Size(37, 22);
            this.numText2.TabIndex = 1;
            this.numText2.Text = "0";
            this.numText2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numText3
            // 
            this.numText3.Location = new System.Drawing.Point(117, 32);
            this.numText3.Name = "numText3";
            this.numText3.Size = new System.Drawing.Size(37, 22);
            this.numText3.TabIndex = 2;
            this.numText3.Text = "0";
            this.numText3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numText4
            // 
            this.numText4.Location = new System.Drawing.Point(172, 32);
            this.numText4.Name = "numText4";
            this.numText4.Size = new System.Drawing.Size(37, 22);
            this.numText4.TabIndex = 3;
            this.numText4.Text = "0";
            this.numText4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numText5
            // 
            this.numText5.Location = new System.Drawing.Point(225, 32);
            this.numText5.Name = "numText5";
            this.numText5.Size = new System.Drawing.Size(37, 22);
            this.numText5.TabIndex = 4;
            this.numText5.Text = "0";
            this.numText5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numText6
            // 
            this.numText6.Location = new System.Drawing.Point(279, 32);
            this.numText6.Name = "numText6";
            this.numText6.Size = new System.Drawing.Size(37, 22);
            this.numText6.TabIndex = 5;
            this.numText6.Text = "0";
            this.numText6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numText7
            // 
            this.numText7.Location = new System.Drawing.Point(331, 32);
            this.numText7.Name = "numText7";
            this.numText7.Size = new System.Drawing.Size(37, 22);
            this.numText7.TabIndex = 6;
            this.numText7.Text = "0";
            this.numText7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numText8
            // 
            this.numText8.Location = new System.Drawing.Point(385, 32);
            this.numText8.Name = "numText8";
            this.numText8.Size = new System.Drawing.Size(37, 22);
            this.numText8.TabIndex = 7;
            this.numText8.Text = "0";
            this.numText8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(438, 30);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 8;
            this.startButton.Text = "開始排序";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 80);
            this.Controls.Add(this.startButton);
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
            this.Text = "氣泡排序法演示";
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
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer1;
    }
}

