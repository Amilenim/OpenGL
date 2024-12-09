using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using OpenGL_Lab_2.Enum;
using static OpenGL_Lab_2.RenderControl;

namespace OpenGL_Lab_2
{
    public partial class RenderControl : OpenGL
    {
        public int Verticales { get; set; } = 1;
        public int Horizontales { get; set; } = 1;
        public FigureMode figureView { get; set; } = 0;

         Draw draw;
        double size = 15.0;
        double sizeSide = 4.25;


        public RenderControl()
        {
            InitializeComponent();
        }

        private void OnRender(object sender, EventArgs e)
        {
            glClear(GL_COLOR_BUFFER_BIT);
            glLoadIdentity();

            if (Width > Height)
            {
                glViewport((Width - Height) / 2, 0, Height, Height);
            }
            else
            {
                glViewport(0, (Height - Width) / 2, Width, Width);
            }
            double maxSize = Math.Max(Horizontales, Verticales);
            gluOrtho2D(-size * maxSize, size * maxSize, -size * maxSize, size * maxSize);

            draw.DrawFigure(Verticales, Horizontales, sizeSide, figureView);

            glLoadIdentity();
            glViewport(0, 0, Width, Height);
            gluOrtho2D(-Width / 2, Width / 2, -Height / 2, Height / 2);
            draw.DrawButtons(figureView, -Width / 2, Width / 2, -Height / 2, Height / 2);
        }

        private void RenderControl_ContextCreated(object sender, EventArgs e)
        {
            draw = new Draw();
            draw.Print = DrawText;
        }
    }
}

