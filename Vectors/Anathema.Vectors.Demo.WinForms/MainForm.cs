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
            if (demoSelectComboBox.SelectedIndex == 0) {
                contentPanel.Controls.Clear();
                SimpleMomentum2DDemoPanel p = new SimpleMomentum2DDemoPanel();
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
