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

namespace videoStar
{
    public partial class GestStars : UserControl
    {
        public event EventHandler<eventClickDetail> eventClickDetail;
        Star slctStar;
        public GestStars()
        {
            InitializeComponent();
            starVue1.ClickDetail += HandleClickDetail;
            detailStar1.Hide();
        }

        

        private int pageCount;
        private int pageActive = 1;
        private int items = 8;



        private void HandleClickDetail(object sender, eventClickDetail e)
        {
            Point point1 = new Point(0, 0);
            e.St.GetStarDetail();
            slctStar = e.St;


            detailStar1.Show();
            detailStar1.BringToFront();


            detailStar1.Location = point1;
            detailStar1.Size = this.Parent.Size;
            detailStar1.AfficheStarDetail(e.St);

            //MessageBox.Show("ok");
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
                ctn.GetStar(st);
                ctn.Show();
                


            }
        }


        public void ActuGestStar()
        {
            HideItems();
            Affiche();
            Totalpages();

        }

        private void lblTitre_Click(object sender, EventArgs e)
        {

        }
    }
}
