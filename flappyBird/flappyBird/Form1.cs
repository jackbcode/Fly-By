using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flappyBird
{
    public partial class Form1 : Form
    {
        bool jumping = false;
        int pipespeed = 3;
        int gravity = 5;
        int Inscore = 0;

        public Form1()
        {
            
            InitializeComponent();
            endText1.Text = "Game Over";
            endText2.Text = "Your final score is:";
            gameDesigner.Text = "Game built by Jack Bradley ";
            endText1.Visible = false;
            endText2.Visible = false;
            gameDesigner.Visible = false;
            button1.Visible = false;
        }

        private void gametimer_Tick(object sender, EventArgs e)
        {
            cactus.Left -= pipespeed;
            tree.Left -= pipespeed;
            pipeTop.Left -= pipespeed;
            thunder.Left -= pipespeed;
            dragon.Top += gravity;
            scoreText.Text = " " + Inscore;

            if(cactus.Left < -80)
            {
                cactus.Left = 1000;
                Inscore += 1;
            }
            else if(pipeTop.Left< -95){
                pipeTop.Left = 1100;
                Inscore += 1;
            }

            else if(tree.Left < -120)
            {
                tree.Left = 1000;
                Inscore += 1;
            }

            else if(thunder.Left < -40)
            {
                thunder.Left = 800;
                Inscore += 1;

            }

            if (dragon.Bounds.IntersectsWith(ground.Bounds))
            {
                endGame();
            }
            else if (dragon.Bounds.IntersectsWith(cactus.Bounds))
            {
                endGame();
            }
            else if (dragon.Bounds.IntersectsWith(pipeTop.Bounds))
            {
                endGame();
            }
            else if (dragon.Bounds.IntersectsWith(tree.Bounds))
            {
                endGame();
            }

            else if (dragon.Bounds.IntersectsWith(thunder.Bounds))
            {
                endGame();
            }

        }

        private void GameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                jumping = false;
                gravity = 5;
            }
        }

        private void endGame()
        {
            gametimer.Stop();
            endText1.Visible = true;
            endText2.Visible = true;
            gameDesigner.Visible = true;
            button1.Visible = true;
        }

        private void GameKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                jumping = true;
                gravity = -5;
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            var form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
            form1.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
        }

        private void dragon_Click(object sender, EventArgs e)
        {

        }
    }
}
