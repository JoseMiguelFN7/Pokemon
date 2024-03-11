using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon
{
    public partial class formInicio : Form
    {
        public static tipo[] arrTipos = new tipo[16];
        public formInicio()
        {
            leerTipos();
            Console.WriteLine(arrTipos[13].getInmuneA().esVacia());
            InitializeComponent();
        }

        public static void leerTipos()
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

        private void button1_Click(object sender, EventArgs e)
        {
            formBatalla FB = new formBatalla();
            FB.Show();
        }
    }
}
