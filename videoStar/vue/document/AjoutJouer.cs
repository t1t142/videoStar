using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using videoStar.events.star;
using videoStar.entity;

namespace videoStar.vue.document
{
    public partial class AjoutJouer : UserControl
    {
        private Star slctStar;

        public Star SlctStar { get => slctStar; set => slctStar = value; }

        private List<Jouer> jouers = new List<Jouer>();
        private Jouer jouer = null;
        private Role role = null;
        List<Role> roles;



        public AjoutJouer()
        {
            InitializeComponent();
            gestStars1.EventSlctStar += HandleEventSlctStar;
         
            gestStars1.Hide();
            AffichageInit();

        }

        private void AffichageInit()
        {
            txtPerso.Visible = false;
            txtStar.Visible = false;
            lblPerso.Visible = false;
            btnModifStar.Visible = false;
            btnAjtStar.Visible = true;
            comboBox1.Text = "";
            txtStar.Text = "";
            txtPerso.Text = "";
            slctStar = null;
            role = null;
            jouer = null;
            jouers.Clear();
        }




        private void HandleEventSlctStar(object sender, EventSlctStar e)
        {
            gestStars1.Hide();

            SlctStar = e.St;
            txtStar.Text = SlctStar.Nom + " " + SlctStar.Prenom;
            txtStar.Visible = true;
            btnAjtStar.Visible = false;
            btnModifStar.Visible = true;
        }

        private void btnAjtStar_Click(object sender, EventArgs e)
        {
            Dimensionnement.Dimensionner(gestStars1, 0, 0, true, 0, 0);
            gestStars1.Reglages();
            gestStars1.ActuGestStar();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Hide();


        }







        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Length > 0)
            {
                string rech = comboBox1.Text;

                roles = Role.GetRolesByName(comboBox1.Text, 1, 10);

                comboBox1.Items.Clear();
                /*foreach (Role unRole in roles)
                {
                    comboBox1.Items.Add(unRole.Libelle);
                }*/
                foreach (Role role in roles)
                {
                    comboBox1.Items.Add(role);
                }
                comboBox1.DisplayMember = "libelle";
                comboBox1.ValueMember = "id";
                comboBox1.DroppedDown = true;
                comboBox1.Select(comboBox1.Text.Length, 0);
                if (comboBox1.Text == "Acteur")
                {
                    txtPerso.Visible = true;
                    lblPerso.Visible = true;
                }
                else
                {
                    txtPerso.Visible = false;
                    lblPerso.Visible = false;
                }
            }
        }





        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {



            role = (Role)comboBox1.SelectedItem;
            // MessageBox.Show(((Role)comboBox1.SelectedItem).Id.ToString());

        }


        private void btnAjout_Click(object sender, EventArgs e)
        {



            if (role == null)
            {
                MessageBox.Show("le Role ne peux pas etre vide");
            }

            else
            {
                if (SlctStar != null)
                {

                    jouer = new Jouer();
                    jouer.Star = slctStar;
                    jouer.Role = role;
                    jouer.Personnage = txtPerso.Text;

                    jouers.Add(jouer);
                    Actualise();
                    //dataGridView1.DataSource = Convert.ConvertToDataTable(roles);
                    AffichageInit();




                }
                else
                {

                    MessageBox.Show("la Star ne peux pas etre vide");
                }

            }


        }

        private void btnAnnul_Click(object sender, EventArgs e)
        {
            AffichageInit();
        }

        private void Actualise()

        {
            //  dataGridView1.DataSource  = jouers;



        }
    } 
}



