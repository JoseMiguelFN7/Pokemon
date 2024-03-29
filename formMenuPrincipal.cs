using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon
{
    public partial class formMenuPrincipal : Form
    {
        bool exitForm = false;
        public formMenuPrincipal()
        {
            InitializeComponent();         
            titulo.Parent = fondoprincipal;                   
            salir.Parent = fondoprincipal;
            labpartida.Parent = fondoprincipal;
            pokemon.Parent = fondoprincipal;
            picpokemon.Parent = fondoprincipal;           
        }

        private void labelpartida_MouseEnter(object sender, EventArgs e)
        {
            labelpartida.ForeColor = Color.RoyalBlue;
        }

        private void labelpartida_MouseLeave(object sender, EventArgs e)
        {
            labelpartida.ForeColor = Color.Gold;
        }


        private void salir_MouseEnter(object sender, EventArgs e)
        {
            salir.ForeColor = Color.RoyalBlue;
        }

        private void salir_MouseLeave(object sender, EventArgs e)
        {
            salir.ForeColor = Color.Gold;
        }

        private void labpartida_MouseEnter(object sender, EventArgs e)
        {
            labpartida.ForeColor = Color.RoyalBlue;
        }

        private void labpartida_MouseLeave(object sender, EventArgs e)
        {
            labpartida.ForeColor = Color.Gold;
        }

        private void labpartida_Click(object sender, EventArgs e)
        {
            exitForm = true;
            formEntrenadores entrenadores = new formEntrenadores();
            entrenadores.Visible = true;
            this.Close();
        }

        private void labeltorneo_MouseEnter(object sender, EventArgs e)
        {
            labeltorneo.ForeColor = Color.RoyalBlue;
        }

        private void labeltorneo_MouseLeave(object sender, EventArgs e)
        {
            labeltorneo.ForeColor = Color.Gold;
        }

        private void labeltorneo_Click(object sender, EventArgs e)
        {
            exitForm = true;
            formElegirTorneo elegirtorneo = new formElegirTorneo();
            elegirtorneo.Visible = true;
            this.Close();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!exitForm)
            {
                Application.Exit();
            }
        }
    }
}
