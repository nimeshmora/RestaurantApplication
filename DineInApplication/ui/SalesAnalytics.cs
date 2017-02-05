using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using DineInApplication.service;
using System.Data.SqlClient;
using System.Collections;

namespace DineInApplication.ui
{
    public partial class SalesAnalytics : Form
    {
        private ArrayList menuItemQuantities;
        private ArrayList menuItemType;
        SalesService salesService;
        
        public SalesAnalytics()
        {
            InitializeComponent();
            salesService = new SalesService();

            menuItemQuantities = new ArrayList();
            menuItemType = new ArrayList();
            menuItemType.Add("Snacks");
            menuItemType.Add("Soups");
            menuItemType.Add("Mains");
            menuItemType.Add("Beverages");
            menuItemType.Add("Desserts");


            SqlDataReader reader = salesService.getAllTimeFoodItemQuantities();
            while(reader.Read()){

                menuItemQuantities.Add(reader["total"]);
                
            }
            reader.Close();

            for (int i = 0; i < menuItemQuantities.Count;i++ )
            {
                int point = chart1.Series["salesSeries"].Points.AddY(menuItemQuantities[i]);
                DataPoint pt = chart1.Series["salesSeries"].Points[point];
                pt.LegendText = menuItemType[i].ToString();
            }

            menuItemQuantities.Clear();
        

        }

        private void button2_Click(object sender, EventArgs e)
        {

            chart1.Series["salesSeries"].Points.Clear();
            SqlDataReader reader = salesService.getLastThirtyDaysFoodItemquanitites();
            while (reader.Read())
            {

                menuItemQuantities.Add(reader["total"]);

            }
            reader.Close();
            for (int i = 0; i < menuItemQuantities.Count; i++)
            {
                int point = chart1.Series["salesSeries"].Points.AddY(menuItemQuantities[i]);
                DataPoint pt = chart1.Series["salesSeries"].Points[point];
                pt.LegendText = menuItemType[i].ToString();
            }

            menuItemQuantities.Clear();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series["salesSeries"].Points.Clear();
            SqlDataReader reader = salesService.getAllTimeFoodItemQuantities();
            while (reader.Read())
            {

                menuItemQuantities.Add(reader["total"]);

            }
            reader.Close();
            for (int i = 0; i < menuItemQuantities.Count; i++)
            {
                int point = chart1.Series["salesSeries"].Points.AddY(menuItemQuantities[i]);
                DataPoint pt = chart1.Series["salesSeries"].Points[point];
                pt.LegendText = menuItemType[i].ToString();
            }

            menuItemQuantities.Clear();
        

        }

        private void button3_Click(object sender, EventArgs e)
        {
            chart1.Series["salesSeries"].Points.Clear();
            SqlDataReader reader = salesService.getLastSevenDaysFoodItemQuantities();
            while (reader.Read())
            {

                menuItemQuantities.Add(reader["total"]);

            }
            reader.Close();
            for (int i = 0; i < menuItemQuantities.Count; i++)
            {
                int point = chart1.Series["salesSeries"].Points.AddY(menuItemQuantities[i]);
                DataPoint pt = chart1.Series["salesSeries"].Points[point];
                pt.LegendText = menuItemType[i].ToString();
            }

            menuItemQuantities.Clear();
        }


    }
}
