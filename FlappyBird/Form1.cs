using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        int obstacleSpd = 5;
        int birdSpd = 8;      //gravity
        int jumpStrength = 10;
        int score = 0;
        bool speedInc = false; //prevents pseed from increasing every tick

        public Form1()
        {
            InitializeComponent();

            this.KeyPreview = true;

            gameTimer.Start();


        }



        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Space)
            {
                birdPlayer.Top -= jumpStrength;
            }
        }


        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //no good
        }

        private void gameOver()
        { 
            gameTimer.Stop();
            scoreText.Text = "Flappy Bird died.";
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            birdPlayer.Top += birdSpd; //affects bird margin depending on bridSpd
            
            //Affect obstacles margin
            obstacleBottom.Left -= obstacleSpd;
            obstacleTop.Left -= obstacleSpd;

            scoreText.Text = score.ToString();

            //Spawn obstacle again
            if (obstacleBottom.Left < -150 && obstacleTop.Left < -150)
            {
                obstacleBottom.Left = 950;
                obstacleTop.Left = 950;
                score++;

            }

            scoreText.Text = scoreText.ToString();
            //collision
            if (birdPlayer.Bounds.IntersectsWith(obstacleBottom.Bounds) || birdPlayer.Bounds.IntersectsWith(obstacleTop.Bounds) || birdPlayer.Bounds.IntersectsWith(ground.Bounds))
            {

                gameOver();
                return;
                

            }

            if (score >= 10 && !speedInc)
            {
                obstacleSpd += 3;
                speedInc = true;
            }
        }
    }
}
