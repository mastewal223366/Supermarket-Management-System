using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketManagementSystem
{
   public  class DataBase
    {
      public static MySqlConnection connectDB()
        {
            MySqlConnection con;
            String Server = "localhost";
            String database = "Supermarket";
            String user = "root";
            String password = "";
            String connection = "SERVER=" + Server + ";" + "DATABASE=" + database + ";" + "UID=" + user + ";" + "PASSWORD=" + password + ";";
            con = new MySqlConnection(connection);
            return con;
        }
   
    }
}
