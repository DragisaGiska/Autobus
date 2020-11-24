using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace rok_11_7_2014
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBoxKategorija.SelectedIndex = 0;
            comboBoxLinija.SelectedIndex = 0;
            this.toolStripStatusLabelVrijeme.Text = DateTime.Now.ToString("HH:mm:ss   dd:MM:yyyy");
            dateTimePicker1.MinDate = DateTime.Now;
        }

        private void textBoxSjediste_TextChanged(object sender, EventArgs e)
        {
            int broj;
            if (int.TryParse(textBoxSjediste.Text, out broj) )
            {
                if (int.Parse(textBoxSjediste.Text) < 1 || int.Parse(textBoxSjediste.Text) > 21)
                {
                    MessageBox.Show("Uneseno sjedište ne postoji", "Pogrešan unos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxSjediste.Clear();
                }
            }
            else if(!string.IsNullOrEmpty(textBoxSjediste.Text))
            {
                MessageBox.Show("Uneseno sjedište ne postoji", "Pogrešan unos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxSjediste.Clear();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabelVrijeme.Text = DateTime.Now.ToString("HH:mm:ss   dd:MM:yyyy");
            dateTimePicker1.MinDate = DateTime.Now;
        }

        private void buttonRezervisi_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(textBoxSjediste.Text)) && (!string.IsNullOrEmpty(textBoxputnik.Text)))
            {
                try
                {
                    MessageBox.Show("Uspjesno ste rezervisali sjedište broj: " + textBoxSjediste.Text + "\nFunkcija: " + this.Izracunaj(), "Uspješna rezervacija", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
                finally
                {
                    MessageBox.Show("Uspjesno ste rezervisali sjedište broj: " + textBoxSjediste.Text, "Uspješna rezervacija", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    textBoxSjediste.Clear();
                    textBoxputnik.Clear();
                    comboBoxKategorija.SelectedIndex = 0;
                    comboBoxLinija.SelectedIndex = 0;
                    dateTimePicker1.ResetText();
                }
            }
            else
            {
                MessageBox.Show("Popunite sva polja", "Pogrešan unos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        int Izracunaj()
        {
            int z = 0, x = 1 / z; return x;
        }


        private void buttonSjediste_Click(object sender, EventArgs e)
        {
         
            RezervacijaSjedista rezervacija_sjedista = new RezervacijaSjedista(textBoxputnik.Text, textBoxSjediste.Text);
            DialogResult dr= rezervacija_sjedista.ShowDialog();
            if (rezervacija_sjedista.promjene)
            {
                DialogResult dr2 = MessageBox.Show("Želite li sačuvati promjene", "Pažnja", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dr2 == DialogResult.Yes)
                {
                    textBoxSjediste.Text = rezervacija_sjedista.krajnje_sjediste;
                }
            }
            
        }

        private void panelPozadina_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
