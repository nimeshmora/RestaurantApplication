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
using Microsoft.VisualBasic;

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

                item_image = FoodItemService.provideFoodItemImagePath(selectedItemId);

                snackImageBox.ImageLocation = @item_image;
            }
        }

        private void soupDataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            String item_image = "";

            if (soupDataGrid.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.soupDataGrid.SelectedRows[0];
                String s = Convert.ToString(row.Cells["item_id"].Value);
                selectedItemId = Convert.ToInt32(s);
                item_image = FoodItemService.provideFoodItemImagePath(selectedItemId);

                soupImageBox.ImageLocation = @item_image;
            }
        }

        private void mainsDataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            String item_image = "";

            if (mainsDataGrid.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.mainsDataGrid.SelectedRows[0];
                String s = Convert.ToString(row.Cells["item_id"].Value);
                selectedItemId = Convert.ToInt32(s);
                item_image = FoodItemService.provideFoodItemImagePath(selectedItemId);

                mainsImageBox.ImageLocation = @item_image;
            }
        }

        private void dessertDataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            String item_image = "";

            if (dessertDataGrid.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.dessertDataGrid.SelectedRows[0];
                String s = Convert.ToString(row.Cells["item_id"].Value);
                selectedItemId = Convert.ToInt32(s);
                item_image = FoodItemService.provideFoodItemImagePath(selectedItemId);

                dessertImageBox.ImageLocation = @item_image;
            }
        }

        private void beverageDataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            String item_image = "";

            if (beverageDataGrid.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.beverageDataGrid.SelectedRows[0];
                String s = Convert.ToString(row.Cells["item_id"].Value);
                selectedItemId = Convert.ToInt32(s);
                item_image = FoodItemService.provideFoodItemImagePath(selectedItemId);

                beverageImageBox.ImageLocation = @item_image;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (snackDataGrid.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.snackDataGrid.SelectedRows[0];
                String s = Convert.ToString(row.Cells["item_id"].Value);
                int selectedItemId = Convert.ToInt32(s);
                string itemQuantity = Microsoft.VisualBasic.Interaction.InputBox("Item Quantity ", "Quantity", "1");
                FoodCartService.addFoodItemToCart(itemQuantity, selectedItemId);
                MessageBox.Show("Item added to cart");
            }
            else {
                MessageBox.Show("Select food item first!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (soupDataGrid.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.soupDataGrid.SelectedRows[0];
                String s = Convert.ToString(row.Cells["item_id"].Value);
                int selectedItemId = Convert.ToInt32(s);
                string itemQuantity = Microsoft.VisualBasic.Interaction.InputBox("Item Quantity ", "Quantity", "1");
                FoodCartService.addFoodItemToCart(itemQuantity, selectedItemId);
                MessageBox.Show("Item added to cart");
            }
            else
            {
                MessageBox.Show("Select food item first!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (mainsDataGrid.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.mainsDataGrid.SelectedRows[0];
                String s = Convert.ToString(row.Cells["item_id"].Value);
                int selectedItemId = Convert.ToInt32(s);
                string itemQuantity = Microsoft.VisualBasic.Interaction.InputBox("Item Quantity ", "Quantity", "1");
                FoodCartService.addFoodItemToCart(itemQuantity, selectedItemId);
                MessageBox.Show("Item added to cart");
            }
            else
            {
                MessageBox.Show("Select food item first!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dessertDataGrid.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.dessertDataGrid.SelectedRows[0];
                String s = Convert.ToString(row.Cells["item_id"].Value);
                int selectedItemId = Convert.ToInt32(s);
                string itemQuantity = Microsoft.VisualBasic.Interaction.InputBox("Item Quantity ", "Quantity", "1");
                FoodCartService.addFoodItemToCart(itemQuantity, selectedItemId);
                MessageBox.Show("Item added to cart");
            }
            else
            {
                MessageBox.Show("Select food item first!");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (beverageDataGrid.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.beverageDataGrid.SelectedRows[0];
                String s = Convert.ToString(row.Cells["item_id"].Value);
                int selectedItemId = Convert.ToInt32(s);
                string itemQuantity = Microsoft.VisualBasic.Interaction.InputBox("Item Quantity ", "Quantity", "1");
                FoodCartService.addFoodItemToCart(itemQuantity, selectedItemId);
                MessageBox.Show("Item added to cart!");
            }
            else
            {
                MessageBox.Show("Select food item first!");
            }
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            String amountAndDate = FoodCartService.addFoodOrder();
            if (amountAndDate != "")
            {
                MessageBox.Show("Order Successful " + amountAndDate);
            }
            else {
                MessageBox.Show("Add items to cart first!");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            String amountAndDate =  FoodCartService.addFoodOrder();
            if (amountAndDate != "")
            {
                MessageBox.Show("Order Successful " + amountAndDate);
            }
            else
            {
                MessageBox.Show("Add items to cart first!");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
             String amountAndDate = FoodCartService.addFoodOrder();
            if(amountAndDate != ""){
                MessageBox.Show("Order Successful " + amountAndDate);
            }
            else
            {
                MessageBox.Show("Add items to cart first!");
            }
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            String amountAndDate =  FoodCartService.addFoodOrder();
            if (amountAndDate != "")
            {
                MessageBox.Show("Order Successful " + amountAndDate);
            }
            else
            {
                MessageBox.Show("Add items to cart first!");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
             String amountAndDate = FoodCartService.addFoodOrder();
             if (amountAndDate != "")
             {
                 MessageBox.Show("Order Successful " + amountAndDate);
             }
             else
             {
                 MessageBox.Show("Add items to cart first!");
             }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainMenu mainmenu = new MainMenu();
            mainmenu.StartPosition = FormStartPosition.Manual;
            mainmenu.Location = new Point(this.Location.X + (this.Width - mainmenu.Width) / 2, this.Location.Y + (this.Height - mainmenu.Height) / 2);
            mainmenu.Show();
            this.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MainMenu mainmenu = new MainMenu();
            mainmenu.StartPosition = FormStartPosition.Manual;
            mainmenu.Location = new Point(this.Location.X + (this.Width - mainmenu.Width) / 2, this.Location.Y + (this.Height - mainmenu.Height) / 2);
            mainmenu.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MainMenu mainmenu = new MainMenu();
            mainmenu.StartPosition = FormStartPosition.Manual;
            mainmenu.Location = new Point(this.Location.X + (this.Width - mainmenu.Width) / 2, this.Location.Y + (this.Height - mainmenu.Height) / 2);
            mainmenu.Show();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MainMenu mainmenu = new MainMenu();
            mainmenu.StartPosition = FormStartPosition.Manual;
            mainmenu.Location = new Point(this.Location.X + (this.Width - mainmenu.Width) / 2, this.Location.Y + (this.Height - mainmenu.Height) / 2);
            mainmenu.Show();
            this.Close();
        }

    }
}
