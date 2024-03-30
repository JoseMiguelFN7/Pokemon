using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class precisionX : objeto
    {
        public precisionX()
        {
            this.ID = 9;
            this.nombre = "Precisión X";
            this.descripcion = "Este objeto aumenta la precisión de todos los movimientos del Pokémon que lo lleva en un nivel, hasta un máximo de 6 niveles. Cada nivel aumenta la precisión en un 33%.";
            this.icono = Properties.Resources.precisionx;
        }

        public string usarPrecisionX(pokemon PKM, Random ran)
        {
            int nvl = ran.Next(1, 7);
            int aumento;
            for (int i = 0; i < PKM.getMovimientos().Length; i++)
            {
                aumento = (int)Math.Round(PKM.getMovimientos()[i].getPrecision() * 0.33);
                for (int j = 0; j < nvl; j++)
                {
                    PKM.getMovimientos()[i].setPrecision(PKM.getMovimientos()[i].getPrecision() + aumento);
                }
                if (PKM.getMovimientos()[i].getPrecision() > 100)
                {
                    PKM.getMovimientos()[i].setPrecision(100);
                }
            }
            return " usó una PrecisionX. ¡Los movimientos de " + PKM.getNombre() + " son un " + nvl * 33 + "% más precisos!.";
        }
    }
}
