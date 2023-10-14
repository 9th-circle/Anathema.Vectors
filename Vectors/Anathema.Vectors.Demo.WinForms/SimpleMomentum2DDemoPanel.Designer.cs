namespace Anathema.Vectors.Demo.WinForms
{
    partial class SimpleMomentum2DDemoPanel
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
            // SimpleMomentum2DDemoPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "SimpleMomentum2DDemoPanel";
            this.Size = new System.Drawing.Size(598, 392);
            this.SizeChanged += new System.EventHandler(this.SimpleMomentum2DDemoPanel_SizeChanged);
            this.ParentChanged += new System.EventHandler(this.SimpleMomentum2DDemoPanel_ParentChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer renderTimer;
    }
}
