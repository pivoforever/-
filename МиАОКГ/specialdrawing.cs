using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace МиАОКГ
{
    class SpecialDrawing
    {
        public CPoint3D[] storageSpecial3D = new CPoint3D[14];
        public CPoint2D[] storageSpecial2D = new CPoint2D[14];
        double alfa;
        double betta;
        double gamma;


        public SpecialDrawing()
        {
            storageSpecial2D[0] = new CPoint2D(0, 0, "T", Brushes.Red);
            storageSpecial2D[1] = new CPoint2D(0, 0, "Tx", Brushes.Gray);
            storageSpecial2D[2] = new CPoint2D(0, 0, "Ty", Brushes.Gray);
            storageSpecial2D[3] = new CPoint2D(0, 0, "Tz", Brushes.Gray);
            storageSpecial2D[4] = new CPoint2D(0, 0, "Tyz", Brushes.Gray);
            storageSpecial2D[5] = new CPoint2D(0, 0, "Tzx", Brushes.Gray);
            storageSpecial2D[6] = new CPoint2D(0, 0, "Txy", Brushes.Gray);
            storageSpecial2D[7] = new CPoint2D(0, 0, "O", Brushes.Black);
            storageSpecial2D[8] = new CPoint2D(0, 0, "X", Brushes.Black);
            storageSpecial2D[9] = new CPoint2D(0, 0, "-X", Brushes.Black);
            storageSpecial2D[10] = new CPoint2D(0, 0, "Y", Brushes.Black);
            storageSpecial2D[11] = new CPoint2D(0, 0, "-Y", Brushes.Black);
            storageSpecial2D[12] = new CPoint2D(0, 0, "Z", Brushes.Black);
            storageSpecial2D[13] = new CPoint2D(0, 0, "-Z", Brushes.Black);
        }

        void calculatePoints()
        {
            for (int i = 0; i < 14; i++)
            {
                calculate(storageSpecial2D[i], storageSpecial3D[i], alfa, betta, gamma, Form1.Center);
            }

        }
        public void updatePoints(CPoint3D[] storage, double alfa, double betta, double gamma)
        {
            storageSpecial3D = storage;
            this.alfa = alfa;
            this.betta = betta;
            this.gamma = gamma;
            calculatePoints();
        }

        public void drawPoints(Graphics g, Font fontNames)
        {
            drawLines(g);
            for (int i = 0; i < 14; i++)
            {
                g.FillEllipse(storageSpecial2D[i].color, storageSpecial2D[i].x - 3, storageSpecial2D[i].y - 3, 6, 6);
                g.DrawString(storageSpecial2D[i].name, fontNames, Brushes.Red, storageSpecial2D[i].x, storageSpecial2D[i].y);
            }
        }
        void drawLines(Graphics g)
        {
            Pen AxisPen = new Pen(Color.Black, 1);
            Pen PLine = new Pen(Color.Black, 2);
            g.DrawLine(AxisPen, storageSpecial2D[8].x, storageSpecial2D[8].y, storageSpecial2D[9].x, storageSpecial2D[9].y);
            g.DrawLine(AxisPen, storageSpecial2D[10].x, storageSpecial2D[10].y, storageSpecial2D[11].x, storageSpecial2D[11].y);
            g.DrawLine(AxisPen, storageSpecial2D[12].x, storageSpecial2D[12].y, storageSpecial2D[13].x, storageSpecial2D[13].y);
            g.DrawLine(PLine, storageSpecial2D[0].x, storageSpecial2D[0].y, storageSpecial2D[4].x, storageSpecial2D[4].y);
            g.DrawLine(PLine, storageSpecial2D[0].x, storageSpecial2D[0].y, storageSpecial2D[5].x, storageSpecial2D[5].y);
            g.DrawLine(PLine, storageSpecial2D[0].x, storageSpecial2D[0].y, storageSpecial2D[6].x, storageSpecial2D[6].y);
            g.DrawLine(PLine, storageSpecial2D[4].x, storageSpecial2D[4].y, storageSpecial2D[2].x, storageSpecial2D[2].y);
            g.DrawLine(PLine, storageSpecial2D[4].x, storageSpecial2D[4].y, storageSpecial2D[3].x, storageSpecial2D[3].y);
            g.DrawLine(PLine, storageSpecial2D[5].x, storageSpecial2D[5].y, storageSpecial2D[1].x, storageSpecial2D[1].y);
            g.DrawLine(PLine, storageSpecial2D[5].x, storageSpecial2D[5].y, storageSpecial2D[3].x, storageSpecial2D[3].y);
            g.DrawLine(PLine, storageSpecial2D[6].x, storageSpecial2D[6].y, storageSpecial2D[1].x, storageSpecial2D[1].y);
            g.DrawLine(PLine, storageSpecial2D[6].x, storageSpecial2D[6].y, storageSpecial2D[2].x, storageSpecial2D[2].y);
            g.DrawLine(PLine, storageSpecial2D[1].x, storageSpecial2D[1].y, storageSpecial2D[7].x, storageSpecial2D[7].y);
            g.DrawLine(PLine, storageSpecial2D[2].x, storageSpecial2D[2].y, storageSpecial2D[7].x, storageSpecial2D[7].y);
            g.DrawLine(PLine, storageSpecial2D[3].x, storageSpecial2D[3].y, storageSpecial2D[7].x, storageSpecial2D[7].y);

        }

        public CPoint2D calculate(CPoint2D Point2D, CPoint3D Point3D, double alfa, double betta, double gamma, Axis Center)
        {

            Point2D.x = Convert.ToInt32(Center.xCenter + Point3D.x * Math.Cos(alfa) - Point3D.y * Math.Cos(betta) + Point3D.z * Math.Sin(gamma));
            Point2D.y = Convert.ToInt32(Center.yCenter - Point3D.x * Math.Sin(alfa) + Point3D.y * Math.Cos(betta) - Point3D.z * Math.Cos(gamma));
            return Point2D;
        }
    }
}
