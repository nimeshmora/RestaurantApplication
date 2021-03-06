﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DineInApplication.sqlqueries;
using System.Data;

namespace DineInApplication.service
{
    class FoodItemService
    {
        private SqlConnection con;

        public FoodItemService() {

            DBConnectionService connectionService = new DBConnectionService();
            con = connectionService.getDbConnection();
            con.Open();
        }

        public DataTable serveSnackItems() 
        {

            SqlCommand cmd = new SqlCommand(SqlQueryHelper.getFoodTypeServeQuery(), con);
            cmd.Parameters.AddWithValue("@foodType", "Snacks");

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

        public DataTable serveSoupItems() {

            SqlCommand cmd = new SqlCommand(SqlQueryHelper.getFoodTypeServeQuery(), con);
            cmd.Parameters.AddWithValue("@foodType", "Soups");

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

        public DataTable serveMainsItems()
        {

            SqlCommand cmd = new SqlCommand(SqlQueryHelper.getFoodTypeServeQuery(), con);
            cmd.Parameters.AddWithValue("@foodType", "Mains");

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

        public DataTable serveBeverageItems()
        {

            SqlCommand cmd = new SqlCommand(SqlQueryHelper.getFoodTypeServeQuery(), con);
            cmd.Parameters.AddWithValue("@foodType", "Beverages");

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

        public DataTable serveDessertItems()
        {

            SqlCommand cmd = new SqlCommand(SqlQueryHelper.getFoodTypeServeQuery(), con);
            cmd.Parameters.AddWithValue("@foodType", "Desserts");

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


        public static String provideFoodItemImagePath(int slectedItemId)
        {

            String item_image = "";
            DBConnectionService connectionService = new DBConnectionService();
            SqlConnection con = connectionService.getDbConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(SqlQueryHelper.getFoodItemImageQuery(), con);
            cmd.Parameters.AddWithValue("@itemId", slectedItemId);
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            con.Close();

            foreach (DataRow r in dt.Rows)
            {
                item_image = r["item_image"].ToString();
            }
            return item_image;
        }

    }
}
