using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace szamok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            int A = 0;
            int B = 0;
            int C = 0;
            int D = 0;
            int E = 0;

            string elso = D.ToString() + B.ToString() + C.ToString();
            string masodik = C.ToString() + D.ToString() + E.ToString();
            string eredmeny = B.ToString() + A.ToString() + C.ToString() + B.ToString();

            for (int i = 0; i < 1000000; i++)
            {
                A = rnd.Next(1, 10);
                B = rnd.Next(1, 10);
                C = rnd.Next(1, 10);
                D = rnd.Next(1, 10);
                E = rnd.Next(1, 10);

                elso = D.ToString() + B.ToString() + C.ToString();
                masodik = C.ToString() + D.ToString() + E.ToString();
                eredmeny = B.ToString() + A.ToString() + C.ToString() + B.ToString();


                if (Convert.ToInt32(elso) + Convert.ToInt32(masodik) == Convert.ToInt32(eredmeny))
                {
                    label1.Text = $"A:{A}, B:{B}, C:{C}, D:{D}, E:{E}\n";
                }
                

            }

        }
    }
}
