using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class lista
    {
        private nodo inicio;
        private int tamanio;

        public lista()
        {
            this.inicio = null;
            this.tamanio = 0;
        }

        public nodo getInicio()
        {
            return inicio;
        }

        public int getTamanio()
        {
            return tamanio;
        }

        public bool esVacia()
        {
            return inicio == null;
        }

        public void agregarTipoAlFinal(tipo t)
        { //método para agregar una persona al final de la lista
            nodo nuevo = new nodo();
            nuevo.setValorTipo(t);
            if (esVacia())
            {
                inicio = nuevo;
            }
            else
            {
                nodo aux = inicio;
                while (aux.getSiguiente() != null)
                {
                    aux = aux.getSiguiente();
                }
                aux.setSiguiente(nuevo);
            }
            tamanio++;
        }

        public void agregarNombreTipoAlFinal(string t)
        { //método para agregar una persona al final de la lista
            nodo nuevo = new nodo();
            nuevo.setValorNombreTipo(t);
            if (esVacia())
            {
                inicio = nuevo;
            }
            else
            {
                nodo aux = inicio;
                while (aux.getSiguiente() != null)
                {
                    aux = aux.getSiguiente();
                }
                aux.setSiguiente(nuevo);
            }
            tamanio++;
        }
    }
}
