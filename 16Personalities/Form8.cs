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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f7 = new Form7();
            f7.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            char x = 'A';
            int Q = 7;
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
            Form9 f9 = new Form9();
            f9.ShowDialog();
        }
    }
}
