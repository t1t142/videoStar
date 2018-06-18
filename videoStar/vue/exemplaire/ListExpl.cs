using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace videoStar.vue.exemplaire
{
    public partial class ListExpl : UserControl
    {
        public ListExpl()
        {
            InitializeComponent();
            ajoutExp1.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dimensionnement.Dimensionner(ajoutExp1, 0, 0, true, 0, 0);
            
        }
    }
}
