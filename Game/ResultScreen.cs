using System;
using System.Windows.Forms;

namespace EscapeRoomGame
{
    public partial class ResultsScreen : Form
    {
        private int finalScore;

        public ResultsScreen(int score)  // Constructor that accepts the final score
        {
            InitializeComponent();
            finalScore = score;
            lblFinalScore.Text = "Final Score: " + finalScore.ToString();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Close();
        }

        private void lblFinalScore_Click(object sender, EventArgs e)
        {
            // Optional: Add functionality if you want to do something when the label is clicked
        }
    }
}
