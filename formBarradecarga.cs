using System;
using AxWMPLib;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Pokemon
{
    public partial class formBarradecarga : Form
    {
        private bool teclaPresionada = false;
        private bool exitform = false;

        public formBarradecarga()
        {
            InitializeComponent();
            string ruta = Path.Combine(Application.StartupPath, "videos\\barradecarga.mp4");
            videoCarga.URL = ruta;
            videoCarga.settings.autoStart = true;
            videoCarga.uiMode = "none";
        }

        private void videoCarga_PlayStateChange(object sender, _WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == (int)WMPLib.WMPPlayState.wmppsMediaEnded && !teclaPresionada)
            {
                exitform = true;
                videoCarga.settings.mute = true;
                formBatalla FB = new formBatalla();
                FB.Visible = true;
                this.Close();
            }
        }

        private void formBarradecarga_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!exitform)
            {
                Application.Exit();
            }
        }
    }
}
