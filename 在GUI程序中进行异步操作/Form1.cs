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

namespace 在GUI程序中进行异步操作
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Btn_Run_Click(object sender, EventArgs e)
        {
            Btn_Run.Enabled = false;
            label1.Text = "已运行";
            await Task.Delay(1000);
            label1.Text = "未运行";
            Btn_Run.Enabled = true;

        }
    }
}
