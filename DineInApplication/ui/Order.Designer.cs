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
            this.orderBtn = new System.Windows.Forms.Button();
            this.Soups = new System.Windows.Forms.TabPage();
            this.soupDataGrid = new System.Windows.Forms.DataGridView();
            this.Mains = new System.Windows.Forms.TabPage();
            this.mainsDataGrid = new System.Windows.Forms.DataGridView();
            this.Desserts = new System.Windows.Forms.TabPage();
            this.dessertDataGrid = new System.Windows.Forms.DataGridView();
            this.Beverages = new System.Windows.Forms.TabPage();
            this.beverageDataGrid = new System.Windows.Forms.DataGridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.snackImageBox = new System.Windows.Forms.PictureBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.SnacksTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.snackDataGrid)).BeginInit();
            this.Soups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soupDataGrid)).BeginInit();
            this.Mains.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainsDataGrid)).BeginInit();
            this.Desserts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dessertDataGrid)).BeginInit();
            this.Beverages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beverageDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snackImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // orderBtn
            // 
            this.orderBtn.Location = new System.Drawing.Point(562, 398);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(75, 33);
            this.orderBtn.TabIndex = 3;
            this.orderBtn.Text = "Check Out";
            this.orderBtn.UseVisualStyleBackColor = true;
            // 
            // Soups
            // 
            this.Soups.Controls.Add(this.pictureBox1);
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
            // soupDataGrid
            // 
            this.soupDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.soupDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.soupDataGrid.Location = new System.Drawing.Point(8, 9);
            this.soupDataGrid.Name = "soupDataGrid";
            this.soupDataGrid.Size = new System.Drawing.Size(430, 357);
            this.soupDataGrid.TabIndex = 0;
            // 
            // Mains
            // 
            this.Mains.Controls.Add(this.mainsDataGrid);
            this.Mains.ImageIndex = 2;
            this.Mains.Location = new System.Drawing.Point(4, 23);
            this.Mains.Name = "Mains";
            this.Mains.Size = new System.Drawing.Size(660, 448);
            this.Mains.TabIndex = 2;
            this.Mains.Text = "Mains";
            this.Mains.UseVisualStyleBackColor = true;
            // 
            // mainsDataGrid
            // 
            this.mainsDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mainsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainsDataGrid.Location = new System.Drawing.Point(8, 9);
            this.mainsDataGrid.Name = "mainsDataGrid";
            this.mainsDataGrid.Size = new System.Drawing.Size(430, 357);
            this.mainsDataGrid.TabIndex = 0;
            // 
            // Desserts
            // 
            this.Desserts.Controls.Add(this.dessertDataGrid);
            this.Desserts.ImageIndex = 3;
            this.Desserts.Location = new System.Drawing.Point(4, 23);
            this.Desserts.Name = "Desserts";
            this.Desserts.Size = new System.Drawing.Size(660, 448);
            this.Desserts.TabIndex = 3;
            this.Desserts.Text = "Desserts";
            this.Desserts.UseVisualStyleBackColor = true;
            // 
            // dessertDataGrid
            // 
            this.dessertDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dessertDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dessertDataGrid.Location = new System.Drawing.Point(10, 8);
            this.dessertDataGrid.Name = "dessertDataGrid";
            this.dessertDataGrid.Size = new System.Drawing.Size(430, 357);
            this.dessertDataGrid.TabIndex = 0;
            // 
            // Beverages
            // 
            this.Beverages.Controls.Add(this.beverageDataGrid);
            this.Beverages.ImageIndex = 4;
            this.Beverages.Location = new System.Drawing.Point(4, 23);
            this.Beverages.Name = "Beverages";
            this.Beverages.Size = new System.Drawing.Size(660, 448);
            this.Beverages.TabIndex = 4;
            this.Beverages.Text = "Beverages";
            this.Beverages.UseVisualStyleBackColor = true;
            // 
            // beverageDataGrid
            // 
            this.beverageDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.beverageDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.beverageDataGrid.Location = new System.Drawing.Point(8, 13);
            this.beverageDataGrid.Name = "beverageDataGrid";
            this.beverageDataGrid.Size = new System.Drawing.Size(430, 357);
            this.beverageDataGrid.TabIndex = 0;
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
            // snackImageBox
            // 
            this.snackImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.snackImageBox.Location = new System.Drawing.Point(462, 61);
            this.snackImageBox.Name = "snackImageBox";
            this.snackImageBox.Size = new System.Drawing.Size(182, 172);
            this.snackImageBox.TabIndex = 4;
            this.snackImageBox.TabStop = false;
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
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(462, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 172);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
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
            this.Soups.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.soupDataGrid)).EndInit();
            this.Mains.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainsDataGrid)).EndInit();
            this.Desserts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dessertDataGrid)).EndInit();
            this.Beverages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.beverageDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snackImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}