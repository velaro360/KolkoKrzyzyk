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

namespace KolkoKrzyzyk
{
    public partial class Form3 : Form
    {
        List<Label> lista = new List<Label>();

        public Form3(string poziom)
        {
            InitializeComponent();

            if (poziom == "latwy")
                rbLatwy.Checked = true;
            else
                rbTrudny.Checked = true;
        }

        private void rbLatwy_CheckedChanged(object sender, EventArgs e)
        {
            if (lista.Count != 0)
            {
                foreach (Label l in lista)
                {
                    l.Visible = false;
                }
                lista = new List<Label>();
            }

            if (File.Exists(@"..\..\Zawartosc\rank_latwy.txt") == false) File.Create(@"..\..\Zawartosc\rank_latwy.txt");
            Wyswietl(@"..\..\Zawartosc\rank_latwy.txt");

            
        }

        private void rbTrudny_CheckedChanged(object sender, EventArgs e)
        {
            if (lista.Count != 0)
            {
                foreach (Label l in lista)
                {
                    l.Visible = false;
                }
                lista = new List<Label>();
            }

            if (File.Exists(@"..\..\Zawartosc\rank_trudny.txt") == false) File.Create(@"..\..\Zawartosc\rank_trudny.txt");
            Wyswietl(@"..\..\Zawartosc\rank_trudny.txt");
        }

        private void Wyswietl(string sciezka)
        {
            StreamReader sr = new StreamReader(sciezka);
            int x;
            int y = 185;
            int lp = 1;
            int a = 0;

            List<Gracz> gracze = new List<Gracz>();

            while (sr.EndOfStream != true)
            {
                gracze.Add(new Gracz(sr.ReadLine(), sr.ReadLine(), sr.ReadLine()));
            }
            sr.Close();

            List<Gracz> SortowaniGracze = gracze.OrderBy(o => o.czas).ToList();

            for (int i = 0; i < 10; i++)
            {
                if (SortowaniGracze.Count == 0)
                {
                    foreach(Label l in lista)
                    {
                        l.Visible = false;
                    }

                    info_rekordy.Visible = true;
                    return;
                }
                else
                {
                    info_rekordy.Visible = false;
                }

                x = 18;

                /* <LICZBA PORZĄDKOWA> ****************/
                lista.Add(new Label());
                this.Controls.Add(lista[a]);

                lista[a].Text = Convert.ToString(lp)+"."; lp++;
                lista[a].Location = new Point(x, y);
                lista[a].AutoSize = true;
                lista[a].Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
                a++;
                /* </LICZBA PORZĄDKOWA> ****************/

                x += 42;

                /* <IMIĘ> *****************************/
                lista.Add(new Label());
                this.Controls.Add(lista[a]);

                if (SortowaniGracze[i].imie.Length > 11) //Skracanie długich imion
                {
                    SortowaniGracze[i].imie = SortowaniGracze[i].imie.Remove(10);
                    SortowaniGracze[i].imie = SortowaniGracze[i].imie.Insert(10,"...");
                }

                lista[a].Text = SortowaniGracze[i].imie;
                lista[a].Location = new Point(x, y);
                lista[a].AutoSize = true;
                lista[a].Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
                a++;
                /* </IMIĘ> *****************************/

                x += 113;

                /* <CZAS> *****************************/
                lista.Add(new Label());
                this.Controls.Add(lista[a]);

                lista[a].Text = Convert.ToString(SortowaniGracze[i].czas);
                lista[a].Location = new Point(x, y);
                lista[a].AutoSize = true;
                lista[a].Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
                a++;
                /* </CZAS> *****************************/

                x += 99;

                /* <DATA> *****************************/
                lista.Add(new Label());
                this.Controls.Add(lista[a]);

                lista[a].Text = SortowaniGracze[i].data;
                lista[a].Location = new Point(x, y);
                lista[a].AutoSize = true;
                lista[a].Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
                a++;
                /* </DATA> *****************************/

                y += 30;
                if (i + 1 == SortowaniGracze.Count) return;
            }
        }
    }

    public class Gracz
    {
        public string imie;
        public double czas;
        public string data;

        public Gracz(string i, string c, string d)
        {
            imie = i;
            czas = Convert.ToDouble(c);
            data = d;
        }
    }
}
