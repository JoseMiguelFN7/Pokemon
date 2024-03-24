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
        private pocion valorPocion;
        private superPocion valorSuperPocion;
        private hiperPocion valorHiperPocion;
        private antiParalisis valorAntiParalisis;
        private antidoto valorAntidoto;
        private despertar valorDespertar;
        private curaTotal valorCuraTotal;
        private maxPocion valorMaxPocion;
        private precisionX valorPrecisionX;
        private nodo siguiente;

        public nodo()
        {
            this.valorTipo = null;
            this.valorNombreTipo = null;
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

        public tipo getValorTipo()
        {
            return this.valorTipo;
        }

        public string getValorNombreTipo()
        {
            return this.valorNombreTipo;
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
        public void setValorPokemon(pokemon p)
        {
            this.valorPokemon = p;
        }

        public pokemon getValorPokemon()
        {
            return this.valorPokemon;
        }
    }
}
