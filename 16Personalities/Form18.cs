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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form17 f17 = new Form17();
            f17.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            char x = 'A';
            int Q = 17;
            if (radioButton1.Checked == true)
            {
                x = 'E';
            }
            if (radioButton2.Checked == true)
            {
                x = 'I';
            }
            result r1 = new result(x, Q);
            this.Hide();
            Form19 f19 = new Form19();
            f19.ShowDialog();
        }
    }
}
