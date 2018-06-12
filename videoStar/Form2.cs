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
            gestionville1.BringToFront();
           gestionville1.RaiseeventClickDetail += HandleeventClickDetail;
        }

        private void gestionville1_Load(object sender, EventArgs e)
        {

        }

        void HandleeventClickDetail(object sender, eventClickDetail e)
        {
            detailVille1.BringToFront();
            detailVille1.GetVilledetail(e.Id);

        }

    }


 }
