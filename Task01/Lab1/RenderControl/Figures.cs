using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public partial class RenderControl
    {
        public class Figures
        {
            public void Grid()
            {
                for (int i = -8; i <= 1; i++)
                {
                    glVertex2d(i, -4);
                    glVertex2d(i, 2);
                }
                for (int j = -3; j <= 1; j++)
                {
                    glVertex2d(-9, j);
                    glVertex2d(2, j);
                }
                glEnd();
                glDisable(GL_LINE_STIPPLE);
            }
            public void Form(int OffsetX = 0)
            {
                glBegin(GL_LINE_LOOP);
                glVertex2d(-8 + OffsetX, 1);
                glVertex2d(-6 + OffsetX, 1);
                glVertex2d(-5 + OffsetX, -1);
                glVertex2d(-5 + OffsetX, -3);
                glVertex2d(-7 + OffsetX, -3);
                glVertex2d(-8 + OffsetX, -1);
                glEnd();
            }
            public void DrawFigure()
            {
                glLineWidth(3);
                glColor3ub(0, 0, 0);
                glBegin(GL_LINE_LOOP);
                Form(0);
                glEnd();
            }
            public void DrawPoints()
            {
                glEnable(GL_POINT);
                glPointSize(5);
                glBegin(GL_POINTS);
                Form(5);
                glEnd();
                glDisable(GL_POINT);
            }
        }
    }
}
