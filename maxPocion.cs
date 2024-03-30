using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class maxPocion : objeto
    {
        public maxPocion()
        {
            this.ID = 8;
            this.nombre = "Max poción";
            this.descripcion = "Cura todos los PS del Pokémon.";
            this.icono = Properties.Resources.maxpocion;
        }

        public string usarMaxPocion(pokemon PKM)
        {
            PKM.setHP(PKM.getHP(1), 2);
            return " usó una Max poción. ¡" + PKM.getNombre() + " ha recuperado todos sus PS!.";
        }
    }
}
