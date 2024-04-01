using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Pokemon
{
    public partial class formEntrenadores : Form
    {
        public static formMenuPrincipal menuPrincipal;
        public static cola colaEntrenadores = new cola();
        bool exitForm = false;

        public formEntrenadores()
        {
            InitializeComponent();
            pictureentrenador1.Parent = fondoprincipalent;
            pictureentrenadora2.Parent = fondoprincipalent;
            picturepokemon.Parent = fondoprincipalent;
            picturepok1.Parent = fondoprincipalent;
            labelclub.Parent = fondoprincipalent;
            labelENT1.Parent = fondoprincipalent;
            labelENT2.Parent = fondoprincipalent;
            groupBoxerror.Visible = false;
        }

        private bool ValidarNombre(string nombre)
        {
            return Regex.IsMatch(nombre, @"^[a-zA-Z]+$");
        }

        private void botonconfirmar_Click(object sender, EventArgs e)
        {            
            string Entrenador1 = textBoxnombre1.Text;
            string Entrenador2 = textBoxnombre2.Text;

            if (string.IsNullOrWhiteSpace(Entrenador1)) 
            {
                groupBoxerror.Visible = true;
                return;
            }

            if (string.IsNullOrWhiteSpace(Entrenador2))
            {
                groupBoxerror.Visible = true;
                return;
            }

            if (!ValidarNombre(Entrenador1) || !ValidarNombre(Entrenador2))
            {
                groupBoxerror.Visible = true;
                return;
            }

            jugador E1 = new jugador(1, Entrenador1, 0, 0, 0);
            jugador E2 = new jugador(2, Entrenador2, 0, 0, 0);

            colaEntrenadores.agregarJugadorEnCola(E1);
            colaEntrenadores.agregarJugadorEnCola(E2);

            exitForm = true;
            FormSeleccionarEquipo.torneo = false;
            FormSeleccionarEquipo FSE = new FormSeleccionarEquipo();
            FSE.Visible = true;
            this.Close();
        }

        private void botonsalirerror_Click(object sender, EventArgs e)
        {
            groupBoxerror.Visible = false;
        }

        private void formEntrenadores_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!exitForm)
            {
                Application.Exit();
            }
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            exitForm = true;
            menuPrincipal.Show();
            this.Close();
        }
    }
}