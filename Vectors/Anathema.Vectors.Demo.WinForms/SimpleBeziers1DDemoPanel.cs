using Anathema.Vectors.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Anathema.Vectors.Demo.WinForms
{
    public partial class SimpleBeziers1DDemoPanel : UserControl
    {
        public SimpleBeziers1DDemoPanel()
        {
            InitializeComponent();
        }

        private void SimpleBeziers1DDemoPanel_MouseMove(object sender, MouseEventArgs e)
        {
            float m = e.Y;
            using (Bitmap b = new Bitmap(Width, Height))
            {
                using (Graphics g = Graphics.FromImage(b))
                {
                    g.Clear(Color.DarkGray);

                    vec2 start = new vec2(0, 0);
                    vec2 end = new vec2(Width, Height);

                    for (int x = 0; x < Width - 1; x++)
                    {
                        float f = x / (float)Width;
                        float f2 = (x + 1) / (float)Width;
                        vec2 ap = new vec2(x, scalar.quadraticBezierInterpolate(0, m, Height,f));
                        vec2 bp = new vec2(x+1, scalar.quadraticBezierInterpolate(0, m, Height, f2));

                        g.DrawLine(Pens.Azure, ap.x, ap.y, bp.x, bp.y);
                    }

                    using (Graphics g2 = Graphics.FromHwnd(Handle))
                        g2.DrawImage(b, 0, 0);
                }
            }
        }
    }
}
