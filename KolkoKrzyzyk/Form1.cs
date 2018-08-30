using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
//using System.IO;

namespace KolkoKrzyzyk
{
    public partial class Form1 : Form
    {
        string[] gracz = new string[9];
        string[,] gracz2 = new string[3, 3];

        bool start = true;
        bool koniec = false;

        public List<PictureBox> obrazki = new List<PictureBox>();

        bool hard = false;
        bool easy = true;

        Stopwatch sw;
        Form2 f;

        public Form1()
        {
            InitializeComponent();
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            f = new Form2();

            if (easy) f.poziom = "latwy";
            if (hard) f.poziom = "trudny";

            if (start)
            {
                start = false;

                obrazki.Add(o1); obrazki.Add(o2); obrazki.Add(o3);
                obrazki.Add(o4); obrazki.Add(o5); obrazki.Add(o6);
                obrazki.Add(o7); obrazki.Add(o8); obrazki.Add(o9);

                foreach (PictureBox obrazek in obrazki)
                {
                    obrazek.Visible = true;
                }

                PictureBox tlo = new PictureBox();
                this.Controls.Add(tlo);
                tlo.Location = new Point(18, 52);
                tlo.Size = new Size(334, 362);
                tlo.BackColor = Color.FromArgb(0, 0, 0);
                tlo.SendToBack();

                sw = new Stopwatch();

                // tu cos kombinowalem ze sciezkami ale jeszcze nie doszedlem do tego jak ma to wygldac
                //sciezkaKrzyzyk = sciezkaKrzyzyk.Replace(@"bin\Debug", @"Zawartosc\krzyzyk.png");
                //sciezkaKrzyzykZ = sciezkaKrzyzykZ.Replace(@"bin\Debug", @"Zawartosc\krzyzykZ.png");
                //sciezkaKolko = sciezkaKolko.Replace(@"bin\Debug", @"Zawartosc\Kolko.png");
                //sciezkaKolkoC = sciezkaKolko.Replace(@"bin\Debug", @"Zawartosc\KolkoC.png");
            }

            else
            {
                Czysc();
            }

            foreach(PictureBox obrazek in obrazki)
            {
                obrazek.Enabled = true;
            }
            sw.Start();
            Czasomierz();
        }

        private async void Czasomierz()
        {
            again:
            czas.Text = await Asynch();
            if (koniec == false) goto again;
        }

        private Task<string> Asynch()
        {
            Task<string> t = new Task<string>(ZwrocCzas);
            t.Start();

            return t;
        }

        private string ZwrocCzas()
        {
            Thread.Sleep(50);
            return Convert.ToString(sw.ElapsedMilliseconds / 1000.00);
        }

        /* Funkcja wstawiająca obrazek po kliknięciu gracza (krzyżyk), a następnie wywołująca,
         * kolejną funkcję, która wstawi (po wybraniu odpowiedniego pola) kółko */
        private void Malowanie(PictureBox o, string kto, int num)
        {
            if (koniec) return;
            int ile = 0;
            if (gracz[num - 1] != null) return;

            o.Image = Image.FromFile(@"..\..\Zawartosc\krzyzyk.png");
            gracz[num - 1] = "czlowiek";

            if (Wygrana("czlowiek"))
            {
                sw.Stop();
                f.czas_value.Text = Convert.ToString(sw.ElapsedMilliseconds / 1000.00);
                f.Show();
                koniec = true;
                return;
            }

            for (int i = 0; i < 9; i++) if (gracz[i] == null) ile++;
            if (ile == 0) return;

            int a = Decyzja();

            gracz[a] = "komputer";
            obrazki[a].Image = Image.FromFile(@"..\..\Zawartosc\kolko.png");

            if (Wygrana("komputer"))
            {
                f.tbImie.Visible = false;
                f.imie.Visible = false;
                f.zatwierdz.Visible = false;
                f.zobacz.Location = new Point(150,110);
                f.czas_value.Visible = false;
                f.czas.Visible = false;
                f.info_wynik.Image = Image.FromFile(@"..\..\Zawartosc\porazka.png");
                f.info_wynik.Location = new Point(75, 20);
                f.Show();
                koniec = true;
            }
        }

