namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        static public int playerScore = 0;
        static public int aiScore = 0;
        static public string whoWon = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            playerChoice("rock");
            label4.Text = $"Winner: {whoWon}";
            label2.Text = $"Score: {playerScore}";
            label3.Text = $"AI Score: {aiScore}";
            progressBar1.Value = playerScore;
            if (playerScore <= 10)
            {
                progressBar1.Value = playerScore;
            }
            if (aiScore <= 10)
            {
                progressBar2.Value = aiScore;
            }
            checkPlayerWin();
            checkAIWin();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            playerChoice("paper");
            label4.Text = $"Winner: {whoWon}";
            label2.Text = $"Score: {playerScore}";
            label3.Text = $"AI Score: {aiScore}";
            progressBar1.Value = playerScore;
            if (playerScore <= 10)
            {
                progressBar1.Value = playerScore;
            }
            if (aiScore <= 10)
            {
                progressBar2.Value = aiScore;
            }
            checkPlayerWin();
            checkAIWin();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            playerChoice("scissors");
            label4.Text = $"Winner: {whoWon}";
            label2.Text = $"Score: {playerScore}";
            label3.Text = $"AI Score: {aiScore}";
            if (playerScore <= 10)
            {
                progressBar1.Value = playerScore;
            }
            if (aiScore <= 10)
            {
                progressBar2.Value = aiScore;
            }
            checkPlayerWin();
            checkAIWin();
        }

        static void checkPlayerWin()
        {
            if (playerScore >= 10)
            {
                playerWonWholeGame();
            }

        }

        static void checkAIWin()
        {
            if (aiScore >= 10)
            {
                aiWonWholeGame();
            }
        }

        static void aiWonWholeGame()
        {
            DialogResult result = MessageBox.Show("Play Again?", "AI Won The Game", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                playAgain();
            }
            else
            {
                Application.Exit();
            }
        }

        static void playerWonWholeGame()
        {
            DialogResult result = MessageBox.Show("Play Again?", "Player Won The Game",  MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                playAgain();
            }
            else
            {
                Application.Exit();
            }
        }

        static void playAgain()
        {
            playerScore = 0;
            aiScore = 0;
        }

        static void playerChoice(string choice)
        {
            int playerChoice = 0;
            int aiChoice;
            Random random = new Random();
            switch (choice)
            {
                case "rock":
                    playerChoice = 1;
                    break;
                case "paper":
                    playerChoice = 2;
                    break;
                case "scissors":
                    playerChoice = 3;
                    break;
            }
            aiChoice = random.Next(1, 4);

            switch ((playerChoice, aiChoice))
            {
                case (1, 1):
                    whoWon = "none";
                    break;

                case (2, 1):
                    whoWon = "player";
                    break;

                case (3, 1):
                    whoWon = "ai";
                    break;

                case (1, 2):
                    whoWon = "ai";
                    break;

                case (2, 2):
                    whoWon = "none";
                    break;

                case (3, 2):
                    whoWon = "player";
                    break;

                case (1, 3):
                    whoWon = "player";
                    break;

                case (2, 3):
                    whoWon = "ai";
                    break;

                case (3, 3):
                    whoWon = "none";
                    break;
            }
            switch (whoWon)
            {
                case "player":

                    playerScore++;
                    break;

                case "ai":

                    aiScore++;
                    break;

                case "none":

                    break;
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
