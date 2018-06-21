using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using videoStar.entity;

namespace videoStar
{
   public class Document
    {
        
       private String code;
       private String titre;
       private  String annee;
       private String photo;
       private TypeDocument docType;
       private  List<Lieux> lieuTournage;
       private List<Jouer> jouers;

        public string Code { get => code; set => code = value; }
        public string Titre { get => titre; set => titre = value; }
        public string Annee { get => annee; set => annee = value; }
        public string Photo { get => photo; set => photo = value; }
        internal TypeDocument DocType { get => docType; set => docType = value; }
        public List<Lieux> LieuTournage { get => lieuTournage; set => lieuTournage = value; }
        public List<Jouer> Jouers { get => jouers; set => jouers = value; }

        public Document()
        {
        }


        public static void GetallDocuments()
        {

            string query = "SELECT * FROM document";
            

            MySqlCommand cmd = DBConnect.GetConnexion().CreateCommand();
          
            cmd.CommandText = query;


            //Create a data reader and Execute the command
            MySqlDataReader dataReader = cmd.ExecuteReader();

            //Read the data and store them in the list
            while (dataReader.Read())
            {




                MessageBox.Show(dataReader["codeDocument"].ToString());
                            
                }

            dataReader.Close();


        }

        public static void GetDocumentsBy()
        {

            string query = "SELECT * FROM document";


            MySqlCommand cmd = DBConnect.GetConnexion().CreateCommand();

            cmd.CommandText = query;


            //Create a data reader and Execute the command
            MySqlDataReader dataReader = cmd.ExecuteReader();

            //Read the data and store them in the list
            while (dataReader.Read())
            {




                MessageBox.Show(dataReader["codeDocument"].ToString());

            }

            dataReader.Close();

        }

        public void Insertdocument(Document film)
        {


            string query = "INSERT INTO `document` (`codedocument`, `titre`, `anneesortie`, `photo`, `codetypedocument`) " +
          " VALUES ( @code,@titre, @sortie, @photo, @codedoc)";




            try
            {

                //create command and assign the query and connection from the constructor
                // MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlCommand cmd = DBConnect.GetConnexion().CreateCommand();
                cmd.CommandText = query;
                //Execute command
                //Execute command
                cmd.Parameters.AddWithValue("@titre", film.Titre);
                cmd.Parameters.AddWithValue("@code",film.Code);
                cmd.Parameters.AddWithValue("@sortie", film.Annee);
                cmd.Parameters.AddWithValue("@photo", film.Photo);
                cmd.Parameters.AddWithValue("@codedoc", film.DocType.CodeTypeDocument);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            //close connection




        }











    }
}
