namespace Pokemon
{
    partial class formBarradecarga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formBarradecarga));
            this.videoCarga = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.videoCarga)).BeginInit();
            this.SuspendLayout();
            // 
            // videoCarga
            // 
            this.videoCarga.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoCarga.Enabled = true;
            this.videoCarga.Location = new System.Drawing.Point(0, 0);
            this.videoCarga.Name = "videoCarga";
            this.videoCarga.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("videoCarga.OcxState")));
            this.videoCarga.Size = new System.Drawing.Size(862, 453);
            this.videoCarga.TabIndex = 0;
            this.videoCarga.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.videoCarga_PlayStateChange);
            // 
            // formBarradecarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 453);
            this.Controls.Add(this.videoCarga);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "formBarradecarga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barra de carga";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formBarradecarga_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.videoCarga)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer videoCarga;
    }
}