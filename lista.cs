using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

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

        public void agregarJugadorAlFinal(jugador j)
        { //metodo para agregar jugadores al final de la lista
            nodo nuevo = new nodo();
            nuevo.setValorJugador(j);
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

        public jugador buscarJugador(string nombreJ)
        { //para buscar un jugador en la lista
            if (esVacia())
            {
                return null;
            }
            else
            {
                nodo aux = inicio;
                while (aux != null)
                {
                    if (aux.getValorJugador().getNombre().Equals(nombreJ))
                    {
                        return aux.getValorJugador();
                    }
                    aux = aux.getSiguiente();
                }
                return null;
            }
        }

        public bool existeJNombre(string nombreJ)
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
                    if (aux.getValorJugador().getNombre().Equals(nombreJ))
                    {
                        return true;
                    }
                    aux = aux.getSiguiente();
                }
                return false;
            }
        }

        public void agregarPokemonAlFinal(pokemon pkm)
        { //metodo para agregar jugadores al final de la lista
            nodo nuevo = new nodo();
            nuevo.setValorPokemon(pkm);
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

        public void eliminarPokemon(pokemon pkm)
        { //metodo para eliminar un pokemon de la lista.
            if (!esVacia())
            {
                if (inicio.getValorPokemon().getID() == pkm.getID())
                {
                    inicio = inicio.getSiguiente();
                }
                else
                {
                    nodo aux = inicio;
                    while (aux.getSiguiente() != null)
                    {
                        if (aux.getSiguiente().getValorPokemon().getID() == pkm.getID())
                        {
                            aux.setSiguiente(aux.getSiguiente().getSiguiente());
                            return;
                        }
                        aux = aux.getSiguiente();
                    }
                }
            }
        }

        public pokemon[] getArrayPokemones()
        { //para convertir la lista en una array
            pokemon[] arrayPokemones = new pokemon[tamanio];
            if (esVacia())
            {
                return null;
            }
            else
            {
                nodo aux = inicio;
                for (int i = 0; i < tamanio; i++)
                {
                    arrayPokemones[i] = aux.getValorPokemon();
                    aux = aux.getSiguiente();
                }
                return arrayPokemones;
            }
        }

        public jugador[] getArrayJugadores()
        { //para convertir la lista en una array
            jugador[] arrayJugadores = new jugador[tamanio];
            if (esVacia())
            {
                return null;
            }
            else
            {
                nodo aux = inicio;
                for (int i = 0; i < tamanio; i++)
                {
                    arrayJugadores[i] = aux.getValorJugador();
                    aux = aux.getSiguiente();
                }
                return arrayJugadores;
            }
        }

        public lista randomizeJugadores(jugador[] j)
        { //metodo que recibe un arreglo ordenado y retorna una lista con esos elementos en orden aleatorio.
            ArrayList index = new ArrayList(); //ArrayList vacia que contendra los indices del arreglo ordenado.
            for (int i = 0; i < j.Length; i++)
            {
                index.Add(i); //Agrega los indices de uno en uno hasta completar los que posee el arreglo.
            }
            int k = j.Length; //El valor inicial de k es la cantidad de elementos en el arreglo de cartas.
            Random num = new Random(); //Num sera un entero generado de manera aleatoria en el rango especificado.
            int a; //El valor de num sera almacenado aqui para usarlo en cada iteracion.
            lista ranJug = new lista(); //Pila donde se almacenaran las cartas desordenadas.
            do
            {
                a = num.Next(k); //numero entero aleatorio entre 0 y k-1.
                ranJug.agregarJugadorAlFinal(j[(int)index[a]]); //agrega al tope de la pila el elemento del arreglo ordenado en la posicion dada por el indice seleccionado dentro de la ArrayList de manera aleatoria.
                index.RemoveAt(a); //Elimina el indice selecionado del ArrayList para evitar que se repita.
                k--; //El rango de valores disminuye en 1 para ajustarse al nuevo tamano del ArrayList.
            } while (k > 0);
            return ranJug; //Devuelve la pila de cartas ya desorganizada.
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

        public void limpiarLista()
        {
            inicio = null;
            tamanio = 0;
        }

        public void agregarColaALista(cola c)
        {
            jugador j;
            for (int i = 0; i < c.getTamanio(); i++)
            {
                j = c.sacarJugadorDeLaCola();
                if (!existeID(j.getID()))
                {
                    agregarJugadorAlFinal(j);
                }
                c.agregarJugadorEnCola(j);
            }
        }

        public bool existeID(int ID)
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
                    if (aux.getValorJugador().getID() == ID)
                    {
                        return true;
                    }
                    aux = aux.getSiguiente();
                }
                return false;
            }
        }

        public string obtenerStringJugadores()
        {
            if (esVacia())
            {
                return null;
            }
            else
            {
                string s = "";
                nodo aux = inicio;
                while (aux != null)
                {

                    if (aux.getSiguiente() != null)
                    {
                        s += aux.getValorJugador().getID() + "/" + aux.getValorJugador().getNombre() + "/" + aux.getValorJugador().getPJugadas() + "/" + aux.getValorJugador().getPGanadas() + "/" + aux.getValorJugador().getTGanados() + "\n";
                    }
                    else
                    {
                        s += aux.getValorJugador().getID() + "/" + aux.getValorJugador().getNombre() + "/" + aux.getValorJugador().getPJugadas() + "/" + aux.getValorJugador().getPGanadas() + "/" + aux.getValorJugador().getTGanados();
                    }
                    aux = aux.getSiguiente();
                }
                return s;
            }
        }

        public void agregarListaALista(lista l)
        {
            nodo nuevo = l.inicio;

            if (l.esVacia())
            {
                return;
            }
            else
            {
                if (esVacia())
                {
                    inicio = nuevo;
                }
                else
                {
                    while (nuevo != null)
                    {
                        if (!existeID(nuevo.getValorJugador().getID()))
                        {
                            agregarJugadorAlFinal(nuevo.getValorJugador());
                        }
                        nuevo = nuevo.getSiguiente();
                    }
                }
            }
        }

        public void llenarComboBox(ComboBox CB)
        {
            if (esVacia() || CB.Items.Count>0)
            {
                return;
            }
            else
            {
                nodo aux = inicio;
                while (aux != null)
                {
                    CB.Items.Add(aux.getValorJugador().getNombre());
                    aux = aux.getSiguiente();
                }
            }
        }
    }
}
