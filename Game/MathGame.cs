using System;
using System.Windows.Forms;

namespace EscapeRoomGame
{
    public partial class MathGame : Form
    {
        private Random rand = new Random();
        private int num1, num2, correctAnswer;
        private int score = 0;
        private int timeLeft = 60;

        public MathGame()
        {
            InitializeComponent();
            LoadMathQuestion();
            gameTimer.Interval = 1000; // 1 second
            gameTimer.Tick += gameTimer_Tick;
            gameTimer.Start();
        }

        private void LoadMathQuestion()
        {
            num1 = rand.Next(1, 20);
            num2 = rand.Next(1, 20);
            correctAnswer = num1 + num2;
            lblQuestion.Text = $"{num1} + {num2} = ?";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int userAnswer;
            if (int.TryParse(txtAnswer.Text, out userAnswer) && userAnswer == correctAnswer)
            {
                score += 10;
                lblScore.Text = "Score: " + score;
                LoadMathQuestion();
            }
            else
            {
                MessageBox.Show("Wrong Answer!");
            }
            txtAnswer.Clear();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            lblTimer.Text = "Time Left: " + timeLeft;

            if (timeLeft == 0)
            {
                gameTimer.Stop();
                MessageBox.Show("Time's up!");
                ResultsScreen results = new ResultsScreen(score);
                results.Show();
                this.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Close();
        }
    }
}
