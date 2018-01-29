using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.IO;

namespace Kalkulator_Dopasowań
{
    public partial class edytor : Form
    {

        public edytor()
        {
            InitializeComponent();
        }

        private void edytor_plik_zakoncz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void editor_file_exiteditor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void edytor_01param_dodaj_Click(object sender, EventArgs e)
        {

            ListViewItem powtorzona = edytor_lista.FindItemWithText(textBox_nazwa_01param.Text);
            if (powtorzona != null)
            {
                MessageBox.Show("Cecha " + powtorzona.ToString() + " już istnieje!");
            }
            else
            {

                string naglowek_grupy = "Cechy Przeciwne";
                ListViewGroup edytor_lista_cechyprzeciwne = new ListViewGroup(naglowek_grupy);
                ListViewGroup istnieje = null;
                foreach (ListViewGroup grupa in edytor_lista.Groups)
                {
                    if (grupa.Header == edytor_lista_cechyprzeciwne.Header)
                    { istnieje = grupa; break; }
                }
                if (istnieje == null)                                                                      // Jeżeli nie znajdzie istniejącą grupę
                {
                    edytor_lista.Groups.Add(edytor_lista_cechyprzeciwne);                               // Tworzy ją
                    string[] nowacecha = { textBox_nazwa_01param.Text, textBox_komentarz_01param.Text, "0", "0" };      // oraz dodaje element do listview i grupy
                    var cecha = new ListViewItem(nowacecha, edytor_lista_cechyprzeciwne);
                    edytor_lista.Items.Add(cecha);

                }
                if (istnieje != null)
                {
                    string[] nowacecha = { textBox_nazwa_01param.Text, textBox_komentarz_01param.Text, "0", "0" };      // oraz dodaje element do listview i grupy
                    var cecha = new ListViewItem(nowacecha, istnieje);
                    edytor_lista.Items.Add(cecha);
                }
            }







        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem powtorzona = edytor_lista.FindItemWithText(textBox_nazwa_zakresparam.Text);
            if (powtorzona != null)
            {
                MessageBox.Show("Cecha " + powtorzona.ToString() + " już istnieje!");
            }
            else
            {

                string naglowek_grupy = "Cechy Zakresowe";
                ListViewGroup edytor_lista_cechyzakresowe = new ListViewGroup(naglowek_grupy);
                ListViewGroup istnieje = null;
                foreach (ListViewGroup grupa in edytor_lista.Groups)
                {
                    if (grupa.Header == edytor_lista_cechyzakresowe.Header)
                    { istnieje = grupa; break; }
                }
                if (istnieje == null)                                                                      // Jeżeli nie znajdzie istniejącą grupę
                {
                    edytor_lista.Groups.Add(edytor_lista_cechyzakresowe);                               // Tworzy ją
                    string[] nowacecha = { textBox_nazwa_zakresparam.Text, textBox_komentarz_zakresparam.Text, textBox_minimum_zakresparam.Text, textBox_maximum_zakresparam.Text };      // oraz dodaje element do listview i grupy
                    var cecha = new ListViewItem(nowacecha, edytor_lista_cechyzakresowe);
                    edytor_lista.Items.Add(cecha);

                }
                if (istnieje != null)
                {                                                                                                // oraz dodaje element do listview i grupy
                    string[] nowacecha = { textBox_nazwa_zakresparam.Text, textBox_komentarz_zakresparam.Text, textBox_minimum_zakresparam.Text, textBox_maximum_zakresparam.Text }; 
                    var cecha = new ListViewItem(nowacecha, istnieje);
                    edytor_lista.Items.Add(cecha);
                }
            }
        }

            private void edytor_skasuj_Click(object sender, EventArgs e)
            {
                if (edytor_lista.SelectedItems != null)
                {
                    var confirmation = MessageBox.Show(
                    "Czy chcesz usunąć zaznaczone elementy?",
                    "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                );

                    //ListViewItem zaznaczone = ListView.CheckedIndexCollection();
                    if (confirmation == DialogResult.Yes)
                    {
                        for (int i = edytor_lista.Items.Count - 1; i >= 0; i--)
                        {
                            if (edytor_lista.Items[i].Selected)
                            {
                                edytor_lista.Items[i].Remove();
                            }
                        }
                    }
                }
            }

            private void edytor_plik_zapisz_Click(object sender, EventArgs e)
            {
                using (var plik = File.CreateText(@"c:\temp\bankcech.bank"))
                {
                    plik.WriteLine("-");
                    plik.WriteLine(opis.Text);
                    plik.WriteLine("-");
                    for (int i = 0; i < edytor_lista.Items.Count; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            plik.WriteLine("-");
                            string a = edytor_lista.Items[i].SubItems[j].Text;
                            plik.WriteLine(a);
                        }
                        plik.WriteLine("-");


                    }
                }

                //string[] podaj;
                //edytor_lista.Items.CopyTo(podaj);
                //string dane = Newtonsoft.Json.JsonConvert.SerializeObject(edytor_lista.Items);
                //int b = 99;
                //string[] a = { };
                //edytor_lista.Items.CopyTo(a, b);


                    //ListViewItem[] a = new ListViewItem[edytor_lista.Items.Count];
                    //edytor_lista.Items.CopyTo(a, 0);
                    //ListViewItem a = edytor_lista.Items.CopyTo()
                    /*var myList = new List<string>();
                    foreach (ListViewItem Item in edytor_lista.SelectedItems)
                    {
                        myList.add(Item.Text.ToString());
                    }
                    var myArray = myList.ToArray();
                    plik.WriteLine(myArray);*/
                

            }

