using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class antidoto : objeto
    {
        public antidoto()
        {
            this.ID = 5;
            this.nombre = "Antídoto";
            this.descripcion = "Cura el veneno del Pokémon.";
            this.icono = Properties.Resources.antidoto;
        }

        public string usarAntidoto(pokemon PKM)
        {
            string s = " usó un Antídoto. ";
            if (PKM.getEstadoAlterado() == 5)
            {
                PKM.setEstadoAlterado(0);
                s += "¡" + PKM.getNombre() + " ya no está envenenado!.";
            }
            else
            {
                s += "No hizo efecto.";
            }

            return s;
        }
    }
}
