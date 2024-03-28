using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class jugador
    {
        private int ID;
        private string nombre;
        private pila[] bolsa;
        private pokemon[] pokemones;
        private int pJugadas;
        private int pGanadas;
        private int tGanados;
        private turno turno;

        public jugador(int iD, string nombre, int pJugadas, int pGanadas, int tGanados)
        {
            ID = iD;
            this.nombre = nombre;
            this.bolsa = new pila[9];
            this.pokemones = new pokemon[6];
            this.pJugadas = pJugadas;
            this.pGanadas = pGanadas;
            this.tGanados = tGanados;
            this.turno = new turno(this);
        }

        public void setID(int id)
        {
            this.ID = id;
        }

        public void setNombre(string n)
        {
            this.nombre = n;
        }

        public void setBolsa(pila[] b)
        {
            this.bolsa = b;
        }

        public void setPokemones(pokemon[] p)
        {
            this.pokemones = p;
        }

        public void setPJugadas(int pj)
        {
            this.pJugadas = pj;
        }

        public void setPGanadas(int pg)
        {
            this.pGanadas = pg;
        }

        public void setTGanados(int tg)
        {
            this.tGanados = tg;
        }

        public int getID()
        {
            return this.ID;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public pila[] getBolsa()
        {
            return this.bolsa;
        }

        public pokemon[] getPokemones()
        {
            return this.pokemones;
        }

        public int getPJugadas()
        {
            return this.pJugadas;
        }

        public int getPGanadas()
        {
            return this.pGanadas;
        }

        public int getTGanados()
        {
            return this.tGanados;
        }

        public turno GetTurno()
        {
            return this.turno;
        }

        public pokemon cambiarPKM(int index)
        {
            return pokemones[index];
        }

        public bool quedaPKMVivo()
        {
            for (int i = 0; i < pokemones.Length; i++)
            {
                if (pokemones[i].getHP(2) > 0)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
