using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace videoStar.entity
{
   public class Participer
    {
        private Document doc;
        private Star star;
        private Role role;
        private String personnage;
      
        public Star Star { get => star; set => star = value; }
        public Role Role { get => role; set => role = value; }
        public string Personnage { get => personnage; set => personnage = value; }
        internal Document Doc { get => doc; set => doc = value; }

        public Participer()
        {

        }

        public static DataSet SelectParticipantsByFilm (string codeDocument)
        {
            string query = "SELECT document.titre,star.nom,star.prenom,role.libelle,role.personnage FROM participer" +
                " JOIN star ON participer.idstar = star.idstar " +
                "JOIN role ON participer.idrole = role.idrole " +
                "JOIN document ON participer.codedocument = document.codedocument " +
                "where participer.codedocument  =@codedocument";



            DataSet ds = new DataSet(); ;
            MySqlCommand cmd = DBConnect.GetConnexion().CreateCommand();
            cmd.Parameters.AddWithValue("@codedocument", codeDocument);
            cmd.CommandText = query;
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            adap.Fill(ds);
            return ds;
        }

        public static DataSet SelectParticipationByStar(int idStar)
        {
            string query = "SELECT document.anneesortie,document.titre,role.libelle,role.personnage FROM participer" +
                " JOIN star ON participer.idstar = star.idstar " +
                "JOIN role ON participer.idrole = role.idrole " +
                "JOIN document ON participer.codedocument = document.codedocument " +
                "where participer.idstar =@idstar";



            DataSet ds = new DataSet(); ;
            MySqlCommand cmd = DBConnect.GetConnexion().CreateCommand();
            cmd.Parameters.AddWithValue("@idstar",idStar);
            cmd.CommandText = query;
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            adap.Fill(ds);
            return ds;
        }

        public void AjouterParticipant(Participer participant)
        {

            string query = "INSERT INTO `participer`(`codedocument`, `idstar`, `idrole`) " +
          " VALUES ( @codedocument,@idstar,@idrole)";

            try
            {
              
                MySqlCommand cmd = DBConnect.GetConnexion().CreateCommand();
                cmd.CommandText = query;
                //Execute command
                //Execute command
                cmd.Parameters.AddWithValue("@codedocument", participant.Doc.Code);
                cmd.Parameters.AddWithValue("@idrole",participant.Role.Id );
                cmd.Parameters.AddWithValue("@idstar", participant.Star.Id);

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }
    }

}
