using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tolik;

namespace game
{
    public partial class Form1 : Form
    {

        Player tolik;
        TheBarrel barrel;
        Ground ground;
        Sans sans;
        Background back;
        float gravity;
        int counter = 0;
        int seconds = 0;
        bool isEnemyAlive = true;
        float tracking;
        int direction = 0;
        int timeChecker;
        Random rnd = new Random();
        


        public Form1()
        {
            InitializeComponent();
            Init();
            Invalidate();
        }

        public void Init()
        {
            tolik = new Player(100, 490);
            barrel = new TheBarrel(340, 525);
            back = new Background(0, 0);
            timer1.Interval = 10;
            timer1.Tick += new EventHandler(update);
            timer1.Start();
        }



        private void update(object sender, EventArgs e)
        {

            counter++;
            tracking = tolik.x;
            if(tolik.gravityValue != 0.1f)
            {
                tolik.gravityValue += 0.005f;
                gravity += tolik.gravityValue;
                tolik.y += gravity;
            }

            if(timeChecker == counter + 20)
            {
                tolik.y = 190;
                gravity = 0;
                tolik.gravityValue = 0;
            }

           

            MoveTolik();
            onGround();
            //MoveSans();
            Invalidate();
        }

        private void onGround()
        {
            if (ground.y + 25 < tolik.y)
            {
                tolik = new Player(tracking, 490);
            }
        }

        private void MoveTolik()
        {
            if(direction == 1)
            {
                tolik.x += 5;
            }
            else if (direction == 2)
            {
                tolik.x -= 5;
            }
            else if (direction == 3)
            {
                tolik.y -= 5;
            }
            else if (direction == 4)
            {
                tolik.y += 5;
            }
            else if (direction == 5)
            {

            }
        }

        private void MoveSans()
        {
            sans.x -= 1;
        }

        private void CreateEnemy()
        {
           
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {

            Graphics graphics = e.Graphics;

            graphics.DrawImage(back.backImage, back.x, back.y, back.sizeX, back.sizeY);
            graphics.DrawImage(barrel.barrelImage, barrel.x, barrel.y, barrel.sizeX, barrel.sizeY);
            graphics.DrawImage(tolik.tolikImage, tolik.x, tolik.y, tolik.size, tolik.size);


           


            for (int i = 0; i < 20; i++)
            {
                ground = new Ground(i * 128, 475);
                graphics.DrawImage(ground.groundImage, ground.x, ground.y, ground.sizeX, ground.sizeY);
            }

            int num = rnd.Next(0, 1000);

            

            if (num > 900)
            {
                sans = new Sans(440, 525);
                graphics.DrawImage(sans.sansImage, sans.x, sans.y, sans.sizeX, sans.sizeY);
                isEnemyAlive = false;
            }
        }
        private void Form1_Load(object sender, EventArgs e) {   }

        private void button1_Click(object sender, EventArgs e) //jump
        {
            timeChecker = counter;
            gravity = 0;
            tolik.gravityValue = -0.125f;
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) //right
        {
            direction = 1;
        }

        private void button3_Click(object sender, EventArgs e) //left
        {
            direction = 2;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            float num = tolik.y;
            label3.Text = num.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            direction = 3;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            direction = 4;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            direction = 5;
        }
    }
}
