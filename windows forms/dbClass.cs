using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace WindowsFormsApplication1
{
    class dbClass
    {
        public static MySqlConnection dbConn;
        public static void dbCall()
        {      
            dbConn = new MySqlConnection("Server=localhost" + "Database=trainsystem;" + "Uid=root;" + "Pwd=123;");

            if (dbConn.State != ConnectionState.Open)
            {
                dbConn.Open();
            }
        }

        public static void dbClose()
        {
            dbConn.Close();
        }
 

    }
}
