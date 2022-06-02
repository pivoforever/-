using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace МиАОКГ
{
    public class CPoint2D
    {
        public int x;
        public int y;
        public string name;
        public Brush color;
        public CPoint2D(int x, int y, string name, Brush color)
        {
            this.x = x;
            this.y = y;
            this.name = name;
            this.color = color;
        }
    }
}
