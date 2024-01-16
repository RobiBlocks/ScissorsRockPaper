using System.Security.Cryptography;

namespace ScherSteinPapier
{
    public partial class Form1 : Form
    {
        int benutzerWahl;
        int gegnerWahl;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSchere_Click(object sender, EventArgs e)
        {
            EingabeButtonsVerschwinden();
            labelBenutzerWahl.Visible = true;
            labelBenutzerWahl.Text = "Du hast Schere gewählt!";
            GegnerWählt();
            benutzerWahl = 1;
            GewinnVergleich();
            buttonBeenden.Visible = true;
        }

        private void buttonStein_Click(object sender, EventArgs e)
        {
            EingabeButtonsVerschwinden();
            labelBenutzerWahl.Visible = true;
            labelBenutzerWahl.Text = "Du hast Stein gewählt!";
            benutzerWahl = 2;
            GegnerWählt();
            GewinnVergleich();
            buttonBeenden.Visible = true;
        }

        private void buttonPapier_Click(object sender, EventArgs e)
        {
            EingabeButtonsVerschwinden();
            labelBenutzerWahl.Visible = true;
            labelBenutzerWahl.Text = "Du hast Papier gewählt!";
            benutzerWahl = 3;
            GegnerWählt();
            GewinnVergleich();
            buttonBeenden.Visible = true;
        }

        void EingabeButtonsVerschwinden()
        {
            buttonSchere.Visible = false;
            buttonStein.Visible = false;
            buttonPapier.Visible = false;
        }

        void GegnerWählt()
        {
            Random rnd = new Random();
            gegnerWahl = rnd.Next(1, 4); //1 = Schere, 2 = Stein, 3 = Papier
            labelGegnerWahl.Visible = true;

            if (gegnerWahl == 1)
            {
                labelGegnerWahl.Text = "Der Gegner hat Schere gewählt!";
            }
            if (gegnerWahl == 2)
            {
                labelGegnerWahl.Text = "Der Gegner hat Stein gewählt!";
            }
            if (gegnerWahl == 3)
            {
                labelGegnerWahl.Text = "Der Gegner hat Papier gewählt!";
            }
        }

        void GewinnVergleich()
        {
            if (benutzerWahl == 1 && gegnerWahl == 1 ||
                benutzerWahl == 2 && gegnerWahl == 2 ||
                benutzerWahl == 3 && gegnerWahl == 3)
            {
                labelGewinner.Visible = true;
                labelGewinner.Text = "UNENTSCHIEDEN!";
            }
            if (benutzerWahl == 1 && gegnerWahl == 3 ||
                benutzerWahl == 2 && gegnerWahl == 1 ||
                benutzerWahl == 3 && gegnerWahl == 2)
            {
                labelGewinner.Visible = true;
                labelGewinner.Text = "Du hast GEWONNEN!";
            }
            if (benutzerWahl == 3 && gegnerWahl == 1 ||
                benutzerWahl == 1 && gegnerWahl == 2 ||
                benutzerWahl == 2 && gegnerWahl == 3)
            {
                labelGewinner.Visible = true;
                labelGewinner.Text = "Du hast VERLOREN!";
            }
        }

        private void buttonBeenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}