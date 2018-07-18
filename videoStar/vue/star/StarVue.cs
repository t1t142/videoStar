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
using videoStar.events;

namespace videoStar.vue.star
{
    public partial class StarVue : UserControl
    {
      private  Star star;

        public Star Star { get => star;
            set
            { star = value;
                if (star != null)
                {
                    lblNom.Text = star.Nom;
                    lblPrenom.Text = star.Prenom;
                   
                    picBox.ImageLocation = Parametres.repPhotoStar + star.Photo;
                }
            }
        }


        public event EventHandler<eventClickDetail> ClickDetail;
       
        public StarVue()
        {
            InitializeComponent();
        }

    
        /*
        
        */
        private void button1_Click(object sender, EventArgs e)
        {
            OnClickDetail(new eventClickDetail(this.Name,Star));
        }


        protected virtual void OnClickDetail(eventClickDetail e)
        {
            EventHandler<eventClickDetail> handler = ClickDetail;

            if (handler != null)
            { 
                handler(this, e);
            }
        }

       
    }
}
