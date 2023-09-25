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
    public partial class menu : Form
    {

        int horizontalspeed = 5;
        int Ball_x = 4;
        int Ball_y = 4;
        public menu()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left -= horizontalspeed;
            if (pictureBox1.Left < 12 || pictureBox1.Right > 590)
            {
                horizontalspeed = -horizontalspeed;
            }


            ball.Left += Ball_x;
            ball.Top += Ball_y;
            if (ball.Left + ball.Width > ClientSize.Width || ball.Left < 0)
            {
                Ball_x = -Ball_x;
            }
            if (ball.Top + ball.Width > ClientSize.Height || ball.Top < 0)
            {
                Ball_y = -Ball_y;
            }
        }

        private void button1_Click(object sender, EventArgs e) //done accces au level easy
        {
            Form1 gameWindow = new Form1();
            gameWindow.Show();
        }

        private void button2_Click(object sender, EventArgs e)// donne acces au level medium
        {
            medium gameWindow = new medium(); 
            gameWindow.Show();
        }

        private void button3_Click(object sender, EventArgs e) //affiche les regles 
        {
            regle gameWindow = new regle();
            gameWindow.Show();
        }

        private void button4_Click(object sender, EventArgs e) // donne acces au level hard
        {
            hard gameWindow =  new hard();
            gameWindow.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

     

    }
}
