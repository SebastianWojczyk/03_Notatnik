using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_Notatnik
{
    public partial class FormEdytor : Form
    {
        private string plikSciezka = "";
        private bool czyZmieniony;
        public string PlikSciezka
        {
            set
            {
                plikSciezka = value;
                aktualizujInfo();
            }
            get
            {
                return plikSciezka;
            }
        }
        public bool CzyZmieniony
        {
            set
            {
                czyZmieniony = value;
                aktualizujInfo();
            }
            get
            {
                return czyZmieniony;
            }
        }

        public FormEdytor()
        {
            InitializeComponent();
            nowyToolStripMenuItem_Click(null, null);
        }
        private void aktualizujInfo()
        {
            if (PlikSciezka == "")
            {
                this.Text = "Nowy plik";
            }
            else
            {
                this.Text = Path.GetFileName(PlikSciezka);
            }
            if (CzyZmieniony)
            {
                this.Text += " *";
            }
        }
        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CzyZmieniony)
            {
                PytanieZapiszZmiany();
            }
            PlikSciezka = "";
            richTextBoxEdytor.Clear();
            CzyZmieniony = false;
        }
        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CzyZmieniony)
            {
                PytanieZapiszZmiany();
            }
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Pliki TXT|*.txt|Pliki BAT|*.bat|Wszystko|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                PlikSciezka = ofd.FileName;
                richTextBoxEdytor.Text = File.ReadAllText(PlikSciezka);
                CzyZmieniony = false;
            }
        }
        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PlikSciezka == "")
            {
                zapiszJakoToolStripMenuItem_Click(sender, e);
            }
            else
            {
                File.WriteAllText(PlikSciezka, richTextBoxEdytor.Text);
                CzyZmieniony = false;
            }
        }
        private void zapiszJakoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Pliki TXT|*.txt|Pliki BAT|*.bat|Wszystko|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                PlikSciezka = sfd.FileName;
                File.WriteAllText(PlikSciezka, richTextBoxEdytor.Text);
                CzyZmieniony = false;
            }
        }

        private void richTextBoxEdytor_TextChanged(object sender, EventArgs e)
        {
            CzyZmieniony = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CzyZmieniony)
            {
                PytanieZapiszZmiany();
            }
        }

        private void PytanieZapiszZmiany()
        {
            if (MessageBox.Show("Czy chcesz zapisać zmiany?",
                                               "UWAGA - dokonano zmian w dokumencie.",
                                               MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                zapiszToolStripMenuItem_Click(null, null);
            }
        }

        private void konfiguracjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKonfiguracja fk = new FormKonfiguracja();
            fk.KolorCzcionki = richTextBoxEdytor.ForeColor;
            fk.KolorTla = richTextBoxEdytor.BackColor;
            fk.Czcionka = richTextBoxEdytor.Font;
            if (fk.ShowDialog() == DialogResult.OK)
            {
                richTextBoxEdytor.ForeColor = fk.KolorCzcionki;
                richTextBoxEdytor.BackColor = fk.KolorTla;
                richTextBoxEdytor.Font = fk.Czcionka;
            }
        }
    }
}