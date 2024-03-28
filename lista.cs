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
        { //metodo para agregar tipo al final de la lista
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
        { //metodo para agregar nombre del tipo al final de la lista
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

        public bool existeNombreTipo(string n)
        {
            if (esVacia())
            {
                return false;
            }
            else
            {
                nodo aux = inicio;
                while (aux != null)
                {
                    if (aux.getValorNombreTipo().Equals(n))
                    {
                        return true;
                    }
                    aux = aux.getSiguiente();
                }
                return false;
            }
        }

        public void agregarMovimientoAlFinal(movimiento m)
        { //metodo para agregar un movimiento al final de la lista
            nodo nuevo = new nodo();
            nuevo.setValorMovimiento(m);
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

        public movimiento obtenerMovID(int id)
        {
            if (esVacia())
            {
                return null;
            }
            else
            {
                nodo aux = inicio;
                while (aux != null)
                {
                    if (aux.getValorMovimiento().getID() == id)
                    {
                        return aux.getValorMovimiento();
                    }
                    aux = aux.getSiguiente();
                }
                return null;
            }
        }
    }
}
