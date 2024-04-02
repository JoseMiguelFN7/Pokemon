using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Pokemon
{
    public partial class formBatalla : Form
    {
        public static formLlaves FLL;
        bool PKM1Muerto = false;
        bool PKM2Muerto = false;
        public static jugador ganador;
        bool segundoRealizado = false;
        PictureBox PKMCambiado;
        int count;
        int animacion;
        bool exitForm = false;
        public static pokemon pokemon1;
        public static pokemon pokemon2;
        public static jugador P1;
        public static jugador P2;
        int IndexPKM;
        Random r = new Random();
        cola jugadores = new cola();

        public formBatalla()
        {

            jugadores = FormSeleccionarEquipo.colaEntrenadores;

            P1 = jugadores.sacarJugadorDeLaCola();
            jugadores.agregarJugadorEnCola(P1);
            P2 = jugadores.sacarJugadorDeLaCola();
            jugadores.agregarJugadorEnCola(P2);

            Console.WriteLine(FormSeleccionarEquipo.colaEntrenadores.getTamanio());

            llenarBolsas(P1, P2);

            pokemon1 = P1.getPokemones()[0];
            pokemon2 = P2.getPokemones()[0];

            //{ Width = 889, Height = 500}
            //{ Width = 1111, Height = 594}


            //1202, 661


            InitializeComponent();
            //SE AJUSTAN TODAS LAS UBICACIONES Y TAMANOS
            fondo.Size = new Size(889, 500);
            this.ClientSize = fondo.Size;
            pictureBoxPKM1.Parent = fondo;
            pictureBoxPKM2.Parent = fondo;
            panelOpciones.Parent = fondo;
            pictureBoxDatosPKM1.Parent = fondo;
            panelDatosPKM1.Parent = pictureBoxDatosPKM1;
            panelDatosPKM1.Location = new Point(60, 1);
            pictureBoxDatosPKM2.Parent = fondo;
            panelDatosPKM2.Parent = pictureBoxDatosPKM2;
            panelDatosPKM2.Location = new Point(50, 1);
            panelBolsa.Location = new Point(fondo.Width / 2 - panelBolsa.Width / 2, fondo.Height / 2 - panelBolsa.Height / 2);
            panelCambioPKM.Location = new Point(fondo.Width / 2 - panelCambioPKM.Width / 2, fondo.Height / 2 - panelCambioPKM.Height / 2);

            //SE LLENA INFO DE POKEMONES
            actualizarInfo(pokemon1);
            actualizarInfo(pokemon2);

            panelMovimientos.Parent = fondo;
            panelMovimientos.Location = new Point(630, 156);
            labelNombreMov1.Parent = pictureBoxMov1;
            labelNombreMov1.Size = new Size(120, 47);
            labelNombreMov1.Location = new Point(50, 5);
            labelNombreMov2.Parent = pictureBoxMov2;
            labelNombreMov2.Size = new Size(120, 47);
            labelNombreMov2.Location = new Point(50, 5);
            labelNombreMov3.Parent = pictureBoxMov3;
            labelNombreMov3.Size = new Size(120, 47);
            labelNombreMov3.Location = new Point(50, 5);
            labelNombreMov4.Parent = pictureBoxMov4;
            labelNombreMov4.Size = new Size(120, 47);
            labelNombreMov4.Location = new Point(50, 5);
            labelUsos1.Parent = pictureBoxMov1;
            labelUsos1.Size = new Size(50, 50);
            labelUsos1.Location = new Point(175, pictureBoxMov1.Height / 2 - labelUsos1.Height / 2);
            labelUsos2.Parent = pictureBoxMov2;
            labelUsos2.Size = new Size(50, 50);
            labelUsos2.Location = new Point(175, pictureBoxMov2.Height / 2 - labelUsos2.Height / 2);
            labelUsos3.Parent = pictureBoxMov3;
            labelUsos3.Size = new Size(50, 50);
            labelUsos3.Location = new Point(175, pictureBoxMov3.Height / 2 - labelUsos3.Height / 2);
            labelUsos4.Parent = pictureBoxMov4;
            labelUsos4.Size = new Size(50, 50);
            labelUsos4.Location = new Point(175, pictureBoxMov4.Height / 2 - labelUsos4.Height / 2);
            actualizarMovimientos(pokemon1);

            labelNombreObj1.Parent = pictureBoxObj1;
            labelNombreObj1.Dock = DockStyle.Fill;
            labelNombreObj2.Parent = pictureBoxObj2;
            labelNombreObj2.Dock = DockStyle.Fill;
            labelNombreObj3.Parent = pictureBoxObj3;
            labelNombreObj3.Dock = DockStyle.Fill;
            labelNombreObj4.Parent = pictureBoxObj4;
            labelNombreObj4.Dock = DockStyle.Fill;
            labelNombreObj5.Parent = pictureBoxObj5;
            labelNombreObj5.Dock = DockStyle.Fill;
            labelNombreObj6.Parent = pictureBoxObj6;
            labelNombreObj6.Dock = DockStyle.Fill;
            labelNombreObj7.Parent = pictureBoxObj7;
            labelNombreObj7.Dock = DockStyle.Fill;
            labelNombreObj8.Parent = pictureBoxObj8;
            labelNombreObj8.Dock = DockStyle.Fill;
            labelNombreObj9.Parent = pictureBoxObj9;
            labelNombreObj9.Dock = DockStyle.Fill;

            panelPKM1.Parent = pictureBoxPKM1Container;
            panelPKM1.Location = new Point(0, 0);
            panelPKM2.Parent = pictureBoxPKM2Container;
            panelPKM2.Location = new Point(0, 0);
            panelPKM3.Parent = pictureBoxPKM3Container;
            panelPKM3.Location = new Point(0, 0);
            panelPKM4.Parent = pictureBoxPKM4Container;
            panelPKM4.Location = new Point(0, 0);
            panelPKM5.Parent = pictureBoxPKM5Container;
            panelPKM5.Location = new Point(0, 0);
            panelPKM6.Parent = pictureBoxPKM6Container;
            panelPKM6.Location = new Point(0, 0);

            labelNombreMov1Cambio.Parent = pictureBoxMov1Cambio;
            labelNombreMov2Cambio.Parent = pictureBoxMov2Cambio;
            labelNombreMov3Cambio.Parent = pictureBoxMov3Cambio;
            labelNombreMov4Cambio.Parent = pictureBoxMov4Cambio;
            labelTipo1.Parent = pictureBoxTipo1;
            labelTipo1.Dock = DockStyle.Fill;
            labelTipo2.Parent = pictureBoxTipo2;
            labelTipo2.Dock = DockStyle.Fill;
            labelNombreMov1Cambio.Parent = pictureBoxMov1Cambio;
            labelNombreMov1Cambio.Location = new Point(60, pictureBoxMov1Cambio.Height / 2 - labelNombreMov1Cambio.Height / 2);
            labelNombreMov2Cambio.Parent = pictureBoxMov2Cambio;
            labelNombreMov2Cambio.Location = new Point(60, pictureBoxMov2Cambio.Height / 2 - labelNombreMov2Cambio.Height / 2);
            labelNombreMov3Cambio.Parent = pictureBoxMov3Cambio;
            labelNombreMov3Cambio.Location = new Point(60, pictureBoxMov3Cambio.Height / 2 - labelNombreMov3Cambio.Height / 2);
            labelNombreMov4Cambio.Parent = pictureBoxMov4Cambio;
            labelNombreMov4Cambio.Location = new Point(60, pictureBoxMov4Cambio.Height / 2 - labelNombreMov4Cambio.Height / 2);
            labelUsos1Cambio.Parent = pictureBoxMov1Cambio;
            labelUsos1Cambio.Location = new Point(190, pictureBoxMov1Cambio.Height / 2 - labelUsos1Cambio.Height / 2);
            labelUsos2Cambio.Parent = pictureBoxMov2Cambio;
            labelUsos2Cambio.Location = new Point(190, pictureBoxMov2Cambio.Height / 2 - labelUsos2Cambio.Height / 2);
            labelUsos3Cambio.Parent = pictureBoxMov3Cambio;
            labelUsos3Cambio.Location = new Point(190, pictureBoxMov3Cambio.Height / 2 - labelUsos3Cambio.Height / 2);
            labelUsos4Cambio.Parent = pictureBoxMov4Cambio;
            labelUsos4Cambio.Location = new Point(190, pictureBoxMov4Cambio.Height / 2 - labelUsos4Cambio.Height / 2);

            panelRendirse.Location = new Point((fondo.Width / 2) - (panelRendirse.Width / 2), (fondo.Height / 2) - (panelRendirse.Height / 2));

            pictureBoxPokeBall.Parent = fondo;
            pictureBoxBlueSpark.Parent = fondo;

            panelGanador.Location = new Point((fondo.Width / 2) - (panelGanador.Width / 2), (fondo.Height / 2) - (panelGanador.Height / 2));

            P1.GetTurno().setActivo(true);
            P2.GetTurno().setActivo(true);

            formInicio.reproducir(1);

            labelInfo.Text = "Turno de " + P1.getNombre() + ".";
        }

        public void llenarBolsas(jugador j1, jugador j2)
        {
            for (int i = 0; i < 9; i++)
            {
                j1.getBolsa()[i] = new pila();
                j2.getBolsa()[i] = new pila();

                switch (i + 1)
                {
                    case 1:
                        for (int j = 0; j < 3; j++)
                        {
                            j1.getBolsa()[i].agregarPocionEnLaPila(new pocion());
                            j2.getBolsa()[i].agregarPocionEnLaPila(new pocion());
                        }
                        break;
                    case 2:
                        for (int j = 0; j < 2; j++)
                        {
                            j1.getBolsa()[i].agregarSuperPocionEnLaPila(new superPocion());
                            j2.getBolsa()[i].agregarSuperPocionEnLaPila(new superPocion());
                        }
                        break;
                    case 3:
                        j1.getBolsa()[i].agregarHiperPocionEnLaPila(new hiperPocion());
                        j2.getBolsa()[i].agregarHiperPocionEnLaPila(new hiperPocion());
                        break;
                    case 4:
                        j1.getBolsa()[i].agregarAntiParalisisEnLaPila(new antiParalisis());
                        j2.getBolsa()[i].agregarAntiParalisisEnLaPila(new antiParalisis());
                        break;
                    case 5:
                        j1.getBolsa()[i].agregarAntidotoEnLaPila(new antidoto());
                        j2.getBolsa()[i].agregarAntidotoEnLaPila(new antidoto());
                        break;
                    case 6:
                        j1.getBolsa()[i].agregarDespertarEnLaPila(new despertar());
                        j2.getBolsa()[i].agregarDespertarEnLaPila(new despertar());
                        break;
                    case 7:
                        j1.getBolsa()[i].agregarCuraTotalEnLaPila(new curaTotal());
                        j2.getBolsa()[i].agregarCuraTotalEnLaPila(new curaTotal());
                        break;
                    case 8:
                        j1.getBolsa()[i].agregarMaxPocionEnLaPila(new maxPocion());
                        j2.getBolsa()[i].agregarMaxPocionEnLaPila(new maxPocion());
                        break;
                    case 9:
                        for (int j = 0; j < 3; j++)
                        {
                            j1.getBolsa()[i].agregarPrecisionXEnLaPila(new precisionX());
                            j2.getBolsa()[i].agregarPrecisionXEnLaPila(new precisionX());
                        }
                        break;
                }
            }
        }

        public void asignarImagenPKM2(pokemon PKM)
        {
            pictureBoxPKM2.Image = null;
            pictureBoxPKM2.Image = PKM.getImg()[0];
            pictureBoxPKM2.Size = new Size(pictureBoxPKM2.Image.Width * 2, pictureBoxPKM2.Image.Height * 2);
            pictureBoxPKM2.Location = new Point(610 - pictureBoxPKM2.Width, 360 - pictureBoxPKM2.Height);
        }

        public void asignarImagenPKM1(pokemon PKM)
        {
            pictureBoxPKM1.Image = null;
            pictureBoxPKM1.Image = PKM.getImg()[1];
            pictureBoxPKM1.Size = new Size(pictureBoxPKM1.Image.Width * 2, pictureBoxPKM1.Image.Height * 2);
            pictureBoxPKM1.Location = new Point(310 - pictureBoxPKM1.Width, 400 - pictureBoxPKM1.Height);
        }

        public void actualizarMovimientos(pokemon PKM)
        {
            if (PKM.getID() == 132)
            {
                pictureBoxMov1.Image = Properties.Resources.MovNormal;
                labelNombreMov1.Text = "Transformar";
                labelUsos1.Visible = false;
                pictureBoxMov2.Visible = false;
                labelNombreMov2.Visible = false;
                labelUsos2.Visible = false;
                pictureBoxMov3.Visible = false;
                labelNombreMov3.Visible = false;
                labelUsos3.Visible = false;
                pictureBoxMov4.Visible = false;
                labelNombreMov4.Visible = false;
                labelUsos4.Visible = false;
            }
            else
            {
                tipo.asignarImagenTipo(PKM.getMovimientos()[0].getTipo(), pictureBoxMov1);
                labelNombreMov1.Text = PKM.getMovimientos()[0].getNombre();
                labelUsos1.Visible = true;
                labelUsos1.Text = PKM.getMovimientos()[0].getUsos(1) + "/" + PKM.getMovimientos()[0].getUsos(0);
                pictureBoxMov2.Visible = true;
                tipo.asignarImagenTipo(PKM.getMovimientos()[1].getTipo(), pictureBoxMov2);
                labelNombreMov2.Visible = true;
                labelNombreMov2.Text = PKM.getMovimientos()[1].getNombre();
                labelUsos2.Visible = true;
                labelUsos2.Text = PKM.getMovimientos()[1].getUsos(1) + "/" + PKM.getMovimientos()[1].getUsos(0);
                pictureBoxMov3.Visible = true;
                tipo.asignarImagenTipo(PKM.getMovimientos()[2].getTipo(), pictureBoxMov3);
                labelNombreMov3.Visible = true;
                labelNombreMov3.Text = PKM.getMovimientos()[2].getNombre();
                labelUsos3.Visible = true;
                labelUsos3.Text = PKM.getMovimientos()[2].getUsos(1) + "/" + PKM.getMovimientos()[2].getUsos(0);
                pictureBoxMov4.Visible = true;
                tipo.asignarImagenTipo(PKM.getMovimientos()[3].getTipo(), pictureBoxMov4);
                labelNombreMov4.Visible = true;
                labelNombreMov4.Text = PKM.getMovimientos()[3].getNombre();
                labelUsos4.Visible = true;
                labelUsos4.Text = PKM.getMovimientos()[3].getUsos(1) + "/" + PKM.getMovimientos()[3].getUsos(0);
            }
        }

        public void mostrarDescripcionMov(jugador P, int n)
        {
            textBoxMovDescripcionCambio.Text = P.getPokemones()[IndexPKM].getMovimientos()[n].getDescripcion();
        }

        public void actualizarMovimientosCambioPKM(jugador P, int n)
        {
            tableLayoutPanel12.Visible = true;

            labelNombreMov1Cambio.Visible = true;
            labelUsos1Cambio.Visible = true;

            labelNombreMov2Cambio.Visible = true;
            labelUsos2Cambio.Visible = true;

            labelNombreMov3Cambio.Visible = true;
            labelUsos3Cambio.Visible = true;

            labelNombreMov4Cambio.Visible = true;
            labelUsos4Cambio.Visible = true;

            tipo.asignarImagenTipo(P.getPokemones()[n].getTipos().getInicio().getValorTipo(), pictureBoxTipo1);
            labelTipo1.Visible = true;
            labelTipo1.Text = P.getPokemones()[n].getTipos().getInicio().getValorTipo().getNombre();
            if (P.getPokemones()[n].getTipos().getTamanio() > 1)
            {
                pictureBoxTipo2.Visible = true;
                labelTipo2.Visible = true;
                tipo.asignarImagenTipo(P.getPokemones()[n].getTipos().getInicio().getSiguiente().getValorTipo(), pictureBoxTipo2);
                labelTipo2.Text = P.getPokemones()[n].getTipos().getInicio().getSiguiente().getValorTipo().getNombre();
            }
            else
            {
                pictureBoxTipo2.Visible = false;
                labelTipo2.Visible = false;
            }

            if (P.getPokemones()[n].getID() == 132)
            {
                
                labelNombreMov1Cambio.Visible = true;
                tipo.asignarImagenTipo(formInicio.arrTipos[0], pictureBoxMov1Cambio);
                labelNombreMov1Cambio.Text = "Transformar";
                labelUsos1Cambio.Text = "1/1";
                labelUsos1Cambio.Visible = true;

                labelNombreMov2Cambio.Visible = false;
                labelUsos2Cambio.Visible = false;
                labelNombreMov3Cambio.Visible = false;
                labelUsos3Cambio.Visible = false;
                labelNombreMov4Cambio.Visible = false;
                labelUsos4Cambio.Visible = false;
            }
            else
            {
                labelNombreMov1Cambio.Visible = true;
                tipo.asignarImagenTipo(P.getPokemones()[n].getMovimientos()[0].getTipo(), pictureBoxMov1Cambio);
                labelNombreMov1Cambio.Text = P.getPokemones()[n].getMovimientos()[0].getNombre();
                labelUsos1Cambio.Text = P.getPokemones()[n].getMovimientos()[0].getUsos(1) + "/" + P.getPokemones()[n].getMovimientos()[0].getUsos(0);
                labelUsos1Cambio.Visible = true;
                labelNombreMov2Cambio.Visible = true;
                tipo.asignarImagenTipo(P.getPokemones()[n].getMovimientos()[1].getTipo(), pictureBoxMov2Cambio);
                labelNombreMov2Cambio.Text = P.getPokemones()[n].getMovimientos()[1].getNombre();
                labelUsos2Cambio.Text = P.getPokemones()[n].getMovimientos()[1].getUsos(1) + "/" + P.getPokemones()[n].getMovimientos()[1].getUsos(0);
                labelUsos2Cambio.Visible = true;
                labelNombreMov3Cambio.Visible = true;
                tipo.asignarImagenTipo(P.getPokemones()[n].getMovimientos()[2].getTipo(), pictureBoxMov3Cambio);
                labelNombreMov3Cambio.Text = P.getPokemones()[n].getMovimientos()[2].getNombre();
                labelUsos3Cambio.Text = P.getPokemones()[n].getMovimientos()[2].getUsos(1) + "/" + P.getPokemones()[n].getMovimientos()[2].getUsos(0);
                labelUsos3Cambio.Visible = true;
                labelNombreMov4Cambio.Visible = true;
                tipo.asignarImagenTipo(P.getPokemones()[n].getMovimientos()[3].getTipo(), pictureBoxMov4Cambio);
                labelNombreMov4Cambio.Text = P.getPokemones()[n].getMovimientos()[3].getNombre();
                labelUsos4Cambio.Text = P.getPokemones()[n].getMovimientos()[3].getUsos(1) + "/" +    P.getPokemones()[n].getMovimientos()[3].getUsos(0);
                labelUsos4Cambio.Visible = true;
            }

            IndexPKM = n;

            if (!P.getPokemones()[n].Equals(pokemon1) && !P.getPokemones()[n].Equals(pokemon2))
            {
                pictureBoxConfirmarCambio.Visible = true;
                pictureBoxConfirmarCambio.Enabled = true;
            }
        }

        public void actualizarInfoCambios(jugador P)
        {
            actualizarPKMCambio(P, 0, pictureBoxPKM1Cambio, labelNombre1Cambio, labelNivel1Cambio, labelHP1Cambio, barraHPPKM1Cambio);
            actualizarPKMCambio(P, 1, pictureBoxPKM2Cambio, labelNombre2Cambio, labelNivel2Cambio, labelHP2Cambio, barraHPPKM2Cambio);
            actualizarPKMCambio(P, 2, pictureBoxPKM3Cambio, labelNombre3Cambio, labelNivel3Cambio, labelHP3Cambio, barraHPPKM3Cambio);
            actualizarPKMCambio(P, 3, pictureBoxPKM4Cambio, labelNombre4Cambio, labelNivel4Cambio, labelHP4Cambio, barraHPPKM4Cambio);
            actualizarPKMCambio(P, 4, pictureBoxPKM5Cambio, labelNombre5Cambio, labelNivel5Cambio, labelHP5Cambio, barraHPPKM5Cambio);
            actualizarPKMCambio(P, 5, pictureBoxPKM6Cambio, labelNombre6Cambio, labelNivel6Cambio, labelHP6Cambio, barraHPPKM6Cambio);
        }

        public void actualizarPKMCambio(jugador P, int n, PictureBox PB, Label lNombre, Label lNivel, Label lHP, ProgressBar barraHP)
        {
            PB.Image = P.getPokemones()[n].getImg()[2];
            lNombre.Text = P.getPokemones()[n].getNombre();
            lNivel.Text = "Nvl. " + P.getPokemones()[n].getNivel();
            lHP.Text = "HP: " + P.getPokemones()[n].getHP(2) + "/" + P.getPokemones()[n].getHP(1);
            barraHP.Value = (int)Math.Round(((double)P.getPokemones()[n].getHP(2) / P.getPokemones()[n].getHP(1)) * 100);

            if (P.getPokemones()[n].getHP(2) == 0)
            {
                PB.Enabled = false;
                lNombre.Enabled = false;
                lNivel.Enabled = false;
                lHP.Enabled = false;
                barraHP.Enabled = false;
            }
            else
            {
                PB.Enabled = true;
                lNombre.Enabled = true;
                lNivel.Enabled = true;
                lHP.Enabled = true;
                barraHP.Enabled = true;
            }
        }

        public void ocultarMovCambios()
        {
            pictureBoxTipo1.Image = null;
            labelTipo1.Visible = false;
            pictureBoxTipo2.Image = null;
            labelTipo2.Visible = false;
            pictureBoxMov1Cambio.Image = null;
            labelNombreMov1Cambio.Visible = false;
            labelUsos1Cambio.Visible = false;
            pictureBoxMov2Cambio.Image = null;
            labelNombreMov2Cambio.Visible = false;
            labelUsos2Cambio.Visible = false;
            pictureBoxMov3Cambio.Image = null;
            labelNombreMov3Cambio.Visible = false;
            labelUsos3Cambio.Visible = false;
            pictureBoxMov4Cambio.Image = null;
            labelNombreMov4Cambio.Visible = false;
            labelUsos4Cambio.Visible = false;
        }

        public void actualizarInfo(pokemon PKM)
        {
            if (PKM.Equals(pokemon1))
            {
                //Pokemon 1
                labelNombrePKM1.Text = pokemon1.getNombre();
                labelHpPKM1.Text = "HP: " + pokemon1.getHP(2) + "/" + pokemon1.getHP(1);
                labelNvlPKM1.Text = "Nvl: " + pokemon1.getNivel();
                barraHpPKM1.Value = (int)Math.Round(((double)pokemon1.getHP(2) / pokemon1.getHP(1)) * 100);
                asignarImagenPKM1(pokemon1);
            }
            else
            {
                //Pokemon 2
                labelNombrePKM2.Text = pokemon2.getNombre();
                labelHpPKM2.Text = "HP: " + pokemon2.getHP(2) + "/" + pokemon2.getHP(1);
                labelNvlPKM2.Text = "Nvl: " + pokemon2.getNivel();
                barraHpPKM2.Value = (int)Math.Round(((double)pokemon2.getHP(2) / pokemon2.getHP(1)) * 100);
                asignarImagenPKM2(pokemon2);
            }
        }

        public void mostrarInfoObjeto(int id, jugador j) 
        {
            objeto obj = formInicio.arrObj[id - 1];
            labelNombreObj.Text = obj.getNombre();
            pictureBoxObjIcon.Image = obj.getIcono();
            labelCantidadObjeto.Text = "x " + j.getBolsa()[id-1].getTamanio();
            textBoxDescripcionObj.Text = obj.getDescripcion();
        }

        public void ocultarInfoObjeto()
        {
            labelNombreObj.Text = "";
            pictureBoxObjIcon.Image = null;
            labelCantidadObjeto.Text = "";
            textBoxDescripcionObj.Text = "";
        }

        public void turnos(int op)
        {
            panelMovimientos.Visible = false;
            panelOpciones.Visible = true;

            jugador JActual = jugadores.sacarJugadorDeLaCola();
            labelInfo.Text = "Turno de " + jugadores.verInicio().getNombre() + ".";

            JActual.GetTurno().setAccion(op);

            if (JActual.GetTurno().estaActivo())
            {
                JActual.GetTurno().setActivo(false);
            }

            jugadores.agregarJugadorEnCola(JActual);

            if (jugadores.todosListos())
            {
                segundoRealizado = false;
                if (pokemon1.getVEL(2) >= pokemon2.getVEL(2))
                {
                    accion(P1, P1.GetTurno().getAccion(), pictureBoxPKM1, pictureBoxPKM2);
                }
                else
                {
                    accion(P2, P2.GetTurno().getAccion(), pictureBoxPKM2, pictureBoxPKM1);
                }
            }

            if (jugadores.verInicio().Equals(P1))
            {
                actualizarMovimientos(pokemon1);
            }
            else
            {
                actualizarMovimientos(pokemon2);
            }
        }

        public bool movPosible(int op)
        {
            if (jugadores.verInicio().Equals(P1))
            {
                if (pokemon1.getMovimientos()[op].getUsos(1) > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (pokemon2.getMovimientos()[op].getUsos(1) > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool objPosible(int op)
        {
            if (jugadores.verInicio().getBolsa()[op-4].esVacia())
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void displayAnim(int n, PictureBox PB)
        {
            panelOpciones.Visible = false;
            animacion = n;
            switch (animacion)
            {
                case 0:
                    PB.Visible = false;
                    pictureBoxPokeBall.Location = new Point(PB.Location.X - (pictureBoxPokeBall.Width / 2), PB.Location.Y + PB.Height - pictureBoxPokeBall.Height);
                    pictureBoxPokeBall.Visible = true;
                    pictureBoxBlueSpark.Location = new Point(PB.Location.X + (PB.Width / 2) - (pictureBoxBlueSpark.Width / 2), PB.Location.Y + (PB.Height / 2) - (pictureBoxBlueSpark.Height / 2));
                    break;
                case 1:
                    pictureBoxEffect.Image = Properties.Resources.heal;
                    break;
                case 2:
                    pictureBoxEffect.Image = Properties.Resources.Normal;
                    break;
                case 3:
                    pictureBoxEffect.Image = Properties.Resources.fuego;
                    break;
                case 4:
                    pictureBoxEffect.Image = Properties.Resources.agua;
                    break;
                case 5:
                    pictureBoxEffect.Image = Properties.Resources.volador;
                    break;
                case 6:
                    pictureBoxEffect.Image = Properties.Resources.Normal; //CAMBIAR A PLANTA
                    break;
                case 7:
                    pictureBoxEffect.Image = Properties.Resources.Normal; //CAMBIAR A BICHO
                    break;
                case 8:
                    pictureBoxEffect.Image = Properties.Resources.electrico;
                    break;
                case 9:
                    pictureBoxEffect.Image = Properties.Resources.psiquico;
                    break;
                case 10:
                    pictureBoxEffect.Image = Properties.Resources.veneno;
                    break;
                case 11:
                    pictureBoxEffect.Image = Properties.Resources.tierra;
                    break;
                case 12:
                    pictureBoxEffect.Image = Properties.Resources.roca;
                    break;
                case 13:
                    pictureBoxEffect.Image = Properties.Resources.hielo;
                    break;
                case 14:
                    pictureBoxEffect.Image = Properties.Resources.lucha;
                    break;
                case 15:
                    pictureBoxEffect.Image = Properties.Resources.dragon;
                    break;
                case 16:
                    pictureBoxEffect.Image = Properties.Resources.fantasma;
                    break;
                case 17:
                    pictureBoxEffect.Image = Properties.Resources.acero;
                    break;
                case 18:
                    pictureBoxEffect.Image = Properties.Resources.hada;
                    break;
            }

            if (animacion != 0)
            {
                pictureBoxEffect.Parent = PB;
                pictureBoxEffect.Location = new Point(0, 0);
                pictureBoxEffect.Size = PB.Size;
                pictureBoxEffect.Visible = true;
            }
            timer.Start();
        }

        private void formBatalla_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!exitForm)
            {
                Application.Exit();
            }
        }

        private void pictureBoxLuchar_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxLuchar.Image = Properties.Resources.Luchar2;
        }

        private void pictureBoxLuchar_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxLuchar.Image = Properties.Resources.Luchar1;
        }

        private void pictureBoxPKM_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxPKM.Image = Properties.Resources.Pokemon2;
        }

        private void pictureBoxPKM_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxPKM.Image = Properties.Resources.Pokemon1;
        }

        private void pictureBoxBolsa_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxBolsa.Image = Properties.Resources.Bolsa2;
        }

        private void pictureBoxBolsa_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxBolsa.Image = Properties.Resources.Bolsa1;
        }

        private void pictureBoxRendirse_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxRendirse.Image = Properties.Resources.Rendirse2;
        }

        private void pictureBoxRendirse_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxRendirse.Image = Properties.Resources.Rendirse1;
        }

        private void pictureBoxLuchar_Click(object sender, EventArgs e)
        {
            panelBolsa.Visible = false;
            panelOpciones.Visible = false;
            panelMovimientos.Visible = true;
            panelCambioPKM.Visible = false;
        }

        private void pictureBoxMovVolver_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxMovVolver.Image = Properties.Resources.Volver2;
        }

        private void pictureBoxMovVolver_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxMovVolver.Image = Properties.Resources.Volver1;
        }

        private void pictureBoxMovVolver_Click(object sender, EventArgs e)
        {
            panelOpciones.Visible = true;
            panelMovimientos.Visible = false;
        }

        private void pictureBoxBolsa_Click(object sender, EventArgs e)
        {
            panelBolsa.Visible = true;
            panelCambioPKM.Visible = false;
            panelRendirse.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panelBolsa.Visible = false;
        }

        private void labelNombreObj1_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoObjeto(1, jugadores.verInicio());
        }

        private void labelNombreObj2_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoObjeto(2, jugadores.verInicio());
        }

        private void labelNombreObj3_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoObjeto(3, jugadores.verInicio());
        }

        private void labelNombreObj4_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoObjeto(4, jugadores.verInicio());
        }

        private void labelNombreObj5_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoObjeto(5, jugadores.verInicio());
        }

        private void labelNombreObj6_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoObjeto(6, jugadores.verInicio());
        }

        private void labelNombreObj7_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoObjeto(7, jugadores.verInicio());
        }

        private void labelNombreObj8_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoObjeto(8, jugadores.verInicio());
        }

        private void labelNombreObj9_MouseEnter(object sender, EventArgs e)
        {
            mostrarInfoObjeto(9, jugadores.verInicio());
        }

        private void labelNombreObj_MouseLeave(object sender, EventArgs e)
        {
            ocultarInfoObjeto();
        }

        private void labelNombreObj1_Click(object sender, EventArgs e)
        {
            if (objPosible(4))
            {
                turnos(4);
                panelBolsa.Visible = false;
            }
        }

        private void labelNombreObj2_Click(object sender, EventArgs e)
        {
            if (objPosible(5))
            {
                turnos(5);
                panelBolsa.Visible = false;
            }
        }

        private void labelNombreObj3_Click(object sender, EventArgs e)
        {
            if (objPosible(6))
            {
                turnos(6);
                panelBolsa.Visible = false;
            }
        }

        private void labelNombreObj4_Click(object sender, EventArgs e)
        {
            if (objPosible(7))
            {
                turnos(7);
                panelBolsa.Visible = false;
            }
        }

        private void labelNombreObj5_Click(object sender, EventArgs e)
        {
            if (objPosible(8))
            {
                turnos(8);
                panelBolsa.Visible = false;
            }
        }

        private void labelNombreObj6_Click(object sender, EventArgs e)
        {
            if (objPosible(9))
            {
                turnos(9);
                panelBolsa.Visible = false;
            }
        }

        private void labelNombreObj7_Click(object sender, EventArgs e)
        {
            if (objPosible(10))
            {
                turnos(10);
                panelBolsa.Visible = false;
            }
        }

        private void labelNombreObj8_Click(object sender, EventArgs e)
        {
            if (objPosible(11))
            {
                turnos(11);
                panelBolsa.Visible = false;
            }
        }

        private void labelNombreObj9_Click(object sender, EventArgs e)
        {
            if (objPosible(12))
            {
                turnos(12);
                panelBolsa.Visible = false;
            }
        }

        private void pictureBoxPKM_Click(object sender, EventArgs e)
        {
            panelBolsa.Visible = false;
            panelCambioPKM.Visible = true;
            panelRendirse.Visible = false;
            tableLayoutPanel12.Visible = false;
            
            labelNombreMov1Cambio.Visible = false;
            labelUsos1Cambio.Visible = false;
            
            labelNombreMov2Cambio.Visible = false;
            labelUsos2Cambio.Visible = false;
            
            labelNombreMov3Cambio.Visible = false;
            labelUsos3Cambio.Visible = false;
            
            labelNombreMov4Cambio.Visible = false;
            labelUsos4Cambio.Visible = false;

            actualizarInfoCambios(jugadores.verInicio());
            pictureBoxConfirmarCambio.Enabled = false;
            pictureBoxConfirmarCambio.Visible = false;
        }

        private void pictureBoxXPKM_Click(object sender, EventArgs e)
        {
            if (pictureBoxXPKM.Enabled)
            {
                panelCambioPKM.Visible = false;
            }
        }

        private void panelPKM1_Click(object sender, EventArgs e)
        {
            if (panelPKM1.Enabled && pictureBoxPKM1Cambio.Enabled && labelNombre1Cambio.Enabled && labelNivel1Cambio.Enabled && barraHPPKM1Cambio.Enabled && labelHP1Cambio.Enabled)
            {
                if (PKM1Muerto || PKM2Muerto)
                {
                    if (PKM1Muerto)
                    {
                        actualizarMovimientosCambioPKM(P1, 0);
                    }

                    if (PKM2Muerto)
                    {
                        actualizarMovimientosCambioPKM(P2, 0);
                    }
                }
                else
                {
                    actualizarMovimientosCambioPKM(jugadores.verInicio(), 0);
                }
            }
        }

        private void pictureBoxMov1Cambio_MouseEnter(object sender, EventArgs e)
        {
            mostrarDescripcionMov(jugadores.verInicio(), 0);
        }

        private void pictureBoxMov2Cambio_MouseEnter(object sender, EventArgs e)
        {
            mostrarDescripcionMov(jugadores.verInicio(), 1);
        }

        private void pictureBoxMov3Cambio_MouseEnter(object sender, EventArgs e)
        {
            mostrarDescripcionMov(jugadores.verInicio(), 2);
        }

        private void pictureBoxMov4Cambio_Click(object sender, EventArgs e)
        {
            mostrarDescripcionMov(jugadores.verInicio(), 3);
        }

        private void pictureBoxMov1Cambio_MouseLeave(object sender, EventArgs e)
        {
            textBoxMovDescripcionCambio.Text = "";
        }

        private void panelPKM2_Click(object sender, EventArgs e)
        {
            if (panelPKM2.Enabled && pictureBoxPKM2Cambio.Enabled && labelNombre2Cambio.Enabled && labelNivel2Cambio.Enabled && barraHPPKM2Cambio.Enabled && labelHP2Cambio.Enabled)
            {
                if (PKM1Muerto || PKM2Muerto)
                {
                    if (PKM1Muerto)
                    {
                        actualizarMovimientosCambioPKM(P1, 1);
                    }

                    if (PKM2Muerto)
                    {
                        actualizarMovimientosCambioPKM(P2, 1);
                    }
                }
                else
                {
                    actualizarMovimientosCambioPKM(jugadores.verInicio(), 1);
                }
            }
        }

        private void panelPKM3_Click(object sender, EventArgs e)
        {
            if (panelPKM3.Enabled && pictureBoxPKM3Cambio.Enabled && labelNombre3Cambio.Enabled && labelNivel3Cambio.Enabled && barraHPPKM3Cambio.Enabled && labelHP3Cambio.Enabled)
            {
                if (PKM1Muerto || PKM2Muerto)
                {
                    if (PKM1Muerto)
                    {
                        actualizarMovimientosCambioPKM(P1, 2);
                    }

                    if (PKM2Muerto)
                    {
                        actualizarMovimientosCambioPKM(P2, 2);
                    }
                }
                else
                {
                    actualizarMovimientosCambioPKM(jugadores.verInicio(), 2);
                }
            }
        }

        private void panelPKM4_Click(object sender, EventArgs e)
        {
            if (panelPKM4.Enabled && pictureBoxPKM4Cambio.Enabled && labelNombre4Cambio.Enabled && labelNivel4Cambio.Enabled && barraHPPKM4Cambio.Enabled && labelHP4Cambio.Enabled)
            {
                if (PKM1Muerto || PKM2Muerto)
                {
                    if (PKM1Muerto)
                    {
                        actualizarMovimientosCambioPKM(P1, 3);
                    }

                    if (PKM2Muerto)
                    {
                        actualizarMovimientosCambioPKM(P2, 3);
                    }
                }
                else
                {
                    actualizarMovimientosCambioPKM(jugadores.verInicio(), 3);
                }
            }
        }

        private void panelPKM5_Click(object sender, EventArgs e)
        {
            if (panelPKM5.Enabled && pictureBoxPKM5Cambio.Enabled && labelNombre5Cambio.Enabled && labelNivel5Cambio.Enabled && barraHPPKM5Cambio.Enabled && labelHP5Cambio.Enabled)
            {
                if (PKM1Muerto || PKM2Muerto)
                {
                    if (PKM1Muerto)
                    {
                        actualizarMovimientosCambioPKM(P1, 4);
                    }

                    if (PKM2Muerto)
                    {
                        actualizarMovimientosCambioPKM(P2, 4);
                    }
                }
                else
                {
                    actualizarMovimientosCambioPKM(jugadores.verInicio(), 4);
                }
            }
        }

        private void panelPKM6_Click(object sender, EventArgs e)
        {
            if (panelPKM6.Enabled && pictureBoxPKM6Cambio.Enabled && labelNombre6Cambio.Enabled && labelNivel6Cambio.Enabled && barraHPPKM6Cambio.Enabled && labelHP6Cambio.Enabled)
            {
                if (PKM1Muerto || PKM2Muerto)
                {
                    if (PKM1Muerto)
                    {
                        actualizarMovimientosCambioPKM(P1, 5);
                    }

                    if (PKM2Muerto)
                    {
                        actualizarMovimientosCambioPKM(P2, 5);
                    }
                }
                else
                {
                    actualizarMovimientosCambioPKM(jugadores.verInicio(), 5);
                }
            }
        }

        private void pictureBoxMov1_Click(object sender, EventArgs e)
        {
            if (labelNombreMov1.Text.Equals("Transformar"))
            {
                turnos(19);
            }
            else
            {
                if (movPosible(0))
                {
                    turnos(0);
                }
            }
        }

        private void pictureBoxMov2_Click(object sender, EventArgs e)
        {
            if (movPosible(1))
            {
                turnos(1);
            }
        }

        private void pictureBoxMov3_Click(object sender, EventArgs e)
        {
            if (movPosible(2))
            {
                turnos(2);
            }
        }

        private void pictureBoxConfirmarCambio_Click(object sender, EventArgs e)
        {
            if (pictureBoxConfirmarCambio.Enabled)
            {
                if (PKM1Muerto)
                {
                    pokemon1 = P1.cambiarPKM(IndexPKM);
                    actualizarInfo(pokemon1);
                    displayAnim(0, pictureBoxPKM1);
                    panelCambioPKM.Visible = false;
                    labelInfo.Text = pokemon1.getNombre() + " ha entrado en batalla.";
                    return;
                }

                if (PKM2Muerto)
                {
                    pokemon2 = P2.cambiarPKM(IndexPKM);
                    actualizarInfo(pokemon2);
                    displayAnim(0, pictureBoxPKM2);
                    panelCambioPKM.Visible = false;
                    labelInfo.Text = pokemon2.getNombre() + " ha entrado en batalla.";
                    return;
                }

                panelCambioPKM.Visible = false;
                turnos(IndexPKM+13);
                pictureBoxConfirmarCambio.Enabled = false;
                pictureBoxConfirmarCambio.Visible = false;
            }
        }

        private void pictureBoxRendirse_Click(object sender, EventArgs e)
        {
            panelRendirse.Visible = true;
            panelCambioPKM.Visible = false;
            panelBolsa.Visible = false;
        }

        private void pictureBoxNoRendirse_Click(object sender, EventArgs e)
        {
            panelRendirse.Visible = false;
        }

        private void pictureBoxSiRendirse_Click(object sender, EventArgs e)
        {
            if (jugadores.verInicio().Equals(P1))
            {
                ganador = P2;
            }
            else
            {
                ganador = P1;
            }
            panelRendirse.Visible = false;
            panelGanador.Visible = true;
            labelGanador.Text = "¡Felicidades " + ganador.getNombre() + ", ganaste el combate!";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;

            if (animacion == 0)
            {
                switch (count)
                {
                    case 4:
                        pictureBoxPokeBall.Visible = false;
                        pictureBoxBlueSpark.Visible = true;
                        break;
                    case 7:
                        pictureBoxBlueSpark.Visible = false;

                        if (!PKM1Muerto && !PKM2Muerto)
                        {
                            if (PKMCambiado.Equals(pictureBoxPKM1))
                            {
                                pictureBoxPKM1.Visible = true;
                            }
                            else
                            {
                                pictureBoxPKM2.Visible = true;
                            }

                            if (!P1.GetTurno().estaActivo())
                            {
                                actualizarInfo(pokemon1);
                                return;
                            }

                            if (!P2.GetTurno().estaActivo())
                            {
                                actualizarInfo(pokemon2);
                                return;
                            }
                        }
                        else
                        {
                            if (PKM1Muerto)
                            {
                                pictureBoxPKM1.Visible = true;
                                actualizarMovimientos(pokemon1);
                            }
                            else
                            {
                                pictureBoxPKM2.Visible = true;
                            }
                        }
                        break;
                    case 9:
                        count = 0;
                        timer.Stop();

                        if (!PKM1Muerto && !PKM2Muerto)
                        {
                            if (!P1.GetTurno().estaActivo())
                            {
                                if (!segundoRealizado)
                                {
                                    segundoRealizado = true;
                                }
                                accion(P1, P1.GetTurno().getAccion(), pictureBoxPKM1, pictureBoxPKM2);
                                actualizarInfo(pokemon1);
                                return;
                            }

                            if (!P2.GetTurno().estaActivo())
                            {
                                if (!segundoRealizado)
                                {
                                    segundoRealizado = true;
                                }
                                accion(P2, P2.GetTurno().getAccion(), pictureBoxPKM2, pictureBoxPKM1);
                                actualizarInfo(pokemon2);
                                return;
                            }

                        }
                        else
                        {
                            if (PKM1Muerto)
                            {
                                PKM1Muerto = false;
                            }
                            else
                            {
                                PKM2Muerto = false;
                            }
                            pictureBoxXPKM.Enabled = true;
                            panelOpciones.Visible = true;
                        }

                        if (segundoRealizado)
                        {
                            panelOpciones.Visible = true;
                            labelInfo.Text = "Turno de " + P1.getNombre() + ".";
                        }
                        break;
                }
            }
            else
            {
                switch (count)
                {
                    case 2:
                        pictureBoxEffect.Visible = false;
                        break;
                    case 5:
                        count = 0;
                        timer.Stop();


                        if (!finalizar())
                        {
                            if ((pokemon2.getHP(2) == 0) || (pokemon1.getHP(2) == 0))
                            {
                                pictureBoxXPKM.Enabled = false;

                                tableLayoutPanel12.Visible = false;

                                labelNombreMov1Cambio.Visible = false;
                                labelUsos1Cambio.Visible = false;

                                labelNombreMov2Cambio.Visible = false;
                                labelUsos2Cambio.Visible = false;

                                labelNombreMov3Cambio.Visible = false;
                                labelUsos3Cambio.Visible = false;

                                labelNombreMov4Cambio.Visible = false;
                                labelUsos4Cambio.Visible = false;
                            }

                            if (pokemon2.getHP(2) == 0)
                            {
                                PKM2Muerto = true;
                                P2.GetTurno().setActivo(true);
                                actualizarInfoCambios(P2);
                                panelOpciones.Visible = false;
                                panelCambioPKM.Visible = true;
                            }

                            if (pokemon1.getHP(2) == 0)
                            {
                                PKM1Muerto = true;
                                P1.GetTurno().setActivo(true);
                                actualizarInfoCambios(P1);
                                panelOpciones.Visible = false;
                                panelCambioPKM.Visible = true;
                            }

                            if (!PKM1Muerto && !PKM2Muerto)
                            {
                                if (!P1.GetTurno().estaActivo())
                                {
                                    if (!segundoRealizado)
                                    {
                                        segundoRealizado = true;
                                    }
                                    accion(P1, P1.GetTurno().getAccion(), pictureBoxPKM1, pictureBoxPKM2);
                                    return;
                                }
                                if (!P2.GetTurno().estaActivo())
                                {
                                    if (!segundoRealizado)
                                    {
                                        segundoRealizado = true;
                                    }
                                    accion(P2, P2.GetTurno().getAccion(), pictureBoxPKM2, pictureBoxPKM1);
                                    return;
                                }

                                if (segundoRealizado)
                                {
                                    panelOpciones.Visible = true;
                                    labelInfo.Text = "Turno de " + P1.getNombre() + ".";
                                }
                            }
                            else
                            {
                                if (PKM1Muerto)
                                {
                                    actualizarInfo(pokemon1);
                                    pictureBoxPKM1.Visible = true;
                                }
                                if (PKM2Muerto)
                                {
                                    actualizarInfo(pokemon2);
                                    pictureBoxPKM2.Visible = true;
                                }
                            }
                        }
                        break;
                }
            }
        }

        public void accion(jugador p, int op, PictureBox PB, PictureBox PBRival)
        {
            if (p.Equals(P1))
            {
                labelInfo.Text = P1.GetTurno().usarTurno(pokemon1, pokemon2, op, r, pictureBoxPKM1);
                if ((pokemon1.getEstadoAlterado() != 0) && ((pokemon1.getEstadoAlterado() == 2) || (pokemon1.getEstadoAlterado() == 5)))
                {
                    pokemon1.setHP(pokemon1.getHP(2) - pokemon1.getHP(1) / 16, 2);
                }
            }
            else
            {
                labelInfo.Text = P2.GetTurno().usarTurno(pokemon2, pokemon1, op, r, pictureBoxPKM2);
                if ((pokemon2.getEstadoAlterado() != 0) && ((pokemon2.getEstadoAlterado() == 2) || (pokemon2.getEstadoAlterado() == 5)))
                {
                    pokemon2.setHP(pokemon2.getHP(2) - pokemon2.getHP(1) / 16, 2);
                }
            }

            p.GetTurno().setActivo(true);

            switch (op)
            {
                case 0: case 1: case 2: case 3:
                    if (p.Equals(P1))
                    {
                        displayAnim(tipo.determinarTipo(pokemon1.getMovimientos()[op].getTipo().getNombre()) + 2, PBRival);
                        actualizarInfo(pokemon2);
                    }
                    else
                    {
                        displayAnim(tipo.determinarTipo(pokemon2.getMovimientos()[op].getTipo().getNombre()) + 2, PBRival);
                        actualizarInfo(pokemon1);
                    }
                    break;
                case 4: case 5: case 6: case 7: case 8: case 9: case 10: case 11: case 12:
                    displayAnim(1, PB);
                    actualizarInfo(pokemon1);
                    actualizarInfo(pokemon2);
                    break;
                case 13: case 14: case 15: case 16: case 17: case 18:
                    PKMCambiado = PB;
                    displayAnim(0, PB);
                    actualizarInfo(pokemon1);
                    actualizarInfo(pokemon2);
                    break;
                case 19:
                    actualizarInfo(pokemon1);
                    actualizarInfo(pokemon2);
                    displayAnim(1, PB);
                    break;
            }

            if (jugadores.verInicio().Equals(P1))
            {
                actualizarMovimientos(pokemon1);
            }
            else
            {
                actualizarMovimientos(pokemon2);
            }

            switch (pokemon1.getEstadoAlterado())
            {
                case 0:
                    labelNombrePKM1.BackColor = Color.Transparent;
                    break;
                case 1:
                    labelNombrePKM1.BackColor = Color.Yellow;
                    break;
                case 2:
                    labelNombrePKM1.BackColor = Color.Orange;
                    break;
                case 3:
                    labelNombrePKM1.BackColor = Color.LightGray;
                    break;
                case 4:
                    labelNombrePKM1.BackColor = Color.LightBlue;
                    break;
                case 5:
                    labelNombrePKM1.BackColor = Color.MediumPurple;
                    break;
            }

            switch (pokemon2.getEstadoAlterado())
            {
                case 0:
                    labelNombrePKM2.BackColor = Color.Transparent;
                    break;
                case 1:
                    labelNombrePKM2.BackColor = Color.Yellow;
                    break;
                case 2:
                    labelNombrePKM2.BackColor = Color.Orange;
                    break;
                case 3:
                    labelNombrePKM2.BackColor = Color.LightGray;
                    break;
                case 4:
                    labelNombrePKM2.BackColor = Color.LightBlue;
                    break;
                case 5:
                    labelNombrePKM2.BackColor = Color.MediumPurple;
                    break;
            }
        }

        public bool finalizar()
        {
            if (!P1.quedaPKMVivo())
            {
                ganador = P2;
            }

            if (!P2.quedaPKMVivo())
            {
                ganador = P1;
            }

            if (ganador != null)
            {
                panelGanador.Visible = true;
                labelGanador.Text = "¡Felicidades " + ganador.getNombre() + ", ganaste el combate!";
                return true;
            }
            else
            {
                return false;
            }
        }

        private void pictureBoxMov4_Click(object sender, EventArgs e)
        {
            if (movPosible(3))
            {
                turnos(3);
            }
        }

        private void buttonGanador_Click(object sender, EventArgs e)
        {
            P1.setPJugadas(P1.getPJugadas() + 1);
            P2.setPJugadas(P2.getPJugadas() + 1);
            ganador.setPGanadas(ganador.getPGanadas() + 1);
            if (FormSeleccionarEquipo.torneo)
            {
                ganador.setTGanados(ganador.getTGanados() + 1);
                FLL.batallaActual.setValorJugador(ganador);
                FLL.Visible = true;

                P1.resetDitto();
                P2.resetDitto();
            }
            else
            {
                P1.setPokemones(new pokemon[6]);
                P2.setPokemones(new pokemon[6]);
                formMenuPrincipal FMP = new formMenuPrincipal();
                FMP.Visible = true;
            }
            jugadores.sacarJugadorDeLaCola();
            jugadores.sacarJugadorDeLaCola();
            exitForm = true;
            this.Close();
        }
    }
}
