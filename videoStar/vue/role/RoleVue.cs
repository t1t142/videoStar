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

namespace videoStar.vue.role
{
    public partial class RoleVue : UserControl
    {
        public RoleVue()
        {
            InitializeComponent();
            ajoutRole1.Hide();
            updateRole1.Hide();
            ActuRole();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dimensionnement.Dimensionner(ajoutRole1, 450, 60, false, 400, 700);
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

        private void RoleVue_Load(object sender, EventArgs e)
        {

        }

        public void ActuRole()
        {
          dataGridView1.DataSource= Role.SelectRole().Tables[0].DefaultView;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dimensionnement.Dimensionner(updateRole1, 0, 0, true, 400, 700);
        }
    }
}
