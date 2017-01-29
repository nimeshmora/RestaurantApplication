using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DineInApplication.service;
using System.Data.SqlClient;
using DineInApplication.sqlqueries;

namespace DineInApplication.ui
{
    public partial class Order : Form
    {
        private int selectedItemId;
        public Order()
        {
            InitializeComponent();

            FoodItemService foodItemService = new FoodItemService();
            DataTable dataSnacks = foodItemService.serveSnackItems();
            BindingSource bSourceSnack = new BindingSource();
            bSourceSnack.DataSource = dataSnacks;
            snackDataGrid.DataSource = bSourceSnack;

            DataTable dataSoups = foodItemService.serveSoupItems();
            BindingSource bSourceSoups = new BindingSource();
            bSourceSoups.DataSource = dataSoups;
            soupDataGrid.DataSource = bSourceSoups;

            DataTable dataMains = foodItemService.serveMainsItems();
            BindingSource bSourceMains = new BindingSource();
            bSourceMains.DataSource = dataMains;
            mainsDataGrid.DataSource = bSourceMains;

            DataTable dataBeverages = foodItemService.serveBeverageItems();
            BindingSource bSourceBeverages = new BindingSource();
            bSourceBeverages.DataSource = dataBeverages;
            beverageDataGrid.DataSource = bSourceBeverages;

            DataTable dataDessert = foodItemService.serveDessertItems();
            BindingSource bSourceDesserts = new BindingSource();
            bSourceDesserts.DataSource = dataDessert;
            dessertDataGrid.DataSource = bSourceDesserts;
            
        }

        private void Order_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu mainmenu = new MainMenu();
            mainmenu.StartPosition = FormStartPosition.Manual;
            mainmenu.Location = new Point(this.Location.X + (this.Width - mainmenu.Width) / 2, this.Location.Y + (this.Height - mainmenu.Height) / 2);
            mainmenu.Show();
            this.Close();

        }


        private void snackDataGrid_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void snackDataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            String item_image = "";

            if (snackDataGrid.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.snackDataGrid.SelectedRows[0];
                String s = Convert.ToString(row.Cells["item_id"].Value);
                selectedItemId = Convert.ToInt32(s);

                DBConnectionService connectionService = new DBConnectionService();
                SqlConnection con = connectionService.getDbConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand(SqlQueryHelper.getFoodItemImageQuery(), con);
                cmd.Parameters.AddWithValue("@itemId", selectedItemId);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                con.Close();

                foreach (DataRow r in dt.Rows)
                {
                    item_image = r["item_image"].ToString();
                }

                snackImageBox.ImageLocation = @item_image;
            }
        }


        
    }
}