        /* Wstawianie w jednej linii zielonych krzyżyków (zw. gracza) lub
         * czerwonych kółek (zw. komputera) */
        private void Malowanie(int a, int b, int c, string kto)
        {
            obrazki[a].Image = Image.FromFile(kto);
            obrazki[b].Image = Image.FromFile(kto);
            obrazki[c].Image = Image.FromFile(kto);
        }

        /*Po wyborze pola przez gracza zapada decyzja (w zależności od poziomu trudności)
         * co komputer ma zrobić*/
        private int Decyzja()
        {
            int liczba = 0;

            for(int i=0; i<3; i++)
            {
                for(int j=0; j<3; j++)
                {
                    if (gracz[liczba] == "czlowiek") gracz2[i, j] = "c";
                    if (gracz[liczba] == "komputer") gracz2[i, j] = "k";
                    if (gracz[liczba] == null ) gracz2[i, j] = null;
                    liczba++;
                }
            }
            
            if (easy)
            {
                return Losowanie();
            }

            if (hard)
            {
                if (Wybieranie() != -1) return Wybieranie();
                else return Losowanie();
            }

            return Losowanie();
        }

        /*Losuje jakieś pole dla komputera*/
        private int Losowanie()
        {
            Random r = new Random();
            int a = r.Next(8);

            while (gracz[a] != null)
            {
                a = r.Next(8);
            }
            return a;
        }

        /*Wybieranie pola przez komputer w sytuacjach krytycznych, tzn takich gdzie w jednej linii
         * są 2 takie same znaki i wystarczy postawić odpowiednio trzeci aby zakończyć grę*/
        private int Wybieranie()
        {
            int liczba;
            int[] wsp = new int[2];
            int nule;
            string kto = "k"; //Najpierw sprawdzam czy komputer ma 2 znaki ustawione w jednej linii...

            if(hard)
            {
                if (gracz[0] == null && gracz[4] == "czlowiek") return 0;

                if (gracz[4] == null)
                {
                    return 4;
                }
            }

            etykieta:

            for (int i = 0; i < 3; i++) //Sprawdzanie wierszy
            {
                liczba = 0;
                nule = 0;
                for (int j = 0; j < 3; j++)
                {
                    if (gracz2[i, j] == kto) liczba++;
                    if (gracz2[i,j] == null) { wsp[0] = i; wsp[1] = j; nule++; }
                }
                if (liczba == 2 && nule != 0) return (3*wsp[0] + wsp[1]);
            }

            for (int i = 0; i < 3; i++) //Sprawdzanie kolumn
            {
                liczba = 0;
                nule = 0;
                for (int j = 0; j < 3; j++)
                {
                    if (gracz2[j, i] == kto) liczba++;
                    if (gracz2[j, i] == null) { wsp[0] = j; wsp[1] = i; nule++; }
                }
                if (liczba == 2 && nule != 0) return wsp[0] * 3 + wsp[1];
            }

            liczba = 0;
            nule = 0;

            for (int i = 0; i < 3; i++) //Sprawdzenie skosu lewy-górny -> prawy-dolny
            {
                if (gracz2[i, i] == kto) liczba++;
                if (gracz2[i, i] == null) { wsp[0] = i; wsp[1] = i; nule++; }
            }
            if (liczba == 2 && nule!=0) return wsp[0] * 3 + wsp[1];

            liczba = 0;
            nule = 0;

            int l = 2;

            for (int i = 0; i < 3; i++) //Sprawdzanie skosu prawy-górny -> lewy-dolny
            {
                if (gracz2[i, l] == kto) liczba++;
                if (gracz2[i, l] == null) { wsp[0] = i; wsp[1] = l; nule++; }
                l--;
            }
            if (liczba == 2 && nule != 0) return wsp[0] * 3 + wsp[1];

            if (kto=="k")
            {
                kto = "c";
                goto etykieta; //... Potem cofam sie i sprawdzam czy gracz ma taką sytuację
            }

            if (hard)
            {
                if (gracz[3] == "czlowiek" && gracz[1] == "czlowiek")
                {
                    if (gracz[0] == null) return 0;
                }

                if (gracz[1] == "czlowiek" && gracz[5] == "czlowiek")
                {
                    if (gracz[2] == null) return 2;
                }

                if (gracz[7] == "czlowiek" && gracz[3] == "czlowiek")
                {
                    if (gracz[6] == null) return 6;
                }

                if (gracz[7] == "czlowiek" && gracz[5] == "czlowiek")
                {
                    if (gracz[8] == null) return 8;
                }
            }

            return -1;
        }

