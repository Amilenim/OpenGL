using System;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using OpenGL_Lab_2.Enum;
using static OpenGL_Lab_2.OpenGL;


namespace OpenGL_Lab_2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OnSizeWindowChange(object sender, System.EventArgs e)
        {
            renderControl1.Horizontales = (int)horizontalNumericUpDown.Value;
            renderControl1.Verticales = (int)verticalNumericUpDown.Value;
            renderControl1.Invalidate();
        }

        private void OnViewModeCheckedChanged(object sender, System.EventArgs e)
        {
            if (fillViewRadioButton.Checked)
            {
                renderControl1.figureView = FigureMode.Fill;
            }
            else if (lineViewRadioButton.Checked)
            {
                renderControl1.figureView = FigureMode.Line;
            }
            else if (pointViewRadioButton.Checked)
            {
                renderControl1.figureView = FigureMode.Point;
            }
            renderControl1.Invalidate();
        }

        private void OnClick(object sender, MouseEventArgs e)
        {
            double sizeX = renderControl1.ClientRectangle.Width;
            double sizeY = renderControl1.ClientRectangle.Height;

            double trueY = sizeY - e.Y;

            double buttonWidth = 40;
            double buttonHeight = 30;
            double buttonSpace = 10;

            double xStart = sizeX - (buttonWidth);
            double yStart = buttonSpace;

            for (int i = 0; i < 3; i++)
            {
                int count = 2;
                double x = xStart - i * (buttonWidth + buttonSpace);
                double y = yStart;

                if (e.X >= x && e.X <= x + buttonWidth && trueY >= y && trueY <= y + buttonHeight)
                {
                    renderControl1.figureView = (FigureMode)count - i;
                    switch (count - i)
                    {
                        case 0:
                            fillViewRadioButton.Checked = true; break;
                        case 1:
                            lineViewRadioButton.Checked = true; break;
                        case 2:
                            pointViewRadioButton.Checked = true; break;
                    }
                    renderControl1.Invalidate();
                    break;
                }
            }
        }
    }
}