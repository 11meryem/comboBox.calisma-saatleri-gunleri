using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button._28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int gunno = comboBox1.SelectedIndex;
            gunno++;
            if (gunno == 1 || gunno == 2 || gunno == 3 || gunno == 4 || gunno == 5)
            {
                label2.Text = "çalışma saatleri 9.00'dan 15.00a kadar";

            }

            else if(gunno == 6)
            {
                label2.Text = "çalışma saatleri 9dan 13e kadar";
            }

            else
            {
                label2.Text = "tatil";
            }
         
        }
    }
}
