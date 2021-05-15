using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace game
{
    class Sans
    {
        public int x;
        public int y;
        public int sizeX;
        public int sizeY;
        public Image sansImage;

        public Sans(int x, int y)
        {
            sansImage = new Bitmap("C:\\Users\\zanteria\\Desktop\\sans.png");
            this.x = x;
            this.y = y;
            sizeX = 48;
            sizeY = 50;
        }
    }
}
