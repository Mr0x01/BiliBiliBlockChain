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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.loginButton = new System.Windows.Forms.Button();
            this.logBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.userIdBlockStartBtn = new System.Windows.Forms.Button();
            this.userIdTextbox = new System.Windows.Forms.TextBox();
            this.userIdLable = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.aboutTextBox = new System.Windows.Forms.TextBox();
            this.headImg = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headImg)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(12, 240);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(200, 43);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "登录";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // logBox
            // 
            this.logBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.logBox.Location = new System.Drawing.Point(6, 20);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logBox.Size = new System.Drawing.Size(748, 234);
            this.logBox.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(218, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(554, 271);
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
            this.tabPage1.Size = new System.Drawing.Size(546, 245);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "拉黑指定用户粉丝";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // userIdBlockStartBtn
            // 
            this.userIdBlockStartBtn.Location = new System.Drawing.Point(129, 41);
            this.userIdBlockStartBtn.Name = "userIdBlockStartBtn";
            this.userIdBlockStartBtn.Size = new System.Drawing.Size(75, 23);
            this.userIdBlockStartBtn.TabIndex = 2;
            this.userIdBlockStartBtn.Text = "开始屏蔽";
            this.userIdBlockStartBtn.UseVisualStyleBackColor = true;
            this.userIdBlockStartBtn.Click += new System.EventHandler(this.userIdBlockStartBtn_Click);
            // 
            // userIdTextbox
            // 
            this.userIdTextbox.Location = new System.Drawing.Point(23, 42);
            this.userIdTextbox.Name = "userIdTextbox";
            this.userIdTextbox.Size = new System.Drawing.Size(100, 21);
            this.userIdTextbox.TabIndex = 1;
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.aboutTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(546, 245);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "说明";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // aboutTextBox
            // 
            this.aboutTextBox.Location = new System.Drawing.Point(7, 7);
            this.aboutTextBox.Multiline = true;
            this.aboutTextBox.Name = "aboutTextBox";
            this.aboutTextBox.ReadOnly = true;
            this.aboutTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.aboutTextBox.Size = new System.Drawing.Size(539, 232);
            this.aboutTextBox.TabIndex = 0;
            this.aboutTextBox.Text = resources.GetString("aboutTextBox.Text");
            this.aboutTextBox.TextChanged += new System.EventHandler(this.AboutTextBox_TextChanged);
            // 
            // headImg
            // 
            this.headImg.Image = ((System.Drawing.Image)(resources.GetObject("headImg.Image")));
            this.headImg.ImageLocation = "";
            this.headImg.InitialImage = null;
            this.headImg.Location = new System.Drawing.Point(12, 34);
            this.headImg.Name = "headImg";
            this.headImg.Size = new System.Drawing.Size(200, 200);
            this.headImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.headImg.TabIndex = 3;
            this.headImg.TabStop = false;
            this.headImg.Click += new System.EventHandler(this.HeadImg_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.logBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 289);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 260);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "执行日志";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.headImg);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.loginButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "BiliBili批量拉黑工具";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Loaded);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headImg)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        public System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox userIdTextbox;
        private System.Windows.Forms.Label userIdLable;
        public System.Windows.Forms.Button userIdBlockStartBtn;
        private System.Windows.Forms.TextBox aboutTextBox;
        public System.Windows.Forms.PictureBox headImg;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

