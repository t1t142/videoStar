using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace videoStar
{
    public partial class gestionville : UserControl
    {
        public event EventHandler<eventClickDetail> RaiseeventClickDetail;

        private int pageCount;
        private int pageActive=1;
        private int items=8;
        public gestionville()
        {
            InitializeComponent();
            conteneurItem1.RaiseeventClickDetail += HandleeventClickDetail;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void gestionville_Load(object sender, EventArgs e)
        {
            
           Actualise();
        
        }


        private void HideItems()
        {
            foreach (Control control in this.Controls)
            {

                if (control is conteneurItem)
                {
                    control.Hide();
                }


            }
        }


        private void Totalpages()
        {
           int villes = Ville.CountVilles(textBox1.Text) ;
           
            pageCount = villes / items;
            if (villes % items>0)
            {
               
                pageCount++;
            }

            label3.Text = "Page " + pageActive.ToString() +@" / " + pageCount.ToString();
       
        }

        private void Affiche()
        {


            List<Ville> villes = Ville.GetVillePages(textBox1.Text, pageActive, items);
            //MessageBox.Show(villes.Count.ToString());

            for (int i = 0; i <= villes.Count - 1; i++)
            {

                int j = i + 1;
                Ville ville = villes[i];
                conteneurItem ctn = (conteneurItem)Controls.Find("conteneurItem" + j.ToString(), false)[0];
                ctn.GetVille(ville);
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

        private void button2_Click(object sender, EventArgs e)
        {

            if (pageActive < pageCount)
            {
                pageActive++;
                Actualise();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pageActive >1)
            {
                pageActive--;
                Actualise();
            }
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



    }
}
