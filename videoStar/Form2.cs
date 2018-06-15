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
         
           

            

        }


        void ClickDetail(object sender, eventClickDetail e)
        {
            //detailVille1.BringToFront();
            //detailVille1.GetVilledetail(e.Id);
            MessageBox.Show("ok");
        }

        

        

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void BtnStars_Click(object sender, EventArgs e)
        {
            gestStars1.Show();
            gestStars1.BringToFront();
            

            gestStars1.Location = point1;
            gestStars1.Size = panel2.Size;
            gestStars1.ActuGestStar();
        }

        private void gestStars1_Load(object sender, EventArgs e)
        {

        }
    }


 }
