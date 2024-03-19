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
    public partial class formBatalla : Form
    {
        bool exitForm = false;
        pokemon pokemon1 = formInicio.arrPKM[0];
        pokemon pokemon2 = formInicio.arrPKM[24];
        pila[] bolsaP1 = new pila[9];
        pila[] bolsaP2 = new pila[9];

        public formBatalla()
        {
            for (int i = 0; i < 9; i++)
            {
                bolsaP1[i] = new pila();
                bolsaP2[i] = new pila();

                switch (i+1)
                {
                    case 1:
                        for (int j = 0; j < 5; j++)
                        {
                            bolsaP1[i].agregarPocionEnLaPila(new pocion());
                            bolsaP2[i].agregarPocionEnLaPila(new pocion());
                        }
                        break;
                    case 2:
                        for (int j = 0; j < 5; j++)
                        {
                            bolsaP1[i].agregarSuperPocionEnLaPila(new superPocion());
                            bolsaP2[i].agregarSuperPocionEnLaPila(new superPocion());
                        }
                        break;
                    case 3:
                        for (int j = 0; j < 5; j++)
                        {
                            bolsaP1[i].agregarHiperPocionEnLaPila(new hiperPocion());
                            bolsaP2[i].agregarHiperPocionEnLaPila(new hiperPocion());
                        }
                        break;
                    case 4:
                        for (int j = 0; j < 5; j++)
                        {
                            bolsaP1[i].agregarAntiParalisisEnLaPila(new antiParalisis());
                            bolsaP2[i].agregarAntiParalisisEnLaPila(new antiParalisis());
                        }
                        break;
                    case 5:
                        for (int j = 0; j < 5; j++)
                        {
                            bolsaP1[i].agregarAntidotoEnLaPila(new antidoto());
                            bolsaP2[i].agregarAntidotoEnLaPila(new antidoto());
                        }
                        break;
                    case 6:
                        for (int j = 0; j < 5; j++)
                        {
                            bolsaP1[i].agregarDespertarEnLaPila(new despertar());
                            bolsaP2[i].agregarDespertarEnLaPila(new despertar());
                        }
                        break;
                    case 7:
                        for (int j = 0; j < 5; j++)
                        {
                            bolsaP1[i].agregarCuraTotalEnLaPila(new curaTotal());
                            bolsaP2[i].agregarCuraTotalEnLaPila(new curaTotal());
                        }
                        break;
                    case 8:
                        for (int j = 0; j < 5; j++)
                        {
                            bolsaP1[i].agregarMaxPocionEnLaPila(new maxPocion());
                            bolsaP2[i].agregarMaxPocionEnLaPila(new maxPocion());
                        }
                        break;
                    case 9:
                        for (int j = 0; j < 5; j++)
                        {
                            bolsaP1[i].agregarPrecisionXEnLaPila(new precisionX());
                            bolsaP2[i].agregarPrecisionXEnLaPila(new precisionX());
                        }
                        break;
                    default:
                        Console.WriteLine("EEEEEEEERRRRRRRRRRRRRROOOOOOOOOOOOOOOOOOOOOOOR");
                        break;
                }
            }

            pokemon1.setMovimiento(new movimiento(0, "Ataque Brutal", formInicio.arrTipos[0], 16), 0);
            pokemon1.setMovimiento(new movimiento(0, "Ataque Loco", formInicio.arrTipos[1], 16), 1);
            pokemon1.setMovimiento(new movimiento(0, "Ataque Arrecho", formInicio.arrTipos[2], 16), 2);
            pokemon1.setMovimiento(new movimiento(0, "Ataque ALL OUT", formInicio.arrTipos[3], 16), 3);
            //{ Width = 889, Height = 500}
            //{ Width = 1111, Height = 594}
            InitializeComponent();
            tableLayoutPanel1.Visible = false;
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
            asignarImagenPKM1(pokemon1);
            asignarImagenPKM2(pokemon2);
            Console.WriteLine(this.Size);

            //SE LLENA INFO DE POKEMONES
            actualizarInfo(pokemon1, pokemon2);

            panelMovimientos.Parent = fondo;
            panelMovimientos.Location = new Point(630, 156);
            labelNombreMov1.Parent = pictureBoxMov1;
            labelNombreMov1.Size = new Size(120, 47);
            labelNombreMov1.Location = new Point(50, 14);
            labelNombreMov2.Parent = pictureBoxMov2;
            labelNombreMov2.Size = new Size(120, 47);
            labelNombreMov2.Location = new Point(50, 14);
            labelNombreMov3.Parent = pictureBoxMov3;
            labelNombreMov3.Size = new Size(120, 47);
            labelNombreMov3.Location = new Point(50, 14);
            labelNombreMov4.Parent = pictureBoxMov4;
            labelNombreMov4.Size = new Size(120, 47);
            labelNombreMov4.Location = new Point(50, 14);
            labelUsos1.Parent = pictureBoxMov1;
            labelUsos1.Size = new Size(47, 47);
            labelUsos1.Location = new Point(180, 14);
            labelUsos2.Parent = pictureBoxMov2;
            labelUsos2.Size = new Size(47, 47);
            labelUsos2.Location = new Point(180, 14);
            labelUsos3.Parent = pictureBoxMov3;
            labelUsos3.Size = new Size(47, 47);
            labelUsos3.Location = new Point(180, 14);
            labelUsos4.Parent = pictureBoxMov4;
            labelUsos4.Size = new Size(47, 47);
            labelUsos4.Location = new Point(180, 14);
            actualizarMovimientos(pokemon1);
            Console.WriteLine(panelOpciones.Location);

            labelNombreObj1.Parent = pictureBoxObj1;
            labelNombreObj1.Size = pictureBoxObj1.Size;
            labelNombreObj1.Location = new Point(0, 0);
        }

        public void asignarImagenPKM2(pokemon PKM)
        {
            pictureBoxPKM2.Image = PKM.getImg()[0];
            pictureBoxPKM2.Size = new Size(pictureBoxPKM2.Image.Width * 2, pictureBoxPKM2.Image.Height * 2);
            pictureBoxPKM2.Location = new Point(595 - pictureBoxPKM2.Width, 360 - pictureBoxPKM2.Height);
        }

        public void asignarImagenPKM1(pokemon PKM)
        {
            pictureBoxPKM1.Image = PKM.getImg()[1];
            pictureBoxPKM1.Size = new Size(pictureBoxPKM1.Image.Width * 2, pictureBoxPKM1.Image.Height * 2);
            pictureBoxPKM1.Location = new Point(75, 400 - pictureBoxPKM1.Height);
        }

        public void actualizarMovimientos(pokemon PKM)
        {
            asignarImagenTipoMovimiento(PKM.getMovimientos(0), pictureBoxMov1);
            labelNombreMov1.Text = PKM.getMovimientos(0).getNombre();
            labelUsos1.Text = PKM.getMovimientos(0).getUsos(1) + "/" + PKM.getMovimientos(0).getUsos(0);
            asignarImagenTipoMovimiento(PKM.getMovimientos(1), pictureBoxMov2);
            labelNombreMov2.Text = PKM.getMovimientos(1).getNombre();
            labelUsos2.Text = PKM.getMovimientos(1).getUsos(1) + "/" + PKM.getMovimientos(1).getUsos(0);
            asignarImagenTipoMovimiento(PKM.getMovimientos(2), pictureBoxMov3);
            labelNombreMov3.Text = PKM.getMovimientos(2).getNombre();
            labelUsos3.Text = PKM.getMovimientos(2).getUsos(1) + "/" + PKM.getMovimientos(1).getUsos(0);
            asignarImagenTipoMovimiento(PKM.getMovimientos(3), pictureBoxMov4);
            labelNombreMov4.Text = PKM.getMovimientos(3).getNombre();
            labelUsos4.Text = PKM.getMovimientos(3).getUsos(1) + "/" + PKM.getMovimientos(1).getUsos(0);
        }

        public void asignarImagenTipoMovimiento(movimiento move, PictureBox PB)
        {
            switch (move.getTipo().getNombre())
            {
                case "Normal":
                    PB.Image = Properties.Resources.MovNormal;
                    break;
                case "Fuego":
                    PB.Image = Properties.Resources.MovFuego;
                    break;
                case "Agua":
                    PB.Image = Properties.Resources.MovAgua;
                    break;
                case "Volador":
                    PB.Image = Properties.Resources.MovVolador;
                    break;
                case "Planta":
                    PB.Image = Properties.Resources.MovPlanta;
                    break;
                case "Bicho":
                    PB.Image = Properties.Resources.MovBicho;
                    break;
                case "Eléctrico":
                    PB.Image = Properties.Resources.MovElectrico;
                    break;
                case "Psíquico":
                    PB.Image = Properties.Resources.MovPsiquico;
                    break;
                case "Veneno":
                    PB.Image = Properties.Resources.MovVeneno;
                    break;
                case "Tierra":
                    PB.Image = Properties.Resources.MovTierra;
                    break;
                case "Roca":
                    PB.Image = Properties.Resources.MovRoca;
                    break;
                case "Hielo":
                    PB.Image = Properties.Resources.MovHielo;
                    break;
                case "Lucha":
                    PB.Image = Properties.Resources.MovLucha;
                    break;
                case "Dragón":
                    PB.Image = Properties.Resources.MovDragon;
                    break;
                case "Fantasma":
                    PB.Image = Properties.Resources.MovFantasma;
                    break;
                case "Acero":
                    PB.Image = Properties.Resources.MovAcero;
                    break;
                case "Hada":
                    PB.Image = Properties.Resources.MovHada;
                    break;
                default:
                    Console.WriteLine("EEEEERROOOOOOOOOOOOOOOOOOOOOOOOOR");
                    break;
            }
        }

        public void actualizarInfo(pokemon PKM1, pokemon PKM2)
        {
            //Pokemon 1
            labelNombrePKM1.Text = PKM1.getNombre();
            labelHpPKM1.Text = "HP: " + PKM1.getHP(2) + "/" + PKM1.getHP(1);
            labelNvlPKM1.Text = "Nvl: " + PKM1.getNivel();
            barraHpPKM1.Value = (PKM1.getHP(2) / PKM1.getHP(1)) * 100;
            
            /*if (barraHpPKM1.Value > 50)
            {
                barraHpPKM1.ForeColor = Color.Green;
            }
            else
            {
                if (barraHpPKM1.Value > 20)
                {
                    barraHpPKM1.ForeColor = Color.PapayaWhip;
                }
                else
                {
                    barraHpPKM1.ForeColor = Color.Red;
                }
            }*/

            //Pokemon 2
            labelNombrePKM2.Text = PKM2.getNombre();
            labelHpPKM2.Text = "HP: " + PKM2.getHP(2) + "/" + PKM2.getHP(1);
            labelNvlPKM2.Text = "Nvl: " + PKM2.getNivel();
            barraHpPKM2.Value = (PKM2.getHP(2) / PKM2.getHP(1)) * 100;
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
            panelOpciones.Visible = false;
            panelMovimientos.Visible = true;
        }

        private void pictureBoxMovVolver_MouseHover(object sender, EventArgs e)
        {
            
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
    }
}
