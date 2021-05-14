using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace tolik
{
    class Player
    {

        public float x;
        public float y;
        public int size;
        public Image tolikImage;

        public float gravityValue;

        public Player(int x, int y)
        {
            tolikImage = new Bitmap("C:\\Users\\zanteria\\Desktop\\Tolik.png");
            this.x = x;
            this.y = y;
            size = 90;
            gravityValue = 0.2f;
        }

    }
}
