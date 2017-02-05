using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DineInApplication.sqlqueries;

namespace DineInApplication.service
{
    class SalesService
    {
        private  SqlConnection con;

        public SalesService() {

            DBConnectionService connectionService = new DBConnectionService();
            con = connectionService.getDbConnection();
            con.Open();
        }
        public  SqlDataReader getAllTimeFoodItemQuantities() {

           
            SqlCommand cmd = new SqlCommand(SqlQueryHelper.getAllTimeFoodQuantityQuery(), con);
            SqlDataReader reader = cmd.ExecuteReader();
            
            return reader;
        }

        public SqlDataReader getLastSevenDaysFoodItemQuantities() {

            SqlCommand cmd = new SqlCommand(SqlQueryHelper.getLastSevenDayFoodQuantityQuery(), con);
            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }

        public  SqlDataReader getLastThirtyDaysFoodItemquanitites() {
            
            SqlCommand cmd = new SqlCommand(SqlQueryHelper.getLastThirtyDayFoodQuantityQuery(), con);
            SqlDataReader reader = cmd.ExecuteReader();
            
            return reader;
        }
    }
}
