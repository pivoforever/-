using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace МиАОКГ
{
    class CPoint3D
    {
        public int x;
        public int y;
        public int z;
        string name;
        Brush color;
        public CPoint3D(int x, int y, int z, string name, Brush color)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.name = name;
            this.color = color;
        }
    }
}
