using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;

namespace Lab1
{
    public partial class RenderControl : OpenGL
    {
        public RenderControl()
        {
            InitializeComponent();
        }

        private void RenderControl_Render(object sender, EventArgs e)
        {
            Figures figures = new Figures();
            glClear(GL_COLOR_BUFFER_BIT);
            glLoadIdentity();
            glViewport(0, 0, Width, Height);
            gluOrtho2D(-10, +3, -5, +3);

            glLineWidth(1);
            glEnable(GL_LINE_STIPPLE);
            glLineStipple(6, 0xAAAA);
            glColor3ub(200, 200, 200);
            glBegin(GL_LINES);

            figures.Grid();
            figures.DrawFigure();
            figures.DrawPoints();
        }
    }
}