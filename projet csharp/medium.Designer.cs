namespace projet_csharp
{
    partial class medium
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.score_ball = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // score_ball
            // 
            this.score_ball.AutoSize = true;
            this.score_ball.BackColor = System.Drawing.Color.Black;
            this.score_ball.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_ball.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.score_ball.Location = new System.Drawing.Point(388, 9);
            this.score_ball.Name = "score_ball";
            this.score_ball.Size = new System.Drawing.Size(143, 36);
            this.score_ball.TabIndex = 42;
            this.score_ball.Text = "Score : 0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox13.Image = global::projet_csharp.Properties.Resources.metal;
            this.pictureBox13.Location = new System.Drawing.Point(594, 164);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(100, 23);
            this.pictureBox13.TabIndex = 44;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Tag = "incassable";
            // 
            // pictureBox19
            // 
            this.pictureBox19.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox19.Image = global::projet_csharp.Properties.Resources.metal;
            this.pictureBox19.Location = new System.Drawing.Point(221, 164);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(100, 23);
            this.pictureBox19.TabIndex = 43;
            this.pictureBox19.TabStop = false;
            this.pictureBox19.Tag = "incassable";
            this.pictureBox19.Click += new System.EventHandler(this.pictureBox19_Click);
            // 
            // pictureBox17
            // 
            this.pictureBox17.BackColor = System.Drawing.Color.Cyan;
            this.pictureBox17.Location = new System.Drawing.Point(102, 164);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(100, 23);
            this.pictureBox17.TabIndex = 41;
            this.pictureBox17.TabStop = false;
            this.pictureBox17.Tag = "brique";
            this.pictureBox17.Click += new System.EventHandler(this.pictureBox17_Click);
            // 
            // pictureBox18
            // 
            this.pictureBox18.BackColor = System.Drawing.Color.Green;
            this.pictureBox18.Location = new System.Drawing.Point(102, 203);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(100, 23);
            this.pictureBox18.TabIndex = 40;
            this.pictureBox18.TabStop = false;
            this.pictureBox18.Tag = "brique";
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackColor = System.Drawing.Color.Cyan;
            this.pictureBox14.Location = new System.Drawing.Point(474, 164);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(100, 23);
            this.pictureBox14.TabIndex = 38;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.Tag = "brique";
            // 
            // pictureBox16
            // 
            this.pictureBox16.BackColor = System.Drawing.Color.Cyan;
            this.pictureBox16.Location = new System.Drawing.Point(350, 164);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(100, 23);
            this.pictureBox16.TabIndex = 36;
            this.pictureBox16.TabStop = false;
            this.pictureBox16.Tag = "brique";
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Green;
            this.pictureBox9.Location = new System.Drawing.Point(221, 203);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(100, 23);
            this.pictureBox9.TabIndex = 35;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "brique";
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Green;
            this.pictureBox10.Location = new System.Drawing.Point(474, 203);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(100, 23);
            this.pictureBox10.TabIndex = 34;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Tag = "brique";
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Green;
            this.pictureBox11.Location = new System.Drawing.Point(594, 203);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(100, 23);
            this.pictureBox11.TabIndex = 33;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Tag = "brique";
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.Green;
            this.pictureBox12.Location = new System.Drawing.Point(350, 203);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(100, 23);
            this.pictureBox12.TabIndex = 32;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Tag = "brique";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Green;
            this.pictureBox5.Location = new System.Drawing.Point(102, 122);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 23);
            this.pictureBox5.TabIndex = 31;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "brique";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Cyan;
            this.pictureBox6.Location = new System.Drawing.Point(723, 164);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 23);
            this.pictureBox6.TabIndex = 30;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "brique";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Green;
            this.pictureBox7.Location = new System.Drawing.Point(723, 122);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(100, 23);
            this.pictureBox7.TabIndex = 29;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "brique";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Green;
            this.pictureBox8.Location = new System.Drawing.Point(723, 203);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(100, 23);
            this.pictureBox8.TabIndex = 28;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "brique";
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Transparent;
            this.ball.Image = global::projet_csharp.Properties.Resources._8_ball_pool_png_23051;
            this.ball.Location = new System.Drawing.Point(404, 416);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(24, 24);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball.TabIndex = 27;
            this.ball.TabStop = false;
            this.ball.Click += new System.EventHandler(this.ball_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Green;
            this.pictureBox4.Location = new System.Drawing.Point(221, 122);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 23);
            this.pictureBox4.TabIndex = 26;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "brique";
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Green;
            this.pictureBox3.Location = new System.Drawing.Point(474, 122);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 23);
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "brique";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Green;
            this.pictureBox2.Location = new System.Drawing.Point(594, 122);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 23);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "brique";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Green;
            this.pictureBox1.Location = new System.Drawing.Point(350, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 23);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "brique";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Blue;
            this.player.Location = new System.Drawing.Point(350, 470);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(144, 24);
            this.player.TabIndex = 22;
            this.player.TabStop = false;
            this.player.Tag = "player";
            // 
            // medium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::projet_csharp.Properties.Resources.paint_png_22878;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(925, 537);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox19);
            this.Controls.Add(this.score_ball);
            this.Controls.Add(this.pictureBox17);
            this.Controls.Add(this.pictureBox18);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox16);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.player);
            this.DoubleBuffered = true;
            this.Name = "medium";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "medium";
            this.Load += new System.EventHandler(this.medium_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label score_ball;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.PictureBox pictureBox13;
    }
}