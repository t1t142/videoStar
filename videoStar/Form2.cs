using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using videoStar.vue.star;


namespace videoStar
{
    public partial class Form2 : Form
    {
        Point point1 = new Point(0, 0);

        public Form2()
        {
            InitializeComponent();

            // gestionville1.RaiseeventClickDetail += HandleeventClickDetail;

            gestStars1.Hide();
            annexeVue1.Hide();
            docListe1.Hide();

        }


        void ClickDetail(object sender, eventClickDetail e)
        {
            //detailVille1.BringToFront();
            //detailVille1.GetVilledetail(e.Id);
            MessageBox.Show("ok");
        }

        

        



        private void BtnStars_Click(object sender, EventArgs e)
        {
            Dimensionnement.Dimensionner(gestStars1, 0, 0, true, 0, 0);
           
            gestStars1.ActuGestStar();
        }

       

        private void btnAnx_Click(object sender, EventArgs e)
        {
            Dimensionnement.Dimensionner(annexeVue1, 0,0,true,0,0);
            /*  annexeVue1.Show();
            annexeVue1.BringToFront();


            annexeVue1.Location = point1;
            annexeVue1.Size = panel2.Size;*/
        }

        private void btnFilms_Click(object sender, EventArgs e)
        {
            Dimensionnement.Dimensionner(docListe1, 0, 0, true, 0, 0);
        }
    }


 }
