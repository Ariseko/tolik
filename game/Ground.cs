using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace game
{
    class Ground
    {
        public int x;
        public int y;
        public int sizeX;
        public int sizeY;
        public Image groundImage;

        public Ground(int x, int y)
        {
            groundImage = new Bitmap("C:\\Users\\zanteria\\Desktop\\game\\envoriment\\ground.png ");
            this.x = x;
            this.y = y;
            sizeX = 128;
            sizeY = 128;
        }
    }
}
