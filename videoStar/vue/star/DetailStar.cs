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
        public DetailStar()
        {
            InitializeComponent();
        }


        public void AfficheStarDetail(Star st)
        {
            txtDetStarNom.Text = st.Nom;
            txtDetStarPrenom.Text = st.Prenom;
            datePickerDetail.Value = st.Datenaisance;
            cbxDetPays.Text = st.PaysOrigine;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
        }

       
    }
}
