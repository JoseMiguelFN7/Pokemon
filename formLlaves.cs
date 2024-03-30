﻿using System;
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
        AVL llaves = new AVL();

        public formLlaves()
        {
            jugador[] vacios = new jugador[7];
            for (int i = 0; i < vacios.Length; i++)
            {
                vacios[i] = new jugador(i-7, string.Empty, 0, 0, 0);
            }

            formElegirTorneo.listaJtorneo = formElegirTorneo.listaJtorneo.randomizeJugadores(formElegirTorneo.listaJtorneo.getArrayJugadores());

            jugador[] test = new jugador[formElegirTorneo.listaJtorneo.getTamanio()];

            test = formElegirTorneo.listaJtorneo.getArrayJugadores();

            for (int i = 0; i < test.Length; i++)
            {
                Console.WriteLine(test[i].getID());
            }

            InitializeComponent();
            
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

                    llaves.insertarJugador(vacios[0]);

                    llaves.insertarFinal(formElegirTorneo.listaJtorneo);

                    Clasificado_final1.Text = formElegirTorneo.listaJtorneo.getInicio().getValorJugador().getNombre();
                    Clasificado_final2.Text = formElegirTorneo.listaJtorneo.getInicio().getSiguiente().getValorJugador().getNombre();

                    /*Console.WriteLine(llaves.getRaiz().getValorJugador().getID());
                    Console.WriteLine(llaves.getRaiz().getDer().getValorJugador().getID());
                    Console.WriteLine(llaves.getRaiz().getIzq().getValorJugador().getID());*/

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

                    for (int i = 0; i < 3; i++)
                    {
                        llaves.insertarJugador(vacios[i]);
                    }

                    llaves.insertarSemi(formElegirTorneo.listaJtorneo);

                    clasificado_bracket1.Text = llaves.getRaiz().getDer().getDer().getValorJugador().getNombre();
                    clasificado_bracket2.Text = llaves.getRaiz().getDer().getIzq().getValorJugador().getNombre();
                    clasificado_bracket3.Text = llaves.getRaiz().getIzq().getDer().getValorJugador().getNombre();
                    clasificado_bracket4.Text = llaves.getRaiz().getIzq().getIzq().getValorJugador().getNombre();

                    /*Console.WriteLine(llaves.getRaiz().getValorJugador().getID());                          //B
                    Console.WriteLine(llaves.getRaiz().getDer().getValorJugador().getID());                 //B
                    Console.WriteLine(llaves.getRaiz().getIzq().getValorJugador().getID());                 //B
                    Console.WriteLine(llaves.getRaiz().getDer().getDer().getValorJugador().getID());        //1
                    Console.WriteLine(llaves.getRaiz().getDer().getIzq().getValorJugador().getID());        //2
                    Console.WriteLine(llaves.getRaiz().getIzq().getDer().getValorJugador().getID());        //3
                    Console.WriteLine(llaves.getRaiz().getIzq().getIzq().getValorJugador().getID());        //4*/

                    break;
                case 8:

                    fondo.Image = Properties.Resources.torneo8jugadores;

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


                    /*Console.WriteLine(llaves.getRaiz().getValorJugador().getID());                              //B
                    Console.WriteLine(llaves.getRaiz().getDer().getValorJugador().getID());                     //B
                    Console.WriteLine(llaves.getRaiz().getIzq().getValorJugador().getID());                     //B
                    Console.WriteLine(llaves.getRaiz().getIzq().getDer().getValorJugador().getID());            //B
                    Console.WriteLine(llaves.getRaiz().getIzq().getIzq().getValorJugador().getID());            //B
                    Console.WriteLine(llaves.getRaiz().getDer().getDer().getValorJugador().getID());            //B
                    Console.WriteLine(llaves.getRaiz().getDer().getIzq().getValorJugador().getID());            //B
                    Console.WriteLine(llaves.getRaiz().getDer().getDer().getDer().getValorJugador().getID());   //1
                    Console.WriteLine(llaves.getRaiz().getDer().getDer().getIzq().getValorJugador().getID());   //2
                    Console.WriteLine(llaves.getRaiz().getDer().getIzq().getDer().getValorJugador().getID());   //3
                    Console.WriteLine(llaves.getRaiz().getDer().getIzq().getIzq().getValorJugador().getID());   //4
                    Console.WriteLine(llaves.getRaiz().getIzq().getDer().getDer().getValorJugador().getID());   //5
                    Console.WriteLine(llaves.getRaiz().getIzq().getDer().getIzq().getValorJugador().getID());   //6
                    Console.WriteLine(llaves.getRaiz().getIzq().getIzq().getDer().getValorJugador().getID());   //7
                    Console.WriteLine(llaves.getRaiz().getIzq().getIzq().getIzq().getValorJugador().getID());   //8*/
                    break;
            }
        }

        public void actualizarBrackets()
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
}