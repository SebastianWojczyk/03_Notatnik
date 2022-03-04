using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_Notatnik
{
    public partial class FormKonfiguracja : Form
    {
        public Color KolorCzcionki
        {
            get => labelTest.ForeColor;
            set => labelTest.ForeColor = value;
        }
        public Color KolorTla
        {
            get => labelTest.BackColor;
            set => labelTest.BackColor = value;
        }
        public Font Czcionka
        {
            get => labelTest.Font;
            set => labelTest.Font = value;
        }

        public FormKonfiguracja()
        {
            InitializeComponent();
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
        private void buttonAnuluj_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void buttonKolorCzcionki_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                KolorCzcionki = cd.Color;
            }
        }

        private void buttonKolorTla_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                KolorTla = cd.Color;
            }
        }

        private void buttonCzcionka_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                Czcionka = fd.Font;
            }
        }
    }
}
