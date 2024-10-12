using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dikdörtgen_Alan_Cevre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 kısakenar, uzunkenar,alan,cevre;

            kısakenar =Convert.ToInt32(textBox1.Text); 
            uzunkenar = Convert.ToInt32(textBox2.Text);
            alan = kısakenar * uzunkenar;
            cevre = kısakenar * 2 + uzunkenar * 2;
            label6.Text=Convert.ToString(alan);
            label7.Text=Convert.ToString(cevre);

        }
    }
}
