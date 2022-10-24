using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        private int answer=0;
        public Form1()
        {
            InitializeComponent();
            //在表單一開始先取亂數1~3,存放在變數中,並在lable裡呈現答案,方便查看城市是否正確
            answer = new Random().Next(1, 4);
            answerlabel.Text = answer.ToString();

            //answerlabel.Visible = false;
        }

        private void Guess01button_Click(object sender, EventArgs e)
        {
            //sender是按鈕,將他轉型為Button之後,可以取得Tag值
            Button btn = (Button)sender;
            int tag=Convert.ToInt32(btn.Tag);

            MessageBox.Show(tag.ToString());

            //跟答案比對就知道有沒有答對了
            if(tag==answer)
            {
                MessageBox.Show("您答對了");
            }
            else 
            {
                MessageBox.Show("您答錯了,請按其他鍵試試");           
            }
            

        }
    }
}
