namespace Arithmetic
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
            this.MulButon = new System.Windows.Forms.Button();
            this.divButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.opLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ansLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.Control;
            this.addButton.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.addButton.Location = new System.Drawing.Point(44, 143);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(69, 41);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // subButton
            // 
            this.subButton.BackColor = System.Drawing.SystemColors.Control;
            this.subButton.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.subButton.Location = new System.Drawing.Point(132, 143);
            this.subButton.Name = "subButton";
            this.subButton.Size = new System.Drawing.Size(69, 41);
            this.subButton.TabIndex = 1;
            this.subButton.Text = "-";
            this.subButton.UseVisualStyleBackColor = false;
            this.subButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // MulButon
            // 
            this.MulButon.BackColor = System.Drawing.SystemColors.Control;
            this.MulButon.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MulButon.Location = new System.Drawing.Point(223, 143);
            this.MulButon.Name = "MulButon";
            this.MulButon.Size = new System.Drawing.Size(69, 41);
            this.MulButon.TabIndex = 2;
            this.MulButon.Text = "*";
            this.MulButon.UseVisualStyleBackColor = false;
            this.MulButon.Click += new System.EventHandler(this.addButton_Click);
            // 
            // divButton
            // 
            this.divButton.BackColor = System.Drawing.SystemColors.Control;
            this.divButton.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.divButton.Location = new System.Drawing.Point(311, 143);
            this.divButton.Name = "divButton";
            this.divButton.Size = new System.Drawing.Size(69, 41);
            this.divButton.TabIndex = 3;
            this.divButton.Text = "/";
            this.divButton.UseVisualStyleBackColor = false;
            this.divButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(44, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(69, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // opLabel
            // 
            this.opLabel.AutoSize = true;
            this.opLabel.Location = new System.Drawing.Point(144, 77);
            this.opLabel.Name = "opLabel";
            this.opLabel.Size = new System.Drawing.Size(0, 12);
            this.opLabel.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "=";
            // 
            // ansLabel
            // 
            this.ansLabel.AutoSize = true;
            this.ansLabel.Location = new System.Drawing.Point(345, 76);
            this.ansLabel.Name = "ansLabel";
            this.ansLabel.Size = new System.Drawing.Size(0, 12);
            this.ansLabel.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(181, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(68, 22);
            this.textBox2.TabIndex = 8;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(44, 220);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(336, 37);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "結束";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 304);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.ansLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.opLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.divButton);
            this.Controls.Add(this.MulButon);
            this.Controls.Add(this.subButton);
            this.Controls.Add(this.addButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "四則運算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button subButton;
        private System.Windows.Forms.Button MulButon;
        private System.Windows.Forms.Button divButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label opLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ansLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button closeButton;
    }
}

