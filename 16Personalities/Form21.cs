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
    public partial class Form21 : Form
    {
        public Form21()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form20 f20 = new Form20();
            f20.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            char x = 'A';
            int Q = 20;
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
            r1.ShowDialog();
        }
    }
}
