using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace คำนวณภาษี
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int text1 = int.Parse(textBox1.Text);
                if (text1 <= 150000)
                {
                    textBox3.Text = "0";
                    MessageBox.Show("คุณไม่ต้องเสียภาษี", "แจ้งเตือน");
                }
                else if (text1 >= 150001 && text1 <= 300000)
                {
                    int Ans = ((text1 - 150000) * 5) / 100;
                    textBox3.Text = Ans.ToString();
                }
                else if (text1 >= 300001 && text1 <= 500000)
                {
                    int Ans = (((text1 - 300000) * 10) / 100) + 7500;
                    textBox3.Text = Ans.ToString();
                }
                else if (text1 >= 500001 && text1 <= 750000)
                {
                    int Ans = (((text1 - 500000) * 15) / 100) + 27500;
                    textBox3.Text = Ans.ToString();
                }
                else if (text1 >= 750001 && text1 <= 1000000)
                {
                    int Ans = (((text1 - 750000) * 20) / 100) + 65000;
                    textBox3.Text = Ans.ToString();
                }
                else if (text1 >= 1000001 && text1 <= 2000000)
                {
                    int Ans = (((text1 - 1000000) * 25) / 100) + 115000;
                    textBox3.Text = Ans.ToString();
                }
                else if (text1 >= 2000001 && text1 <= 4000000)
                {
                    int Ans = (((text1 - 2000000) * 30) / 100) + 365000;
                    textBox3.Text = Ans.ToString();
                }
                else if (text1 >= 4000001)
                {
                    int Ans = (((text1 - 4000000) * 35) / 100) + 965000;
                    textBox3.Text = Ans.ToString();
                }
            }
            catch
            {
                MessageBox.Show("กรุณาใส่ข้อมูลให้ถูกต้อง");
            }

        }
    }
}
