namespace GcdLcm
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
            this.computeButton = new System.Windows.Forms.Button();
            this.integerLabel1 = new System.Windows.Forms.Label();
            this.integerLabel2 = new System.Windows.Forms.Label();
            this.gcdLabel = new System.Windows.Forms.Label();
            this.lcmLebel = new System.Windows.Forms.Label();
            this.integerText1 = new System.Windows.Forms.TextBox();
            this.integerText2 = new System.Windows.Forms.TextBox();
            this.gcdText = new System.Windows.Forms.TextBox();
            this.lcmText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // computeButton
            // 
            this.computeButton.Location = new System.Drawing.Point(39, 95);
            this.computeButton.Name = "computeButton";
            this.computeButton.Size = new System.Drawing.Size(290, 23);
            this.computeButton.TabIndex = 0;
            this.computeButton.Text = "計算！";
            this.computeButton.UseVisualStyleBackColor = true;
            this.computeButton.Click += new System.EventHandler(this.computeButton_Click);
            // 
            // integerLabel1
            // 
            this.integerLabel1.AutoSize = true;
            this.integerLabel1.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.integerLabel1.Location = new System.Drawing.Point(56, 55);
            this.integerLabel1.Name = "integerLabel1";
            this.integerLabel1.Size = new System.Drawing.Size(52, 13);
            this.integerLabel1.TabIndex = 1;
            this.integerLabel1.Text = "正整數1";
            // 
            // integerLabel2
            // 
            this.integerLabel2.AutoSize = true;
            this.integerLabel2.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.integerLabel2.Location = new System.Drawing.Point(208, 55);
            this.integerLabel2.Name = "integerLabel2";
            this.integerLabel2.Size = new System.Drawing.Size(52, 13);
            this.integerLabel2.TabIndex = 2;
            this.integerLabel2.Text = "正整數2";
            // 
            // gcdLabel
            // 
            this.gcdLabel.AutoSize = true;
            this.gcdLabel.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gcdLabel.Location = new System.Drawing.Point(36, 149);
            this.gcdLabel.Name = "gcdLabel";
            this.gcdLabel.Size = new System.Drawing.Size(72, 13);
            this.gcdLabel.TabIndex = 3;
            this.gcdLabel.Text = "最大公因數";
            // 
            // lcmLebel
            // 
            this.lcmLebel.AutoSize = true;
            this.lcmLebel.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lcmLebel.Location = new System.Drawing.Point(194, 149);
            this.lcmLebel.Name = "lcmLebel";
            this.lcmLebel.Size = new System.Drawing.Size(72, 13);
            this.lcmLebel.TabIndex = 4;
            this.lcmLebel.Text = "最小公倍數";
            // 
            // integerText1
            // 
            this.integerText1.Location = new System.Drawing.Point(114, 52);
            this.integerText1.Name = "integerText1";
            this.integerText1.Size = new System.Drawing.Size(63, 22);
            this.integerText1.TabIndex = 5;
            this.integerText1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.integerText1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.integerText1_KeyPress);
            // 
            // integerText2
            // 
            this.integerText2.Location = new System.Drawing.Point(266, 52);
            this.integerText2.Name = "integerText2";
            this.integerText2.Size = new System.Drawing.Size(63, 22);
            this.integerText2.TabIndex = 6;
            this.integerText2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.integerText2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.integerText2_KeyPress);
            // 
            // gcdText
            // 
            this.gcdText.Location = new System.Drawing.Point(114, 146);
            this.gcdText.Name = "gcdText";
            this.gcdText.Size = new System.Drawing.Size(63, 22);
            this.gcdText.TabIndex = 7;
            this.gcdText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lcmText
            // 
            this.lcmText.Location = new System.Drawing.Point(266, 146);
            this.lcmText.Name = "lcmText";
            this.lcmText.Size = new System.Drawing.Size(63, 22);
            this.lcmText.TabIndex = 8;
            this.lcmText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 218);
            this.Controls.Add(this.lcmText);
            this.Controls.Add(this.gcdText);
            this.Controls.Add(this.integerText2);
            this.Controls.Add(this.integerText1);
            this.Controls.Add(this.lcmLebel);
            this.Controls.Add(this.gcdLabel);
            this.Controls.Add(this.integerLabel2);
            this.Controls.Add(this.integerLabel1);
            this.Controls.Add(this.computeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "求最大公因數和最小公倍數";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button computeButton;
        private System.Windows.Forms.Label integerLabel1;
        private System.Windows.Forms.Label integerLabel2;
        private System.Windows.Forms.Label gcdLabel;
        private System.Windows.Forms.Label lcmLebel;
        private System.Windows.Forms.TextBox integerText1;
        private System.Windows.Forms.TextBox integerText2;
        private System.Windows.Forms.TextBox gcdText;
        private System.Windows.Forms.TextBox lcmText;
    }
}

