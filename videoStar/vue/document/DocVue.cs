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
    public partial class DocVue : UserControl
    {
        private Document doc;

        public Document Doc
        {
            get => doc;
            set
            {
                doc = value;
                if (doc != null)
                {
                    lblNom.Text = doc.Titre;
                    lblPrenom.Text = doc.Annee;

                    picBox.ImageLocation = Parametres.repPhotofilm + doc.Photo;
                }
            }
        }





        public DocVue()
        {
            InitializeComponent();
        }

        private void DocVue_Load(object sender, EventArgs e)
        {

        }

        private void lblNom_Click(object sender, EventArgs e)
        {

        }
    }
}
