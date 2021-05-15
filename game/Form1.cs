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
        float gravity;
        int counter=0;
        int seconds=0;
        bool isEnemyAlive=true;
        Random rnd = new Random();
        


        public Form1()
        {
            InitializeComponent();
            Init();
            Invalidate();
        }

        public void Init()
        {
            tolik = new Player(100, 190);
            barrel = new TheBarrel(340, 225);
            timer1.Interval = 10;
            timer1.Tick += new EventHandler(update);
            timer1.Start();
        }



        private void update(object sender, EventArgs e)
        {
           if(tolik.gravityValue != 0.1f)
           {
                tolik.gravityValue += 0.005f;
                gravity += tolik.gravityValue;
                tolik.y += gravity;
           }
            

            MoveTolik();
            MoveSans();
            Invalidate();
        }

        private void MoveTolik()
        {
            tolik.x += 1;
        }

        private void MoveSans()
        {
            sans.x -= 1;
        }

        private void CreateEnemy(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
           
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            graphics.DrawImage(tolik.tolikImage, tolik.x, tolik.y, tolik.size, tolik.size);
            graphics.DrawImage(barrel.barrelImage, barrel.x, barrel.y, barrel.sizeX, barrel.sizeY);

            for (int i = 0; i < 20; i++)
            {
                ground = new Ground(i * 128, 175);
                graphics.DrawImage(ground.groundImage, ground.x, ground.y, ground.sizeX, ground.sizeY);
            }

            int num = rnd.Next(0, 1000);

            if (num > 500 && isEnemyAlive == true)
            {
                sans = new Sans(440, 225);
                graphics.DrawImage(sans.sansImage, sans.x, sans.y, sans.sizeX, sans.sizeY);
                isEnemyAlive = false;
            }
        }
        private void Form1_Load(object sender, EventArgs e) {   }

        private void button1_Click(object sender, EventArgs e)
        {
            gravity = 0;
            tolik.gravityValue = -0.125f;
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
