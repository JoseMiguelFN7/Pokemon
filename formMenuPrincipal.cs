using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon
{
    public partial class formMenuPrincipal : Form
    {
        public static formEntrenadores entrenadores;
        public static formElegirTorneo torneo;
        public static bool exitForm = false;

        public formMenuPrincipal()
        {
            formBatalla.ganador = null;

            actualizarArchivoJugadores();

            InitializeComponent();         
            titulo.Parent = fondoprincipal;                   
            salir.Parent = fondoprincipal;
            labpartida.Parent = fondoprincipal;
            pokemon.Parent = fondoprincipal;
            picpokemon.Parent = fondoprincipal;

            formInicio.reproducir(0);
        }

        public void actualizarArchivoJugadores()
        {
            string ruta = Path.Combine(Application.StartupPath, "Archivostxt\\Jugadores.txt");
            string texto = formInicio.jugadores.obtenerStringJugadores();
            archivo.escribirArchivo(texto, ruta); //Sobreescribe archivo
        }

        private void labelpartida_MouseEnter(object sender, EventArgs e)
        {
            labelpartida.ForeColor = Color.RoyalBlue;
        }

        private void labelpartida_MouseLeave(object sender, EventArgs e)
        {
            labelpartida.ForeColor = Color.Gold;
        }


        private void salir_MouseEnter(object sender, EventArgs e)
        {
            salir.ForeColor = Color.RoyalBlue;
        }

        private void salir_MouseLeave(object sender, EventArgs e)
        {
            salir.ForeColor = Color.Gold;
        }

        private void labpartida_MouseEnter(object sender, EventArgs e)
        {
            labpartida.ForeColor = Color.RoyalBlue;
        }

        private void labpartida_MouseLeave(object sender, EventArgs e)
        {
            labpartida.ForeColor = Color.Gold;
        }

        private void labpartida_Click(object sender, EventArgs e)
        {
            entrenadores = new formEntrenadores();
            formEntrenadores.menuPrincipal = this;
            entrenadores.Visible = true;
            this.Hide();
        }

        private void labeltorneo_MouseEnter(object sender, EventArgs e)
        {
            labeltorneo.ForeColor = Color.RoyalBlue;
        }

        private void labeltorneo_MouseLeave(object sender, EventArgs e)
        {
            labeltorneo.ForeColor = Color.Gold;
        }

        private void labeltorneo_Click(object sender, EventArgs e)
        {
            torneo = new formElegirTorneo();
            formElegirTorneo.menuPrincipal = this;
            torneo.Visible = true;
            this.Hide();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            exitForm = false;
            this.Close();
        }

        private void formMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!exitForm)
            {
                Application.Exit();
            }
        }
    }
}
