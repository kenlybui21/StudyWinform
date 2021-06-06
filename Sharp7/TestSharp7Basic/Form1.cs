using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestSharp7Basic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Change(object sender, EventArgs e)
        {
            if (ckbModule1.CheckState == CheckState.Checked)
            {
                Login.Text = Input.Text;
                MessageBox.Show("Đã thay đổi thông tin");
            }
        }
    }
}
