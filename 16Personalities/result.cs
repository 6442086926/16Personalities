using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _16Personalities
{
    public partial class result : Form
    {
        public static char[] list = new char[20];
        public result(char x, int Q)
        {
            list[Q - 1] = x;
            InitializeComponent();
            if (Q == 20)
            {
                int a = mbti(list);
                richTextBox1.Text = consult(a);
                pictureBox1.ImageLocation = "S_434187.jpg";
            }
        }
        public int mbti(char[] list)
        {
            int i;
            int E = 0, I = 0, S = 0, N = 0, T = 0, F = 0, J = 0, P = 0;
            for (i = 0; i < 20; i++)
            {
                if (list[i] == 'E')
                {
                    E += 1;
                }
                else if (list[i] == 'I')
                {
                    I += 1;
                }
                else if (list[i] == 'S')
                {
                    S += 1;
                }
                else if (list[i] == 'N')
                {
                    N += 1;
                }
                else if (list[i] == 'T')
                {
                    T += 1;
                }
                else if (list[i] == 'F')
                {
                    F += 1;
                }
                else if (list[i] == 'J')
                {
                    J += 1;
                }
                else if (list[i] == 'P')
                {
                    P += 1;
                }
            }
                if ((E < I) && (S < N) && (T < F) && (J < P))
                {
                    return 1;
                }else if ((E < I) && (S < N) && (T < F) && (J > P))
                {
                    return 2;
                }
                else if ((E < I) && (S < N) && (T > F) && (J < P))
                {
                    return 3;
                }
                else if ((E < I) && (S < N) && (T > F) && (J > P))
                {
                    return 4;
                }
                else if ((E < I) && (S > N) && (T < F) && (J < P))
                {
                    return 5;
                }
                else if ((E < I) && (S > N) && (T < F) && (J > P))
                {
                    return 6;
                }
                else if ((E < I) && (S > N) && (T > F) && (J < P))
                {
                    return 7;
                }
                else if ((E < I) && (S > N) && (T > F) && (J > P))
                {
                    return 8;
                }
                else if ((E > I) && (S < N) && (T < F) && (J < P))
                {
                    return 9;
                }
                else if ((E > I) && (S < N) && (T < F) && (J > P))
                {
                    return 10;
                }
                else if ((E > I) && (S < N) && (T > F) && (J < P))
                {
                    return 11;
                }
                else if ((E > I) && (S < N) && (T > F) && (J > P))
                {
                    return 12;
                }
                else if ((E > I) && (S > N) && (T < F) && (J < P))
                {
                    return 13;
                }
                else if ((E > I) && (S > N) && (T < F) && (J > P))
                {
                    return 14;
                }
                else if ((E > I) && (S > N) && (T > F) && (J < P))
                {
                    return 15;
                }
                else if ((E > I) && (S > N) && (T > F) && (J > P))
                {
                    return 16;
                }
            return 0;    
        }

        public string consult(int mbti)
        {
            if (mbti == 1)
            {
                return "infp";
            }
            if (mbti == 2)
            {
                return "infj";
            }
            if (mbti == 3)
            {
                return "intp";
            }
            if (mbti == 4)
            {
                return "intj";
            }
            if (mbti == 5)
            {
                return "isfp";
            }
            if (mbti == 6)
            {
                return "isfj";
            }
            if (mbti == 7)
            {
                return "istp";
            }
            if (mbti == 8)
            {
                return "istj";
            }
            if (mbti == 9)
            {
                return "enfp";
            }
            if (mbti == 10)
            {
                return "enfj";
            }
            if (mbti == 11)
            {
                return "entp";
            }
            if (mbti == 12)
            {
                return "entj";
            }
            if (mbti == 13)
            {
                return "esfp";
            }
            if (mbti == 14)
            {
                return "esfj";
            }
            if (mbti == 15)
            {
                return "estp";
            }
            if (mbti == 16)
            {
                return "estj";
            }
            return "a";
        }

        public string ImageLocation { get; set; }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }


        private void result_Load(object sender, EventArgs e)
        {

        }
    }
}
