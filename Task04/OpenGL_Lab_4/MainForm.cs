using System;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;
using static OpenGL_Lab_4.OpenGL;


namespace OpenGL_Lab_4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OnCheckedChangedRb1(object sender, System.EventArgs e)
        {
            renderControl1.ChosedFigure = false;
            numericUpDownA.Visible = true;
            label1.Visible = true;
            renderControl1.Invalidate();
        }

        private void OnCheckedChangedRb2(object sender, System.EventArgs e)
        {
            renderControl1.ChosedFigure = true;
            numericUpDownA.Visible = false;
            label1.Visible = false;
            renderControl1.CoefficientA = 1.0;

            renderControl1.Invalidate();
        }

        private void OnValueChangedA(object sender, System.EventArgs e)
        {
            if (numericUpDownA.Value == numericUpDownB.Value)
            {
                numericUpDownB.Value = (double)numericUpDownA.Value > renderControl1.CoefficientA ?
                    (decimal)((double)numericUpDownB.Value - 0.1) :
                    (decimal)((double)numericUpDownB.Value + 0.1);
            }
            renderControl1.CoefficientA = (double)numericUpDownA.Value;
            renderControl1.Invalidate();
        }

        private void OnValueChangedB(object sender, System.EventArgs e)
        {
            if (numericUpDownA.Value == numericUpDownB.Value)
            {
                numericUpDownA.Value = (double)numericUpDownB.Value > renderControl1.CoefficientB ?
                    (decimal)((double)numericUpDownA.Value - 0.1) :
                    (decimal)((double)numericUpDownA.Value + 0.1);
            }
            renderControl1.CoefficientB = (double)numericUpDownB.Value;
            renderControl1.Invalidate();
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                double width = renderControl1.ClientRectangle.Width;
                double height = renderControl1.ClientRectangle.Height;
                double minSide = Math.Min(width, height);
                double maxSide = Math.Max(width, height);
                double difference = maxSide - minSide;

                bool isWidthGreater = width > height;
                double xLength = isWidthGreater ? width / height : 1;
                double yLength = !isWidthGreater ? height / width : 1;

                bool isInBounds = difference / 2 < (isWidthGreater ? e.X : height - e.Y) &&
                                  (isWidthGreater ? e.X : height - e.Y) < minSide + difference / 2;

                renderControl1.LineIsExist = (difference != 0) ? isInBounds : true;

                if (renderControl1.LineIsExist)
                {
                    renderControl1.MouseIsUp = false;
                    renderControl1.StartLineX = renderControl1.FinishLineX = (renderControl1.Length * xLength) * ((e.X - width / 2.0) / (width / 2.0));
                    renderControl1.StartLineY = renderControl1.FinishLineY = (renderControl1.Length * yLength) * ((height / 2.0 - e.Y) / (height / 2.0));
                }
            }
            renderControl1.Invalidate();
        }


        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && renderControl1.LineIsExist)
            {
                double width = renderControl1.ClientRectangle.Width;
                double height = renderControl1.ClientRectangle.Height;

                bool isWidthGreater = width > height;
                double xLength = isWidthGreater ? width / height : 1;
                double yLength = !isWidthGreater ? height / width : 1;

                renderControl1.FinishLineX = (renderControl1.Length * xLength) * ((e.X - width / 2.0) / (width / 2.0));
                renderControl1.FinishLineY = (renderControl1.Length * yLength) * ((height / 2.0 - e.Y) / (height / 2.0));

                renderControl1.MouseIsUp = true;

                bool isLineSame = renderControl1.FinishLineX == renderControl1.StartLineX && renderControl1.FinishLineY == renderControl1.StartLineY;
                renderControl1.LineIsExist = !isLineSame;
            }
            renderControl1.Invalidate();
        }
    }
}
