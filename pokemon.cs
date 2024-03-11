using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class pokemon
    {
        private int ID;
        private string nombre;
        private int nivel;
        private lista tipos;
        //ARREGLO DE MOVIMIENTOS
        private int[] HP;
        private int[] ATK;
        private int[] ATKS;
        private int[] DEF;
        private int[] DEFS;
        private int[] VEL;

        public pokemon(int iD, string nombre, int nivel, string tipos, int hP, int aTK, int aTKS, int dEF, int dEFS, int vEL)
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
            foreach (string s in arr)
            {
                this.tipos.agregarTipoAlFinal(formInicio.arrTipos[tipo.determinarTipo(s)]);
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
    }
}
