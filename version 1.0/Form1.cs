using System.Security.Cryptography;
using System.Windows.Forms;

namespace ScherSteinPapier
{
    public partial class Form1 : Form
    {
        int userChoice;
        int opponentChoice;
        int highscore = 0;
        string highscoreString;
        string data;

        public Form1()
        {
            InitializeComponent();
            data = ReadingFile(GetPath());
            string[] list = data.Split(',');

            int namePosition = list.Length - 2;
            labelPlayerName.Text = list[namePosition];
        }

        private void buttonScissors_Click(object sender, EventArgs e)
        {
            HideButtons();
            labelUserChoice.Visible = true;
            labelUserChoice.Text = "Du hast Schere gewählt!";
            OpponentSelects();
            userChoice = 1;
            CompareInputs();
            buttonFinish.Visible = true;
            buttonNext.Visible = true;
        }

        private void buttonStone_Click(object sender, EventArgs e)
        {
            HideButtons();
            labelUserChoice.Visible = true;
            labelUserChoice.Text = "Du hast Stein gewählt!";
            userChoice = 2;
            OpponentSelects();
            CompareInputs();
            buttonFinish.Visible = true;
            buttonNext.Visible = true;
        }

        private void buttonPaper_Click(object sender, EventArgs e)
        {
            HideButtons();
            labelUserChoice.Visible = true;
            labelUserChoice.Text = "Du hast Papier gewählt!";
            userChoice = 3;
            OpponentSelects();
            CompareInputs();
            buttonFinish.Visible = true;
            buttonNext.Visible = true;
        }

        void HideButtons()
        {
            buttonScissors.Visible = false;
            buttonStone.Visible = false;
            buttonPaper.Visible = false;
        }

        void OpponentSelects()
        {
            Random rnd = new Random();
            opponentChoice = rnd.Next(1, 4); //1 = Schere, 2 = Stein, 3 = Papier
            labelOpponentChoice.Visible = true;

            if (opponentChoice == 1)
            {
                labelOpponentChoice.Text = "Der Gegner hat Schere gewählt!";
            }
            if (opponentChoice == 2)
            {
                labelOpponentChoice.Text = "Der Gegner hat Stein gewählt!";
            }
            if (opponentChoice == 3)
            {
                labelOpponentChoice.Text = "Der Gegner hat Papier gewählt!";
            }
        }

        void CompareInputs()
        {
            if (userChoice == 1 && opponentChoice == 1 ||
                userChoice == 2 && opponentChoice == 2 ||
                userChoice == 3 && opponentChoice == 3)
            {
                labelWinner.Visible = true;
                labelWinner.Text = "UNENTSCHIEDEN!";
            }
            if (userChoice == 1 && opponentChoice == 3 ||
                userChoice == 2 && opponentChoice == 1 ||
                userChoice == 3 && opponentChoice == 2)
            {
                labelWinner.Visible = true;
                labelWinner.Text = "Du hast GEWONNEN!";
                highscore = highscore + 1;
            }
            if (userChoice == 3 && opponentChoice == 1 ||
                userChoice == 1 && opponentChoice == 2 ||
                userChoice == 2 && opponentChoice == 3)
            {
                labelWinner.Visible = true;
                labelWinner.Text = "Du hast VERLOREN!";
            }
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            this.Close();
            FormStart frmStart = new FormStart();
            frmStart.ShowDialog();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            int round = Convert.ToInt32(labelRound.Text);
            labelRound.Text = Convert.ToString(round + 1);

            buttonNext.Visible = false;
            buttonScissors.Visible = true;
            buttonStone.Visible = true;
            buttonPaper.Visible = true;
            labelUserChoice.Visible = false;
            labelOpponentChoice.Visible = false;
            labelWinner.Visible = false;
        }
        static string GetPath()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "highscore.txt");
        }
        static string ReadingFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                return File.ReadAllText(fileName);
            }
            return "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelRound.Text = "1";
        }

        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            highscoreString = highscore.ToString();
            data = ReadingFile(GetPath());
            string content = data + highscoreString + ",";
            string path = GetPath();
            File.WriteAllText(path, content);
        }
    }
}