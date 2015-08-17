using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADSafeOfQQHelper
{
    public partial class MsgForm : Form
    {
        private string msg = "";

        public MsgForm()
        {
            InitializeComponent();
        }

        public MsgForm(string msg)
        {
            this.msg = msg;
            InitializeComponent();
        }

        private void MsgForm_Load(object sender, EventArgs e)
        {
            this.labelMsg.Text = this.msg;
        }
    }
}
