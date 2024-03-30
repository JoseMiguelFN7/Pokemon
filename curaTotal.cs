using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class curaTotal : objeto
    {
        public curaTotal()
        {
            this.ID = 7;
            this.nombre = "Cura Total";
            this.descripcion = "Cura todos los PS del Pokémon y elimina todos los problemas de estado.";
            this.icono = Properties.Resources.curatotal;
        }

        public string usarCuraTotal(pokemon PKM)
        {
            string s = " usó una Cura Total. ¡" + PKM.getNombre() + " ha recuperado todos sus PS";
            if (PKM.getEstadoAlterado() == 0)
            {
                s += "!.";
            }
            else
            {
                s += " y ya no posee estados alterados!.";
            }
            PKM.setHP(PKM.getHP(1), 2);
            PKM.setEstadoAlterado(0);
            PKM.setProbRecuperar(0);


            return s;
        }
    }
}
