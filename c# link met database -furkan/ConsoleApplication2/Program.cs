using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Data
{
    public class DBConnection
    {
        private DBConnection()
        {
        }

        private string databaseName = string.Empty;
        public string DatabaseName
        {
            get { return databaseName; }
            set { databaseName = value; }
        }

        public string Password { get; set; }
        private MySqlConnection connection = null;
        public MySqlConnection Connection
        {
            get { return connection; }
        }

        private static DBConnection _instance = null;
        public static DBConnection Instance()
        {
            if (_instance == null)
                _instance = new DBConnection();
            return _instance;
        }

        public bool IsConnect()
        {
            bool result = true;
            if (Connection == null)
            {
                if (String.IsNullOrEmpty(databaseName))
                    result = false;
<<<<<<< HEAD
                string connstring = string.Format("Server=localhost; database={0}; UID=root; password=0000", databaseName);
=======
                string connstring = string.Format("Server=localhost; database={0}; UID=root; password=0848963", databaseName);
>>>>>>> 49b5520076899fe705e50f69113627996413473f
                connection = new MySqlConnection(connstring);
                connection.Open();
                result = true;
            }

            return result;
        }

        public void Close()
        {
            connection.Close();
        }
    }
    

    public class db
    {


        static void Main()
        {
            var dbCon = DBConnection.Instance();
<<<<<<< HEAD
            dbCon.DatabaseName = "bigdata";
=======
            dbCon.DatabaseName = "project3";
>>>>>>> 49b5520076899fe705e50f69113627996413473f

            if (dbCon.IsConnect())
            {
                //suppose col0 and col1 are defined as VARCHAR in the DB
<<<<<<< HEAD
                string query = "SELECT * FROM beschadiging";
=======
                string query = "SELECT * FROM beschadiging_auto";
>>>>>>> 49b5520076899fe705e50f69113627996413473f
                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();
                List<string> lijst = new List<string>();
                while (reader.Read())
                {
                    
                    
                    for (int x = 0; x < 6; x++)
                    {
                        lijst.Add(reader.GetString(x));
                        lijst.Add(" ");
                    }
                    lijst.Add("\n");
                }

                Console.WriteLine(string.Join("" , lijst));
                Console.ReadLine();
            }

         }


    }
}





