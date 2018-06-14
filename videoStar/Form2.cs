using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace videoStar
{
    public partial class Form2 : Form
    {
       

        public Form2()
        {
            InitializeComponent();
            
            // gestionville1.RaiseeventClickDetail += HandleeventClickDetail;
            gestionStars1.Hide();
           

            

        }


        void HandleeventClickDetail(object sender, eventClickDetail e)
        {
            //detailVille1.BringToFront();
            //detailVille1.GetVilledetail(e.Id);

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            gestionStars1.Show();
            gestionStars1.BringToFront();
            Point point1 = new Point(250, 0);

            gestionStars1.Location=point1;

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
    }


 }
