namespace DineInApplication.ui
{
    partial class Order
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.SnacksTab = new System.Windows.Forms.TabPage();
            this.snackDataGrid = new System.Windows.Forms.DataGridView();
            this.snackImageBox = new System.Windows.Forms.PictureBox();
            this.orderBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Soups = new System.Windows.Forms.TabPage();
            this.button10 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.soupImageBox = new System.Windows.Forms.PictureBox();
            this.soupDataGrid = new System.Windows.Forms.DataGridView();
            this.Mains = new System.Windows.Forms.TabPage();
            this.button11 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.mainsImageBox = new System.Windows.Forms.PictureBox();
            this.mainsDataGrid = new System.Windows.Forms.DataGridView();
            this.Desserts = new System.Windows.Forms.TabPage();
            this.button12 = new System.Windows.Forms.Button();
            this.dessertImageBox = new System.Windows.Forms.PictureBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dessertDataGrid = new System.Windows.Forms.DataGridView();
            this.Beverages = new System.Windows.Forms.TabPage();
            this.button13 = new System.Windows.Forms.Button();
            this.beverageImageBox = new System.Windows.Forms.PictureBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.beverageDataGrid = new System.Windows.Forms.DataGridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1.SuspendLayout();
            this.SnacksTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.snackDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snackImageBox)).BeginInit();
            this.Soups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soupImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soupDataGrid)).BeginInit();
            this.Mains.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainsImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainsDataGrid)).BeginInit();
            this.Desserts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dessertImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dessertDataGrid)).BeginInit();
            this.Beverages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beverageImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beverageDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.SnacksTab);
            this.tabControl1.Controls.Add(this.Soups);
            this.tabControl1.Controls.Add(this.Mains);
            this.tabControl1.Controls.Add(this.Desserts);
            this.tabControl1.Controls.Add(this.Beverages);
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(668, 475);
            this.tabControl1.TabIndex = 0;
            // 
            // SnacksTab
            // 
            this.SnacksTab.Controls.Add(this.snackDataGrid);
            this.SnacksTab.Controls.Add(this.snackImageBox);
            this.SnacksTab.Controls.Add(this.orderBtn);
            this.SnacksTab.Controls.Add(this.addBtn);
            this.SnacksTab.Controls.Add(this.button1);
            this.SnacksTab.ImageIndex = 0;
            this.SnacksTab.Location = new System.Drawing.Point(4, 23);
            this.SnacksTab.Name = "SnacksTab";
            this.SnacksTab.Padding = new System.Windows.Forms.Padding(3);
            this.SnacksTab.Size = new System.Drawing.Size(660, 448);
            this.SnacksTab.TabIndex = 0;
            this.SnacksTab.Text = "Snacks";
            this.SnacksTab.UseVisualStyleBackColor = true;
            // 
            // snackDataGrid
            // 
            this.snackDataGrid.AllowUserToAddRows = false;
            this.snackDataGrid.AllowUserToDeleteRows = false;
            this.snackDataGrid.AllowUserToResizeColumns = false;
            this.snackDataGrid.AllowUserToResizeRows = false;
            this.snackDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.snackDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.snackDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.snackDataGrid.Location = new System.Drawing.Point(7, 7);
            this.snackDataGrid.Name = "snackDataGrid";
            this.snackDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.snackDataGrid.Size = new System.Drawing.Size(430, 357);
            this.snackDataGrid.TabIndex = 5;
            this.snackDataGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.snackDataGrid_CellMouseClick);
            // 
            // snackImageBox
            // 
            this.snackImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.snackImageBox.Location = new System.Drawing.Point(462, 61);
            this.snackImageBox.Name = "snackImageBox";
            this.snackImageBox.Size = new System.Drawing.Size(182, 172);
            this.snackImageBox.TabIndex = 4;
            this.snackImageBox.TabStop = false;
            // 
            // orderBtn
            // 
            this.orderBtn.Location = new System.Drawing.Point(562, 398);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(75, 33);
            this.orderBtn.TabIndex = 3;
            this.orderBtn.Text = "Check Out";
            this.orderBtn.UseVisualStyleBackColor = true;
            this.orderBtn.Click += new System.EventHandler(this.orderBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackgroundImage = global::DineInApplication.Properties.Resources.cart1;
            this.addBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Location = new System.Drawing.Point(614, 4);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(43, 34);
            this.addBtn.TabIndex = 2;
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::DineInApplication.Properties.Resources.arrow_left;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(8, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 47);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Soups
            // 
            this.Soups.Controls.Add(this.button10);
            this.Soups.Controls.Add(this.button3);
            this.Soups.Controls.Add(this.button2);
            this.Soups.Controls.Add(this.soupImageBox);
            this.Soups.Controls.Add(this.soupDataGrid);
            this.Soups.ImageIndex = 1;
            this.Soups.Location = new System.Drawing.Point(4, 23);
            this.Soups.Name = "Soups";
            this.Soups.Padding = new System.Windows.Forms.Padding(3);
            this.Soups.Size = new System.Drawing.Size(660, 448);
            this.Soups.TabIndex = 1;
            this.Soups.Text = "Soups";
            this.Soups.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(562, 398);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 33);
            this.button10.TabIndex = 4;
            this.button10.Text = "Check Out";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::DineInApplication.Properties.Resources.arrow_left;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(10, 389);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 49);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::DineInApplication.Properties.Resources.cart1;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(615, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 35);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // soupImageBox
            // 
            this.soupImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.soupImageBox.Location = new System.Drawing.Point(462, 64);
            this.soupImageBox.Name = "soupImageBox";
            this.soupImageBox.Size = new System.Drawing.Size(182, 172);
            this.soupImageBox.TabIndex = 1;
            this.soupImageBox.TabStop = false;
            // 
            // soupDataGrid
            // 
            this.soupDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.soupDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.soupDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.soupDataGrid.Location = new System.Drawing.Point(8, 9);
            this.soupDataGrid.Name = "soupDataGrid";
            this.soupDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.soupDataGrid.Size = new System.Drawing.Size(430, 357);
            this.soupDataGrid.TabIndex = 0;
            this.soupDataGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.soupDataGrid_CellMouseClick);
            // 
            // Mains
            // 
            this.Mains.Controls.Add(this.button11);
            this.Mains.Controls.Add(this.button5);
            this.Mains.Controls.Add(this.button4);
            this.Mains.Controls.Add(this.mainsImageBox);
            this.Mains.Controls.Add(this.mainsDataGrid);
            this.Mains.ImageIndex = 2;
            this.Mains.Location = new System.Drawing.Point(4, 23);
            this.Mains.Name = "Mains";
            this.Mains.Size = new System.Drawing.Size(660, 448);
            this.Mains.TabIndex = 2;
            this.Mains.Text = "Mains";
            this.Mains.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(562, 398);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 33);
            this.button11.TabIndex = 4;
            this.button11.Text = "Check Out";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::DineInApplication.Properties.Resources.arrow_left;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(10, 387);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(63, 51);
            this.button5.TabIndex = 3;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::DineInApplication.Properties.Resources.cart1;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(613, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(43, 40);
            this.button4.TabIndex = 2;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // mainsImageBox
            // 
            this.mainsImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainsImageBox.Location = new System.Drawing.Point(461, 63);
            this.mainsImageBox.Name = "mainsImageBox";
            this.mainsImageBox.Size = new System.Drawing.Size(182, 172);
            this.mainsImageBox.TabIndex = 1;
            this.mainsImageBox.TabStop = false;
            // 
            // mainsDataGrid
            // 
            this.mainsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mainsDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mainsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainsDataGrid.Location = new System.Drawing.Point(8, 9);
            this.mainsDataGrid.Name = "mainsDataGrid";
            this.mainsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainsDataGrid.Size = new System.Drawing.Size(430, 357);
            this.mainsDataGrid.TabIndex = 0;
            this.mainsDataGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.mainsDataGrid_CellMouseClick);
            // 
            // Desserts
            // 
            this.Desserts.Controls.Add(this.button12);
            this.Desserts.Controls.Add(this.dessertImageBox);
            this.Desserts.Controls.Add(this.button7);
            this.Desserts.Controls.Add(this.button6);
            this.Desserts.Controls.Add(this.dessertDataGrid);
            this.Desserts.ImageIndex = 3;
            this.Desserts.Location = new System.Drawing.Point(4, 23);
            this.Desserts.Name = "Desserts";
            this.Desserts.Size = new System.Drawing.Size(660, 448);
            this.Desserts.TabIndex = 3;
            this.Desserts.Text = "Desserts";
            this.Desserts.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(562, 398);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 33);
            this.button12.TabIndex = 4;
            this.button12.Text = "Check Out";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // dessertImageBox
            // 
            this.dessertImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dessertImageBox.Location = new System.Drawing.Point(468, 59);
            this.dessertImageBox.Name = "dessertImageBox";
            this.dessertImageBox.Size = new System.Drawing.Size(182, 172);
            this.dessertImageBox.TabIndex = 3;
            this.dessertImageBox.TabStop = false;
            // 
            // button7
            // 
            this.button7.BackgroundImage = global::DineInApplication.Properties.Resources.arrow_left;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(10, 388);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(63, 50);
            this.button7.TabIndex = 2;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::DineInApplication.Properties.Resources.cart1;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(617, 1);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(40, 37);
            this.button6.TabIndex = 1;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dessertDataGrid
            // 
            this.dessertDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dessertDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dessertDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dessertDataGrid.Location = new System.Drawing.Point(10, 8);
            this.dessertDataGrid.Name = "dessertDataGrid";
            this.dessertDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dessertDataGrid.Size = new System.Drawing.Size(430, 357);
            this.dessertDataGrid.TabIndex = 0;
            this.dessertDataGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dessertDataGrid_CellMouseClick);
            // 
            // Beverages
            // 
            this.Beverages.Controls.Add(this.button13);
            this.Beverages.Controls.Add(this.beverageImageBox);
            this.Beverages.Controls.Add(this.button9);
            this.Beverages.Controls.Add(this.button8);
            this.Beverages.Controls.Add(this.beverageDataGrid);
            this.Beverages.ImageIndex = 4;
            this.Beverages.Location = new System.Drawing.Point(4, 23);
            this.Beverages.Name = "Beverages";
            this.Beverages.Size = new System.Drawing.Size(660, 448);
            this.Beverages.TabIndex = 4;
            this.Beverages.Text = "Beverages";
            this.Beverages.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(562, 398);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 33);
            this.button13.TabIndex = 4;
            this.button13.Text = "Check Out";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // beverageImageBox
            // 
            this.beverageImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.beverageImageBox.Location = new System.Drawing.Point(461, 64);
            this.beverageImageBox.Name = "beverageImageBox";
            this.beverageImageBox.Size = new System.Drawing.Size(182, 172);
            this.beverageImageBox.TabIndex = 3;
            this.beverageImageBox.TabStop = false;
            // 
            // button9
            // 
            this.button9.BackgroundImage = global::DineInApplication.Properties.Resources.arrow_left;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(8, 389);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(64, 49);
            this.button9.TabIndex = 2;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.BackgroundImage = global::DineInApplication.Properties.Resources.cart1;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(620, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(37, 30);
            this.button8.TabIndex = 1;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // beverageDataGrid
            // 
            this.beverageDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.beverageDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.beverageDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.beverageDataGrid.Location = new System.Drawing.Point(8, 13);
            this.beverageDataGrid.Name = "beverageDataGrid";
            this.beverageDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.beverageDataGrid.Size = new System.Drawing.Size(430, 357);
            this.beverageDataGrid.TabIndex = 0;
            this.beverageDataGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.beverageDataGrid_CellMouseClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "favicon.png");
            this.imageList1.Images.SetKeyName(1, "favicon.gif");
            this.imageList1.Images.SetKeyName(2, "eatenwith_b.png");
            this.imageList1.Images.SetKeyName(3, "1f369.png");
            this.imageList1.Images.SetKeyName(4, "images.png");
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 474);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            this.tabControl1.ResumeLayout(false);
            this.SnacksTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.snackDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snackImageBox)).EndInit();
            this.Soups.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.soupImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soupDataGrid)).EndInit();
            this.Mains.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainsImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainsDataGrid)).EndInit();
            this.Desserts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dessertImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dessertDataGrid)).EndInit();
            this.Beverages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.beverageImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beverageDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage SnacksTab;
        private System.Windows.Forms.TabPage Soups;
        private System.Windows.Forms.TabPage Mains;
        private System.Windows.Forms.TabPage Desserts;
        private System.Windows.Forms.TabPage Beverages;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DataGridView soupDataGrid;
        private System.Windows.Forms.DataGridView mainsDataGrid;
        private System.Windows.Forms.DataGridView beverageDataGrid;
        private System.Windows.Forms.DataGridView dessertDataGrid;
        private System.Windows.Forms.PictureBox snackImageBox;
        private System.Windows.Forms.DataGridView snackDataGrid;
        private System.Windows.Forms.PictureBox soupImageBox;
        private System.Windows.Forms.PictureBox mainsImageBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox beverageImageBox;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.PictureBox dessertImageBox;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
    }
}