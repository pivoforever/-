using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace МиАОКГ
{
    class ComplexDrawing
    {
        CPoint3D[] storageComplex3D = new CPoint3D[14];
        CPoint2D[] storageComplex2D = new CPoint2D[12];
        public ComplexDrawing()
        {
            storageComplex2D[0] = new CPoint2D(0, 0, "O", Brushes.Black);
            storageComplex2D[1] = new CPoint2D(0, 0, "X", Brushes.Green);
            storageComplex2D[2] = new CPoint2D(0, 0, "Y", Brushes.Green);
            storageComplex2D[3] = new CPoint2D(0, 0, "Z", Brushes.Green);
            storageComplex2D[4] = new CPoint2D(0, 0, "Y", Brushes.Green);
            storageComplex2D[5] = new CPoint2D(0, 0, "T1", Brushes.Gray);
            storageComplex2D[6] = new CPoint2D(0, 0, "T2", Brushes.Gray);
            storageComplex2D[7] = new CPoint2D(0, 0, "T3", Brushes.Gray);
            storageComplex2D[8] = new CPoint2D(0, 0, "Tx", Brushes.Gray);
            storageComplex2D[9] = new CPoint2D(0, 0, "Ty", Brushes.Gray);
            storageComplex2D[10] = new CPoint2D(0, 0, "Ty", Brushes.Gray);
            storageComplex2D[11] = new CPoint2D(0, 0, "Tz", Brushes.Gray);
        }
        void calculatePoints()
        {
            storageComplex2D[0].x = Form1.Center.xCenter;
            storageComplex2D[0].y = Form1.Center.yCenter;
            Calculate1(storageComplex2D[5], storageComplex3D[6], Form1.Center);
            Calculate1(storageComplex2D[9], storageComplex3D[2], Form1.Center);
            Calculate1(storageComplex2D[8], storageComplex3D[1], Form1.Center);
            Calculate1(storageComplex2D[1], storageComplex3D[8], Form1.Center);
            Calculate1(storageComplex2D[4], storageComplex3D[10], Form1.Center);
            Calculate2(storageComplex2D[3], storageComplex3D[12], Form1.Center);
            Calculate2(storageComplex2D[6], storageComplex3D[5], Form1.Center);
            Calculate2(storageComplex2D[11], storageComplex3D[3], Form1.Center);
            Calculate3(storageComplex2D[7], storageComplex3D[4], Form1.Center);
            Calculate3(storageComplex2D[2], storageComplex3D[10], Form1.Center);
            Calculate3(storageComplex2D[10], storageComplex3D[2], Form1.Center);


        }
        public void updatePoints(CPoint3D[] storage)
        {
            storageComplex3D = storage;
            calculatePoints();
        }
        public void drawPoints(Graphics g, Font fontNames)
        {
            drawLines(g);
            for (int i = 0; i < 12; i++)
            {
                g.FillEllipse(storageComplex2D[i].color, storageComplex2D[i].x - 3, storageComplex2D[i].y - 3, 6, 6);
                g.DrawString(storageComplex2D[i].name, fontNames, Brushes.Red, storageComplex2D[i].x, storageComplex2D[i].y);
            }
        }
        void drawLines(Graphics g)
        {
            Pen AxisPen = new Pen(Color.Black, 1);
            Pen PLine = new Pen(Color.Black, 2);
            g.DrawLine(AxisPen, storageComplex2D[1].x, storageComplex2D[1].y, storageComplex2D[2].x, storageComplex2D[2].y);
            g.DrawLine(AxisPen, storageComplex2D[3].x, storageComplex2D[3].y, storageComplex2D[4].x, storageComplex2D[4].y);
            g.DrawLine(PLine, storageComplex2D[5].x, storageComplex2D[5].y, storageComplex2D[8].x, storageComplex2D[8].y);
            g.DrawLine(PLine, storageComplex2D[5].x, storageComplex2D[5].y, storageComplex2D[9].x, storageComplex2D[9].y);
            g.DrawLine(PLine, storageComplex2D[6].x, storageComplex2D[6].y, storageComplex2D[8].x, storageComplex2D[8].y);
            g.DrawLine(PLine, storageComplex2D[6].x, storageComplex2D[6].y, storageComplex2D[11].x, storageComplex2D[11].y);
            g.DrawLine(PLine, storageComplex2D[7].x, storageComplex2D[7].y, storageComplex2D[11].x, storageComplex2D[11].y);
            g.DrawLine(PLine, storageComplex2D[7].x, storageComplex2D[7].y, storageComplex2D[10].x, storageComplex2D[10].y);
            int d;
            if (storageComplex2D[9].y == Form1.Center.yCenter) { d = 1; }
            else { d = 2 * Math.Abs(Form1.Center.yCenter - storageComplex2D[9].y); }

            if (storageComplex2D[10].y < 0)
            {
                g.DrawArc(PLine, Form1.Center.xCenter - d / 2, Form1.Center.yCenter - d / 2, d, d, 180, 90);
            }
            else { g.DrawArc(PLine, Form1.Center.xCenter - d / 2, Form1.Center.yCenter - d / 2, d, d, 0, 90); }


        }

        CPoint2D Calculate1(CPoint2D Point2D, CPoint3D Point3D, Axis Center)
        {
            Point2D.x = Convert.ToInt32(Center.xCenter - Math.Abs(Point3D.x));
            Point2D.y = Convert.ToInt32(Center.yCenter + Math.Abs(Point3D.y));
            return Point2D;
        }
        CPoint2D Calculate2(CPoint2D Point2D, CPoint3D Point3D, Axis Center)
        {
            Point2D.x = Convert.ToInt32(Center.xCenter - Math.Abs(Point3D.x));
            Point2D.y = Convert.ToInt32(Center.yCenter - Math.Abs(Point3D.z));
            return Point2D;
        }
        CPoint2D Calculate3(CPoint2D Point2D, CPoint3D Point3D, Axis Center)
        {
            Point2D.x = Convert.ToInt32(Center.xCenter + Math.Abs(Point3D.y));
            Point2D.y = Convert.ToInt32(Center.yCenter - Math.Abs(Point3D.z));
            return Point2D;
        }
    }
}
