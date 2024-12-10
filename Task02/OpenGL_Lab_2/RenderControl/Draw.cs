using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenGL_Lab_2.Enum;

namespace OpenGL_Lab_2
{
    public partial class RenderControl
    {
        public class Draw
        {
            public delegate void outText(string s, double x, double y, double z = 0);
            public outText Print;
            public void DrawFigure(int verticales, int horizontales, double size, FigureMode figureView)
            {
                double displacementX, displacementY;
                if (verticales != 0 || horizontales != 0)
                {
                    for (int i = 0; i < horizontales; i += 1)
                    {
                        for (int j = 0; j < verticales; j += 1)
                        {
                            displacementX = i * size * 2;
                            displacementY = j * size * 2;
                            if (j > 0)
                            {
                                displacementX += (size * j) / 2;
                            }
                            if (i > 0)
                            {
                                displacementY -= (size / 2) * i;
                            }
                            switch (figureView)
                            {
                                case FigureMode.Fill:
                                    glPolygonMode(GL_FRONT_AND_BACK, GL_FILL);                                    
                                    break;
                                case FigureMode.Line:
                                    glPolygonMode(GL_FRONT_AND_BACK, GL_LINE);                                    
                                    break;
                                case FigureMode.Point:
                                    glPolygonMode(GL_FRONT_AND_BACK, GL_POINT);                                    
                                    break;
                            }
                            glBegin(GL_QUADS);
                            glColor3f(0, 0, 1);
                            QuadsCoordinates(displacementX, displacementY, size);
                            glBegin(GL_QUADS);
                            glColor3f(0, 0, 1);
                            QuadsСrookedCoordinates(displacementX + size, displacementY + size, size);
                            glEnd();
                            glBegin(GL_TRIANGLES);
                            glColor3f(1, 1, 0);
                            TriangleBottomCoordinates(displacementX, displacementY + size, size);
                            glColor3f(1, 1, 0);
                            TriangleRightCoordinates(displacementX + size, displacementY, size);
                            glColor3f(1, 0, 0);
                            TriangleTopCoordinates(displacementX + size * 2, displacementY + size / 2, size);
                            glColor3f(0.6f, 0.6f, 0.6f);
                            TriangleLeftCoordinates(displacementX + size, displacementY - size / 2, size);
                            glEnd();

                        }
                    }
                }
            }
            public void QuadsCoordinates(double start_x, double start_y, double size)
            {
                glVertex2d(start_x, start_y);
                glVertex2d(start_x + size, start_y);
                glVertex2d(start_x + size, start_y + size);
                glVertex2d(start_x, start_y + size);
            }
            public void QuadsСrookedCoordinates(double start_x, double start_y, double size)
            {
                glVertex2d(start_x, start_y);
                glVertex2d(start_x + size / 2, start_y + size);
                glVertex2d(start_x + size * 1.5, start_y + size / 2);
                glVertex2d(start_x + size, start_y - size / 2);
            }
            public void TriangleTopCoordinates(double start_x, double start_y, double size)
            {
                glVertex2d(start_x, start_y);
                glVertex2d(start_x + size / 2, start_y + size);
                glVertex2d(start_x + size, start_y);
            }
            public void TriangleBottomCoordinates(double start_x, double start_y, double size)
            {
                glVertex2d(start_x + size / 2, start_y + size);
                glVertex2d(start_x + size, start_y);
                glVertex2d(start_x + size * 1.5, start_y + size);
            }
            public void TriangleRightCoordinates(double start_x, double start_y, double size)
            {
                glVertex2d(start_x, start_y);
                glVertex2d(start_x, start_y + size);
                glVertex2d(start_x + size, start_y + size / 2);
            }
            public void TriangleLeftCoordinates(double start_x, double start_y, double size)
            {
                glVertex2d(start_x, start_y + size / 2);
                glVertex2d(start_x + size, start_y + size);
                glVertex2d(start_x + size, start_y);
            }
            public void DrawButtons(FigureMode figureMode, double start_x, double end_x, double start_y, double end_y)
            {
                glPolygonMode(GL_FRONT_AND_BACK, GL_FILL);
                string[] buttonLabels = { "Fill", "Lines", "Point" };
                double buttonWidth = 40;
                double buttonHeight = 30;
                double space = 10;

                double xStart = end_x - buttonWidth;
                double yStart = start_y;

                for (int i = 0; i < 3; i++)
                {
                    double x = xStart - i * (buttonWidth + space);
                    double y = yStart;
                    if ((int)figureMode == 2 - i)
                    {
                        glColor3f(1, 0.2f, 0);
                    }
                    else
                    {
                        glColor3f(0.8f, 0.0f, 0.0f);
                    }
                    glBegin(GL_QUADS);
                    glVertex2d(x, y);
                    glVertex2d(x, y + buttonHeight);
                    glVertex2d(x + buttonWidth, y + buttonHeight);
                    glVertex2d(x + buttonWidth, y);
                    glEnd();
                    glColor3f(0, 0, 0);
                    Print(buttonLabels[2 - i], x + 3, y + buttonHeight / 3);
                }
            }
        }
    }
}
