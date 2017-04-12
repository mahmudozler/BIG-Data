using System;
using System.Collections.Generic;
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
                

                

                string queryColBeschadiging = "SELECT count(*) FROM information_schema.columns WHERE table_name = 'beschadiging_auto'";
                string queryColDiefstal = "SELECT count(*) FROM information_schema.columns WHERE table_name = 'diefstal_uit_auto'";
                string querySlachtoffer = "SELECT count(*) FROM information_schema.columns WHERE table_name = 'slachtoffers_diefstal_auto'";

                var cmdBeschadiging_auto = new MySqlCommand(queryColBeschadiging, dbCon.Connection);
                var cmdDiefstal_uit_auto = new MySqlCommand(queryColDiefstal, dbCon.Connection);
                var cmdSlachtoffers = new MySqlCommand(querySlachtoffer, dbCon.Connection);
                var readerBeschadiging_auto_col = cmdBeschadiging_auto.ExecuteReader();

                List<string> lijst = new List<string>();
                List<string> lijst1 = new List<string>();
                List<string> lijst2 = new List<string>();

                while (readerBeschadiging_auto_col.Read())
                {
                    for (int x = 0; x <1; x++)
                    {
                        lijst.Add(readerBeschadiging_auto_col.GetString(x));
                    }
                }

                int beschadiging_auto_col = Int32.Parse(lijst[0]);
                readerBeschadiging_auto_col.Close();

                var readerDiefstal_uit_auto = cmdDiefstal_uit_auto.ExecuteReader();
                while (readerDiefstal_uit_auto.Read())
                {
                    for (int x1 = 0; x1 < 1; x1++)
                    {
                        lijst1.Add(readerDiefstal_uit_auto.GetString(x1));
                    }
                }
                int diefstal_uit_auto_col = Int32.Parse(lijst1[0]);
                readerDiefstal_uit_auto.Close();

                var readerSlachtoffers = cmdSlachtoffers.ExecuteReader();
                while (readerSlachtoffers.Read())
                {
                    for (int x2 = 0; x2 < 1; x2++)
                    {
                        lijst2.Add(readerSlachtoffers.GetString(x2));
                    }
                }
                int slachtoffers_col = Int32.Parse(lijst2[0]);
                readerSlachtoffers.Close();


                string query1 = "SELECT * FROM beschadiging_auto";
                var cmd1 = new MySqlCommand(query1, dbCon.Connection);
                var reader1 = cmd1.ExecuteReader();
                
                List<string> beschadiging_auto = new List<string>();

                while (reader1.Read())
                {
                    for (int xR1 = 0; xR1 < beschadiging_auto_col; xR1++)
                    {
                        beschadiging_auto.Add(reader1.GetString(xR1));
                        beschadiging_auto.Add(" ");
                    }
                    beschadiging_auto.Add("\n");
                }
                Console.WriteLine("Percentages aantal beschadigde auto's per wijk \n");
                Console.WriteLine(string.Join("", beschadiging_auto));
                reader1.Close();

                string query2 = "SELECT * FROM diefstal_uit_auto";
                var cmd2 = new MySqlCommand(query2, dbCon.Connection);
                var reader2 = cmd2.ExecuteReader();

                List<string> diefstal_uit_auto = new List<string>();

                while (reader2.Read())
                {
                    for (int xR2 = 0; xR2 < diefstal_uit_auto_col; xR2++)
                    {
                        diefstal_uit_auto.Add(reader2.GetString(xR2));
                        diefstal_uit_auto.Add(" ");
                    }
                    diefstal_uit_auto.Add("\n");
                }

                Console.WriteLine(string.Join("", diefstal_uit_auto));
                reader2.Close();

                string query3 = "SELECT * FROM slachtoffers_diefstal_auto";
                var cmd3 = new MySqlCommand(query3, dbCon.Connection);
                var reader3 = cmd3.ExecuteReader();

                List<string> slachtoffers = new List<string>();

                while (reader3.Read())
                {
                    for (int xR3 = 0; xR3 < slachtoffers_col; xR3++)
                    {
                        slachtoffers.Add(reader3.GetString(xR3));
                        slachtoffers.Add(" ");
                    }
                    slachtoffers.Add("\n");
                }

                Console.WriteLine(string.Join("", slachtoffers));

                Console.ReadLine();
            }

         }


    }
}





