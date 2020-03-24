using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BVtranslateAV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       public int translate(String x)
        {
            int r=0;
            Dictionary<char, int> dic= new Dictionary<char, int>();          
            String table = "fZodR9XQDSUm21yCkr6zBqiveYah8bt4xsWpHnJE7jL5VG3guMTKNPAwcF";
            for (int i=0;i<58;i++)
            {
                dic.Add(table[i],i);
            }
            int[] s = {11,10,3,8,4,6};
            int xo = 177451812;
            long add = 8728348608;
            for (int i = 0; i < 6; i++)
            {
                
                r+=dic[x[s[i]]]*(int)Math.Pow(58,i);

            }
            int re = (int)(r - add) ^ xo;
            return re;
;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String x=BVtext.Text.ToString();
            if (x.Length < 12)
            {
                x = "BV17x411w7KC";
                BVtext.Text = x;
            }
            int r = translate(x);
            String re = r + "";
            AVtext.Text = re;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://space.bilibili.com/40506842/video");
        }
    }
}
