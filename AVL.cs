using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class AVL
    {
        private nodo raiz;

        public AVL()
        {
            this.raiz = null;
        }

        public bool esVacio()
        {
            return raiz == null;
        }

        public nodo getRaiz()
        {
            return raiz;
        }

        private int obtenerFE(nodo nodo)
        { //Para obtener el Factor de Equilibrio Izquierda-Derecha.
            if (nodo == null)
            {
                return 0;
            }
            return nodo.getAltura(nodo.getIzq()) - nodo.getAltura(nodo.getDer());
        }

        private void actualizarAltura(nodo nodo)
        { //Metodo para actualizar las alturas de los nodos despues de cada movimiento/rotacion
            if (nodo != null)
            {
                nodo.setAltura(Math.Max(nodo.getAltura(nodo.getIzq()), nodo.getAltura(nodo.getDer())) + 1); //La altura seria la altura del arbol mayor entre izquierda y derecha
            }
        }

        private nodo rotacionDerecha(nodo a)
        { //Para balancear hacia la derecha
            nodo b = a.getIzq();
            nodo aux = b.getDer();

            b.setDer(a);
            a.setIzq(aux);

            actualizarAltura(a);
            actualizarAltura(b);

            return b;
        }

        private nodo rotacionIzquierda(nodo b)
        { //Para balancear hacia la izquierda
            nodo a = b.getDer();
            nodo aux = a.getIzq();

            a.setIzq(b);
            b.setDer(aux);

            actualizarAltura(b);
            actualizarAltura(a);

            return a;
        }

        public void insertarJugador(jugador jugador)
        {
            raiz = insertarJ(raiz, jugador);
        }

        private nodo insertarJ(nodo nodo, jugador jugador)
        {
            if (nodo == null)
            {
                nodo n = new nodo();
                n.setValorJugador(jugador);
                return n;
            }

            if (jugador.getID() < nodo.getValorJugador().getID())
            { //Si es menor, va a la izquierda
                nodo.setIzq(insertarJ(nodo.getIzq(), jugador));
            }
            else if (jugador.getID() > nodo.getValorJugador().getID())
            {//Si es mayor, va a la derecha
                nodo.setDer(insertarJ(nodo.getDer(), jugador));
            }
            else
            {
                return nodo; //En caso de ser duplicado, no lo ingresa
            }

            actualizarAltura(nodo);

            int FE = obtenerFE(nodo);

            if (FE > 1 && jugador.getID() < nodo.getIzq().getValorJugador().getID())
            { //Cuando hay desequilibrio a la izquierda y la hoja esta a la izquierda
                return rotacionDerecha(nodo);
            }

            if (FE < -1 && jugador.getID() > nodo.getDer().getValorJugador().getID())
            { //Cuando hay desequilibrio a la derecha y la hoja esta a la derecha
                return rotacionIzquierda(nodo);
            }

            if (FE > 1 && jugador.getID() > nodo.getIzq().getValorJugador().getID())
            { //Cuando hay desequilibrio a la izquierda y la hoja esta a la derecha
                nodo.setIzq(rotacionIzquierda(nodo.getIzq())); //Se rota a la izquierda
                return rotacionDerecha(nodo); //Despues a la derecha
            }

            if (FE < -1 && jugador.getID() < nodo.getDer().getValorJugador().getID())
            { //Cuando hay desequilibrio a la izquierda y la hoja esta a la derecha
                nodo.setDer(rotacionDerecha(nodo.getDer())); //Se rota a la derecha
                return rotacionIzquierda(nodo); //Despues a la izquierda
            }

            return nodo;
        }

        private nodo obtenerNodoMinimo(nodo nodo)
        { //Metodo usado al eliminar un nodo para determinar su reemplazo
            nodo actual = nodo;
            while (actual.getIzq() != null)
            { //consigue el nodo con el valor mas pequeño
                actual = actual.getIzq();
            }
            return actual;
        }

        public jugador buscarJugador(int numID)
        { //Para retornar los datos de un jugador dentro del arbol
            return buscarJ(raiz, numID);
        }

        private jugador buscarJ(nodo n, int numID)
        {
            if (n == null)
            {
                return null;
            }
            if (n.getValorJugador().getID() == numID)
            {
                return n.getValorJugador();
            }
            if (numID > n.getValorJugador().getID())
            {
                return buscarJ(n.getDer(), numID);
            }
            else
            {
                return buscarJ(n.getIzq(), numID);
            }
        }

        public void insertarFinal(lista l)
        {
            raiz.setDer(l.getInicio());
            raiz.setIzq(l.getInicio().getSiguiente());
        }

        public void insertarSemi(lista l)
        {
            raiz.getDer().setDer(l.getInicio());
            raiz.getDer().setIzq(l.getInicio().getSiguiente());
            raiz.getIzq().setDer(l.getInicio().getSiguiente().getSiguiente());
            raiz.getIzq().setIzq(l.getInicio().getSiguiente().getSiguiente().getSiguiente());
        }

        public void insertarCuartos(lista l)
        {
            raiz.getDer().getDer().setDer(l.getInicio());
            raiz.getDer().getDer().setIzq(l.getInicio().getSiguiente());
            raiz.getDer().getIzq().setDer(l.getInicio().getSiguiente().getSiguiente());
            raiz.getDer().getIzq().setIzq(l.getInicio().getSiguiente().getSiguiente().getSiguiente());
            raiz.getIzq().getDer().setDer(l.getInicio().getSiguiente().getSiguiente().getSiguiente().getSiguiente());
            raiz.getIzq().getDer().setIzq(l.getInicio().getSiguiente().getSiguiente().getSiguiente().getSiguiente().getSiguiente());
            raiz.getIzq().getIzq().setDer(l.getInicio().getSiguiente().getSiguiente().getSiguiente().getSiguiente().getSiguiente().getSiguiente());
            raiz.getIzq().getIzq().setIzq(l.getInicio().getSiguiente().getSiguiente().getSiguiente().getSiguiente().getSiguiente().getSiguiente().getSiguiente());
        }
    }
}
