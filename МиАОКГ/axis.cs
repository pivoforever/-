using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace МиАОКГ
{
    public class Axis
    {
        public int xCenter;
        public int yCenter;
        public Axis(int xCenter, int yCenter)
        {
            this.xCenter = xCenter;
            this.yCenter = yCenter;
        }
        int getCenterX() { return xCenter; }
        int getCenterY() { return yCenter; }
    }
}