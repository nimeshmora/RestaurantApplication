using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DineInApplication.sqlqueries;
using System.Data;

namespace DineInApplication.service
{
    class FeedbackService
    {
        private SqlConnection con;
        private Boolean isFeedbackSaved = false;
        
        public FeedbackService() {

            DBConnectionService connectionService = new DBConnectionService();
            con = connectionService.getDbConnection();
            con.Open();
        }

        public DataTable serveCustomerOrdersToGiveFeedBack() {

            SqlCommand cmd = new SqlCommand(SqlQueryHelper.getCustomerOrdersQuery(), con);
            cmd.Parameters.AddWithValue("@user_id", LoginService.getLoggedInUserID());
            
            try
            {
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                con.Close();

                return dt;
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public Boolean saveFeedBack(int present, int price, int taste, int time, String comment, int selectedOrderId) {

            int updatedRowsInOrderTable=0;
            SqlCommand cmdSaveFeed = new SqlCommand(SqlQueryHelper.addFeedBackForOrder(), con);
            cmdSaveFeed.Parameters.AddWithValue("@present", present);
            cmdSaveFeed.Parameters.AddWithValue("@taste", taste);
            cmdSaveFeed.Parameters.AddWithValue("@timetoprepare", time);
            cmdSaveFeed.Parameters.AddWithValue("@price", price);
            cmdSaveFeed.Parameters.AddWithValue("@comment", comment);
            int numOfRowsAddedInFeedTable = cmdSaveFeed.ExecuteNonQuery();

            if (numOfRowsAddedInFeedTable > 0)
            {
                
                SqlCommand cmdFeedMaxID = new SqlCommand(SqlQueryHelper.getMaxFeedID(), con);
                int feedMaxID = Convert.ToInt32(cmdFeedMaxID.ExecuteScalar());

                SqlCommand cmdUpdateOrderTableWithFeedBackID = new SqlCommand(SqlQueryHelper.updateOrderTableWithAddedFeedID(), con);
                cmdUpdateOrderTableWithFeedBackID.Parameters.AddWithValue("@feedMaxID", feedMaxID);
                cmdUpdateOrderTableWithFeedBackID.Parameters.AddWithValue("@selectedOrderID", selectedOrderId);

                 updatedRowsInOrderTable = cmdUpdateOrderTableWithFeedBackID.ExecuteNonQuery();

            }

            if (updatedRowsInOrderTable > 0 && numOfRowsAddedInFeedTable>0)
            {
                isFeedbackSaved = true;
            }
            
            return isFeedbackSaved;
        }
    }
}
