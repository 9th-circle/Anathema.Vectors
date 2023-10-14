using System;
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
    public partial class SimpleMomentum2DDemoPanel : UserControl
    {
        Graphics displayGraphics;
        Bitmap backBuffer = null;
        Graphics renderGraphics;

        class Ball
        {
            public fvec2 position = new fvec2();
            public fvec2 inertia = new fvec2();
            public float size = 20.0f;
            public float brightness = 0.0f;
        }


        List<Ball> balls = new List<Ball>();

        public SimpleMomentum2DDemoPanel()
        {
            InitializeComponent();

            displayGraphics = Graphics.FromHwnd(this.Handle);

            Random r = new Random();
            for (int i = 0; i < 7; i++)
            {

                Ball b = new Ball() { position = new fvec2(r.Next(Width), r.Next(Height)),
                    inertia = new fvec2((float)r.NextDouble() - 0.5f, (float)r.NextDouble() - 0.5f) * 15.0f,
                    size = r.Next(30) + 10 };

                balls.Add(b);
            }
        }

        private void renderTimer_Tick(object sender, EventArgs e)
        {
            if (backBuffer == null)
            {
                backBuffer = new Bitmap(Width, Height);
                renderGraphics = Graphics.FromImage(backBuffer);
            }
            if(backBuffer.Width != Width || backBuffer.Height != Height)
            {
                backBuffer = new Bitmap(Width, Height);
                renderGraphics = Graphics.FromImage(backBuffer);
            }

            renderGraphics.Clear(Color.White);

            foreach (Ball b in balls)
            {
                if (b.position.x <= b.size && b.inertia.x < 0)
                {
                    b.brightness = 1.0f;
                    b.inertia.x *= -1;
                    b.position.x = b.size;
                }
                if (b.position.x >= Width - b.size && b.inertia.x > 0)
                {
                    b.brightness = 1.0f;
                    b.inertia.x *= -1;
                    b.position.x = Width-b.size;
                }
                if (b.position.y <= b.size && b.inertia.y < 0)
                {
                    b.brightness = 1.0f;
                    b.inertia.y *= -1;
                    b.position.y = b.size;
                }
                if (b.position.y >= Height - b.size && b.inertia.y > 0)
                {
                    b.brightness = 1.0f;
                    b.inertia.y *= -1;
                    b.position.y = Height - b.size;
                }

                if (b.brightness > 0)
                    b.brightness *= 0.95f;

                foreach (Ball b2 in balls)
                {
                    if (b != b2)
                    {
                        if ((b2.position - b.position).length < b.size + b2.size)
                        {
                            b.brightness = 1.0f;
                            b2.brightness = 1.0f;

                            //todo: calculate the actual correct collision angle
                            b.inertia *= -1;

                            float toPush = (b.size + b2.size) - (b2.position - b.position).length;
                            b.position -= (b2.position - b.position).normalised * toPush * 1.01f;
                            b2.position += (b2.position - b.position).normalised * toPush * 1.01f;
                        }
                    }
                }

                b.position += b.inertia;

                byte c = (byte)(b.brightness * 255);
                    renderGraphics.FillEllipse(new SolidBrush(Color.FromArgb(255,c/2,c/2,c)), b.position.x - b.size, b.position.y - b.size, b.size * 2, b.size * 2);

            }

            displayGraphics.DrawImage(backBuffer, 0, 0);
        }

        private void SimpleMomentum2DDemoPanel_SizeChanged(object sender, EventArgs e)
        {
            displayGraphics = Graphics.FromHwnd(this.Handle);
        }
    }
}
