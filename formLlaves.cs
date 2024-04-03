using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon
{
    public partial class formLlaves : Form
    {
        bool exitForm = false;
        AVL llaves = new AVL();
        public static cola rivales = new cola();
        public nodo batallaActual = new nodo();
        Image fondoGanador;

        public formLlaves()
        {
            jugador[] vacios = new jugador[7];
            for (int i = 0; i < vacios.Length; i++)
            {
                vacios[i] = new jugador(i-7, string.Empty, 0, 0, 0);
            }

            formElegirTorneo.listaJtorneo = formElegirTorneo.listaJtorneo.randomizeJugadores(formElegirTorneo.listaJtorneo.getArrayJugadores());


            InitializeComponent();

            labelGanador.Parent = fondo;
            
            switch (formElegirTorneo.listaJtorneo.getTamanio())
            {
                case 2:
                    jugador1.Visible = false;
                    jugador2.Visible = false;
                    jugador3.Visible = false;
                    jugador4.Visible = false;
                    jugador5.Visible = false;
                    jugador6.Visible = false;
                    jugador7.Visible = false;
                    jugador8.Visible = false;
                    clasificado_bracket1.Visible = false;
                    clasificado_bracket2.Visible = false;
                    clasificado_bracket3.Visible = false;
                    clasificado_bracket4.Visible = false;
                    fondo.Image = Properties.Resources.torneo2jugadores;
                    fondoGanador = Properties.Resources.torneo2jugadoresGanador;

                    llaves.insertarJugador(vacios[0]);

                    llaves.insertarFinal(formElegirTorneo.listaJtorneo);

                    Clasificado_final1.Text = formElegirTorneo.listaJtorneo.getInicio().getValorJugador().getNombre();
                    Clasificado_final2.Text = formElegirTorneo.listaJtorneo.getInicio().getSiguiente().getValorJugador().getNombre();

                    break;
                case 4:
                    jugador1.Visible = false;
                    jugador2.Visible = false;
                    jugador3.Visible = false;
                    jugador4.Visible = false;
                    jugador5.Visible = false;
                    jugador6.Visible = false;
                    jugador7.Visible = false;
                    jugador8.Visible = false;

                    fondo.Image = Properties.Resources.torneo4jugadores;
                    fondoGanador = Properties.Resources.torneo4jugadoresGanador;

                    for (int i = 0; i < 3; i++)
                    {
                        llaves.insertarJugador(vacios[i]);
                    }

                    llaves.insertarSemi(formElegirTorneo.listaJtorneo);

                    clasificado_bracket1.Text = llaves.getRaiz().getDer().getDer().getValorJugador().getNombre();
                    clasificado_bracket2.Text = llaves.getRaiz().getDer().getIzq().getValorJugador().getNombre();
                    clasificado_bracket3.Text = llaves.getRaiz().getIzq().getDer().getValorJugador().getNombre();
                    clasificado_bracket4.Text = llaves.getRaiz().getIzq().getIzq().getValorJugador().getNombre();

                    break;
                case 8:

                    fondo.Image = Properties.Resources.torneo8jugadores;
                    fondoGanador = Properties.Resources.torneo8jugadoresGanador;

                    for (int i = 0; i < vacios.Length; i++)
                    {
                        llaves.insertarJugador(vacios[i]);
                    }

                    llaves.insertarCuartos(formElegirTorneo.listaJtorneo);

                    jugador1.Text = llaves.getRaiz().getDer().getDer().getDer().getValorJugador().getNombre();
                    jugador2.Text = llaves.getRaiz().getDer().getDer().getIzq().getValorJugador().getNombre();
                    jugador3.Text = llaves.getRaiz().getDer().getIzq().getDer().getValorJugador().getNombre();
                    jugador4.Text = llaves.getRaiz().getDer().getIzq().getIzq().getValorJugador().getNombre();
                    jugador5.Text = llaves.getRaiz().getIzq().getDer().getDer().getValorJugador().getNombre();
                    jugador6.Text = llaves.getRaiz().getIzq().getDer().getIzq().getValorJugador().getNombre();
                    jugador7.Text = llaves.getRaiz().getIzq().getIzq().getDer().getValorJugador().getNombre();
                    jugador8.Text = llaves.getRaiz().getIzq().getIzq().getIzq().getValorJugador().getNombre();

                    break;
            }

            
        }

        public void actualizarBrackets()
        {
            if (formElegirTorneo.listaJtorneo.getTamanio() >= 2)
            {
                labelGanador.Text = llaves.getRaiz().getValorJugador().getNombre();
                Clasificado_final1.Text = llaves.getRaiz().getDer().getValorJugador().getNombre();
                Clasificado_final2.Text = llaves.getRaiz().getIzq().getValorJugador().getNombre();
            }

            if (formElegirTorneo.listaJtorneo.getTamanio() >= 4)
            {
                clasificado_bracket1.Text = llaves.getRaiz().getDer().getDer().getValorJugador().getNombre();
                clasificado_bracket2.Text = llaves.getRaiz().getDer().getIzq().getValorJugador().getNombre();
                clasificado_bracket3.Text = llaves.getRaiz().getIzq().getDer().getValorJugador().getNombre();
                clasificado_bracket4.Text = llaves.getRaiz().getIzq().getIzq().getValorJugador().getNombre();
            }

            if (formElegirTorneo.listaJtorneo.getTamanio() == 8)
            {
                jugador1.Text = llaves.getRaiz().getDer().getDer().getDer().getValorJugador().getNombre();
                jugador2.Text = llaves.getRaiz().getDer().getDer().getIzq().getValorJugador().getNombre();
                jugador3.Text = llaves.getRaiz().getDer().getIzq().getDer().getValorJugador().getNombre();
                jugador4.Text = llaves.getRaiz().getDer().getIzq().getIzq().getValorJugador().getNombre();
                jugador5.Text = llaves.getRaiz().getIzq().getDer().getDer().getValorJugador().getNombre();
                jugador6.Text = llaves.getRaiz().getIzq().getDer().getIzq().getValorJugador().getNombre();
                jugador7.Text = llaves.getRaiz().getIzq().getIzq().getDer().getValorJugador().getNombre();
                jugador8.Text = llaves.getRaiz().getIzq().getIzq().getIzq().getValorJugador().getNombre();
            }
        }

        public cola proximoCombate()
        {
            cola proximoCombate = new cola();

            if (jugador1.Text != "" && jugador2.Text != "" && clasificado_bracket1.Text == "")
            {
                proximoCombate.agregarJugadorEnCola(llaves.getRaiz().getDer().getDer().getDer().getValorJugador());
                proximoCombate.agregarJugadorEnCola(llaves.getRaiz().getDer().getDer().getIzq().getValorJugador());
                labelSiguienteCombate.Text = "Siguiente combate:\n" + llaves.getRaiz().getDer().getDer().getDer().getValorJugador().getNombre() + " vs " + llaves.getRaiz().getDer().getDer().getIzq().getValorJugador().getNombre();
                batallaActual = llaves.getRaiz().getDer().getDer();
                return proximoCombate;
            }

            if (jugador3.Text != "" && jugador4.Text != "" && clasificado_bracket2.Text == "")
            {
                proximoCombate.agregarJugadorEnCola(llaves.getRaiz().getDer().getIzq().getDer().getValorJugador());
                proximoCombate.agregarJugadorEnCola(llaves.getRaiz().getDer().getIzq().getIzq().getValorJugador());
                labelSiguienteCombate.Text = "Siguiente combate:\n" + llaves.getRaiz().getDer().getIzq().getDer().getValorJugador().getNombre() + " vs " + llaves.getRaiz().getDer().getIzq().getIzq().getValorJugador().getNombre();
                batallaActual = llaves.getRaiz().getDer().getIzq();
                return proximoCombate;
            }

            if (jugador5.Text != "" && jugador6.Text != "" && clasificado_bracket3.Text == "")
            {
                proximoCombate.agregarJugadorEnCola(llaves.getRaiz().getIzq().getDer().getDer().getValorJugador());
                proximoCombate.agregarJugadorEnCola(llaves.getRaiz().getIzq().getDer().getIzq().getValorJugador());
                labelSiguienteCombate.Text = "Siguiente combate:\n" + llaves.getRaiz().getIzq().getDer().getDer().getValorJugador().getNombre() + " vs " + llaves.getRaiz().getIzq().getDer().getIzq().getValorJugador().getNombre();
                batallaActual = llaves.getRaiz().getIzq().getDer();
                return proximoCombate;
            }

            if (jugador7.Text != "" && jugador8.Text != "" && clasificado_bracket4.Text == "")
            {
                proximoCombate.agregarJugadorEnCola(llaves.getRaiz().getIzq().getIzq().getDer().getValorJugador());
                proximoCombate.agregarJugadorEnCola(llaves.getRaiz().getIzq().getIzq().getIzq().getValorJugador());
                labelSiguienteCombate.Text = "Siguiente combate:\n" + llaves.getRaiz().getIzq().getIzq().getDer().getValorJugador().getNombre() + " vs " + llaves.getRaiz().getIzq().getIzq().getIzq().getValorJugador().getNombre();
                batallaActual = llaves.getRaiz().getIzq().getIzq();
                return proximoCombate;
            }

            if (clasificado_bracket1.Text != "" && clasificado_bracket2.Text != "" && Clasificado_final1.Text == "")
            {
                proximoCombate.agregarJugadorEnCola(llaves.getRaiz().getDer().getDer().getValorJugador());
                proximoCombate.agregarJugadorEnCola(llaves.getRaiz().getDer().getIzq().getValorJugador());
                labelSiguienteCombate.Text = "Siguiente combate:\n" + llaves.getRaiz().getDer().getDer().getValorJugador().getNombre() + " vs " + llaves.getRaiz().getDer().getIzq().getValorJugador().getNombre();
                batallaActual = llaves.getRaiz().getDer();
                return proximoCombate;
            }

            if (clasificado_bracket3.Text != "" && clasificado_bracket4.Text != "" && Clasificado_final2.Text == "")
            {
                proximoCombate.agregarJugadorEnCola(llaves.getRaiz().getIzq().getDer().getValorJugador());
                proximoCombate.agregarJugadorEnCola(llaves.getRaiz().getIzq().getIzq().getValorJugador());
                labelSiguienteCombate.Text = "Siguiente combate:\n" + llaves.getRaiz().getIzq().getDer().getValorJugador().getNombre() + " vs " + llaves.getRaiz().getIzq().getIzq().getValorJugador().getNombre();
                batallaActual = llaves.getRaiz().getIzq();
                return proximoCombate;
            }

            if (Clasificado_final1.Text != "" && Clasificado_final2.Text != "" && labelGanador.Text == "")
            {
                proximoCombate.agregarJugadorEnCola(llaves.getRaiz().getDer().getValorJugador());
                proximoCombate.agregarJugadorEnCola(llaves.getRaiz().getIzq().getValorJugador());
                labelSiguienteCombate.Text = "Siguiente combate:\n" + llaves.getRaiz().getDer().getValorJugador().getNombre() + " vs " + llaves.getRaiz().getIzq().getValorJugador().getNombre();
                batallaActual = llaves.getRaiz();
                return proximoCombate;
            }

            labelGanador.Visible = true;
            fondo.Image = fondoGanador;
            labelSiguienteCombate.Text = "El ganador es:\n" + llaves.getRaiz().getValorJugador().getNombre();
            buttonCombateSiguiente.Text = "SALIR AL MENU";
            return null;
        }

        private void formLlaves_VisibleChanged(object sender, EventArgs e)
        {
            actualizarBrackets();
            rivales = proximoCombate();
        }

        private void buttonCombateSiguiente_Click(object sender, EventArgs e)
        {
            if (rivales != null)
            {
                formBatalla.FLL = this;
                FormSeleccionarEquipo.torneo = true;
                FormSeleccionarEquipo FSE = new FormSeleccionarEquipo();
                FSE.Visible = true;
                this.Visible = false;
            }
            else
            {
                llaves.getRaiz().getValorJugador().setTGanados(llaves.getRaiz().getValorJugador().getTGanados()+1);
                exitForm = true;
                formMenuPrincipal FMP = new formMenuPrincipal();
                FMP.Visible = true;
                this.Close();
            }
        }

        private void formLlaves_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!exitForm)
            {
                Application.Exit();
            }
        }
    }
}
