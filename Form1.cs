using System;
using System.Windows.Forms;

namespace FlappyBirdGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int gravity = 20;
        int speed = 15;
        Random rand = new Random();
        int score = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            flappy.Top += gravity;
            topTube.Left -= speed;
            buttomTube.Left -= speed;

            if (topTube.Left < 0)
            { topTube.Left = rand.Next(700, 950); score++; lblScore.Text = $"Score : {score}"; }

            if (buttomTube.Left < 0)
            { buttomTube.Left = rand.Next(700, 950); score++; lblScore.Text = $"Score : {score}"; }

            if (flappy.Bounds.IntersectsWith(topTube.Bounds) || flappy.Bounds.IntersectsWith(buttomTube.Bounds) || flappy.Bounds.IntersectsWith(land.Bounds))
            {
                timer1.Stop();
                MessageBox.Show($"ebl3 ya noob 😆 , \n\n Your Score is {score}", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (timer1.Enabled == false)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    timer1.Start();
                    topTube.Left = rand.Next(700, 950);
                    buttomTube.Left = rand.Next(700, 950);
                    flappy.Top = 80;
                    score = 0;
                    lblScore.Text = $"Score : {score}";
                }
            }

            if (e.KeyCode == Keys.Space) { gravity = -15; }
            if (flappy.Top < 2) { flappy.Top = 15; }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) { gravity = 15; }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                timer1.Start();
                topTube.Left = rand.Next(700, 950);
                buttomTube.Left = rand.Next(700, 950);
                flappy.Top = 80;
                score = 0;
                lblScore.Text = $"Score : {score}";

            }
        }


    }
}
