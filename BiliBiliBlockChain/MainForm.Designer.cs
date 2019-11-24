namespace BiliBiliBlockChain
{
    partial class MainForm
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
            this.loginButton = new System.Windows.Forms.Button();
            this.logBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.videoIdLable = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.userIdLable = new System.Windows.Forms.Label();
            this.userIdTextbox = new System.Windows.Forms.TextBox();
            this.userIdBlockStartBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(12, 170);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "登录";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // logBox
            // 
            this.logBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.logBox.Location = new System.Drawing.Point(13, 399);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logBox.Size = new System.Drawing.Size(759, 150);
            this.logBox.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(156, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(560, 356);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.userIdBlockStartBtn);
            this.tabPage1.Controls.Add(this.userIdTextbox);
            this.tabPage1.Controls.Add(this.userIdLable);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(552, 330);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "拉黑指定用户粉丝";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.videoIdLable);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(552, 330);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "拉黑指定视频评论人";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // videoIdLable
            // 
            this.videoIdLable.AutoSize = true;
            this.videoIdLable.Location = new System.Drawing.Point(6, 28);
            this.videoIdLable.Name = "videoIdLable";
            this.videoIdLable.Size = new System.Drawing.Size(41, 12);
            this.videoIdLable.TabIndex = 0;
            this.videoIdLable.Text = "视频ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(53, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 1;
            // 
            // userIdLable
            // 
            this.userIdLable.AutoSize = true;
            this.userIdLable.Location = new System.Drawing.Point(21, 17);
            this.userIdLable.Name = "userIdLable";
            this.userIdLable.Size = new System.Drawing.Size(41, 12);
            this.userIdLable.TabIndex = 0;
            this.userIdLable.Text = "用户ID";
            // 
            // userIdTextbox
            // 
            this.userIdTextbox.Location = new System.Drawing.Point(68, 14);
            this.userIdTextbox.Name = "userIdTextbox";
            this.userIdTextbox.Size = new System.Drawing.Size(100, 21);
            this.userIdTextbox.TabIndex = 1;
            // 
            // userIdBlockStartBtn
            // 
            this.userIdBlockStartBtn.Location = new System.Drawing.Point(184, 14);
            this.userIdBlockStartBtn.Name = "userIdBlockStartBtn";
            this.userIdBlockStartBtn.Size = new System.Drawing.Size(75, 23);
            this.userIdBlockStartBtn.TabIndex = 2;
            this.userIdBlockStartBtn.Text = "开始屏蔽";
            this.userIdBlockStartBtn.UseVisualStyleBackColor = true;
            this.userIdBlockStartBtn.Click += new System.EventHandler(this.userIdBlockStartBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.loginButton);
            this.Name = "MainForm";
            this.Text = "BiliBili批量拉黑工具";
            this.Load += new System.EventHandler(this.MainForm_Loaded);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        public System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label videoIdLable;
        private System.Windows.Forms.TextBox userIdTextbox;
        private System.Windows.Forms.Label userIdLable;
        public System.Windows.Forms.Button userIdBlockStartBtn;
    }
}

