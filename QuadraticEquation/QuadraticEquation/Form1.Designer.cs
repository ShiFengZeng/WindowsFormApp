namespace QuadraticEquation
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
            this.xSquare = new System.Windows.Forms.TextBox();
            this.x = new System.Windows.Forms.TextBox();
            this.constant = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.computeButton = new System.Windows.Forms.Button();
            this.xSquareLabel = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.zeroLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // xSquare
            // 
            this.xSquare.Location = new System.Drawing.Point(12, 37);
            this.xSquare.Name = "xSquare";
            this.xSquare.Size = new System.Drawing.Size(100, 22);
            this.xSquare.TabIndex = 0;
            this.xSquare.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.xSquare_KeyPress);
            // 
            // x
            // 
            this.x.Location = new System.Drawing.Point(157, 37);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(100, 22);
            this.x.TabIndex = 1;
            this.x.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.x_KeyPress);
            // 
            // constant
            // 
            this.constant.Location = new System.Drawing.Point(291, 37);
            this.constant.Name = "constant";
            this.constant.Size = new System.Drawing.Size(100, 22);
            this.constant.TabIndex = 2;
            this.constant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.constant_KeyPress);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(134, 105);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(283, 22);
            this.result.TabIndex = 3;
            // 
            // computeButton
            // 
            this.computeButton.Location = new System.Drawing.Point(12, 103);
            this.computeButton.Name = "computeButton";
            this.computeButton.Size = new System.Drawing.Size(100, 23);
            this.computeButton.TabIndex = 4;
            this.computeButton.Text = "計算結果";
            this.computeButton.UseVisualStyleBackColor = true;
            this.computeButton.Click += new System.EventHandler(this.computeButton_Click);
            // 
            // xSquareLabel
            // 
            this.xSquareLabel.AutoSize = true;
            this.xSquareLabel.Location = new System.Drawing.Point(118, 40);
            this.xSquareLabel.Name = "xSquareLabel";
            this.xSquareLabel.Size = new System.Drawing.Size(33, 12);
            this.xSquareLabel.TabIndex = 5;
            this.xSquareLabel.Text = "X^2 +";
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(263, 40);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(22, 12);
            this.xLabel.TabIndex = 6;
            this.xLabel.Text = "X +";
            // 
            // zeroLabel
            // 
            this.zeroLabel.AutoSize = true;
            this.zeroLabel.Location = new System.Drawing.Point(397, 40);
            this.zeroLabel.Name = "zeroLabel";
            this.zeroLabel.Size = new System.Drawing.Size(20, 12);
            this.zeroLabel.TabIndex = 7;
            this.zeroLabel.Text = "= 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 164);
            this.Controls.Add(this.zeroLabel);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.xSquareLabel);
            this.Controls.Add(this.computeButton);
            this.Controls.Add(this.result);
            this.Controls.Add(this.constant);
            this.Controls.Add(this.x);
            this.Controls.Add(this.xSquare);
            this.Name = "Form1";
            this.Text = "一元二次方程式求解";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox xSquare;
        private System.Windows.Forms.TextBox x;
        private System.Windows.Forms.TextBox constant;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button computeButton;
        private System.Windows.Forms.Label xSquareLabel;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label zeroLabel;
    }
}

