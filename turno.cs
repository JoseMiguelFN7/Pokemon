using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon
{
    public class turno
    {
        jugador jugador;
        bool activo;
        int accion;

        public turno(jugador jugador)
        {
            this.activo = false;
            this.accion = 0;
            this.jugador = jugador;
        }

        public void setJugador(jugador j)
        {
            this.jugador = j;
        }

        public void setActivo(bool b)
        {
            this.activo = b;
        }

        public void setAccion(int a)
        {
            this.accion = a;
        }

        public jugador getJugador()
        {
            return jugador;
        }

        public bool estaActivo()
        {
            return activo;
        }

        public int getAccion()
        {
            return accion;
        }

        public string usarTurno(pokemon PKM, pokemon PKMRival, int op, Random ran, PictureBox PB)
        {
            string s = string.Empty;
            switch (op)
            {
                case 0: case 1: case 2: case 3:
                    s = this.usarMovimiento(PKM, PKMRival, op, ran);
                    break;
                case 4: case 5: case 6: case 7: case 8: case 9: case 10: case 11: case 12:
                    s = this.usarObjeto(op - 3, PKM, ran);
                    break;
                case 13: case 14: case 15: case 16: case 17: case 18:
                    s = this.cambiarPKM(op - 13);
                    break;
            }
            return s;
        }

        public string usarMovimiento(pokemon PKM, pokemon PKMRival, int indexMov, Random ran)
        {
            string s = string.Empty;

            if ((PKM.getEstadoAlterado() == 3) || (PKM.getEstadoAlterado() == 4))
            {
                if (PKM.getProbRecuperar() >= ran.Next(1, 101))
                {
                    s += "¡" + PKM.getNombre() + " se ha ";
                    if (PKM.getEstadoAlterado() == 3)
                    {
                        s += "despertado!. ";
                    }
                    else
                    {
                        s += "descongelado!. ";
                    }
                    PKM.setEstadoAlterado(0);
                    PKM.setProbRecuperar(0);
                }
                else
                {
                    s += PKM.getNombre() + " está ";
                    if (PKM.getEstadoAlterado() == 3)
                    {
                        s += "dormido. ";
                    }
                    else
                    {
                        s += "congelado. ";
                    }
                    PKM.setProbRecuperar(PKM.getProbRecuperar() + 20);
                }
            }
            
            if (!estaActivo() && (PKM.getEstadoAlterado() != 1) && (PKM.getEstadoAlterado() != 3) && (PKM.getEstadoAlterado() != 4))
            {
                return PKM.ejecutarMovimiento(PKMRival, indexMov, ran);
            }
            else
            {
                if (PKM.getEstadoAlterado() == 1)
                {
                    s += PKM.getNombre() + " está paralizado.";
                }
            }

            return s;
        }

        public string usarObjeto(int IDObj, pokemon PKM, Random ran)
        {
            string s = string.Empty;

            if (!estaActivo())
            {
                switch (IDObj)
                {
                    case 1:
                        s += this.jugador.getNombre() + this.jugador.getBolsa()[IDObj-1].sacarPocionDePila().usarPocion(PKM);
                        break;
                    case 2:
                        s += this.jugador.getNombre() + this.jugador.getBolsa()[IDObj - 1].sacarSuperPocionDePila().usarSuperPocion(PKM);
                        break;
                    case 3:
                        s += this.jugador.getNombre() + this.jugador.getBolsa()[IDObj - 1].sacarHiperPocionDePila().usarHiperPocion(PKM);
                        break;
                    case 4:
                        s += this.jugador.getNombre() + this.jugador.getBolsa()[IDObj - 1].sacarAntiParalisisDePila().usarAntiparalisis(PKM);
                        break;
                    case 5:
                        s += this.jugador.getNombre() + this.jugador.getBolsa()[IDObj - 1].sacarAntidotoDePila().usarAntidoto(PKM);
                        break;
                    case 6:
                        s += this.jugador.getNombre() + this.jugador.getBolsa()[IDObj - 1].sacarDespertarDePila().usarDespertar(PKM);
                        break;
                    case 7:
                        s += this.jugador.getNombre() + this.jugador.getBolsa()[IDObj - 1].sacarCuraTotalDePila().usarCuraTotal(PKM);
                        break;
                    case 8:
                        s += this.jugador.getNombre() + this.jugador.getBolsa()[IDObj - 1].sacarMaxPocionDePila().usarMaxPocion(PKM);
                        break;
                    case 9:
                        s += this.jugador.getNombre() + this.jugador.getBolsa()[IDObj - 1].sacarPrecisionXDePila().usarPrecisionX(PKM, ran);
                        break;
                }
            }
            return s;
        }

        public string cambiarPKM(int index)
        {
            string s = this.jugador.getNombre() + " ha cambiado a ";

            if (this.jugador.Equals(formBatalla.P1))
            {
                s += formBatalla.pokemon1.getNombre();
                formBatalla.pokemon1 = this.jugador.getPokemones()[index];
            }
            else
            {
                s += formBatalla.pokemon2.getNombre();
                formBatalla.pokemon2 = this.jugador.getPokemones()[index];
            }

            s += " por " + this.jugador.getPokemones()[index].getNombre() + ".";
            return s;
        }
    }
}
