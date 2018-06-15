using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace videoStar
{
    public partial class annexeVue : UserControl
    {
        public annexeVue()
        {
            InitializeComponent();
        }

        private void BtnRoles_Click(object sender, EventArgs e)
        {
            Dimensionnement.Dimensionner(roleVue1, 0, 0, true, 0, 0);
        }
    }
}
