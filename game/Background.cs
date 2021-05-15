using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace game
{
    class Background
    {
        public int x;
        public int y;
        public int sizeX;
        public int sizeY;
        public Image backImage;

        public Background(int x, int y)
        {
            backImage = new Bitmap("C:\\Users\\zanteria\\Desktop\\back.png");
            this.x = x;
            this.y = y;
            sizeX = 1920;
            sizeY = 1080;
        }
    }
}
