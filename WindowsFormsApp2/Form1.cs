﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("您確定要刪除這筆紀錄?","刪除紀錄");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("您確定要刪除媽這筆紀錄?",
                                                    "刪除紀錄",
                                                    MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                MessageBox.Show("您選了yes");
            }
            else
            {
                MessageBox.Show("您選了No");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("無法刪除,因為目前此會員並不存在",
                                                  "刪除紀錄",
                                                  MessageBoxButtons.OK,
                                                  MessageBoxIcon.Error);
        }
    }
}
