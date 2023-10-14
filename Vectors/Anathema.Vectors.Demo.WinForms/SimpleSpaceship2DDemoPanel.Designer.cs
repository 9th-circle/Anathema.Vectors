
namespace Anathema.Vectors.Demo.WinForms
{
    partial class SimpleSpaceship2DDemoPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.renderTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // renderTimer
            // 
            this.renderTimer.Enabled = true;
            this.renderTimer.Interval = 5;
            this.renderTimer.Tick += new System.EventHandler(this.renderTimer_Tick);
            // 
            // SimpleSpaceship2DDemoPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "SimpleSpaceship2DDemoPanel";
            this.Size = new System.Drawing.Size(453, 364);
            this.SizeChanged += new System.EventHandler(this.SimpleSpaceship2DDemoPanel_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SimpleSpaceship2DDemoPanel_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SimpleSpaceship2DDemoPanel_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer renderTimer;
    }
}
