﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon
{
    public partial class formInicio : Form
    {
        public static tipo[] arrTipos = new tipo[18];
        public static pokemon[] arrPKM = new pokemon[151];
        public static objeto[] arrObj = new objeto[9];

        public formInicio()
        {
            leerTipos();
            leerPokemon();
            llenarArrObj();
            Console.WriteLine(arrPKM[0].getNombre());
            Console.WriteLine(arrPKM[0].getID());
            Console.WriteLine(arrPKM[0].getNivel());
            Console.WriteLine(arrPKM[0].getHP(0));
            Console.WriteLine(arrPKM[0].getATK(0));
            Console.WriteLine(arrPKM[0].getDEF(0));
            Console.WriteLine(arrPKM[0].getATKS(0));
            Console.WriteLine(arrPKM[0].getDEFS(0));
            Console.WriteLine(arrPKM[0].getVEL(0));
            Console.WriteLine(arrPKM[0].getTipos().getInicio().getValorTipo().getNombre());
            if (arrPKM[0].getTipos().getTamanio() > 1)
            {
                Console.WriteLine(arrPKM[0].getTipos().getInicio().getSiguiente().getValorTipo().getNombre());
            }
            InitializeComponent();
        }

        public void leerTipos()
        {
            string ruta = Path.Combine(Application.StartupPath, "Archivostxt\\Tipos.txt");
            string texto = archivo.leerArchivo(ruta);

            string[] stringTipos = texto.Split('\n');

            int i = 0;
            foreach (String t in stringTipos)
            {
                string[] datosTipos = t.Split(',');
                tipo tNuevo = new tipo(datosTipos[0], datosTipos[1], datosTipos[2], datosTipos[3], datosTipos[4]);
                arrTipos[i++] = tNuevo;
            }
        }

        public void leerPokemon()
        {
            string ruta = Path.Combine(Application.StartupPath, "Archivostxt\\PKM.txt");
            string texto = archivo.leerArchivo(ruta);

            string[] stringPKM = texto.Split('\n');

            int i = 0;
            foreach (String p in stringPKM)
            {
                string[] datosPKM = p.Split(',');
                pokemon PKMNuevo = new pokemon(int.Parse(datosPKM[0]), datosPKM[1], 50, datosPKM[2], int.Parse(datosPKM[3]), int.Parse(datosPKM[4]), int.Parse(datosPKM[5]), int.Parse(datosPKM[6]), int.Parse(datosPKM[7]), int.Parse(datosPKM[8]));
                arrPKM[i++] = PKMNuevo;
            }
        }
        
        public void llenarArrObj()
        {
            arrObj[0] = new pocion();
            arrObj[1] = new superPocion();
            arrObj[2] = new hiperPocion();
            arrObj[3] = new antiParalisis();
            arrObj[4] = new antidoto();
            arrObj[5] = new despertar();
            arrObj[6] = new curaTotal();
            arrObj[7] = new maxPocion();
            arrObj[8] = new precisionX();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formBatalla FB = new formBatalla();
            FB.Show();
            this.Hide();
        }
    }
}