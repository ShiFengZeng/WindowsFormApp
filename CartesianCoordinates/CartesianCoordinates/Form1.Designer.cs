namespace CartesianCoordinates
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
            this.x1Text = new System.Windows.Forms.TextBox();
            this.y1Text = new System.Windows.Forms.TextBox();
            this.x2Text = new System.Windows.Forms.TextBox();
            this.y2Text = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.xLine = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.yLine = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.aLine = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // x1Text
            // 
            this.x1Text.Location = new System.Drawing.Point(13, 13);
            this.x1Text.Name = "x1Text";
            this.x1Text.Size = new System.Drawing.Size(32, 22);
            this.x1Text.TabIndex = 0;
            // 
            // y1Text
            // 
            this.y1Text.Location = new System.Drawing.Point(51, 13);
            this.y1Text.Name = "y1Text";
            this.y1Text.Size = new System.Drawing.Size(32, 22);
            this.y1Text.TabIndex = 1;
            // 
            // x2Text
            // 
            this.x2Text.Location = new System.Drawing.Point(13, 41);
            this.x2Text.Name = "x2Text";
            this.x2Text.Size = new System.Drawing.Size(32, 22);
            this.x2Text.TabIndex = 2;
            // 
            // y2Text
            // 
            this.y2Text.Location = new System.Drawing.Point(51, 41);
            this.y2Text.Name = "y2Text";
            this.y2Text.Size = new System.Drawing.Size(32, 22);
            this.y2Text.TabIndex = 3;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(13, 70);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(70, 23);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "繪圖";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.aLine,
            this.yLine,
            this.xLine});
            this.shapeContainer1.Size = new System.Drawing.Size(323, 289);
            this.shapeContainer1.TabIndex = 5;
            this.shapeContainer1.TabStop = false;
            // 
            // xLine
            // 
            this.xLine.Name = "xLine";
            this.xLine.X1 = 27;
            this.xLine.X2 = 64;
            this.xLine.Y1 = 122;
            this.xLine.Y2 = 134;
            // 
            // yLine
            // 
            this.yLine.Name = "yLine";
            this.yLine.X1 = 25;
            this.yLine.X2 = 62;
            this.yLine.Y1 = 147;
            this.yLine.Y2 = 159;
            // 
            // aLine
            // 
            this.aLine.Name = "aLine";
            this.aLine.X1 = 24;
            this.aLine.X2 = 61;
            this.aLine.Y1 = 169;
            this.aLine.Y2 = 181;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 289);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.y2Text);
            this.Controls.Add(this.x2Text);
            this.Controls.Add(this.y1Text);
            this.Controls.Add(this.x1Text);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "直角座標圖";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox x1Text;
        private System.Windows.Forms.TextBox y1Text;
        private System.Windows.Forms.TextBox x2Text;
        private System.Windows.Forms.TextBox y2Text;
        private System.Windows.Forms.Button startButton;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape aLine;
        private Microsoft.VisualBasic.PowerPacks.LineShape yLine;
        private Microsoft.VisualBasic.PowerPacks.LineShape xLine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

