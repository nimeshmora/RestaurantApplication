using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DineInApplication.service;

namespace DineInApplication.ui
{
    public partial class Feedback : Form
    {
        private int selectedOrderID = 0;
        public Feedback()
        {
            InitializeComponent();

            FeedbackService feedService = new FeedbackService();
            DataTable dataOrders = feedService.serveCustomerOrdersToGiveFeedBack();
            BindingSource bSourceOrders = new BindingSource();
            bSourceOrders.DataSource = dataOrders;
            orderDataGrid.DataSource = bSourceOrders;
        }

        private void pres1_MouseClick(object sender, MouseEventArgs e)
        {
            pres1.BackColor = Color.Gold;
            pres2.BackColor = Color.FloralWhite;
            pres3.BackColor = Color.FloralWhite;
            pres4.BackColor = Color.FloralWhite;
            pres5.BackColor = Color.FloralWhite;

            presTxt.Text = "1";

        }

        private void pres2_Click(object sender, EventArgs e)
        {
            pres1.BackColor = Color.Gold;
            pres2.BackColor = Color.Gold;
            pres3.BackColor = Color.FloralWhite;
            pres4.BackColor = Color.FloralWhite;
            pres5.BackColor = Color.FloralWhite;
            presTxt.Text = "2";
        }

        private void pres3_MouseClick(object sender, MouseEventArgs e)
        {
            pres1.BackColor = Color.Gold;
            pres2.BackColor = Color.Gold;
            pres3.BackColor = Color.Gold;
            pres4.BackColor = Color.FloralWhite;
            pres5.BackColor = Color.FloralWhite;
            presTxt.Text = "3";
        }

        private void pres4_MouseClick(object sender, MouseEventArgs e)
        {
            pres1.BackColor = Color.Gold;
            pres2.BackColor = Color.Gold;
            pres3.BackColor = Color.Gold;
            pres4.BackColor = Color.Gold;
            pres5.BackColor = Color.FloralWhite;
            presTxt.Text = "4";

        }

        private void pres5_MouseClick(object sender, MouseEventArgs e)
        {
            pres1.BackColor = Color.Gold;
            pres2.BackColor = Color.Gold;
            pres3.BackColor = Color.Gold;
            pres4.BackColor = Color.Gold;
            pres5.BackColor = Color.Gold;
            presTxt.Text = "5";
        }

        private void pres1_Click(object sender, EventArgs e)
        {

        }

        private void time1_Click(object sender, EventArgs e)
        {
            time1.BackColor = Color.Gold;
            time2.BackColor = Color.FloralWhite;
            time3.BackColor = Color.FloralWhite;
            time4.BackColor = Color.FloralWhite;
            time5.BackColor = Color.FloralWhite;
            timeTxt.Text = "1";
        }

        private void time2_Click(object sender, EventArgs e)
        {
            time1.BackColor = Color.Gold;
            time2.BackColor = Color.Gold;
            time3.BackColor = Color.FloralWhite;
            time4.BackColor = Color.FloralWhite;
            time5.BackColor = Color.FloralWhite;
            timeTxt.Text = "2";
        }

        private void time3_Click(object sender, EventArgs e)
        {
            time1.BackColor = Color.Gold;
            time2.BackColor = Color.Gold;
            time3.BackColor = Color.Gold;
            time4.BackColor = Color.FloralWhite;
            time5.BackColor = Color.FloralWhite;
            timeTxt.Text = "3";
        }

        private void time4_Click(object sender, EventArgs e)
        {
            time1.BackColor = Color.Gold;
            time2.BackColor = Color.Gold;
            time3.BackColor = Color.Gold;
            time4.BackColor = Color.Gold;
            time5.BackColor = Color.FloralWhite;
            timeTxt.Text = "4";
        }

        private void time5_Click(object sender, EventArgs e)
        {
            time1.BackColor = Color.Gold;
            time2.BackColor = Color.Gold;
            time3.BackColor = Color.Gold;
            time4.BackColor = Color.Gold;
            time5.BackColor = Color.Gold;
            timeTxt.Text = "5";
        }

        private void taste1_Click(object sender, EventArgs e)
        {
            taste1.BackColor = Color.Gold;
            taste2.BackColor = Color.FloralWhite;
            taste3.BackColor = Color.FloralWhite;
            taste4.BackColor = Color.FloralWhite;
            taste5.BackColor = Color.FloralWhite;
            tasteTxt.Text = "1";
        }

        private void taste2_Click(object sender, EventArgs e)
        {
            taste1.BackColor = Color.Gold;
            taste2.BackColor = Color.Gold;
            taste3.BackColor = Color.FloralWhite;
            taste4.BackColor = Color.FloralWhite;
            taste5.BackColor = Color.FloralWhite;
            tasteTxt.Text = "2";
        }

        private void taste3_Click(object sender, EventArgs e)
        {
            taste1.BackColor = Color.Gold;
            taste2.BackColor = Color.Gold;
            taste3.BackColor = Color.Gold;
            taste4.BackColor = Color.FloralWhite;
            taste5.BackColor = Color.FloralWhite;
            tasteTxt.Text = "3";
        }

