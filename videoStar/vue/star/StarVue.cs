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
    public partial class StarVue : UserControl
    {
        Star st;

        public event EventHandler<eventClickDetail> ClickDetail;
        public StarVue()
        {
            InitializeComponent();
        }

    

        public void GetStar(Star st)
        {
            this.st = st;
            lblNom.Text = st.Nom;
            lblPrenom.Text = st.Prenom;
            picBox.ImageLocation = st.Photo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OnClickDetail(new eventClickDetail(st));
        }


        protected virtual void OnClickDetail(eventClickDetail e)
        {
            EventHandler<eventClickDetail> handler = ClickDetail;

            if (handler != null)
            { 
                handler(this, e);
            }
        }

        private void star_Load(object sender, EventArgs e)
        {

        }
    }
}
