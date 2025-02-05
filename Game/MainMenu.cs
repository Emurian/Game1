using System;
using System.Windows.Forms;

namespace EscapeRoomGame
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnMath_Click(object sender, EventArgs e)
        {
            MathGame mathGame = new MathGame();
            mathGame.Show();
            this.Hide();
        }

        private void btnLogic_Click(object sender, EventArgs e)
        {
            LogicGame logicGame = new LogicGame();
            logicGame.Show();
            this.Hide();
        }

        private void btnPattern_Click(object sender, EventArgs e)
        {
            PatternGame patternGame = new PatternGame();
            patternGame.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
