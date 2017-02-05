using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DineInApplication.sqlqueries;

namespace DineInApplication.service
{
    class FoodCartService
    {
        public static void addFoodItemToCart(string itemQuantity, int itemId)
        {
            
            int max_id = 0;
            String order_date = "";
            DBConnectionService connectionService = new DBConnectionService();
            SqlConnection con = connectionService.getDbConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(SqlQueryHelper.getMaxOrderId(), con);
            if (cmd.ExecuteScalar() != null && DBNull.Value != cmd.ExecuteScalar())
            {
                max_id = Convert.ToInt32(cmd.ExecuteScalar());
            }
            else
            {
                max_id = 0;
            }

          
            SqlCommand dateCmd = new SqlCommand(SqlQueryHelper.getDateOfMaxOrderId(),con);
            dateCmd.Parameters.AddWithValue("@order_id", max_id);
            SqlDataReader reader = dateCmd.ExecuteReader();
            while(reader.Read()){
                order_date = reader["order_date"].ToString();
            }
            reader.Close();

            if (order_date != "0000")
            {

                SqlCommand addOrderTemporary = new SqlCommand(SqlQueryHelper.addOrderTempQuery(), con);
                addOrderTemporary.Parameters.AddWithValue("@order_date", "0000");
                addOrderTemporary.Parameters.AddWithValue("@user_id", 1);
                addOrderTemporary.ExecuteNonQuery();


                SqlCommand addOrderItemCmd = new SqlCommand(SqlQueryHelper.addOrderItemQuery(), con);
                addOrderItemCmd.Parameters.AddWithValue("@order_id", max_id+1);
                addOrderItemCmd.Parameters.AddWithValue("@food_item_id", itemId);
                addOrderItemCmd.Parameters.AddWithValue("@food_item_quantity", itemQuantity);
                addOrderItemCmd.ExecuteNonQuery();
           
            }
            else
            {

                SqlCommand addOrderItemCmd = new SqlCommand(SqlQueryHelper.addOrderItemQuery(), con);
                addOrderItemCmd.Parameters.AddWithValue("@order_id", max_id);
                addOrderItemCmd.Parameters.AddWithValue("@food_item_id", itemId);
                addOrderItemCmd.Parameters.AddWithValue("@food_item_quantity", itemQuantity);
                addOrderItemCmd.ExecuteNonQuery();
           

            }
            con.Close(); 
        }

        public static String addFoodOrder() { 

             // get max order id & check for data = 0000
            int max_id = 0;
            String order_date = "";
            int amount = 0;
            DateTime currentDate = DateTime.MinValue ;
            String dateAndAmount = "";

            DBConnectionService connectionService = new DBConnectionService();
            SqlConnection con = connectionService.getDbConnection();
            con.Open();
            SqlCommand maxOrderIdCheckCmd = new SqlCommand(SqlQueryHelper.getMaxOrderId(),con);
            if (maxOrderIdCheckCmd.ExecuteScalar() != null && DBNull.Value != maxOrderIdCheckCmd.ExecuteScalar())
            {
                max_id = Convert.ToInt32(maxOrderIdCheckCmd.ExecuteScalar());
            }
            if(max_id != 0){
                SqlCommand dateCmd = new SqlCommand(SqlQueryHelper.getDateOfMaxOrderId(), con);
                dateCmd.Parameters.AddWithValue("@order_id", max_id);
                SqlDataReader reader = dateCmd.ExecuteReader();
                while (reader.Read())
                {
                    order_date = reader["order_date"].ToString();
                }
                reader.Close();

            }

            if(order_date == "0000" && max_id != 0){
                SqlCommand orderItemSet = new SqlCommand(SqlQueryHelper.getOrderItemsValueForOrderQuery(), con);
                orderItemSet.Parameters.AddWithValue("@max_id", max_id);
                amount = Convert.ToInt32(orderItemSet.ExecuteScalar());
              
                SqlCommand updatePermanantOrderInOrderTbl = new SqlCommand(SqlQueryHelper.updateOrderQuery(),con);
                currentDate = DateTime.Now;
                currentDate.ToString("yyyyMMdd");

                updatePermanantOrderInOrderTbl.Parameters.AddWithValue("@order_date", currentDate);
                updatePermanantOrderInOrderTbl.Parameters.AddWithValue("@order_amount", amount);
                updatePermanantOrderInOrderTbl.Parameters.AddWithValue("@max_id", max_id);
                updatePermanantOrderInOrderTbl.Parameters.AddWithValue("@user_id", LoginService.getLoggedInUserID());
                updatePermanantOrderInOrderTbl.ExecuteNonQuery();
                dateAndAmount = "order date: " + currentDate + "  order amount: " + amount;
            }

            return dateAndAmount;
        }


      }
    
}
