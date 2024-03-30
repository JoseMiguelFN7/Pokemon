using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class pocion : objeto
    {
        public pocion()
        {
            this.ID = 1;
            this.nombre = "Poción";
            this.descripcion = "Cura 20 PS al Pokémon.";
            this.icono = Properties.Resources.pocion;
        }

        public string usarPocion(pokemon PKM)
        {
            PKM.setHP(PKM.getHP(2) + 20, 2);
            if (PKM.getHP(2) > PKM.getHP(1))
            {
                PKM.setHP(PKM.getHP(1), 2);
            }

            return " usó una Poción. ¡" + PKM.getNombre() + " ha recuperado 20 PS!.";
        }
    }
}
