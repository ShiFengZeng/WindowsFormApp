namespace Tower_of_Hanoi
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
            this.listA = new System.Windows.Forms.ListBox();
            this.listB = new System.Windows.Forms.ListBox();
            this.listC = new System.Windows.Forms.ListBox();
            this.moveList = new System.Windows.Forms.ListBox();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.moveLabel = new System.Windows.Forms.Label();
            this.numText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listA
            // 
            this.listA.FormattingEnabled = true;
            this.listA.ItemHeight = 12;
            this.listA.Location = new System.Drawing.Point(21, 34);
            this.listA.Name = "listA";
            this.listA.Size = new System.Drawing.Size(130, 304);
            this.listA.TabIndex = 0;
            // 
            // listB
            // 
            this.listB.FormattingEnabled = true;
            this.listB.ItemHeight = 12;
            this.listB.Location = new System.Drawing.Point(184, 34);
            this.listB.Name = "listB";
            this.listB.Size = new System.Drawing.Size(130, 304);
            this.listB.TabIndex = 1;
            // 
            // listC
            // 
            this.listC.FormattingEnabled = true;
            this.listC.ItemHeight = 12;
            this.listC.Location = new System.Drawing.Point(346, 34);
            this.listC.Name = "listC";
            this.listC.Size = new System.Drawing.Size(130, 304);
            this.listC.TabIndex = 2;
            // 
            // moveList
            // 
            this.moveList.FormattingEnabled = true;
            this.moveList.ItemHeight = 12;
            this.moveList.Location = new System.Drawing.Point(492, 141);
            this.moveList.Name = "moveList";
            this.moveList.Size = new System.Drawing.Size(130, 232);
            this.moveList.TabIndex = 3;
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(65, 345);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(13, 12);
            this.labelA.TabIndex = 4;
            this.labelA.Text = "A";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(231, 345);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(13, 12);
            this.labelB.TabIndex = 5;
            this.labelB.Text = "B";
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(401, 345);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(13, 12);
            this.labelC.TabIndex = 6;
            this.labelC.Text = "C";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(492, 73);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(130, 24);
            this.startButton.TabIndex = 7;
            this.startButton.Text = "開始演示";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // moveLabel
            // 
            this.moveLabel.AutoSize = true;
            this.moveLabel.Location = new System.Drawing.Point(490, 112);
            this.moveLabel.Name = "moveLabel";
            this.moveLabel.Size = new System.Drawing.Size(53, 12);
            this.moveLabel.TabIndex = 8;
            this.moveLabel.Text = "移動順序";
            // 
            // numText
            // 
            this.numText.Location = new System.Drawing.Point(492, 34);
            this.numText.Name = "numText";
            this.numText.Size = new System.Drawing.Size(130, 22);
            this.numText.TabIndex = 9;
            this.numText.Text = "0";
            this.numText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 385);
            this.Controls.Add(this.numText);
            this.Controls.Add(this.moveLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.moveList);
            this.Controls.Add(this.listC);
            this.Controls.Add(this.listB);
            this.Controls.Add(this.listA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "河內塔演示程式";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listA;
        private System.Windows.Forms.ListBox listB;
        private System.Windows.Forms.ListBox listC;
        private System.Windows.Forms.ListBox moveList;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label moveLabel;
        private System.Windows.Forms.TextBox numText;
    }
}

