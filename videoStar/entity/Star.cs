using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using videoStar.exception.Star;

namespace videoStar.entity
{
   public class Star
    {
        int id;
        String nom;
        String prenom;
        DateTime  datenaisance;
        String paysOrigine;
        string photo;
       

        public int Id { get => id; set => id = value; }
        public string Nom
        {
            get => nom;
            set
            {
                if (value.Length >= 1)
                {
                    nom = value;
                }
                else
                {
                    throw new StarNomException();
                }
            }
        }


        public String Prenom
        {
         get => prenom;
            set
             {
                 if (value.Length >= 1)
                   {
                      prenom = value;
                   }
                 else
                  {
                   throw new StarPrenomException();
                  }
             }
        }
        public DateTime Datenaisance { get => datenaisance; set => datenaisance = value; }
        public String Photo { get => photo; set => photo = value; }
        public String PaysOrigine { get => paysOrigine; set => paysOrigine = value; }
       

        public Star()
        {
        }

        public Star(String nom, String prenom, DateTime datenaisance, String paysOrigine)
        {
            Nom = nom;
            Prenom = prenom;
            Datenaisance = datenaisance;
            PaysOrigine = paysOrigine;         
        }
        public Star(int id, String nom, String prenom, String paysOrigine)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
           
            PaysOrigine = paysOrigine;
        }


        public static List<Star> GetStarsPages(string recherche, int activepage, int pageitem)
        {
            string query = "SELECT * FROM star WHERE nom LIKE @recherche  LIMIT @active,@pageitem";

            MySqlCommand cmd = DBConnect.GetConnexion().CreateCommand();

            cmd.Parameters.AddWithValue("@recherche", recherche + '%');
            cmd.Parameters.AddWithValue("@active", ((activepage - 1) * pageitem));
            cmd.Parameters.AddWithValue("@pageitem",  pageitem);
            cmd.CommandText = query;

            MySqlDataReader dataReader = cmd.ExecuteReader();
            List<Star> stars = new List<Star>();
           
            while (dataReader.Read())
            {              
                Star st = new Star();
                st.Id = int.Parse(dataReader["idstar"].ToString());
                st.Nom = dataReader["nom"].ToString();
                st.Prenom = dataReader["prenom"].ToString();
                st.Datenaisance = DateTime.Parse(dataReader["datenaissance"].ToString());
                st.PaysOrigine= dataReader["paysorigine"].ToString();
                st.Photo = dataReader["photo"].ToString();              

                stars.Add(st);
            }

            dataReader.Close();

            return stars;

        }
        public static int CountStars(string recherche)
        {

            string query = "SELECT COUNT(*) FROM star WHERE nom LIKE @recherche";
            int Count = -1;

            MySqlCommand cmd = DBConnect.GetConnexion().CreateCommand();
            cmd.Parameters.AddWithValue("@recherche", recherche + '%');

            cmd.CommandText = query;

            Count = int.Parse(cmd.ExecuteScalar().ToString());

            return Count;

        }

        public void InsertStar(Star st)
        {
            string query = "INSERT INTO `star` (`idstar`, `nom`, `prenom`, `datenaissance`, `paysorigine`, `photo`) " +
          " VALUES (NULL, @nom,@prenom, @date, @pays, @photo)";

            try
            {               
                MySqlCommand cmd = DBConnect.GetConnexion().CreateCommand();
                cmd.CommandText = query;
                
                cmd.Parameters.AddWithValue("@Nom", st.Nom);
                cmd.Parameters.AddWithValue("@Prenom", st.Prenom);
                cmd.Parameters.AddWithValue("@date", st.Datenaisance);
                cmd.Parameters.AddWithValue("@photo", st.Photo);
                cmd.Parameters.AddWithValue("@pays", st.PaysOrigine);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                  MessageBox.Show(ex.Message);
            }           

        }

        public Star GetStarDetail()
        {
            //todo methode get document by stars
            //puis instancie ...
            return this;
        }

    }
}
 