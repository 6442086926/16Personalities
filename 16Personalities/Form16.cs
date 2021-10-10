using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16Personalities
{
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form15 f15 = new Form15();
            f15.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            char x = 'A';
            int Q = 15;
            if (radioButton1.Checked == true)
            {
                x = 'T';
            }
            if (radioButton2.Checked == true)
            {
                x = 'F';
            }
            result r1 = new result(x, Q);
            this.Hide();
            Form17 f17 = new Form17();
            f17.ShowDialog();
        }
    }
}
