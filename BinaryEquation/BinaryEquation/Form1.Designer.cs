namespace BinaryEquation
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.ansLabel = new System.Windows.Forms.Label();
            this.a1Text = new System.Windows.Forms.TextBox();
            this.b1Text = new System.Windows.Forms.TextBox();
            this.c1Text = new System.Windows.Forms.TextBox();
            this.a2Text = new System.Windows.Forms.TextBox();
            this.b2Text = new System.Windows.Forms.TextBox();
            this.c2Text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "X +";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "X +";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "Y =";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(83, 159);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(164, 23);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "求解";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // ansLabel
            // 
            this.ansLabel.AutoSize = true;
            this.ansLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ansLabel.Location = new System.Drawing.Point(29, 202);
            this.ansLabel.Name = "ansLabel";
            this.ansLabel.Size = new System.Drawing.Size(0, 16);
            this.ansLabel.TabIndex = 5;
            // 
            // a1Text
            // 
            this.a1Text.Location = new System.Drawing.Point(31, 42);
            this.a1Text.Name = "a1Text";
            this.a1Text.Size = new System.Drawing.Size(49, 22);
            this.a1Text.TabIndex = 6;
            this.a1Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // b1Text
            // 
            this.b1Text.Location = new System.Drawing.Point(130, 42);
            this.b1Text.Name = "b1Text";
            this.b1Text.Size = new System.Drawing.Size(49, 22);
            this.b1Text.TabIndex = 7;
            this.b1Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // c1Text
            // 
            this.c1Text.Location = new System.Drawing.Point(243, 42);
            this.c1Text.Name = "c1Text";
            this.c1Text.Size = new System.Drawing.Size(49, 22);
            this.c1Text.TabIndex = 8;
            this.c1Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // a2Text
            // 
            this.a2Text.Location = new System.Drawing.Point(31, 103);
            this.a2Text.Name = "a2Text";
            this.a2Text.Size = new System.Drawing.Size(49, 22);
            this.a2Text.TabIndex = 9;
            this.a2Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // b2Text
            // 
            this.b2Text.Location = new System.Drawing.Point(130, 103);
            this.b2Text.Name = "b2Text";
            this.b2Text.Size = new System.Drawing.Size(49, 22);
            this.b2Text.TabIndex = 10;
            this.b2Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // c2Text
            // 
            this.c2Text.Location = new System.Drawing.Point(243, 103);
            this.c2Text.Name = "c2Text";
            this.c2Text.Size = new System.Drawing.Size(49, 22);
            this.c2Text.TabIndex = 11;
            this.c2Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 254);
            this.Controls.Add(this.c2Text);
            this.Controls.Add(this.b2Text);
            this.Controls.Add(this.a2Text);
            this.Controls.Add(this.c1Text);
            this.Controls.Add(this.b1Text);
            this.Controls.Add(this.a1Text);
            this.Controls.Add(this.ansLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "二元一次方程式求解";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label ansLabel;
        private System.Windows.Forms.TextBox a1Text;
        private System.Windows.Forms.TextBox b1Text;
        private System.Windows.Forms.TextBox c1Text;
        private System.Windows.Forms.TextBox a2Text;
        private System.Windows.Forms.TextBox b2Text;
        private System.Windows.Forms.TextBox c2Text;
    }
}

