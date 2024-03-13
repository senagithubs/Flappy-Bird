namespace FLAPPY_BİRD
{
    public partial class Form1 : Form
    {
        int boruHızı = 8;
        int gravity = 10;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappybird.Top += gravity;
            borualt.Left -= boruHızı;
            boruust.Left -= boruHızı;
            scoretext.Text = "Score:" + score;
            if (borualt.Left < -150)
            {
                borualt.Left = 800;
                score++;

            }
            if (boruust.Left < -180)
            {
                boruust.Left = 950;
                score++;
            }
            if (flappybird.Bounds.IntersectsWith(borualt.Bounds) || flappybird.Bounds.IntersectsWith(boruust.Bounds) || flappybird.Bounds.IntersectsWith(zemin.Bounds))
            {
                endGame();
            }
            if (score > 5)
            {
                boruHızı = 15;

            }
            if (flappybird.Top < -25)
            {
                endGame();
            }
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }
        }
          
        private void 
            gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }

        }
        private void endGame()
        {
            gametimer.Stop();
            scoretext.Text = "Game Over";

        }
    }
}