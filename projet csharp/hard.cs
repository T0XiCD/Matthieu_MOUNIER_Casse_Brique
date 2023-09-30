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
    public partial class hard : Form
    {
        public hard()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        
        bool moveLeft, moveRight;
        int speed = 12;


        int Ball_x = 8;
        int Ball_y = 8;

        int horizontalspeed = 5;
        int horizontalspeed1 = 5;
        int horizontalspeed2 = 5;
        int horizontalspeed3 = 5;


        int score = 0;
  
        private void gameOver()
        {
            //condition de defaite avec le stop su jeux et une fenetre qui souvre pour dire qu'on a perdu + le score qui a ete fais et si on la ferme sa ferme la fenentre du jeux pour revinr au menu 
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
                if (x.BackColor == Color.Green)// fonction pour enlever les case verte
                {
                    if (ball.Bounds.IntersectsWith(x.Bounds))
                    {
                        Controls.Remove(x);
                    }
                }

                if (x.BackColor == Color.Yellow) // pour accelerer la ball
                {
                    if (ball.Bounds.IntersectsWith(x.Bounds))
                    {
                        Controls.Remove(x);
                        Ball_x = 12;
                        Ball_y = 12;

                    }
                }

                if (x.BackColor == Color.Red)// fonction pour enlever les case qui son rouge
                {
                    if (ball.Bounds.IntersectsWith(x.Bounds))
                    {
                        Controls.Remove(x);
                    }

                }

                if (x is PictureBox && x.Tag == "brique")
                {
                    if (ball.Bounds.IntersectsWith(x.Bounds))
                    {

                        // pour touche deux fois la meme case 
                        x.BackColor = Color.Red;
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

            foreach (Control x in this.Controls)// brique grise qui son incasseble et que la ball rebondit dessus
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

                    if (ball.Bounds.IntersectsWith(x.Bounds) && score == 44)
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

        private void incassable()
        {
           pictureBox19.Left -= horizontalspeed3;
            if (pictureBox19.Left < 12 || pictureBox19.Left > 171)
            {
                horizontalspeed3 = -horizontalspeed3;
            }

            pictureBox13.Left -= horizontalspeed2;
            if (pictureBox13.Left < 400 || pictureBox13.Left > 600)
            {
                horizontalspeed2 = -horizontalspeed2;
            }

            pictureBox35.Left -= horizontalspeed1;
            if (pictureBox35.Left < 400 || pictureBox35.Left > 600)
            {
                horizontalspeed1 = -horizontalspeed1;
            }

            pictureBox36.Left -= horizontalspeed;
            if (pictureBox36.Left < 12 || pictureBox36.Left > 171)
            {
                horizontalspeed = -horizontalspeed;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            ball_movement();
            get_score();
            player_movement();
            incassable();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox36_Click(object sender, EventArgs e)
        {
          
        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

       

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

       

       
    }
}
