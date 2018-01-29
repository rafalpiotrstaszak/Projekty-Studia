using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kalkulator_Dopasowań
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void b_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void b_instrukcja_Click(object sender, EventArgs e)
        {
            instrukcja instrukcja = new instrukcja();
            instrukcja.Show();
        }

        private void b_edytor_Click(object sender, EventArgs e)
        {
            edytor edytor = new edytor();
            edytor.Show();
        }

        private void b_kalkulator_Click(object sender, EventArgs e)
        {
            kalkulator kalkulator = new kalkulator();
            kalkulator.Show();
            
        }
    }
}
