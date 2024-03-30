using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        private int estadoAlterado;
        private double probRecuperar;
        bool ditto;

        public pokemon(int iD, string nombre, int nivel, string tipos, int hP, int aTK, int dEF, int aTKS, int dEFS, int vEL, string movs)
        {
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
            this.estadoAlterado = 0;
            this.probRecuperar = 0;
            if (iD == 132)
            {
                this.ditto = true;
            }
            else
            {
                this.ditto = false;
            }

            string[] arrT = tipos.Split('/');
            foreach (string t in arrT)
            {
                this.tipos.agregarTipoAlFinal(formInicio.arrTipos[tipo.determinarTipo(t)]);
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

            string[] arrM = movs.Split('/');
            int contador = 0;
            foreach (string m in arrM)
            {
                this.movimientos[contador++] = formInicio.movimientos.obtenerMovID(int.Parse(m)).clonarMov();
            }
        }

        public void setID(int id)
        {
            ID = id;
        }

        public void setNombre(string n)
        {
            nombre = n;
        }

        public void setNivel(int n)
        {
            nivel = n;
        }

        public void setTipos(lista t)
        {
            tipos = t;
        }

        public void setMovimiento(movimiento move, int pos)
        {
            movimientos[pos] = move;
        }

        public void setArrMovimiento(movimiento[] arrMov)
        {
            movimientos = arrMov;
        }

        public void setHP(int hp, int pos)
        {
            HP[pos] = hp;
        }

        public void setArrHP(int[] arrHp)
        {
            HP = arrHp;
        }

        public void setATK(int atk, int pos)
        {
            ATK[pos] = atk;
        }
        public void setArrATK(int[] arrAtk)
        {
            ATK = arrAtk;
        }

        public void setATKS(int atks, int pos)
        {
            ATKS[pos] = atks;
        }

        public void setArrATKS(int[] arrAtkS)
        {
            ATKS = arrAtkS;
        }

        public void setDEF(int def, int pos)
        {
            DEF[pos] = def;
        }

        public void setArrDEF(int[] arrDef)
        {
            DEF = arrDef;
        }

        public void setDEFS(int defs, int pos)
        {
            DEFS[pos] = defs;
        }

        public void setArrDEFS(int[] arrDefS)
        {
            DEFS = arrDefS;
        }

        public void setVEL(int vel, int pos)
        {
            VEL[pos] = vel;
        }

        public void setArrVEL(int[] arrVel)
        {
            VEL = arrVel;
        }

        public void setEstadoAlterado(int EA)
        {
            estadoAlterado = EA;
        }

        public void setProbRecuperar(double PR)
        {
            this.probRecuperar = PR;
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

        public movimiento[] getMovimientos()
        {
            return movimientos;
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

        public int getEstadoAlterado()
        {
            return estadoAlterado;
        }

        public double getProbRecuperar()
        {
            return probRecuperar;
        }

        public Image[] getImg()
        {
            Image[] images = new Image[3];
            switch (this.ID)
            {
                case 1:
                    images[0] = Properties.Resources._1_bulbasaur;
                    images[1] = Properties.Resources._1_bulbasaur_back;
                    images[2] = Properties.Resources._1;
                    break;
                case 2:
                    images[0] = Properties.Resources._2_ivysaur;
                    images[1] = Properties.Resources._2_ivysaur_back;
                    images[2] = Properties.Resources._2;
                    break;
                case 3:
                    images[0] = Properties.Resources._3_venusaur;
                    images[1] = Properties.Resources._3_venusaur_back;
                    images[2] = Properties.Resources._3;
                    break;
                case 4:
                    images[0] = Properties.Resources._4_charmander;
                    images[1] = Properties.Resources._4_charmander_back;
                    images[2] = Properties.Resources._4;
                    break;
                case 5:
                    images[0] = Properties.Resources._5_charmeleon;
                    images[1] = Properties.Resources._5_charmeleon_back;
                    images[2] = Properties.Resources._5;
                    break;
                case 6:
                    images[0] = Properties.Resources._6_charizard;
                    images[1] = Properties.Resources._6_charizard_back;
                    images[2] = Properties.Resources._6;
                    break;
                case 7:
                    images[0] = Properties.Resources._7_squirtle;
                    images[1] = Properties.Resources._7_squirtle_back;
                    images[2] = Properties.Resources._7;
                    break;
                case 8:
                    images[0] = Properties.Resources._8_wartortle;
                    images[1] = Properties.Resources._8_wartortle_back;
                    images[2] = Properties.Resources._8;
                    break;
                case 9:
                    images[0] = Properties.Resources._9_blastoise;
                    images[1] = Properties.Resources._9_blastoise_back;
                    images[2] = Properties.Resources._9;
                    break;
                case 10:
                    images[0] = Properties.Resources._10_caterpie;
                    images[1] = Properties.Resources._10_caterpie_back;
                    images[2] = Properties.Resources._10;
                    break;
                case 11:
                    images[0] = Properties.Resources._11_metapod;
                    images[1] = Properties.Resources._11_metapod_back;
                    images[2] = Properties.Resources._11;
                    break;
                case 12:
                    images[0] = Properties.Resources._12_butterfree;
                    images[1] = Properties.Resources._12_butterfree_back;
                    images[2] = Properties.Resources._12;
                    break;
                case 13:
                    images[0] = Properties.Resources._13_weedle;
                    images[1] = Properties.Resources._13_weedle_back;
                    images[2] = Properties.Resources._13;
                    break;
                case 14:
                    images[0] = Properties.Resources._14_kakuna;
                    images[1] = Properties.Resources._14_kakuna_back;
                    images[2] = Properties.Resources._14;
                    break;
                case 15:
                    images[0] = Properties.Resources._15_beedrill;
                    images[1] = Properties.Resources._15_beedrill_back;
                    images[2] = Properties.Resources._15;
                    break;
                case 16:
                    images[0] = Properties.Resources._16_pidgey;
                    images[1] = Properties.Resources._16_pidgey_back;
                    images[2] = Properties.Resources._16;
                    break;
                case 17:
                    images[0] = Properties.Resources._17_pidgeotto;
                    images[1] = Properties.Resources._17_pidgeotto_back;
                    images[2] = Properties.Resources._17;
                    break;
                case 18:
                    images[0] = Properties.Resources._18_pidgeot;
                    images[1] = Properties.Resources._18_pidgeot_back;
                    images[2] = Properties.Resources._18;
                    break;
                case 19:
                    images[0] = Properties.Resources._19_rattata;
                    images[1] = Properties.Resources._19_rattata_back;
                    images[2] = Properties.Resources._19;
                    break;
                case 20:
                    images[0] = Properties.Resources._20_raticate;
                    images[1] = Properties.Resources._21_spearow_back;
                    images[2] = Properties.Resources._20;
                    break;
                case 21:
                    images[0] = Properties.Resources._21_spearow;
                    images[1] = Properties.Resources._21_spearow_back;
                    images[2] = Properties.Resources._21;
                    break;
                case 22:
                    images[0] = Properties.Resources._22_fearow;
                    images[1] = Properties.Resources._22_fearow_back;
                    images[2] = Properties.Resources._22;
                    break;
                case 23:
                    images[0] = Properties.Resources._23_ekans;
                    images[1] = Properties.Resources._23_ekans_back;
                    images[2] = Properties.Resources._23;
                    break;
                case 24:
                    images[0] = Properties.Resources._24_arbok;
                    images[1] = Properties.Resources._25_pikachu_back;
                    images[2] = Properties.Resources._24;
                    break;
                case 25:
                    images[0] = Properties.Resources._25_pikachu;
                    images[1] = Properties.Resources._25_pikachu_back;
                    images[2] = Properties.Resources._25;
                    break;
                case 26:
                    images[0] = Properties.Resources._26_raichu;
                    images[1] = Properties.Resources._26_raichu_back;
                    images[2] = Properties.Resources._26;
                    break;
                case 27:
                    images[0] = Properties.Resources._27_sandshrew;
                    images[1] = Properties.Resources._27_sandshrew_back;
                    images[2] = Properties.Resources._27;
                    break;
                case 28:
                    images[0] = Properties.Resources._28_sandslash;
                    images[1] = Properties.Resources._28_sandslash_back;
                    images[2] = Properties.Resources._28;
                    break;
                case 29:
                    images[0] = Properties.Resources._29_nidoran_f;
                    images[1] = Properties.Resources._29_nidoran_f_back;
                    images[2] = Properties.Resources._29;
                    break;
                case 30:
                    images[0] = Properties.Resources._30_nidorina;
                    images[1] = Properties.Resources._30_nidorina_back;
                    images[2] = Properties.Resources._30;
                    break;
                case 31:
                    images[0] = Properties.Resources._31_nidoqueen;
                    images[1] = Properties.Resources._31_nidoqueen_back;
                    images[2] = Properties.Resources._31;
                    break;
                case 32:
                    images[0] = Properties.Resources._32_nidoran_m;
                    images[1] = Properties.Resources._32_nidoran_m_back;
                    images[2] = Properties.Resources._32;
                    break;
                case 33:
                    images[0] = Properties.Resources._33_nidorino;
                    images[1] = Properties.Resources._33_nidorino_back;
                    images[2] = Properties.Resources._33;
                    break;
                case 34:
                    images[0] = Properties.Resources._34_nidoking;
                    images[1] = Properties.Resources._34_nidoking_back;
                    images[2] = Properties.Resources._34;
                    break;
                case 35:
                    images[0] = Properties.Resources._35_clefairy;
                    images[1] = Properties.Resources._35_clefairy_back;
                    images[2] = Properties.Resources._35;
                    break;
                case 36:
                    images[0] = Properties.Resources._36_clefable;
                    images[1] = Properties.Resources._36_clefable_back;
                    images[2] = Properties.Resources._36;
                    break;
                case 37:
                    images[0] = Properties.Resources._37_vulpix;
                    images[1] = Properties.Resources._37_vulpix_back;
                    images[2] = Properties.Resources._37;
                    break;
                case 38:
                    images[0] = Properties.Resources._38_ninetales;
                    images[1] = Properties.Resources._38_ninetales_back;
                    images[2] = Properties.Resources._38;
                    break;
                case 39:
                    images[0] = Properties.Resources._39_jigglypuff;
                    images[1] = Properties.Resources._39_jigglypuff_back;
                    images[2] = Properties.Resources._39;
                    break;
                case 40:
                    images[0] = Properties.Resources._40_wigglytuff;
                    images[1] = Properties.Resources._40_wigglytuff_back;
                    images[2] = Properties.Resources._40;
                    break;
                case 41:
                    images[0] = Properties.Resources._41_zubat;
                    images[1] = Properties.Resources._41_zubat_back;
                    images[2] = Properties.Resources._41;
                    break;
                case 42:
                    images[0] = Properties.Resources._42_golbat;
                    images[1] = Properties.Resources._42_golbat_back;
                    images[2] = Properties.Resources._42;
                    break;
                case 43:
                    images[0] = Properties.Resources._43_oddish;
                    images[1] = Properties.Resources._43_oddish_back;
                    images[2] = Properties.Resources._43;
                    break;
                case 44:
                    images[0] = Properties.Resources._44_gloom;
                    images[1] = Properties.Resources._44_gloom_back;
                    images[2] = Properties.Resources._44;
                    break;
                case 45:
                    images[0] = Properties.Resources._45_vileplume;
                    images[1] = Properties.Resources._45_vileplume_back;
                    images[2] = Properties.Resources._45;
                    break;
                case 46:
                    images[0] = Properties.Resources._46_paras;
                    images[1] = Properties.Resources._46_paras_back;
                    images[2] = Properties.Resources._46;
                    break;
                case 47:
                    images[0] = Properties.Resources._47_parasect;
                    images[1] = Properties.Resources._47_parasect_back;
                    images[2] = Properties.Resources._47;
                    break;
                case 48:
                    images[0] = Properties.Resources._48_venonat;
                    images[1] = Properties.Resources._48_venonat_back;
                    images[2] = Properties.Resources._48;
                    break;
                case 49:
                    images[0] = Properties.Resources._49_venomoth;
                    images[1] = Properties.Resources._49_venomoth_back;
                    images[2] = Properties.Resources._49;
                    break;
                case 50:
                    images[0] = Properties.Resources._50_diglett;
                    images[1] = Properties.Resources._50_diglett_back;
                    images[2] = Properties.Resources._50;
                    break;
                case 51:
                    images[0] = Properties.Resources._51_dugtrio;
                    images[1] = Properties.Resources._51_dugtrio_back;
                    images[2] = Properties.Resources._51;
                    break;
                case 52:
                    images[0] = Properties.Resources._52_meowth;
                    images[1] = Properties.Resources._52_meowth_back;
                    images[2] = Properties.Resources._52;
                    break;
                case 53:
                    images[0] = Properties.Resources._53_persian;
                    images[1] = Properties.Resources._53_persian_back;
                    images[2] = Properties.Resources._53;
                    break;
                case 54:
                    images[0] = Properties.Resources._54_psyduck;
                    images[1] = Properties.Resources._54_psyduck_back;
                    images[2] = Properties.Resources._54;
                    break;
                case 55:
                    images[0] = Properties.Resources._55_golduck;
                    images[1] = Properties.Resources._55_golduck_back;
                    images[2] = Properties.Resources._55;
                    break;
                case 56:
                    images[0] = Properties.Resources._56_mankey;
                    images[1] = Properties.Resources._56_mankey_back;
                    images[2] = Properties.Resources._56;
                    break;
                case 57:
                    images[0] = Properties.Resources._57_primeape;
                    images[1] = Properties.Resources._57_primeape_back;
                    images[2] = Properties.Resources._57;
                    break;
                case 58:
                    images[0] = Properties.Resources._58_growlithe;
                    images[1] = Properties.Resources._58_growlithe_back;
                    images[2] = Properties.Resources._58;
                    break;
                case 59:
                    images[0] = Properties.Resources._59_arcanine;
                    images[1] = Properties.Resources._59_arcanine_back;
                    images[2] = Properties.Resources._59;
                    break;
                case 60:
                    images[0] = Properties.Resources._60_poliwag;
                    images[1] = Properties.Resources._60_poliwag_back;
                    images[2] = Properties.Resources._60;
                    break;
                case 61:
                    images[0] = Properties.Resources._61_poliwhirl;
                    images[1] = Properties.Resources._61_poliwhirl_back;
                    images[2] = Properties.Resources._61;
                    break;
                case 62:
                    images[0] = Properties.Resources._62_poliwrath;
                    images[1] = Properties.Resources._62_poliwrath_back;
                    images[2] = Properties.Resources._62;
                    break;
                case 63:
                    images[0] = Properties.Resources._63_abra;
                    images[1] = Properties.Resources._63_abra_back;
                    images[2] = Properties.Resources._63;
                    break;
                case 64:
                    images[0] = Properties.Resources._64_kadabra;
                    images[1] = Properties.Resources._64_kadabra_back;
                    images[2] = Properties.Resources._64;
                    break;
                case 65:
                    images[0] = Properties.Resources._65_alakazam;
                    images[1] = Properties.Resources._65_alakazam_back;
                    images[2] = Properties.Resources._65;
                    break;
                case 66:
                    images[0] = Properties.Resources._66_machop;
                    images[1] = Properties.Resources._66_machop_back;
                    images[2] = Properties.Resources._66;
                    break;
                case 67:
                    images[0] = Properties.Resources._67_machoke;
                    images[1] = Properties.Resources._67_machoke_back;
                    images[2] = Properties.Resources._67;
                    break;
                case 68:
                    images[0] = Properties.Resources._68_machamp;
                    images[1] = Properties.Resources._68_machamp_back;
                    images[2] = Properties.Resources._68;
                    break;
                case 69:
                    images[0] = Properties.Resources._69_bellsprout;
                    images[1] = Properties.Resources._69_bellsprout_back;
                    images[2] = Properties.Resources._69;
                    break;
                case 70:
                    images[0] = Properties.Resources._70_weepinbell;
                    images[1] = Properties.Resources._70_weepinbell_back;
                    images[2] = Properties.Resources._70;
                    break;
                case 71:
                    images[0] = Properties.Resources._71_victreebel;
                    images[1] = Properties.Resources._71_victreebel_back;
                    images[2] = Properties.Resources._71;
                    break;
                case 72:
                    images[0] = Properties.Resources._72_tentacool;
                    images[1] = Properties.Resources._72_tentacool_back;
                    images[2] = Properties.Resources._72;
                    break;
                case 73:
                    images[0] = Properties.Resources._73_tentacruel;
                    images[1] = Properties.Resources._73_tentacruel_back;
                    images[2] = Properties.Resources._73;
                    break;
                case 74:
                    images[0] = Properties.Resources._74_geodude;
                    images[1] = Properties.Resources._74_geodude_back;
                    images[2] = Properties.Resources._74;
                    break;
                case 75:
                    images[0] = Properties.Resources._75_graveler;
                    images[1] = Properties.Resources._75_graveler_back;
                    images[2] = Properties.Resources._75;
                    break;
                case 76:
                    images[0] = Properties.Resources._76_golem;
                    images[1] = Properties.Resources._76_golem_back;
                    images[2] = Properties.Resources._76;
                    break;
                case 77:
                    images[0] = Properties.Resources._77_ponyta;
                    images[1] = Properties.Resources._77_ponyta_back;
                    images[2] = Properties.Resources._77;
                    break;
                case 78:
                    images[0] = Properties.Resources._78_rapidash;
                    images[1] = Properties.Resources._78_rapidash_back;
                    images[2] = Properties.Resources._78;
                    break;
                case 79:
                    images[0] = Properties.Resources._79_slowpoke;
                    images[1] = Properties.Resources._79_slowpoke_back;
                    images[2] = Properties.Resources._79;
                    break;
                case 80:
                    images[0] = Properties.Resources._80_slowbro;
                    images[1] = Properties.Resources._80_slowbro_back;
                    images[2] = Properties.Resources._80;
                    break;
                case 81:
                    images[0] = Properties.Resources._81_magnemite;
                    images[1] = Properties.Resources._81_magnemite_back;
                    images[2] = Properties.Resources._81;
                    break;
                case 82:
                    images[0] = Properties.Resources._82_magneton;
                    images[1] = Properties.Resources._82_magneton_back;
                    images[2] = Properties.Resources._82;
                    break;
                case 83:
                    images[0] = Properties.Resources._83_farfetchd;
                    images[1] = Properties.Resources._83_farfetchd_back;
                    images[2] = Properties.Resources._83;
                    break;
                case 84:
                    images[0] = Properties.Resources._84_doduo;
                    images[1] = Properties.Resources._84_doduo_back;
                    images[2] = Properties.Resources._84;
                    break;
                case 85:
                    images[0] = Properties.Resources._85_dodrio;
                    images[1] = Properties.Resources._85_dodrio_back;
                    images[2] = Properties.Resources._85;
                    break;
                case 86:
                    images[0] = Properties.Resources._86_seel;
                    images[1] = Properties.Resources._86_seel_back;
                    images[2] = Properties.Resources._86;
                    break;
                case 87:
                    images[0] = Properties.Resources._87_dewgong;
                    images[1] = Properties.Resources._87_dewgong_back;
                    images[2] = Properties.Resources._87;
                    break;
                case 88:
                    images[0] = Properties.Resources._88_grimer;
                    images[1] = Properties.Resources._88_grimer_back;
                    images[2] = Properties.Resources._88;
                    break;
                case 89:
                    images[0] = Properties.Resources._89_muk;
                    images[1] = Properties.Resources._89_muk_back;
                    images[2] = Properties.Resources._89;
                    break;
                case 90:
                    images[0] = Properties.Resources._90_shellder;
                    images[1] = Properties.Resources._90_shellder_back;
                    images[2] = Properties.Resources._90;
                    break;
                case 91:
                    images[0] = Properties.Resources._91_cloyster;
                    images[1] = Properties.Resources._91_cloyster_back;
                    images[2] = Properties.Resources._91;
                    break;
                case 92:
                    images[0] = Properties.Resources._92_gastly;
                    images[1] = Properties.Resources._92_gastly_back;
                    images[2] = Properties.Resources._92;
                    break;
                case 93:
                    images[0] = Properties.Resources._93_haunter;
                    images[1] = Properties.Resources._93_haunter_back;
                    images[2] = Properties.Resources._93;
                    break;
                case 94:
                    images[0] = Properties.Resources._94_gengar;
                    images[1] = Properties.Resources._94_gengar_back;
                    images[2] = Properties.Resources._94;
                    break;
                case 95:
                    images[0] = Properties.Resources._95_onix;
                    images[1] = Properties.Resources._95_onix_back;
                    images[2] = Properties.Resources._95;
                    break;
                case 96:
                    images[0] = Properties.Resources._96_drowzee;
                    images[1] = Properties.Resources._96_drowzee_back;
                    images[2] = Properties.Resources._96;
                    break;
                case 97:
                    images[0] = Properties.Resources._97_hypno;
                    images[1] = Properties.Resources._97_hypno_back;
                    images[2] = Properties.Resources._97;
                    break;
                case 98:
                    images[0] = Properties.Resources._98_krabby;
                    images[1] = Properties.Resources._98_krabby_back;
                    images[2] = Properties.Resources._98;
                    break;
                case 99:
                    images[0] = Properties.Resources._99_kingler;
                    images[1] = Properties.Resources._99_kingler_back;
                    images[2] = Properties.Resources._99;
                    break;
                case 100:
                    images[0] = Properties.Resources._100_voltorb;
                    images[1] = Properties.Resources._100_voltorb_back;
                    images[2] = Properties.Resources._100;
                    break;
                case 101:
                    images[0] = Properties.Resources._101_electrode;
                    images[1] = Properties.Resources._101_electrode_back;
                    images[2] = Properties.Resources._101;
                    break;
                case 102:
                    images[0] = Properties.Resources._102_exeggcute;
                    images[1] = Properties.Resources._102_exeggcute_back;
                    images[2] = Properties.Resources._102;
                    break;
                case 103:
                    images[0] = Properties.Resources._103_exeggutor;
                    images[1] = Properties.Resources._103_exeggutor_back;
                    images[2] = Properties.Resources._103;
                    break;
                case 104:
                    images[0] = Properties.Resources._104_cubone;
                    images[1] = Properties.Resources._104_cubone_back;
                    images[2] = Properties.Resources._104;
                    break;
                case 105:
                    images[0] = Properties.Resources._105_marowak;
                    images[1] = Properties.Resources._105_marowak_back;
                    images[2] = Properties.Resources._105;
                    break;
                case 106:
                    images[0] = Properties.Resources._106_hitmonlee;
                    images[1] = Properties.Resources._106_hitmonlee_back;
                    images[2] = Properties.Resources._106;
                    break;
                case 107:
                    images[0] = Properties.Resources._107_hitmonchan;
                    images[1] = Properties.Resources._107_hitmonchan_back;
                    images[2] = Properties.Resources._107;
                    break;
                case 108:
                    images[0] = Properties.Resources._108_lickitung;
                    images[1] = Properties.Resources._108_lickitung_back;
                    images[2] = Properties.Resources._108;
                    break;
                case 109:
                    images[0] = Properties.Resources._109_koffing;
                    images[1] = Properties.Resources._109_koffing_back;
                    images[2] = Properties.Resources._109;
                    break;
                case 110:
                    images[0] = Properties.Resources._110_weezing;
                    images[1] = Properties.Resources._110_weezing_back;
                    images[2] = Properties.Resources._110;
                    break;
                case 111:
                    images[0] = Properties.Resources._111_rhyhorn;
                    images[1] = Properties.Resources._111_rhyhorn_back;
                    images[2] = Properties.Resources._111;
                    break;
                case 112:
                    images[0] = Properties.Resources._112_rhydon;
                    images[1] = Properties.Resources._112_rhydon_back;
                    images[2] = Properties.Resources._112;
                    break;
                case 113:
                    images[0] = Properties.Resources._113_chansey;
                    images[1] = Properties.Resources._113_chansey_back;
                    images[2] = Properties.Resources._113;
                    break;
                case 114:
                    images[0] = Properties.Resources._114_tangela;
                    images[1] = Properties.Resources._114_tangela_back;
                    images[2] = Properties.Resources._114;
                    break;
                case 115:
                    images[0] = Properties.Resources._115_kangaskhan;
                    images[1] = Properties.Resources._115_kangaskhan_back;
                    images[2] = Properties.Resources._115;
                    break;
                case 116:
                    images[0] = Properties.Resources._116_horsea;
                    images[1] = Properties.Resources._116_horsea_back;
                    images[2] = Properties.Resources._116;
                    break;
                case 117:
                    images[0] = Properties.Resources._117_seadra;
                    images[1] = Properties.Resources._117_seadra_back;
                    images[2] = Properties.Resources._117;
                    break;
                case 118:
                    images[0] = Properties.Resources._118_goldeen;
                    images[1] = Properties.Resources._118_goldeen_back;
                    images[2] = Properties.Resources._118;
                    break;
                case 119:
                    images[0] = Properties.Resources._119_seaking;
                    images[1] = Properties.Resources._119_seaking_a_back;
                    images[2] = Properties.Resources._119;
                    break;
                case 120:
                    images[0] = Properties.Resources._120_staryu;
                    images[1] = Properties.Resources._120_staryu_back;
                    images[2] = Properties.Resources._120;
                    break;
                case 121:
                    images[0] = Properties.Resources._121_starmie;
                    images[1] = Properties.Resources._121_starmie_back;
                    images[2] = Properties.Resources._121;
                    break;
                case 122:
                    images[0] = Properties.Resources._122_mr_mime;
                    images[1] = Properties.Resources._122_mr__mime_back;
                    images[2] = Properties.Resources._122;
                    break;
                case 123:
                    images[0] = Properties.Resources._123_scyther;
                    images[1] = Properties.Resources._123_scyther_back;
                    images[2] = Properties.Resources._123;
                    break;
                case 124:
                    images[0] = Properties.Resources._124_jynx;
                    images[1] = Properties.Resources._124_jynx_back;
                    images[2] = Properties.Resources._124;
                    break;
                case 125:
                    images[0] = Properties.Resources._125_electabuzz;
                    images[1] = Properties.Resources._125_electabuzz_back;
                    images[2] = Properties.Resources._125;
                    break;
                case 126:
                    images[0] = Properties.Resources._126_magmar;
                    images[1] = Properties.Resources._126_magmar_back;
                    images[2] = Properties.Resources._126;
                    break;
                case 127:
                    images[0] = Properties.Resources._127_pinsir;
                    images[1] = Properties.Resources._127_pinsir_back;
                    images[2] = Properties.Resources._127;
                    break;
                case 128:
                    images[0] = Properties.Resources._128_tauros;
                    images[1] = Properties.Resources._128_tauros_back;
                    images[2] = Properties.Resources._128;
                    break;
                case 129:
                    images[0] = Properties.Resources._129_magikarp;
                    images[1] = Properties.Resources._129_magikarp_back; ;
                    images[2] = Properties.Resources._129;
                    break;
                case 130:
                    images[0] = Properties.Resources._130_gyarados;
                    images[1] = Properties.Resources._130_gyarados_back_;
                    images[2] = Properties.Resources._130;
                    break;
                case 131:
                    images[0] = Properties.Resources._131_lapras;
                    images[1] = Properties.Resources._131_lapras_back_;
                    images[2] = Properties.Resources._131;
                    break;
                case 132:
                    images[0] = Properties.Resources._132_ditto;
                    images[1] = Properties.Resources._132_ditto_back_;
                    images[2] = Properties.Resources._132;
                    break;
                case 133:
                    images[0] = Properties.Resources._133_eevee;
                    images[1] = Properties.Resources._133_eevee_back_;
                    images[2] = Properties.Resources._133;
                    break;
                case 134:
                    images[0] = Properties.Resources._134_vaporeon;
                    images[1] = Properties.Resources._134_vaporeon_back;
                    images[2] = Properties.Resources._134;
                    break;
                case 135:
                    images[0] = Properties.Resources._135_jolteon;
                    images[1] = Properties.Resources._135_jolteon_back_;
                    images[2] = Properties.Resources._135;
                    break;
                case 136:
                    images[0] = Properties.Resources._136_flareon;
                    images[1] = Properties.Resources._136_flareon_back_;
                    images[2] = Properties.Resources._136;
                    break;
                case 137:
                    images[0] = Properties.Resources._137_porygon;
                    images[1] = Properties.Resources._137_porygon_back_;
                    images[2] = Properties.Resources._137;
                    break;
                case 138:
                    images[0] = Properties.Resources._138_omanyte;
                    images[1] = Properties.Resources._138_omanyte_back_;
                    images[2] = Properties.Resources._138;
                    break;
                case 139:
                    images[0] = Properties.Resources._139_omastar;
                    images[1] = Properties.Resources._139_omastar_back_;
                    images[2] = Properties.Resources._139;
                    break;
                case 140:
                    images[0] = Properties.Resources._140_kabuto;
                    images[1] = Properties.Resources._140_kabuto_back_;
                    images[2] = Properties.Resources._140;
                    break;
                case 141:
                    images[0] = Properties.Resources._141_kabutops;
                    images[1] = Properties.Resources._141_kabutops_back_;
                    images[2] = Properties.Resources._141;
                    break;
                case 142:
                    images[0] = Properties.Resources._142_aerodactyl;
                    images[1] = Properties.Resources._142_aerodactyl_back_;
                    images[2] = Properties.Resources._142;
                    break;
                case 143:
                    images[0] = Properties.Resources._143_snorlax;
                    images[1] = Properties.Resources._143_snorlax_back_;
                    images[2] = Properties.Resources._143;
                    break;
                case 144:
                    images[0] = Properties.Resources._144_articuno;
                    images[1] = Properties.Resources._144_articuno_back_;
                    images[2] = Properties.Resources._144;
                    break;
                case 145:
                    images[0] = Properties.Resources._145_zapdos;
                    images[1] = Properties.Resources._145_zapdos_back_;
                    images[2] = Properties.Resources._145;
                    break;
                case 146:
                    images[0] = Properties.Resources._146_moltres;
                    images[1] = Properties.Resources._146_moltres_back_;
                    images[2] = Properties.Resources._146;
                    break;
                case 147:
                    images[0] = Properties.Resources._147_dratini;
                    images[1] = Properties.Resources._147_dratini_back_;
                    images[2] = Properties.Resources._147;
                    break;
                case 148:
                    images[0] = Properties.Resources._148_dragonair;
                    images[1] = Properties.Resources._148_dragonair_back_;
                    images[2] = Properties.Resources._148;
                    break;
                case 149:
                    images[0] = Properties.Resources._149_dragonite;
                    images[1] = Properties.Resources._149_dragonite_back_;
                    images[2] = Properties.Resources._149;
                    break;
                case 150:
                    images[0] = Properties.Resources._150_mewtwo;
                    images[1] = Properties.Resources._150_mewtwo_back_;
                    images[2] = Properties.Resources._150;
                    break;
                case 151:
                    images[0] = Properties.Resources._151_mew;
                    images[1] = Properties.Resources._151_mew_back_;
                    images[2] = Properties.Resources._151;
                    break;
                default:
                    images[0] = null;
                    images[1] = null;
                    images[2] = null;
                    break;
            }
            return images;
        }

        public pokemon crearCopiaPKM()
        {
            int id = this.getID();
            string nombre = this.getNombre();
            int nvl = this.getNivel();
            string tipos = this.getTipos().getInicio().getValorTipo().getNombre();
            if (this.getTipos().getTamanio() > 1)
            {
                tipos += "/" + this.getTipos().getInicio().getSiguiente().getValorTipo().getNombre();
            }
            int hp = this.getHP(1);
            int atk = this.getATK(1);
            int def = this.getDEF(1);
            int atks = this.getATKS(1);
            int defs = this.getDEFS(1);
            int vel = this.getVEL(1);
            string movs = this.getMovimientos()[0].getID() + "/" + this.getMovimientos()[1].getID() + "/" + this.getMovimientos()[2].getID() + "/" + this.getMovimientos()[3].getID();

            return new pokemon(id, nombre, nvl, tipos, hp, atk, def, atks, defs, vel, movs);
        }

        public void transformarDitto(pokemon PKM)
        {
            if (this.ID == 132)
            {
                this.setID(PKM.ID);
                this.setNombre(PKM.nombre);
                this.setNivel(PKM.nivel);
                this.setTipos(PKM.tipos);
                this.setHP(PKM.HP[0], 0);
                this.setArrHP(PKM.HP);
                this.setArrATK(PKM.ATK);
                this.setArrDEF(PKM.DEF);
                this.setArrATKS(PKM.ATKS);
                this.setArrDEFS(PKM.DEFS);
                this.setArrVEL(PKM.VEL);
                this.setArrMovimiento(PKM.movimientos);
            }
        }

        public string ejecutarMovimiento(pokemon PKMRival, int indexMov, Random ran)
        {
            string s = string.Empty;
            bool secundario = false;
            movimiento mov = null;

            if (indexMov == 19)
            {
                this.transformarDitto(PKMRival);
                s += "¡Ditto se ha transformado en " + PKMRival.getNombre() + "!";
            }
            else
            {
                mov = this.getMovimientos()[indexMov];

                s = this.getNombre() + " usó " + mov.getNombre() + ".";

                if (mov.getCategoria().Equals("Físico") || mov.getCategoria().Equals("Especial"))
                {
                    s += atacar(PKMRival, indexMov, ran);
                }
                else
                {
                    s += movEstado(PKMRival, indexMov, ran, secundario);
                }

                this.getMovimientos()[indexMov].setUsos(mov.getUsos(1) - 1, 1);
            }
            return s;
        }

        public string atacar(pokemon PKMRival, int indexMov, Random ran)
        {
            bool secundario = true;

            string s = string.Empty;

            movimiento mov = this.getMovimientos()[indexMov];

            double STAB = 1;
            double t1 = 1;
            double t2 = 1;
            int crit = 1;
            double danioF = 0;
            double danioS = 0;
            double rand = 1;


            if (mov.getTipo().Equals(this.getTipos().getInicio().getValorTipo()))
            {
                STAB = 1.5;
            }
            else
            {
                if (this.getTipos().getTamanio() > 1)
                {
                    if (mov.getTipo().Equals(this.getTipos().getInicio().getSiguiente().getValorTipo()))
                    {
                        STAB = 1.5;
                    }
                }
            }

            if (mov.getTipo().getEficazContra().existeNombreTipo(PKMRival.getTipos().getInicio().getValorTipo().getNombre()))
            {
                t1 = 2;
            }

            if (mov.getTipo().getNoEfectivoContra().existeNombreTipo(PKMRival.getTipos().getInicio().getValorTipo().getNombre()))
            {
                t1 = 0.5;
            }

            if (PKMRival.getTipos().getInicio().getValorTipo().getInmuneA().existeNombreTipo(mov.getTipo().getNombre()))
            {
                t1 = 0;
            }

            if (PKMRival.getTipos().getTamanio() > 1)
            {
                if (mov.getTipo().getEficazContra().existeNombreTipo(PKMRival.getTipos().getInicio().getSiguiente().getValorTipo().getNombre()))
                {
                    t2 = 2;
                }

                if (mov.getTipo().getNoEfectivoContra().existeNombreTipo(PKMRival.getTipos().getInicio().getSiguiente().getValorTipo().getNombre()))
                {
                    t2 = 0.5;
                }

                if (PKMRival.getTipos().getInicio().getSiguiente().getValorTipo().getInmuneA().existeNombreTipo(mov.getTipo().getNombre()))
                {
                    t2 = 0;
                }
            }

            if ((t1 * t2) >= 2)
            {
                s += " ¡Es muy eficaz!.";
            }
            else
            {
                if (((t1 * t2) < 1) && ((t1 * t2) > 0))
                {
                    s += " Es poco eficaz.";
                }
                else
                {
                    if ((t1 * t2) == 0)
                    {
                        s += " ¡No hizo efecto!.";
                        return s;
                    }
                }
            }

            int n = ran.Next(1, 101);

            if (n <= 5)
            {
                crit = 2;
            }

            switch (mov.getCategoria())
            {
                case "Físico":
                    danioF = ((((((2 * this.getNivel() * crit / 5) + 2) * mov.getPotencia() * this.getATK(2) / PKMRival.getDEF(2)) / 50)) + 2) * STAB * t1 * t2;
                    break;
                case "Especial":
                    danioS = ((((((2 * this.getNivel() * crit / 5) + 2) * mov.getPotencia() * this.getATKS(2) / PKMRival.getDEFS(2)) / 50)) + 2) * STAB * t1 * t2;
                    break;
            }

            rand = (double)((ran.Next(39) + 217)) / 255;

            if (danioF == 1 || danioS == 1)
            {
                rand = 1;
            }

            danioF *= rand;
            danioS *= rand;

            int success = ran.Next(1, 101);

            if (success <= mov.getPrecision())
            {
                if (crit == 2)
                {
                    s += " ¡Golpe crítico!.";
                }

                s += " ¡Golpe exitoso!.";

                PKMRival.setHP((int)Math.Round(PKMRival.getHP(2) - danioF - danioS), 2);
                //estados alterados

                s += movEstado(PKMRival, indexMov, ran, secundario);

                if (PKMRival.getHP(2) <= 0)
                {
                    PKMRival.setHP(0, 2);
                    PKMRival.setEstadoAlterado(0);
                    s += " ¡" + PKMRival.getNombre() + " ha caído!.";
                }
            }
            else
            {
                s += " ¡El movimiento ha fallado!. ";
                Console.WriteLine("FALLOOOOOOOOOOO");
            }
            return s;
        }

        public string movEstado(pokemon PKMRival, int indexMov, Random ran, bool sec)
        {
            movimiento mov = this.getMovimientos()[indexMov];
            string s = string.Empty;

            if (sec)
            {
                s += determinarEfecto(PKMRival, mov, ran, sec);
            }
            else
            {
                int success = ran.Next(1, 101);

                if (success <= mov.getPrecision())
                {
                    s += determinarEfecto(PKMRival, mov, ran, sec);
                }
                else
                {
                    s += " ¡El movimiento ha fallado!. ";
                }
            }
            return s;
        }

        public string determinarEfecto(pokemon PKMRival, movimiento mov, Random ran, bool sec)
        {
            string s = string.Empty;

            if (mov.getEstadoAlterado() >= 1 && mov.getEstadoAlterado() <= 5)
            {
                if ((ran.Next(1, 101) <= mov.getEfecto()) && (PKMRival.getEstadoAlterado() == 0))
                {
                    s += "¡" + PKMRival.nombre + " ha sido afectado con ";

                    switch (mov.getEstadoAlterado())
                    {
                        case 1:
                            s += "parálisis!.";
                            break;
                        case 2:
                            s += "quemadura!.";
                            break;
                        case 3:
                            s += "sueño!.";
                            break;
                        case 4:
                            s += "congelacion!.";
                            break;
                        case 5:
                            s += "envenenamiento!.";
                            break;
                    }
                    PKMRival.setEstadoAlterado(mov.getEstadoAlterado());
                    if (mov.getEstadoAlterado() == 3 || mov.getEstadoAlterado() == 4)
                    {
                        PKMRival.setProbRecuperar(20);
                    }
                }
                else
                {
                    if (!sec)
                    {
                        s += "¡El movimiento no hizo efecto!.";
                    }
                }
            }

            if (mov.getEstadoAlterado() >= 6 && mov.getEstadoAlterado() <= 10)
            {
                if (ran.Next(1, 101) <= mov.getEfecto())
                {
                    mov.aumentarStat(this, mov.getEstadoAlterado());
                    s += " ¡Su ";
                    switch (mov.getEstadoAlterado())
                    {
                        case 6:
                            s += "ataque ";
                            break;
                        case 7:
                            s += "ataque especial ";
                            break;
                        case 8:
                            s += "defensa ";
                            break;
                        case 9:
                            s += "defensa especial ";
                            break;
                        case 10:
                            s += "velocidad ";
                            break;
                    }
                    s += "aumentó!";
                }
                else
                {
                    s += "¡El movimiento no hizo efecto!.";
                }
            }

            if (mov.getEstadoAlterado() >= 11 && mov.getEstadoAlterado() <= 15)
            {
                if (ran.Next(1, 101) <= mov.getEfecto())
                {
                    mov.disminuirStat(PKMRival, mov.getEstadoAlterado());

                    switch (mov.getEstadoAlterado())
                    {
                        case 11:
                            s += " ¡El ataque ";
                            break;
                        case 12:
                            s += " ¡El ataque especial ";
                            break;
                        case 13:
                            s += " ¡La defensa ";
                            break;
                        case 14:
                            s += " ¡La defensa especial ";
                            break;
                        case 15:
                            s += " ¡La velocidad ";
                            break;
                    }
                    s += "de " + PKMRival.nombre + " disminuyó!.";
                }
                else
                {
                    s += "¡El movimiento no hizo efecto!.";
                }
            }
            return s;
        }
    }
}