        private void taste4_Click(object sender, EventArgs e)
        {
            taste1.BackColor = Color.Gold;
            taste2.BackColor = Color.Gold;
            taste3.BackColor = Color.Gold;
            taste4.BackColor = Color.Gold;
            taste5.BackColor = Color.FloralWhite;
            tasteTxt.Text = "4";
        }

        private void taste5_Click(object sender, EventArgs e)
        {
            taste1.BackColor = Color.Gold;
            taste2.BackColor = Color.Gold;
            taste3.BackColor = Color.Gold;
            taste4.BackColor = Color.Gold;
            taste5.BackColor = Color.Gold;
            tasteTxt.Text = "5";
        }

        private void price1_Click(object sender, EventArgs e)
        {
            price1.BackColor = Color.Gold;
            price2.BackColor = Color.FloralWhite;
            price3.BackColor = Color.FloralWhite;
            price4.BackColor = Color.FloralWhite;
            price5.BackColor = Color.FloralWhite;
            priceTxt.Text = "1";
        }

        private void price2_Click(object sender, EventArgs e)
        {

            price1.BackColor = Color.Gold;
            price2.BackColor = Color.Gold;
            price3.BackColor = Color.FloralWhite;
            price4.BackColor = Color.FloralWhite;
            price5.BackColor = Color.FloralWhite;
            priceTxt.Text = "2";
        }

        private void price3_Click(object sender, EventArgs e)
        {

            price1.BackColor = Color.Gold;
            price2.BackColor = Color.Gold;
            price3.BackColor = Color.Gold;
            price4.BackColor = Color.FloralWhite;
            price5.BackColor = Color.FloralWhite;
            priceTxt.Text = "3";
        }

        private void price4_Click(object sender, EventArgs e)
        {

            price1.BackColor = Color.Gold;
            price2.BackColor = Color.Gold;
            price3.BackColor = Color.Gold;
            price4.BackColor = Color.Gold;
            price5.BackColor = Color.FloralWhite;
            priceTxt.Text = "4";
        }

        private void price5_Click(object sender, EventArgs e)
        {

            price1.BackColor = Color.Gold;
            price2.BackColor = Color.Gold;
            price3.BackColor = Color.Gold;
            price4.BackColor = Color.Gold;
            price5.BackColor = Color.Gold;
            priceTxt.Text = "5";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void orderDataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (orderDataGrid.SelectedRows.Count != 0)
            {

                DataGridViewRow row = this.orderDataGrid.SelectedRows[0];
                String s = Convert.ToString(row.Cells["order_id"].Value);
                selectedOrderID = Convert.ToInt32(s);

                orderNameLbl.Text = "Order: "+s;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(selectedOrderID != 0){

                int presentationRating = Convert.ToInt32(presTxt.Text);
                int tasteRating = Convert.ToInt32(tasteTxt.Text);
                int timeRating = Convert.ToInt32(timeTxt.Text);
                int priceRating = Convert.ToInt32(priceTxt.Text);
                String comment = commentBox.Text.ToString();

                FeedbackService feedService = new FeedbackService();
                Boolean isFeedBackSaved = feedService.saveFeedBack(presentationRating, priceRating, tasteRating, timeRating, comment, selectedOrderID);
                if(isFeedBackSaved){
                    MessageBox.Show("FeedBack saved successfully!");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainMenu mainmenu = new MainMenu();
            mainmenu.StartPosition = FormStartPosition.Manual;
            mainmenu.Location = new Point(this.Location.X + (this.Width - mainmenu.Width) / 2, this.Location.Y + (this.Height - mainmenu.Height) / 2);
            mainmenu.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int presentationRating = Convert.ToInt32(presTxt.Text);
            int tasteRating = Convert.ToInt32(tasteTxt.Text);
            int timeRating = Convert.ToInt32(timeTxt.Text);
            int priceRating = Convert.ToInt32(priceTxt.Text);

            int overallRating = (presentationRating + tasteRating + timeRating + priceRating)/4;
            

            if(overallRating == 1){
                all1.BackColor = Color.Gold;
            }
            else if (overallRating == 2) {
                all1.BackColor = Color.Gold;
                all2.BackColor = Color.Gold;
            }else if(overallRating == 3){
                all1.BackColor = Color.Gold;
                all2.BackColor = Color.Gold;
                all3.BackColor = Color.Gold;
            }else if(overallRating == 4){

                all1.BackColor = Color.Gold;
                all2.BackColor = Color.Gold;
                all3.BackColor = Color.Gold;
                all4.BackColor = Color.Gold;
            }
            else if (overallRating == 5)
            {
                all1.BackColor = Color.Gold;
                all2.BackColor = Color.Gold;
                all3.BackColor = Color.Gold;
                all4.BackColor = Color.Gold;
                all5.BackColor = Color.Gold;
            }
            else {
                all1.BackColor = Color.FloralWhite;
                all2.BackColor = Color.FloralWhite;
                all3.BackColor = Color.FloralWhite;
                all4.BackColor = Color.FloralWhite;
                all5.BackColor = Color.FloralWhite;
            }
        }



    }
}
