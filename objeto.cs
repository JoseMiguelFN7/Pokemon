using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class objeto
    {
        protected int ID;
        protected string nombre;
        protected string descripcion;
        protected Image icono;

        public void setID(int id)
        {
            this.ID = id;
        }

        public void setNombre(string n)
        {
            this.nombre = n;
        }

        public void setDescripcion(string d)
        {
            this.descripcion = d;
        }

        public int getID()
        {
            return this.ID;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public string getDescripcion()
        {
            return this.descripcion;
        }

        public Image getIcono()
        {
            return icono;
        }
    }

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
            if (PKM.getHP(2)> PKM.getHP(1))
            {
                PKM.setHP(PKM.getHP(1), 2);
            }

            return " usó una Poción. ¡" + PKM.getNombre() + " ha recuperado 20 PS!.";
        }
    }

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
            return " usó una PrecisionX. ¡Los movimientos de " + PKM.getNombre() + " son un " + nvl*33 + "% más precisos!.";
        }
    }
}
