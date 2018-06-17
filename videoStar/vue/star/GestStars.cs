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
using videoStar.vue.star;
using videoStar.events;

namespace videoStar.vue.star
{
    public partial class GestStars : UserControl
    {
      
       private Star slctStar;
      private  Point point1 = new Point(0, 0);


        public Star SlctStar { get => slctStar; set => slctStar = value; }




        public GestStars()
        {
            InitializeComponent();
            
        starVue1.ClickDetail += HandleClickDetail;
        starVue2.ClickDetail += HandleClickDetail;
        starVue3.ClickDetail += HandleClickDetail;
        starVue4.ClickDetail += HandleClickDetail;
        starVue5.ClickDetail += HandleClickDetail;
        starVue6.ClickDetail += HandleClickDetail;
        starVue7.ClickDetail += HandleClickDetail;
        starVue8.ClickDetail += HandleClickDetail;
        ajoutStar1.AjtStar += HandleAjtStar;
            detailStar1.Hide();
            ajoutStar1.Hide();
            
        }

       
        private void HandleAjtStar(object sender, EventAjtStar e)
        {
            ActuGestStar();
        }

        private int pageCount;
        private int pageActive = 1;
        private int items = 8;

        
       
        private void HandleClickDetail(object sender, eventClickDetail e)
        {

            e.St.GetStarDetail();
            SlctStar = e.St;

            // todo fonction générale affiche
            detailStar1.Show();
            detailStar1.BringToFront();


            detailStar1.Location = point1;
            detailStar1.Size = this.Parent.Size;
            detailStar1.AfficheStarDetail(e.St);

        }

        private void HideItems()
        {
            foreach (Control control in this.Controls)
            {

                if (control is StarVue)
                {
                    control.Hide();
                }


            }
        }


        private void Totalpages()
        {
            int stars = Star.CountStars(txtRecherche.Text);

            pageCount = stars / items;
            if (stars % items > 0)
            {

                pageCount++;
            }

            lblPages.Text = "Page " + pageActive.ToString() + @" / " + pageCount.ToString();

        }

        private void Affiche()
        {


            List<Star> stars = Star.GetStarsPages(txtRecherche.Text, pageActive, items);
            //MessageBox.Show(villes.Count.ToString());

            for (int i = 0; i <= stars.Count - 1; i++)
            {

                int j = i + 1;
                Star st = stars[i];
                StarVue ctn = (StarVue)Controls.Find("starVue" + j.ToString(), false)[0];
                ctn.Star=st;
                ctn.Show();
                


            }
        }


        public void ActuGestStar()
        {
            HideItems();
            Affiche();
            Totalpages();

        }

        

        private void btnAjouter_Click(object sender, EventArgs e)
        { // todo fonction générale affiche
            ajoutStar1.Show();
            ajoutStar1.BringToFront();


            ajoutStar1.Location = point1;
            ajoutStar1.Size = this.Parent.Size;

        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {

        }

        private void starVue_Click(object sender, EventArgs e)
        {
            StarVue starVue = (StarVue)sender;
            SlctStar= starVue.Star;
            foreach (Control stv in this.Controls)
            {
                if (stv is StarVue stv1)
                {
                    if (starVue.Name == stv.Name)
                    {
                        stv1.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else
                    {
                        stv1.BorderStyle = BorderStyle.None;
                    }
                }
            }
        }

        private void DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("cool");
        }

        private void GestStars_Load(object sender, EventArgs e)
        {

        }
    }
}
