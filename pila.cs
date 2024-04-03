using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class pila
    {
        private nodo tope;
        private int tamanio;

        public pila()
        {
            this.tope = null;
            this.tamanio = 0;
        }

        public bool esVacia()
        { //Metodo para determinar si la pila esta vacia.
            return tope == null;
        }

        public int getTamanio()
        {
            return tamanio;
        }

        public void agregarPocionEnLaPila(pocion valorPocion)
        { //Metodo para agregar Pocion a la pila.
            nodo nuevo = new nodo();
            nuevo.setValorPocion(valorPocion);
            if (esVacia())
            {
                tope = nuevo;
            }
            else
            {
                nuevo.setSiguiente(tope);
                tope = nuevo;
            }
            tamanio++;
        }

        public pocion sacarPocionDePila()
        { //Metodo para sacar una Pocion de la pila.
            pocion valorPocion = null;
            if (!esVacia())
            {
                valorPocion = tope.getValorPocion();
                tope = tope.getSiguiente();
                tamanio--;
            }
            return valorPocion;
        }

        public void agregarSuperPocionEnLaPila(superPocion valorSuperPocion)
        { //Metodo para agregar Super Pocion a la pila.
            nodo nuevo = new nodo();
            nuevo.setValorSuperPocion(valorSuperPocion);
            if (esVacia())
            {
                tope = nuevo;
            }
            else
            {
                nuevo.setSiguiente(tope);
                tope = nuevo;
            }
            tamanio++;
        }

        public superPocion sacarSuperPocionDePila()
        { //Metodo para sacar una Super Pocion de la pila.
            superPocion valorSuperPocion = null;
            if (!esVacia())
            {
                valorSuperPocion = tope.getValorSuperPocion();
                tope = tope.getSiguiente();
                tamanio--;
            }
            return valorSuperPocion;
        }

        public void agregarHiperPocionEnLaPila(hiperPocion valorHiperPocion)
        { //Metodo para agregar Hiper Pocion a la pila.
            nodo nuevo = new nodo();
            nuevo.setValorHiperPocion(valorHiperPocion);
            if (esVacia())
            {
                tope = nuevo;
            }
            else
            {
                nuevo.setSiguiente(tope);
                tope = nuevo;
            }
            tamanio++;
        }

        public hiperPocion sacarHiperPocionDePila()
        { //Metodo para sacar una Hiper Pocion de la pila.
            hiperPocion valorHiperPocion = null;
            if (!esVacia())
            {
                valorHiperPocion = tope.getValorHiperPocion();
                tope = tope.getSiguiente();
                tamanio--;
            }
            return valorHiperPocion;
        }

        public void agregarAntiParalisisEnLaPila(antiParalisis valorAntiParalisis)
        { //Metodo para agregar Antiparalisis a la pila.
            nodo nuevo = new nodo();
            nuevo.setValorAntiparalisis(valorAntiParalisis);
            if (esVacia())
            {
                tope = nuevo;
            }
            else
            {
                nuevo.setSiguiente(tope);
                tope = nuevo;
            }
            tamanio++;
        }

        public antiParalisis sacarAntiParalisisDePila()
        { //Metodo para sacar un Antiparalisis de la pila.
            antiParalisis valorAntiParalisis = null;
            if (!esVacia())
            {
                valorAntiParalisis = tope.getValorAntiparalisis();
                tope = tope.getSiguiente();
                tamanio--;
            }
            return valorAntiParalisis;
        }

        public void agregarAntidotoEnLaPila(antidoto valorAntidoto)
        { //Metodo para agregar Antiparalisis a la pila.
            nodo nuevo = new nodo();
            nuevo.setValorAntidoto(valorAntidoto);
            if (esVacia())
            {
                tope = nuevo;
            }
            else
            {
                nuevo.setSiguiente(tope);
                tope = nuevo;
            }
            tamanio++;
        }

        public antidoto sacarAntidotoDePila()
        { //Metodo para sacar un Antiparalisis de la pila.
            antidoto valorAntidoto = null;
            if (!esVacia())
            {
                valorAntidoto = tope.getValorAntidoto();
                tope = tope.getSiguiente();
                tamanio--;
            }
            return valorAntidoto;
        }

        public void agregarDespertarEnLaPila(despertar valorDespertar)
        { //Metodo para agregar Antiparalisis a la pila.
            nodo nuevo = new nodo();
            nuevo.setValorDespertar(valorDespertar);
            if (esVacia())
            {
                tope = nuevo;
            }
            else
            {
                nuevo.setSiguiente(tope);
                tope = nuevo;
            }
            tamanio++;
        }

        public despertar sacarDespertarDePila()
        { //Metodo para sacar un Antiparalisis de la pila.
            despertar valorDespertar = null;
            if (!esVacia())
            {
                valorDespertar = tope.getValorDespertar();
                tope = tope.getSiguiente();
                tamanio--;
            }
            return valorDespertar;
        }

        public void agregarCuraTotalEnLaPila(curaTotal valorCuraTotal)
        { //Metodo para agregar Antiparalisis a la pila.
            nodo nuevo = new nodo();
            nuevo.setValorCuraTotal(valorCuraTotal);
            if (esVacia())
            {
                tope = nuevo;
            }
            else
            {
                nuevo.setSiguiente(tope);
                tope = nuevo;
            }
            tamanio++;
        }

        public curaTotal sacarCuraTotalDePila()
        { //Metodo para sacar un Antiparalisis de la pila.
            curaTotal valorCuraTotal = null;
            if (!esVacia())
            {
                valorCuraTotal = tope.getValorCuraTotal();
                tope = tope.getSiguiente();
                tamanio--;
            }
            return valorCuraTotal;
        }

        public void agregarMaxPocionEnLaPila(maxPocion valorMaxPocion)
        { //Metodo para agregar Antiparalisis a la pila.
            nodo nuevo = new nodo();
            nuevo.setValorMaxPocion(valorMaxPocion);
            if (esVacia())
            {
                tope = nuevo;
            }
            else
            {
                nuevo.setSiguiente(tope);
                tope = nuevo;
            }
            tamanio++;
        }

        public maxPocion sacarMaxPocionDePila()
        { //Metodo para sacar un Antiparalisis de la pila.
            maxPocion valorMaxPocion = null;
            if (!esVacia())
            {
                valorMaxPocion = tope.getValorMaxPocion();
                tope = tope.getSiguiente();
                tamanio--;
            }
            return valorMaxPocion;
        }

        public void agregarPrecisionXEnLaPila(precisionX valorPrecisionX)
        { //Metodo para agregar Antiparalisis a la pila.
            nodo nuevo = new nodo();
            nuevo.setValorPrecisionX(valorPrecisionX);
            if (esVacia())
            {
                tope = nuevo;
            }
            else
            {
                nuevo.setSiguiente(tope);
                tope = nuevo;
            }
            tamanio++;
        }

        public precisionX sacarPrecisionXDePila()
        { //Metodo para sacar un Antiparalisis de la pila.
            precisionX valorPrecisionX = null;
            if (!esVacia())
            {
                valorPrecisionX = tope.getValorPrecisionX();
                tope = tope.getSiguiente();
                tamanio--;
            }
            return valorPrecisionX;
        }
    }
}
