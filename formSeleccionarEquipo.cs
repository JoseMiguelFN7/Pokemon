using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Pokemon
{
    public partial class FormSeleccionarEquipo : Form
    {
        public static jugador Jugador_1;
        public static jugador Jugador_2;
        private lista listaPokemonDisponibles;
        private int cantidadPorPagina = 20;
        private int paginaActual = 1;
        public FormSeleccionarEquipo()
        {
            Jugador_1 = new jugador(1, "Jugador 1",0,0,0);
            Jugador_2 = new jugador(2, "Jugador 2", 0, 0, 0);
            InitializeComponent();
            listaPokemonDisponibles = CargarPokemonDisponibles();
            MostrarPokemonDisponibles();
        }
        private lista CargarPokemonDisponibles()
        {
            lista pokemones = new lista();
            string[] lines = File.ReadAllLines("pokemones.txt");
            int contador = 0;
            int indiceInicial = (paginaActual - 1) * cantidadPorPagina;
            int indiceFinal = Math.Min(indiceInicial + cantidadPorPagina, lines.Length);
            for (int i = indiceInicial; i < indiceFinal; i++)
            {
                string line = lines[i];
                string[] data = line.Split(',');
                if (data.Length == 10)
                {
                    int id = int.Parse(data[0]);
                    string nombre = data[1];
                    int nivel = int.Parse(data[2]);
                    string tipos = data[3];
                    int hp = int.Parse(data[4]);
                    int atk = int.Parse(data[5]);
                    int atks = int.Parse(data[6]);
                    int def = int.Parse(data[7]);
                    int defs = int.Parse(data[8]);
                    int vel = int.Parse(data[9]);

                    pokemon nuevoPokemon = new pokemon(id, nombre, nivel, tipos, hp, atk, atks, def, defs, vel);
                    pokemones.agregarPokemonAlFinal(nuevoPokemon);
                }
                else
                {
                    Console.WriteLine($"Error de formato en la línea: {line}");
                }
                contador++;
            }
            return pokemones;
        }

        private void MostrarPokemonDisponibles()
        {
            flowLayoutPanelPokemones.Controls.Clear(); 

            foreach (pokemon pokemon in listaPokemonDisponibles)
            {
                int idPokemon = pokemon.getID();

                if (File.Exists($"sprites/{idPokemon}.png"))
                {
                    Image imagenOriginal = Image.FromFile($"sprites/{idPokemon}.png");

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
    pokemon pokemonSeleccionado = pokemon;

    // Verificar si ambos equipos están llenos
    if (equipoLleno(Jugador_1) && equipoLleno(Jugador_2))
    {
        MessageBox.Show("¡Ambos equipos están llenos! No puedes agregar más Pokémon.");
        return;
    }

    // Verificar si el Pokémon ya está en alguno de los equipos
    if (pokemonEnEquipo(Jugador_1, pokemonSeleccionado) || pokemonEnEquipo(Jugador_2, pokemonSeleccionado))
    {
        MessageBox.Show("¡Este Pokémon ya está en un equipo!");
        return;
    }

    // Agregar el Pokémon al equipo del Jugador 1
    if (!equipoLleno(Jugador_1))
    {
        AgregarPokemonAlEquipo(Jugador_1, pokemonSeleccionado);
        MessageBox.Show($"¡{pokemonSeleccionado.getNombre()} ha sido agregado al equipo del Jugador 1!");
    }

    // Agregar el Pokémon al equipo del Jugador 2
    if (!equipoLleno(Jugador_2))
    {
        AgregarPokemonAlEquipo(Jugador_2, pokemonSeleccionado);
        MessageBox.Show($"¡{pokemonSeleccionado.getNombre()} ha sido agregado al equipo del Jugador 2!");
    }
};

                    pictureBox.MouseEnter += (sender, e) =>
                    {
                        MostrarTiposPokemon(pokemon, pictureBoxTipo1, pictureBoxTipo2);
                        MostrarGIF(pokemon);
                    };

                    pictureBox.MouseLeave += (sender, e) =>
                    {
                        OcultarGIF();
                        OcultarTiposPokemon(pictureBoxTipo1, pictureBoxTipo2);
                    };
                }
                else
                {
                    Console.WriteLine($"No se encontró el sprite para el Pokémon con ID {idPokemon}");
                }
            }
        }

        // Función para verificar si un equipo está lleno
        private bool equipoLleno(jugador jugador)
        {
            foreach (pokemon p in jugador.getPokemones())
            {
                if (p == null)
                {
                    return false;
                }
            }
            return true;
        }

        // Función para verificar si un Pokémon está en un equipo
        private bool pokemonEnEquipo(jugador jugador, pokemon pokemonSeleccionado)
        {
            foreach (pokemon p in jugador.getPokemones())
            {
                if (p != null && p.getID() == pokemonSeleccionado.getID())
                {
                    return true;
                }
            }
            return false;
        }

        // Función para agregar un Pokémon al equipo de un jugador
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
            int cantidadTipos = pokemon.getTipos().getTamanio();
            if (cantidadTipos == 1)
            {
                tipo tipo1 = pokemon.getTipos().getInicio().getValorTipo();
                switch (tipo1.getNombre())
                {
                    case "Normal":
                        pictureBoxTipo1.Image = Properties.Resources.MovNormal;
                        pictureBoxTipo1.Visible = true;
                        break;
                    case "Fuego":
                        pictureBoxTipo1.Image = Properties.Resources.MovFuego;
                        pictureBoxTipo1.Visible = true;
                        break;
                    case "Agua":
                        pictureBoxTipo1.Image = Properties.Resources.MovAgua;
                        pictureBoxTipo1.Visible = true;
                        break;
                    case "Volador":
                        pictureBoxTipo1.Image = Properties.Resources.MovVolador;
                        pictureBoxTipo1.Visible = true;
                        break;
                    case "Planta":
                        pictureBoxTipo1.Image = Properties.Resources.MovPlanta;
                        pictureBoxTipo1.Visible = true;
                        break;
                    case "Bicho":
                        pictureBoxTipo1.Image = Properties.Resources.MovBicho;
                        pictureBoxTipo1.Visible = true;
                        break;
                    case "Eléctrico":
                        pictureBoxTipo1.Image = Properties.Resources.MovElectrico;
                        pictureBoxTipo1.Visible = true;
                        break;
                    case "Psíquico":
                        pictureBoxTipo1.Image = Properties.Resources.MovPsiquico;
                        pictureBoxTipo1.Visible = true;
                        break;
                    case "Veneno":
                        pictureBoxTipo1.Image = Properties.Resources.MovVeneno;
                        pictureBoxTipo1.Visible = true;
                        break;
                    case "Tierra":
                        pictureBoxTipo1.Image = Properties.Resources.MovTierra;
                        pictureBoxTipo1.Visible = true;
                        break;
                    case "Roca":
                        pictureBoxTipo1.Image = Properties.Resources.MovRoca;
                        pictureBoxTipo1.Visible = true;
                        break;
                    case "Hielo":
                        pictureBoxTipo1.Image = Properties.Resources.MovHielo;
                        pictureBoxTipo1.Visible = true;
                        break;
                    case "Lucha":
                        pictureBoxTipo1.Image = Properties.Resources.MovLucha;
                        pictureBoxTipo1.Visible = true;
                        break;
                    case "Dragón":
                        pictureBoxTipo1.Image = Properties.Resources.MovDragon;
                        pictureBoxTipo1.Visible = true;
                        break;
                    case "Fantasma":
                        pictureBoxTipo1.Image = Properties.Resources.MovFantasma;
                        pictureBoxTipo1.Visible = true;
                        break;
                    case "Acero":
                        pictureBoxTipo1.Image = Properties.Resources.MovAcero;
                        pictureBoxTipo1.Visible = true;
                        break;
                    case "Hada":
                        pictureBoxTipo1.Image = Properties.Resources.MovHada;
                        pictureBoxTipo1.Visible = true;
                        break;
                    default:
                        Console.WriteLine("EEEEERROOOOOOOOOOOOOOOOOOOOOOOOOR");
                        break;
                }
            }
            else if (cantidadTipos == 2)
            {
                tipo tipo1 = pokemon.getTipos().getInicio().getValorTipo();
                tipo tipo2 = pokemon.getTipos().getInicio().getSiguiente().getValorTipo();
                switch (tipo1.getNombre())
                {
                    case "Normal":
                        pictureBoxTipo1.Image = Properties.Resources.MovNormal;
                        pictureBoxTipo1.Visible = true;
                        break;
                    case "Fuego":
                        pictureBoxTipo1.Image = Properties.Resources.MovFuego;
                        pictureBoxTipo1.Visible = true;
                        break;
                    case "Agua":
                        pictureBoxTipo1.Image = Properties.Resources.MovAgua;
                        pictureBoxTipo1.Visible = true;
                        break;
                    case "Volador":
                        pictureBoxTipo1.Image = Properties.Resources.MovVolador;
                        pictureBoxTipo1.Visible = true;
                        break;
                    case "Planta":
                        pictureBoxTipo1.Image = Properties.Resources.MovPlanta;
                        pictureBoxTipo1.Visible = true;
                        break;
                    case "Bicho":
                        pictureBoxTipo1.Image = Properties.Resources.MovBicho;
                        pictureBoxTipo1.Visible = true;
                        break;
                    case "Eléctrico":
                        pictureBoxTipo1.Image = Properties.Resources.MovElectrico;
                        pictureBoxTipo1.Visible = true;
                        break;
                    case "Psíquico":
                        pictureBoxTipo1.Image = Properties.Resources.MovPsiquico;
                        pictureBoxTipo1.Visible = true;
                        break;
                    case "Veneno":
                        pictureBoxTipo1.Image = Properties.Resources.MovVeneno;
                        pictureBoxTipo1.Visible = true;
                        break;
                    case "Tierra":
                        pictureBoxTipo1.Image = Properties.Resources.MovTierra;
                        pictureBoxTipo1.Visible = true;
                        break;
                    case "Roca":
                        pictureBoxTipo1.Image = Properties.Resources.MovRoca;
                        pictureBoxTipo1.Visible = true;
                        break;
                    case "Hielo":
                        pictureBoxTipo1.Image = Properties.Resources.MovHielo;
                        pictureBoxTipo1.Visible = true;
                        break;
                    case "Lucha":
                        pictureBoxTipo1.Image = Properties.Resources.MovLucha;
                        pictureBoxTipo1.Visible = true;
                        break;
                    case "Dragón":
                        pictureBoxTipo1.Image = Properties.Resources.MovDragon;
                        pictureBoxTipo1.Visible = true;
                        break;
                    case "Fantasma":
                        pictureBoxTipo1.Image = Properties.Resources.MovFantasma;
                        pictureBoxTipo1.Visible = true;
                        break;
                    case "Acero":
                        pictureBoxTipo1.Image = Properties.Resources.MovAcero;
                        pictureBoxTipo1.Visible = true;
                        break;
                    case "Hada":
                        pictureBoxTipo1.Image = Properties.Resources.MovHada;
                        pictureBoxTipo1.Visible = true;
                        break;
                    default:
                        Console.WriteLine("EEEEERROOOOOOOOOOOOOOOOOOOOOOOOOR");
                        break;
                }
                switch (tipo2.getNombre())
                {
                    case "Normal":
                        pictureBoxTipo2.Image = Properties.Resources.MovNormal;
                        pictureBoxTipo2.Visible = true;
                        break;
                    case "Fuego":
                        pictureBoxTipo2.Image = Properties.Resources.MovFuego;
                        pictureBoxTipo2.Visible = true;
                        break;
                    case "Agua":
                        pictureBoxTipo2.Image = Properties.Resources.MovAgua;
                        pictureBoxTipo2.Visible = true;
                        break;
                    case "Volador":
                        pictureBoxTipo2.Image = Properties.Resources.MovVolador;
                        pictureBoxTipo2.Visible = true;
                        break;
                    case "Planta":
                        pictureBoxTipo2.Image = Properties.Resources.MovPlanta;
                        pictureBoxTipo2.Visible = true;
                        break;
                    case "Bicho":
                        pictureBoxTipo2.Image = Properties.Resources.MovBicho;
                        pictureBoxTipo2.Visible = true;
                        break;
                    case "Eléctrico":
                        pictureBoxTipo2.Image = Properties.Resources.MovElectrico;
                        pictureBoxTipo2.Visible = true;
                        break;
                    case "Psíquico":
                        pictureBoxTipo2.Image = Properties.Resources.MovPsiquico;
                        pictureBoxTipo2.Visible = true;
                        break;
                    case "Veneno":
                        pictureBoxTipo2.Image = Properties.Resources.MovVeneno;
                        pictureBoxTipo2.Visible = true;
                        break;
                    case "Tierra":
                        pictureBoxTipo2.Image = Properties.Resources.MovTierra;
                        pictureBoxTipo2.Visible = true;
                        break;
                    case "Roca":
                        pictureBoxTipo2.Image = Properties.Resources.MovRoca;
                        pictureBoxTipo2.Visible = true;
                        break;
                    case "Hielo":
                        pictureBoxTipo2.Image = Properties.Resources.MovHielo;
                        pictureBoxTipo2.Visible = true;
                        break;
                    case "Lucha":
                        pictureBoxTipo2.Image = Properties.Resources.MovLucha;
                        pictureBoxTipo2.Visible = true;
                        break;
                    case "Dragón":
                        pictureBoxTipo2.Image = Properties.Resources.MovDragon;
                        pictureBoxTipo2.Visible = true;
                        break;
                    case "Fantasma":
                        pictureBoxTipo2.Image = Properties.Resources.MovFantasma;
                        pictureBoxTipo2.Visible = true;
                        break;
                    case "Acero":
                        pictureBoxTipo2.Image = Properties.Resources.MovAcero;
                        pictureBoxTipo2.Visible = true;
                        break;
                    case "Hada":
                        pictureBoxTipo2.Image = Properties.Resources.MovHada;
                        pictureBoxTipo2.Visible = true;
                        break;
                    default:
                        Console.WriteLine("EEEEERROOOOOOOOOOOOOOOOOOOOOOOOOR");
                        break;
                }
            }
        }

        private void OcultarGIF()
        {
            pictureBoxGIF.Visible = false;
        }
        private void OcultarTiposPokemon(PictureBox pictureBoxTipo, PictureBox pictureBoxtipo2)
        {
            pictureBoxTipo1.Visible = false;
            pictureBoxTipo2.Visible = false;
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
            } else
            {
                paginaActual = totalDePaginas;
                listaPokemonDisponibles = CargarPokemonDisponibles();
                MostrarPokemonDisponibles();
            }
        }

        private void btnCerrarCaja_Click(object sender, EventArgs e)
        {
            if (equipoLleno(Jugador_1) && equipoLleno(Jugador_2))
            {
                Jugador_1.setPokemones(Jugador_1.getPokemones());
                Jugador_2.setPokemones(Jugador_2.getPokemones());
                MessageBox.Show("¡Tu equipo ha sido guardado!");
                return;
            }
            else
            {
                MessageBox.Show("¡No puedes guardar tu equipo si no has elegido 6 pokemones!");
                return;
            }
        }
    }
}