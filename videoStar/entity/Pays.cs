using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace videoStar
{
  public  class Pays
    {
        int id;
        String libelle;

        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }

        public Pays(int id, string libelle)
        {
            Id = id;
            Libelle = libelle;
        }


public static List<Pays> GetPaysByName(string recherche,int activepage,int pageitem)
        {
            string query = "SELECT * FROM pays WHERE libelle LIKE @recherche  LIMIT @active,@pageitem";



            MySqlCommand cmd = DBConnect.GetConnexion().CreateCommand();

            cmd.Parameters.AddWithValue("@recherche", recherche + '%');
            cmd.Parameters.AddWithValue("@active", ((activepage - 1) * pageitem));
            cmd.Parameters.AddWithValue("@pageitem", pageitem);
            cmd.CommandText = query;


            //Create a data reader and Execute the command
            MySqlDataReader dataReader = cmd.ExecuteReader();
            List<Pays> pays = new List<Pays>();
            //Read the data and store them in the list
            while (dataReader.Read())
            {

                int id = int.Parse(dataReader["idpays"].ToString());
                String libelle = dataReader["libelle"].ToString();
                Pays unpays = new Pays(id, libelle);

                pays.Add(unpays);

            }

            dataReader.Close();

            return pays;

        }





    }








 }
