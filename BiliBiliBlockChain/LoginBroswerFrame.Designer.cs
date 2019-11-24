namespace BiliBiliBlockChain
{
    partial class LoginBroswerFrame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginBroswer = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // loginBroswer
            // 
            this.loginBroswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginBroswer.Location = new System.Drawing.Point(0, 0);
            this.loginBroswer.MinimumSize = new System.Drawing.Size(20, 20);
            this.loginBroswer.Name = "loginBroswer";
            this.loginBroswer.Size = new System.Drawing.Size(437, 400);
            this.loginBroswer.TabIndex = 0;
            // 
            // LoginBroswerFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 400);
            this.Controls.Add(this.loginBroswer);
            this.Name = "LoginBroswerFrame";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "登录账号";
            this.Load += new System.EventHandler(this.LoginBroswerFrame_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser loginBroswer;
    }
}