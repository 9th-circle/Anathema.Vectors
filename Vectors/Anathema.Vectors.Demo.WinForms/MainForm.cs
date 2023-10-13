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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SimpleMomentum2DDemoPanel p = new SimpleMomentum2DDemoPanel();
            p.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(p);
        }
    }
}
