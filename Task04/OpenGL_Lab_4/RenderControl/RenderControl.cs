using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;

namespace OpenGL_Lab_4
{
    public partial class RenderControl : OpenGL
    {
        Draw draw;
        public double StartLineX { get; set; }
        public double StartLineY { get; set; }
        public double FinishLineX { get; set; }
        public double FinishLineY { get; set; }
        public double Length { get; set; } = 1.5;
        public bool ChosedFigure { get; set; } = false;
        public bool MouseIsUp { get; set; } = true;
        public bool LineIsExist { get; set; } = false;
        public double CoefficientA { get; set; } = 1.0;
        public double CoefficientB { get; set; } = 1.0;

        public RenderControl()
        {
            InitializeComponent();
        }

        private void OnRender(object sender, EventArgs e)
        {
            glClear(GL_COLOR_BUFFER_BIT);
            glLoadIdentity();

            int size = Math.Min(Width, Height);
            glViewport((Width - size) / 2, (Height - size) / 2, size, size);
            Length = draw.FindMax(CoefficientA, CoefficientB, ChosedFigure);
            gluOrtho2D(-Length, Length, -Length, Length);
            draw.DrawGrid(-Length, Length, -Length, Length);
            draw.DrawCoordinateGrid(-Length, Length, -Length, Length);
            if (!ChosedFigure)
                draw.DrawParametricEllipse(CoefficientA, CoefficientB);
            else
                draw.DrawHyperbola(CoefficientA, CoefficientB);
            if (LineIsExist)
            {
                CreateLine();
                draw.SearchPoint(CoefficientA, CoefficientB, StartLineX, StartLineY, FinishLineX, FinishLineY, ChosedFigure);
            }
        }

        private void CreateLine()
        {
            if (!MouseIsUp)
            {
                draw.DrawLineWait(StartLineX, FinishLineX, StartLineY, FinishLineY);
            }
            else
            {
                draw.DrawLine(StartLineX, FinishLineX, StartLineY, FinishLineY);
            }
        }

        private void OnCreated(object sender, EventArgs e)
        {
            draw = new Draw();
        }
    }
}
