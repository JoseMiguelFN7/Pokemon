using System;

namespace Pokemon
{
    public class Pokemon
    {
        private int ID;
        private string nombre;
        private int nivel;
        private lista tipos;
        private int[] HP;
        private int[] ATK;
        private int[] ATKS;
        private int[] DEF;
        private int[] DEFS;
        private int[] VEL;

        public Pokemon(int iD, string nombre, int nivel, string tipos, int hP, int aTK, int aTKS, int dEF, int dEFS, int vEL)
        {
            ID = iD;
            this.nombre = nombre;
            this.nivel = nivel;
            this.tipos = new lista();
            this.HP = new int[3];
            this.ATK = new int[3];
            this.ATKS = new int[3];
            this.DEF = new int[3];
            this.DEFS = new int[3];
            this.VEL = new int[3];

            string[] arr = tipos.Split('/');
            tipo[] tiposArray = formSeleccionarEquipo.ObtenerTipos();
            if (tiposArray != null)
            {
                foreach (string s in arr)
                {
                    int tipoIndex = tipo.determinarTipo(s);
                    if (tipoIndex >= 0 && tipoIndex < tiposArray.Length)
                    {
                        this.tipos.agregarTipoAlFinal(tiposArray[tipoIndex]);
                    }
                    else
                    {
                        Console.WriteLine($"Error: Tipo {s} no encontrado.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Error: No se pudo obtener la lista de tipos de Pokémon.");
            }

            for (int i = 0; i < 3; i++)
            {
                HP[i] = hP;
                ATK[i] = aTK;
                ATKS[i] = aTKS;
                DEF[i] = dEF;
                DEFS[i] = dEFS;
                VEL[i] = vEL;
            }
        }

        public void setHP(int hp, int pos)
        {
            HP[pos] = hp;
        }

        public void setATK(int atk, int pos)
        {
            ATK[pos] = atk;
        }

        public void setATKS(int atks, int pos)
        {
            ATKS[pos] = atks;
        }

        public void setDEF(int def, int pos)
        {
            DEF[pos] = def;
        }

        public void setDEFS(int defs, int pos)
        {
            DEFS[pos] = defs;
        }

        public void setVEL(int vel, int pos)
        {
            VEL[pos] = vel;
        }

        public int getHP(int pos)
        {
            return HP[pos];
        }

        public int getATK(int pos)
        {
            return ATK[pos];
        }

        public int getATKS(int pos)
        {
            return ATKS[pos];
        }

        public int getDEF(int pos)
        {
            return DEF[pos];
        }

        public int getDEFS(int pos)
        {
            return DEFS[pos];
        }

        public int getVEL(int pos)
        {
            return VEL[pos];
        }

        public override string ToString()
        {
            return nombre;
        }

        public int getID()
        {
            return ID;
        }
    }
}