            private void edytor_plik_otworz_Click(object sender, EventArgs e)
            {
                string naglowek_grupy = "Cechy Zakresowe";
                ListViewGroup edytor_lista_cechyzakresowe = new ListViewGroup(naglowek_grupy);
                ListViewGroup istnieje = null;
                foreach (ListViewGroup grupa in edytor_lista.Groups)
                {
                    if (grupa.Header == edytor_lista_cechyzakresowe.Header)
                    { istnieje = grupa; break; }
                }


                string dane;
                using (var plik = File.OpenText(@"d:\bankcech.json"))
                {
                    dane = plik.ReadToEnd();
                }


                if (istnieje == null)                                                                      // Jeżeli nie znajdzie istniejącą grupę
                {
                    edytor_lista.Groups.Add(edytor_lista_cechyzakresowe);                               // Tworzy ją

                    
                    //Cech_wczyt p = Newtonsoft.Json.JsonConvert.DeserializeObject<Cech_wczyt>(dane);
                    //List<Cech_wczyt> edytor_lista = new List<Cech_wczyt>();
                    //textBox_komentarz_01param.Text = newList.ToString;
                    //string[] nowacecha = { };      // oraz dodaje element do listview i grupy
                    //textBox_nazwa_zakresparam.Text = element.ListViewItem;
                    //var cecha = new ListViewItem(newList, edytor_lista_cechyzakresowe);
                    //edytor_lista.Items.Add(cecha);

                }
                if (istnieje != null)
                {                                                                                                // oraz dodaje element do listview i grupy
                    string[] nowacecha = { textBox_nazwa_zakresparam.Text, textBox_komentarz_zakresparam.Text, textBox_minimum_zakresparam.Text, textBox_maximum_zakresparam.Text };
                    var cecha = new ListViewItem(nowacecha, istnieje);
                    edytor_lista.Items.Add(cecha);
                }

                //textBox_komentarz_01param.Text = wczyt;
            }

            private void edytor_plik_nowy_Click(object sender, EventArgs e)
            {


                var confirmation = MessageBox.Show(
                "Zacząć od początku?",
                "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmation == DialogResult.Yes)
                {
                edytor_lista.Items.Clear();
                textBox_nazwa_01param.Text = "";
                textBox_nazwa_zakresparam.Text = "";
                textBox_komentarz_01param.Text = "";
                textBox_komentarz_zakresparam.Text = "";
                textBox_maximum_zakresparam.Text = "";
                textBox_minimum_zakresparam.Text = "";
                opis.Text = "";
                }

            }

            private void edytor_widok_pelnyekran_Click(object sender, EventArgs e)
            {
               
            }

            private void edytor_edycja_znajdz_Click(object sender, EventArgs e)
            {
               
            }

            private void edytor_plik_zapisz_uzyj_Click(object sender, EventArgs e)
            {

            }

            private void edytor_plik_zapisz_uzyj_Click_1(object sender, EventArgs e)
            {
                using (var plik = File.CreateText(@"d:\bankcech3.bank"))
                {
                    plik.WriteLine("-");
                    plik.WriteLine(opis.Text);
                    plik.WriteLine("-");
                    for (int i = 0; i < edytor_lista.Items.Count; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            plik.WriteLine("-");
                            string a = edytor_lista.Items[i].SubItems[j].Text;
                            plik.WriteLine(a);
                        }
                        plik.WriteLine("-");


                    }
                }
                kalkulator kalkulator = new kalkulator();
                kalkulator.Show();
                string[,] tab = new string[edytor_lista.Items.Count, 4];
                for (int i = 0; (i < edytor_lista.Items.Count); i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        tab[i, j] = edytor_lista.Items[i].SubItems[j].Text;
                    }

                }
                var confirmation = MessageBox.Show(
                            "Wczytać dane z edytora?",
                            "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmation == DialogResult.Yes)
                            {
                                ziu zapisziuzyj = new ziu();
                                zapisziuzyj.metoda(tab, edytor_lista.Items.Count);
                            }


            }
    }
}