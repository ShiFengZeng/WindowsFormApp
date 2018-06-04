namespace _3x3_Matrix_Multiply
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
            this.m1Label = new System.Windows.Forms.Label();
            this.muLabel = new System.Windows.Forms.Label();
            this.m2Label = new System.Windows.Forms.Label();
            this.mrLabel = new System.Windows.Forms.Label();
            this.calButton = new System.Windows.Forms.Button();
            this.m1Text1 = new System.Windows.Forms.TextBox();
            this.m1Text2 = new System.Windows.Forms.TextBox();
            this.m1Text3 = new System.Windows.Forms.TextBox();
            this.m1Text4 = new System.Windows.Forms.TextBox();
            this.m1Text5 = new System.Windows.Forms.TextBox();
            this.m1Text6 = new System.Windows.Forms.TextBox();
            this.m1Text7 = new System.Windows.Forms.TextBox();
            this.m1Text8 = new System.Windows.Forms.TextBox();
            this.m1Text9 = new System.Windows.Forms.TextBox();
            this.m2Text1 = new System.Windows.Forms.TextBox();
            this.m2Text2 = new System.Windows.Forms.TextBox();
            this.m2Text3 = new System.Windows.Forms.TextBox();
            this.m2Text4 = new System.Windows.Forms.TextBox();
            this.m2Text5 = new System.Windows.Forms.TextBox();
            this.m2Text6 = new System.Windows.Forms.TextBox();
            this.m2Text7 = new System.Windows.Forms.TextBox();
            this.m2Text8 = new System.Windows.Forms.TextBox();
            this.m2Text9 = new System.Windows.Forms.TextBox();
            this.mrText1 = new System.Windows.Forms.TextBox();
            this.mrText2 = new System.Windows.Forms.TextBox();
            this.mrText3 = new System.Windows.Forms.TextBox();
            this.mrText4 = new System.Windows.Forms.TextBox();
            this.mrText5 = new System.Windows.Forms.TextBox();
            this.mrText6 = new System.Windows.Forms.TextBox();
            this.mrText7 = new System.Windows.Forms.TextBox();
            this.mrText8 = new System.Windows.Forms.TextBox();
            this.mrText9 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // m1Label
            // 
            this.m1Label.AutoSize = true;
            this.m1Label.Location = new System.Drawing.Point(13, 22);
            this.m1Label.Name = "m1Label";
            this.m1Label.Size = new System.Drawing.Size(41, 12);
            this.m1Label.TabIndex = 0;
            this.m1Label.Text = "矩陣一";
            // 
            // muLabel
            // 
            this.muLabel.AutoSize = true;
            this.muLabel.Location = new System.Drawing.Point(144, 93);
            this.muLabel.Name = "muLabel";
            this.muLabel.Size = new System.Drawing.Size(13, 12);
            this.muLabel.TabIndex = 1;
            this.muLabel.Text = "X";
            // 
            // m2Label
            // 
            this.m2Label.AutoSize = true;
            this.m2Label.Location = new System.Drawing.Point(186, 22);
            this.m2Label.Name = "m2Label";
            this.m2Label.Size = new System.Drawing.Size(41, 12);
            this.m2Label.TabIndex = 2;
            this.m2Label.Text = "矩陣二";
            // 
            // mrLabel
            // 
            this.mrLabel.AutoSize = true;
            this.mrLabel.Location = new System.Drawing.Point(392, 22);
            this.mrLabel.Name = "mrLabel";
            this.mrLabel.Size = new System.Drawing.Size(53, 12);
            this.mrLabel.TabIndex = 3;
            this.mrLabel.Text = "結果矩陣";
            // 
            // calButton
            // 
            this.calButton.Location = new System.Drawing.Point(313, 87);
            this.calButton.Name = "calButton";
            this.calButton.Size = new System.Drawing.Size(63, 23);
            this.calButton.TabIndex = 4;
            this.calButton.Text = "=";
            this.calButton.UseVisualStyleBackColor = true;
            this.calButton.Click += new System.EventHandler(this.calButton_Click);
            // 
            // m1Text1
            // 
            this.m1Text1.Location = new System.Drawing.Point(15, 61);
            this.m1Text1.Name = "m1Text1";
            this.m1Text1.Size = new System.Drawing.Size(31, 22);
            this.m1Text1.TabIndex = 5;
            this.m1Text1.Text = "0";
            this.m1Text1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m1Text1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.m1Text1_KeyDown);
            this.m1Text1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.m1Text1_KeyPress);
            // 
            // m1Text2
            // 
            this.m1Text2.Location = new System.Drawing.Point(52, 61);
            this.m1Text2.Name = "m1Text2";
            this.m1Text2.Size = new System.Drawing.Size(31, 22);
            this.m1Text2.TabIndex = 6;
            this.m1Text2.Text = "0";
            this.m1Text2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m1Text2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.m1Text1_KeyDown);
            this.m1Text2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.m1Text1_KeyPress);
            // 
            // m1Text3
            // 
            this.m1Text3.Location = new System.Drawing.Point(89, 61);
            this.m1Text3.Name = "m1Text3";
            this.m1Text3.Size = new System.Drawing.Size(31, 22);
            this.m1Text3.TabIndex = 7;
            this.m1Text3.Text = "0";
            this.m1Text3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m1Text3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.m1Text1_KeyDown);
            this.m1Text3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.m1Text1_KeyPress);
            // 
            // m1Text4
            // 
            this.m1Text4.Location = new System.Drawing.Point(15, 89);
            this.m1Text4.Name = "m1Text4";
            this.m1Text4.Size = new System.Drawing.Size(31, 22);
            this.m1Text4.TabIndex = 8;
            this.m1Text4.Text = "0";
            this.m1Text4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m1Text4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.m1Text1_KeyDown);
            this.m1Text4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.m1Text1_KeyPress);
            // 
            // m1Text5
            // 
            this.m1Text5.Location = new System.Drawing.Point(52, 89);
            this.m1Text5.Name = "m1Text5";
            this.m1Text5.Size = new System.Drawing.Size(31, 22);
            this.m1Text5.TabIndex = 9;
            this.m1Text5.Text = "0";
            this.m1Text5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m1Text5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.m1Text1_KeyDown);
            this.m1Text5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.m1Text1_KeyPress);
            // 
            // m1Text6
            // 
            this.m1Text6.Location = new System.Drawing.Point(89, 89);
            this.m1Text6.Name = "m1Text6";
            this.m1Text6.Size = new System.Drawing.Size(31, 22);
            this.m1Text6.TabIndex = 10;
            this.m1Text6.Text = "0";
            this.m1Text6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m1Text6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.m1Text1_KeyDown);
            this.m1Text6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.m1Text1_KeyPress);
            // 
            // m1Text7
            // 
            this.m1Text7.Location = new System.Drawing.Point(15, 118);
            this.m1Text7.Name = "m1Text7";
            this.m1Text7.Size = new System.Drawing.Size(31, 22);
            this.m1Text7.TabIndex = 11;
            this.m1Text7.Text = "0";
            this.m1Text7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m1Text7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.m1Text1_KeyDown);
            this.m1Text7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.m1Text1_KeyPress);
            // 
            // m1Text8
            // 
            this.m1Text8.Location = new System.Drawing.Point(52, 118);
            this.m1Text8.Name = "m1Text8";
            this.m1Text8.Size = new System.Drawing.Size(31, 22);
            this.m1Text8.TabIndex = 12;
            this.m1Text8.Text = "0";
            this.m1Text8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m1Text8.KeyDown += new System.Windows.Forms.KeyEventHandler(this.m1Text1_KeyDown);
            this.m1Text8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.m1Text1_KeyPress);
            // 
            // m1Text9
            // 
            this.m1Text9.Location = new System.Drawing.Point(89, 118);
            this.m1Text9.Name = "m1Text9";
            this.m1Text9.Size = new System.Drawing.Size(31, 22);
            this.m1Text9.TabIndex = 13;
            this.m1Text9.Text = "0";
            this.m1Text9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m1Text9.KeyDown += new System.Windows.Forms.KeyEventHandler(this.m1Text1_KeyDown);
            this.m1Text9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.m1Text1_KeyPress);
            // 
            // m2Text1
            // 
            this.m2Text1.Location = new System.Drawing.Point(188, 61);
            this.m2Text1.Name = "m2Text1";
            this.m2Text1.Size = new System.Drawing.Size(31, 22);
            this.m2Text1.TabIndex = 14;
            this.m2Text1.Text = "0";
            this.m2Text1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m2Text1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.m1Text1_KeyDown);
            this.m2Text1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.m1Text1_KeyPress);
            // 
            // m2Text2
            // 
            this.m2Text2.Location = new System.Drawing.Point(225, 61);
            this.m2Text2.Name = "m2Text2";
            this.m2Text2.Size = new System.Drawing.Size(31, 22);
            this.m2Text2.TabIndex = 15;
            this.m2Text2.Text = "0";
            this.m2Text2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m2Text2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.m1Text1_KeyDown);
            this.m2Text2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.m1Text1_KeyPress);
            // 
            // m2Text3
            // 
            this.m2Text3.Location = new System.Drawing.Point(262, 61);
            this.m2Text3.Name = "m2Text3";
            this.m2Text3.Size = new System.Drawing.Size(31, 22);
            this.m2Text3.TabIndex = 16;
            this.m2Text3.Text = "0";
            this.m2Text3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m2Text3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.m1Text1_KeyDown);
            this.m2Text3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.m1Text1_KeyPress);
            // 
            // m2Text4
            // 
            this.m2Text4.Location = new System.Drawing.Point(188, 89);
            this.m2Text4.Name = "m2Text4";
            this.m2Text4.Size = new System.Drawing.Size(31, 22);
            this.m2Text4.TabIndex = 17;
            this.m2Text4.Text = "0";
            this.m2Text4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m2Text4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.m1Text1_KeyDown);
            this.m2Text4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.m1Text1_KeyPress);
            // 
            // m2Text5
            // 
            this.m2Text5.Location = new System.Drawing.Point(225, 89);
            this.m2Text5.Name = "m2Text5";
            this.m2Text5.Size = new System.Drawing.Size(31, 22);
            this.m2Text5.TabIndex = 18;
            this.m2Text5.Text = "0";
            this.m2Text5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m2Text5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.m1Text1_KeyDown);
            this.m2Text5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.m1Text1_KeyPress);
            // 
            // m2Text6
            // 
            this.m2Text6.Location = new System.Drawing.Point(262, 89);
            this.m2Text6.Name = "m2Text6";
            this.m2Text6.Size = new System.Drawing.Size(31, 22);
            this.m2Text6.TabIndex = 19;
            this.m2Text6.Text = "0";
            this.m2Text6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m2Text6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.m1Text1_KeyDown);
            this.m2Text6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.m1Text1_KeyPress);
            // 
            // m2Text7
            // 
            this.m2Text7.Location = new System.Drawing.Point(188, 118);
            this.m2Text7.Name = "m2Text7";
            this.m2Text7.Size = new System.Drawing.Size(31, 22);
            this.m2Text7.TabIndex = 20;
            this.m2Text7.Text = "0";
            this.m2Text7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m2Text7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.m1Text1_KeyDown);
            this.m2Text7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.m1Text1_KeyPress);
            // 
            // m2Text8
            // 
            this.m2Text8.Location = new System.Drawing.Point(225, 118);
            this.m2Text8.Name = "m2Text8";
            this.m2Text8.Size = new System.Drawing.Size(31, 22);
            this.m2Text8.TabIndex = 21;
            this.m2Text8.Text = "0";
            this.m2Text8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m2Text8.KeyDown += new System.Windows.Forms.KeyEventHandler(this.m1Text1_KeyDown);
            this.m2Text8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.m1Text1_KeyPress);
            // 
            // m2Text9
            // 
            this.m2Text9.Location = new System.Drawing.Point(262, 117);
            this.m2Text9.Name = "m2Text9";
            this.m2Text9.Size = new System.Drawing.Size(31, 22);
            this.m2Text9.TabIndex = 22;
            this.m2Text9.Text = "0";
            this.m2Text9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m2Text9.KeyDown += new System.Windows.Forms.KeyEventHandler(this.m1Text1_KeyDown);
            this.m2Text9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.m1Text1_KeyPress);
            // 
            // mrText1
            // 
            this.mrText1.Enabled = false;
            this.mrText1.Location = new System.Drawing.Point(394, 61);
            this.mrText1.Name = "mrText1";
            this.mrText1.Size = new System.Drawing.Size(31, 22);
            this.mrText1.TabIndex = 23;
            this.mrText1.Text = "0";
            this.mrText1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mrText2
            // 
            this.mrText2.Enabled = false;
            this.mrText2.Location = new System.Drawing.Point(431, 61);
            this.mrText2.Name = "mrText2";
            this.mrText2.Size = new System.Drawing.Size(31, 22);
            this.mrText2.TabIndex = 24;
            this.mrText2.Text = "0";
            this.mrText2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mrText3
            // 
            this.mrText3.Enabled = false;
            this.mrText3.Location = new System.Drawing.Point(468, 61);
            this.mrText3.Name = "mrText3";
            this.mrText3.Size = new System.Drawing.Size(31, 22);
            this.mrText3.TabIndex = 25;
            this.mrText3.Text = "0";
            this.mrText3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mrText4
            // 
            this.mrText4.Enabled = false;
            this.mrText4.Location = new System.Drawing.Point(394, 89);
            this.mrText4.Name = "mrText4";
            this.mrText4.Size = new System.Drawing.Size(31, 22);
            this.mrText4.TabIndex = 26;
            this.mrText4.Text = "0";
            this.mrText4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mrText5
            // 
            this.mrText5.Enabled = false;
            this.mrText5.Location = new System.Drawing.Point(431, 89);
            this.mrText5.Name = "mrText5";
            this.mrText5.Size = new System.Drawing.Size(31, 22);
            this.mrText5.TabIndex = 27;
            this.mrText5.Text = "0";
            this.mrText5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mrText6
            // 
            this.mrText6.Enabled = false;
            this.mrText6.Location = new System.Drawing.Point(468, 89);
            this.mrText6.Name = "mrText6";
            this.mrText6.Size = new System.Drawing.Size(31, 22);
            this.mrText6.TabIndex = 28;
            this.mrText6.Text = "0";
            this.mrText6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mrText7
            // 
            this.mrText7.Enabled = false;
            this.mrText7.Location = new System.Drawing.Point(394, 117);
            this.mrText7.Name = "mrText7";
            this.mrText7.Size = new System.Drawing.Size(31, 22);
            this.mrText7.TabIndex = 29;
            this.mrText7.Text = "0";
            this.mrText7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mrText8
            // 
            this.mrText8.Enabled = false;
            this.mrText8.Location = new System.Drawing.Point(431, 117);
            this.mrText8.Name = "mrText8";
            this.mrText8.Size = new System.Drawing.Size(31, 22);
            this.mrText8.TabIndex = 30;
            this.mrText8.Text = "0";
            this.mrText8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mrText9
            // 
            this.mrText9.Enabled = false;
            this.mrText9.Location = new System.Drawing.Point(468, 117);
            this.mrText9.Name = "mrText9";
            this.mrText9.Size = new System.Drawing.Size(31, 22);
            this.mrText9.TabIndex = 31;
            this.mrText9.Text = "0";
            this.mrText9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 163);
            this.Controls.Add(this.mrText9);
            this.Controls.Add(this.mrText8);
            this.Controls.Add(this.mrText7);
            this.Controls.Add(this.mrText6);
            this.Controls.Add(this.mrText5);
            this.Controls.Add(this.mrText4);
            this.Controls.Add(this.mrText3);
            this.Controls.Add(this.mrText2);
            this.Controls.Add(this.mrText1);
            this.Controls.Add(this.m2Text9);
            this.Controls.Add(this.m2Text8);
            this.Controls.Add(this.m2Text7);
            this.Controls.Add(this.m2Text6);
            this.Controls.Add(this.m2Text5);
            this.Controls.Add(this.m2Text4);
            this.Controls.Add(this.m2Text3);
            this.Controls.Add(this.m2Text2);
            this.Controls.Add(this.m2Text1);
            this.Controls.Add(this.m1Text9);
            this.Controls.Add(this.m1Text8);
            this.Controls.Add(this.m1Text7);
            this.Controls.Add(this.m1Text6);
            this.Controls.Add(this.m1Text5);
            this.Controls.Add(this.m1Text4);
            this.Controls.Add(this.m1Text3);
            this.Controls.Add(this.m1Text2);
            this.Controls.Add(this.m1Text1);
            this.Controls.Add(this.calButton);
            this.Controls.Add(this.mrLabel);
            this.Controls.Add(this.m2Label);
            this.Controls.Add(this.muLabel);
            this.Controls.Add(this.m1Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3x3矩陣相乘";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label m1Label;
        private System.Windows.Forms.Label muLabel;
        private System.Windows.Forms.Label m2Label;
        private System.Windows.Forms.Label mrLabel;
        private System.Windows.Forms.Button calButton;
        private System.Windows.Forms.TextBox m1Text1;
        private System.Windows.Forms.TextBox m1Text2;
        private System.Windows.Forms.TextBox m1Text3;
        private System.Windows.Forms.TextBox m1Text4;
        private System.Windows.Forms.TextBox m1Text5;
        private System.Windows.Forms.TextBox m1Text6;
        private System.Windows.Forms.TextBox m1Text7;
        private System.Windows.Forms.TextBox m1Text8;
        private System.Windows.Forms.TextBox m1Text9;
        private System.Windows.Forms.TextBox m2Text1;
        private System.Windows.Forms.TextBox m2Text2;
        private System.Windows.Forms.TextBox m2Text3;
        private System.Windows.Forms.TextBox m2Text4;
        private System.Windows.Forms.TextBox m2Text5;
        private System.Windows.Forms.TextBox m2Text6;
        private System.Windows.Forms.TextBox m2Text7;
        private System.Windows.Forms.TextBox m2Text8;
        private System.Windows.Forms.TextBox m2Text9;
        private System.Windows.Forms.TextBox mrText1;
        private System.Windows.Forms.TextBox mrText2;
        private System.Windows.Forms.TextBox mrText3;
        private System.Windows.Forms.TextBox mrText4;
        private System.Windows.Forms.TextBox mrText5;
        private System.Windows.Forms.TextBox mrText6;
        private System.Windows.Forms.TextBox mrText7;
        private System.Windows.Forms.TextBox mrText8;
        private System.Windows.Forms.TextBox mrText9;
    }
}

