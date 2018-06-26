using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace videoStar.entity
{
    class TypeDocument
    {
        private String codeTypeDocument;
        private String typenom;

        public string CodeTypeDocument { get => codeTypeDocument; set => codeTypeDocument = value; }
        public string Typenom { get => typenom; set => typenom = value; }

        public TypeDocument(string codeTypeDocument, string typenom)
        {
            CodeTypeDocument = codeTypeDocument;
            Typenom = typenom;
        }

        public static List<TypeDocument> GetTypeDocByCode(string recherche, int activepage, int pageitem)
        {
            List<TypeDocument> types = new List<TypeDocument>();
            string query = "SELECT * FROM typedocument WHERE codetypedocument LIKE @recherche  LIMIT @active,@pageitem";

            MySqlCommand cmd = DBConnect.GetConnexion().CreateCommand();

            cmd.Parameters.AddWithValue("@recherche", recherche + '%');
            cmd.Parameters.AddWithValue("@active", ((activepage - 1) * pageitem));
            cmd.Parameters.AddWithValue("@pageitem", pageitem);
            cmd.CommandText = query;

            MySqlDataReader dataReader = cmd.ExecuteReader();
 
            while (dataReader.Read())
            {               
                TypeDocument unType = new TypeDocument(dataReader["codetypedocument"].ToString(),
                    dataReader["typenom"].ToString());

                types.Add(unType);

            }
            dataReader.Close();

            return types;

        }

    }
}
