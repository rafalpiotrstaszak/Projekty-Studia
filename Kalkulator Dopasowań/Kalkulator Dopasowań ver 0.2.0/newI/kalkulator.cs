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
    public partial class kalkulator : Form
    {
        public kalkulator()
        {
            InitializeComponent();

                
            
        }

        private void kalkulator_Shown(object sender, EventArgs e)
        {
            string naglowek_grupy = "Cechy";
            ListViewGroup kalkulator_lista_cechyzakresowe = new ListViewGroup(naglowek_grupy);
            ListViewGroup istnieje = null;
            foreach (ListViewGroup grupa in kalkulator_lista.Groups)
            {
                if (grupa.Header == kalkulator_lista_cechyzakresowe.Header)
                { istnieje = grupa; break; }
            }
            ziu zapisziuzyj = new ziu();
            
            string f,m,k,l;
            
            for (int w = 0; w < zapisziuzyj.zwrocu(); w++ )
            {
                zapisziuzyj.pobierzi(w);
                for (int q = 0; q < 3; q++)
                {
                    zapisziuzyj.pobierzj(q);
                    f = zapisziuzyj.zwroc_element(); 
                    m = zapisziuzyj.zwroc_element(); 
                    k = zapisziuzyj.zwroc_element(); 
                    l = zapisziuzyj.zwroc_element(); 

                    if (istnieje == null)    
                                                                             // Jeżeli nie znajdzie istniejącą grupę
                    {
                        kalkulator_lista.Groups.Add(kalkulator_lista_cechyzakresowe);                               // Tworzy ją
                        string[] nowacecha = { f, m, k, l };      // oraz dodaje element do listview i grupy
                        var cecha = new ListViewItem(nowacecha, kalkulator_lista_cechyzakresowe);
                        kalkulator_lista.Items.Add(cecha);

                    }
                    if (istnieje != null)
                    {                                                                                                // oraz dodaje element do listview i grupy
                        string[] nowacecha = { f, m, k, l };
                        var cecha = new ListViewItem(nowacecha, istnieje);
                        kalkulator_lista.Items.Add(cecha);
                    }
                }
            }
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label4.Visible == false)
            {
                label4.Visible = true;
            }
            if (label5.Visible == false)
            {
                label5.Visible = true;
            }
        }
    }
}
