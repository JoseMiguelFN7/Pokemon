using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Drawing;

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
            picturepokemon.Parent = fondoprincipalent;
            labelclub.Parent = fondoprincipalent;
            labelENT1.Parent = fondoprincipalent;
            labelENT2.Parent = fondoprincipalent;
            checkBoxEntrenador1.Parent = fondoprincipalent;
            checkBoxEntrenador2.Parent = fondoprincipalent;
            groupBoxerror.Visible = false;

            formInicio.jugadores.llenarComboBox(comboBoxEntrenador1);
            formInicio.jugadores.llenarComboBox(comboBoxEntrenador2);
        }

        private bool ValidarNombre(string nombre)
        {
            return Regex.IsMatch(nombre, @"^[a-zA-Z]+$");
        }

        private bool repetido(string s1, string s2)
        {
            if (s1.Equals(s2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void botonconfirmar_Click(object sender, EventArgs e)
        {
            texto1.Text = "Ingrese caracteres válidos.\r\n(Sólo letras)";
            string Entrenador1;
            string Entrenador2;

            if (checkBoxEntrenador1.Checked)
            {
                Entrenador1 = comboBoxEntrenador1.Text;
            }
            else
            {
                Entrenador1 = textBoxnombre1.Text;
            }

            if (checkBoxEntrenador2.Checked)
            {
                Entrenador2 = comboBoxEntrenador2.Text;
            }
            else
            {
                Entrenador2 = textBoxnombre2.Text;
            }

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

                if (!ValidarNombre(Entrenador1))
                {
                    if (checkBoxEntrenador1.Checked)
                    {
                        comboBoxEntrenador1.ForeColor = Color.Red;
                    }
                    else
                    {
                        textBoxnombre1.ForeColor = Color.Red;
                    }
                }
                else
                {
                    comboBoxEntrenador1.ForeColor = Color.Black;
                    textBoxnombre1.ForeColor = Color.Black;
                }

                if (!ValidarNombre(Entrenador2))
                {
                    if (checkBoxEntrenador2.Checked)
                    {
                        comboBoxEntrenador2.ForeColor = Color.Red;
                    }
                    else
                    {
                        textBoxnombre2.ForeColor = Color.Red;
                    }
                }
                else
                {
                    comboBoxEntrenador2.ForeColor = Color.Black;
                    textBoxnombre2.ForeColor = Color.Black;
                }

                return;
            }

            if (repetido(Entrenador1, Entrenador2))
            {
                groupBoxerror.Visible = true;
                texto1.Text = "No se permiten nombres\r\nrepetidos";

                return;
            }

            if ((formInicio.jugadores.existeJNombre(Entrenador1) && !checkBoxEntrenador1.Checked) || (formInicio.jugadores.existeJNombre(Entrenador2) && !checkBoxEntrenador2.Checked))
            {
                groupBoxerror.Visible = true;
                texto1.Text = "Ya hay un perfil\r\ncon este nombre.";

                if (formInicio.jugadores.existeJNombre(Entrenador1))
                {
                    if (checkBoxEntrenador1.Checked)
                    {
                        comboBoxEntrenador1.ForeColor = Color.Red;
                    }
                    else
                    {
                        textBoxnombre1.ForeColor = Color.Red;
                    }
                }
                else
                {
                    comboBoxEntrenador1.ForeColor = Color.Black;
                    textBoxnombre1.ForeColor = Color.Black;
                }

                if (formInicio.jugadores.existeJNombre(Entrenador2))
                {
                    groupBoxerror.Visible = true;

                    if (checkBoxEntrenador2.Checked)
                    {
                        comboBoxEntrenador2.ForeColor = Color.Red;
                    }
                    else
                    {
                        textBoxnombre2.ForeColor = Color.Red;
                    }
                }
                else
                {
                    comboBoxEntrenador2.ForeColor = Color.Black;
                    textBoxnombre2.ForeColor = Color.Black;
                }

                return;
            }

            jugador E1;
            jugador E2;

            if (checkBoxEntrenador1.Checked)
            {
                E1 = formInicio.jugadores.buscarJugador(Entrenador1);
            }
            else
            {
                E1 = new jugador(formInicio.idJugador++, Entrenador1, 0, 0, 0);
            }

            if (checkBoxEntrenador2.Checked)
            {
                E2 = formInicio.jugadores.buscarJugador(Entrenador2);
            }
            else
            {
                E2 = new jugador(formInicio.idJugador++, Entrenador2, 0, 0, 0);
            }

            colaEntrenadores.agregarJugadorEnCola(E1);
            colaEntrenadores.agregarJugadorEnCola(E2);

            formInicio.jugadores.agregarColaALista(colaEntrenadores);

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

        private void checkBoxEntrenador1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEntrenador1.Checked)
            {
                comboBoxEntrenador1.Visible = true;
                textBoxnombre1.Visible = false;
            }
            else
            {
                comboBoxEntrenador1.Visible = false;
                textBoxnombre1.Visible = true;
            }
        }

        private void checkBoxEntrenador2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEntrenador2.Checked)
            {
                comboBoxEntrenador2.Visible = true;
                textBoxnombre2.Visible = false;
            }
            else
            {
                comboBoxEntrenador2.Visible = false;
                textBoxnombre2.Visible = true;
            }
        }
    }
}