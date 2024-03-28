using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class archivo
    {
        public static string leerArchivo(string file)
        {
            if (File.Exists(file))
            {
                StreamReader sr = new StreamReader(file);
                string texto, line;
                line = sr.ReadLine();
                texto = line;
                while ((line = sr.ReadLine()) != null)
                {
                    texto += "\n" + line;
                }
                sr.Close();
                return texto;
            }
            return null;
        }

        public static void escribirArchivo(string texto, string file)
        {
            StreamWriter sw = new StreamWriter(file);
            sw.WriteLine(texto);
            sw.Close();
        }
    }
}
