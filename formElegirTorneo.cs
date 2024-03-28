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
        private cola colaJtorneo = new cola();

        public formElegirTorneo()
        {
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
            if (radio2jugadores.Checked) 
        {            
            groupBox2nombres.Visible = true;
            textBoxnombre1.Enabled = true;
            textBoxnombre2.Enabled = true;
            textBoxnombre3.Enabled = false;
            textBoxnombre4.Enabled = false;
            textBoxnombre5.Enabled = false;
            textBoxnombre6.Enabled = false;
            textBoxnombre7.Enabled = false;
            textBoxnombre8.Enabled = false;
            radio4jugadores.Checked = false;
            radio8jugadores.Checked = false;
            botonconfirmar.Visible = true;
            pictitulo.Visible = true;             
        }

            if (radio4jugadores.Checked)
        {
                groupBox2nombres.Visible = true;
                textBoxnombre1.Enabled = true;
                textBoxnombre2.Enabled = true;
                textBoxnombre3.Enabled = true;
                textBoxnombre4.Enabled = true;
                textBoxnombre5.Enabled = false;
                textBoxnombre6.Enabled = false;
                textBoxnombre7.Enabled = false;
                textBoxnombre8.Enabled = false;

            radio4jugadores.Checked = false;
            radio8jugadores.Checked = false;
            botonconfirmar.Visible = true;
            pictitulo.Visible = true;
            }

            if (radio8jugadores.Checked)
            {
                groupBox2nombres.Visible = true; 
                textBoxnombre1.Enabled = true;
                textBoxnombre2.Enabled = true;
                textBoxnombre3.Enabled = true;
                textBoxnombre4.Enabled = true;
                textBoxnombre5.Enabled = true;
                textBoxnombre6.Enabled = true;
                textBoxnombre7.Enabled = true;
                textBoxnombre8.Enabled = true;

            radio4jugadores.Checked = false;
            radio8jugadores.Checked = false;
            botonconfirmar.Visible = true;
            pictitulo.Visible = true;
            }
        }

         //boton equis superior
        private void buttonsalir_Click(object sender, EventArgs e)        
            {
                groupBox2nombres.Visible = false;
                botonconfirmar.Visible = false;
                textBoxnombre1.Text = ("");
                textBoxnombre2.Text = ("");
                textBoxnombre3.Text = ("");
                textBoxnombre4.Text = ("");
                textBoxnombre5.Text = ("");
                textBoxnombre6.Text = ("");
                textBoxnombre7.Text = ("");
                textBoxnombre8.Text = ("");
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
                String jugador1 = textBoxnombre1.Text;
                String jugador2 = textBoxnombre2.Text;

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

                jugador JT1 = new jugador(1, jugador1, 0, 0, 0);
                jugador JT2 = new jugador(2, jugador2, 0, 0, 0);

                colaJtorneo.agregarJugadorEnCola(JT1);
                colaJtorneo.agregarJugadorEnCola(JT2);
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

                jugador JT1 = new jugador(1, jugador1, 0, 0, 0);
                jugador JT2 = new jugador(2, jugador2, 0, 0, 0);
                jugador JT3 = new jugador(3, jugador3, 0, 0, 0);
                jugador JT4 = new jugador(4, jugador4, 0, 0, 0);


                colaJtorneo.agregarJugadorEnCola(JT1);
                colaJtorneo.agregarJugadorEnCola(JT2);
                colaJtorneo.agregarJugadorEnCola(JT3);
                colaJtorneo.agregarJugadorEnCola(JT4);

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

                if (string.IsNullOrWhiteSpace(jugador1) || string.IsNullOrWhiteSpace(jugador2) || string.IsNullOrWhiteSpace(jugador3) || string.IsNullOrWhiteSpace(jugador4)
                    || string.IsNullOrWhiteSpace(jugador5) || string.IsNullOrWhiteSpace(jugador6) || string.IsNullOrWhiteSpace(jugador7) || string.IsNullOrWhiteSpace(jugador8))
                {
                    groupBoxerror.Visible = true;
                    return;
                }

                if (!ValidarNombre(jugador1) || !ValidarNombre(jugador2) || !ValidarNombre(jugador3) || !ValidarNombre(jugador4)
                    || !ValidarNombre(jugador5) || !ValidarNombre(jugador6) || !ValidarNombre(jugador7) || !ValidarNombre(jugador8))
                {
                    groupBoxerror.Visible = true;
                    return;
                }

                jugador JT1 = new jugador(1, jugador1, 0, 0, 0);
                jugador JT2 = new jugador(2, jugador2, 0, 0, 0);
                jugador JT3 = new jugador(3, jugador3, 0, 0, 0);
                jugador JT4 = new jugador(4, jugador4, 0, 0, 0);
                jugador JT5 = new jugador(5, jugador5, 0, 0, 0);
                jugador JT6 = new jugador(6, jugador6, 0, 0, 0);
                jugador JT7 = new jugador(7, jugador7, 0, 0, 0);
                jugador JT8 = new jugador(8, jugador8, 0, 0, 0);

                colaJtorneo.agregarJugadorEnCola(JT1);
                colaJtorneo.agregarJugadorEnCola(JT2);
                colaJtorneo.agregarJugadorEnCola(JT3);
                colaJtorneo.agregarJugadorEnCola(JT4);
                colaJtorneo.agregarJugadorEnCola(JT5);
                colaJtorneo.agregarJugadorEnCola(JT6);
                colaJtorneo.agregarJugadorEnCola(JT7);
                colaJtorneo.agregarJugadorEnCola(JT8);

            }
        }
        private void botonsalirerror_Click(object sender, EventArgs e)
        {
            groupBoxerror.Visible = false;
        }
    }
}
