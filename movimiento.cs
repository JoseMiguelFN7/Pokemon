using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class movimiento
    {
        private int id;
        private string nombre;
        private tipo tipo;
        private int[] usos;

        public movimiento(int id, string nombre, tipo tipo, int usos)
        {
            this.id = id;
            this.nombre = nombre;
            this.tipo = tipo;
            this.usos = new int[2];

            this.usos[0] = usos;
            this.usos[1] = usos;
        }

        public int getId() 
        { 
            return id;
        }

        public string getNombre()
        {
            return nombre;
        }

        public tipo getTipo()
        {
            return tipo;
        }

        public int getUsos(int pos)
        {
            return usos[pos];
        }
    }
}
