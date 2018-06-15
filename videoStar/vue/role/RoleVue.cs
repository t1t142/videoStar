using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace videoStar.vue.role
{
    public partial class RoleVue : UserControl
    {
        public RoleVue()
        {
            InitializeComponent();
            ajoutRole1.Hide();
            updateRole1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ajoutRole1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(this.Parent.Name=="pnlAnnexe")
            {
                MessageBox.Show("ok");
            }
            else
            {
                MessageBox.Show(this.Parent.Name);
            }
        }
    }
}
