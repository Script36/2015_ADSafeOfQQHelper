namespace ADSafeOfQQHelper
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buOk = new System.Windows.Forms.Button();
            this.buAbout = new System.Windows.Forms.Button();
            this.labelMain = new System.Windows.Forms.Label();
            this.cBoxNoAlert = new System.Windows.Forms.CheckBox();
            this.buSelectPath = new System.Windows.Forms.Button();
            this.cBoxHelper = new System.Windows.Forms.CheckBox();
            this.labelPath = new System.Windows.Forms.Label();
            this.cBoxAtuo = new System.Windows.Forms.CheckBox();
            this.notifyIconMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.IconRMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.IconRMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.IconRMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // buOk
            // 
            this.buOk.Location = new System.Drawing.Point(12, 12);
            this.buOk.Name = "buOk";
            this.buOk.Size = new System.Drawing.Size(77, 51);
            this.buOk.TabIndex = 0;
            this.buOk.Text = "启动";
            this.buOk.UseVisualStyleBackColor = true;
            this.buOk.Click += new System.EventHandler(this.buOk_Click);
            // 
            // buAbout
            // 
            this.buAbout.Location = new System.Drawing.Point(144, 12);
            this.buAbout.Name = "buAbout";
            this.buAbout.Size = new System.Drawing.Size(46, 23);
            this.buAbout.TabIndex = 2;
            this.buAbout.Text = "关于";
            this.buAbout.UseVisualStyleBackColor = true;
            this.buAbout.Click += new System.EventHandler(this.buAbout_Click);
            // 
            // labelMain
            // 
            this.labelMain.AutoSize = true;
            this.labelMain.Location = new System.Drawing.Point(95, 51);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(95, 12);
            this.labelMain.TabIndex = 3;
            this.labelMain.Text = "适用版本:v1.407";
            // 
            // cBoxNoAlert
            // 
            this.cBoxNoAlert.AutoSize = true;
            this.cBoxNoAlert.Checked = global::ADSafeOfQQHelper.Properties.Settings.Default.noAlert;
            this.cBoxNoAlert.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ADSafeOfQQHelper.Properties.Settings.Default, "noAlert", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cBoxNoAlert.Location = new System.Drawing.Point(12, 142);
            this.cBoxNoAlert.Name = "cBoxNoAlert";
            this.cBoxNoAlert.Size = new System.Drawing.Size(156, 16);
            this.cBoxNoAlert.TabIndex = 5;
            this.cBoxNoAlert.Text = "不显示广告去除成功提示";
            this.cBoxNoAlert.UseVisualStyleBackColor = true;
            this.cBoxNoAlert.CheckedChanged += new System.EventHandler(this.cBoxNoAlert_CheckedChanged);
            // 
            // buSelectPath
            // 
            this.buSelectPath.Location = new System.Drawing.Point(170, 69);
            this.buSelectPath.Name = "buSelectPath";
            this.buSelectPath.Size = new System.Drawing.Size(20, 23);
            this.buSelectPath.TabIndex = 6;
            this.buSelectPath.Text = "…";
            this.buSelectPath.UseVisualStyleBackColor = true;
            this.buSelectPath.Click += new System.EventHandler(this.buSelectPath_Click);
            // 
            // cBoxHelper
            // 
            this.cBoxHelper.AutoSize = true;
            this.cBoxHelper.Checked = global::ADSafeOfQQHelper.Properties.Settings.Default.StartHelper;
            this.cBoxHelper.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ADSafeOfQQHelper.Properties.Settings.Default, "StartHelper", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cBoxHelper.Location = new System.Drawing.Point(12, 98);
            this.cBoxHelper.Name = "cBoxHelper";
            this.cBoxHelper.Size = new System.Drawing.Size(72, 16);
            this.cBoxHelper.TabIndex = 8;
            this.cBoxHelper.Text = "同时启动";
            this.cBoxHelper.UseVisualStyleBackColor = true;
            this.cBoxHelper.CheckedChanged += new System.EventHandler(this.cBoxHelper_CheckedChanged);
            // 
            // labelPath
            // 
            this.labelPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ADSafeOfQQHelper.Properties.Settings.Default, "HelperPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.labelPath.Location = new System.Drawing.Point(12, 74);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(150, 12);
            this.labelPath.TabIndex = 7;
            this.labelPath.Text = global::ADSafeOfQQHelper.Properties.Settings.Default.HelperPath;
            this.labelPath.Click += new System.EventHandler(this.labelPath_Click);
            // 
            // cBoxAtuo
            // 
            this.cBoxAtuo.AutoSize = true;
            this.cBoxAtuo.Checked = global::ADSafeOfQQHelper.Properties.Settings.Default.autoStart;
            this.cBoxAtuo.Location = new System.Drawing.Point(12, 120);
            this.cBoxAtuo.Name = "cBoxAtuo";
            this.cBoxAtuo.Size = new System.Drawing.Size(108, 16);
            this.cBoxAtuo.TabIndex = 4;
            this.cBoxAtuo.Text = "开启时自动启动";
            this.cBoxAtuo.UseVisualStyleBackColor = true;
            this.cBoxAtuo.CheckedChanged += new System.EventHandler(this.cBoxAtuo_CheckedChanged);
            // 
            // notifyIconMain
            // 
            this.notifyIconMain.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconMain.Icon")));
            this.notifyIconMain.Text = "QQHelper去广告";
            this.notifyIconMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconMain_MouseClick);
            this.notifyIconMain.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconMain_MouseDoubleClick);
            // 
            // IconRMenu
            // 
            this.IconRMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IconRMenuExit});
            this.IconRMenu.Name = "contextMenuStrip1";
            this.IconRMenu.Size = new System.Drawing.Size(101, 26);
            // 
            // IconRMenuExit
            // 
            this.IconRMenuExit.Name = "IconRMenuExit";
            this.IconRMenuExit.Size = new System.Drawing.Size(152, 22);
            this.IconRMenuExit.Text = "退出";
            this.IconRMenuExit.Click += new System.EventHandler(this.IconRMenuExit_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 163);
            this.Controls.Add(this.cBoxHelper);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.buSelectPath);
            this.Controls.Add(this.cBoxNoAlert);
            this.Controls.Add(this.cBoxAtuo);
            this.Controls.Add(this.labelMain);
            this.Controls.Add(this.buAbout);
            this.Controls.Add(this.buOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "去广告";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.SizeChanged += new System.EventHandler(this.FormMain_SizeChanged);
            this.IconRMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buOk;
        private System.Windows.Forms.Button buAbout;
        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.CheckBox cBoxAtuo;
        private System.Windows.Forms.CheckBox cBoxNoAlert;
        private System.Windows.Forms.Button buSelectPath;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.CheckBox cBoxHelper;
        private System.Windows.Forms.NotifyIcon notifyIconMain;
        private System.Windows.Forms.ContextMenuStrip IconRMenu;
        private System.Windows.Forms.ToolStripMenuItem IconRMenuExit;
    }
}

