
namespace Task05
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
            cbLight = new System.Windows.Forms.CheckBox();
            rdbtnPerspective = new System.Windows.Forms.RadioButton();
            rdbtnOrtho = new System.Windows.Forms.RadioButton();
            rdbtnFill = new System.Windows.Forms.RadioButton();
            rdbtnLine = new System.Windows.Forms.RadioButton();
            SuspendLayout();
            // 
            // renderControl1
            // 
            renderControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            renderControl1.AngleX = 0D;
            renderControl1.AngleY = 0D;
            renderControl1.BackColor = System.Drawing.Color.SlateGray;
            renderControl1.CameraPhi = 1.5707963267948966D;
            renderControl1.CameraRadius = 10D;
            renderControl1.CameraTheta = 0D;
            renderControl1.CenterX = 0D;
            renderControl1.CenterY = 0D;
            renderControl1.CenterZ = 0D;
            renderControl1.Fill = true;
            renderControl1.ForeColor = System.Drawing.Color.White;
            renderControl1.LastLeftMouseX = 0D;
            renderControl1.LastLeftMouseY = 0D;
            renderControl1.LastRightMouseX = 0D;
            renderControl1.LastRightMouseY = 0D;
            renderControl1.LightOn = true;
            renderControl1.Location = new System.Drawing.Point(12, 12);
            renderControl1.Mode = true;
            renderControl1.Multi = 1D;
            renderControl1.Name = "renderControl1";
            renderControl1.NotPanning = true;
            renderControl1.NotRotating = true;
            renderControl1.PanOffsetX = 0D;
            renderControl1.PanOffsetY = 0D;
            renderControl1.PanOffsetZ = 0D;
            renderControl1.Size = new System.Drawing.Size(480, 300);
            renderControl1.TabIndex = 0;
            renderControl1.TextCodePage = 1251;
            renderControl1.MouseDown += OnMouseDown;
            renderControl1.MouseMove += OnMouseMove;
            renderControl1.MouseUp += OnMouseUp;
            renderControl1.MouseWheel += OnWheel;
            // 
            // cbLight
            // 
            cbLight.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            cbLight.AutoSize = true;
            cbLight.Checked = true;
            cbLight.CheckState = System.Windows.Forms.CheckState.Checked;
            cbLight.Location = new System.Drawing.Point(504, 12);
            cbLight.Name = "cbLight";
            cbLight.Size = new System.Drawing.Size(53, 19);
            cbLight.TabIndex = 1;
            cbLight.Text = "Light";
            cbLight.UseVisualStyleBackColor = true;
            cbLight.CheckedChanged += OnChekedLight;
            // 
            // rdbtnPerspective
            // 
            rdbtnPerspective.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            rdbtnPerspective.AutoSize = true;
            rdbtnPerspective.Checked = true;
            rdbtnPerspective.Location = new System.Drawing.Point(504, 77);
            rdbtnPerspective.Name = "rdbtnPerspective";
            rdbtnPerspective.Size = new System.Drawing.Size(85, 19);
            rdbtnPerspective.TabIndex = 1;
            rdbtnPerspective.TabStop = true;
            rdbtnPerspective.Text = "Perspective";
            rdbtnPerspective.UseVisualStyleBackColor = true;
            rdbtnPerspective.CheckedChanged += OnCheckedPerspective;
            // 
            // rdbtnOrtho
            // 
            rdbtnOrtho.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            rdbtnOrtho.AutoSize = true;
            rdbtnOrtho.Location = new System.Drawing.Point(504, 52);
            rdbtnOrtho.Name = "rdbtnOrtho";
            rdbtnOrtho.Size = new System.Drawing.Size(56, 19);
            rdbtnOrtho.TabIndex = 0;
            rdbtnOrtho.Text = "Ortho";
            rdbtnOrtho.UseVisualStyleBackColor = true;
            rdbtnOrtho.CheckedChanged += OnCheckedOrtho;
            // 
            // rdbtnFill
            // 
            rdbtnFill.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            rdbtnFill.AutoSize = true;
            rdbtnFill.Checked = true;
            rdbtnFill.Location = new System.Drawing.Point(504, 124);
            rdbtnFill.Name = "rdbtnFill";
            rdbtnFill.Size = new System.Drawing.Size(40, 19);
            rdbtnFill.TabIndex = 0;
            rdbtnFill.TabStop = true;
            rdbtnFill.Text = "Fill";
            rdbtnFill.UseVisualStyleBackColor = true;
            rdbtnFill.CheckedChanged += OnCheckedFill;
            // 
            // rdbtnLine
            // 
            rdbtnLine.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            rdbtnLine.AutoSize = true;
            rdbtnLine.Location = new System.Drawing.Point(504, 149);
            rdbtnLine.Name = "rdbtnLine";
            rdbtnLine.Size = new System.Drawing.Size(47, 19);
            rdbtnLine.TabIndex = 1;
            rdbtnLine.Text = "Line";
            rdbtnLine.UseVisualStyleBackColor = true;
            rdbtnLine.CheckedChanged += OnCheckedLine;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(624, 324);
            Controls.Add(rdbtnOrtho);
            Controls.Add(rdbtnPerspective);
            Controls.Add(rdbtnLine);
            Controls.Add(rdbtnFill);
            Controls.Add(cbLight);
            Controls.Add(renderControl1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Main Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RenderControl renderControl1;
        private System.Windows.Forms.CheckBox cbLight;
        private System.Windows.Forms.RadioButton rdbtnPerspective;
        private System.Windows.Forms.RadioButton rdbtnOrtho;
        private System.Windows.Forms.RadioButton rdbtnFill;
        private System.Windows.Forms.RadioButton rdbtnLine;
    }
}

