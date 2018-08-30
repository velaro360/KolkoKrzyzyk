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
    public partial class Form2 : Form
    {
        StreamWriter sw;
        public string poziom;
        string data = DateTime.Now.ToString("dd/MM/yyyy");
        Form3 f;

        public Form2()
        {
            InitializeComponent();
        }

        private void zatwierdz_Click(object sender, EventArgs e)
        {
            if(poziom == "latwy")
            {
                sw = File.AppendText(@"..\..\Zawartosc\rank_latwy.txt");
                sw.WriteLine(tbImie.Text);
                sw.WriteLine(czas_value.Text);
                sw.WriteLine(data);
            }

            if (poziom == "trudny")
            {
                sw = File.AppendText(@"..\..\Zawartosc\rank_trudny.txt");
                sw.WriteLine(tbImie.Text);
                sw.WriteLine(czas_value.Text);
                sw.WriteLine(data);
            }

            sw.Close();
            zatwierdz.Text = "Zatwierdzono";
            zatwierdz.Enabled = false;
        }

        private void zobacz_Click(object sender, EventArgs e)
        {
            f = new Form3(poziom);
            f.Show();
        }
    }
}
