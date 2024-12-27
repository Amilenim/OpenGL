using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;

namespace Task05
{
    public partial class RenderControl : OpenGL
    {
        Draw draw;

        public double Multi { get; set; } = 1.0;
        public bool Mode { get; set; } = true;
        public bool LightOn { get; set; } = true;
        public bool NotRotating { get; set; } = true;
        public bool NotPanning { get; set; } = true;
        public bool Fill {  get; set; } = true;
        public double LastRightMouseX { get; set; } = 0.0;
        public double LastRightMouseY { get; set; } = 0.0;
        public double LastLeftMouseX { get; set; } = 0.0;
        public double LastLeftMouseY { get; set; } = 0.0;
        public double CameraRadius { get; set; } = 10.0;
        public double CameraTheta { get; set; } = 0.0;
        public double CameraPhi { get; set; } = Math.PI / 2;
        public double AngleX { get; set; } = 0.0;
        public double AngleY { get; set; } = 0.0;
        public double CenterX { get; set; } = 0.0;
        public double CenterY { get; set; } = 0.0;
        public double CenterZ { get; set; } = 0.0;
        public double PanOffsetX { get; set; } = 0.0;
        public double PanOffsetY { get; set; } = 0.0;
        public double PanOffsetZ { get; set; } = 0.0;
        private uint coordinatesDisplayList;
        private uint gridDisplayList;
        private uint sphereDisplayList;
        private uint coneDisplayList;
        private uint discDisplayList;
        public RenderControl()
        {
            InitializeComponent();
        }
        private void OnRender(object sender, EventArgs e)
        {
            glClearColor(0.41f, 0.38f, 0.36f, 1.0f);
            glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);
            glEnable(GL_DEPTH_TEST);

            glViewport(0, 0, Width, Height);

            glMatrixMode(GL_PROJECTION);
            glLoadIdentity();
            double size = 20;
            double aspect = (double)Width / Height;
            if (Mode)
            {
                gluPerspective(45.0, aspect, 0.1, 100.0);
            }
            else
            {
                glOrtho(-size * Multi, size * Multi, -size * Multi, size * Multi, -size * 2.5 * Multi, size * 2.5 * Multi);
            }

            glMatrixMode(GL_MODELVIEW);
            glLoadIdentity();
            glTranslated(PanOffsetX, PanOffsetY, 0.0);

            if (Mode) 
            {
                double cameraX = CameraRadius * Math.Sin(CameraPhi) * Math.Cos(CameraTheta);
                double cameraY = CameraRadius * Math.Cos(CameraPhi);
                double cameraZ = CameraRadius * Math.Sin(CameraPhi) * Math.Sin(CameraTheta);

                gluLookAt(
                    Multi * cameraX, Multi * cameraY, Multi * cameraZ,
                    CenterX, CenterY, CenterZ,
                    0.0, 1.0, 0.0
                );
            }
            else
            {
                glRotatef((float)AngleY, 1.0f, 0.0f, 0.0f);
                glRotatef((float)AngleX, 0.0f, 1.0f, 0.0f);
            }
            glCallList(coordinatesDisplayList);
            if (LightOn)
                SetupLighting();
            else
            {
                glDisable(GL_LIGHTING);
                glDisable(GL_LIGHT0);
                glDisable(GL_COLOR_MATERIAL);
            }
            
            glCallList(gridDisplayList);
            double scale = CameraRadius;
            float lineWidth = Math.Clamp((float)(1.0 / scale), 0.1f, 5.0f);
            glLineWidth(lineWidth);
            draw.DrawSphere(-4.0, -2.5, 4.5, 3.0, Fill);
            draw.DrawCone(-4.5, +2.5, +2.5, 2.5, 0.5, 2.0, Fill);
            draw.DrawDisc(+3.5, -1.0, +3.0, 2.0, 0.0, Fill);
        }

        private void SetupLighting()
        {
            glEnable(GL_LIGHTING);
            glEnable(GL_LIGHT0);

            float[] lightPosition = { 5.0f, 5.0f, 5.0f, 1.0f };
            glLightfv(GL_LIGHT0, GL_POSITION, lightPosition);

            float[] lightAmbient = { 0.2f, 0.2f, 0.2f, 1.0f };
            float[] lightDiffuse = { 0.8f, 0.8f, 0.8f, 1.0f };
            float[] lightSpecular = { 1.0f, 1.0f, 1.0f, 1.0f };

            glLightfv(GL_LIGHT0, GL_AMBIENT, lightAmbient);
            glLightfv(GL_LIGHT0, GL_DIFFUSE, lightDiffuse);
            glLightfv(GL_LIGHT0, GL_SPECULAR, lightSpecular);

            glEnable(GL_COLOR_MATERIAL);
            glColorMaterial(GL_FRONT, GL_AMBIENT_AND_DIFFUSE);

            float[] materialSpecular = { 1.0f, 1.0f, 1.0f, 1.0f };
            float materialShininess = 50.0f;

            glMaterialfv(GL_FRONT, GL_SPECULAR, materialSpecular);
            glMaterialf(GL_FRONT, GL_SHININESS, materialShininess);
        }

        private void InitializeDisplayLists()
        {
            coordinatesDisplayList = glGenLists(1);
            glNewList(coordinatesDisplayList, GL_COMPILE);
            draw.DrawCoordinatesLines(CenterX, CenterY, CenterZ);
            glEndList();

            gridDisplayList = glGenLists(1);
            glNewList(gridDisplayList, GL_COMPILE);
            draw.DrawGrid(10);
            glEndList();

            sphereDisplayList = glGenLists(1);
            glNewList(sphereDisplayList, GL_COMPILE);
            draw.DrawSphere(-4.0, -2.5, 4.5, 3.0, Fill);
            glEndList();

            coneDisplayList = glGenLists(1);
            glNewList(coneDisplayList, GL_COMPILE);
            draw.DrawCone(-4.5, +2.5, +2.5, 2.5, 0.5, 2.0, Fill);
            glEndList();

            discDisplayList = glGenLists(1);
            glNewList(discDisplayList, GL_COMPILE);
            draw.DrawDisc(+3.5, -1.0, +3.0, 2.0, 0.0, Fill);
            glEndList();
        }
        private void DeleteDisplayLists()
        {
            glDeleteLists(coordinatesDisplayList, 1);
            glDeleteLists(gridDisplayList, 1);
            glDeleteLists(sphereDisplayList, 1);
            glDeleteLists(coneDisplayList, 1);
            glDeleteLists(discDisplayList, 1);
        }

        private void OnCreate(object sender, EventArgs e)
        {
            draw = new Draw();
            draw.Print = DrawText;

            InitializeDisplayLists();
        }

        private void OnDelete(object sender, EventArgs e)
        {
            DeleteDisplayLists();
        }
    }
}

