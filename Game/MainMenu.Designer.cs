namespace EscapeRoomGame
{
    partial class MainMenu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnMath;
        private System.Windows.Forms.Button btnLogic;
        private System.Windows.Forms.Button btnPattern;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTitle;

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnMath = new System.Windows.Forms.Button();
            this.btnLogic = new System.Windows.Forms.Button();
            this.btnPattern = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(50, 20);
            this.lblTitle.Text = "Virtual Escape Room Game";

            // btnMath
            this.btnMath.Location = new System.Drawing.Point(100, 80);
            this.btnMath.Size = new System.Drawing.Size(200, 40);
            this.btnMath.Text = "Math Game";
            this.btnMath.Click += new System.EventHandler(this.btnMath_Click);

            // btnLogic
            this.btnLogic.Location = new System.Drawing.Point(100, 130);
            this.btnLogic.Size = new System.Drawing.Size(200, 40);
            this.btnLogic.Text = "Logic Game";
            this.btnLogic.Click += new System.EventHandler(this.btnLogic_Click);

            // btnPattern
            this.btnPattern.Location = new System.Drawing.Point(100, 180);
            this.btnPattern.Size = new System.Drawing.Size(200, 40);
            this.btnPattern.Text = "Pattern Recognition";
            this.btnPattern.Click += new System.EventHandler(this.btnPattern_Click);

            // btnExit
            this.btnExit.Location = new System.Drawing.Point(100, 230);
            this.btnExit.Size = new System.Drawing.Size(200, 40);
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            // MainMenu
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnMath);
            this.Controls.Add(this.btnLogic);
            this.Controls.Add(this.btnPattern);
            this.Controls.Add(this.btnExit);
            this.Name = "MainMenu";
            this.Text = "Escape Room Game";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