        /* Sprawdzanie czy ktoś wygrał*/
        private bool Wygrana(string kto)
        {
            string sciezka;
            if (kto == "czlowiek") sciezka = @"..\..\Zawartosc\krzyzykZ.png";
            else sciezka = @"..\..\Zawartosc\kolkoC.png";

            if (gracz[0] == gracz[1] && gracz[1] == gracz[2] && gracz[1] != null) { Malowanie(0, 1, 2, sciezka); return true; }
            if (gracz[3] == gracz[4] && gracz[4] == gracz[5] && gracz[4] != null) { Malowanie(3, 4, 5, sciezka); return true; }
            if (gracz[6] == gracz[7] && gracz[7] == gracz[8] && gracz[7] != null) { Malowanie(6, 7, 8, sciezka); return true; }

            if (gracz[0] == gracz[3] && gracz[3] == gracz[6] && gracz[3] != null) { Malowanie(0, 3, 6, sciezka); return true; }
            if (gracz[1] == gracz[4] && gracz[4] == gracz[7] && gracz[4] != null) { Malowanie(1, 4, 7, sciezka); return true; }
            if (gracz[2] == gracz[5] && gracz[5] == gracz[8] && gracz[5] != null) { Malowanie(2, 5, 8, sciezka); return true; }

            if (gracz[0] == gracz[4] && gracz[4] == gracz[8] && gracz[4] != null) { Malowanie(0, 4, 8, sciezka); return true; }
            if (gracz[2] == gracz[4] && gracz[4] == gracz[6] && gracz[4] != null) { Malowanie(2, 4, 6, sciezka); return true; }

            return false;
        }

        private void Czysc()
        {
            koniec = false;
            czas.Text = "0";

            foreach (PictureBox obrazek in obrazki)
            {
                obrazek.Image = Image.FromFile(@"..\..\Zawartosc\empty.png");
                obrazek.Enabled = false;
            }

            for (int i = 0; i < 9; i++) gracz[i] = null;

            if (start == true) return;

            sw.Stop();
            sw.Reset();
        }

        private void o1_Click(object sender, EventArgs e)
        {
            Malowanie(o1, "czlowiek", 1);
        }

        private void o2_Click(object sender, EventArgs e)
        {
            Malowanie(o2, "czlowiek", 2);
        }

        private void o3_Click(object sender, EventArgs e)
        {
            Malowanie(o3, "czlowiek", 3);
        }

        private void o4_Click(object sender, EventArgs e)
        {
            Malowanie(o4, "czlowiek", 4);
        }

        private void o5_Click(object sender, EventArgs e)
        {
            Malowanie(o5, "czlowiek", 5);
        }

        private void o6_Click(object sender, EventArgs e)
        {
            Malowanie(o6, "czlowiek", 6);
        }

        private void o7_Click(object sender, EventArgs e)
        {
            Malowanie(o7, "czlowiek", 7);
        }

        private void o8_Click(object sender, EventArgs e)
        {
            Malowanie(o8, "czlowiek", 8);
        }

        private void o9_Click(object sender, EventArgs e)
        {
            Malowanie(o9, "czlowiek", 9);
        }

        private void latwy_Click(object sender, EventArgs e)
        {
            easy = true; hard = false;
            info_poziom2.Text = "Łatwy";
            info_poziom2.BackColor = Color.FromArgb(128, 255, 128);
            Czysc();
        }

        private void trudny_Click(object sender, EventArgs e)
        {
            easy = false; hard = true;
            info_poziom2.Text = "Trudny";
            info_poziom2.BackColor = Color.FromArgb(250, 163, 163);
            Czysc();
        }
    }

}
