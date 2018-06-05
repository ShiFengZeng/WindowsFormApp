namespace TrafficLight
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
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.greenOval = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.yellowOval = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.redOval = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.redButton = new System.Windows.Forms.Button();
            this.yellowButton = new System.Windows.Forms.Button();
            this.greenButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.autoChangeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.greenOval,
            this.yellowOval,
            this.redOval});
            this.shapeContainer1.Size = new System.Drawing.Size(353, 265);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // greenOval
            // 
            this.greenOval.FillColor = System.Drawing.Color.Green;
            this.greenOval.Location = new System.Drawing.Point(245, 59);
            this.greenOval.Name = "greenOval";
            this.greenOval.Size = new System.Drawing.Size(75, 75);
            // 
            // yellowOval
            // 
            this.yellowOval.FillColor = System.Drawing.Color.Yellow;
            this.yellowOval.Location = new System.Drawing.Point(140, 59);
            this.yellowOval.Name = "yellowOval";
            this.yellowOval.Size = new System.Drawing.Size(75, 75);
            // 
            // redOval
            // 
            this.redOval.FillColor = System.Drawing.Color.Red;
            this.redOval.Location = new System.Drawing.Point(35, 59);
            this.redOval.Name = "redOval";
            this.redOval.Size = new System.Drawing.Size(75, 75);
            // 
            // redButton
            // 
            this.redButton.Location = new System.Drawing.Point(35, 169);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(75, 23);
            this.redButton.TabIndex = 1;
            this.redButton.Text = "紅燈";
            this.redButton.UseVisualStyleBackColor = true;
            this.redButton.Click += new System.EventHandler(this.redButton_Click);
            // 
            // yellowButton
            // 
            this.yellowButton.Location = new System.Drawing.Point(140, 169);
            this.yellowButton.Name = "yellowButton";
            this.yellowButton.Size = new System.Drawing.Size(75, 23);
            this.yellowButton.TabIndex = 2;
            this.yellowButton.Text = "黃燈";
            this.yellowButton.UseVisualStyleBackColor = true;
            this.yellowButton.Click += new System.EventHandler(this.yellowButton_Click);
            // 
            // greenButton
            // 
            this.greenButton.Location = new System.Drawing.Point(246, 169);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(75, 23);
            this.greenButton.TabIndex = 3;
            this.greenButton.Text = "綠燈";
            this.greenButton.UseVisualStyleBackColor = true;
            this.greenButton.Click += new System.EventHandler(this.greenButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(68, 213);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(98, 23);
            this.changeButton.TabIndex = 4;
            this.changeButton.Text = "燈號轉換";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // autoChangeButton
            // 
            this.autoChangeButton.Location = new System.Drawing.Point(189, 213);
            this.autoChangeButton.Name = "autoChangeButton";
            this.autoChangeButton.Size = new System.Drawing.Size(98, 23);
            this.autoChangeButton.TabIndex = 5;
            this.autoChangeButton.Text = "燈號自動轉換";
            this.autoChangeButton.UseVisualStyleBackColor = true;
            this.autoChangeButton.Click += new System.EventHandler(this.autoChangeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 265);
            this.Controls.Add(this.autoChangeButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.greenButton);
            this.Controls.Add(this.yellowButton);
            this.Controls.Add(this.redButton);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "紅綠燈";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape redOval;
        private Microsoft.VisualBasic.PowerPacks.OvalShape greenOval;
        private Microsoft.VisualBasic.PowerPacks.OvalShape yellowOval;
        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.Button yellowButton;
        private System.Windows.Forms.Button greenButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button autoChangeButton;
    }
}

