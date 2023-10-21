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
        }

        private void demoSelectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            contentPanel.Controls.Clear();
            if (demoSelectComboBox.SelectedIndex == 0) {
                SimpleMomentum2DDemoPanel p = new SimpleMomentum2DDemoPanel();
                p.Dock = DockStyle.Fill;
                contentPanel.Controls.Add(p);
            }
            if (demoSelectComboBox.SelectedIndex == 1)
            {
                SimpleParticles2DDemoPanel p = new SimpleParticles2DDemoPanel();
                p.Dock = DockStyle.Fill;
                contentPanel.Controls.Add(p);
            }
            if (demoSelectComboBox.SelectedIndex == 2)
            {
                SimpleSpaceship2DDemoPanel p = new SimpleSpaceship2DDemoPanel();
                p.Dock = DockStyle.Fill;
                contentPanel.Controls.Add(p);
            }
            if (demoSelectComboBox.SelectedIndex == 3)
            {
                SimpleBeziers2DDemoPanel p = new SimpleBeziers2DDemoPanel();
                p.Dock = DockStyle.Fill;
                contentPanel.Controls.Add(p);
            }
            if (demoSelectComboBox.SelectedIndex == 4)
            {
                SimpleBeziers1DDemoPanel p = new SimpleBeziers1DDemoPanel();
                p.Dock = DockStyle.Fill;
                contentPanel.Controls.Add(p);
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {

            demoSelectComboBox.SelectedIndex = 0;
        }
    }
}
