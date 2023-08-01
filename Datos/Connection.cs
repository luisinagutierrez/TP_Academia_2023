using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Connection
    {
        public static SqlConnection Connect()
        {
            SqlConnection conn = new SqlConnection("server=PC-LUCA;Integrated Security=false;Database=db_Academia_302_TT_2023;uid=sa;pwd=261001;");
            conn.Open();
            return conn;
        }
        //public SqlConnection connection;
        //public string connectionString = "server=PC-LUCA;Integrated Security=false;Database=db_Academia_302_TT_2023;uid=sa;pwd=261001;";

        //public void OpenConnection()
        //{
        //    connection = new SqlConnection(connectionString);
        //    connection.Open();
        //}

        public static SqlConnection Disconnect()
        {
            SqlConnection conn = new SqlConnection("server=PC-LUCA;Integrated Security=false;Database=db_Academia_302_TT_2023;uid=sa;pwd=261001;");
            conn.Close();
            return conn;
        }

        // Aquí puedes agregar otros métodos para ejecutar consultas en la base de datos
    }

}

