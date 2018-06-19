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
    public class Role
    {
       private int id;
        private String libelle;
        private String service;
        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }

        public Role()
        {
        }

        public Role(int id, string libelle)
        {
            Id = id;
            Libelle = libelle;
        }

        public static List<Role> GetRolesByName(string recherche, int activepage, int pageitem)
        {
            List < Role > roles= new List<Role>();
            string query = "SELECT * FROM role WHERE libelle LIKE @recherche  LIMIT @active,@pageitem";



            MySqlCommand cmd = DBConnect.GetConnexion().CreateCommand();

            cmd.Parameters.AddWithValue("@recherche", recherche + '%');
            cmd.Parameters.AddWithValue("@active", ((activepage - 1) * pageitem));
            cmd.Parameters.AddWithValue("@pageitem", pageitem);
            cmd.CommandText = query;


            //Create a data reader and Execute the command
            MySqlDataReader dataReader = cmd.ExecuteReader();
            //Read the data and store them in the list
            while (dataReader.Read())
            {

                int id = int.Parse(dataReader["idrole"].ToString());
                String libelle = dataReader["libelle"].ToString();
                Role unRole = new Role(id, libelle);

                roles.Add(unRole);

            }
            dataReader.Close();

            return roles;
            
        }
        

            public static DataSet SelectRole()
        {
            string query = "SELECT libelle FROM role";



            DataSet ds = new DataSet(); ;
            MySqlCommand cmd = DBConnect.GetConnexion().CreateCommand();
            cmd.CommandText = query;
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                ds = new DataSet();
                adap.Fill(ds);
                return ds;
         }


        public void Ajouter(Role rl)
        {

            string query = "INSERT INTO `role` ('idrole', `libelle`) " +
          " VALUES (NULL, @libelle)";




            try
            {

                //create command and assign the query and connection from the constructor
                // MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlCommand cmd = DBConnect.GetConnexion().CreateCommand();
                cmd.CommandText = query;
                //Execute command
                //Execute command
                cmd.Parameters.AddWithValue("@libelle", rl.Libelle);
                
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











