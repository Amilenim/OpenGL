using OpenGL_Lab_3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using static OpenGL_Lab_3.RenderControl;

namespace OpenGL_Lab_3
{
    public partial class RenderControl : OpenGL
    {
        Draw draw;
        public double pointNum = 500;
        public bool AutoCalcY { get; set; } = false;
        public double XMin { get; set; } = -1;
        public double XMax { get; set; } = +1;
        public double YMin { get; set; } = -1;
        public double YMax { get; set; } = +1;
        public int Func { get; set; } = 0;
        Func<double, double>[] functionArray;
        public RenderControl()
        {
            InitializeComponent();
        }

        private void RenderControl_Render(object sender, EventArgs e)
        {
            glClear(GL_COLOR_BUFFER_BIT);
            glLoadIdentity();
            glViewport(0, 0, Width, Height);
            if (!AutoCalcY)
            {
                (YMin, YMax) = draw.FindMinAndMax(XMin, XMax, pointNum, functionArray[Func]);
            }
            YMax = Math.Min(YMax, 100);
            YMin = Math.Max(YMin, -100);
            gluOrtho2D(XMin, XMax, YMin, YMax);
            draw.DrawGrid(XMin, XMax, YMin, YMax);
            draw.CoordinateGrid(XMin, XMax, YMin, YMax);
            draw.FunctionLinesAndPoints(XMin, XMax, YMin, YMax, pointNum, functionArray[Func]);
        }
        private void RenderControl_ContextCreated(object sender, EventArgs e)
        {
            draw = new Draw();
            functionArray = new Func<double, double>[]
            {
                // f1(x) = cos(cos(2x + 0.1))
                x => {
                    double innerCos = Math.Cos(2 * x + 0.1);
                    return Math.Cos(innerCos);
                },
                // f2(x) = (cos(cos(pi * x)) * e^(cos(5x))) / |cos(cos(pi * x))| - 0.5
                x => {
                    double innerCosPiX = Math.Cos(Math.PI * x);
                    double expValue = Math.Exp(Math.Cos(5 * x));
                    double numerator = Math.Cos(innerCosPiX) * expValue;
                    double denominator = Math.Abs(innerCosPiX);
                    return numerator / denominator - 0.5;
                },
            };
        }
    }
}
