using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class hiperPocion : objeto
    {
        public hiperPocion()
        {
            this.ID = 3;
            this.nombre = "Hiperpoción";
            this.descripcion = "Cura 200 PS al Pokémon.";
            this.icono = Properties.Resources.hiperpocion;
        }

        public string usarHiperPocion(pokemon PKM)
        {
            PKM.setHP(PKM.getHP(2) + 200, 2);
            if (PKM.getHP(2) > PKM.getHP(1))
            {
                PKM.setHP(PKM.getHP(1), 2);
            }

            return " usó una Hiper Poción. ¡" + PKM.getNombre() + " ha recuperado 200 PS!.";
        }
    }
}
