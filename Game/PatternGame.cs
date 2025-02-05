using System;
using System.Windows.Forms;

namespace EscapeRoomGame
{
    public partial class PatternGame : Form
    {
        private string[] patterns = { "2, 4, 6, 8, ?", "1, 1, 2, 3, 5, ?" };
        private string[] patternAnswers = { "10", "8" };
        private Random rand = new Random();
        private int patternIndex;
        private int score = 0;

        public PatternGame()
        {
            InitializeComponent(); // This calls the InitializeComponent() method from the designer.
            LoadPattern();
        }

        private void LoadPattern()
        {
            patternIndex = rand.Next(patterns.Length);
            lblQuestion.Text = patterns[patternIndex];
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtAnswer.Text == patternAnswers[patternIndex])
            {
                score += 10;
                lblScore.Text = "Score: " + score;
                LoadPattern();
            }
            else
            {
                MessageBox.Show("Wrong Answer!");
            }
            txtAnswer.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Close();
        }

        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }
    }
}
