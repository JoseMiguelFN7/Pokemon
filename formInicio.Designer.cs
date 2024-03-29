namespace Pokemon
{
    partial class formInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formInicio));
            this.videoIntro = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.videoIntro)).BeginInit();
            this.SuspendLayout();
            // 
            // videoIntro
            // 
            this.videoIntro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoIntro.Enabled = true;
            this.videoIntro.Location = new System.Drawing.Point(0, 0);
            this.videoIntro.Name = "videoIntro";
            this.videoIntro.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("videoIntro.OcxState")));
            this.videoIntro.Size = new System.Drawing.Size(866, 450);
            this.videoIntro.TabIndex = 0;
            this.videoIntro.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.videoIntro_PlayStateChange_1);
            this.videoIntro.KeyDownEvent += new AxWMPLib._WMPOCXEvents_KeyDownEventHandler(this.videoIntro_KeyDownEvent);
            this.videoIntro.MouseDownEvent += new AxWMPLib._WMPOCXEvents_MouseDownEventHandler(this.videoIntro_MouseDownEvent);
            // 
            // formInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 450);
            this.Controls.Add(this.videoIntro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pokemon";
            ((System.ComponentModel.ISupportInitialize)(this.videoIntro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer videoIntro;
    }
}