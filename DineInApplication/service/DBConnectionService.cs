using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DineInApplication.service
{
    class DBConnectionService
    {
        public SqlConnection getDbConnection(){


        String connectionString = @"Data Source=MESHBOY\MSSQLSEREVER3;Initial Catalog=dinein;Integrated Security=True;Pooling=False";
        try
        {

            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
        catch (Exception ex) {

            return null;
        }

        }
    }
}
