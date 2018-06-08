using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace videoStar
{
    class Civilite
    {
        int id;
        String libelle;

        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }

        public Civilite(int id, string libelle)
        {
            Id = id;
            Libelle = libelle;
        }

        public Adherent  GetCiviliteBy(Adherent adherent)
        {

            string query = "SELECT civilite.libelle FROM civilite where id_civilite=@id_civilite";


            MySqlCommand cmd = DBConnect.GetConnexion().CreateCommand();

            cmd.Parameters.AddWithValue("@id_civilite", adherent.IdCivilite);
            cmd.CommandText = query;


            //Create a data reader and Execute the command
            MySqlDataReader dataReader = cmd.ExecuteReader();

            //Read the data and store them in the list
            while (dataReader.Read())
            {




                MessageBox.Show(dataReader["libelle"].ToString());

            }

            dataReader.Close();

            return adherent;

        }

    }
}
