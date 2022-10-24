using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void greetButton_Click(object sender, EventArgs e)
        {
            //得到輸入姓名
            string name = nameTexrBox.Text;

            //組合出問候語
            string message = $"Hi,{name}";

            //指派給label
            greetinglabel.Text = message;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
