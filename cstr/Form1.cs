using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cstr
{
    public partial class Form1 : Form
    {
        string moban = "", t1 = "", t2 = "", t3 = "", str1 = "", str2 = "", str3 = "", result = "";
        string[] str1l, str2l, str3l;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result = "1";
            result = "";

            int count = 0;
            moban = textBox1.Text;
            t1 = textBox2.Text;
            t2 = textBox3.Text;
            t3 = textBox4.Text;
            str1 = textBox5.Text;
            str2 = textBox6.Text;
            str3 = textBox7.Text;

            str1l = str1.Split(',');
            str2l = str2.Split(',');
            str3l = str3.Split(',');

            if (str1l.Length > 1)
            {
                for(int i = 0; i < str1l.Length; i++)
                {
                    result += cl(i);
                }
            }

            textBox8.Text = result;
        }

        private string cl(int len)
        {
            string str = moban;
            if (str1l.Length > len)
            {
                str = str.Replace(t1, str1l[len]);
            }
            if (str2l.Length > len)
            {
                str = str.Replace(t2, str2l[len]);
            }
            if (str3l.Length > len)
            {
                str = str.Replace(t3, str3l[len]);
            }
            return str;

        }
    }
}
