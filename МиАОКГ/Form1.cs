using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace МиАОКГ
{
    public partial class Form1 : Form
    {

        int x;
        int y;
        int z;
        double alfa;
        double betta;
        double gamma;
        Graphics g1;
        Graphics g2;
        public static Axis Center;
        SpecialDrawing spacialDrawing = new SpecialDrawing();
        ComplexDrawing complexDrawing = new ComplexDrawing();
        CPoint3D[] baseStorage3DPoints = new CPoint3D[14];


        public Form1()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void trackBarX_Scroll(object sender, EventArgs e)
        {
            //pictureBox1.Refresh();
            //pictureBox2.Refresh();
            vX.Text = trackBarX.Value.ToString();
        }

        private void trackBarY_Scroll(object sender, EventArgs e)
        {
            //pictureBox1.Refresh();
            //pictureBox2.Refresh();
            vY.Text = trackBarY.Value.ToString();
        }

        private void trackBarZ_Scroll(object sender, EventArgs e)
        {
            //pictureBox1.Refresh();
            //pictureBox2.Refresh();
            vZ.Text = trackBarZ.Value.ToString();
        }

        private void trackBarAlfa_Scroll(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            CurValueAlfa.Text = trackBarAlfa.Value.ToString();
        }

        private void trackBarBeta_Scroll(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            CurValueBeta.Text = trackBarBeta.Value.ToString();
        }

        private void trackBarGamma_Scroll(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            CurValueGamma.Text = trackBarGamma.Value.ToString();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            g1 = e.Graphics;
            input();
            processSpacial();
            outputSpacial();
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            g2 = e.Graphics;
            input();
            processComplex();
            outputComplex();
        }

        void input()
        {


            alfa = convertToRadian(trackBarAlfa.Value);
            betta = convertToRadian(trackBarBeta.Value);
            gamma = convertToRadian(trackBarGamma.Value);
            createPoints();
        }
        void createPoints()
        {
            Center = new Axis(pictureBox1.Width / 2, pictureBox1.Height / 2);
            int lenAxis;
            int offset;
            offset = Math.Min(Center.xCenter, Center.yCenter) / 3;
            lenAxis = Math.Min(Center.xCenter, Center.yCenter) - offset;
            x = trackBarX.Value;
            y = trackBarY.Value;
            z = trackBarZ.Value;
            baseStorage3DPoints[0] = new CPoint3D(x, y, z, "t_2d", Brushes.Black);
            baseStorage3DPoints[1] = new CPoint3D(x, 0, 0, "tx_2d", Brushes.Black);
            baseStorage3DPoints[2] = new CPoint3D(0, y, 0, "ty_2d", Brushes.Black);
            baseStorage3DPoints[3] = new CPoint3D(0, 0, z, "tz_2d", Brushes.Black);
            baseStorage3DPoints[4] = new CPoint3D(0, y, z, "t3_2d", Brushes.Black);
            baseStorage3DPoints[5] = new CPoint3D(x, 0, z, "t2_2d", Brushes.Black);
            baseStorage3DPoints[6] = new CPoint3D(x, y, 0, "t1_2d", Brushes.Black);
            baseStorage3DPoints[7] = new CPoint3D(0, 0, 0, "to_2d", Brushes.Black);
            baseStorage3DPoints[8] = new CPoint3D(lenAxis, 0, 0, "tox1_2d", Brushes.Black);
            baseStorage3DPoints[9] = new CPoint3D(-lenAxis, 0, 0, "tox2_2d", Brushes.Black);
            baseStorage3DPoints[10] = new CPoint3D(0, lenAxis, 0, "toy1_2d", Brushes.Black);
            baseStorage3DPoints[11] = new CPoint3D(0, -lenAxis, 0, "toy2_2d", Brushes.Black);
            baseStorage3DPoints[12] = new CPoint3D(0, 0, lenAxis, "toz1_2d", Brushes.Black);
            baseStorage3DPoints[13] = new CPoint3D(0, 0, -lenAxis, "toz2_2d", Brushes.Black);
        }
        void processSpacial()
        {
            spacialDrawing.updatePoints(baseStorage3DPoints, alfa, betta, gamma);

        }
        void processComplex()
        {
            complexDrawing.updatePoints(baseStorage3DPoints);
        }
        void outputSpacial()
        {
            Font fontPoint = new Font(label0.Font, label0.Font.Style);
            spacialDrawing.drawPoints(g1, fontPoint);
        }
        void outputComplex()
        {
            Font fontPoint = new Font(label0.Font, label0.Font.Style);
            complexDrawing.drawPoints(g2, fontPoint);
        }


        double convertToRadian(int angle)
        {
            double angled = angle;
            angled = (angled / 180) * Math.PI;
            return angled;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            pictureBox2.Refresh();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                trackBarX.Minimum = 0;
                trackBarX.Maximum = 60;
                trackBarY.Minimum = 0;
                trackBarY.Maximum = 60;
                trackBarZ.Minimum = 0;
                trackBarZ.Maximum = 60;
                labelMinX.Text = "0";
                labelMaxX.Text = "60";
                trackBarX.Value = 0;
                labelMinY.Text = "0";
                labelMaxY.Text = "60";
                trackBarY.Value = 0;
                labelMinZ.Text = "0";
                labelMaxZ.Text = "60";
                trackBarZ.Value = 0;
            }
            else if (radioButton2.Checked)
            {
                trackBarX.Minimum = -60;
                trackBarX.Maximum = 0;
                trackBarY.Minimum = -60;
                trackBarY.Maximum = 0;
                trackBarZ.Minimum = -60;
                trackBarZ.Maximum = 0;
                labelMinX.Text = "-60";
                labelMaxX.Text = "0";
                trackBarX.Value = 0;
                labelMinY.Text = "-60";
                labelMaxY.Text = "0";
                trackBarY.Value = 0;
                labelMinZ.Text = "-60";
                labelMaxZ.Text = "0";
                trackBarZ.Value = 0;
            }
        }
    }
}


