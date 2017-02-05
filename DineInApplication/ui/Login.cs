using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DineInApplication.service;

namespace DineInApplication
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            LoginService login = new LoginService();
            if (username.Text == "" || password.Text == "")
            {
                MessageBox.Show("Provide username and password!");
            }
            else
            {
                int user_id = login.authenticateUser(username.Text, password.Text);
                if (user_id != 0)
                {

                    ui.MainMenu mainmenu = new ui.MainMenu();
                    mainmenu.StartPosition = FormStartPosition.Manual;
                    mainmenu.Location = new Point(this.Location.X + (this.Width - mainmenu.Width) / 2, this.Location.Y + (this.Height - mainmenu.Height) / 2);
                    mainmenu.Show(this);
                    this.Hide();

                }
                else {

                    MessageBox.Show("Login Failed!");
                }
            
            }
   
           
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
