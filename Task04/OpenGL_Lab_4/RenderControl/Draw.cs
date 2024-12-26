using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenGL_Lab_4
{
    public partial class RenderControl
    {
        public class Draw
        {
            public void DrawParametricEllipse(double a, double b)
            {
                glColor3f(0.0f, 0.0f, 1.0f);
                glBegin(GL_LINE_LOOP);

                int segments = 100;
                for (int i = 0; i <= segments; i++)
                {
                    double t = 2.0 * Math.PI * i / segments;
                    double x = 0.0 + a * Math.Cos(t);
                    double y = 0.0 + b * Math.Sin(t);
                    glVertex2d(x, y);
                }

                glEnd();
            }


            public void DrawHyperbola(double a, double b)
            {
                glColor3d(0, 0, 1);

                glBegin(GL_LINE_STRIP);
                double tMax = 3.0;

                for (double t = -tMax; t <= tMax; t += 0.05)
                {
                    double x = a * Math.Cosh(t);
                    double y = b * Math.Sinh(t);
                    glVertex2d(x, y);
                }
                glEnd();

                glBegin(GL_LINE_STRIP);
                for (double t = -tMax; t <= tMax; t += 0.05)
                {
                    double x = -a * Math.Cosh(t);
                    double y = b * Math.Sinh(t);
                    glVertex2d(x, y);
                }
                glEnd();
            }



            public void SearchPoint(double a, double b, double Xls, double Yls, double Xle, double Yle, bool isChoosed)
            {
                glPointSize(5.0f);
                glColor3f(0.0f, 1.0f, 0.0f);
                glBegin(GL_POINTS);

                double dx = Xle - Xls;
                double dy = Yle - Yls;

                double A, B, C;
                if (isChoosed)
                {
                    A = (dx * dx) / (a * a) - (dy * dy) / (b * b);
                    B = 2 * (Xls * dx / (a * a) - Yls * dy / (b * b));
                    C = (Xls * Xls) / (a * a) - (Yls * Yls) / (b * b) - 1;
                }
                else
                {
                    A = (dx * dx) / (a * a) + (dy * dy) / (b * b);
                    B = 2 * (Xls * dx / (a * a) + Yls * dy / (b * b));
                    C = (Xls * Xls) / (a * a) + (Yls * Yls) / (b * b) - 1;
                }

                HandleDiscriminant(A, B, C, dx, dy, Xls, Yls);

                glEnd();
            }


            private void HandleDiscriminant(double A, double B, double C, double dx, double dy, double Xls, double Yls)
            {
                double discriminant = B * B - 4 * A * C;
                if (discriminant >= 0)
                {
                    double sqrtD = Math.Sqrt(discriminant);
                    if (A != 0)
                    {
                        AddPoint((-B + sqrtD) / (2 * A), dx, dy, Xls, Yls);
                        AddPoint((-B - sqrtD) / (2 * A), dx, dy, Xls, Yls);
                    }
                    else if (B != 0)
                    {
                        AddPoint(-C / B, dx, dy, Xls, Yls);
                    }
                }
            }


            private void AddPoint(double t, double dx, double dy, double Xls, double Yls)
            {
                if (t >= 0 && t <= 1)
                {
                    double x = Xls + t * dx;
                    double y = Yls + t * dy;
                    glVertex2d(x, y);
                }
            }



            public double FindMax(double a, double b, bool isChoosed)
            {
                double maxX, maxY;

                if (!isChoosed)
                {
                    maxX = Math.Abs(a);
                    maxY = Math.Abs(b);
                }
                else
                {
                    double range = 2.0;
                    maxX = range;
                    maxY = a;

                }
                return Math.Max(maxX, maxY);
            }
            public void DrawGrid(double XMin, double XMax, double YMin, double YMax)
            {
                glLineWidth(1.0f);
                glColor3ub(200, 200, 200);
                glBegin(GL_LINES);
                for (double i = XMin; i <= XMax; i += XMax / 10)
                {
                    glVertex2d(i, YMin);
                    glVertex2d(i, YMax);
                }
                for (double j = YMin; j <= YMax; j += YMax / 10)
                {
                    glVertex2d(XMin, j);
                    glVertex2d(XMax, j);
                }
                glEnd();
            }

            public void DrawCoordinateGrid(double XMin, double XMax, double YMin, double YMax)
            {
                glLineWidth(2.0f);
                glBegin(GL_LINES);
                glColor3ub(0, 0, 0);
                glVertex2d(XMin, 0);
                glVertex2d(XMax, 0);
                glVertex2d(0, YMin);
                glVertex2d(0, YMax);
                glEnd();
                glLineWidth(1.0f);
            }

            public void DrawLineWait(double XMin, double XMax, double YMin, double YMax)
            {
                glColor3f(0.0f, 0.0f, 0.0f);
                glLineWidth(1.7f);
                glBegin(GL_LINES);
                glVertex2d(XMin, YMin);
                glVertex2d(XMax, YMax);
                glEnd();
            }
            public void DrawLine(double XMin, double XMax, double YMin, double YMax)
            {
                glColor3f(0.0f, 0.0f, 0.0f);
                glLineWidth(1.7f);
                glBegin(GL_LINES);
                glVertex2d(XMin, YMin);
                glVertex2d(XMax, YMax);
                glEnd();
            }
        }
    }
}
