using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ADSafeOfQQHelper
{


    public partial class FormMain : Form
    {
        private Thread thread;
        private Process proc;

        public FormMain()
        {
            InitializeComponent();
            proc = new Process();
            thread = new Thread(loopProcess);
        }

        #region Event Functions

        //on main Form load
        private void FormMain_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.autoStart) mainStart();
        }

        //on main Form close
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.thread.Abort();
            this.proc.Dispose();
        }

        private void buOk_Click(object sender, EventArgs e)
        {
            mainStart();
        }

        private void buAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("去广告器v1.1.2", "关于");
        }

        private void cBoxAtuo_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.autoStart = this.cBoxAtuo.Checked;
            Properties.Settings.Default.Save();
        }

        private void cBoxNoAlert_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.noAlert = this.cBoxNoAlert.Checked;
            Properties.Settings.Default.Save();
        }

        private void cBoxHelper_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.StartHelper = this.cBoxHelper.Checked;
            Properties.Settings.Default.Save();
        }

        private void buSelectPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdialog = new OpenFileDialog();
            fdialog.InitialDirectory = Environment.CurrentDirectory;
            if (fdialog.ShowDialog() == DialogResult.OK)
            {
                this.labelPath.Text = fdialog.FileName;
                Properties.Settings.Default.HelperPath = this.labelPath.Text;
                Properties.Settings.Default.Save();
            }
            /*
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = "C:";
            if(fbd .ShowDialog() == DialogResult.OK)*/
        }

        private void labelPath_Click(object sender, EventArgs e)
        {
            MsgForm news = new MsgForm(this.labelPath.Text);
            news.ShowDialog();
        }

        #endregion

        #region Helping Functions
        
        //main thread
        private void mainStart()
        {
            this.buOk.Enabled = false;
            this.buOk.Text = "已经启动";
            this.labelMain.Text = "运行中...";
            this.thread.Start();
            //sub.Join();//阻塞主线程

            //自动执行QQHelper
            if (Properties.Settings.Default.StartHelper
                && !this.labelPath.Text.Equals("未选择程序"))
            {
                if (System.IO.File.Exists(Properties.Settings.Default.HelperPath) )
                {
                    Process p = new Process();
                    p.StartInfo.FileName = Properties.Settings.Default.HelperPath;
                    if (!p.Start())
                    {
                        MessageBox.Show("QQHelper启动失败", "警告");
                    }
                    else
                    {
                        p.Close();
                    }
                }
                else
                {
                    MessageBox.Show("所选程序已变更目录", "警告");
                }
            }
        }

        //子线程的主循环
        private void loopProcess()
        {
            while(true)
            {
                threadKillProcess();
                Thread.Sleep(10);
            }
        }

        //get AD process Names
        private string[] getADProcNames()
        {
            string res = "";
            string pstr = ".uTMP";
            do
            {
                res = runCmd("tasklist|findstr /I \"" + pstr + "\"");
                if (res.IndexOf("Console") > 0)
                    break;
                else
                    Thread.Sleep(1000);
            }
            while (true);
            return res.Split('\n');
        }

        //kill AD process
        private void threadKillProcess()
        {
            //taskkill /PID 1230
            //taskkill /im cmd.exe /f
            //.uTMP

            string[] list = getADProcNames();

            for (int i = 0; i < list.Length;i++ )
            {
                if (list[i].Length > 5)
                {
                    string[] para = list[i].Split(' ');
                    string res_ok = runCmd("taskkill /im \"" + para[0] + "\" /f");
                    if (res_ok.Length > 5)
                    {
                        if (Properties.Settings.Default.noAlert) break;
                        //定义一个委托实例，该实例执行打开窗口代码
                        BeginInvoke(new MethodInvoker(openMsg));
                        break;
                    }
                }
            }
        }

        //run cmd code
        private string runCmd(string args) 
        {
            proc = new Process();
            proc.StartInfo.FileName = "cmd.exe";
            proc.StartInfo.UseShellExecute = false;    //是否使用操作系统shell启动
            proc.StartInfo.RedirectStandardInput = true;//接受来自调用程序的输入信息
            proc.StartInfo.RedirectStandardOutput = true;//由调用程序获取输出信息
            proc.StartInfo.RedirectStandardError = true;//重定向标准错误输出
            proc.StartInfo.CreateNoWindow = true;//不显示程序窗口
            proc.Start();//启动程序

            proc.Start();
            //向cmd窗口发送输入信息
            proc.StandardInput.WriteLine(args + "&exit");
            proc.StandardInput.AutoFlush = true;

            //获取cmd窗口的输出信息
            string output = proc.StandardOutput.ReadToEnd();

            proc.WaitForExit();//等待程序执行完退出进程
            proc.Close();

            return output.Substring(output.IndexOf("&exit") + 6);
        }

        //Show Message of Successfully Deleting AD 
        private void openMsg()
        {
            MsgForm news = new MsgForm("成功去除广告!!");
            news.ShowDialog();
        }

        #endregion

        #region windows Changes Event
        private void FormMain_SizeChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("我被最小化了");
            //判断是否选择的是最小化按钮 
            if (WindowState == FormWindowState.Minimized)
            {
                //this.Hide();两个方法都可以
                this.ShowInTaskbar = false;
                notifyIconMain.Visible = true;
            }
        }

        private void IconRMenuExit_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("是否退出","提示",MessageBoxButtons.OKCancel);
            if (res == DialogResult.OK) 
            {
                this.Close();
            }
        }

        private void notifyIconMain_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) {
                IconRMenu.Show(MousePosition);
            }
        }

        private void notifyIconMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //判断是否已经最小化于托盘 
            if (WindowState == FormWindowState.Minimized && e.Button == MouseButtons.Left)
            {
                //还原窗体显示
                WindowState = FormWindowState.Normal;
                //激活窗体并给予它焦点 
                this.Activate();
                //任务栏区显示图标
                //this.show()
                this.ShowInTaskbar = true;
                //托盘区图标隐藏 
                notifyIconMain.Visible = false;
            }
        }
        #endregion



    }
}
