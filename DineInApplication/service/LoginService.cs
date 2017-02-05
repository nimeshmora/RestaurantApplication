using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DineInApplication.sqlqueries;
using System.Windows.Forms;

namespace DineInApplication.service
{
    class LoginService
    {
        private static int loggedInUserID = 0;

        public static int getLoggedInUserID() {
            return loggedInUserID;
        }
        public int authenticateUser(String username , String password) {

            DBConnectionService connectionService = new DBConnectionService();
            SqlConnection con = connectionService.getDbConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(SqlQueryHelper.getLoginUserIDQuery() ,con);
            cmd.Parameters.AddWithValue("@username",username);
            cmd.Parameters.AddWithValue("@password",password);

            try
            {
                loggedInUserID = Convert.ToInt32(cmd.ExecuteScalar());
                return loggedInUserID;
            }
            catch (Exception ex)
            {

                return 0;
            }

        }
    }
}
