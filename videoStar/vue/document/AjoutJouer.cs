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
using Tulpep.NotificationWindow;

namespace videoStar.vue.document
{
    public partial class AjoutJouer : UserControl
    {
        private Star slctStar;
        private Document slctDoc;
        public Star SlctStar { get => slctStar; set => slctStar = value; }
        public Document SlctDoc { get => slctDoc; set => slctDoc = value; }

       // private List<Jouer> jouers = new List<Jouer>();
        private Participer participant = null;
        private Role role = null;
        List<Role> roles;



        public AjoutJouer()
        {
           InitializeComponent();
            gestStars1.EventSlctStar += HandleEventSlctStar;
           // docListe1.Hide();
            gestStars1.Hide();
            AffichageInit();

        }
     
        private void AffichageInit()
        {
            if (SlctDoc != null)
            {
                btnAjoutFilm.Visible = false;
                textBox1.Text = SlctDoc.Titre;
            }
            btnModiFilm.Visible = false;
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
            participant = null;
            
        
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
                string rech = comboBox1.Text;

                roles = Role.GetRolesByName(comboBox1.Text, 1, 20);

                comboBox1.Items.Clear();
                
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            role = (Role)comboBox1.SelectedItem;
            // MessageBox.Show(((Role)comboBox1.SelectedItem).Id.ToString());
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
          
            if(Control())
            {
                participant = new Participer();
                participant.Doc = slctDoc;
                participant.Star = slctStar;
                participant.Role = role;
                participant.Personnage = txtPerso.Text;

               Boolean inserer= participant.AjouterParticipant(participant);
                if (inserer)
                {
                    Actualise();
                    //dataGridView1.DataSource = Convert.ConvertToDataTable(jouer);
                    AffichageInit();

                    PopupNotifier popup = new PopupNotifier();
                    popup.TitleText = "Confirmation";
                    popup.ContentText = "la participation a bien été ajoutée ";
                    popup.Popup();
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
            dataGridView1.DataSource = Participer.SelectParticipantsByFilm(slctDoc.Code).Tables[0].DefaultView;


        }

        private void AjoutJouer_VisibleChanged(object sender, EventArgs e)
        {
            AffichageInit();
        }

        private Boolean Control()
        {

            Boolean control = true;

            if (slctDoc == null)
            {
                MessageBox.Show("le Film ne peux pas etre vide");
                control = false;
            }

            if (SlctStar == null)
            {
                MessageBox.Show("la Star ne peux pas etre vide");
                control = false;
            }
            if (role == null)
            {
                MessageBox.Show("le Role ne peux pas etre vide");
                control = false;
            }

            return control;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    } 
}



