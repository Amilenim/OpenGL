using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenGL_Lab_3
{
    public partial class RenderControl
    {
        public class Draw
        {
            public void DrawGrid(double XMin, double XMax, double YMin, double YMax)
            {
                glLineWidth(1.0f);
                glColor3ub(200, 200, 200);
                glBegin(GL_LINES);
                for (double i = XMin; i <= XMax; i += 0.2)
                {
                    glVertex2d(i, YMin);
                    glVertex2d(i, YMax);
                }
                for (double j = YMin; j <= YMax; j += 0.2)
                {
                    glVertex2d(XMin, j);
                    glVertex2d(XMax, j);
                }
                glEnd();
            }
            public void CoordinateGrid(double XMin, double XMax, double YMin, double YMax)
            {
                glLineWidth(3.0f);
                glBegin(GL_LINES);
                glColor3ub(0, 0, 0);
                glVertex2d(XMin, 0);
                glVertex2d(XMax, 0);
                glVertex2d(0, YMin);
                glVertex2d(0, YMax);
                glEnd();
            }
            public void FunctionLinesAndPoints(double XMin, double XMax, double YMin, double YMax, double pointNum, Func<double, double> func)
            {
                glLineWidth(2.0f);
                glColor3ub(0, 0, 0);
                glBegin(GL_LINE_STRIP);

                double previousY = double.NaN;
                double stepSize = (XMax - XMin) / (pointNum - 1);
                double x = XMin;
                double y = func(x);
                glVertex2d(x, y);
                for (int i = 0; i < pointNum; i++)
                {
                    previousY = y;
                    x = XMin + i * stepSize;
                    y = func(x);

                    if (!double.IsNaN(previousY) && Math.Abs(y - previousY) > 5.0)
                    {
                        glEnd();
                        glBegin(GL_LINE_STRIP);
                        continue;
                    }
                    glVertex2d(x, y);

                    if ((previousY * y) <= 0 && previousY != 0)
                    {
                        glEnd();
                        Point(previousY, x, stepSize, y);
                        glBegin(GL_LINE_STRIP);
                        glColor3ub(0, 0, 0);
                        glVertex2d(x, y);
                    }
                }
                glEnd();
            }
            public (double, double) FindMinAndMax(double XMin, double XMax, double pointNum, Func<double, double> func)
            {
                double stepSize = (XMax - XMin) / (pointNum - 1);
                double x = XMin;
                double y = func(x);
                double minY = y, maxY = y;

                for (int i = 0; i < pointNum; i++)
                {
                    x = XMin + i * stepSize;
                    y = func(x);

                    if (y > maxY)
                    {  
                        maxY = y; 
                    }
                    if (y < minY)
                    {
                        minY = y;

                    }
                }
                return (minY, maxY);
            }
            private void Point(double previousY, double x, double h, double y)
            {
                glPointSize(5.0f);
                glColor3ub(250, 0, 0);
                glBegin(GL_POINTS);
                glVertex2d(x - h / 2, (previousY + y) / 2);
                glEnd();
            }
        }
    }
}
