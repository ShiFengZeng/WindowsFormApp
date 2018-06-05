namespace Calculator
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
            this.addButton = new System.Windows.Forms.Button();
            this.subButton = new System.Windows.Forms.Button();
            this.mulButton = new System.Windows.Forms.Button();
            this.divButton = new System.Windows.Forms.Button();
            this.eqlButton = new System.Windows.Forms.Button();
            this.noteqlButton = new System.Windows.Forms.Button();
            this.biggerButton = new System.Windows.Forms.Button();
            this.smallerButton = new System.Windows.Forms.Button();
            this.Val1 = new System.Windows.Forms.TextBox();
            this.Val2 = new System.Windows.Forms.TextBox();
            this.resultVal = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(13, 99);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // subButton
            // 
            this.subButton.Location = new System.Drawing.Point(94, 99);
            this.subButton.Name = "subButton";
            this.subButton.Size = new System.Drawing.Size(75, 23);
            this.subButton.TabIndex = 1;
            this.subButton.Text = "-";
            this.subButton.UseVisualStyleBackColor = true;
            this.subButton.Click += new System.EventHandler(this.subButton_Click);
            // 
            // mulButton
            // 
            this.mulButton.Location = new System.Drawing.Point(175, 99);
            this.mulButton.Name = "mulButton";
            this.mulButton.Size = new System.Drawing.Size(75, 23);
            this.mulButton.TabIndex = 2;
            this.mulButton.Text = "*";
            this.mulButton.UseVisualStyleBackColor = true;
            this.mulButton.Click += new System.EventHandler(this.mulButton_Click);
            // 
            // divButton
            // 
            this.divButton.Location = new System.Drawing.Point(256, 99);
            this.divButton.Name = "divButton";
            this.divButton.Size = new System.Drawing.Size(75, 23);
            this.divButton.TabIndex = 3;
            this.divButton.Text = "/";
            this.divButton.UseVisualStyleBackColor = true;
            this.divButton.Click += new System.EventHandler(this.divButton_Click);
            // 
            // eqlButton
            // 
            this.eqlButton.Location = new System.Drawing.Point(13, 139);
            this.eqlButton.Name = "eqlButton";
            this.eqlButton.Size = new System.Drawing.Size(75, 23);
            this.eqlButton.TabIndex = 4;
            this.eqlButton.Text = "==?";
            this.eqlButton.UseVisualStyleBackColor = true;
            this.eqlButton.Click += new System.EventHandler(this.eqlButton_Click);
            // 
            // noteqlButton
            // 
            this.noteqlButton.Location = new System.Drawing.Point(94, 139);
            this.noteqlButton.Name = "noteqlButton";
            this.noteqlButton.Size = new System.Drawing.Size(75, 23);
            this.noteqlButton.TabIndex = 5;
            this.noteqlButton.Text = "!=?";
            this.noteqlButton.UseVisualStyleBackColor = true;
            this.noteqlButton.Click += new System.EventHandler(this.noteqlButton_Click);
            // 
            // biggerButton
            // 
            this.biggerButton.Location = new System.Drawing.Point(175, 139);
            this.biggerButton.Name = "biggerButton";
            this.biggerButton.Size = new System.Drawing.Size(75, 23);
            this.biggerButton.TabIndex = 6;
            this.biggerButton.Text = ">?";
            this.biggerButton.UseVisualStyleBackColor = true;
            this.biggerButton.Click += new System.EventHandler(this.biggerButton_Click);
            // 
            // smallerButton
            // 
            this.smallerButton.Location = new System.Drawing.Point(256, 139);
            this.smallerButton.Name = "smallerButton";
            this.smallerButton.Size = new System.Drawing.Size(75, 23);
            this.smallerButton.TabIndex = 7;
            this.smallerButton.Text = "<?";
            this.smallerButton.UseVisualStyleBackColor = true;
            this.smallerButton.Click += new System.EventHandler(this.smallerButton_Click);
            // 
            // Val1
            // 
            this.Val1.Location = new System.Drawing.Point(13, 44);
            this.Val1.Name = "Val1";
            this.Val1.Size = new System.Drawing.Size(156, 22);
            this.Val1.TabIndex = 8;
            // 
            // Val2
            // 
            this.Val2.Location = new System.Drawing.Point(177, 44);
            this.Val2.Name = "Val2";
            this.Val2.Size = new System.Drawing.Size(154, 22);
            this.Val2.TabIndex = 9;
            // 
            // resultVal
            // 
            this.resultVal.Location = new System.Drawing.Point(94, 178);
            this.resultVal.Name = "resultVal";
            this.resultVal.Size = new System.Drawing.Size(237, 22);
            this.resultVal.TabIndex = 10;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.resultLabel.Location = new System.Drawing.Point(21, 178);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(73, 21);
            this.resultLabel.TabIndex = 11;
            this.resultLabel.Text = "結果：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 220);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.resultVal);
            this.Controls.Add(this.Val2);
            this.Controls.Add(this.Val1);
            this.Controls.Add(this.smallerButton);
            this.Controls.Add(this.biggerButton);
            this.Controls.Add(this.noteqlButton);
            this.Controls.Add(this.eqlButton);
            this.Controls.Add(this.divButton);
            this.Controls.Add(this.mulButton);
            this.Controls.Add(this.subButton);
            this.Controls.Add(this.addButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "簡易計算機";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button subButton;
        private System.Windows.Forms.Button divButton;
        private System.Windows.Forms.Button eqlButton;
        private System.Windows.Forms.Button noteqlButton;
        private System.Windows.Forms.Button biggerButton;
        private System.Windows.Forms.Button smallerButton;
        private System.Windows.Forms.TextBox Val1;
        private System.Windows.Forms.TextBox Val2;
        private System.Windows.Forms.TextBox resultVal;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button mulButton;
    }
}

