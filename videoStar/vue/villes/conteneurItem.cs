using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace videoStar
{
    public partial class conteneurItem : UserControl
    {
        public event EventHandler<eventClickDetail> RaiseeventClickDetail;
        public conteneurItem()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void conteneurItem_Load(object sender, EventArgs e)
        {
            label1.Text = "cool";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = @"C:\Users\Thierry\Downloads\téléchargement.jpg";
          
        }


        public void GetVille(Ville ville)
        {
            label1.Text = ville.Libelle;
            label2.Text = ville.Id.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OnRaiseeventClickDetail(new eventClickDetail(label2.Text));
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

