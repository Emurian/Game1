namespace EscapeRoomGame
{
    partial class MathGame
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer gameTimer;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);

            this.SuspendLayout();

            // lblQuestion
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(100, 50);
            this.lblQuestion.Text = "5 + 3 = ?";

            // txtAnswer
            this.txtAnswer.Location = new System.Drawing.Point(100, 100);
            this.txtAnswer.Size = new System.Drawing.Size(150, 30);

            // btnSubmit
            this.btnSubmit.Location = new System.Drawing.Point(100, 150);
            this.btnSubmit.Size = new System.Drawing.Size(100, 40);
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);

            // btnBack
            this.btnBack.Location = new System.Drawing.Point(100, 200);
            this.btnBack.Size = new System.Drawing.Size(200, 40);
            this.btnBack.Text = "Back to Menu";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            // lblScore
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(300, 50);
            this.lblScore.Text = "Score: 0";

            // lblTimer
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(300, 100);
            this.lblTimer.Text = "Time Left: 60";

            // gameTimer
            this.gameTimer.Interval = 1000;

            // MathGame
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblTimer);
            this.Name = "MathGame";
            this.Text = "Math Game";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
