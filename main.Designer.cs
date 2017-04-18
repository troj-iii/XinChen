namespace SunCity
{
    partial class main
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.wb_ = new System.Windows.Forms.WebBrowser();
            this.reg_ = new System.Windows.Forms.Button();
            this.url_ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.beg_ = new System.Windows.Forms.Button();
            this.login_ = new System.Windows.Forms.Button();
            this.console_ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wb_
            // 
            this.wb_.Location = new System.Drawing.Point(-1, 83);
            this.wb_.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb_.Name = "wb_";
            this.wb_.ScriptErrorsSuppressed = true;
            this.wb_.Size = new System.Drawing.Size(1359, 735);
            this.wb_.TabIndex = 0;
            // 
            // reg_
            // 
            this.reg_.Location = new System.Drawing.Point(275, 12);
            this.reg_.Name = "reg_";
            this.reg_.Size = new System.Drawing.Size(118, 36);
            this.reg_.TabIndex = 1;
            this.reg_.Text = "注册";
            this.reg_.UseVisualStyleBackColor = true;
            this.reg_.Click += new System.EventHandler(this.reg__Click);
            // 
            // url_
            // 
            this.url_.Location = new System.Drawing.Point(39, 56);
            this.url_.Name = "url_";
            this.url_.ReadOnly = true;
            this.url_.Size = new System.Drawing.Size(1319, 21);
            this.url_.TabIndex = 2;
            this.url_.Text = "www.hg6668a.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "网址";
            // 
            // beg_
            // 
            this.beg_.Location = new System.Drawing.Point(74, 12);
            this.beg_.Name = "beg_";
            this.beg_.Size = new System.Drawing.Size(118, 36);
            this.beg_.TabIndex = 4;
            this.beg_.Text = "开始";
            this.beg_.UseVisualStyleBackColor = true;
            this.beg_.Click += new System.EventHandler(this.beg__Click);
            // 
            // login_
            // 
            this.login_.Location = new System.Drawing.Point(487, 12);
            this.login_.Name = "login_";
            this.login_.Size = new System.Drawing.Size(118, 36);
            this.login_.TabIndex = 5;
            this.login_.Text = "登录";
            this.login_.UseVisualStyleBackColor = true;
            this.login_.Click += new System.EventHandler(this.login__Click);
            // 
            // console_
            // 
            this.console_.Location = new System.Drawing.Point(1196, 12);
            this.console_.Name = "console_";
            this.console_.Size = new System.Drawing.Size(118, 36);
            this.console_.TabIndex = 6;
            this.console_.Text = "Console";
            this.console_.UseVisualStyleBackColor = true;
            this.console_.Click += new System.EventHandler(this.console__Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 813);
            this.Controls.Add(this.console_);
            this.Controls.Add(this.login_);
            this.Controls.Add(this.beg_);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.url_);
            this.Controls.Add(this.reg_);
            this.Controls.Add(this.wb_);
            this.Name = "main";
            this.Text = "SunCity";
            this.Load += new System.EventHandler(this.main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser wb_;
        private System.Windows.Forms.Button reg_;
        private System.Windows.Forms.TextBox url_;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button beg_;
        private System.Windows.Forms.Button login_;
        private System.Windows.Forms.Button console_;
    }
}

