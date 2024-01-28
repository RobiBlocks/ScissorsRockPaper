using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScherSteinPapier
{
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            string daten = Datenleser(GetPath());
            string playerName = textBoxName.Text;
            string inhalt = daten + playerName + ",";
            string pfad = GetPath();
            File.WriteAllText(pfad, inhalt);
            Form1 frm1 = new Form1();
            frm1.ShowDialog();
            this.Close();
        }

        private void buttonBeenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormStart_Load(object sender, EventArgs e)
        {
            string scoreAnzeige = Datenleser(GetPath());
            labelScore.Text = scoreAnzeige;
        }
        static string GetPath()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "highscore.txt");
        }
        static string Datenleser(string dateiName)
        {
            if (File.Exists(dateiName))
            {
                return File.ReadAllText(dateiName);
            }
            return "";
        }
    }
}
