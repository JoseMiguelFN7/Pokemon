using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                    return 17;
            }
        }

        public static void asignarImagenTipo(tipo T, PictureBox PB)
        {
            switch (T.getNombre())
            {
                case "Normal":
                    PB.Image = Properties.Resources.MovNormal;
                    break;
                case "Fuego":
                    PB.Image = Properties.Resources.MovFuego;
                    break;
                case "Agua":
                    PB.Image = Properties.Resources.MovAgua;
                    break;
                case "Volador":
                    PB.Image = Properties.Resources.MovVolador;
                    break;
                case "Planta":
                    PB.Image = Properties.Resources.MovPlanta;
                    break;
                case "Bicho":
                    PB.Image = Properties.Resources.MovBicho;
                    break;
                case "Eléctrico":
                    PB.Image = Properties.Resources.MovElectrico;
                    break;
                case "Psíquico":
                    PB.Image = Properties.Resources.MovPsiquico;
                    break;
                case "Veneno":
                    PB.Image = Properties.Resources.MovVeneno;
                    break;
                case "Tierra":
                    PB.Image = Properties.Resources.MovTierra;
                    break;
                case "Roca":
                    PB.Image = Properties.Resources.MovRoca;
                    break;
                case "Hielo":
                    PB.Image = Properties.Resources.MovHielo;
                    break;
                case "Lucha":
                    PB.Image = Properties.Resources.MovLucha;
                    break;
                case "Dragón":
                    PB.Image = Properties.Resources.MovDragon;
                    break;
                case "Fantasma":
                    PB.Image = Properties.Resources.MovFantasma;
                    break;
                case "Acero":
                    PB.Image = Properties.Resources.MovAcero;
                    break;
                case "Hada":
                    PB.Image = Properties.Resources.MovHada;
                    break;
            }
        }
    }
}
