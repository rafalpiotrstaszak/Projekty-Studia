using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObliczaniePI_Monte_Carlo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static double funkcja(double a, double b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            if (a < b)
            {
                double temp = a;
                a = b;
                b = temp;
            }
            if (a == 0.0)
                return 0.0;
            else
            {
                double ba = b / a;
                return a * Math.Sqrt(1.0 + ba * ba);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r = 1;
            Random random = new Random();

            for (int z=0; z<r; z++)
            {
                int g = Int32.Parse(ile.Text);

                int v = 0;
                double lpi;

                double x, y;
                for (int i = 1; i <= g; i++)
                {
                    x = random.NextDouble();
                    y = random.NextDouble();
                    if (funkcja(x, y) <= 1)
                        v++;
                    double pi = 4 * (float)v / i;
                    lpi = pi;
                    label3.Text = ("Po " + g + " liczbach losowych Pi wynosi: " + pi);
                    //MessageBox.Show("Po " + i + " liczbach losowych Pi wynosi " + pi);
                }
                //label3.Text = ("Po " + g + " liczbach losowych Pi wynosi" + lpi);

            }
        }
    }
}
