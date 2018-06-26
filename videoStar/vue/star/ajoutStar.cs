using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using videoStar.entity;
using Tulpep.NotificationWindow;
using videoStar.events;
using videoStar.outils;

namespace videoStar.vue.star
{
    public partial class ajoutStar : UserControl

    {
        public event EventHandler<EventAjtStar> AjtStar;
        public ajoutStar()
        {
            InitializeComponent();
            pictureBox1.AllowDrop = true;
            pictureBox1.ImageLocation = @"D:\image\drag-drop-upload-1.gif";
            cbxPays.DroppedDown = true;

        }



        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            
           Boolean fileVerif= Photo.VerifierPhoto(files);

            if (fileVerif) { 
            pictureBox1.ImageLocation = files[0];
            txtPhoto.Text = files[0];

            }

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cbxPays_TextChanged(object sender, EventArgs e)
        {
            if (cbxPays.Text.Length >= 2 && cbxPays.Text.Length <= 4)
            {
                string rech = cbxPays.Text;

                List<Pays> pays = Pays.GetPaysByName(cbxPays.Text, 1, 20);

                cbxPays.Items.Clear();
                foreach (Pays unPays in pays)
                {
                    cbxPays.Items.Add(unPays.Libelle);
                }
                cbxPays.DroppedDown = true;
                cbxPays.Select(cbxPays.Text.Length, 0);
                
            }

        }

        private void cbxPays_SelectedValueChanged(object sender, EventArgs e)
        {
            //comboBox1.Text = comboBox1.SelectedIndex.ToString();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
                          
            Star st= null;

            try
            { 
                 st = new Star(txtNom.Text, txtPrenom.Text, dtpNaissance.Value, cbxPays.Text);
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            if (st != null) {

                string dossier = @"C:\Users\Thierry\source\repos\videoStar\images\star";
                string photo= Photo.SavePhoto(txtPhoto.Text,dossier);
                st.Photo =photo;
                st.InsertStar(st);
            
                PopupNotifier popup = new PopupNotifier();
                popup.TitleText = "un popup perso et un";
                popup.ContentText = "la nouvelle star a bien été ajoutée ";
                popup.Popup();
                OnAjtStar(new EventAjtStar(st));
            }
        }

        protected virtual void OnAjtStar(EventAjtStar e)
        {
            EventHandler<EventAjtStar> handler = AjtStar;

            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void cbxPays_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxPays.Text.Length >= 2 )
            {
                string rech = cbxPays.Text;

                List<Pays> pays = Pays.GetPaysByName(cbxPays.Text, 1, 20);

                cbxPays.Items.Clear();

                foreach (Pays unPays in pays)
                {

                    cbxPays.Items.Add(unPays.Libelle);
                }
                cbxPays.DroppedDown = true;
                cbxPays.Select(cbxPays.Text.Length, 0);
               
            }
        }

        
       
    }
}
