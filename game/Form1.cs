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
        float gravity;

        public Form1()
        {
            InitializeComponent();
            Init();
            Invalidate();
        }

        public void Init()
        {
            tolik = new Player(200, 190);
            barrel = new TheBarrel(340, 225);
            timer1.Interval = 1;
            timer1.Tick += new EventHandler(update);
            timer1.Start();
        }

        private void update(object sender, EventArgs e)
        {
            if (tolik.gravityValue != 0.1f)
            {
                tolik.gravityValue += 0.005f; 
            }

            gravity += tolik.gravityValue;
            tolik.y += gravity;
            Invalidate();

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
        }
        private void Form1_Load(object sender, EventArgs e) {   }

        private void button1_Click(object sender, EventArgs e)
        {
            gravity = 0;
            tolik.gravityValue = -0.15f;
        }
    }
}
