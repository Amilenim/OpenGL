using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Windows.Forms;
using static OpenGL_Lab_3.OpenGL;


namespace OpenGL_Lab_3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Cordinate_ValueChanged(object sender, System.EventArgs e)
        {
            renderControl1.XMin = (double)numericUpDownXmin.Value;
            //numericUpDownXmin.Maximum = (decimal)((double)numericUpDownXmax.Value - 1);

            renderControl1.XMax = (double)numericUpDownXmax.Value;
            //numericUpDownXmax.Minimum = (decimal)((double)numericUpDownXmin.Value + 1);

            renderControl1.YMin = (double)numericUpDownYmin.Value;
            //numericUpDownYmin.Maximum = (decimal)((double)numericUpDownYmax.Value - 1);

            renderControl1.YMax = (double)numericUpDownYmax.Value;
            //numericUpDownYmax.Minimum = (decimal)((double)numericUpDownYmin.Value + 1);
            renderControl1.Invalidate();
        }

        private void Points_ValueChanged(object sender, System.EventArgs e)
        {
            renderControl1.pointNum = (int)numericUpDownPoints.Value;
            renderControl1.Invalidate();
        }

        private void Func_CheckedChanged(object sender, System.EventArgs e)
        {
            if (radioButtonFunc1.Checked)
            {
                renderControl1.Func = 0;
            }
            if (radioButtonFunc2.Checked)
            {
                renderControl1.Func = 1;
            }
            renderControl1.Invalidate();
        }

        private void buttonAutoCalcY_Click(object sender, System.EventArgs e)
        {
            if (!renderControl1.AutoCalcY)
            {
                buttonAutoCalcY.Text = "Back";
                label5.Location = new Point(label5.Location.X, label5.Location.Y + 60);
                numericUpDownPoints.Location = new Point(numericUpDownPoints.Location.X, numericUpDownPoints.Location.Y + 60);
                buttonAutoCalcY.Location = new Point(buttonAutoCalcY.Location.X, buttonAutoCalcY.Location.Y + 60);
                numericUpDownYmin.Visible = true;
                numericUpDownYmax.Visible = true;
                label3.Visible = true;
                label4.Visible = true;

            }
            else
            {
                buttonAutoCalcY.Text = "Auto Calc (Y)";
                label5.Location = new Point(label5.Location.X, label5.Location.Y - 60);
                numericUpDownPoints.Location = new Point(numericUpDownPoints.Location.X, numericUpDownPoints.Location.Y - 60);
                buttonAutoCalcY.Location = new Point(buttonAutoCalcY.Location.X, buttonAutoCalcY.Location.Y - 60);
                numericUpDownYmin.Visible = false;
                numericUpDownYmax.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
            }
            renderControl1.AutoCalcY = !renderControl1.AutoCalcY;
            renderControl1.Invalidate();
        }
    }
}
