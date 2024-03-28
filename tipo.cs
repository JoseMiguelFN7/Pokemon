using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class tipo
    {
        private string nombre;
        private lista eficazContra;
        private lista noEfectivoContra;
        private lista debilContra;
        private lista inmuneA;

        public tipo(string nombre, string eficazContra, string noEfectivoContra, string debilContra, string inmuneA)
        {
            this.nombre = nombre;
            this.eficazContra = new lista();
            this.noEfectivoContra = new lista();
            this.debilContra = new lista();
            this.inmuneA = new lista();

            string[] arr = eficazContra.Split('/');
            if (!arr[0].Equals("no"))
            {
                foreach (string name in arr)
                {
                    this.eficazContra.agregarNombreTipoAlFinal(name);
                }
            }

            arr = noEfectivoContra.Split('/');
            if (!arr[0].Equals("no"))
            {
                foreach (string name in arr)
                {
                    this.noEfectivoContra.agregarNombreTipoAlFinal(name);
                }
            }

            arr = debilContra.Split('/');
            if (!arr[0].Equals("no"))
            {
                foreach (string name in arr)
                {
                    this.debilContra.agregarNombreTipoAlFinal(name);
                }
            }

            arr = inmuneA.Split('/');
            if (!arr[0].Equals("no"))
            {
                foreach (string name in arr)
                {
                    this.inmuneA.agregarNombreTipoAlFinal(name);
                }
            }
        }

        public void setNombre(string n)
        {
            this.nombre = n;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public lista getEficazContra()
        {
            return eficazContra;
        }

        public lista getNoEfectivoContra()
        {
            return noEfectivoContra;
        }

        public lista getDebilContra()
        {
            return debilContra;
        }

        public lista getInmuneA()
        {
            return inmuneA;
        }

        public static int determinarTipo(string s)
        {
            switch (s)
            {
                case "Normal":
                    return 0;
                case "Fuego":
                    return 1;
                case "Agua":
                    return 2;
                case "Volador":
                    return 3;
                case "Planta":
                    return 4;
                case "Bicho":
                    return 5;
                case "Eléctrico":
                    return 6;
                case "Psíquico":
                    return 7;
                case "Veneno":
                    return 8;
                case "Tierra":
                    return 9;
                case "Roca":
                    return 10;
                case "Hielo":
                    return 11;
                case "Lucha":
                    return 12;
                case "Dragón":
                    return 13;
                case "Fantasma":
                    return 14;
                case "Acero":
                    return 15;
                case "Hada":
                    return 16;
                default:
                    Console.WriteLine("EEEEERROOOOOOOOOOOOOOOOOOOOOOOOOR");
                    Console.WriteLine(s);
                    return 17;
            }
        }
    }
}
