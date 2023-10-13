
namespace Anathema.Vectors.Demo.WinForms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.demoSelectComboBox = new System.Windows.Forms.ComboBox();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // demoSelectComboBox
            // 
            this.demoSelectComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.demoSelectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.demoSelectComboBox.FormattingEnabled = true;
            this.demoSelectComboBox.Items.AddRange(new object[] {
            "Simple Momentum (2D)"});
            this.demoSelectComboBox.Location = new System.Drawing.Point(0, 0);
            this.demoSelectComboBox.Name = "demoSelectComboBox";
            this.demoSelectComboBox.Size = new System.Drawing.Size(800, 21);
            this.demoSelectComboBox.TabIndex = 0;
            // 
            // contentPanel
            // 
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 21);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(800, 429);
            this.contentPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.demoSelectComboBox);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "MainForm";
            this.Text = "Vector Demo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox demoSelectComboBox;
        private System.Windows.Forms.Panel contentPanel;
    }
}

