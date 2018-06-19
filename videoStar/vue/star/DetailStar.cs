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
    public partial class DetailStar : UserControl
    {
        Boolean editable = false;


        public DetailStar()
        {
            InitializeComponent();
            Editable(editable);
        }


        public void AfficheStarDetail(Star st)
        {
            txtDetStarNom.Text = st.Nom;
            txtDetStarPrenom.Text = st.Prenom;
            datePickerDetail.Value = st.Datenaisance;
            cbxDetPays.Text = st.PaysOrigine;
            pictureBox1.ImageLocation = st.Photo;
            txtPhoto.Text = st.Photo;
            txtid.Text = st.Id.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
        }

       

        private void Editable(Boolean editable)
        {

           
                foreach (Control cont in Controls)
                {
                    if (cont is Button){

                    }
                    else
                    {
                        if (editable)
                        {
                            cont.Enabled = true;
                        pictureBox1.AllowDrop = true;
                    }
                        else
                        {
                        cont.Enabled = false;
                        pictureBox1.AllowDrop = false;
                    }
                    
                }
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            editable = true;
            Editable(editable);
        }
        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string file in files)
            {
                MessageBox.Show(file);

                String[] elements = file.Split(new char[] { '\\', '.' });
                foreach (string element in elements)
                {
                    MessageBox.Show(element);
                }

                pictureBox1.ImageLocation = file;
                txtPhoto.Text = file;

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
