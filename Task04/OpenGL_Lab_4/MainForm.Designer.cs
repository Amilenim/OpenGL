
namespace OpenGL_Lab_4
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
            numericUpDownA = new System.Windows.Forms.NumericUpDown();
            numericUpDownB = new System.Windows.Forms.NumericUpDown();
            radioButton1 = new System.Windows.Forms.RadioButton();
            radioButton2 = new System.Windows.Forms.RadioButton();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownB).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // renderControl1
            // 
            renderControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            renderControl1.BackColor = System.Drawing.Color.White;
            renderControl1.ChosedFigure = false;
            renderControl1.CoefficientA = 1D;
            renderControl1.CoefficientB = 0.7D;
            renderControl1.FinishLineX = 0D;
            renderControl1.FinishLineY = 0D;
            renderControl1.ForeColor = System.Drawing.Color.White;
            renderControl1.Length = 1D;
            renderControl1.LineIsExist = false;
            renderControl1.Location = new System.Drawing.Point(0, 0);
            renderControl1.MouseIsUp = true;
            renderControl1.Name = "renderControl1";
            renderControl1.Size = new System.Drawing.Size(447, 324);
            renderControl1.StartLineX = 0D;
            renderControl1.StartLineY = 0D;
            renderControl1.TabIndex = 0;
            renderControl1.TextCodePage = 1251;
            renderControl1.MouseDown += OnMouseDown;
            renderControl1.MouseUp += OnMouseUp;
            // 
            // numericUpDownA
            // 
            numericUpDownA.DecimalPlaces = 1;
            numericUpDownA.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownA.Location = new System.Drawing.Point(11, 30);
            numericUpDownA.Name = "numericUpDownA";
            numericUpDownA.Size = new System.Drawing.Size(78, 23);
            numericUpDownA.TabIndex = 1;
            numericUpDownA.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownA.ValueChanged += OnValueChangedA;
            // 
            // numericUpDownB
            // 
            numericUpDownB.DecimalPlaces = 1;
            numericUpDownB.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownB.Location = new System.Drawing.Point(11, 59);
            numericUpDownB.Name = "numericUpDownB";
            numericUpDownB.Size = new System.Drawing.Size(78, 23);
            numericUpDownB.TabIndex = 2;
            numericUpDownB.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownB.ValueChanged += OnValueChangedB;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new System.Drawing.Point(11, 34);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new System.Drawing.Size(58, 19);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "Ellipse";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += OnCheckedChangedRb1;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new System.Drawing.Point(11, 59);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new System.Drawing.Size(80, 19);
            radioButton2.TabIndex = 4;
            radioButton2.Text = "Hyperbola";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += OnCheckedChangedRb2;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Location = new System.Drawing.Point(467, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(145, 95);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Figure";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(numericUpDownA);
            groupBox2.Controls.Add(numericUpDownB);
            groupBox2.Location = new System.Drawing.Point(467, 113);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(145, 95);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Parameters";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(95, 61);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(14, 15);
            label2.TabIndex = 4;
            label2.Text = "B";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(95, 32);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(15, 15);
            label1.TabIndex = 3;
            label1.Text = "A";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(624, 324);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(renderControl1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Main Form";
            ((System.ComponentModel.ISupportInitialize)numericUpDownA).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownB).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RenderControl renderControl1;
        private System.Windows.Forms.NumericUpDown numericUpDownA;
        private System.Windows.Forms.NumericUpDown numericUpDownB;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

