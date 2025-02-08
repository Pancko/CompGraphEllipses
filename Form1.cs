using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_CompGraphEllipse
{
    public partial class Form1 : Form
    {
        // Размер точки центра
        int centerSize = 10;
        int width1 = 300;
        int height1 = 150;
        int numPoints = 36;
        Graphics g;
        Pen pen;
        SolidBrush brush;
        float rotatingAngle1 = 0;
        float rotatingAngle2 = 0;
        float rotatingAngle3 = 0;
        int rotatingSpeed1;
        int rotatingSpeed2;
        int rotatingSpeed3;
        int travel2 = 0;
        int travel3 = 0;
        int travelSpeed2;
        int travelSpeed3;
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            pen = new Pen(Color.Black, 4);
            brush = new SolidBrush(Color.Black);

            Timer timer = new Timer();
            timer.Interval = 100;
            timer.Tick += (s, e) =>
            {
                rotatingAngle1 += rotatingSpeed1;
                if (rotatingAngle1 >= 360) rotatingAngle1 = 0;

                rotatingAngle2 += rotatingSpeed2;
                if (rotatingAngle2 >= 360) rotatingAngle2 = 0;

                rotatingAngle3 += rotatingSpeed3;
                if (rotatingAngle3 >= 360) rotatingAngle3 = 0;

                travel2 += travelSpeed2;
                if (travel2 >= numPoints) travel2 = 0;
                if (travel2 < 0) travel2 = numPoints + travel2;

                travel3 += travelSpeed3;
                if (travel3 >= numPoints) travel3 = 0;
                if (travel3 < 0) travel3 = numPoints + travel3;

                this.Invalidate();
            };
            timer.Start();

            this.Paint += (s, e) =>
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                int screenWidth = this.ClientSize.Width;
                int screenHeight = this.ClientSize.Height;

                // Первый эллипс
                int x1 = (screenWidth - width1) / 2;
                int y1 = (screenHeight - height1) / 2;
                int center1X = x1 + width1 / 2 - centerSize / 2;
                int center1Y = y1 + height1 / 2 - centerSize / 2;

                PointF[] points1 = new PointF[numPoints];

                for (int i = 0; i < numPoints; i++)
                {
                    double pointAngle = i * (2 * Math.PI / numPoints);
                    float x = center1X + (float)(width1 / 2 * Math.Cos(pointAngle));
                    float y = center1Y + (float)(height1 / 2 * Math.Sin(pointAngle));
                    points1[i] = new PointF(x, y);
                }

                points1 = rotate(points1, rotatingAngle1);
                g.DrawPolygon(pen, points1);
                g.FillEllipse(brush, center1X - centerSize / 2, center1Y - centerSize / 2, centerSize, centerSize);


                // Второй эллипс
                int width2 = width1 / 2;
                int height2 = height1 / 2;
                int x2 = x1 + width1 - width2 / 2;
                int y2 = y1 + (height1 - height2) / 2;
                float center2X = points1[travel2 % numPoints].X;
                float center2Y = points1[travel2 % numPoints].Y;

                PointF[] points2 = new PointF[numPoints];

                for (int i = 0; i < numPoints; i++)
                {
                    double pointAngle = i * (2 * Math.PI / numPoints);
                    float x = center2X + (float)(width2 / 2 * Math.Cos(pointAngle));
                    float y = center2Y + (float)(height2 / 2 * Math.Sin(pointAngle));
                    points2[i] = new PointF(x, y);
                }

                points2 = rotate(points2, rotatingAngle2);
                g.DrawPolygon(pen, points2);
                g.FillEllipse(brush, center2X - centerSize / 2, center2Y - centerSize / 2, centerSize, centerSize);

                // Третий эллипс
                int width3 = width2 / 2;
                int height3 = height2 / 2;
                int x3 = x2 + width2 - width3 / 2;
                int y3 = y2 + (height2 - height3) / 2;
                float center3X = points2[travel3 % numPoints].X;
                float center3Y = points2[travel3 % numPoints].Y;

                PointF[] points3 = new PointF[numPoints];

                for (int i = 0; i < numPoints; i++)
                {
                    double pointAngle = i * (2 * Math.PI / numPoints);
                    float x = center3X + (float)(width3 / 2 * Math.Cos(pointAngle));
                    float y = center3Y + (float)(height3 / 2 * Math.Sin(pointAngle));
                    points3[i] = new PointF(x, y);
                }

                points3 = rotate(points3, rotatingAngle3);
                g.DrawPolygon(pen, points3);
                g.FillEllipse(brush, center3X - centerSize / 2, center3Y - centerSize / 2, centerSize, centerSize);
            };
        }

        PointF[] rotate(PointF[] points, float angle)
        {
            PointF[] newPoints = points;
            float cx1 = 0;
            float cy1 = 0;
            for (int i = 0; i < newPoints.Length; i++)
            {
                cx1 += newPoints[i].X;
                cy1 += newPoints[i].Y;
            }
            cx1 = cx1 / newPoints.Length;
            cy1 = cy1 / newPoints.Length;

            for (int i = 0; i < newPoints.Length; i++)
            {
                float x = (int)((points[i].X - cx1) * Math.Cos(angle) - (points[i].Y - cy1) * Math.Sin(angle)) + cx1;
                float y = (int)((points[i].X - cx1) * Math.Sin(angle) + (points[i].Y - cy1) * Math.Cos(angle)) + cy1;
                newPoints[i] = new PointF(x, y);
            }
            return newPoints;
        }
        private void rotating1_ValueChanged(object sender, EventArgs e)
        {
            rotatingSpeed1 = (int)rotating1.Value;
        }

        private void rotating2_ValueChanged(object sender, EventArgs e)
        {
            rotatingSpeed2 = (int)rotating2.Value;
        }

        private void rotating3_ValueChanged(object sender, EventArgs e)
        {
            rotatingSpeed3 = (int)rotating3.Value;
        }

        private void travelling2_ValueChanged(object sender, EventArgs e)
        {
            travelSpeed2 = (int)travelling2.Value;
        }

        private void travelling3_ValueChanged(object sender, EventArgs e)
        {
            travelSpeed3 = (int)travelling3.Value;
        }
    }


}
