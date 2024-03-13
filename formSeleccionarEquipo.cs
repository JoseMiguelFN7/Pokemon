using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon
{
    public partial class formSeleccionarEquipo : Form
    {
        private List<Pokemon> listaPokemonDisponibles;
        private List<Pokemon> equipoPokemon;

        public formSeleccionarEquipo()
        {
            InitializeComponent();
            // Inicializar las listas de Pokémon disponibles y equipo Pokémon
            listaPokemonDisponibles = CargarPokemonDisponibles();
            equipoPokemon = new List<Pokemon>();
            MostrarPokemonDisponibles();
        }

        private List<Pokemon> CargarPokemonDisponibles()
        {
            List<Pokemon> pokemon = new List<Pokemon>();
            string[] lines = File.ReadAllLines("pokemones.txt");
            foreach (string line in lines)
            {
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

                    Pokemon nuevoPokemon = new Pokemon(id, nombre, nivel, tipos, hp, atk, atks, def, defs, vel);
                    pokemon.Add(nuevoPokemon);
                }
                else
                {
                    Console.WriteLine($"Error de formato en la línea: {line}");
                }
            }

            return pokemon;
        }

        private void MostrarPokemonDisponibles()
        {
            listBoxPokemonDisponibles.DataSource = null;
            listBoxPokemonDisponibles.DataSource = listaPokemonDisponibles;
            listBoxPokemonDisponibles.DisplayMember = "Nombre";
        }

        private void buttonAgregarPokemon_Click(object sender, EventArgs e)
        {
            Pokemon pokemonSeleccionado = listBoxPokemonDisponibles.SelectedItem as Pokemon;
            if (pokemonSeleccionado != null && equipoPokemon.Count < 6)
            {
                equipoPokemon.Add(pokemonSeleccionado);
                listaPokemonDisponibles.Remove(pokemonSeleccionado); // Eliminar de la lista de disponibles
                MostrarPokemonDisponibles();
                MostrarEquipoPokemon();
            }
            else
            {
                MessageBox.Show("Ya has seleccionado 6 Pokémon para tu equipo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarEquipoPokemon()
        {
            listBoxEquipoPokemon.DataSource = null;
            listBoxEquipoPokemon.DataSource = equipoPokemon;
            listBoxEquipoPokemon.DisplayMember = "Nombre";
        }

        private void buttonEliminarPokemon_Click(object sender, EventArgs e)
        {
            Pokemon pokemonSeleccionado = listBoxEquipoPokemon.SelectedItem as Pokemon;
            if (pokemonSeleccionado != null)
            {
                int index = equipoPokemon.IndexOf(pokemonSeleccionado);
                equipoPokemon.Remove(pokemonSeleccionado);

                int insertIndex = 0;
                for (int i = 0; i < listaPokemonDisponibles.Count; i++)
                {
                    if (listaPokemonDisponibles[i].getID() > pokemonSeleccionado.getID())
                    {
                        insertIndex = i;
                        break;
                    }
                    else
                    {
                        insertIndex = i + 1;
                    }
                }

                listaPokemonDisponibles.Insert(insertIndex, pokemonSeleccionado);
                MostrarPokemonDisponibles();
                MostrarEquipoPokemon();
            }
        }
        public static tipo[] ObtenerTipos()
        {
            // Lo de los tipos no funciona todavía so retornará null hasta que añadamos eso
            return null;
        }
    }
}
