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
        }
         
        //boton para confirmar  la cantidad de jugadores al torneo
        private void button1_Click(object sender, EventArgs e)
        {
            groupBox2nombres.Visible = true;

            if (radio2jugadores.Checked) 
            {
                pictitulo.Visible = true;
                botonconfirmar.Visible = true;
                botonconfirmar.Location = new Point(159, 195);
            }

            if (radio4jugadores.Checked)
            {
                textBoxnombre3.Visible = true;
                labelnombre3.Visible = true;
                textBoxnombre4.Visible = true;
                labelnombre4.Visible = true;
                botonconfirmar.Location = new Point(159, 282);

                botonconfirmar.Visible = true;
                pictitulo.Visible = true;
            }

            if (radio8jugadores.Checked)
            {
                textBoxnombre3.Visible = true;
                labelnombre3.Visible = true;
                textBoxnombre4.Visible = true;
                labelnombre4.Visible = true;
                textBoxnombre5.Visible = true;
                labelnombre5.Visible = true;
                textBoxnombre6.Visible = true;
                labelnombre6.Visible = true;
                textBoxnombre7.Visible = true;
                labelnombre7.Visible = true;
                textBoxnombre8.Visible = true;
                labelnombre8.Visible = true;
                botonconfirmar.Location = new Point(335, 422);

                botonconfirmar.Visible = true;
                pictitulo.Visible = true;
            }
            groupBoxerror.BringToFront();
        }

         //boton equis superior
        private void buttonsalir_Click(object sender, EventArgs e)        
        {
            groupBox2nombres.Visible = false;
            textBoxnombre3.Visible = false;
            labelnombre3.Visible = false;
            textBoxnombre4.Visible = false;
            labelnombre4.Visible = false;
            textBoxnombre5.Visible = false;
            labelnombre5.Visible = false;
            textBoxnombre6.Visible = false;
            labelnombre6.Visible = false;
            textBoxnombre7.Visible = false;
            labelnombre7.Visible = false;
            textBoxnombre8.Visible = false;
            labelnombre8.Visible = false;

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
            if (radio2jugadores.Checked)
            {
                string jugador1 = textBoxnombre1.Text;
                string jugador2 = textBoxnombre2.Text;

                if (string.IsNullOrWhiteSpace(jugador1) || string.IsNullOrWhiteSpace(jugador2))
                {
                    groupBoxerror.Visible = true;
                    return;
                }

                if (!ValidarNombre(jugador1) || !ValidarNombre(jugador2))
                {
                    groupBoxerror.Visible = true;
                    return;
                }
                listaJtorneo.agregarJugadorAlFinal(new jugador(formInicio.idJugador++, jugador1, 0, 0, 0));
                listaJtorneo.agregarJugadorAlFinal(new jugador(formInicio.idJugador++, jugador2, 0, 0, 0));

                formInicio.jugadores.agregarListaALista(listaJtorneo);
            }

            
            if (radio4jugadores.Checked)
            {                
                string jugador1 = textBoxnombre1.Text;
                string jugador2 = textBoxnombre2.Text;
                string jugador3 = textBoxnombre3.Text;
                string jugador4 = textBoxnombre4.Text;

                if (string.IsNullOrWhiteSpace(jugador1) || string.IsNullOrWhiteSpace(jugador2) || string.IsNullOrWhiteSpace(jugador3) || string.IsNullOrWhiteSpace(jugador4))
                {
                    groupBoxerror.Visible = true;
                    return;
                }

                if (!ValidarNombre(jugador1) || !ValidarNombre(jugador2) || !ValidarNombre(jugador3) || !ValidarNombre(jugador4))
                {
                    groupBoxerror.Visible = true;
                    return;
                }

                listaJtorneo.agregarJugadorAlFinal(new jugador(formInicio.idJugador++, jugador1, 0, 0, 0));
                listaJtorneo.agregarJugadorAlFinal(new jugador(formInicio.idJugador++, jugador2, 0, 0, 0));
                listaJtorneo.agregarJugadorAlFinal(new jugador(formInicio.idJugador++, jugador3, 0, 0, 0));
                listaJtorneo.agregarJugadorAlFinal(new jugador(formInicio.idJugador++, jugador4, 0, 0, 0));

                formInicio.jugadores.agregarListaALista(listaJtorneo);
            }

            if (radio8jugadores.Checked)
            {
                string jugador1 = textBoxnombre1.Text;
                string jugador2 = textBoxnombre2.Text;
                string jugador3 = textBoxnombre3.Text;
                string jugador4 = textBoxnombre4.Text;
                string jugador5 = textBoxnombre5.Text;
                string jugador6 = textBoxnombre6.Text;
                string jugador7 = textBoxnombre7.Text;
                string jugador8 = textBoxnombre8.Text;

                if (string.IsNullOrWhiteSpace(jugador1) || string.IsNullOrWhiteSpace(jugador2) || string.IsNullOrWhiteSpace(jugador3) || string.IsNullOrWhiteSpace(jugador4) || string.IsNullOrWhiteSpace(jugador5) || string.IsNullOrWhiteSpace(jugador6) || string.IsNullOrWhiteSpace(jugador7) || string.IsNullOrWhiteSpace(jugador8))
                {
                    groupBoxerror.Visible = true;
                    return;
                }

                if (!ValidarNombre(jugador1) || !ValidarNombre(jugador2) || !ValidarNombre(jugador3) || !ValidarNombre(jugador4) || !ValidarNombre(jugador5) || !ValidarNombre(jugador6) || !ValidarNombre(jugador7) || !ValidarNombre(jugador8))
                {
                    groupBoxerror.Visible = true;
                    return;
                }

                listaJtorneo.agregarJugadorAlFinal(new jugador(formInicio.idJugador++, jugador1, 0, 0, 0));
                listaJtorneo.agregarJugadorAlFinal(new jugador(formInicio.idJugador++, jugador2, 0, 0, 0));
                listaJtorneo.agregarJugadorAlFinal(new jugador(formInicio.idJugador++, jugador3, 0, 0, 0));
                listaJtorneo.agregarJugadorAlFinal(new jugador(formInicio.idJugador++, jugador4, 0, 0, 0));
                listaJtorneo.agregarJugadorAlFinal(new jugador(formInicio.idJugador++, jugador5, 0, 0, 0));
                listaJtorneo.agregarJugadorAlFinal(new jugador(formInicio.idJugador++, jugador6, 0, 0, 0));
                listaJtorneo.agregarJugadorAlFinal(new jugador(formInicio.idJugador++, jugador7, 0, 0, 0));
                listaJtorneo.agregarJugadorAlFinal(new jugador(formInicio.idJugador++, jugador8, 0, 0, 0));

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
    }
}
