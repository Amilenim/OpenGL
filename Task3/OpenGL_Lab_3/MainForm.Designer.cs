
namespace OpenGL_Lab_3
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            renderControl1 = new RenderControl();
            numericUpDownXmin = new System.Windows.Forms.NumericUpDown();
            numericUpDownXmax = new System.Windows.Forms.NumericUpDown();
            numericUpDownYmin = new System.Windows.Forms.NumericUpDown();
            numericUpDownYmax = new System.Windows.Forms.NumericUpDown();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            radioButtonFunc1 = new System.Windows.Forms.RadioButton();
            radioButtonFunc2 = new System.Windows.Forms.RadioButton();
            label5 = new System.Windows.Forms.Label();
            numericUpDownPoints = new System.Windows.Forms.NumericUpDown();
            buttonAutoCalcY = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownXmin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownXmax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownYmin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownYmax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPoints).BeginInit();
            SuspendLayout();
            // 
            // renderControl1
            // 
            renderControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            renderControl1.AutoCalcY = false;
            renderControl1.BackColor = System.Drawing.Color.White;
            renderControl1.ForeColor = System.Drawing.Color.White;
            renderControl1.Func = 0;
            renderControl1.Location = new System.Drawing.Point(0, 0);
            renderControl1.Name = "renderControl1";
            renderControl1.Size = new System.Drawing.Size(460, 324);
            renderControl1.TabIndex = 0;
            renderControl1.TextCodePage = 1251;
            renderControl1.XMax = 1.5D;
            renderControl1.XMin = -1.5D;
            renderControl1.YMax = 0.99999768968962766D;
            renderControl1.YMin = 0.54030435039544089D;
            // 
            // numericUpDownXmin
            // 
            numericUpDownXmin.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            numericUpDownXmin.DecimalPlaces = 1;
            numericUpDownXmin.Location = new System.Drawing.Point(552, 20);
            numericUpDownXmin.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            numericUpDownXmin.Name = "numericUpDownXmin";
            numericUpDownXmin.Size = new System.Drawing.Size(60, 23);
            numericUpDownXmin.TabIndex = 1;
            numericUpDownXmin.Value = new decimal(new int[] { 1, 0, 0, int.MinValue });
            numericUpDownXmin.ValueChanged += Cordinate_ValueChanged;
            // 
            // numericUpDownXmax
            // 
            numericUpDownXmax.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            numericUpDownXmax.DecimalPlaces = 1;
            numericUpDownXmax.Location = new System.Drawing.Point(552, 50);
            numericUpDownXmax.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            numericUpDownXmax.Name = "numericUpDownXmax";
            numericUpDownXmax.Size = new System.Drawing.Size(60, 23);
            numericUpDownXmax.TabIndex = 2;
            numericUpDownXmax.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownXmax.ValueChanged += Cordinate_ValueChanged;
            // 
            // numericUpDownYmin
            // 
            numericUpDownYmin.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            numericUpDownYmin.DecimalPlaces = 1;
            numericUpDownYmin.Location = new System.Drawing.Point(552, 80);
            numericUpDownYmin.Maximum = new decimal(new int[] { 0, 0, 0, 0 });
            numericUpDownYmin.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            numericUpDownYmin.Name = "numericUpDownYmin";
            numericUpDownYmin.Size = new System.Drawing.Size(60, 23);
            numericUpDownYmin.TabIndex = 3;
            numericUpDownYmin.Value = new decimal(new int[] { 1, 0, 0, int.MinValue });
            numericUpDownYmin.Visible = false;
            numericUpDownYmin.ValueChanged += Cordinate_ValueChanged;
            // 
            // numericUpDownYmax
            // 
            numericUpDownYmax.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            numericUpDownYmax.DecimalPlaces = 1;
            numericUpDownYmax.Location = new System.Drawing.Point(552, 110);
            numericUpDownYmax.Name = "numericUpDownYmax";
            numericUpDownYmax.Size = new System.Drawing.Size(60, 23);
            numericUpDownYmax.TabIndex = 4;
            numericUpDownYmax.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownYmax.Visible = false;
            numericUpDownYmax.ValueChanged += Cordinate_ValueChanged;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(488, 20);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(35, 15);
            label1.TabIndex = 5;
            label1.Text = "Xmin";
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(488, 50);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(36, 15);
            label2.TabIndex = 6;
            label2.Text = "Xmax";
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(488, 80);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(34, 15);
            label3.TabIndex = 7;
            label3.Tag = "";
            label3.Text = "Ymin";
            label3.Visible = false;
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(488, 110);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(35, 15);
            label4.TabIndex = 8;
            label4.Text = "Ymax";
            label4.Visible = false;
            // 
            // radioButtonFunc1
            // 
            radioButtonFunc1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            radioButtonFunc1.AutoSize = true;
            radioButtonFunc1.Checked = true;
            radioButtonFunc1.Location = new System.Drawing.Point(488, 293);
            radioButtonFunc1.Name = "radioButtonFunc1";
            radioButtonFunc1.Size = new System.Drawing.Size(57, 19);
            radioButtonFunc1.TabIndex = 9;
            radioButtonFunc1.TabStop = true;
            radioButtonFunc1.Text = "Func1";
            radioButtonFunc1.UseVisualStyleBackColor = true;
            radioButtonFunc1.CheckedChanged += Func_CheckedChanged;
            // 
            // radioButtonFunc2
            // 
            radioButtonFunc2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            radioButtonFunc2.AutoSize = true;
            radioButtonFunc2.Location = new System.Drawing.Point(548, 293);
            radioButtonFunc2.Name = "radioButtonFunc2";
            radioButtonFunc2.Size = new System.Drawing.Size(57, 19);
            radioButtonFunc2.TabIndex = 10;
            radioButtonFunc2.Text = "Func2";
            radioButtonFunc2.UseVisualStyleBackColor = true;
            radioButtonFunc2.CheckedChanged += Func_CheckedChanged;
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(488, 83);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(40, 15);
            label5.TabIndex = 11;
            label5.Text = "Points";
            // 
            // numericUpDownPoints
            // 
            numericUpDownPoints.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            numericUpDownPoints.Location = new System.Drawing.Point(552, 81);
            numericUpDownPoints.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownPoints.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDownPoints.Name = "numericUpDownPoints";
            numericUpDownPoints.Size = new System.Drawing.Size(60, 23);
            numericUpDownPoints.TabIndex = 12;
            numericUpDownPoints.Value = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDownPoints.ValueChanged += Points_ValueChanged;
            // 
            // buttonAutoCalcY
            // 
            buttonAutoCalcY.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            buttonAutoCalcY.Location = new System.Drawing.Point(488, 110);
            buttonAutoCalcY.Name = "buttonAutoCalcY";
            buttonAutoCalcY.Size = new System.Drawing.Size(124, 23);
            buttonAutoCalcY.TabIndex = 13;
            buttonAutoCalcY.Text = "Auto Calc (Y)";
            buttonAutoCalcY.UseVisualStyleBackColor = true;
            buttonAutoCalcY.Click += buttonAutoCalcY_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(624, 324);
            Controls.Add(buttonAutoCalcY);
            Controls.Add(numericUpDownPoints);
            Controls.Add(label5);
            Controls.Add(radioButtonFunc2);
            Controls.Add(radioButtonFunc1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericUpDownYmax);
            Controls.Add(numericUpDownYmin);
            Controls.Add(numericUpDownXmax);
            Controls.Add(numericUpDownXmin);
            Controls.Add(renderControl1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Main Form";
            ((System.ComponentModel.ISupportInitialize)numericUpDownXmin).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownXmax).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownYmin).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownYmax).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPoints).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RenderControl renderControl1;
        private System.Windows.Forms.NumericUpDown numericUpDownXmin;
        private System.Windows.Forms.NumericUpDown numericUpDownXmax;
        private System.Windows.Forms.NumericUpDown numericUpDownYmin;
        private System.Windows.Forms.NumericUpDown numericUpDownYmax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButtonFunc1;
        private System.Windows.Forms.RadioButton radioButtonFunc2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownPoints;
        private System.Windows.Forms.Button buttonAutoCalcY;
    }
}

