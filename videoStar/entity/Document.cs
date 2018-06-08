using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace videoStar
{
    class Document
    {
        
        String code;
        String titre;

        public string Code { get => code; set => code = value; }
        public string Titre { get => titre; set => titre = value; }

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
    }
}
