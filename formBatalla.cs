using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon
{
    public partial class formBatalla : Form
    {
        
        public formBatalla()
        {
            InitializeComponent();
            pictureBox1.Image = formInicio.arrPKM[0].getImgFront();
            pictureBox1.Parent = pictureBox2;
        }
    }
}
