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
    public partial class detailVille : UserControl
    {
        public detailVille()
        {
            InitializeComponent();

        }

        private void detailVille_Load(object sender, EventArgs e)
        {

        }

        public void GetVilledetail(string id)
        {
            Ville ville = Ville.DetailVille(id);

            label1.Text = ville.Libelle;
            label2.Text = ville.Id.ToString();
            label3.Text = ville.Cp.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SendToBack();
        }
    }
}
