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

            

                string connstring = string.Format("Server=localhost; database={0}; UID=root; password=0848963", databaseName);

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

            

            dbCon.DatabaseName = "project3";

            if (dbCon.IsConnect())
            {
                //suppose col0 and col1 are defined as VARCHAR in the DB

                

                string query = "SELECT * FROM beschadiging_auto";

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





