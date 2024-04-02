using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class movimiento   //   ID/NOMBRE/TIPO/POTENCIA/CATEGORIA/PRECISIÓN/ESTADO ALTERATO/EFECTO/USOS/DESCRIPCIÓN
    {
        private int id;
        private string nombre;
        private tipo tipo;
        private int potencia;
        private string categoria;
        private int precision;
        private int estadoAlterado;
        private int efecto;
        private int[] usos;
        private string descripcion;

        public movimiento(int id, string nombre, tipo tipo, int potencia, string categoria, int precision, int estadoAlterado, int efecto, int usos, string descripcion)
        {
            this.id = id;
            this.nombre = nombre;
            this.tipo = tipo;
            this.potencia = potencia;
            this.categoria = categoria;
            this.precision = precision;
            this.estadoAlterado = estadoAlterado;
            this.efecto = efecto;
            this.usos = new int[2];
            this.descripcion = descripcion;

            this.usos[0] = usos;
            this.usos[1] = usos;
        }

        public int getID() 
        { 
            return id;
        }

        public string getNombre()
        {
            return nombre;
        }

        public tipo getTipo()
        {
            return tipo;
        }

        public int getPotencia()
        {
            return potencia;
        }

        public string getCategoria()
        {
            return categoria;
        }

        public int getPrecision()
        {
            return precision;
        }

        public int getEstadoAlterado()
        {
            return estadoAlterado;
        }

        public int getEfecto() 
        {
            return efecto;
        }

        public int getUsos(int pos)
        {
            return usos[pos];
        }

        public string getDescripcion()
        {
            return descripcion;
        }

        public void setUsos(int valor, int pos)
        {
            usos[pos] = valor;
        }

        public void setPrecision(int valor)
        {
            precision = valor;
        }

        public movimiento clonarMov()
        {
            int id = this.id;
            string nombre = this.nombre;
            tipo tipo = this.tipo;
            int potencia = this.potencia;
            string categoria = this.categoria;
            int precision = this.precision;
            int estadoAlterado = this.estadoAlterado;
            int efecto = this.efecto;
            int[] usos = this.usos;
            string descripcion = this.descripcion;

            return new movimiento(id, nombre, tipo, potencia, categoria, precision, estadoAlterado, efecto, usos[0], descripcion);
        }

        public void aumentarStat(pokemon PKM, int n)
        {
            switch (n)
            {
                case 6:
                    PKM.setATK((int)Math.Round(PKM.getATK(1)*1.5), 2);
                    break;
                case 7:
                    PKM.setATKS((int)Math.Round(PKM.getATKS(1) * 1.5), 2);
                    break;
                case 8:
                    PKM.setDEF((int)Math.Round(PKM.getDEF(1) * 1.5), 2);
                    break;
                case 9:
                    PKM.setDEFS((int)Math.Round(PKM.getDEFS(1) * 1.5), 2);
                    break;
                case 10:
                    PKM.setVEL((int)Math.Round(PKM.getVEL(1) * 1.5), 2);
                    break;
            }
        }

        public void disminuirStat(pokemon PKM, int n)
        {
            switch (n)
            {
                case 11:
                    PKM.setATK((int)Math.Round(PKM.getATK(1) / 1.5), 2);
                    break;
                case 12:
                    PKM.setATKS((int)Math.Round(PKM.getATKS(1) / 1.5), 2);
                    break;
                case 13:
                    PKM.setDEF((int)Math.Round(PKM.getDEF(1) / 1.5), 2);
                    break;
                case 14:
                    PKM.setDEFS((int)Math.Round(PKM.getDEFS(1) / 1.5), 2);
                    break;
                case 15:
                    PKM.setVEL((int)Math.Round(PKM.getVEL(1) / 1.5), 2);
                    break;
            }
        }
    }
}
