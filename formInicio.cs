using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon
{
    public partial class formInicio : Form
    {
        public static tipo[] arrTipos = new tipo[18];
        public static pokemon[] arrPKM = new pokemon[151];
        public static objeto[] arrObj = new objeto[9];
        public static lista movimientos = new lista();
        public static lista jugadores = new lista();
        public static int idJugador = 1;

        public formInicio()
        {
            leerJugadores();
            leerTipos();
            leerMovimientos();
            leerPokemon();
            llenarArrObj();
            InitializeComponent();
            string ruta = Path.Combine(Application.StartupPath, "videos\\intro.mp4");
            videoIntro.URL = ruta;
            videoIntro.settings.autoStart = true;
            videoIntro.uiMode = "none";
        }

        public void leerTipos()
        {
            string ruta = Path.Combine(Application.StartupPath, "Archivostxt\\Tipos.txt");
            string texto = archivo.leerArchivo(ruta);

            string[] stringTipos = texto.Split('\n');

            int i = 0;
            foreach (String t in stringTipos)
            {
                string[] datosTipos = t.Split(',');
                tipo tNuevo = new tipo(datosTipos[0], datosTipos[1], datosTipos[2], datosTipos[3], datosTipos[4]);
                arrTipos[i++] = tNuevo;
            }
        }

        public void leerPokemon()
        {
            string ruta = Path.Combine(Application.StartupPath, "Archivostxt\\PKM.txt");
            string texto = archivo.leerArchivo(ruta);

            string[] stringPKM = texto.Split('\n');

            int i = 0;
            foreach (String p in stringPKM)
            {
                string[] datosPKM = p.Split(',');
                pokemon PKMNuevo = new pokemon(int.Parse(datosPKM[0]), datosPKM[1], 50, datosPKM[2], int.Parse(datosPKM[3]), int.Parse(datosPKM[4]), int.Parse(datosPKM[5]), int.Parse(datosPKM[6]), int.Parse(datosPKM[7]), int.Parse(datosPKM[8]), datosPKM[9]);
                arrPKM[i++] = PKMNuevo;
            }
        }
        
        public void llenarArrObj()
        {
            arrObj[0] = new pocion();
            arrObj[1] = new superPocion();
            arrObj[2] = new hiperPocion();
            arrObj[3] = new antiParalisis();
            arrObj[4] = new antidoto();
            arrObj[5] = new despertar();
            arrObj[6] = new curaTotal();
            arrObj[7] = new maxPocion();
            arrObj[8] = new precisionX();
        }

        public void leerMovimientos()
        {
            string ruta = Path.Combine(Application.StartupPath, "Archivostxt\\Movimientos.txt");
            string texto = archivo.leerArchivo(ruta);

            string[] stringMovs = texto.Split('\n');

            foreach (string m in stringMovs)
            {
                string[] datosMov = m.Split('/');
                movimientos.agregarMovimientoAlFinal(new movimiento(int.Parse(datosMov[0]), datosMov[1], arrTipos[tipo.determinarTipo(datosMov[2])], int.Parse(datosMov[3]), datosMov[4], int.Parse(datosMov[5]), int.Parse(datosMov[6]), int.Parse(datosMov[7]), int.Parse(datosMov[8]), datosMov[9]));
            }
        }

        public void leerJugadores()
        {
            string ruta = Path.Combine(Application.StartupPath, "Archivostxt\\Jugadores.txt");
            string texto = archivo.leerArchivo(ruta);

            if (!string.IsNullOrEmpty(texto))
            {
                string[] stringJug = texto.Split('\n');

                foreach (string j in stringJug)
                {
                    string[] datosJug = j.Split('/');
                    jugadores.agregarJugadorAlFinal(new jugador(int.Parse(datosJug[0]), datosJug[1], int.Parse(datosJug[2]), int.Parse(datosJug[3]), int.Parse(datosJug[4])));
                    idJugador++;
                }
            }
        }

        private bool teclaPresionada = false;

        private void videoIntro_KeyDownEvent(object sender, _WMPOCXEvents_KeyDownEvent e)
        {
            teclaPresionada = true;
            formMenuPrincipal formMenu = new formMenuPrincipal();
            formMenu.Visible = true;
            this.Hide();
            videoIntro.settings.mute = true;
        }

        private void videoIntro_PlayStateChange_1(object sender, _WMPOCXEvents_PlayStateChangeEvent e)
        {

            if (e.newState == (int)WMPLib.WMPPlayState.wmppsMediaEnded && !teclaPresionada)
            {
                formMenuPrincipal formmenu = new formMenuPrincipal();
                formmenu.Visible = true;
                this.Hide();
                videoIntro.settings.mute = true;
            }
        }

        private void videoIntro_MouseDownEvent(object sender, _WMPOCXEvents_MouseDownEvent e)
        {
            teclaPresionada = true;
            formMenuPrincipal formMenu = new formMenuPrincipal();
            formMenu.Visible = true;
            this.Hide();
            videoIntro.settings.mute = true;
        }
        public static void reproducir(int i)
        {
            string ruta;
            switch (i)
            {
                case 0:
                    ruta = Path.Combine(Application.StartupPath, "audio\\MainTheme.wav");
                    break;
                case 1:
                    ruta = Path.Combine(Application.StartupPath, "audio\\BattleTheme.wav");
                    break;
                default:
                    ruta = string.Empty;
                    break;
            }

            SoundPlayer bgMusic = new SoundPlayer(ruta);
            bgMusic.PlayLooping();
        }
    }
}