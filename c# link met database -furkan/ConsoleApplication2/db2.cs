using System;
using MySql.Data.MySqlClient;

namespace WebDb
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("test");
			string cs = @"SERVER=localhost;userid=root;
			            password=pass;DATABASE=sys";

			MySqlConnection conn = null;

        	try 
        	{
          		conn = new MySqlConnection(cs);
				conn.Open();
          		Console.WriteLine("MySQL version : {0}", conn.ServerVersion);
        	} 

			catch (MySqlException ex) 
        	{
          		Console.WriteLine("Error: {0}",  ex);

        	} 

			finally 
        	{          
          		if (conn != null) 
	          	{
	              	conn.Close();
	          	}
        	}
		}
	}
}
