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
    public partial class star : UserControl
    {
        public static string Photo { get; internal set; }

        public event EventHandler<eventClickDetail> RaiseeventClickDetail;
        public star()
        {
            InitializeComponent();
        }

    

        public void GetStar(Star st)
        {
            textBox1.Text = st.Nom;
            textBox2.Text = st.Prenom;
            pictureBox2.ImageLocation = st.Photo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OnRaiseeventClickDetail(new eventClickDetail(textBox2.Text));
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

        private void star_Load(object sender, EventArgs e)
        {

        }
    }
}
