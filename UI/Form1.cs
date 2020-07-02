using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyMath;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string error = "";
            double[] result = Class1.Mathing(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text),out error);
            string resultStr =string.Join("\n",result);
            MessageBox.Show(resultStr, error);
        }
    }
}
