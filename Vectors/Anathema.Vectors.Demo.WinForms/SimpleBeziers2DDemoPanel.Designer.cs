namespace Anathema.Vectors.Demo.WinForms
{
    partial class SimpleBeziers2DDemoPanel
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
            this.SuspendLayout();
            // 
            // SimpleBeziers2DDemoPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "SimpleBeziers2DDemoPanel";
            this.Size = new System.Drawing.Size(609, 557);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SimpleBeziers2DDemoPanel_MouseDown);
            this.MouseLeave += new System.EventHandler(this.SimpleBeziers2DDemoPanel_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SimpleBeziers2DDemoPanel_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SimpleBeziers2DDemoPanel_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
