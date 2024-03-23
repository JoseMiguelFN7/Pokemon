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

        public void usarPocion(pokemon PKM)
        {
            PKM.setHP(PKM.getHP(2) + 20, 2);
            if (PKM.getHP(2)> PKM.getHP(1))
            {
                PKM.setHP(PKM.getHP(1), 2);
            }
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

        public void usarSuperPocion(pokemon PKM)
        {
            PKM.setHP(PKM.getHP(2) + 50, 2);
            if (PKM.getHP(2) > PKM.getHP(1))
            {
                PKM.setHP(PKM.getHP(1), 2);
            }
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

        public void usarHiperPocion(pokemon PKM)
        {
            PKM.setHP(PKM.getHP(2) + 200, 2);
            if (PKM.getHP(2) > PKM.getHP(1))
            {
                PKM.setHP(PKM.getHP(1), 2);
            }
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

        //METODO PARA QUITAR PARALISIS
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

        //METODO PARA QUITAR VENENO
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

        //METODO PARA QUITAR SUENO
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

        public void usarCuraTotal(pokemon PKM)
        {
            PKM.setHP(PKM.getHP(1), 2);
            //METODO PARA CURAR ESTADOS ALTERADOS
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

        public void usarCuraTotal(pokemon PKM)
        {
            PKM.setHP(PKM.getHP(1), 2);
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

        //METODO PARA AUMENTAR PRECISION
    }
}
