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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f6 = new Form6();
            f6.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            char x = 'A';
            int Q = 6;
            if (radioButton1.Checked == true)
            {
                x = 'S';
            }
            if (radioButton2.Checked == true)
            {
                x = 'N';
            }
            result r1 = new result(x, Q);
            this.Hide();
            Form8 f8 = new Form8();
            f8.ShowDialog();
        }
    }
}
