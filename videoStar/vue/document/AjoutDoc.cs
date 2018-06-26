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
using videoStar.outils;

namespace videoStar.vue.document
{
    public partial class AjoutDoc : UserControl
    {
        private Star st;
        private Document film;

        public Star St { get => st; set => st = value; }
        public Document Film { get => film; set => film = value; }

        public AjoutDoc()
        {
            InitializeComponent();
            pictureBox1.AllowDrop = true;
            pictureBox1.ImageLocation = @"D:\image\drag-drop-upload-1.gif";
            ajoutJouer1.Hide();
            ajoutJouer1.SlctDoc = Film;
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
            btnAjoutLieux.Visible = true;
            btnAjoutStar.Visible = true;
            Film = new Document();
            Film.Code = txtCode.Text;
            Film.Titre = txtTitre.Text;
            Film.Annee = txtAnnee.Text;
            Film.Photo = txtPhoto.Text;
           
            Film.DocType = (TypeDocument)cbxType.SelectedItem ;
            ajoutJouer1.SlctDoc = film;

            film.Insertdocument(film);

        }

        private void AjoutDoc_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void cbxType_TextChanged(object sender, EventArgs e)
        {
            if (cbxType.Text.Length > 0)
            {
                string rech = cbxType.Text;

                List<TypeDocument> types = TypeDocument.GetTypeDocByCode(cbxType.Text, 1, 10);

                cbxType.Items.Clear();

                foreach (TypeDocument type in types)
                {
                    cbxType.Items.Add(type);
                }
                cbxType.DisplayMember = "CodeTypeDocument";
                cbxType.ValueMember = "TypeNom";
                cbxType.DroppedDown = true;
                cbxType.Select(cbxType.Text.Length, 0);


            }
        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            Boolean fileVerif = Photo.VerifierPhoto(files);

            if (fileVerif)
            {
                pictureBox1.ImageLocation = files[0];
                txtPhoto.Text = files[0];

            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
