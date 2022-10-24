using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            //取得列數
            int? rows = GetRows();

            if(rows.HasValue==false)
            {
                MessageBox.Show("請輸入列數:");
                return;
            }

            //判斷列數必須大於零
            if(rows.Value<=0)
            {
                MessageBox.Show("列數必須大於零");
                return ;
            }
            //生成星號三角形
            string stars = GenerateStars(rows.Value);
            starslabel.Text = stars;

            //用textbox呈現
            cubeBox.Text = stars;
         }
        private string GenerateStars(int rows)
        {
            string result=string.Empty;
            for(int i=1;i<=rows;i++)
            {
                result += new string('*', i) + "\r\n";
            }
            return result;
        }
        private int? GetRows()
        {
            string input=inputBox.Text;
            bool isInt =int.TryParse(input, out int rows);
            if(isInt)
            {
                return rows;
            }
            else
            {
                return null;   
            }
        }


    }


}
