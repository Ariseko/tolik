using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace game
{
    class TheBarrel
    {
        public int x;
        public int y;
        public int sizeX;
        public int sizeY;
        public Image barrelImage;

        public TheBarrel(int x, int y)
        {
            barrelImage = new Bitmap("C:\\Users\\zanteria\\Desktop\\game\\envoriment\\barrel.png ");
            this.x = x;
            this.y = y;
            sizeX = 48;
            sizeY = 50;
        }
    }
}
