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
        public String authenticateUser(String username , String password) {

            DBConnectionService connectionService = new DBConnectionService();
            SqlConnection con = connectionService.getDbConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(SqlQueryHelper.getLoginQuery() ,con);
            cmd.Parameters.AddWithValue("@username",username);
            cmd.Parameters.AddWithValue("@password",password);

            try
            {
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                con.Close();

                String count = dt.Rows[0][0].ToString();
                return count;
            }
            catch (Exception ex)
            {

                return "";
            }

        }
    }
}
