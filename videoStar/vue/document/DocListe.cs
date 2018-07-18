using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using videoStar.events;

namespace videoStar.vue.document
{
    public partial class DocListe : UserControl
    {

    


        private int pageCount;
        private int pageActive = 1;
        private int items = 8;




        public DocListe()
        {
            InitializeComponent();
            ajoutDoc1.AjtDoc += HandleAjtDoc;
            ajoutDoc1.Hide();
            ActuGestDocs();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dimensionnement.Dimensionner(ajoutDoc1, 0, 0, true, 0, 0);
           
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {

        }


        private void HideItems()
        {
            foreach (Control control in this.Controls)
            {

                if (control is DocVue)
                {
                    control.Hide();
                }


            }
        }


        private void Totalpages()
        {
            int docs = Document.CountDocs(txtRecherche.Text);

            pageCount = docs / items;
            if (docs % items > 0)
            {

                pageCount++;
            }

            lblPages.Text = "Page " + pageActive.ToString() + @" / " + pageCount.ToString();

        }

        private void Affiche()
        {

            List<Document> docs = Document.GetDocsPages(txtRecherche.Text, pageActive, items);


            for (int i = 0; i <= docs.Count - 1; i++)
            {

                int j = i + 1;
                Document doc = docs[i];
                DocVue ctn = (DocVue)Controls.Find("docVue" + j.ToString(), false)[0];
                ctn.Doc = doc;
                if (ctn.Visible == false)
                {
                    ctn.Show();
                }

                ctn.BorderStyle = BorderStyle.None;

            }
            Hide();
            for (int i = docs.Count + 1; i <= items; i++)
            {
                DocVue ctn = (DocVue)Controls.Find("docVue" + i.ToString(), false)[0];
                ctn.Hide();
            }

            Show();
            txtRecherche.Focus();
            txtRecherche.Select(txtRecherche.Text.Length, 0);

        }

        public void ActuGestDocs()
        {
            // HideItems();
            Affiche();
            Totalpages();


        }

        private void docVue1_Load(object sender, EventArgs e)
        {

        }

        private void DocListe_Load(object sender, EventArgs e)
        {

        }

        private void btnselect_Click(object sender, EventArgs e)
        {

        }


        private void HandleAjtDoc(object sender, EventAjtDoc e)
        {
            ActuGestDocs();
        }

    }
}
