namespace TextMove
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
            this.northOption = new System.Windows.Forms.RadioButton();
            this.westOption = new System.Windows.Forms.RadioButton();
            this.eastOption = new System.Windows.Forms.RadioButton();
            this.southOption = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fastOption = new System.Windows.Forms.RadioButton();
            this.mediumOption = new System.Windows.Forms.RadioButton();
            this.slowOption = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.carLabel = new System.Windows.Forms.Label();
            this.toggleButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // northOption
            // 
            this.northOption.AutoSize = true;
            this.northOption.Location = new System.Drawing.Point(38, 24);
            this.northOption.Name = "northOption";
            this.northOption.Size = new System.Drawing.Size(35, 16);
            this.northOption.TabIndex = 0;
            this.northOption.TabStop = true;
            this.northOption.Text = "北";
            this.northOption.UseVisualStyleBackColor = true;
            // 
            // westOption
            // 
            this.westOption.AutoSize = true;
            this.westOption.Location = new System.Drawing.Point(14, 46);
            this.westOption.Name = "westOption";
            this.westOption.Size = new System.Drawing.Size(35, 16);
            this.westOption.TabIndex = 1;
            this.westOption.TabStop = true;
            this.westOption.Text = "西";
            this.westOption.UseVisualStyleBackColor = true;
            // 
            // eastOption
            // 
            this.eastOption.AutoSize = true;
            this.eastOption.Location = new System.Drawing.Point(64, 46);
            this.eastOption.Name = "eastOption";
            this.eastOption.Size = new System.Drawing.Size(35, 16);
            this.eastOption.TabIndex = 2;
            this.eastOption.TabStop = true;
            this.eastOption.Text = "東";
            this.eastOption.UseVisualStyleBackColor = true;
            // 
            // southOption
            // 
            this.southOption.AutoSize = true;
            this.southOption.Cursor = System.Windows.Forms.Cursors.Default;
            this.southOption.Location = new System.Drawing.Point(38, 68);
            this.southOption.Name = "southOption";
            this.southOption.Size = new System.Drawing.Size(35, 16);
            this.southOption.TabIndex = 3;
            this.southOption.TabStop = true;
            this.southOption.Text = "南";
            this.southOption.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.eastOption);
            this.groupBox1.Controls.Add(this.southOption);
            this.groupBox1.Controls.Add(this.northOption);
            this.groupBox1.Controls.Add(this.westOption);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(114, 103);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "移動方向";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fastOption);
            this.groupBox2.Controls.Add(this.mediumOption);
            this.groupBox2.Controls.Add(this.slowOption);
            this.groupBox2.Location = new System.Drawing.Point(12, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(125, 95);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "速度";
            // 
            // fastOption
            // 
            this.fastOption.AutoSize = true;
            this.fastOption.Location = new System.Drawing.Point(14, 67);
            this.fastOption.Name = "fastOption";
            this.fastOption.Size = new System.Drawing.Size(47, 16);
            this.fastOption.TabIndex = 2;
            this.fastOption.TabStop = true;
            this.fastOption.Text = "快速";
            this.fastOption.UseVisualStyleBackColor = true;
            this.fastOption.Click += new System.EventHandler(this.fastOption_Click);
            // 
            // mediumOption
            // 
            this.mediumOption.AutoSize = true;
            this.mediumOption.Location = new System.Drawing.Point(14, 45);
            this.mediumOption.Name = "mediumOption";
            this.mediumOption.Size = new System.Drawing.Size(47, 16);
            this.mediumOption.TabIndex = 1;
            this.mediumOption.TabStop = true;
            this.mediumOption.Text = "中速";
            this.mediumOption.UseVisualStyleBackColor = true;
            this.mediumOption.Click += new System.EventHandler(this.mediumOption_Click);
            // 
            // slowOption
            // 
            this.slowOption.AutoSize = true;
            this.slowOption.Location = new System.Drawing.Point(14, 22);
            this.slowOption.Name = "slowOption";
            this.slowOption.Size = new System.Drawing.Size(47, 16);
            this.slowOption.TabIndex = 0;
            this.slowOption.TabStop = true;
            this.slowOption.Text = "慢速";
            this.slowOption.UseVisualStyleBackColor = true;
            this.slowOption.Click += new System.EventHandler(this.slowOption_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // carLabel
            // 
            this.carLabel.AutoSize = true;
            this.carLabel.Location = new System.Drawing.Point(161, 107);
            this.carLabel.Name = "carLabel";
            this.carLabel.Size = new System.Drawing.Size(17, 12);
            this.carLabel.TabIndex = 6;
            this.carLabel.Text = "車";
            // 
            // toggleButton
            // 
            this.toggleButton.Location = new System.Drawing.Point(12, 262);
            this.toggleButton.Name = "toggleButton";
            this.toggleButton.Size = new System.Drawing.Size(125, 23);
            this.toggleButton.TabIndex = 7;
            this.toggleButton.Text = "開始移動";
            this.toggleButton.UseVisualStyleBackColor = true;
            this.toggleButton.Click += new System.EventHandler(this.toggleButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.carLabel);
            this.groupBox3.Location = new System.Drawing.Point(186, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(357, 253);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "畫面";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 321);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.toggleButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文字方塊移動程式";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton northOption;
        private System.Windows.Forms.RadioButton westOption;
        private System.Windows.Forms.RadioButton eastOption;
        private System.Windows.Forms.RadioButton southOption;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton fastOption;
        private System.Windows.Forms.RadioButton mediumOption;
        private System.Windows.Forms.RadioButton slowOption;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label carLabel;
        private System.Windows.Forms.Button toggleButton;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

