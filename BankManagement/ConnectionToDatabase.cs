using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement
{
    public class ConnectionToDatabase
    {
        public string connectionString = "Data Source=THISPC\\SQLEXPRESS;Initial Catalog=SignUpUser;Integrated Security=True";
        public SqlConnection connection;
        public ConnectionToDatabase()
        {
            connection = new SqlConnection(connectionString);
        }
    }
}
