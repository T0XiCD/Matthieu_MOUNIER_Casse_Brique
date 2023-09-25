using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_csharp
{
    public partial class medium : Form
    {

        
        bool moveLeft, moveRight;
        int speed = 12;


        int Ball_x = 8;
        int Ball_y = 8;



        int score = 0;
        public medium()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.FormBorderStyle = FormBorderStyle.None;
        }
        private void gameOver()
        {
            //condition de defaite avec le stop su jeux et une fenetre qui souvre pour dire qu'on a perdu + le score qui a ete fais  et si on la ferme sa ferme la fenentre du jeux pour revinr au menu
            timer1.Stop();
            MessageBox.Show("perdu", score_ball.Text = "Score :" + score);
            Close();    

        }

        private void win()
        {
            //condition de win avec le stop su jeux et une fenetre qui souvre pour dire qu'on a gagner + le score qui a ete fais et si on la ferme sa ferme la fenentre du jeux pour revinr au menu 
            timer1.Stop();
            MessageBox.Show("gagner", score_ball.Text = "Score :" + score);
            Close();
        }
        private void get_score() // a chaque fois que la balle touche une brique le score augmente 
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "brique")
                {
                    if (ball.Bounds.IntersectsWith(x.Bounds))
                    {
                        Controls.Remove(x);
                        Ball_y = -Ball_y;
                        score++;
                        score_ball.Text = "Score :" + score;
                    }
                }
            }
        }
        private void ball_movement()
        {
            ball.Left += Ball_x;
            ball.Top += Ball_y;
            if (ball.Left + ball.Width > ClientSize.Width || ball.Left < 0)
            {
                Ball_x = -Ball_x;
            }
            if (ball.Top < 0 || ball.Bounds.IntersectsWith(player.Bounds))
            {
                Ball_y = -Ball_y;
            }

            foreach (Control x in this.Controls)// brique grise qui son incasseble et que la ball rebondit dessuS
            {
                if (x is PictureBox && x.Tag == "incassable")
                {
                    if (ball.Bounds.IntersectsWith(x.Bounds))
                    {

                        Ball_y = -Ball_y;

                    }
                }
            }


         if (ball.Top + ball.Height > ClientRectangle.Height)// condition de defaite, si la ball sort de l'ecran part en bas 
            {
                gameOver();
            }

            foreach (Control x in this.Controls) // condition de win, il faut que le joueur est un score de 18 (avoir detruis toute les brique) et de retoucher son paddle pour gagner            
            {
                if ((string)x.Tag == "player")
                {

                    if (ball.Bounds.IntersectsWith(x.Bounds) && score == 16)
                    {
                        win();
                    }
                }
            }
        }
        private void player_movement()
        {
            if (moveLeft == true && player.Left > 0)
            {
                player.Left -= speed;
            }
            if (moveRight == true && player.Left < 590)
            {
                player.Left += speed;
            }
        }
      

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                moveLeft = true;
            }

            if (e.KeyCode == Keys.Right)
            {
                moveRight = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                moveLeft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                moveRight = false;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ball_movement();
            get_score();
            player_movement();

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
         
        }

        private void ball_Click(object sender, EventArgs e)
        {

        }
    }
}
