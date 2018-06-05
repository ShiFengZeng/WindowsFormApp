namespace TurtleAndRabbitRace
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
            this.turtleLabel = new System.Windows.Forms.Label();
            this.rabbitLabel = new System.Windows.Forms.Label();
            this.turtleButton = new System.Windows.Forms.RadioButton();
            this.rabbitButton = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.startButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // turtleLabel
            // 
            this.turtleLabel.AutoSize = true;
            this.turtleLabel.Location = new System.Drawing.Point(12, 50);
            this.turtleLabel.Name = "turtleLabel";
            this.turtleLabel.Size = new System.Drawing.Size(29, 12);
            this.turtleLabel.TabIndex = 0;
            this.turtleLabel.Text = "烏龜";
            // 
            // rabbitLabel
            // 
            this.rabbitLabel.AutoSize = true;
            this.rabbitLabel.Location = new System.Drawing.Point(12, 95);
            this.rabbitLabel.Name = "rabbitLabel";
            this.rabbitLabel.Size = new System.Drawing.Size(29, 12);
            this.rabbitLabel.TabIndex = 1;
            this.rabbitLabel.Text = "兔子";
            // 
            // turtleButton
            // 
            this.turtleButton.AutoSize = true;
            this.turtleButton.Location = new System.Drawing.Point(3, 4);
            this.turtleButton.Name = "turtleButton";
            this.turtleButton.Size = new System.Drawing.Size(59, 16);
            this.turtleButton.TabIndex = 2;
            this.turtleButton.TabStop = true;
            this.turtleButton.Text = "烏龜贏";
            this.turtleButton.UseVisualStyleBackColor = true;
            // 
            // rabbitButton
            // 
            this.rabbitButton.AutoSize = true;
            this.rabbitButton.Location = new System.Drawing.Point(107, 4);
            this.rabbitButton.Name = "rabbitButton";
            this.rabbitButton.Size = new System.Drawing.Size(59, 16);
            this.rabbitButton.TabIndex = 3;
            this.rabbitButton.TabStop = true;
            this.rabbitButton.Text = "兔子贏";
            this.rabbitButton.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(253, 162);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(95, 23);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "開始比賽";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.turtleButton);
            this.panel1.Controls.Add(this.rabbitButton);
            this.panel1.Location = new System.Drawing.Point(47, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 23);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(7, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "|";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(7, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "|";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(7, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "|";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(7, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "|";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(348, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(7, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "|";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 215);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.rabbitLabel);
            this.Controls.Add(this.turtleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "龜兔賽跑預測遊戲";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label turtleLabel;
        private System.Windows.Forms.Label rabbitLabel;
        private System.Windows.Forms.RadioButton turtleButton;
        private System.Windows.Forms.RadioButton rabbitButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

