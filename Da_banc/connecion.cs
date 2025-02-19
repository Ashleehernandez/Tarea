using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Da_banc
{
    public class connecion
    {

        static string connectionString = "Data Source=DESKTOP-VVPHGA7\\SQLEXPRESS;Initial Catalog=BANCO;User ID=DESKTOP-VVPHGA7\\ashle;Password=; Trusted_Connection = True; TrustServerCertificate = True;";

        //octener connecion 
        public static SqlConnection getconnection()
        {
            return new SqlConnection(connectionString);
        }

    }
}
