using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Kalkulator_Dopasowań
{
    class ziu
    {
        int i;
        int j;
        int u;
        string r;
        string[,] tablica;
                    

        public void pobierzi(int stani)
        {
            i = stani;

        }

        public void pobierzj(int stanj)
        {
            i = stanj;

        }

        public int zwrocu()
        {
            return u;
        }

        public void metoda(string[,] tab, int stanu)
        {

            u = stanu;
            for (int k = 1; (k < u); k++)
            {
                for (int l = 0; l == 5; l++)
                {
                    tablica[k, l] = tab[k, l];
                }

            }
        }

        public string zwroc_element()
        {
            r = tablica[i, j];
            return r;

        }
        



    }
}
