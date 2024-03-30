using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Pokemon
{
    public partial class FormSeleccionarEquipo : Form
    {
        private formInicio fInicio;
        bool exitForm = false;
        public static jugador Jugador_1;
        public static jugador Jugador_2;
        private lista listaPokemonDisponibles;
        public static lista equipoJugador1 = new lista();
        public static lista equipoJugador2 = new lista();
        private int cantidadPorPagina = 20;
        private int paginaActual = 1;
        private pokemon[] arrPKM;
        private pokemon pokemonSeleccionado;
        private bool hayPokemonSeleccionado = false;
        public static bool elegirEquipoJugador1 = true;

        public FormSeleccionarEquipo()
        {
            fInicio = new formInicio();
            Jugador_1 = new jugador(1, "Jugador 1", 0, 0, 0);
            Jugador_2 = new jugador(2, "Jugador 2", 0, 0, 0);
            InitializeComponent();
            arrPKM = formInicio.arrPKM;
            listaPokemonDisponibles = CargarPokemonDisponibles();
            MostrarPokemonDisponibles();
        }
        private lista CargarPokemonDisponibles()
        {
            lista pokemones = new lista();
            int indiceInicial = (paginaActual - 1) * cantidadPorPagina;
            int indiceFinal = Math.Min(indiceInicial + cantidadPorPagina, arrPKM.Length);
            for (int i = indiceInicial; i < indiceFinal; i++)
            {
                pokemon nuevoPokemon = arrPKM[i];
                pokemones.agregarPokemonAlFinal(nuevoPokemon);
            }
            return pokemones;
        }

        private void MostrarPokemonDisponibles()
        {
            flowLayoutPanelPokemones.Controls.Clear();

            foreach (pokemon pokemon in listaPokemonDisponibles)
            {
                int idPokemon = pokemon.getID();
                
                Image imagenOriginal = pokemon.getImg()[2];

                int nuevoAncho = 120;
                int nuevoAlto = 110;
                Image imagenReescalada = new Bitmap(imagenOriginal, nuevoAncho, nuevoAlto);

                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = imagenReescalada;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Width = nuevoAncho;
                pictureBox.Height = nuevoAlto;

                Label label = new Label();
                label.Text = pokemon.getNombre();
                label.TextAlign = ContentAlignment.MiddleCenter;

                Panel panel = new Panel();
                panel.Controls.Add(pictureBox);
                panel.Controls.Add(label);
                panel.Width = 120;
                panel.Height = 115;
                panel.BorderStyle = BorderStyle.None;
                panel.BackColor = Color.Transparent;

                flowLayoutPanelPokemones.Controls.Add(panel);

                pictureBox.Click += (sender, e) =>
                {
                    LimpiarEtiquetasDeTipo(pictureBoxTipo1);
                    LimpiarEtiquetasDeTipo(pictureBoxTipo2);
                    OcultarTiposPokemon(pictureBoxTipo1, pictureBoxTipo2);
                        // Actualizar el Pokémon seleccionado solo cuando se hace clic en un PictureBox
                        hayPokemonSeleccionado = true;
                    pokemonSeleccionado = pokemon;

                        // Resaltar visualmente el Pokémon seleccionado
                        ResaltarPokemonSeleccionado((PictureBox)sender);

                        // Actualizar la información y tipos mostrados (opcional)
                        labelNombre.Visible = true;
                    labelNombre.Text = pokemonSeleccionado.getNombre();
                    MostrarTiposPokemon(pokemonSeleccionado, pictureBoxTipo1, pictureBoxTipo2);
                    MostrarGIF(pokemonSeleccionado);
                };


                pictureBox.MouseEnter += (sender, e) =>
                {
                    if (!hayPokemonSeleccionado)
                    {
                        labelNombre.Text = pokemon.getNombre();
                        labelNombre.Visible = true;
                        MostrarTiposPokemon(pokemon, pictureBoxTipo1, pictureBoxTipo2);
                        MostrarGIF(pokemon);
                    }
                };

                pictureBox.MouseLeave += (sender, e) =>
                {
                    if (!hayPokemonSeleccionado)
                    {
                        OcultarGIF();
                        labelNombre.Visible = false;
                        LimpiarEtiquetasDeTipo(pictureBoxTipo1);
                        LimpiarEtiquetasDeTipo(pictureBoxTipo2);
                        OcultarTiposPokemon(pictureBoxTipo1, pictureBoxTipo2);
                    }
                };
            }
        }

        //  verificar si un equipo está lleno
        private bool equipoLleno(lista listaPokemon)
        {
            if (listaPokemon.getTamanio() == 6)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //  verificar si un Pokémon está en un equipo
        private bool pokemonEnEquipo(lista equipoPokemon, pokemon pokemonSeleccionado)
        {
            foreach (pokemon p in equipoPokemon)
            {
                if (p != null && pokemonSeleccionado != null && p.getID() == pokemonSeleccionado.getID())
                {
                    return true;
                }
            }
            return false;
        }

        //  agregar un Pokémon al equipo de un jugador
        private void AgregarPokemonAlEquipo(jugador jugador, pokemon pokemonSeleccionado)
        {
            for (int i = 0; i < jugador.getPokemones().Length; i++)
            {
                if (jugador.getPokemones()[i] == null)
                {
                    jugador.getPokemones()[i] = pokemonSeleccionado;
                    break;
                }
            }
        }

        private void MostrarGIF(pokemon pokemon)
        {
            pictureBoxGIF.Image = pokemon.getImg()[0];
            pictureBoxGIF.Size = new Size(pictureBoxGIF.Image.Width * 2, pictureBoxGIF.Image.Height * 2);
            pictureBoxGIF.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxGIF.Visible = true;
        }

        private void MostrarTiposPokemon(pokemon pokemon, PictureBox pictureBoxTipo1, PictureBox pictureBoxTipo2)
        {
            LimpiarEtiquetasDeTipo(pictureBoxTipo1);
            LimpiarEtiquetasDeTipo(pictureBoxTipo2);
            int cantidadTipos = pokemon.getTipos().getTamanio();
            if (cantidadTipos >= 1)
            {
                tipo tipo1 = pokemon.getTipos().getInicio().getValorTipo();
                tipo.asignarImagenTipo(tipo1, pictureBoxTipo1);
                pictureBoxTipo1.Visible = true;
                AgregarTextoATipoPictureBox(pictureBoxTipo1, tipo1.getNombre());
            }
            if (cantidadTipos >= 2)
            {
                tipo tipo2 = pokemon.getTipos().getInicio().getSiguiente().getValorTipo();
                tipo.asignarImagenTipo(tipo2, pictureBoxTipo2);
                pictureBoxTipo2.Visible = true;
                AgregarTextoATipoPictureBox(pictureBoxTipo2, tipo2.getNombre());
            }
        }

        private void LimpiarEtiquetasDeTipo(PictureBox pictureBox)
        {
            foreach (Control control in pictureBox.Controls)
            {
                if (control is Label)
                {
                    pictureBox.Controls.Remove(control);
                    control.Dispose();
                }
            }
        }

        private void AgregarTextoATipoPictureBox(PictureBox pictureBox, string tipoNombre)
        {
            Label labelTipo = new Label();

            labelTipo.Text = tipoNombre;
            labelTipo.ForeColor = Color.Black;
            labelTipo.BackColor = Color.Transparent;
            labelTipo.Font = new Font("Arial", 12, FontStyle.Bold);

            labelTipo.AutoSize = true;
            labelTipo.TextAlign = ContentAlignment.MiddleCenter;

            labelTipo.Location = new Point((pictureBox.Width - labelTipo.Width) - 20, ((pictureBox.Height - labelTipo.Height) / 2) + 1);

            pictureBox.Controls.Add(labelTipo);
        }

        private void OcultarGIF()
        {
            pictureBoxGIF.Visible = false;
        }
        private void OcultarTiposPokemon(PictureBox pictureBoxTipo, PictureBox pictureBoxtipo2)
        {
            pictureBoxTipo1.Visible = false;
            pictureBoxTipo2.Visible = false;
            LimpiarEtiquetasDeTipo(pictureBoxTipo1);
            LimpiarEtiquetasDeTipo(pictureBoxTipo2);
        }
        private void btnPaginaSiguiente_Click(object sender, EventArgs e)
        {
            int totalDePokemon = 151;
            int totalDePaginas = (int)Math.Ceiling((double)totalDePokemon / cantidadPorPagina);

            if (paginaActual < totalDePaginas)
            {
                paginaActual++;
                listaPokemonDisponibles = CargarPokemonDisponibles();
                MostrarPokemonDisponibles();
            }
            else
            {
                paginaActual = 1;
                listaPokemonDisponibles = CargarPokemonDisponibles();
                MostrarPokemonDisponibles();
            }
        }

        private void btnPaginaAnterior_Click(object sender, EventArgs e)
        {
            int totalDePokemon = 151;
            int totalDePaginas = (int)Math.Ceiling((double)totalDePokemon / cantidadPorPagina);
            if (paginaActual > 1)
            {
                paginaActual--;
                listaPokemonDisponibles = CargarPokemonDisponibles();
                MostrarPokemonDisponibles();
            }
            else
            {
                paginaActual = totalDePaginas;
                listaPokemonDisponibles = CargarPokemonDisponibles();
                MostrarPokemonDisponibles();
            }
        }

        private void btnCerrarCaja_Click(object sender, EventArgs e)
        {
            if (equipoLleno(equipoJugador1) && equipoLleno(equipoJugador2))
            {
                MessageBox.Show("¡Tu equipo ha sido guardado!");
                Jugador_1.setPokemones(equipoJugador1.getArrayPokemones());
                Jugador_2.setPokemones(equipoJugador2.getArrayPokemones());
                Console.WriteLine("Pokemones jugador 1:");
                foreach (var pokemon in Jugador_1.getPokemones())
                {
                    if (pokemon != null)
                    {
                        Console.WriteLine(pokemon.getNombre());
                    }
                }

                Console.WriteLine("Pokemones jugador 2:");
                foreach (var pokemon in Jugador_2.getPokemones())
                {
                    if (pokemon != null)
                    {

                        Console.WriteLine(pokemon.getNombre());
                    }
                }
                formBatalla FB = new formBatalla();
                FB.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("¡No puedes guardar tu equipo si no has elegido 6 pokemones!");
                return;
            }
        }


        private void FormSeleccionarEquipo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!exitForm)
            {
                Application.Exit();
            }
        }

        private void ResaltarPokemonSeleccionado(PictureBox pictureBox)
        {
            foreach (Control control in flowLayoutPanelPokemones.Controls)
            {
                if (control is Panel)
                {
                    foreach (Control innerControl in control.Controls)
                    {
                        if (innerControl is PictureBox)
                        {
                            PictureBox innerPictureBox = (PictureBox)innerControl;
                            if (innerPictureBox.Equals(pictureBox))
                            {
                                control.BackColor = Color.LightBlue; // Color de resaltado
                            }
                            else
                            {
                                control.BackColor = Color.Transparent; // Restaurar el color transparente para otros Pokémon
                            }
                        }
                    }
                }
            }
        }

        private void btnEquipoPokemon_Click(object sender, EventArgs e)
        {
            if (pokemonSeleccionado == null)
            {
                MessageBox.Show("Selecciona un Pokémon antes de agregarlo al equipo.");
                return;
            }

            if (elegirEquipoJugador1 && pokemonEnEquipo(equipoJugador1, pokemonSeleccionado))
            {
                MessageBox.Show("¡Este Pokémon ya está en un equipo!");
                return;
            }
            if (!elegirEquipoJugador1 && pokemonEnEquipo(equipoJugador2, pokemonSeleccionado))
            {
                MessageBox.Show("¡Este Pokémon ya está en un equipo!");
                return;
            }

            // Verificar si el equipo del Jugador 1 está lleno
            if (!equipoLleno(equipoJugador1) && elegirEquipoJugador1)
            {
                equipoJugador1.agregarPokemonAlFinal(pokemonSeleccionado.crearCopiaPKM());
                MessageBox.Show($"¡{pokemonSeleccionado.getNombre()} ha sido agregado al equipo del Jugador 1!");

                // Verificar si el equipo del Jugador 1 ahora está lleno
                if (equipoLleno(equipoJugador1))
                {
                    MessageBox.Show("¡El equipo del Jugador 1 está completo! Ahora es el turno del Jugador 2.");
                    elegirEquipoJugador1 = false; // Cambiar al turno del Jugador 2
                }
            }
            // Verificar si el equipo del Jugador 2 está lleno
            else if (!equipoLleno(equipoJugador2) && !elegirEquipoJugador1)
            {
                equipoJugador2.agregarPokemonAlFinal(pokemonSeleccionado.crearCopiaPKM());
                MessageBox.Show($"¡{pokemonSeleccionado.getNombre()} ha sido agregado al equipo del Jugador 2!");

                // Verificar si el equipo del Jugador 2 ahora está lleno
                if (equipoLleno(equipoJugador2))
                {
                    MessageBox.Show("¡Ambos equipos están completos! Ahora puedes cerrar la caja");
                    elegirEquipoJugador1 = true; // Cambiar al turno del Jugador 1
                }
            }
            else
            {
                MessageBox.Show("¡El equipo está lleno! No puedes agregar más Pokémon.");
                return;
            }

            // Limpiar la selección del Pokémon
            LimpiarSeleccionPokemon();
        }

        private void LimpiarSeleccionPokemon()
        {
            pokemonSeleccionado = null;
            hayPokemonSeleccionado = false;
            // Restaurar el color transparente para todos los Pokémon
            foreach (Control control in flowLayoutPanelPokemones.Controls)
            {
                if (control is Panel)
                {
                    control.BackColor = Color.Transparent;
                }
            }
            LimpiarEtiquetasDeTipo(pictureBoxTipo1);
            LimpiarEtiquetasDeTipo(pictureBoxTipo2);
            OcultarTiposPokemon(pictureBoxTipo1, pictureBoxTipo2);
        }
    }
}