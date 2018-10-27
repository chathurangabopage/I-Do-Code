using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryCalc
{
    public partial class Form1 : Form
    {
        int num;
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }
        public void opt()
        {
            int count=0,i,y,p;
            for (i = num; i > 0; i = i / 2)
            {
                count++;
            }
            i = count-1;
            label4.Text = Convert.ToString(count);
            int[] x = new int[count];
            for (p=i; p >= 0; p--)
            {
                y = num % 2;
                x[p]=y;
                num = num / 2;
            }
            string bin="";
            for (p = 0; p <= i; p++)
            {
                bin += Convert.ToString(x[p]);
            }
            label5.Text = Convert.ToString(bin);
        }
        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            num = Convert.ToInt32(textBox1.Text);
        }
        public void button1_Click(object sender, EventArgs e)
        {
            opt();
        }
    }
}
