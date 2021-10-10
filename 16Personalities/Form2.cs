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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            readme f1 = new readme();
            f1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            char x = 'A';
            int Q=1;
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
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }
    }
}
