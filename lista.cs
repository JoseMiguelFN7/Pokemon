using System;
using System.Collections;
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
        private nodo fin;
        public lista()
        {
            this.inicio = null;
            this.tamanio = 0;
            this.fin = null;
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

        public pokemon ObtenerPokemonPorIndice(int indice)
        {
            if (indice < 0 || indice >= tamanio)
            {
                throw new IndexOutOfRangeException("El índice está fuera de los límites de la lista.");
            }
            nodo actual = inicio;
            for(int i = 0; i < indice; i++)
            {
                actual = actual.getSiguiente();
            }
            return actual.getValorPokemon();
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
        public void agregarPokemonAlFinal(pokemon p)
        {
            nodo nuevo = new nodo();
            nuevo.setValorPokemon(p);
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

        public void eliminarPrimerPokemon()
        {
            if (inicio != null)
            {
                inicio = inicio.getSiguiente(); // Avanzamos el puntero inicio al siguiente nodo
                tamanio--; // Reducimos el tamaño de la lista
                if (tamanio == 0)
                {
                    fin = null; // Si la lista queda vacía, también ajustamos fin a null
                }
            }
        }

        public void eliminarPokemon(pokemon p)
        {
            if (inicio != null)
            {
                nodo anterior = null;
                nodo actual = inicio;

                while (actual != null)
                {
                    if (actual.getValorPokemon() == p)
                    {
                        if (anterior == null)
                        {
                            inicio = actual.getSiguiente();
                        }
                        else
                        {
                            anterior.setSiguiente(actual.getSiguiente());
                        }
                        tamanio--;
                        return;
                    }

                    anterior = actual;
                    actual = actual.getSiguiente();
                }
            }
        }
        public IEnumerator GetEnumerator()
        {
            nodo nodoActual = inicio; // Usar el campo 'inicio' en lugar de 'primerNodo'
            while (nodoActual != null)
            {
                yield return nodoActual.getValorPokemon();
                nodoActual = nodoActual.getSiguiente();
            }
        }

        public void eliminarPokemonPorIndice(int indice)
        {
            if (indice < 0 || indice >= this.tamanio)
            {
                Console.WriteLine("Índice fuera de rango");
                return;
            }

            if (indice == 0)
            {
                this.eliminarPrimerPokemon();
                return;
            }

            nodo nodoAnterior = null;
            nodo nodoActual = this.inicio;
            int contador = 0;

            while (contador < indice)
            {
                nodoAnterior = nodoActual;
                nodoActual = nodoActual.getSiguiente();
                contador++;
            }

            nodoAnterior.setSiguiente(nodoActual.getSiguiente());
            if (nodoActual == this.fin)
            {
                this.fin = nodoAnterior;
            }

            this.tamanio--;
        }

        public void insertarPokemonPorIndice(int indice, pokemon p)
        {
            if (indice < 0 || indice > tamanio)
            {
                Console.WriteLine("Índice fuera de rango");
                return;
            }

            nodo nuevo = new nodo();
            nuevo.setValorPokemon(p);

            if (indice == 0)
            {
                nuevo.setSiguiente(inicio);
                inicio = nuevo;
                if (tamanio == 0)
                {
                    fin = nuevo; // Si la lista estaba vacía, el nuevo nodo es también el último
                }
            }
            else
            {
                nodo aux = inicio;
                for (int i = 0; i < indice - 1; i++)
                {
                    aux = aux.getSiguiente();
                }
                nuevo.setSiguiente(aux.getSiguiente());
                aux.setSiguiente(nuevo);
                if (indice == tamanio)
                {
                    fin = nuevo; // Si el índice es igual al tamaño, el nuevo nodo es el último
                }
            }

            tamanio++;
        }
    }
}