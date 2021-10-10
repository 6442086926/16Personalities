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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            char x = 'A';
            int Q = 2;
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
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }
    }
}
