using System;
using System.Drawing;

namespace test1
{
    public partial class RenderControl : OpenGL
    {
        public RenderControl()
        {
            InitializeComponent();
        }

        private double proprller = 0.0;
        private double proprllerSpeed = 0.1;
        private double offsetX = 0.0, offsetY = 0.0;
        private double cx = -0.7, cy = 0.27015;
        private double cxStep = 0.002, cyStep = 0.002;
        private bool isMovingEnabled = true;
        private double speedValue = 0.005;
        private double sizeValue = 1.0;

        private void OnContextCreated(object sender, EventArgs e)
        {
            glClearColor(Color.Black);
            isMovingEnabled = Properties.Settings.Default.IsFloatingFigure;
            cx = (double)Properties.Settings.Default.CxValue;
            cy = (double)Properties.Settings.Default.CyValue;
            speedValue = 0.001 * Properties.Settings.Default.SpeedValue;
            sizeValue = 0.5 * Properties.Settings.Default.SizeValue;
        }

        private void OnRender(object sender, EventArgs e)
        {
            glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);
            glLoadIdentity();

            double viewLeft = -2 + offsetX;
            double viewRight = 2 + offsetX;
            double viewBottom = -2 + offsetY;
            double viewTop = 2 + offsetY;
            glOrtho(viewLeft, viewRight, viewBottom, viewTop, -1, 1);

            DrawProprller();
            if (isMovingEnabled)
            {
                offsetX += speedValue;
                offsetY += speedValue;

                if (offsetX > 2 || offsetX < -2) speedValue = -speedValue;

                cx += cxStep;
                cy += cyStep;
                if (cx > 0.7 || cx < -0.7) cxStep = -cxStep;
                if (cy > 0.7 || cy < -0.7) cyStep = -cyStep;
            }
        }

        private void DrawProprller()
        {
            int resolution = 500;
            double scale = 4.0 / resolution;

            for (int i = 0; i < resolution; i++)
            {
                for (int j = 0; j < resolution; j++)
                {
                    double x = (i - resolution / 2.0) * scale + offsetX;
                    double y = (j - resolution / 2.0) * scale + offsetY;

                    double distance = Math.Sqrt(x * x + y * y);

                    double angle = Math.Atan2(y, x);
                    double radius = 1.5 * Math.Abs(Math.Sin(angle * 2.0 + proprller));
                    double heartX = radius * Math.Cos(angle);
                    double heartY = radius * Math.Sin(angle);

                    if (distance <= Math.Sqrt(heartX * heartX + heartY * heartY))
                    {
                        double color = 1.0 - distance / 1.5;
                        glColor3d(color, color, color);

                        glPointSize(2.0f);
                        glBegin(GL_POINTS);
                        glVertex2d(x, y);
                        glEnd();
                    }
                }
            }
            proprller += proprllerSpeed;
            if (proprller > Math.PI * 2)
                proprller -= Math.PI * 2;
        }
    }
}
