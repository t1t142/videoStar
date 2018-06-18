using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using videoStar.events.star;

namespace videoStar.vue.document
{
    public partial class AjoutJouer : UserControl
    {
       // public event EventHandler<EventSlctStar> HandleEventSlctStar;

        public AjoutJouer()
        {
            InitializeComponent();
            gestStars1.EventSlctStar += HandleEventSlctStar;

            gestStars1.Hide();
            txtPerso.Visible = false;
            txtRole.Visible = false;
            txtStar.Visible = false;
            lblPerso.Visible = false;
            btnModifRole.Visible = false;
            btnModifStar.Visible = false;

        }

        private void HandleEventSlctStar(object sender, EventSlctStar e)
        {
            MessageBox.Show("bien recu");
           /* e.St.GetStarDetail();
            SlctStar = e.St;

            // todo fonction générale affiche
            detailStar1.Show();
            detailStar1.BringToFront();


            detailStar1.Location = point1;
            detailStar1.Size = this.Parent.Size;
            detailStar1.AfficheStarDetail(e.St);
*/
        }

        private void btnAjtStar_Click(object sender, EventArgs e)
        {
            Dimensionnement.Dimensionner(gestStars1, 0, 0, true, 0, 0);
            gestStars1.Reglages();
            gestStars1.ActuGestStar();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
