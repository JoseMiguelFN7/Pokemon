using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class nodo
    {
        private tipo valorTipo;
        private string valorNombreTipo;
        private nodo siguiente;

        public nodo()
        {
            this.valorTipo = null;
            this.siguiente = null;
        }

        public void setValorTipo(tipo t)
        {
            this.valorTipo = t;
        }

        public void setValorNombreTipo(string n)
        {
            this.valorNombreTipo = n;
        }

        public tipo getValorTipo()
        {
            return this.valorTipo;
        }

        public string getValorNombreTipo()
        {
            return this.valorNombreTipo;
        }

        public nodo getSiguiente()
        {
            return siguiente;
        }

        public void setSiguiente(nodo siguiente)
        {
            this.siguiente = siguiente;
        }
    }
}
