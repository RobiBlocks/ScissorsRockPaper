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
            string data = ReadingFile(GetPath());
            string playerName = textBoxName.Text;
            string content = data + playerName + ",";
            string path = GetPath();
            File.WriteAllText(path, content);
            Form1 frm1 = new Form1();
            frm1.ShowDialog();
            this.Close();
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormStart_Load(object sender, EventArgs e)
        {
            string scoreDisplay = ReadingFile(GetPath());
            labelScore.Text = scoreDisplay;
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
    }
}
