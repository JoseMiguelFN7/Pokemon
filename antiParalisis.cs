using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class antiParalisis : objeto
    {
        public antiParalisis()
        {
            this.ID = 4;
            this.nombre = "Antiparálisis";
            this.descripcion = "Cura la parálisis del Pokémon.";
            this.icono = Properties.Resources.antiparalisis;
        }

        public string usarAntiparalisis(pokemon PKM)
        {
            string s = " usó un Antiparálisis. ";
            if (PKM.getEstadoAlterado() == 1)
            {
                PKM.setEstadoAlterado(0);
                s += "¡" + PKM.getNombre() + " ya no está paralizado!.";
            }
            else
            {
                s += "No hizo efecto.";
            }

            return s;
        }
    }
}
