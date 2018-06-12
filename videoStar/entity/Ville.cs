using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace videoStar
{
    public class Ville
    {
        int id;
        String libelle;
        int idCp;
        String cp;
        String pays;

        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }
        public int IdCp { get => idCp; set => idCp = value; }
        public string Cp { get => cp; set => cp = value; }
        public string Pays { get => pays; set => pays = value; }

        public Ville()
        {
           
        }
        public Ville(int id, string libelle)
        {
            this.Id = id;
            this.Libelle = libelle;
          
        }

        public Ville(int id, string libelle, int idCp)
        {
            this.Id = id;
            this.Libelle = libelle;
            this.IdCp = idCp;
        }



        public Adherent GetVilleBy(Adherent adherent)
        {

            string query = "SELECT ville.libelle,code_postal.libelle,pays.libelle FROM ville" +
                           " JOIN   code_postal on ville.ID_CodePostal=code_postal.ID_CodePostal " +
                           "JOIN pays on code_postal.ID_Pays=pays.ID_Pays " +
                           " where `ID_Ville`=@id_civilite ";


            MySqlCommand cmd = DBConnect.GetConnexion().CreateCommand();

            cmd.Parameters.AddWithValue("@id_civilite", adherent.IdCivilite);
            cmd.CommandText = query;


            //Create a data reader and Execute the command
            MySqlDataReader dataReader = cmd.ExecuteReader();

            //Read the data and store them in the list
            while (dataReader.Read())
            {

              //  MessageBox.Show(dataReader["libelle"].ToString());

            }

            dataReader.Close();

            return adherent;

        }
        public static List<Ville> GetVillePages(string recherche, int activepage, int pageitem)//int number,int start)
        {

            string query = "SELECT * FROM ville WHERE libelle LIKE @recherche  LIMIT @active,8";
                          


            MySqlCommand cmd = DBConnect.GetConnexion().CreateCommand();

            cmd.Parameters.AddWithValue("@recherche", recherche + '%');
            cmd.Parameters.AddWithValue("@active", ((activepage-1)*pageitem));

            cmd.CommandText = query;


            //Create a data reader and Execute the command
            MySqlDataReader dataReader = cmd.ExecuteReader();
            List<Ville> villes = new List<Ville>();
            //Read the data and store them in the list
            while (dataReader.Read())
            {

              int id =int.Parse(dataReader["ID_Ville"].ToString());
                String libelle = dataReader["libelle"].ToString();
                Ville ville = new Ville(id, libelle);

                villes.Add(ville);
            }

            dataReader.Close();

            return villes;

        }
        public static int  CountVilles(string recherche)//int number,int start)
        {

            string query = "SELECT COUNT(*) FROM ville WHERE libelle LIKE @recherche";
            int Count = -1;


            MySqlCommand cmd = DBConnect.GetConnexion().CreateCommand();
            cmd.Parameters.AddWithValue("@recherche", recherche + '%');
           
            cmd.CommandText = query;

           
             Count = int.Parse(cmd.ExecuteScalar().ToString() );


            return Count;

        }

        public static Ville DetailVille(string id)//int number,int start)
        {
            
            string query = "SELECT ID_Ville, ville.libelle as 'ville',code_postal.libelle as 'cp',pays.libelle as 'pays'FROM ville" +
                           " JOIN   code_postal on ville.ID_CodePostal=code_postal.ID_CodePostal " +
                           "JOIN pays on code_postal.ID_Pays=pays.ID_Pays " +
                           " where `ID_Ville`=@id ";
           
            

            MySqlCommand cmd = DBConnect.GetConnexion().CreateCommand();
            cmd.Parameters.AddWithValue("@id", id);

            cmd.CommandText = query;

            //Create a data reader and Execute the command
            MySqlDataReader dataReader = cmd.ExecuteReader();
            Ville ville = new Ville();
            //Read the data and store them in the list
            while (dataReader.Read())
            {
               
                ville.Id = int.Parse(dataReader["ID_Ville"].ToString());
                ville.Libelle = dataReader["ville"].ToString();
                ville.Cp = dataReader["cp"].ToString();
                ville.Pays = dataReader["pays"].ToString();
            }

            dataReader.Close();



            return ville;

        }






    }
}
