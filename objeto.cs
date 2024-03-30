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
}
