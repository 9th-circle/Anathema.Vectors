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
    public partial class SimpleBeziers2DDemoPanel : UserControl
    {
        public SimpleBeziers2DDemoPanel()
        {
            InitializeComponent();
        }
        bool leftDown = false;
        bool rightDown = false;

        fvec2 controlA = null;
        fvec2 controlB = null;
        private void SimpleBeziers2DDemoPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(controlA == null)
                controlA = new fvec2(Width / 2, 0);
            if (controlB == null)
                controlB = new fvec2(Width / 2, Height);
            if(leftDown)
                controlA = new fvec2(e.X, e.Y);
            if (rightDown)
                controlB = new fvec2(e.X, e.Y);
            using (Bitmap b = new Bitmap(Width, Height))
            {
                using (Graphics g = Graphics.FromImage(b))
                {
                    g.Clear(Color.DarkGray);

                    fvec2 start = new fvec2(0, 0);
                    fvec2 end = new fvec2(Width, Height);

                    for (int x = 0; x < Width-1; x++)
                    {
                        float f = x / (float)Width;
                        float f2 = (x+1) / (float)Width;
                        fvec2 ap = start.cubicBezierInterpolateTo(controlA, controlB, end, f);
                        fvec2 bp = start.cubicBezierInterpolateTo(controlA, controlB, end, f2);

                        g.DrawLine(Pens.Azure, ap.x, ap.y, bp.x, bp.y);
                    }

                    using (Graphics g2 = Graphics.FromHwnd(Handle))
                        g2.DrawImage(b, 0, 0);
                }
            }
        }

        private void SimpleBeziers2DDemoPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                leftDown = true;
            if (e.Button == MouseButtons.Right)
                rightDown = true;
        }

        private void SimpleBeziers2DDemoPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                leftDown = false;
            if (e.Button == MouseButtons.Right)
                rightDown = false;
        }

        private void SimpleBeziers2DDemoPanel_MouseLeave(object sender, EventArgs e)
        {
            leftDown = false;
            rightDown = false;
        }
    }
}
