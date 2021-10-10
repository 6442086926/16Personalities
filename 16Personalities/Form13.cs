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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form12 f12 = new Form12();
            f12.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            char x = 'A';
            int Q = 12;
            if (radioButton1.Checked == true)
            {
                x = 'J';
            }
            if (radioButton2.Checked == true)
            {
                x = 'P';
            }
            result r1 = new result(x, Q);
            this.Hide();
            Form14 f14 = new Form14();
            f14.ShowDialog();
        }
    }
}
