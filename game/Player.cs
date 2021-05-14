using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace tolik
{
    class Player
    {

        public int x;
        public int y;
        public int size;
        public Image tolikImage;

        public int gravityValue;

        public Player(int x, int y)
        {
            tolikImage = new Bitmap("C:\\Users\\zanteria\\Desktop\\Tolik.png");
            this.x = x;
            this.y = y;
            size = 90;
            gravityValue = 2;
        }

    }
}
