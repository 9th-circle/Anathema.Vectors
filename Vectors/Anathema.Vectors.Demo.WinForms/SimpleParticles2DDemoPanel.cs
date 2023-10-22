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
    public partial class SimpleParticles2DDemoPanel : UserControl
    {
        public SimpleParticles2DDemoPanel()
        {
            InitializeComponent();
        }

        class Particle
        {
            public vec2 pos = new vec2();
            public vec2 momentum = new vec2();

            public List<vec2> trail = new List<vec2>();
            public vec3 colour = new vec3();

            public int life = 100;
        }

        Graphics displayGraphics;
        Bitmap backBuffer = null;
        Graphics renderGraphics;

        int newParticleTimer = 0;
        List<Particle> particles = new List<Particle>();

        private void renderTimer_Tick(object sender, EventArgs e)
        {
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


            renderGraphics.Clear(Color.Black);

            Random r = new Random();

            if (newParticleTimer <= 0)
            {
                Particle p = new Particle();

                var point = this.PointToClient(Cursor.Position);

                p.pos = new vec2(point.X, point.Y);
                p.momentum = new vec2(r.Next(10)-5, r.Next(10) - 5);
                p.colour = new vec3((float)r.NextDouble(), (float)r.NextDouble(), (float)r.NextDouble());

                particles.Add(p);
                newParticleTimer = 2;
            }
            else
                newParticleTimer--;

            List<Particle> toRemove = new List<Particle>();

            foreach (var p in particles)
            {
                p.trail.Add(p.pos);
                p.pos += p.momentum;
                p.momentum.y += 0.25f;
                while(p.trail.Count > 20)
                    p.trail.RemoveAt(0);
                p.life--;
                if (p.life <= 0)
                {
                    toRemove.Add(p);
                    continue;
                }

                if (p.pos.y >= this.Height && p.momentum.y > 0)
                    p.momentum.y = -p.momentum.y * 0.75f;

                for (int i = 0; i < p.trail.Count-1; i++)
                {
                    vec3 c = p.colour * (i / 20.0f) * (p.life / 100.0f);

                    renderGraphics.DrawLine(new Pen(new SolidBrush(Color.FromArgb((byte)(c.r * 255), (byte)(c.g * 255), (byte)(c.b * 255))),3),
                        p.trail[i].x, p.trail[i].y, p.trail[i + 1].x, p.trail[i + 1].y);
                }
            }
            foreach (var p in toRemove)
                particles.Remove(p);

            displayGraphics.DrawImage(backBuffer, 0, 0);
        }

        private void SimpleParticles2DDemoPanel_Resize(object sender, EventArgs e)
        {

            displayGraphics = Graphics.FromHwnd(this.Handle);
        }

        private void SimpleParticles2DDemoPanel_ParentChanged(object sender, EventArgs e)
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
