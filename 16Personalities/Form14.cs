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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form13 f13 = new Form13();
            f13.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            char x = 'A';
            int Q = 13;
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
            Form15 f15 = new Form15();
            f15.ShowDialog();
        }
    }
}
