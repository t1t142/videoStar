using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using videoStar.entity;

namespace videoStar.vue.document
{
    public partial class AjoutDoc : UserControl
    {
        private Star st;

        public Star St { get => st; set => st = value; }

        public AjoutDoc()
        {
            InitializeComponent();
            gestStars1.Hide();

        }

        

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAjtStar_Click(object sender, EventArgs e)
        {
            Dimensionnement.Dimensionner(gestStars1, 0, 0, true, 0, 0);
            gestStars1.Reglages();
            gestStars1.ActuGestStar();
        }
    }
}
