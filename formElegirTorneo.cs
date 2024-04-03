using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon
{
    public partial class formElegirTorneo : Form
    {
        bool exitForm = false;
        public static lista listaJtorneo;
        public static formMenuPrincipal menuPrincipal;
        string jugador1;
        string jugador2;
        string jugador3;
        string jugador4;
        string jugador5;
        string jugador6;
        string jugador7;
        string jugador8;

        public formElegirTorneo()
        {
            listaJtorneo = new lista();
            InitializeComponent();
            torneo.Parent = fondoprincipalt;
            label1.Parent = fondoprincipalt;
            label2.Parent = fondoprincipalt;
            radio2jugadores.Parent = fondoprincipalt;
            radio4jugadores.Parent = fondoprincipalt;
            radio8jugadores.Parent = fondoprincipalt;
            groupBox2nombres.Visible = false; 
            botonconfirmar.Visible = false; 
            pictitulo.Visible = false;
            groupBoxerror.Visible = false;

            formInicio.jugadores.llenarComboBox(comboBoxEntrenador1);
            formInicio.jugadores.llenarComboBox(comboBoxEntrenador2);
        }

        //boton para confirmar  la cantidad de jugadores al torneo
        private void button1_Click(object sender, EventArgs e)
        {
            groupBox2nombres.Visible = true;

            if (radio2jugadores.Checked) 
            {
                pictitulo.Visible = true;
                botonconfirmar.Visible = true;
            }

            if (radio4jugadores.Checked)
            {
                textBoxnombre3.Visible = true;
                labelnombre3.Visible = true;
                checkBoxEntrenador3.Visible = true;
                if (checkBoxEntrenador3.Checked)
                {
                    comboBoxEntrenador3.Visible = true;
                }
                textBoxnombre4.Visible = true;
                labelnombre4.Visible = true;
                checkBoxEntrenador4.Visible = true;
                if (checkBoxEntrenador4.Checked)
                {
                    comboBoxEntrenador4.Visible = true;
                }

                botonconfirmar.Visible = true;
                pictitulo.Visible = true;

                formInicio.jugadores.llenarComboBox(comboBoxEntrenador3);
                formInicio.jugadores.llenarComboBox(comboBoxEntrenador4);
            }

            if (radio8jugadores.Checked)
            {
                textBoxnombre3.Visible = true;
                labelnombre3.Visible = true;
                checkBoxEntrenador3.Visible = true;
                if (checkBoxEntrenador3.Checked)
                {
                    comboBoxEntrenador3.Visible = true;
                }
                textBoxnombre4.Visible = true;
                labelnombre4.Visible = true;
                checkBoxEntrenador4.Visible = true;
                if (checkBoxEntrenador4.Checked)
                {
                    comboBoxEntrenador4.Visible = true;
                }
                textBoxnombre5.Visible = true;
                labelnombre5.Visible = true;
                checkBoxEntrenador5.Visible = true;
                if (checkBoxEntrenador5.Checked)
                {
                    comboBoxEntrenador5.Visible = true;
                }
                textBoxnombre6.Visible = true;
                labelnombre6.Visible = true;
                checkBoxEntrenador6.Visible = true;
                if (checkBoxEntrenador6.Checked)
                {
                    comboBoxEntrenador6.Visible = true;
                }
                textBoxnombre7.Visible = true;
                labelnombre7.Visible = true;
                checkBoxEntrenador7.Visible = true;
                if (checkBoxEntrenador7.Checked)
                {
                    comboBoxEntrenador7.Visible = true;
                }
                textBoxnombre8.Visible = true;
                labelnombre8.Visible = true;
                checkBoxEntrenador8.Visible = true;
                if (checkBoxEntrenador8.Checked)
                {
                    comboBoxEntrenador8.Visible = true;
                }

                botonconfirmar.Visible = true;
                pictitulo.Visible = true;

                formInicio.jugadores.llenarComboBox(comboBoxEntrenador3);
                formInicio.jugadores.llenarComboBox(comboBoxEntrenador4);
                formInicio.jugadores.llenarComboBox(comboBoxEntrenador5);
                formInicio.jugadores.llenarComboBox(comboBoxEntrenador6);
                formInicio.jugadores.llenarComboBox(comboBoxEntrenador7);
                formInicio.jugadores.llenarComboBox(comboBoxEntrenador8);
            }
            groupBoxerror.BringToFront();
        }

         //boton equis superior
        private void buttonsalir_Click(object sender, EventArgs e)        
        {
            groupBox2nombres.Visible = false;
            textBoxnombre3.Visible = false;
            labelnombre3.Visible = false;
            checkBoxEntrenador3.Visible = false;
            comboBoxEntrenador3.Visible = false;
            textBoxnombre4.Visible = false;
            labelnombre4.Visible = false;
            checkBoxEntrenador4.Visible = false;
            comboBoxEntrenador4.Visible = false;
            textBoxnombre5.Visible = false;
            labelnombre5.Visible = false;
            checkBoxEntrenador5.Visible = false;
            comboBoxEntrenador5.Visible = false;
            textBoxnombre6.Visible = false;
            labelnombre6.Visible = false;
            checkBoxEntrenador6.Visible = false;
            comboBoxEntrenador6.Visible = false;
            textBoxnombre7.Visible = false;
            labelnombre7.Visible = false;
            checkBoxEntrenador7.Visible = false;
            comboBoxEntrenador7.Visible = false;
            textBoxnombre8.Visible = false;
            labelnombre8.Visible = false;
            checkBoxEntrenador8.Visible = false;
            comboBoxEntrenador8.Visible = false;

            botonconfirmar.Visible = false;
            textBoxnombre1.Text = "";
            textBoxnombre2.Text = "";
            textBoxnombre3.Text = "";
            textBoxnombre4.Text = "";
            textBoxnombre5.Text = "";
            textBoxnombre6.Text = "";
            textBoxnombre7.Text = "";
            textBoxnombre8.Text = "";
        }

        private bool ValidarNombre(string nombre)
        {
            return Regex.IsMatch(nombre, @"^[a-zA-Z]+$");
        }

        //boton confirmar jugadores 
        private void botonconfirmar_Click(object sender, EventArgs e)
        {
            label3.Text = "Ingrese caracteres válidos.\r\n(Sólo letras)";

            if (radio2jugadores.Checked)
            {
                if (checkBoxEntrenador1.Checked)
                {
                    jugador1 = comboBoxEntrenador1.Text;
                }
                else
                {
                    jugador1 = textBoxnombre1.Text;
                }

                if (checkBoxEntrenador2.Checked)
                {
                    jugador2 = comboBoxEntrenador2.Text;
                }
                else
                {
                    jugador2 = textBoxnombre2.Text;
                }

                if (string.IsNullOrWhiteSpace(jugador1) || string.IsNullOrWhiteSpace(jugador2))
                {
                    groupBoxerror.Visible = true;
                    return;
                }

                if (!ValidarNombre(jugador1) || !ValidarNombre(jugador2))
                {
                    groupBoxerror.Visible = true;

                    if (!ValidarNombre(jugador1))
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

                    if (!ValidarNombre(jugador2))
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

                if (repetido())
                {
                    groupBoxerror.Visible = true;
                    label3.Text = "No se permiten nombres\r\nrepetidos";

                    return;
                }

                if ((formInicio.jugadores.existeJNombre(jugador1) && !checkBoxEntrenador1.Checked) || (formInicio.jugadores.existeJNombre(jugador2) && !checkBoxEntrenador2.Checked))
                {
                    groupBoxerror.Visible = true;
                    label3.Text = "Ya hay un perfil\r\ncon este nombre.";

                    if (formInicio.jugadores.existeJNombre(jugador1))
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

                    if (formInicio.jugadores.existeJNombre(jugador2))
                    {
                        groupBoxerror.Visible = true;
                        label3.Text = "Ya hay un perfil\r\ncon este nombre.";

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

                listaJtorneo.agregarJugadorAlFinal(new jugador(formInicio.idJugador++, jugador1, 0, 0, 0));
                listaJtorneo.agregarJugadorAlFinal(new jugador(formInicio.idJugador++, jugador2, 0, 0, 0));

                formInicio.jugadores.agregarListaALista(listaJtorneo);
            }

            
            if (radio4jugadores.Checked)
            {
                if (checkBoxEntrenador1.Checked)
                {
                    jugador1 = comboBoxEntrenador1.Text;
                }
                else
                {
                    jugador1 = textBoxnombre1.Text;
                }

                if (checkBoxEntrenador2.Checked)
                {
                    jugador2 = comboBoxEntrenador2.Text;
                }
                else
                {
                    jugador2 = textBoxnombre2.Text;
                }

                if (checkBoxEntrenador3.Checked)
                {
                    jugador3 = comboBoxEntrenador3.Text;
                }
                else
                {
                    jugador3 = textBoxnombre3.Text;
                }

                if (checkBoxEntrenador4.Checked)
                {
                    jugador4 = comboBoxEntrenador4.Text;
                }
                else
                {
                    jugador4 = textBoxnombre4.Text;
                }

                if (string.IsNullOrWhiteSpace(jugador1) || string.IsNullOrWhiteSpace(jugador2) || string.IsNullOrWhiteSpace(jugador3) || string.IsNullOrWhiteSpace(jugador4))
                {
                    groupBoxerror.Visible = true;
                    return;
                }

                if (!ValidarNombre(jugador1) || !ValidarNombre(jugador2) || !ValidarNombre(jugador3) || !ValidarNombre(jugador4))
                {
                    groupBoxerror.Visible = true;

                    if (!ValidarNombre(jugador1))
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

                    if (!ValidarNombre(jugador2))
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

                    if (!ValidarNombre(jugador3))
                    {
                        if (checkBoxEntrenador3.Checked)
                        {
                            comboBoxEntrenador3.ForeColor = Color.Red;
                        }
                        else
                        {
                            textBoxnombre3.ForeColor = Color.Red;
                        }
                    }
                    else
                    {
                        comboBoxEntrenador3.ForeColor = Color.Black;
                        textBoxnombre3.ForeColor = Color.Black;
                    }

                    if (!ValidarNombre(jugador4))
                    {
                        if (checkBoxEntrenador4.Checked)
                        {
                            comboBoxEntrenador4.ForeColor = Color.Red;
                        }
                        else
                        {
                            textBoxnombre4.ForeColor = Color.Red;
                        }
                    }
                    else
                    {
                        comboBoxEntrenador4.ForeColor = Color.Black;
                        textBoxnombre4.ForeColor = Color.Black;
                    }

                    return;
                }

                if (repetido())
                {
                    groupBoxerror.Visible = true;
                    label3.Text = "No se permiten nombres\r\nrepetidos";

                    return;
                }

                if ((formInicio.jugadores.existeJNombre(jugador1) && !checkBoxEntrenador1.Checked) || (formInicio.jugadores.existeJNombre(jugador2) && !checkBoxEntrenador2.Checked) || (formInicio.jugadores.existeJNombre(jugador3) && !checkBoxEntrenador3.Checked) || (formInicio.jugadores.existeJNombre(jugador4) && !checkBoxEntrenador4.Checked))
                {
                    groupBoxerror.Visible = true;
                    label3.Text = "Ya hay un perfil\r\ncon este nombre.";

                    if (formInicio.jugadores.existeJNombre(jugador1))
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

                    if (formInicio.jugadores.existeJNombre(jugador2))
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

                    if (formInicio.jugadores.existeJNombre(jugador3))
                    {
                        if (checkBoxEntrenador3.Checked)
                        {
                            comboBoxEntrenador3.ForeColor = Color.Red;
                        }
                        else
                        {
                            textBoxnombre3.ForeColor = Color.Red;
                        }
                    }
                    else
                    {
                        comboBoxEntrenador3.ForeColor = Color.Black;
                        textBoxnombre3.ForeColor = Color.Black;
                    }

                    if (formInicio.jugadores.existeJNombre(jugador4))
                    {
                        groupBoxerror.Visible = true;

                        if (checkBoxEntrenador4.Checked)
                        {
                            comboBoxEntrenador4.ForeColor = Color.Red;
                        }
                        else
                        {
                            textBoxnombre4.ForeColor = Color.Red;
                        }
                    }
                    else
                    {
                        comboBoxEntrenador4.ForeColor = Color.Black;
                        textBoxnombre4.ForeColor = Color.Black;
                    }

                    return;
                }

                jugador E1;
                jugador E2;
                jugador E3;
                jugador E4;

                if (checkBoxEntrenador1.Checked)
                {
                    E1 = formInicio.jugadores.buscarJugador(jugador1);
                }
                else
                {
                    E1 = new jugador(formInicio.idJugador++, jugador1, 0, 0, 0);
                }

                if (checkBoxEntrenador2.Checked)
                {
                    E2 = formInicio.jugadores.buscarJugador(jugador2);
                }
                else
                {
                    E2 = new jugador(formInicio.idJugador++, jugador2, 0, 0, 0);
                }

                if (checkBoxEntrenador3.Checked)
                {
                    E3 = formInicio.jugadores.buscarJugador(jugador3);
                }
                else
                {
                    E3 = new jugador(formInicio.idJugador++, jugador3, 0, 0, 0);
                }

                if (checkBoxEntrenador4.Checked)
                {
                    E4 = formInicio.jugadores.buscarJugador(jugador4);
                }
                else
                {
                    E4 = new jugador(formInicio.idJugador++, jugador4, 0, 0, 0);
                }

                listaJtorneo.agregarJugadorAlFinal(E1);
                listaJtorneo.agregarJugadorAlFinal(E2);
                listaJtorneo.agregarJugadorAlFinal(E3);
                listaJtorneo.agregarJugadorAlFinal(E4);

                formInicio.jugadores.agregarListaALista(listaJtorneo);
            }

            if (radio8jugadores.Checked)
            {
                if (checkBoxEntrenador1.Checked)
                {
                    jugador1 = comboBoxEntrenador1.Text;
                }
                else
                {
                    jugador1 = textBoxnombre1.Text;
                }

                if (checkBoxEntrenador2.Checked)
                {
                    jugador2 = comboBoxEntrenador2.Text;
                }
                else
                {
                    jugador2 = textBoxnombre2.Text;
                }

                if (checkBoxEntrenador3.Checked)
                {
                    jugador3 = comboBoxEntrenador3.Text;
                }
                else
                {
                    jugador3 = textBoxnombre3.Text;
                }

                if (checkBoxEntrenador4.Checked)
                {
                    jugador4 = comboBoxEntrenador4.Text;
                }
                else
                {
                    jugador4 = textBoxnombre4.Text;
                }

                if (checkBoxEntrenador5.Checked)
                {
                    jugador5 = comboBoxEntrenador5.Text;
                }
                else
                {
                    jugador5 = textBoxnombre5.Text;
                }

                if (checkBoxEntrenador6.Checked)
                {
                    jugador6 = comboBoxEntrenador6.Text;
                }
                else
                {
                    jugador6 = textBoxnombre6.Text;
                }

                if (checkBoxEntrenador7.Checked)
                {
                    jugador7 = comboBoxEntrenador7.Text;
                }
                else
                {
                    jugador7 = textBoxnombre7.Text;
                }

                if (checkBoxEntrenador8.Checked)
                {
                    jugador8 = comboBoxEntrenador8.Text;
                }
                else
                {
                    jugador8 = textBoxnombre8.Text;
                }

                if (string.IsNullOrWhiteSpace(jugador1) || string.IsNullOrWhiteSpace(jugador2) || string.IsNullOrWhiteSpace(jugador3) || string.IsNullOrWhiteSpace(jugador4) || string.IsNullOrWhiteSpace(jugador5) || string.IsNullOrWhiteSpace(jugador6) || string.IsNullOrWhiteSpace(jugador7) || string.IsNullOrWhiteSpace(jugador8))
                {
                    groupBoxerror.Visible = true;
                    return;
                }

                if (!ValidarNombre(jugador1) || !ValidarNombre(jugador2) || !ValidarNombre(jugador3) || !ValidarNombre(jugador4) || !ValidarNombre(jugador5) || !ValidarNombre(jugador6) || !ValidarNombre(jugador7) || !ValidarNombre(jugador8))
                {
                    groupBoxerror.Visible = true;

                    if (!ValidarNombre(jugador1))
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

                    if (!ValidarNombre(jugador2))
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

                    if (!ValidarNombre(jugador3))
                    {
                        if (checkBoxEntrenador3.Checked)
                        {
                            comboBoxEntrenador3.ForeColor = Color.Red;
                        }
                        else
                        {
                            textBoxnombre3.ForeColor = Color.Red;
                        }
                    }
                    else
                    {
                        comboBoxEntrenador3.ForeColor = Color.Black;
                        textBoxnombre3.ForeColor = Color.Black;
                    }

                    if (!ValidarNombre(jugador4))
                    {
                        if (checkBoxEntrenador4.Checked)
                        {
                            comboBoxEntrenador4.ForeColor = Color.Red;
                        }
                        else
                        {
                            textBoxnombre4.ForeColor = Color.Red;
                        }
                    }
                    else
                    {
                        comboBoxEntrenador4.ForeColor = Color.Black;
                        textBoxnombre4.ForeColor = Color.Black;
                    }

                    if (!ValidarNombre(jugador5))
                    {
                        if (checkBoxEntrenador5.Checked)
                        {
                            comboBoxEntrenador5.ForeColor = Color.Red;
                        }
                        else
                        {
                            textBoxnombre5.ForeColor = Color.Red;
                        }
                    }
                    else
                    {
                        comboBoxEntrenador5.ForeColor = Color.Black;
                        textBoxnombre5.ForeColor = Color.Black;
                    }

                    if (!ValidarNombre(jugador6))
                    {
                        if (checkBoxEntrenador6.Checked)
                        {
                            comboBoxEntrenador6.ForeColor = Color.Red;
                        }
                        else
                        {
                            textBoxnombre6.ForeColor = Color.Red;
                        }
                    }
                    else
                    {
                        comboBoxEntrenador6.ForeColor = Color.Black;
                        textBoxnombre6.ForeColor = Color.Black;
                    }

                    if (!ValidarNombre(jugador3))
                    {
                        if (checkBoxEntrenador7.Checked)
                        {
                            comboBoxEntrenador7.ForeColor = Color.Red;
                        }
                        else
                        {
                            textBoxnombre7.ForeColor = Color.Red;
                        }
                    }
                    else
                    {
                        comboBoxEntrenador7.ForeColor = Color.Black;
                        textBoxnombre7.ForeColor = Color.Black;
                    }

                    if (!ValidarNombre(jugador8))
                    {
                        if (checkBoxEntrenador8.Checked)
                        {
                            comboBoxEntrenador8.ForeColor = Color.Red;
                        }
                        else
                        {
                            textBoxnombre8.ForeColor = Color.Red;
                        }
                    }
                    else
                    {
                        comboBoxEntrenador8.ForeColor = Color.Black;
                        textBoxnombre8.ForeColor = Color.Black;
                    }

                    return;
                }

                if (repetido())
                {
                    groupBoxerror.Visible = true;
                    label3.Text = "No se permiten nombres\r\nrepetidos";

                    return;
                }

                if ((formInicio.jugadores.existeJNombre(jugador1) && !checkBoxEntrenador1.Checked) || (formInicio.jugadores.existeJNombre(jugador2) && !checkBoxEntrenador2.Checked) || (formInicio.jugadores.existeJNombre(jugador3) && !checkBoxEntrenador3.Checked) || (formInicio.jugadores.existeJNombre(jugador4) && !checkBoxEntrenador4.Checked) || (formInicio.jugadores.existeJNombre(jugador5) && !checkBoxEntrenador5.Checked) || (formInicio.jugadores.existeJNombre(jugador6) && !checkBoxEntrenador6.Checked) || (formInicio.jugadores.existeJNombre(jugador7) && !checkBoxEntrenador7.Checked) || (formInicio.jugadores.existeJNombre(jugador8) && !checkBoxEntrenador8.Checked))
                {
                    groupBoxerror.Visible = true;
                    label3.Text = "Ya hay un perfil\r\ncon este nombre.";

                    if (formInicio.jugadores.existeJNombre(jugador1))
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

                    if (formInicio.jugadores.existeJNombre(jugador2))
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

                    if (formInicio.jugadores.existeJNombre(jugador3))
                    {
                        if (checkBoxEntrenador3.Checked)
                        {
                            comboBoxEntrenador3.ForeColor = Color.Red;
                        }
                        else
                        {
                            textBoxnombre3.ForeColor = Color.Red;
                        }
                    }
                    else
                    {
                        comboBoxEntrenador3.ForeColor = Color.Black;
                        textBoxnombre3.ForeColor = Color.Black;
                    }

                    if (formInicio.jugadores.existeJNombre(jugador4))
                    {
                        groupBoxerror.Visible = true;

                        if (checkBoxEntrenador4.Checked)
                        {
                            comboBoxEntrenador4.ForeColor = Color.Red;
                        }
                        else
                        {
                            textBoxnombre4.ForeColor = Color.Red;
                        }
                    }
                    else
                    {
                        comboBoxEntrenador4.ForeColor = Color.Black;
                        textBoxnombre4.ForeColor = Color.Black;
                    }

                    if (formInicio.jugadores.existeJNombre(jugador5))
                    {
                        if (checkBoxEntrenador5.Checked)
                        {
                            comboBoxEntrenador5.ForeColor = Color.Red;
                        }
                        else
                        {
                            textBoxnombre5.ForeColor = Color.Red;
                        }
                    }
                    else
                    {
                        comboBoxEntrenador5.ForeColor = Color.Black;
                        textBoxnombre5.ForeColor = Color.Black;
                    }

                    if (formInicio.jugadores.existeJNombre(jugador6))
                    {
                        groupBoxerror.Visible = true;

                        if (checkBoxEntrenador6.Checked)
                        {
                            comboBoxEntrenador6.ForeColor = Color.Red;
                        }
                        else
                        {
                            textBoxnombre6.ForeColor = Color.Red;
                        }
                    }
                    else
                    {
                        comboBoxEntrenador6.ForeColor = Color.Black;
                        textBoxnombre6.ForeColor = Color.Black;
                    }

                    if (formInicio.jugadores.existeJNombre(jugador7))
                    {
                        if (checkBoxEntrenador7.Checked)
                        {
                            comboBoxEntrenador7.ForeColor = Color.Red;
                        }
                        else
                        {
                            textBoxnombre7.ForeColor = Color.Red;
                        }
                    }
                    else
                    {
                        comboBoxEntrenador7.ForeColor = Color.Black;
                        textBoxnombre7.ForeColor = Color.Black;
                    }

                    if (formInicio.jugadores.existeJNombre(jugador8))
                    {
                        groupBoxerror.Visible = true;

                        if (checkBoxEntrenador8.Checked)
                        {
                            comboBoxEntrenador8.ForeColor = Color.Red;
                        }
                        else
                        {
                            textBoxnombre8.ForeColor = Color.Red;
                        }
                    }
                    else
                    {
                        comboBoxEntrenador8.ForeColor = Color.Black;
                        textBoxnombre8.ForeColor = Color.Black;
                    }

                    return;
                }

                jugador E1;
                jugador E2;
                jugador E3;
                jugador E4;
                jugador E5;
                jugador E6;
                jugador E7;
                jugador E8;

                if (checkBoxEntrenador1.Checked)
                {
                    E1 = formInicio.jugadores.buscarJugador(jugador1);
                }
                else
                {
                    E1 = new jugador(formInicio.idJugador++, jugador1, 0, 0, 0);
                }

                if (checkBoxEntrenador2.Checked)
                {
                    E2 = formInicio.jugadores.buscarJugador(jugador2);
                }
                else
                {
                    E2 = new jugador(formInicio.idJugador++, jugador2, 0, 0, 0);
                }

                if (checkBoxEntrenador3.Checked)
                {
                    E3 = formInicio.jugadores.buscarJugador(jugador3);
                }
                else
                {
                    E3 = new jugador(formInicio.idJugador++, jugador3, 0, 0, 0);
                }

                if (checkBoxEntrenador4.Checked)
                {
                    E4 = formInicio.jugadores.buscarJugador(jugador4);
                }
                else
                {
                    E4 = new jugador(formInicio.idJugador++, jugador4, 0, 0, 0);
                }

                if (checkBoxEntrenador5.Checked)
                {
                    E5 = formInicio.jugadores.buscarJugador(jugador5);
                }
                else
                {
                    E5 = new jugador(formInicio.idJugador++, jugador5, 0, 0, 0);
                }

                if (checkBoxEntrenador6.Checked)
                {
                    E6 = formInicio.jugadores.buscarJugador(jugador6);
                }
                else
                {
                    E6 = new jugador(formInicio.idJugador++, jugador6, 0, 0, 0);
                }

                if (checkBoxEntrenador7.Checked)
                {
                    E7 = formInicio.jugadores.buscarJugador(jugador7);
                }
                else
                {
                    E7 = new jugador(formInicio.idJugador++, jugador7, 0, 0, 0);
                }

                if (checkBoxEntrenador8.Checked)
                {
                    E8 = formInicio.jugadores.buscarJugador(jugador8);
                }
                else
                {
                    E8 = new jugador(formInicio.idJugador++, jugador8, 0, 0, 0);
                }

                listaJtorneo.agregarJugadorAlFinal(E1);
                listaJtorneo.agregarJugadorAlFinal(E2);
                listaJtorneo.agregarJugadorAlFinal(E3);
                listaJtorneo.agregarJugadorAlFinal(E4);
                listaJtorneo.agregarJugadorAlFinal(E5);
                listaJtorneo.agregarJugadorAlFinal(E6);
                listaJtorneo.agregarJugadorAlFinal(E7);
                listaJtorneo.agregarJugadorAlFinal(E8);

                formInicio.jugadores.agregarListaALista(listaJtorneo);
            }

            exitForm = true;
            formLlaves llavesTorneo = new formLlaves();
            llavesTorneo.Visible = true;
            this.Close();
        }
        private void botonsalirerror_Click(object sender, EventArgs e)
        {
            groupBoxerror.Visible = false;
        }

        private void formElegirTorneo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!exitForm)
            {
                Application.Exit();
            }
        }

        private void buttonVolverMenu_Click(object sender, EventArgs e)
        {
            exitForm = true;
            menuPrincipal.Show();
            this.Close();
        }

        public bool repetido()
        {
            string[] nombres = {jugador1, jugador2, jugador3, jugador4, jugador5, jugador6, jugador7, jugador8};
            for (int i = 0; i < nombres.Length; i++)
            {
                if (!string.IsNullOrEmpty(nombres[i]))
                {
                    for (int j = 0; j < nombres.Length; j++)
                    {
                        if (i != j && nombres[i].Equals(nombres[j]))
                        {
                            textBoxnombre1.ForeColor = Color.Black;
                            textBoxnombre2.ForeColor = Color.Black;
                            textBoxnombre3.ForeColor = Color.Black;
                            textBoxnombre4.ForeColor = Color.Black;
                            textBoxnombre5.ForeColor = Color.Black;
                            textBoxnombre6.ForeColor = Color.Black;
                            textBoxnombre7.ForeColor = Color.Black;
                            textBoxnombre8.ForeColor = Color.Black;

                            switch (i)
                            {
                                case 0:
                                    textBoxnombre1.ForeColor = Color.Red;
                                    break;
                                case 1:
                                    textBoxnombre2.ForeColor = Color.Red;
                                    break;
                                case 2:
                                    textBoxnombre3.ForeColor = Color.Red;
                                    break;
                                case 3:
                                    textBoxnombre4.ForeColor = Color.Red;
                                    break;
                                case 4:
                                    textBoxnombre5.ForeColor = Color.Red;
                                    break;
                                case 5:
                                    textBoxnombre6.ForeColor = Color.Red;
                                    break;
                                case 6:
                                    textBoxnombre7.ForeColor = Color.Red;
                                    break;
                                case 7:
                                    textBoxnombre2.ForeColor = Color.Red;
                                    break;
                            }

                            switch (j)
                            {
                                case 0:
                                    textBoxnombre1.ForeColor = Color.Red;
                                    break;
                                case 1:
                                    textBoxnombre2.ForeColor = Color.Red;
                                    break;
                                case 2:
                                    textBoxnombre3.ForeColor = Color.Red;
                                    break;
                                case 3:
                                    textBoxnombre4.ForeColor = Color.Red;
                                    break;
                                case 4:
                                    textBoxnombre5.ForeColor = Color.Red;
                                    break;
                                case 5:
                                    textBoxnombre6.ForeColor = Color.Red;
                                    break;
                                case 6:
                                    textBoxnombre7.ForeColor = Color.Red;
                                    break;
                                case 7:
                                    textBoxnombre2.ForeColor = Color.Red;
                                    break;
                            }

                            return true;
                        }
                    }
                }
            }
            return false;
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

        private void checkBoxEntrenador3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEntrenador3.Checked)
            {
                comboBoxEntrenador3.Visible = true;
                textBoxnombre3.Visible = false;
            }
            else
            {
                comboBoxEntrenador3.Visible = false;
                textBoxnombre3.Visible = true;
            }
        }

        private void checkBoxEntrenador4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEntrenador4.Checked)
            {
                comboBoxEntrenador4.Visible = true;
                textBoxnombre4.Visible = false;
            }
            else
            {
                comboBoxEntrenador4.Visible = false;
                textBoxnombre4.Visible = true;
            }
        }

        private void checkBoxEntrenador5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEntrenador5.Checked)
            {
                comboBoxEntrenador5.Visible = true;
                textBoxnombre5.Visible = false;
            }
            else
            {
                comboBoxEntrenador5.Visible = false;
                textBoxnombre5.Visible = true;
            }
        }

        private void checkBoxEntrenador6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEntrenador6.Checked)
            {
                comboBoxEntrenador6.Visible = true;
                textBoxnombre6.Visible = false;
            }
            else
            {
                comboBoxEntrenador6.Visible = false;
                textBoxnombre6.Visible = true;
            }
        }

        private void checkBoxEntrenador7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEntrenador7.Checked)
            {
                comboBoxEntrenador7.Visible = true;
                textBoxnombre7.Visible = false;
            }
            else
            {
                comboBoxEntrenador7.Visible = false;
                textBoxnombre7.Visible = true;
            }
        }

        private void checkBoxEntrenador8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEntrenador8.Checked)
            {
                comboBoxEntrenador8.Visible = true;
                textBoxnombre8.Visible = false;
            }
            else
            {
                comboBoxEntrenador8.Visible = false;
                textBoxnombre8.Visible = true;
            }
        }
    }
}
