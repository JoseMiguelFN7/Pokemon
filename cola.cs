using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class cola
    {
        private nodo inicio;
        private nodo fin;
        private int tamanio;

        public cola()
        {
            this.inicio = null;
            this.fin = null;
            this.tamanio = 0;
        }

        public int getTamanio()
        {
            return this.tamanio;
        }

        public bool esVacia()
        { //Para determinar si la cola esta vacia.
            return inicio == null;
        }

        public void agregarJugadorEnCola(jugador datoJugador)
        { //Para meter un nuevo elemento a la cola.
            nodo nuevo = new nodo();
            nuevo.setValorJugador(datoJugador);
            if (esVacia())
            {
                inicio = fin = nuevo;
            }
            else
            {
                fin.setSiguiente(nuevo);
                fin = nuevo;
            }
            tamanio++;
        }

        public jugador sacarJugadorDeLaCola()
        { //Para sacar el elemento que corresponde de la cola.
            jugador valorJugador = null;
            if (!esVacia())
            {
                valorJugador = inicio.getValorJugador();
                inicio = inicio.getSiguiente();
                if (esVacia())
                {
                    fin = null;
                }
                tamanio--;
            }
            return valorJugador;
        }

        public jugador verInicio()
        {
            return inicio.getValorJugador();
        }

        public bool todosListos()
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
                    if (aux.getValorJugador().GetTurno().estaActivo())
                    {
                        return false;
                    }
                    aux = aux.getSiguiente();
                }
                return true;
            }
        }
    }
}