﻿using System;
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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ui.Order newOrder = new ui.Order();
            newOrder.StartPosition = FormStartPosition.Manual;
            newOrder.Location = new Point(this.Location.X + (this.Width - newOrder.Width) / 2, this.Location.Y + (this.Height - newOrder.Height) / 2);
            newOrder.Show();
            this.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            login.StartPosition = FormStartPosition.Manual;
            login.Location = new Point(this.Location.X + (this.Width - login.Width) / 2, this.Location.Y + (this.Height - login.Height) / 2);
            login.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ui.Feedback newFeedBack = new ui.Feedback();
            newFeedBack.StartPosition = FormStartPosition.Manual;
            newFeedBack.Location = new Point(this.Location.X + (this.Width - newFeedBack.Width) / 2, this.Location.Y + (this.Height - newFeedBack.Height) / 2);
            newFeedBack.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ui.SalesAnalytics newSalesAnalytics = new ui.SalesAnalytics();
            newSalesAnalytics.StartPosition = FormStartPosition.Manual;
            newSalesAnalytics.Location = new Point(this.Location.X + (this.Width - newSalesAnalytics.Width) / 2, this.Location.Y + (this.Height - newSalesAnalytics.Height) / 2);
            newSalesAnalytics.Show();
            this.Close();
        }
    }
}
