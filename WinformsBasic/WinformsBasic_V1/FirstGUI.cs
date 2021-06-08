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

namespace WinformsBasicGUI
{
    public partial class FirstGUI : Form
    {
        public FirstGUI()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void btnClick_Change(object sender, EventArgs e)
        {
            if (ckbModule1.CheckState == CheckState.Checked)
            {
                Login.Text = Input.Text;
                MessageBox.Show("Đã thay đổi thông tin");
            }
        }

        List<string> listItem;
        private void btnLoad_Click (object sender, EventArgs e)
        {
            listItem = new List<string>() { "Nguyễn Thị Bích Tín", "Bích Tín Nguyễn", "Nôn" };
            cbData.DataSource = listItem;
        }

        private void btnIncearces_Click(object sender, EventArgs e)
        {
            Thread thrd = new Thread(IncreaseVoid);
            thrd.IsBackground = true;
            thrd.Start();
        }

        void IncreaseVoid()
        {
            for (int i = 0; i < Convert.ToInt32(tbNum.Text); i++)
            {
                lbDisplay.Text = i.ToString();
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bùi Minh Trí");
        }



        int j = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            j++;
            lbTimeDisplay.Text = j.ToString();

        }

        private void btnTimer_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            btnTimer.Text = btnTimer.Text == "Stop" ? "Start" : "Stop";
        }
    }
}
