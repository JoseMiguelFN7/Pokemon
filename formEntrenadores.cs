using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Pokemon
{
    public partial class formEntrenadores : Form
    {
        private cola colaEntrenadores = new cola();
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
        }

        private bool ValidarNombre(string nombre)
        {
            return Regex.IsMatch(nombre, @"^[a-zA-Z]+$");
        }

        private void botonconfirmar_Click(object sender, EventArgs e)
        {            
            String Entrenador1 = textBoxnombre1.Text;
            String Entrenador2 = textBoxnombre2.Text;

            if (string.IsNullOrWhiteSpace(Entrenador1)) 
            {
                MessageBox.Show("¡Ingrese un nombre valido para entrenador 1!");
                return;
            }

            if (string.IsNullOrWhiteSpace(Entrenador2))
            {
                MessageBox.Show("¡Ingrese un nombre valido para entrenador 2!");
                return;
            }

            if (!ValidarNombre(Entrenador1) || !ValidarNombre(Entrenador2))
            {
                MessageBox.Show("Por favor ingrese un nombre válido (solo letras).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            jugador E1 = new jugador(1, Entrenador1, 0, 0, 0);
            jugador E2 = new jugador(2, Entrenador2, 0, 0, 0);

            colaEntrenadores.agregarJugadorEnCola(E1);
            colaEntrenadores.agregarJugadorEnCola(E2);

            formBatalla batallas = new formBatalla();
            batallas.Visible = true;
            this.Visible = false;
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
            formMenuPrincipal FMP = new formMenuPrincipal();
            FMP.Visible = true;
            this.Close();
        }
    }
}