using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConnectDB
{
    class ConnectDB
    {
        string ConnectionString = @"Data Source=pc26;Initial Catalog=Test;Integrated Security=True";

        public void InsertQuery(string Query) {
            SqlConnection Cnn = new SqlConnection(ConnectionString);
            Cnn.Open();
            SqlCommand cmd = new SqlCommand(Query, Cnn);
            cmd.ExecuteNonQuery();
            Cnn.Close();
        }

    }
}
