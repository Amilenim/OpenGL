using OpenGL_Lab_2.Enum;

namespace OpenGL_Lab_2
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
            horizontalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            verticalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            fillViewRadioButton = new System.Windows.Forms.RadioButton();
            lineViewRadioButton = new System.Windows.Forms.RadioButton();
            pointViewRadioButton = new System.Windows.Forms.RadioButton();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            renderControl1 = new RenderControl();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)horizontalNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)verticalNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // horizontalNumericUpDown
            // 
            horizontalNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            horizontalNumericUpDown.Location = new System.Drawing.Point(582, 49);
            horizontalNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            horizontalNumericUpDown.Name = "horizontalNumericUpDown";
            horizontalNumericUpDown.Size = new System.Drawing.Size(46, 23);
            horizontalNumericUpDown.TabIndex = 3;
            horizontalNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            horizontalNumericUpDown.ValueChanged += OnSizeWindowChange;
            // 
            // verticalNumericUpDown
            // 
            verticalNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            verticalNumericUpDown.Location = new System.Drawing.Point(582, 78);
            verticalNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            verticalNumericUpDown.Name = "verticalNumericUpDown";
            verticalNumericUpDown.Size = new System.Drawing.Size(46, 23);
            verticalNumericUpDown.TabIndex = 4;
            verticalNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            verticalNumericUpDown.ValueChanged += OnSizeWindowChange;
            // 
            // fillViewRadioButton
            // 
            fillViewRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            fillViewRadioButton.AutoSize = true;
            fillViewRadioButton.Checked = true;
            fillViewRadioButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            fillViewRadioButton.Location = new System.Drawing.Point(502, 221);
            fillViewRadioButton.Name = "fillViewRadioButton";
            fillViewRadioButton.Size = new System.Drawing.Size(92, 25);
            fillViewRadioButton.TabIndex = 5;
            fillViewRadioButton.TabStop = true;
            fillViewRadioButton.Text = "Fill mode";
            fillViewRadioButton.UseVisualStyleBackColor = true;
            fillViewRadioButton.CheckedChanged += OnViewModeCheckedChanged;
            // 
            // lineViewRadioButton
            // 
            lineViewRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            lineViewRadioButton.AutoSize = true;
            lineViewRadioButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            lineViewRadioButton.Location = new System.Drawing.Point(502, 252);
            lineViewRadioButton.Name = "lineViewRadioButton";
            lineViewRadioButton.Size = new System.Drawing.Size(101, 25);
            lineViewRadioButton.TabIndex = 6;
            lineViewRadioButton.Text = "Line mode";
            lineViewRadioButton.UseVisualStyleBackColor = true;
            lineViewRadioButton.CheckedChanged += OnViewModeCheckedChanged;
            // 
            // pointViewRadioButton
            // 
            pointViewRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            pointViewRadioButton.AutoSize = true;
            pointViewRadioButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            pointViewRadioButton.Location = new System.Drawing.Point(502, 283);
            pointViewRadioButton.Name = "pointViewRadioButton";
            pointViewRadioButton.Size = new System.Drawing.Size(107, 25);
            pointViewRadioButton.TabIndex = 7;
            pointViewRadioButton.Text = "Point mode";
            pointViewRadioButton.UseVisualStyleBackColor = true;
            pointViewRadioButton.CheckedChanged += OnViewModeCheckedChanged;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            label3.Location = new System.Drawing.Point(492, 78);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(60, 21);
            label3.TabIndex = 9;
            label3.Text = "vertical";
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            label4.Location = new System.Drawing.Point(492, 49);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(80, 21);
            label4.TabIndex = 10;
            label4.Text = "horizontal";
            // 
            // renderControl1
            // 
            renderControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            renderControl1.BackColor = System.Drawing.Color.SlateGray;
            renderControl1.figureView = FigureMode.Fill;
            renderControl1.ForeColor = System.Drawing.Color.White;
            renderControl1.Horizontales = 1;
            renderControl1.Location = new System.Drawing.Point(12, 12);
            renderControl1.Name = "renderControl1";
            renderControl1.Size = new System.Drawing.Size(461, 310);
            renderControl1.TabIndex = 0;
            renderControl1.TextCodePage = 1251;
            renderControl1.Verticales = 1;
            renderControl1.MouseDown += OnClick;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            label1.Location = new System.Drawing.Point(523, 12);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(80, 21);
            label1.TabIndex = 11;
            label1.Text = "Tile count:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(640, 334);
            Controls.Add(label1);
            Controls.Add(renderControl1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pointViewRadioButton);
            Controls.Add(lineViewRadioButton);
            Controls.Add(fillViewRadioButton);
            Controls.Add(verticalNumericUpDown);
            Controls.Add(horizontalNumericUpDown);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Main Form";
            ((System.ComponentModel.ISupportInitialize)horizontalNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)verticalNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.NumericUpDown horizontalNumericUpDown;
        private System.Windows.Forms.NumericUpDown verticalNumericUpDown;
        private System.Windows.Forms.RadioButton fillViewRadioButton;
        private System.Windows.Forms.RadioButton lineViewRadioButton;
        private System.Windows.Forms.RadioButton pointViewRadioButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private RenderControl renderControl1;
        private System.Windows.Forms.Label label1;
    }
}

