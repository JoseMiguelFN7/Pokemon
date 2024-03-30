using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class nodo
    {
        private pokemon valorPokemon;
        private tipo valorTipo;
        private string valorNombreTipo;
        private movimiento valorMovimiento;
        private jugador valorJugador;
        private pocion valorPocion;
        private superPocion valorSuperPocion;
        private hiperPocion valorHiperPocion;
        private antiParalisis valorAntiParalisis;
        private antidoto valorAntidoto;
        private despertar valorDespertar;
        private curaTotal valorCuraTotal;
        private maxPocion valorMaxPocion;
        private precisionX valorPrecisionX;
        private nodo siguiente, der, izq;
        private int altura;

        public nodo()
        {
            this.valorPokemon = null;
            this.valorTipo = null;
            this.valorNombreTipo = null;
            this.valorMovimiento = null;
            this.valorJugador = null;
            this.valorPocion = null;
            this.valorSuperPocion = null;
            this.valorHiperPocion = null;
            this.valorAntiParalisis = null;
            this.valorAntidoto = null;
            this.valorDespertar = null;
            this.valorCuraTotal = null;
            this.valorMaxPocion = null;
            this.valorPrecisionX = null;
            this.siguiente = null;
            this.der = null;
            this.izq = null;
            this.altura = 1;
        }

        public void setDer(nodo der)
        {
            this.der = der;
        }

        public void setIzq(nodo izq)
        {
            this.izq = izq;
        }

        public void setValorPokemon(pokemon pkm)
        {
            this.valorPokemon = pkm;
        }

        public void setValorTipo(tipo t)
        {
            this.valorTipo = t;
        }

        public void setValorNombreTipo(string n)
        {
            this.valorNombreTipo = n;
        }

        public void setValorMovimiento(movimiento m)
        {
            this.valorMovimiento = m;
        }

        public void setValorJugador(jugador j)
        {
            this.valorJugador = j;
        }

        public void setValorPocion(pocion VP)
        {
            this.valorPocion = VP;
        }

        public void setValorSuperPocion(superPocion VSP)
        {
            this.valorSuperPocion = VSP;
        }

        public void setValorHiperPocion(hiperPocion VHP)
        {
            this.valorHiperPocion = VHP;
        }

        public void setValorAntiparalisis(antiParalisis VAP)
        {
            this.valorAntiParalisis = VAP;
        }

        public void setValorAntidoto(antidoto VA)
        {
            this.valorAntidoto = VA;
        }

        public void setValorDespertar(despertar VD)
        {
            this.valorDespertar = VD;
        }

        public void setValorCuraTotal(curaTotal VCT)
        {
            this.valorCuraTotal = VCT;
        }

        public void setValorMaxPocion(maxPocion VMP)
        {
            this.valorMaxPocion = VMP;
        }

        public void setValorPrecisionX(precisionX VPX)
        {
            this.valorPrecisionX = VPX;
        }

        public pokemon getValorPokemon()
        {
            return this.valorPokemon;
        }

        public tipo getValorTipo()
        {
            return this.valorTipo;
        }

        public string getValorNombreTipo()
        {
            return this.valorNombreTipo;
        }

        public movimiento getValorMovimiento()
        {
            return this.valorMovimiento;
        }

        public jugador getValorJugador()
        {
            return this.valorJugador;
        }

        public pocion getValorPocion()
        {
            return this.valorPocion;
        }

        public superPocion getValorSuperPocion()
        {
            return this.valorSuperPocion;
        }

        public hiperPocion getValorHiperPocion()
        {
            return this.valorHiperPocion;
        }

        public antiParalisis getValorAntiparalisis()
        {
            return this.valorAntiParalisis;
        }

        public antidoto getValorAntidoto()
        {
            return this.valorAntidoto;
        }

        public despertar getValorDespertar()
        {
            return this.valorDespertar;
        }

        public curaTotal getValorCuraTotal()
        {
            return this.valorCuraTotal;
        }

        public maxPocion getValorMaxPocion()
        {
            return this.valorMaxPocion;
        }

        public precisionX getValorPrecisionX()
        {
            return this.valorPrecisionX;
        }

        public nodo getSiguiente()
        {
            return siguiente;
        }

        public void setSiguiente(nodo siguiente)
        {
            this.siguiente = siguiente;
        }

        public nodo getDer()
        {
            return der;
        }

        public nodo getIzq()
        {
            return izq;
        }

        public int getAltura(nodo nodo)
        {
            if (nodo == null)
            {
                return 0;
            }
            return nodo.altura;
        }

        public void setAltura(int altura)
        {
            this.altura = altura;
        }
    }
}
