﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Anathema.Vectors.Core;

namespace Anathema.Vectors.Demo.WinForms
{
    public partial class SimpleSpaceship2DDemoPanel : UserControl
    {
        Graphics displayGraphics;
        Bitmap backBuffer = null;
        Graphics renderGraphics;

        public SimpleSpaceship2DDemoPanel()
        {
            InitializeComponent();

        }

        vec2 position = null;
        vec2 momentum = new vec2();
        bool leftKeyDown = false;
        bool rightKeyDown = false;
        bool forwardKeyDown = false;
        float direction = 0;

        List<vec3> stars = new List<vec3>();

        float modulo(float input, float divisor)
        {
            if (divisor == 0)
                throw new DivideByZeroException();
            while (input > divisor)
                input -= divisor;
            while(input < 0)
                input += divisor;
            return input;
        }
        private void renderTimer_Tick(object sender, EventArgs e)
        {
            if (position == null)
                return;

            if (backBuffer == null)
            {
                backBuffer = new Bitmap(Width, Height);
                renderGraphics = Graphics.FromImage(backBuffer);
            }
            if (backBuffer.Width != Width || backBuffer.Height != Height)
            {
                backBuffer.Dispose();
                backBuffer = new Bitmap(Width, Height);
                renderGraphics.Dispose();
                renderGraphics = Graphics.FromImage(backBuffer);
            }


            position += momentum;
            if (leftKeyDown)    direction -= 3;
            if (rightKeyDown)   direction += 3;
            if (forwardKeyDown) momentum += vec2.fromAngleDegreesAndLength(direction, 1);

            renderGraphics.Clear(Color.Black);

            foreach (vec3 star in stars)
                renderGraphics.FillEllipse(Brushes.Gray, modulo((star.x - position.x) / star.z, Width), modulo((star.y - position.y) / star.z, Height), 2, 2);
            
            vec2 centerOfShip = new vec2(Width/2, Height/2);
            vec2 forward = centerOfShip + vec2.fromAngleDegreesAndLength(direction, 20);
            vec2 left = centerOfShip + vec2.fromAngleDegreesAndLength(direction - 120, 10);
            vec2 right = centerOfShip + vec2.fromAngleDegreesAndLength(direction + 120, 10);
            renderGraphics.DrawLine(Pens.Blue, forward.x, forward.y, right.x, right.y);
            renderGraphics.DrawLine(Pens.Blue, right.x, right.y, left.x, left.y);
            renderGraphics.DrawLine(Pens.Blue, left.x, left.y, forward.x, forward.y);


            displayGraphics.DrawImage(backBuffer, 0, 0);
        }

        private void SimpleSpaceship2DDemoPanel_SizeChanged(object sender, EventArgs e)
        {
            if (position == null)
                position = new vec2(Width / 2, Height / 2);
            displayGraphics = Graphics.FromHwnd(this.Handle);

            Random r = new Random();

            for (int i = 0; i < 100; i++)
            {
                stars.Add(new vec3((float)r.NextDouble() * Width * 2.0f, (float)r.NextDouble() * Height * 2.0f, ((float)r.NextDouble() * 0.5f) + 1.0f));
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((keyData == Keys.Right) || (keyData == Keys.Left) ||
                (keyData == Keys.Up))
            {
                if (keyData == Keys.Left)
                    leftKeyDown = true;
                if (keyData == Keys.Right)
                    rightKeyDown = true;
                if (keyData == Keys.Up)
                    forwardKeyDown = true;
                return true;
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }
        private void SimpleSpaceship2DDemoPanel_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void SimpleSpaceship2DDemoPanel_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                leftKeyDown = false;
            if (e.KeyCode == Keys.Right)
                rightKeyDown = false;
            if (e.KeyCode == Keys.Up)
                forwardKeyDown = false;
        }

        private void SimpleSpaceship2DDemoPanel_ParentChanged(object sender, EventArgs e)
        {
            if (this.Parent == null)
            {
                renderTimer.Enabled = false;
                renderGraphics.Dispose();
                backBuffer.Dispose();
                displayGraphics.Dispose();
            }
        }
    }
}
