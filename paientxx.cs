using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 医院门诊
{
    public partial class paientxx : Form
    {
        string name,No;
        public paientxx()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public paientxx(string xm,string no):this()
        {
            labxm.Text = "您好"+xm+"!";
            name = xm;
            No = no;
        }
        private void btnzhuxiao_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定退出", "退出", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
        private void formClosed(object sender, FormClosedEventArgs e)
        {
            Show();
        }

        private void btnguahao_Click(object sender, EventArgs e)
        {

        }

        private void btngeirxx_Click(object sender, EventArgs e)
        {
            paitentinfornation  paitentinfornation= new paitentinfornation(name,No);
            paitentinfornation.FormClosed += formClosed;
            Hide();
            paitentinfornation.Show();
        }
    }
}
