using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class superPocion : objeto
    {
        public superPocion()
        {
            this.ID = 2;
            this.nombre = "Superpoción";
            this.descripcion = "Cura 50 PS al Pokémon.";
            this.icono = Properties.Resources.superpocion;
        }

        public string usarSuperPocion(pokemon PKM)
        {
            PKM.setHP(PKM.getHP(2) + 50, 2);
            if (PKM.getHP(2) > PKM.getHP(1))
            {
                PKM.setHP(PKM.getHP(1), 2);
            }

            return " usó una Super Poción. ¡" + PKM.getNombre() + " ha recuperado 50 PS!.";
        }
    }
}
