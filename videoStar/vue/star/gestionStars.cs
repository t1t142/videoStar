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

namespace videoStar.vue.star
{
    public partial class gestionStars : UserControl
    {
        public event EventHandler<eventClickDetail> RaiseeventClickDetail;

        private int pageCount;
        private int pageActive = 1;
        private int items = 8;

        public gestionStars()
        {
            InitializeComponent();
            ajoutStar1.Hide();
            Actualise();
            star1.RaiseeventClickDetail += HandleeventClickDetail;

        }

       

        

        private void button6_Click(object sender, EventArgs e)
        {
            ajoutStar1.Show();
            ajoutStar1.BringToFront();
        }

        

 
        private void HideItems()
        {
            foreach (Control control in this.Controls)
            {

                if (control is star)
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
                    star ctn = (star)Controls.Find("star" + j.ToString(), false)[0];
                    ctn.GetStar(st);
                    ctn.Show();
                    // MessageBox.Show("ol");
                    

                }
            }
        

        private void Actualise()
        {
            HideItems();
            Affiche();
            Totalpages();

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            pageActive = 1;
            Actualise();
        }

        void HandleeventClickDetail(object sender, eventClickDetail e)
        {
            OnRaiseeventClickDetail(new eventClickDetail(e.Id));
        }


        protected virtual void OnRaiseeventClickDetail(eventClickDetail e)
        {
            // Make a temporary copy of the event to avoid possibility of
            // a race condition if the last subscriber unsubscribes
            // immediately after the null check and before the event is raised.
            EventHandler<eventClickDetail> handler = RaiseeventClickDetail;

            // Event will be null if there are no subscribers
            if (handler != null)
            {
                // Use the () operator to raise the event.
                handler(this, e);
            }
        }

        private void button2btnPrecedent_Click(object sender, EventArgs e)
        {
            if (pageActive > 1)
            {
                pageActive--;
                Actualise();
            }
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {

            if (pageActive < pageCount)
            {
                pageActive++;
                Actualise();
            }
        }

        private void ajoutStar1_Load(object sender, EventArgs e)
        {

        }

        private void star2_Load(object sender, EventArgs e)
        {

        }
    }







}

