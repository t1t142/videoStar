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
        private Document film;
        public Star St { get => st; set => st = value; }

        public AjoutDoc()
        {
            InitializeComponent();
            ajoutJouer1.Hide();
           // ajoutJouer1.SlctDoc = film;
        }

        

        

        private void btnAjtStar_Click(object sender, EventArgs e)
        {
            Dimensionnement.Dimensionner(ajoutJouer1, 0, 0, true, 0, 0);
           
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
           /* btnAjoutLieux.Visible = true;
            btnAjoutStar.Visible = true;
            film = new Document();
            film.Code = txtCode.Text;
            film.Titre = txtTitre.Text;
            film.Annee = txtAnnee.Text;
            film.Photo = txtPhoto.Text;*/
        }
    }
}
