using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace rok_11_7_2014
{
    public partial class RezervacijaSjedista : Form
    {
        private string sjediste;
        public string krajnje_sjediste;
        public bool promjene = false;
        public RezervacijaSjedista(string putnik, string sjediste)
        {
            InitializeComponent();
            this.Text = "Putnik: " + putnik;
            this.sjediste = sjediste;
            izborSjedista(this.sjediste);
            this.toolStripStatusLabelVrijeme.Text = DateTime.Now.ToString("HH:mm:ss   dd:MM:yyyy");

        }

        private void izborSjedista(string sjediste)
        {

            foreach (Control ct in tableLayoutPanel1.Controls)
            {
                Button bt = (Button)ct;
                if (bt.Text.CompareTo(sjediste) == 0 && bt!=buttonVozac1 && bt!=buttonVozac2)
                {
                    bt.BackColor = Color.Red;
                }
            }
            this.krajnje_sjediste = sjediste;
            //switch (sjediste)
            //{
            //    case "1":
            //        buttonSjediste1.BackColor = Color.Red;            
            //        break;
            //    case "2":
            //        buttonSjediste2.BackColor = Color.Red;
            //        break;
            //    case "3":
            //        buttonSjediste3.BackColor = Color.Red;
            //        break;
            //    case "4":
            //        buttonSjediste4.BackColor = Color.Red;
            //        break;
            //    case "5":
            //        buttonSjediste5.BackColor = Color.Red;
            //        break;
            //    case "6":
            //        buttonSjediste6.BackColor = Color.Red;
            //        break;
            //    case "7":
            //        buttonSjediste7.BackColor = Color.Red;
            //        break;
            //    case "8":
            //        buttonSjediste8.BackColor = Color.Red;
            //        break;
            //    case "9":
            //        buttonSjediste9.BackColor = Color.Red;
            //        break;
            //    case "10":
            //        buttonSjediste10.BackColor = Color.Red;
            //        break;
            //    case "11":
            //        buttonSjediste11.BackColor = Color.Red;
            //        break;
            //    case "12":
            //        buttonSjediste12.BackColor = Color.Red;
            //        break;
            //    case "13":
            //        buttonSjediste13.BackColor = Color.Red;
            //        break;
            //    case "14":
            //        buttonSjediste14.BackColor = Color.Red;
            //        break;
            //    case "15":
            //        buttonSjediste15.BackColor = Color.Red;
            //        break;
            //    case "16":
            //        buttonSjediste16.BackColor = Color.Red;
            //        break;
            //    case "17":
            //        buttonSjediste17.BackColor = Color.Red;
            //        break;
            //    case "18":
            //        buttonSjediste18.BackColor = Color.Red;
            //        break;
            //    case "19":
            //        buttonSjediste19.BackColor = Color.Red;
            //        break;
            //    case "20":
            //        buttonSjediste20.BackColor = Color.Red;
            //        break;
            //    case "21":
            //        buttonSjediste21.BackColor = Color.Red;
            //        break;
            //    default:
            //        break;


            //}
        }
        private void buttonSjediste_Click(object sender, EventArgs e)
        {
            Button dugme = (Button)sender;
            foreach (Control b in tableLayoutPanel1.Controls)
            {
                if (b is Button)
                {
                    if (b != buttonVozac1 && b != buttonVozac2)
                    {
                        b.BackColor = Color.Green;
                    }
                }        
            }
            izborSjedista(dugme.Text);
            promjene = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabelVrijeme.Text = DateTime.Now.ToString("HH:mm:ss   dd:MM:yyyy");
        }
    }
}
