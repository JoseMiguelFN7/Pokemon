using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class despertar : objeto
    {
        public despertar()
        {
            this.ID = 6;
            this.nombre = "Despertar";
            this.descripcion = "Despierta al Pokémon dormido.";
            this.icono = Properties.Resources.awakening;
        }

        public string usarDespertar(pokemon PKM)
        {
            string s = " usó un Despertar. ";
            if (PKM.getEstadoAlterado() == 3)
            {
                PKM.setEstadoAlterado(0);
                PKM.setProbRecuperar(0);
                s += "¡" + PKM.getNombre() + " ya no tiene sueño!.";
            }
            else
            {
                s += "No hizo efecto.";
            }

            return s;
        }
    }
}
