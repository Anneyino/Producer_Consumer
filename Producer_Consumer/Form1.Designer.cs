namespace Producer_Consumer
{
    partial class PCsynchro
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.PoolBox = new System.Windows.Forms.TextBox();
            this.ProducerBox = new System.Windows.Forms.TextBox();
            this.BeginButton = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.RichTextBox();
            this.PoolLabel = new System.Windows.Forms.Label();
            this.ProducerLabel = new System.Windows.Forms.Label();
            this.ConsumerBox = new System.Windows.Forms.TextBox();
            this.ConsumerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PoolBox
            // 
            this.PoolBox.Location = new System.Drawing.Point(45, 64);
            this.PoolBox.Name = "PoolBox";
            this.PoolBox.Size = new System.Drawing.Size(98, 25);
            this.PoolBox.TabIndex = 0;
            // 
            // ProducerBox
            // 
            this.ProducerBox.Location = new System.Drawing.Point(45, 135);
            this.ProducerBox.Name = "ProducerBox";
            this.ProducerBox.Size = new System.Drawing.Size(98, 25);
            this.ProducerBox.TabIndex = 1;
            // 
            // BeginButton
            // 
            this.BeginButton.Location = new System.Drawing.Point(45, 241);
            this.BeginButton.Name = "BeginButton";
            this.BeginButton.Size = new System.Drawing.Size(98, 26);
            this.BeginButton.TabIndex = 2;
            this.BeginButton.Text = "开始同步";
            this.BeginButton.UseVisualStyleBackColor = true;
            this.BeginButton.Click += new System.EventHandler(this.BeginButton_Click);
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(212, 59);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(345, 208);
            this.resultBox.TabIndex = 3;
            this.resultBox.Text = "";
            // 
            // PoolLabel
            // 
            this.PoolLabel.AutoSize = true;
            this.PoolLabel.Location = new System.Drawing.Point(45, 43);
            this.PoolLabel.Name = "PoolLabel";
            this.PoolLabel.Size = new System.Drawing.Size(82, 15);
            this.PoolLabel.TabIndex = 4;
            this.PoolLabel.Text = "产品池大小";
            // 
            // ProducerLabel
            // 
            this.ProducerLabel.AutoSize = true;
            this.ProducerLabel.Location = new System.Drawing.Point(45, 114);
            this.ProducerLabel.Name = "ProducerLabel";
            this.ProducerLabel.Size = new System.Drawing.Size(82, 15);
            this.ProducerLabel.TabIndex = 5;
            this.ProducerLabel.Text = "生产者数量";
            // 
            // ConsumerBox
            // 
            this.ConsumerBox.Location = new System.Drawing.Point(45, 199);
            this.ConsumerBox.Name = "ConsumerBox";
            this.ConsumerBox.Size = new System.Drawing.Size(98, 25);
            this.ConsumerBox.TabIndex = 6;
            // 
            // ConsumerLabel
            // 
            this.ConsumerLabel.AutoSize = true;
            this.ConsumerLabel.Location = new System.Drawing.Point(48, 178);
            this.ConsumerLabel.Name = "ConsumerLabel";
            this.ConsumerLabel.Size = new System.Drawing.Size(82, 15);
            this.ConsumerLabel.TabIndex = 7;
            this.ConsumerLabel.Text = "消费者数量";
            // 
            // PCsynchro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 293);
            this.Controls.Add(this.ConsumerLabel);
            this.Controls.Add(this.ConsumerBox);
            this.Controls.Add(this.ProducerLabel);
            this.Controls.Add(this.PoolLabel);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.BeginButton);
            this.Controls.Add(this.ProducerBox);
            this.Controls.Add(this.PoolBox);
            this.Name = "PCsynchro";
            this.Text = "生产者消费者同步";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PoolBox;
        private System.Windows.Forms.TextBox ProducerBox;
        private System.Windows.Forms.Button BeginButton;
        private System.Windows.Forms.RichTextBox resultBox;
        private System.Windows.Forms.Label PoolLabel;
        private System.Windows.Forms.Label ProducerLabel;
        private System.Windows.Forms.TextBox ConsumerBox;
        private System.Windows.Forms.Label ConsumerLabel;
    }
}

