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
        private movimiento[] movimientos;
        private int[] HP;
        private int[] ATK;
        private int[] DEF;
        private int[] ATKS;
        private int[] DEFS;
        private int[] VEL;

        public pokemon(int iD, string nombre, int nivel, string tipos, int hP, int aTK, int dEF, int aTKS, int dEFS, int vEL)
        {//AGREGAR MOVIMIENTOS AL ARREGLO
            ID = iD;
            this.nombre = nombre;
            this.nivel = nivel;
            this.tipos = new lista();
            this.movimientos = new movimiento[4];
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

        public void setMovimiento(movimiento move, int pos)
        {
            movimientos[pos] = move;
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

        public movimiento getMovimientos(int pos)
        {
            return movimientos[pos];
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

        public Image[] getImg()
        {
            Image[] images = new Image[2];
            switch (this.ID)
            {
                case 1:
                    images[0] = Properties.Resources._1_bulbasaur;
                    images[1] = Properties.Resources._1_bulbasaur_back;
                    break;
                case 2:
                    images[0] = Properties.Resources._2_ivysaur;
                    images[1] = Properties.Resources._2_ivysaur_back;
                    break;
                case 3:
                    images[0] = Properties.Resources._3_venusaur;
                    images[1] = Properties.Resources._3_venusaur_back;
                    break;
                case 4:
                    images[0] = Properties.Resources._4_charmander;
                    images[1] = Properties.Resources._4_charmander_back;
                    break;
                case 5:
                    images[0] = Properties.Resources._5_charmeleon;
                    images[1] = Properties.Resources._5_charmeleon_back;
                    break;
                case 6:
                    images[0] = Properties.Resources._6_charizard;
                    images[1] = Properties.Resources._6_charizard_back;
                    break;
                case 7:
                    images[0] = Properties.Resources._7_squirtle;
                    images[1] = Properties.Resources._7_squirtle_back;
                    break;
                case 8:
                    images[0] = Properties.Resources._8_wartortle;
                    images[1] = Properties.Resources._8_wartortle_back;
                    break;
                case 9:
                    images[0] = Properties.Resources._9_blastoise;
                    images[1] = Properties.Resources._9_blastoise_back;
                    break;
                case 10:
                    images[0] = Properties.Resources._10_caterpie;
                    images[1] = Properties.Resources._10_caterpie_back;
                    break;
                case 11:
                    images[0] = Properties.Resources._11_metapod;
                    images[1] = Properties.Resources._11_metapod_back;
                    break;
                case 12:
                    images[0] = Properties.Resources._12_butterfree;
                    images[1] = Properties.Resources._12_butterfree_back;
                    break;
                case 13:
                    images[0] = Properties.Resources._13_weedle;
                    images[1] = Properties.Resources._13_weedle_back;
                    break;
                case 14:
                    images[0] = Properties.Resources._14_kakuna;
                    images[1] = Properties.Resources._14_kakuna_back;
                    break;
                case 15:
                    images[0] = Properties.Resources._15_beedrill;
                    images[1] = Properties.Resources._15_beedrill_back;
                    break;
                case 16:
                    images[0] = Properties.Resources._16_pidgey;

                    break;
                case 17:
                    images[0] = Properties.Resources._17_pidgeotto;

                    break;
                case 18:
                    images[0] = Properties.Resources._18_pidgeot;

                    break;
                case 19:
                    images[0] = Properties.Resources._19_rattata;

                    break;
                case 20:
                    images[0] = Properties.Resources._20_raticate;

                    break;
                case 21:
                    images[0] = Properties.Resources._21_spearow;

                    break;
                case 22:
                    images[0] = Properties.Resources._22_fearow;

                    break;
                case 23:
                    images[0] = Properties.Resources._23_ekans;

                    break;
                case 24:
                    images[0] = Properties.Resources._24_arbok;

                    break;
                case 25:
                    images[0] = Properties.Resources._25_pikachu;

                    break;
                case 26:
                    images[0] = Properties.Resources._26_raichu;

                    break;
                case 27:
                    images[0] = Properties.Resources._27_sandshrew;

                    break;
                case 28:
                    images[0] = Properties.Resources._28_sandslash;

                    break;
                case 29:
                    images[0] = Properties.Resources._29_nidoran_f;

                    break;
                case 30:
                    images[0] = Properties.Resources._30_nidorina;

                    break;
                case 31:
                    images[0] = Properties.Resources._31_nidoqueen;

                    break;
                case 32:
                    images[0] = Properties.Resources._32_nidoran_m;

                    break;
                case 33:
                    images[0] = Properties.Resources._33_nidorino;

                    break;
                case 34:
                    images[0] = Properties.Resources._34_nidoking;

                    break;
                case 35:
                    images[0] = Properties.Resources._35_clefairy;

                    break;
                case 36:
                    images[0] = Properties.Resources._36_clefable;

                    break;
                case 37:
                    images[0] = Properties.Resources._37_vulpix;

                    break;
                case 38:
                    images[0] = Properties.Resources._38_ninetales;

                    break;
                case 39:
                    images[0] = Properties.Resources._39_jigglypuff;

                    break;
                case 40:
                    images[0] = Properties.Resources._40_wigglytuff;

                    break;
                case 41:
                    images[0] = Properties.Resources._41_zubat;

                    break;
                case 42:
                    images[0] = Properties.Resources._42_golbat;

                    break;
                case 43:
                    images[0] = Properties.Resources._43_oddish;

                    break;
                case 44:
                    images[0] = Properties.Resources._44_gloom;

                    break;
                case 45:
                    images[0] = Properties.Resources._45_vileplume;

                    break;
                case 46:
                    images[0] = Properties.Resources._19_rattata;

                    break;
                case 47:
                    images[0] = Properties.Resources._47_parasect;

                    break;
                case 48:
                    images[0] = Properties.Resources._48_venonat;

                    break;
                case 49:
                    images[0] = Properties.Resources._49_venomoth;

                    break;
                case 50:
                    images[0] = Properties.Resources._50_diglett;

                    break;
                case 51:
                    images[0] = Properties.Resources._51_dugtrio;

                    break;
                case 52:
                    images[0] = Properties.Resources._52_meowth;

                    break;
                case 53:
                    images[0] = Properties.Resources._53_persian;

                    break;
                case 54:
                    images[0] = Properties.Resources._54_psyduck;

                    break;
                case 55:
                    images[0] = Properties.Resources._55_golduck;

                    break;
                case 56:
                    images[0] = Properties.Resources._56_mankey;

                    break;
                case 57:
                    images[0] = Properties.Resources._57_primeape;

                    break;
                case 58:
                    images[0] = Properties.Resources._58_growlithe;

                    break;
                case 59:
                    images[0] = Properties.Resources._59_arcanine;

                    break;
                case 60:
                    images[0] = Properties.Resources._60_poliwag;

                    break;
                case 61:
                    images[0] = Properties.Resources._61_poliwhirl;

                    break;
                case 62:
                    images[0] = Properties.Resources._62_poliwrath;

                    break;
                case 63:
                    images[0] = Properties.Resources._63_abra;

                    break;
                case 64:
                    images[0] = Properties.Resources._64_kadabra;

                    break;
                case 65:
                    images[0] = Properties.Resources._65_alakazam;

                    break;
                case 66:
                    images[0] = Properties.Resources._66_machop;

                    break;
                case 67:
                    images[0] = Properties.Resources._67_machoke;

                    break;
                case 68:
                    images[0] = Properties.Resources._68_machamp;

                    break;
                case 69:
                    images[0] = Properties.Resources._69_bellsprout;

                    break;
                case 70:
                    images[0] = Properties.Resources._70_weepinbell;

                    break;
                case 71:
                    images[0] = Properties.Resources._71_victreebel;

                    break;
                case 72:
                    images[0] = Properties.Resources._72_tentacool;

                    break;
                case 73:
                    images[0] = Properties.Resources._73_tentacruel;

                    break;
                case 74:
                    images[0] = Properties.Resources._74_geodude;

                    break;
                case 75:
                    images[0] = Properties.Resources._75_graveler;

                    break;
                case 76:
                    images[0] = Properties.Resources._76_golem;

                    break;
                case 77:
                    images[0] = Properties.Resources._77_ponyta;

                    break;
                case 78:
                    images[0] = Properties.Resources._78_rapidash;

                    break;
                case 79:
                    images[0] = Properties.Resources._79_slowpoke;

                    break;
                case 80:
                    images[0] = Properties.Resources._80_slowbro;

                    break;
                case 81:
                    images[0] = Properties.Resources._81_magnemite;

                    break;
                case 82:
                    images[0] = Properties.Resources._82_magneton;

                    break;
                case 83:
                    images[0] = Properties.Resources._83_farfetchd;

                    break;
                case 84:
                    images[0] = Properties.Resources._84_doduo;

                    break;
                case 85:
                    images[0] = Properties.Resources._85_dodrio;

                    break;
                case 86:
                    images[0] = Properties.Resources._86_seel;

                    break;
                case 87:
                    images[0] = Properties.Resources._87_dewgong;

                    break;
                case 88:
                    images[0] = Properties.Resources._88_grimer;

                    break;
                case 89:
                    images[0] = Properties.Resources._89_muk;

                    break;
                case 90:
                    images[0] = Properties.Resources._90_shellder;

                    break;
                case 91:
                    images[0] = Properties.Resources._91_cloyster;

                    break;
                case 92:
                    images[0] = Properties.Resources._92_gastly;

                    break;
                case 93:
                    images[0] = Properties.Resources._93_haunter;

                    break;
                case 94:
                    images[0] = Properties.Resources._94_gengar;

                    break;
                case 95:
                    images[0] = Properties.Resources._95_onix;

                    break;
                case 96:
                    images[0] = Properties.Resources._96_drowzee;

                    break;
                case 97:
                    images[0] = Properties.Resources._97_hypno;

                    break;
                case 98:
                    images[0] = Properties.Resources._98_krabby;

                    break;
                case 99:
                    images[0] = Properties.Resources._99_kingler;

                    break;
                case 100:
                    images[0] = Properties.Resources._100_voltorb;

                    break;
                case 101:
                    images[0] = Properties.Resources._101_electrode;

                    break;
                case 102:
                    images[0] = Properties.Resources._102_exeggcute;

                    break;
                case 103:
                    images[0] = Properties.Resources._103_exeggutor;

                    break;
                case 104:
                    images[0] = Properties.Resources._104_cubone;

                    break;
                case 105:
                    images[0] = Properties.Resources._105_marowak;

                    break;
                case 106:
                    images[0] = Properties.Resources._106_hitmonlee;

                    break;
                case 107:
                    images[0] = Properties.Resources._107_hitmonchan;

                    break;
                case 108:
                    images[0] = Properties.Resources._108_lickitung;

                    break;
                case 109:
                    images[0] = Properties.Resources._109_koffing;

                    break;
                case 110:
                    images[0] = Properties.Resources._110_weezing;

                    break;
                case 111:
                    images[0] = Properties.Resources._111_rhyhorn;

                    break;
                case 112:
                    images[0] = Properties.Resources._112_rhydon;

                    break;
                case 113:
                    images[0] = Properties.Resources._113_chansey;

                    break;
                case 114:
                    images[0] = Properties.Resources._114_tangela;

                    break;
                case 115:
                    images[0] = Properties.Resources._115_kangaskhan;

                    break;
                case 116:
                    images[0] = Properties.Resources._116_horsea;

                    break;
                case 117:
                    images[0] = Properties.Resources._117_seadra;

                    break;
                case 118:
                    images[0] = Properties.Resources._118_goldeen;

                    break;
                case 119:
                    images[0] = Properties.Resources._119_seaking;

                    break;
                case 120:
                    images[0] = Properties.Resources._120_staryu;

                    break;
                case 121:
                    images[0] = Properties.Resources._121_starmie;

                    break;
                case 122:
                    images[0] = Properties.Resources._122_mr_mime;

                    break;
                case 123:
                    images[0] = Properties.Resources._123_scyther;

                    break;
                case 124:
                    images[0] = Properties.Resources._124_jynx;

                    break;
                case 125:
                    images[0] = Properties.Resources._125_electabuzz;

                    break;
                case 126:
                    images[0] = Properties.Resources._126_magmar;

                    break;
                case 127:
                    images[0] = Properties.Resources._127_pinsir;

                    break;
                case 128:
                    images[0] = Properties.Resources._128_tauros;

                    break;
                case 129:
                    images[0] = Properties.Resources._129_magikarp;

                    break;
                case 130:
                    images[0] = Properties.Resources._130_gyarados;

                    break;
                case 131:
                    images[0] = Properties.Resources._131_lapras;

                    break;
                case 132:
                    images[0] = Properties.Resources._132_ditto;

                    break;
                case 133:
                    images[0] = Properties.Resources._133_eevee;

                    break;
                case 134:
                    images[0] = Properties.Resources._134_vaporeon;

                    break;
                case 135:
                    images[0] = Properties.Resources._135_jolteon;

                    break;
                case 136:
                    images[0] = Properties.Resources._136_flareon;

                    break;
                case 137:
                    images[0] = Properties.Resources._137_porygon;

                    break;
                case 138:
                    images[0] = Properties.Resources._138_omanyte;

                    break;
                case 139:
                    images[0] = Properties.Resources._139_omastar;

                    break;
                case 140:
                    images[0] = Properties.Resources._140_kabuto;

                    break;
                case 141:
                    images[0] = Properties.Resources._141_kabutops;

                    break;
                case 142:
                    images[0] = Properties.Resources._142_aerodactyl;

                    break;
                case 143:
                    images[0] = Properties.Resources._143_snorlax;

                    break;
                case 144:
                    images[0] = Properties.Resources._144_articuno;

                    break;
                case 145:
                    images[0] = Properties.Resources._145_zapdos;

                    break;
                case 146:
                    images[0] = Properties.Resources._146_moltres;

                    break;
                case 147:
                    images[0] = Properties.Resources._147_dratini;

                    break;
                case 148:
                    images[0] = Properties.Resources._148_dragonair;

                    break;
                case 149:
                    images[0] = Properties.Resources._149_dragonite;

                    break;
                case 150:
                    images[0] = Properties.Resources._150_mewtwo;

                    break;
                case 151:
                    images[0] = Properties.Resources._151_mew;

                    break;
                default:
                    images[0] = null;
                    images[1] = null;
                    break;
            }
            return images;
        }
    }
}
