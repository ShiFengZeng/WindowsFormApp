namespace BentoStatistics
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
            this.menuCombo = new System.Windows.Forms.ComboBox();
            this.orderList = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.resultButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // menuCombo
            // 
            this.menuCombo.FormattingEnabled = true;
            this.menuCombo.Items.AddRange(new object[] {
            "排骨飯",
            "雞腿飯",
            "控肉飯",
            "鱈魚飯",
            "豬腳飯",
            "滷肉飯",
            "肉燥飯",
            "燒肉飯"});
            this.menuCombo.Location = new System.Drawing.Point(35, 43);
            this.menuCombo.Name = "menuCombo";
            this.menuCombo.Size = new System.Drawing.Size(183, 20);
            this.menuCombo.TabIndex = 0;
            this.menuCombo.Text = "排骨飯";
            // 
            // orderList
            // 
            this.orderList.FormattingEnabled = true;
            this.orderList.ItemHeight = 12;
            this.orderList.Location = new System.Drawing.Point(35, 83);
            this.orderList.Name = "orderList";
            this.orderList.Size = new System.Drawing.Size(183, 136);
            this.orderList.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(245, 43);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(90, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "訂購";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(35, 225);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(90, 23);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "移除";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(131, 225);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(90, 23);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "清空訂單";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // resultButton
            // 
            this.resultButton.Location = new System.Drawing.Point(245, 83);
            this.resultButton.Name = "resultButton";
            this.resultButton.Size = new System.Drawing.Size(90, 23);
            this.resultButton.TabIndex = 5;
            this.resultButton.Text = "開始統計";
            this.resultButton.UseVisualStyleBackColor = true;
            this.resultButton.Click += new System.EventHandler(this.resultButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(245, 125);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(53, 12);
            this.resultLabel.TabIndex = 6;
            this.resultLabel.Text = "尚未統計";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 271);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.resultButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.orderList);
            this.Controls.Add(this.menuCombo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "訂便當程式！";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox menuCombo;
        private System.Windows.Forms.ListBox orderList;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button resultButton;
        private System.Windows.Forms.Label resultLabel;
    }
}

