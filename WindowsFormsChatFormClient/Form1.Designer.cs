namespace WindowsFormsChatFormClient
{
    partial class Form1
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
            this.txtShow = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnFontType = new System.Windows.Forms.Button();
            this.btnFontColor = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtShow
            // 
            this.txtShow.Location = new System.Drawing.Point(12, 12);
            this.txtShow.Multiline = true;
            this.txtShow.Name = "txtShow";
            this.txtShow.Size = new System.Drawing.Size(470, 261);
            this.txtShow.TabIndex = 0;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(13, 309);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(469, 125);
            this.txtInput.TabIndex = 1;
            // 
            // btnFontType
            // 
            this.btnFontType.Location = new System.Drawing.Point(13, 280);
            this.btnFontType.Name = "btnFontType";
            this.btnFontType.Size = new System.Drawing.Size(75, 23);
            this.btnFontType.TabIndex = 2;
            this.btnFontType.Text = "字体";
            this.btnFontType.UseVisualStyleBackColor = true;
            // 
            // btnFontColor
            // 
            this.btnFontColor.Location = new System.Drawing.Point(95, 280);
            this.btnFontColor.Name = "btnFontColor";
            this.btnFontColor.Size = new System.Drawing.Size(75, 23);
            this.btnFontColor.TabIndex = 3;
            this.btnFontColor.Text = "颜色";
            this.btnFontColor.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(406, 280);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 446);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnFontColor);
            this.Controls.Add(this.btnFontType);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.txtShow);
            this.Name = "Form1";
            this.Text = "客户端";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtShow;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnFontType;
        private System.Windows.Forms.Button btnFontColor;
        private System.Windows.Forms.Button btnSend;
    }
}

