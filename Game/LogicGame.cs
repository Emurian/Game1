using System;
using System.Windows.Forms;

namespace EscapeRoomGame
{
    public partial class LogicGame : Form
    {
        private string[,] riddles = {
            {"What has to be broken before you can use it?", "Egg"},
            {"I speak without a mouth and hear without ears. What am I?", "Echo"},
            {"The more you take, the more you leave behind.", "Footsteps"},
            {"What has one eye but cannot see?", "Needle"},
            {"What has hands but can’t clap?", "Clock"},
             {"What has to be broken before you can use it?", "Egg"},
    {"I speak without a mouth and hear without ears. What am I?", "Echo"},
    {"The more you take, the more you leave behind. What are they?", "Footsteps"},
    {"What comes once in a minute, twice in a moment, but never in a thousand years?", "M"},
    {"I’m tall when I’m young, and I’m short when I’m old. What am I?", "Candle"},
    {"What can fill a room but takes up no space?", "Light"},
    {"The more of me you take, the more you leave behind. What am I?", "Footsteps"},
    {"What has one eye but cannot see?", "Needle"},
    {"What has hands but can’t clap?", "Clock"},
    {"I have branches, but no fruit, trunk, or leaves. What am I?", "Bank"},
    {"What has to be fed but never eats?", "Fire"},
    {"The more you take, the more you leave behind. What am I?", "Footsteps"},
    {"What has keys but can’t open locks?", "Piano"},
    {"What gets wetter the more it dries?", "Towel"},
    {"What has a heart but no other organs?", "Deck of cards"},
    {"What has an endless supply of letters but starts empty?", "Mailbox"},
    {"I fly without wings. I cry without eyes. What am I?", "Cloud"},
    {"What can travel around the world while staying in the same spot?", "Stamp"},
    {"What has four legs in the morning, two in the afternoon, and three in the evening?", "Human"},
    {"What has a bottom at the top?", "Legs"},
    {"What has a head, a tail, but no body?", "Coin"},
    {"The more you remove from me, the bigger I get. What am I?", "Hole"},
    {"What begins with T, ends with T, and has T inside?", "Teapot"},
    {"What can be cracked, made, told, and played?", "Joke"},
    {"I shave every day, but my beard stays the same. What am I?", "Barber"},
    {"What runs but never walks?", "River"},
    {"What has cities but no houses, forests but no trees, and rivers but no water?", "Map"},
    {"I have keys but open no locks. I have space but no room. What am I?", "Keyboard"},
    {"What can you hold without touching it?", "Breath"},
    {"What belongs to you but is used more by others?", "Your name"},
    {"What gets sharper the more you use it?", "Brain"},
    {"What has a thumb and four fingers but isn’t alive?", "Glove"},
    {"What is full of holes but still holds water?", "Sponge"},
    {"What has words but never speaks?", "Book"},
    {"The more you share me, the less you have. What am I?", "Secret"},
    {"What has roots but never grows?", "Mountain"},
    {"What has wings but cannot fly?", "Penguin"},
    {"What comes up but never goes down?", "Age"},
    {"What has a neck but no head?", "Bottle"},
    {"What has an end but no beginning?", "Ring"},
    {"What’s always in front of you but you can’t see it?", "Future"},
    {"What can’t talk but will reply when spoken to?", "Echo"},
    {"What can run but never walks?", "Refrigerator"},
    {"What has teeth but cannot bite?", "Comb"},
    {"I can be cracked, made, told, and played. What am I?", "Joke"},
    {"The more you take, the more I leave behind. What am I?", "Footsteps"},
    {"What has a bed but never sleeps?", "River"},
    {"What has 13 hearts but no other organs?", "Deck of cards"},
    {"What has eyes but cannot see?", "Potato"},
    {"What begins and ends with ‘E’ but only has one letter?", "Envelope"},
    {"What has an ear but cannot hear?", "Corn"},
    {"What is heavy forward but not backward?", "Ton"},
    {"What has stripes but no color?", "Zebra"},
    {"What is as light as a feather but even the strongest man cannot hold for long?", "Breath"},
    {"What is stronger than steel but can be destroyed by water?", "Paper"},
    {"I have keys but cannot open doors. What am I?", "Piano"},
    {"What has numbers but cannot count?", "Clock"},
    {"What kind of band never plays music?", "Rubber band"},
    {"What starts with P and ends with E but has thousands of letters?", "Post Office"},
    {"What can fill a room but takes no space?", "Light"},
    {"What has an endless supply of letters but starts empty?", "Mailbox"},
    {"What can be heard but never seen?", "Echo"},
    {"What has a head, a tail, but no body?", "Coin"},
    {"What is always coming but never arrives?", "Tomorrow"},
    {"What do you throw away when you need it and bring back when you don’t?", "Anchor"},
    {"I go up but never down. What am I?", "Age"},
    {"What begins and ends with an ‘E’ but only contains one letter?", "Envelope"},
    {"What can run but never walks?", "Refrigerator"},
    {"What gets bigger the more you take away?", "Hole"},
    {"What can go up a chimney down, but can’t go down a chimney up?", "Umbrella"},
    {"What has a ring but no finger?", "Telephone"},
    {"What can travel around the world while staying in the same place?", "Stamp"},
    {"What has a spine but no bones?", "Book"},
    {"What has an ear but cannot hear?", "Corn"},
    {"What has four fingers and a thumb but isn’t alive?", "Glove"},
    {"What can you catch but not throw?", "Cold"},
    {"What has keys but can’t open locks?", "Piano"},
    {"I have hands but cannot clap. What am I?", "Clock"},
    {"What comes once in a year but twice in a week?", "E"},
    {"What gets sharper the more you use it?", "Brain"},
    {"What has a tail but no body?", "Coin"},
    {"What is full of holes but still holds water?", "Sponge"},
    {"What is white when dirty and black when clean?", "Chalkboard"},
    {"What has an end but no beginning?", "Ring"},
    {"What has many teeth but cannot eat?", "Comb"},
    {"I have one head, one foot, and four legs. What am I?", "Bed"},
    {"What is the capital of France?", "Paris"}
        };

        private Random rand = new Random();
        private int riddleIndex;
        private int score = 0;

        public LogicGame()
        {
            InitializeComponent();  // This will be automatically generated by the designer.
            LoadRiddle();
        }

        private void LoadRiddle()
        {
            riddleIndex = rand.Next(0, riddles.GetLength(0));
            lblQuestion.Text = riddles[riddleIndex, 0];
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtAnswer.Text.Trim().ToLower() == riddles[riddleIndex, 1].ToLower())
            {
                score += 10;
                lblScore.Text = "Score: " + score;
                LoadRiddle();
            }
            else
            {
                MessageBox.Show("Wrong Answer!");
            }
            txtAnswer.Clear();
        }

        // Remove the manually defined InitializeComponent method.

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Close();
        }

        private void LogicGame_Load(object sender, EventArgs e)
        {
            // Logic for loading the game.
        }
    }
}
