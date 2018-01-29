namespace Kalkulator_Dopasowań
{
    partial class edytor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Cechy zakresowe", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Cechy rangowe", System.Windows.Forms.HorizontalAlignment.Left);
            this.pasek_edytora = new System.Windows.Forms.MenuStrip();
            this.edytor_plik = new System.Windows.Forms.ToolStripMenuItem();
            this.edytor_plik_nowy = new System.Windows.Forms.ToolStripMenuItem();
            this.edytor_plik_otworz = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.edytor_plik_zapisz = new System.Windows.Forms.ToolStripMenuItem();
            this.edytor_plik_zapiszjako = new System.Windows.Forms.ToolStripMenuItem();
            this.edytor_plik_zapisz_uzyj = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.edytor_plik_zakoncz = new System.Windows.Forms.ToolStripMenuItem();
            this.editor_file_exiteditor = new System.Windows.Forms.ToolStripMenuItem();
            this.edytor_edycja = new System.Windows.Forms.ToolStripMenuItem();
            this.edytor_edycja_cofnij = new System.Windows.Forms.ToolStripMenuItem();
            this.edytor_edycja_powtorz = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.edytor_edycja_znajdz = new System.Windows.Forms.ToolStripMenuItem();
            this.edytor_widok = new System.Windows.Forms.ToolStripMenuItem();
            this.edytor_widok_pelnyekran = new System.Windows.Forms.ToolStripMenuItem();
            this.edytor_tabcontrol = new System.Windows.Forms.TabControl();
            this.edytor_opis = new System.Windows.Forms.TabPage();
            this.opis = new System.Windows.Forms.TextBox();
            this.edytor_01param = new System.Windows.Forms.TabPage();
            this.textBox_komentarz_01param = new System.Windows.Forms.TextBox();
            this.textBox_nazwa_01param = new System.Windows.Forms.TextBox();
            this.label_nazwa_cechy_01 = new System.Windows.Forms.Label();
            this.edytor_01param_dodaj = new System.Windows.Forms.Button();
            this.edytor_zakresparam = new System.Windows.Forms.TabPage();
            this.textBox_komentarz_zakresparam = new System.Windows.Forms.TextBox();
            this.textBox_maximum_zakresparam = new System.Windows.Forms.TextBox();
            this.textBox_minimum_zakresparam = new System.Windows.Forms.TextBox();
            this.label_maximum_zakresparam = new System.Windows.Forms.Label();
            this.label_minimum_zakresparam = new System.Windows.Forms.Label();
            this.textBox_nazwa_zakresparam = new System.Windows.Forms.TextBox();
            this.label_nazwa_cechy_zakresparam = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.edytor_rangparam = new System.Windows.Forms.TabPage();
            this.textBox_nazwa_rangparam = new System.Windows.Forms.TextBox();
            this.label_nazwa_cechy_rang = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.edytor_skasuj = new System.Windows.Forms.Button();
            this.edytor_lista = new System.Windows.Forms.ListView();
            this.edytot_lista_kol_nazwacechy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.edytot_lista_kol_komentarz = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.edytot_lista_kol_minimum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.edytot_lista_kol_maximum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.edytor_skasuj_wszystko = new System.Windows.Forms.Button();
            this.edytor_edytuj_zaznaczone = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pasek_edytora.SuspendLayout();
            this.edytor_tabcontrol.SuspendLayout();
            this.edytor_opis.SuspendLayout();
            this.edytor_01param.SuspendLayout();
            this.edytor_zakresparam.SuspendLayout();
            this.edytor_rangparam.SuspendLayout();
            this.SuspendLayout();
            // 
            // pasek_edytora
            // 
            this.pasek_edytora.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pasek_edytora.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edytor_plik,
            this.edytor_edycja,
            this.edytor_widok});
            this.pasek_edytora.Location = new System.Drawing.Point(0, 0);
            this.pasek_edytora.Name = "pasek_edytora";
            this.pasek_edytora.Size = new System.Drawing.Size(1184, 24);
            this.pasek_edytora.TabIndex = 0;
            this.pasek_edytora.Text = "Pasek narzędzi edytora";
            // 
            // edytor_plik
            // 
            this.edytor_plik.BackColor = System.Drawing.Color.LightCyan;
            this.edytor_plik.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edytor_plik_nowy,
            this.edytor_plik_otworz,
            this.toolStripSeparator1,
            this.edytor_plik_zapisz,
            this.edytor_plik_zapiszjako,
            this.edytor_plik_zapisz_uzyj,
            this.toolStripSeparator2,
            this.edytor_plik_zakoncz,
            this.editor_file_exiteditor});
            this.edytor_plik.Name = "edytor_plik";
            this.edytor_plik.Size = new System.Drawing.Size(38, 20);
            this.edytor_plik.Text = "Plik";
            // 
            // edytor_plik_nowy
            // 
            this.edytor_plik_nowy.Name = "edytor_plik_nowy";
            this.edytor_plik_nowy.Size = new System.Drawing.Size(167, 22);
            this.edytor_plik_nowy.Text = "Nowy";
            this.edytor_plik_nowy.Click += new System.EventHandler(this.edytor_plik_nowy_Click);
            // 
            // edytor_plik_otworz
            // 
            this.edytor_plik_otworz.Enabled = false;
            this.edytor_plik_otworz.Name = "edytor_plik_otworz";
            this.edytor_plik_otworz.Size = new System.Drawing.Size(167, 22);
            this.edytor_plik_otworz.Text = "Otwórz";
            this.edytor_plik_otworz.Click += new System.EventHandler(this.edytor_plik_otworz_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(164, 6);
            // 
            // edytor_plik_zapisz
            // 
            this.edytor_plik_zapisz.Name = "edytor_plik_zapisz";
            this.edytor_plik_zapisz.Size = new System.Drawing.Size(167, 22);
            this.edytor_plik_zapisz.Text = "Zapisz";
            this.edytor_plik_zapisz.Click += new System.EventHandler(this.edytor_plik_zapisz_Click);
            // 
            // edytor_plik_zapiszjako
            // 
            this.edytor_plik_zapiszjako.Enabled = false;
            this.edytor_plik_zapiszjako.Name = "edytor_plik_zapiszjako";
            this.edytor_plik_zapiszjako.Size = new System.Drawing.Size(167, 22);
            this.edytor_plik_zapiszjako.Text = "Zapisz jako...";
            // 
            // edytor_plik_zapisz_uzyj
            // 
            this.edytor_plik_zapisz_uzyj.Name = "edytor_plik_zapisz_uzyj";
            this.edytor_plik_zapisz_uzyj.Size = new System.Drawing.Size(167, 22);
            this.edytor_plik_zapisz_uzyj.Text = "Zapisz i użyj";
            this.edytor_plik_zapisz_uzyj.Click += new System.EventHandler(this.edytor_plik_zapisz_uzyj_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(164, 6);
            // 
            // edytor_plik_zakoncz
            // 
            this.edytor_plik_zakoncz.Name = "edytor_plik_zakoncz";
            this.edytor_plik_zakoncz.Size = new System.Drawing.Size(167, 22);
            this.edytor_plik_zakoncz.Text = "Zakończ program";
            this.edytor_plik_zakoncz.Click += new System.EventHandler(this.edytor_plik_zakoncz_Click);
            // 
            // editor_file_exiteditor
            // 
            this.editor_file_exiteditor.Name = "editor_file_exiteditor";
            this.editor_file_exiteditor.Size = new System.Drawing.Size(167, 22);
            this.editor_file_exiteditor.Text = "Wyjdź z edytora";
            this.editor_file_exiteditor.Click += new System.EventHandler(this.editor_file_exiteditor_Click);
            // 
            // edytor_edycja
            // 
            this.edytor_edycja.BackColor = System.Drawing.Color.PaleTurquoise;
            this.edytor_edycja.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edytor_edycja_cofnij,
            this.edytor_edycja_powtorz,
            this.toolStripSeparator3,
            this.edytor_edycja_znajdz});
            this.edytor_edycja.Name = "edytor_edycja";
            this.edytor_edycja.Size = new System.Drawing.Size(53, 20);
            this.edytor_edycja.Text = "Edycja";
            // 
            // edytor_edycja_cofnij
            // 
            this.edytor_edycja_cofnij.Enabled = false;
            this.edytor_edycja_cofnij.Name = "edytor_edycja_cofnij";
            this.edytor_edycja_cofnij.Size = new System.Drawing.Size(118, 22);
            this.edytor_edycja_cofnij.Text = "Cofnij";
            // 
            // edytor_edycja_powtorz
            // 
            this.edytor_edycja_powtorz.Enabled = false;
            this.edytor_edycja_powtorz.Name = "edytor_edycja_powtorz";
            this.edytor_edycja_powtorz.Size = new System.Drawing.Size(118, 22);
            this.edytor_edycja_powtorz.Text = "Powtórz";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(115, 6);
            // 
            // edytor_edycja_znajdz
            // 
            this.edytor_edycja_znajdz.Enabled = false;
            this.edytor_edycja_znajdz.Name = "edytor_edycja_znajdz";
            this.edytor_edycja_znajdz.Size = new System.Drawing.Size(118, 22);
            this.edytor_edycja_znajdz.Text = "Znajdź...";
            this.edytor_edycja_znajdz.Click += new System.EventHandler(this.edytor_edycja_znajdz_Click);
            // 
            // edytor_widok
            // 
            this.edytor_widok.BackColor = System.Drawing.Color.LightBlue;
            this.edytor_widok.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edytor_widok_pelnyekran});
            this.edytor_widok.Name = "edytor_widok";
            this.edytor_widok.Size = new System.Drawing.Size(53, 20);
            this.edytor_widok.Text = "Widok";
            // 
            // edytor_widok_pelnyekran
            // 
            this.edytor_widok_pelnyekran.Enabled = false;
            this.edytor_widok_pelnyekran.Name = "edytor_widok_pelnyekran";
            this.edytor_widok_pelnyekran.Size = new System.Drawing.Size(135, 22);
            this.edytor_widok_pelnyekran.Text = "Pełny ekran";
            this.edytor_widok_pelnyekran.Click += new System.EventHandler(this.edytor_widok_pelnyekran_Click);
            // 
            // edytor_tabcontrol
            // 
            this.edytor_tabcontrol.Controls.Add(this.edytor_opis);
            this.edytor_tabcontrol.Controls.Add(this.edytor_01param);
            this.edytor_tabcontrol.Controls.Add(this.edytor_zakresparam);
            this.edytor_tabcontrol.Controls.Add(this.edytor_rangparam);
            this.edytor_tabcontrol.Location = new System.Drawing.Point(434, 27);
            this.edytor_tabcontrol.Multiline = true;
            this.edytor_tabcontrol.Name = "edytor_tabcontrol";
            this.edytor_tabcontrol.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edytor_tabcontrol.SelectedIndex = 0;
            this.edytor_tabcontrol.Size = new System.Drawing.Size(750, 623);
            this.edytor_tabcontrol.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.edytor_tabcontrol.TabIndex = 2;
            // 
            // edytor_opis
            // 
            this.edytor_opis.BackColor = System.Drawing.Color.Tomato;
            this.edytor_opis.Controls.Add(this.opis);
            this.edytor_opis.Location = new System.Drawing.Point(4, 22);
            this.edytor_opis.Name = "edytor_opis";
            this.edytor_opis.Padding = new System.Windows.Forms.Padding(3);
            this.edytor_opis.Size = new System.Drawing.Size(742, 597);
            this.edytor_opis.TabIndex = 3;
            this.edytor_opis.Text = "Opis";
            // 
            // opis
            // 
            this.opis.BackColor = System.Drawing.Color.Linen;
            this.opis.Location = new System.Drawing.Point(7, 6);
            this.opis.Multiline = true;
            this.opis.Name = "opis";
            this.opis.Size = new System.Drawing.Size(729, 554);
            this.opis.TabIndex = 0;
            // 
            // edytor_01param
            // 
            this.edytor_01param.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.edytor_01param.Controls.Add(this.textBox_komentarz_01param);
            this.edytor_01param.Controls.Add(this.textBox_nazwa_01param);
            this.edytor_01param.Controls.Add(this.label_nazwa_cechy_01);
            this.edytor_01param.Controls.Add(this.edytor_01param_dodaj);
            this.edytor_01param.Location = new System.Drawing.Point(4, 22);
            this.edytor_01param.Name = "edytor_01param";
            this.edytor_01param.Padding = new System.Windows.Forms.Padding(3);
            this.edytor_01param.Size = new System.Drawing.Size(742, 597);
            this.edytor_01param.TabIndex = 0;
            this.edytor_01param.Text = "Cechy przeciwne (0/1)";
            // 
            // textBox_komentarz_01param
            // 
            this.textBox_komentarz_01param.BackColor = System.Drawing.Color.PapayaWhip;
            this.textBox_komentarz_01param.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_komentarz_01param.Location = new System.Drawing.Point(11, 323);
            this.textBox_komentarz_01param.Multiline = true;
            this.textBox_komentarz_01param.Name = "textBox_komentarz_01param";
            this.textBox_komentarz_01param.Size = new System.Drawing.Size(725, 237);
            this.textBox_komentarz_01param.TabIndex = 3;
            this.textBox_komentarz_01param.Text = "Wpisz opis...";
            // 
            // textBox_nazwa_01param
            // 
            this.textBox_nazwa_01param.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_nazwa_01param.Location = new System.Drawing.Point(11, 106);
            this.textBox_nazwa_01param.Name = "textBox_nazwa_01param";
            this.textBox_nazwa_01param.Size = new System.Drawing.Size(725, 26);
            this.textBox_nazwa_01param.TabIndex = 2;
            // 
            // label_nazwa_cechy_01
            // 
            this.label_nazwa_cechy_01.AutoSize = true;
            this.label_nazwa_cechy_01.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_nazwa_cechy_01.Location = new System.Drawing.Point(6, 78);
            this.label_nazwa_cechy_01.Name = "label_nazwa_cechy_01";
            this.label_nazwa_cechy_01.Size = new System.Drawing.Size(89, 25);
            this.label_nazwa_cechy_01.TabIndex = 1;
            this.label_nazwa_cechy_01.Text = "Nazwa:";
            // 
            // edytor_01param_dodaj
            // 
            this.edytor_01param_dodaj.BackColor = System.Drawing.Color.PaleGreen;
            this.edytor_01param_dodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.edytor_01param_dodaj.Location = new System.Drawing.Point(6, 6);
            this.edytor_01param_dodaj.Name = "edytor_01param_dodaj";
            this.edytor_01param_dodaj.Size = new System.Drawing.Size(730, 65);
            this.edytor_01param_dodaj.TabIndex = 0;
            this.edytor_01param_dodaj.Text = "DODAJ";
            this.edytor_01param_dodaj.UseVisualStyleBackColor = false;
            this.edytor_01param_dodaj.Click += new System.EventHandler(this.edytor_01param_dodaj_Click);
            // 
            // edytor_zakresparam
            // 
            this.edytor_zakresparam.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.edytor_zakresparam.Controls.Add(this.textBox_komentarz_zakresparam);
            this.edytor_zakresparam.Controls.Add(this.textBox_maximum_zakresparam);
            this.edytor_zakresparam.Controls.Add(this.textBox_minimum_zakresparam);
            this.edytor_zakresparam.Controls.Add(this.label_maximum_zakresparam);
            this.edytor_zakresparam.Controls.Add(this.label_minimum_zakresparam);
            this.edytor_zakresparam.Controls.Add(this.textBox_nazwa_zakresparam);
            this.edytor_zakresparam.Controls.Add(this.label_nazwa_cechy_zakresparam);
            this.edytor_zakresparam.Controls.Add(this.button1);
            this.edytor_zakresparam.Location = new System.Drawing.Point(4, 22);
            this.edytor_zakresparam.Name = "edytor_zakresparam";
            this.edytor_zakresparam.Padding = new System.Windows.Forms.Padding(3);
            this.edytor_zakresparam.Size = new System.Drawing.Size(742, 597);
            this.edytor_zakresparam.TabIndex = 1;
            this.edytor_zakresparam.Text = "Cechy zakresowe";
            // 
            // textBox_komentarz_zakresparam
            // 
            this.textBox_komentarz_zakresparam.BackColor = System.Drawing.Color.PapayaWhip;
            this.textBox_komentarz_zakresparam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_komentarz_zakresparam.Location = new System.Drawing.Point(11, 323);
            this.textBox_komentarz_zakresparam.Multiline = true;
            this.textBox_komentarz_zakresparam.Name = "textBox_komentarz_zakresparam";
            this.textBox_komentarz_zakresparam.Size = new System.Drawing.Size(725, 237);
            this.textBox_komentarz_zakresparam.TabIndex = 9;
            this.textBox_komentarz_zakresparam.Text = "Wpisz opis...";
            // 
            // textBox_maximum_zakresparam
            // 
            this.textBox_maximum_zakresparam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_maximum_zakresparam.Location = new System.Drawing.Point(623, 195);
            this.textBox_maximum_zakresparam.Name = "textBox_maximum_zakresparam";
            this.textBox_maximum_zakresparam.Size = new System.Drawing.Size(113, 26);
            this.textBox_maximum_zakresparam.TabIndex = 8;
            // 
            // textBox_minimum_zakresparam
            // 
            this.textBox_minimum_zakresparam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_minimum_zakresparam.Location = new System.Drawing.Point(11, 195);
            this.textBox_minimum_zakresparam.Name = "textBox_minimum_zakresparam";
            this.textBox_minimum_zakresparam.Size = new System.Drawing.Size(107, 26);
            this.textBox_minimum_zakresparam.TabIndex = 7;
            // 
            // label_maximum_zakresparam
            // 
            this.label_maximum_zakresparam.AutoSize = true;
            this.label_maximum_zakresparam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_maximum_zakresparam.Location = new System.Drawing.Point(618, 167);
            this.label_maximum_zakresparam.Name = "label_maximum_zakresparam";
            this.label_maximum_zakresparam.Size = new System.Drawing.Size(118, 25);
            this.label_maximum_zakresparam.TabIndex = 6;
            this.label_maximum_zakresparam.Text = "Maximum:";
            // 
            // label_minimum_zakresparam
            // 
            this.label_minimum_zakresparam.AutoSize = true;
            this.label_minimum_zakresparam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_minimum_zakresparam.Location = new System.Drawing.Point(6, 167);
            this.label_minimum_zakresparam.Name = "label_minimum_zakresparam";
            this.label_minimum_zakresparam.Size = new System.Drawing.Size(112, 25);
            this.label_minimum_zakresparam.TabIndex = 5;
            this.label_minimum_zakresparam.Text = "Minimum:";
            // 
            // textBox_nazwa_zakresparam
            // 
            this.textBox_nazwa_zakresparam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_nazwa_zakresparam.Location = new System.Drawing.Point(11, 106);
            this.textBox_nazwa_zakresparam.Name = "textBox_nazwa_zakresparam";
            this.textBox_nazwa_zakresparam.Size = new System.Drawing.Size(725, 26);
            this.textBox_nazwa_zakresparam.TabIndex = 4;
            // 
            // label_nazwa_cechy_zakresparam
            // 
            this.label_nazwa_cechy_zakresparam.AutoSize = true;
            this.label_nazwa_cechy_zakresparam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_nazwa_cechy_zakresparam.Location = new System.Drawing.Point(6, 78);
            this.label_nazwa_cechy_zakresparam.Name = "label_nazwa_cechy_zakresparam";
            this.label_nazwa_cechy_zakresparam.Size = new System.Drawing.Size(89, 25);
            this.label_nazwa_cechy_zakresparam.TabIndex = 3;
            this.label_nazwa_cechy_zakresparam.Text = "Nazwa:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(730, 65);
            this.button1.TabIndex = 1;
            this.button1.Text = "DODAJ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // edytor_rangparam
            // 
            this.edytor_rangparam.BackColor = System.Drawing.Color.SkyBlue;
            this.edytor_rangparam.Controls.Add(this.textBox_nazwa_rangparam);
            this.edytor_rangparam.Controls.Add(this.label_nazwa_cechy_rang);
            this.edytor_rangparam.Controls.Add(this.button2);
            this.edytor_rangparam.Location = new System.Drawing.Point(4, 22);
            this.edytor_rangparam.Name = "edytor_rangparam";
            this.edytor_rangparam.Padding = new System.Windows.Forms.Padding(3);
            this.edytor_rangparam.Size = new System.Drawing.Size(742, 597);
            this.edytor_rangparam.TabIndex = 2;
            this.edytor_rangparam.Text = "Cechy rangowe";
            // 
            // textBox_nazwa_rangparam
            // 
            this.textBox_nazwa_rangparam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_nazwa_rangparam.Location = new System.Drawing.Point(11, 106);
            this.textBox_nazwa_rangparam.Name = "textBox_nazwa_rangparam";
            this.textBox_nazwa_rangparam.Size = new System.Drawing.Size(725, 26);
            this.textBox_nazwa_rangparam.TabIndex = 4;
            // 
            // label_nazwa_cechy_rang
            // 
            this.label_nazwa_cechy_rang.AutoSize = true;
            this.label_nazwa_cechy_rang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_nazwa_cechy_rang.Location = new System.Drawing.Point(6, 78);
            this.label_nazwa_cechy_rang.Name = "label_nazwa_cechy_rang";
            this.label_nazwa_cechy_rang.Size = new System.Drawing.Size(89, 25);
            this.label_nazwa_cechy_rang.TabIndex = 3;
            this.label_nazwa_cechy_rang.Text = "Nazwa:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(730, 65);
            this.button2.TabIndex = 1;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // edytor_skasuj
            // 
            this.edytor_skasuj.BackColor = System.Drawing.Color.DarkSalmon;
            this.edytor_skasuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.edytor_skasuj.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.edytor_skasuj.Location = new System.Drawing.Point(112, 615);
            this.edytor_skasuj.Name = "edytor_skasuj";
            this.edytor_skasuj.Size = new System.Drawing.Size(316, 35);
            this.edytor_skasuj.TabIndex = 3;
            this.edytor_skasuj.Text = "USUŃ ZAZNACZONE";
            this.edytor_skasuj.UseVisualStyleBackColor = false;
            this.edytor_skasuj.Click += new System.EventHandler(this.edytor_skasuj_Click);
            // 
            // edytor_lista
            // 
            this.edytor_lista.BackColor = System.Drawing.Color.SeaShell;
            this.edytor_lista.CheckBoxes = true;
            this.edytor_lista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.edytot_lista_kol_nazwacechy,
            this.edytot_lista_kol_komentarz,
            this.edytot_lista_kol_minimum,
            this.edytot_lista_kol_maximum});
            listViewGroup3.Header = "Cechy zakresowe";
            listViewGroup3.Name = "edytor_lista_cechyzakresowe";
            listViewGroup4.Header = "Cechy rangowe";
            listViewGroup4.Name = "edytor_lista_cechyrangowe";
            this.edytor_lista.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup3,
            listViewGroup4});
            this.edytor_lista.Location = new System.Drawing.Point(12, 65);
            this.edytor_lista.Name = "edytor_lista";
            this.edytor_lista.Size = new System.Drawing.Size(416, 544);
            this.edytor_lista.TabIndex = 4;
            this.edytor_lista.UseCompatibleStateImageBehavior = false;
            this.edytor_lista.View = System.Windows.Forms.View.Details;
            // 
            // edytot_lista_kol_nazwacechy
            // 
            this.edytot_lista_kol_nazwacechy.Text = "Nazwa cechy";
            this.edytot_lista_kol_nazwacechy.Width = 155;
            // 
            // edytot_lista_kol_komentarz
            // 
            this.edytot_lista_kol_komentarz.Text = "Komentarz";
            this.edytot_lista_kol_komentarz.Width = 128;
            // 
            // edytot_lista_kol_minimum
            // 
            this.edytot_lista_kol_minimum.Text = "Minimum";
            this.edytot_lista_kol_minimum.Width = 57;
            // 
            // edytot_lista_kol_maximum
            // 
            this.edytot_lista_kol_maximum.Text = "Maximum";
            // 
            // edytor_skasuj_wszystko
            // 
            this.edytor_skasuj_wszystko.BackColor = System.Drawing.Color.Red;
            this.edytor_skasuj_wszystko.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.edytor_skasuj_wszystko.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.edytor_skasuj_wszystko.Location = new System.Drawing.Point(12, 615);
            this.edytor_skasuj_wszystko.Name = "edytor_skasuj_wszystko";
            this.edytor_skasuj_wszystko.Size = new System.Drawing.Size(94, 35);
            this.edytor_skasuj_wszystko.TabIndex = 5;
            this.edytor_skasuj_wszystko.Text = "WYCZYŚĆ WSZYSTKO";
            this.edytor_skasuj_wszystko.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.edytor_skasuj_wszystko.UseVisualStyleBackColor = false;
            // 
            // edytor_edytuj_zaznaczone
            // 
            this.edytor_edytuj_zaznaczone.BackColor = System.Drawing.Color.LemonChiffon;
            this.edytor_edytuj_zaznaczone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.edytor_edytuj_zaznaczone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.edytor_edytuj_zaznaczone.Location = new System.Drawing.Point(12, 27);
            this.edytor_edytuj_zaznaczone.Name = "edytor_edytuj_zaznaczone";
            this.edytor_edytuj_zaznaczone.Size = new System.Drawing.Size(283, 35);
            this.edytor_edytuj_zaznaczone.TabIndex = 6;
            this.edytor_edytuj_zaznaczone.Text = "EDYTUJ ZAZNACZONĄ CECHĘ";
            this.edytor_edytuj_zaznaczone.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Pink;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(301, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 35);
            this.button3.TabIndex = 7;
            this.button3.Text = "POMOC";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // edytor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1184, 662);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.edytor_edytuj_zaznaczone);
            this.Controls.Add(this.edytor_skasuj_wszystko);
            this.Controls.Add(this.edytor_lista);
            this.Controls.Add(this.edytor_skasuj);
            this.Controls.Add(this.pasek_edytora);
            this.Controls.Add(this.edytor_tabcontrol);
            this.MainMenuStrip = this.pasek_edytora;
            this.Name = "edytor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edytor list cech - Kalkulator Dopasowań";
            this.pasek_edytora.ResumeLayout(false);
            this.pasek_edytora.PerformLayout();
            this.edytor_tabcontrol.ResumeLayout(false);
            this.edytor_opis.ResumeLayout(false);
            this.edytor_opis.PerformLayout();
            this.edytor_01param.ResumeLayout(false);
            this.edytor_01param.PerformLayout();
            this.edytor_zakresparam.ResumeLayout(false);
            this.edytor_zakresparam.PerformLayout();
            this.edytor_rangparam.ResumeLayout(false);
            this.edytor_rangparam.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip pasek_edytora;
        private System.Windows.Forms.ToolStripMenuItem edytor_plik;
        private System.Windows.Forms.ToolStripMenuItem edytor_plik_nowy;
        private System.Windows.Forms.ToolStripMenuItem edytor_plik_otworz;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem edytor_plik_zapisz;
        private System.Windows.Forms.ToolStripMenuItem edytor_plik_zapiszjako;
        private System.Windows.Forms.ToolStripMenuItem editor_file_exiteditor;
        private System.Windows.Forms.ToolStripMenuItem edytor_edycja;
        private System.Windows.Forms.ToolStripMenuItem edytor_plik_zapisz_uzyj;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem edytor_edycja_znajdz;
        private System.Windows.Forms.ToolStripMenuItem edytor_plik_zakoncz;
        private System.Windows.Forms.ToolStripMenuItem edytor_edycja_cofnij;
        private System.Windows.Forms.ToolStripMenuItem edytor_edycja_powtorz;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem edytor_widok;
        private System.Windows.Forms.ToolStripMenuItem edytor_widok_pelnyekran;
        private System.Windows.Forms.TabControl edytor_tabcontrol;
        private System.Windows.Forms.TabPage edytor_01param;
        private System.Windows.Forms.TabPage edytor_zakresparam;
        private System.Windows.Forms.TabPage edytor_rangparam;
        private System.Windows.Forms.Label label_nazwa_cechy_01;
        private System.Windows.Forms.Button edytor_01param_dodaj;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button edytor_skasuj;
        private System.Windows.Forms.TextBox textBox_nazwa_01param;
        private System.Windows.Forms.TextBox textBox_nazwa_zakresparam;
        private System.Windows.Forms.Label label_nazwa_cechy_zakresparam;
        private System.Windows.Forms.TextBox textBox_nazwa_rangparam;
        private System.Windows.Forms.Label label_nazwa_cechy_rang;
        private System.Windows.Forms.Label label_maximum_zakresparam;
        private System.Windows.Forms.Label label_minimum_zakresparam;
        private System.Windows.Forms.TextBox textBox_maximum_zakresparam;
        private System.Windows.Forms.TextBox textBox_minimum_zakresparam;
        private System.Windows.Forms.ListView edytor_lista;
        private System.Windows.Forms.ColumnHeader edytot_lista_kol_nazwacechy;
        private System.Windows.Forms.ColumnHeader edytot_lista_kol_komentarz;
        private System.Windows.Forms.ColumnHeader edytot_lista_kol_minimum;
        private System.Windows.Forms.ColumnHeader edytot_lista_kol_maximum;
        private System.Windows.Forms.TextBox textBox_komentarz_01param;
        private System.Windows.Forms.TextBox textBox_komentarz_zakresparam;
        private System.Windows.Forms.TabPage edytor_opis;
        private System.Windows.Forms.TextBox opis;
        private System.Windows.Forms.Button edytor_skasuj_wszystko;
        private System.Windows.Forms.Button edytor_edytuj_zaznaczone;
        private System.Windows.Forms.Button button3;
    }
}