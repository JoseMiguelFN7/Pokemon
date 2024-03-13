using System;
using System.Collections.Generic;
using System.Drawing;
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
        private int[] DEF;
        private int[] ATKS;
        private int[] DEFS;
        private int[] VEL;

        public pokemon(int iD, string nombre, int nivel, string tipos, int hP, int aTK, int dEF, int aTKS, int dEFS, int vEL)
        {
            ID = iD;
            this.nombre = nombre;
            this.nivel = nivel;
            this.tipos = new lista();
            this.HP = new int[3];
            this.ATK = new int[3];
            this.DEF = new int[3];
            this.ATKS = new int[3];
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
                DEF[i] = dEF;
                ATKS[i] = aTKS;
                DEFS[i] = dEFS;
                VEL[i] = vEL;
            }
        }

        public void setNombre(string n)
        {
            nombre = n;
        }

        public void setNivel(int n)
        {
            nivel = n;
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

        public int getID()
        {
            return ID;
        }

        public string getNombre()
        {
            return nombre;
        }

        public int getNivel()
        {
            return nivel;
        }

        public lista getTipos()
        {
            return tipos;
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

        public Image getImgFront()
        {
            switch (this.ID)
            {
                case 1:
                    return Properties.Resources._1_bulbasaur;
                case 2:
                    return Properties.Resources._2_ivysaur;
                case 3:
                    return Properties.Resources._3_venusaur;
                case 4:
                    return Properties.Resources._4_charmander;
                case 5:
                    return Properties.Resources._5_charmeleon;
                case 6:
                    return Properties.Resources._6_charizard;
                case 7:
                    return Properties.Resources._7_squirtle;
                case 8:
                    return Properties.Resources._8_wartortle;
                case 9:
                    return Properties.Resources._9_blastoise;
                case 10:
                    return Properties.Resources._10_caterpie;
                case 11:
                    return Properties.Resources._11_metapod;
                case 12:
                    return Properties.Resources._12_butterfree;
                case 13:
                    return Properties.Resources._13_weedle;
                case 14:
                    return Properties.Resources._14_kakuna;
                case 15:
                    return Properties.Resources._15_beedrill;
                case 16:
                    return Properties.Resources._16_pidgey;
                case 17:
                    return Properties.Resources._17_pidgeotto;
                case 18:
                    return Properties.Resources._18_pidgeot;
                case 19:
                    return Properties.Resources._19_rattata;
                case 20:
                    return Properties.Resources._20_raticate;
                case 21:
                    return Properties.Resources._21_spearow;
                case 22:
                    return Properties.Resources._22_fearow;
                case 23:
                    return Properties.Resources._23_ekans;
                case 24:
                    return Properties.Resources._24_arbok;
                case 25:
                    return Properties.Resources._25_pikachu;
                case 26:
                    return Properties.Resources._26_raichu;
                case 27:
                    return Properties.Resources._27_sandshrew;
                case 28:
                    return Properties.Resources._28_sandslash;
                case 29:
                    return Properties.Resources._29_nidoran_f;
                case 30:
                    return Properties.Resources._30_nidorina;
                case 31:
                    return Properties.Resources._31_nidoqueen;
                case 32:
                    return Properties.Resources._32_nidoran_m;
                case 33:
                    return Properties.Resources._33_nidorino;
                case 34:
                    return Properties.Resources._34_nidoking;
                case 35:
                    return Properties.Resources._35_clefairy;
                case 36:
                    return Properties.Resources._36_clefable;
                case 37:
                    return Properties.Resources._37_vulpix;
                case 38:
                    return Properties.Resources._38_ninetales;
                case 39:
                    return Properties.Resources._39_jigglypuff;
                case 40:
                    return Properties.Resources._40_wigglytuff;
                case 41:
                    return Properties.Resources._41_zubat;
                case 42:
                    return Properties.Resources._42_golbat;
                case 43:
                    return Properties.Resources._43_oddish;
                case 44:
                    return Properties.Resources._44_gloom;
                case 45:
                    return Properties.Resources._45_vileplume;
                case 46:
                    return Properties.Resources._46_paras;
                case 47:
                    return Properties.Resources._47_parasect;
                case 48:
                    return Properties.Resources._48_venonat;
                case 49:
                    return Properties.Resources._49_venomoth;
                case 50:
                    return Properties.Resources._50_diglett;
                case 51:
                    return Properties.Resources._51_dugtrio;
                case 52:
                    return Properties.Resources._52_meowth;
                case 53:
                    return Properties.Resources._53_persian;
                case 54:
                    return Properties.Resources._54_psyduck;
                case 55:
                    return Properties.Resources._55_golduck;
                case 56:
                    return Properties.Resources._56_mankey;
                case 57:
                    return Properties.Resources._57_primeape;
                case 58:
                    return Properties.Resources._58_growlithe;
                case 59:
                    return Properties.Resources._59_arcanine;
                case 60:
                    return Properties.Resources._60_poliwag;
                case 61:
                    return Properties.Resources._61_poliwhirl;
                case 62:
                    return Properties.Resources._62_poliwrath;
                case 63:
                    return Properties.Resources._63_abra;
                case 64:
                    return Properties.Resources._64_kadabra;
                case 65:
                    return Properties.Resources._65_alakazam;
                case 66:
                    return Properties.Resources._66_machop;
                case 67:
                    return Properties.Resources._67_machoke;
                case 68:
                    return Properties.Resources._68_machamp;
                case 69:
                    return Properties.Resources._69_bellsprout;
                case 70:
                    return Properties.Resources._70_weepinbell;
                case 71:
                    return Properties.Resources._71_victreebel;
                case 72:
                    return Properties.Resources._72_tentacool;
                case 73:
                    return Properties.Resources._73_tentacruel;
                case 74:
                    return Properties.Resources._74_geodude;
                case 75:
                    return Properties.Resources._75_graveler;
                case 76:
                    return Properties.Resources._76_golem;
                case 77:
                    return Properties.Resources._77_ponyta;
                case 78:
                    return Properties.Resources._78_rapidash;
                case 79:
                    return Properties.Resources._79_slowpoke;
                case 80:
                    return Properties.Resources._80_slowbro;
                case 81:
                    return Properties.Resources._81_magnemite;
                case 82:
                    return Properties.Resources._82_magneton;
                case 83:
                    return Properties.Resources._83_farfetchd;
                case 84:
                    return Properties.Resources._84_doduo;
                case 85:
                    return Properties.Resources._85_dodrio;
                case 86:
                    return Properties.Resources._86_seel;
                case 87:
                    return Properties.Resources._87_dewgong;
                case 88:
                    return Properties.Resources._88_grimer;
                case 89:
                    return Properties.Resources._89_muk;
                case 90:
                    return Properties.Resources._90_shellder;
                case 91:
                    return Properties.Resources._91_cloyster;
                case 92:
                    return Properties.Resources._92_gastly;
                case 93:
                    return Properties.Resources._93_haunter;
                case 94:
                    return Properties.Resources._94_gengar;
                case 95:
                    return Properties.Resources._95_onix;
                case 96:
                    return Properties.Resources._96_drowzee;
                case 97:
                    return Properties.Resources._97_hypno;
                case 98:
                    return Properties.Resources._98_krabby;
                case 99:
                    return Properties.Resources._99_kingler;
                case 100:
                    return Properties.Resources._100_voltorb;
                case 101:
                    return Properties.Resources._101_electrode;
                case 102:
                    return Properties.Resources._102_exeggcute;
                case 103:
                    return Properties.Resources._103_exeggutor;
                case 104:
                    return Properties.Resources._104_cubone;
                case 105:
                    return Properties.Resources._105_marowak;
                case 106:
                    return Properties.Resources._106_hitmonlee;
                case 107:
                    return Properties.Resources._107_hitmonchan;
                case 108:
                    return Properties.Resources._108_lickitung;
                case 109:
                    return Properties.Resources._109_koffing;
                case 110:
                    return Properties.Resources._110_weezing;
                case 111:
                    return Properties.Resources._111_rhyhorn;
                case 112:
                    return Properties.Resources._112_rhydon;
                case 113:
                    return Properties.Resources._113_chansey;
                case 114:
                    return Properties.Resources._114_tangela;
                case 115:
                    return Properties.Resources._115_kangaskhan;
                case 116:
                    return Properties.Resources._116_horsea;
                case 117:
                    return Properties.Resources._117_seadra;
                case 118:
                    return Properties.Resources._118_goldeen;
                case 119:
                    return Properties.Resources._119_seaking;
                case 120:
                    return Properties.Resources._120_staryu;
                case 121:
                    return Properties.Resources._121_starmie;
                case 122:
                    return Properties.Resources._122_mr_mime;
                case 123:
                    return Properties.Resources._123_scyther;
                case 124:
                    return Properties.Resources._124_jynx;
                case 125:
                    return Properties.Resources._125_electabuzz;
                case 126:
                    return Properties.Resources._126_magmar;
                case 127:
                    return Properties.Resources._127_pinsir;
                case 128:
                    return Properties.Resources._128_tauros;
                case 129:
                    return Properties.Resources._129_magikarp;
                case 130:
                    return Properties.Resources._130_gyarados;
                case 131:
                    return Properties.Resources._131_lapras;
                case 132:
                    return Properties.Resources._132_ditto;
                case 133:
                    return Properties.Resources._133_eevee;
                case 134:
                    return Properties.Resources._134_vaporeon;
                case 135:
                    return Properties.Resources._135_jolteon;
                case 136:
                    return Properties.Resources._136_flareon;
                case 137:
                    return Properties.Resources._137_porygon;
                case 138:
                    return Properties.Resources._138_omanyte;
                case 139:
                    return Properties.Resources._139_omastar;
                case 140:
                    return Properties.Resources._140_kabuto;
                case 141:
                    return Properties.Resources._141_kabutops;
                case 142:
                    return Properties.Resources._142_aerodactyl;
                case 143:
                    return Properties.Resources._143_snorlax;
                case 144:
                    return Properties.Resources._144_articuno;
                case 145:
                    return Properties.Resources._145_zapdos;
                case 146:
                    return Properties.Resources._146_moltres;
                case 147:
                    return Properties.Resources._147_dratini;
                case 148:
                    return Properties.Resources._148_dragonair;
                case 149:
                    return Properties.Resources._149_dragonite;
                case 150:
                    return Properties.Resources._150_mewtwo;
                case 151:
                    return Properties.Resources._151_mew;
                default:
                    return null;
            }
        }
    }
}
