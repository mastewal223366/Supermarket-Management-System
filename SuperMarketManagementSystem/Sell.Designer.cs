namespace SuperMarketManagementSystem
{
    partial class Sell
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.iBtnDateSearch = new FontAwesome.Sharp.IconButton();
            this.cmbDate = new System.Windows.Forms.ComboBox();
            this.dtpSoldDate = new System.Windows.Forms.DateTimePicker();
            this.Date = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblrow = new System.Windows.Forms.Label();
            this.txtSellingQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBrandName2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCategoriesName2 = new System.Windows.Forms.ComboBox();
            this.lblCategoriesName = new System.Windows.Forms.Label();
            this.cmbProductName2 = new System.Windows.Forms.ComboBox();
            this.lblProductName2 = new System.Windows.Forms.Label();
            this.iBtnSell = new FontAwesome.Sharp.IconButton();
            this.iBtnBrandSearch = new FontAwesome.Sharp.IconButton();
            this.iBtnCategoriesSearch = new FontAwesome.Sharp.IconButton();
            this.iBtnProductsearch = new FontAwesome.Sharp.IconButton();
            this.cmbBrandSearch = new System.Windows.Forms.ComboBox();
            this.cmbCategoriesSearch = new System.Windows.Forms.ComboBox();
            this.cmbProductSearch = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvProductList = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvTransactionList = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.panel1.Controls.Add(this.lblQty);
            this.panel1.Controls.Add(this.lblId);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.iBtnDateSearch);
            this.panel1.Controls.Add(this.cmbDate);
            this.panel1.Controls.Add(this.dtpSoldDate);
            this.panel1.Controls.Add(this.Date);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblrow);
            this.panel1.Controls.Add(this.txtSellingQuantity);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbBrandName2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbCategoriesName2);
            this.panel1.Controls.Add(this.lblCategoriesName);
            this.panel1.Controls.Add(this.cmbProductName2);
            this.panel1.Controls.Add(this.lblProductName2);
            this.panel1.Controls.Add(this.iBtnSell);
            this.panel1.Controls.Add(this.iBtnBrandSearch);
            this.panel1.Controls.Add(this.iBtnCategoriesSearch);
            this.panel1.Controls.Add(this.iBtnProductsearch);
            this.panel1.Controls.Add(this.cmbBrandSearch);
            this.panel1.Controls.Add(this.cmbCategoriesSearch);
            this.panel1.Controls.Add(this.cmbProductSearch);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 290);
            this.panel1.TabIndex = 0;
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblQty.Location = new System.Drawing.Point(12, 116);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(0, 25);
            this.lblQty.TabIndex = 101;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblId.Location = new System.Drawing.Point(12, 12);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 25);
            this.lblId.TabIndex = 100;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblTotal.Location = new System.Drawing.Point(600, 108);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(59, 25);
            this.lblTotal.TabIndex = 99;
            this.lblTotal.Text = "Total";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblPrice.Location = new System.Drawing.Point(671, 74);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 25);
            this.lblPrice.TabIndex = 98;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.RosyBrown;
            this.label6.Location = new System.Drawing.Point(595, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 25);
            this.label6.TabIndex = 97;
            this.label6.Text = "price:";
            // 
            // iBtnDateSearch
            // 
            this.iBtnDateSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.iBtnDateSearch.FlatAppearance.BorderSize = 0;
            this.iBtnDateSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnDateSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnDateSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iBtnDateSearch.IconChar = FontAwesome.Sharp.IconChar.SearchLocation;
            this.iBtnDateSearch.IconColor = System.Drawing.Color.White;
            this.iBtnDateSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnDateSearch.IconSize = 30;
            this.iBtnDateSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnDateSearch.Location = new System.Drawing.Point(702, 176);
            this.iBtnDateSearch.Name = "iBtnDateSearch";
            this.iBtnDateSearch.Size = new System.Drawing.Size(107, 35);
            this.iBtnDateSearch.TabIndex = 96;
            this.iBtnDateSearch.Text = "Search";
            this.iBtnDateSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnDateSearch.UseVisualStyleBackColor = false;
            this.iBtnDateSearch.Click += new System.EventHandler(this.iBtnDateSearch_Click);
            // 
            // cmbDate
            // 
            this.cmbDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDate.FormattingEnabled = true;
            this.cmbDate.Location = new System.Drawing.Point(663, 143);
            this.cmbDate.Name = "cmbDate";
            this.cmbDate.Size = new System.Drawing.Size(146, 27);
            this.cmbDate.TabIndex = 95;
            this.cmbDate.Text = "Date";
            // 
            // dtpSoldDate
            // 
            this.dtpSoldDate.Location = new System.Drawing.Point(588, 51);
            this.dtpSoldDate.Name = "dtpSoldDate";
            this.dtpSoldDate.Size = new System.Drawing.Size(220, 20);
            this.dtpSoldDate.TabIndex = 94;
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.ForeColor = System.Drawing.Color.RosyBrown;
            this.Date.Location = new System.Drawing.Point(595, 18);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(138, 25);
            this.Date.TabIndex = 93;
            this.Date.Text = "Selling Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RosyBrown;
            this.label5.Location = new System.Drawing.Point(386, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 92;
            this.label5.Text = "Products";
            // 
            // lblrow
            // 
            this.lblrow.AutoSize = true;
            this.lblrow.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrow.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblrow.Location = new System.Drawing.Point(347, 255);
            this.lblrow.Name = "lblrow";
            this.lblrow.Size = new System.Drawing.Size(0, 25);
            this.lblrow.TabIndex = 91;
            // 
            // txtSellingQuantity
            // 
            this.txtSellingQuantity.Location = new System.Drawing.Point(331, 117);
            this.txtSellingQuantity.Name = "txtSellingQuantity";
            this.txtSellingQuantity.Size = new System.Drawing.Size(246, 20);
            this.txtSellingQuantity.TabIndex = 90;
            this.txtSellingQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSellingQuantity_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RosyBrown;
            this.label2.Location = new System.Drawing.Point(220, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 89;
            this.label2.Text = "Quantity:";
            // 
            // cmbBrandName2
            // 
            this.cmbBrandName2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBrandName2.FormattingEnabled = true;
            this.cmbBrandName2.Location = new System.Drawing.Point(331, 83);
            this.cmbBrandName2.Name = "cmbBrandName2";
            this.cmbBrandName2.Size = new System.Drawing.Size(246, 27);
            this.cmbBrandName2.TabIndex = 88;
            this.cmbBrandName2.Text = "Brand";
            this.cmbBrandName2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbBrandName2_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RosyBrown;
            this.label1.Location = new System.Drawing.Point(178, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 87;
            this.label1.Text = "Brand Name:";
            // 
            // cmbCategoriesName2
            // 
            this.cmbCategoriesName2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoriesName2.FormattingEnabled = true;
            this.cmbCategoriesName2.Location = new System.Drawing.Point(331, 49);
            this.cmbCategoriesName2.Name = "cmbCategoriesName2";
            this.cmbCategoriesName2.Size = new System.Drawing.Size(246, 27);
            this.cmbCategoriesName2.TabIndex = 86;
            this.cmbCategoriesName2.Text = "Categories";
            this.cmbCategoriesName2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCategoriesName2_KeyPress);
            // 
            // lblCategoriesName
            // 
            this.lblCategoriesName.AutoSize = true;
            this.lblCategoriesName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriesName.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblCategoriesName.Location = new System.Drawing.Point(128, 50);
            this.lblCategoriesName.Name = "lblCategoriesName";
            this.lblCategoriesName.Size = new System.Drawing.Size(197, 25);
            this.lblCategoriesName.TabIndex = 85;
            this.lblCategoriesName.Text = "Categories Name:";
            // 
            // cmbProductName2
            // 
            this.cmbProductName2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProductName2.FormattingEnabled = true;
            this.cmbProductName2.Location = new System.Drawing.Point(331, 12);
            this.cmbProductName2.Name = "cmbProductName2";
            this.cmbProductName2.Size = new System.Drawing.Size(246, 27);
            this.cmbProductName2.TabIndex = 84;
            this.cmbProductName2.Text = "products";
            this.cmbProductName2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbProductName2_KeyPress);
            // 
            // lblProductName2
            // 
            this.lblProductName2.AutoSize = true;
            this.lblProductName2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName2.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblProductName2.Location = new System.Drawing.Point(160, 18);
            this.lblProductName2.Name = "lblProductName2";
            this.lblProductName2.Size = new System.Drawing.Size(165, 25);
            this.lblProductName2.TabIndex = 81;
            this.lblProductName2.Text = "Product Name:";
            // 
            // iBtnSell
            // 
            this.iBtnSell.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.iBtnSell.FlatAppearance.BorderSize = 0;
            this.iBtnSell.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iBtnSell.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnSell.ForeColor = System.Drawing.Color.White;
            this.iBtnSell.IconChar = FontAwesome.Sharp.IconChar.S;
            this.iBtnSell.IconColor = System.Drawing.Color.White;
            this.iBtnSell.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnSell.IconSize = 30;
            this.iBtnSell.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnSell.Location = new System.Drawing.Point(391, 217);
            this.iBtnSell.Name = "iBtnSell";
            this.iBtnSell.Size = new System.Drawing.Size(87, 35);
            this.iBtnSell.TabIndex = 80;
            this.iBtnSell.Text = "Sell";
            this.iBtnSell.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnSell.UseVisualStyleBackColor = false;
            this.iBtnSell.Click += new System.EventHandler(this.iBtnSell_Click);
            // 
            // iBtnBrandSearch
            // 
            this.iBtnBrandSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.iBtnBrandSearch.FlatAppearance.BorderSize = 0;
            this.iBtnBrandSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnBrandSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnBrandSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iBtnBrandSearch.IconChar = FontAwesome.Sharp.IconChar.SearchLocation;
            this.iBtnBrandSearch.IconColor = System.Drawing.Color.White;
            this.iBtnBrandSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnBrandSearch.IconSize = 30;
            this.iBtnBrandSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnBrandSearch.Location = new System.Drawing.Point(550, 177);
            this.iBtnBrandSearch.Name = "iBtnBrandSearch";
            this.iBtnBrandSearch.Size = new System.Drawing.Size(107, 35);
            this.iBtnBrandSearch.TabIndex = 79;
            this.iBtnBrandSearch.Text = "Search";
            this.iBtnBrandSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnBrandSearch.UseVisualStyleBackColor = false;
            this.iBtnBrandSearch.Click += new System.EventHandler(this.iBtnBrandSearch_Click_1);
            // 
            // iBtnCategoriesSearch
            // 
            this.iBtnCategoriesSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.iBtnCategoriesSearch.FlatAppearance.BorderSize = 0;
            this.iBtnCategoriesSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnCategoriesSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnCategoriesSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iBtnCategoriesSearch.IconChar = FontAwesome.Sharp.IconChar.SearchLocation;
            this.iBtnCategoriesSearch.IconColor = System.Drawing.Color.White;
            this.iBtnCategoriesSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnCategoriesSearch.IconSize = 30;
            this.iBtnCategoriesSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnCategoriesSearch.Location = new System.Drawing.Point(333, 177);
            this.iBtnCategoriesSearch.Name = "iBtnCategoriesSearch";
            this.iBtnCategoriesSearch.Size = new System.Drawing.Size(107, 35);
            this.iBtnCategoriesSearch.TabIndex = 78;
            this.iBtnCategoriesSearch.Text = "Search";
            this.iBtnCategoriesSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnCategoriesSearch.UseVisualStyleBackColor = false;
            this.iBtnCategoriesSearch.Click += new System.EventHandler(this.iBtnCategoriesSearch_Click_1);
            // 
            // iBtnProductsearch
            // 
            this.iBtnProductsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.iBtnProductsearch.FlatAppearance.BorderSize = 0;
            this.iBtnProductsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnProductsearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnProductsearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iBtnProductsearch.IconChar = FontAwesome.Sharp.IconChar.SearchLocation;
            this.iBtnProductsearch.IconColor = System.Drawing.Color.White;
            this.iBtnProductsearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnProductsearch.IconSize = 30;
            this.iBtnProductsearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnProductsearch.Location = new System.Drawing.Point(159, 177);
            this.iBtnProductsearch.Name = "iBtnProductsearch";
            this.iBtnProductsearch.Size = new System.Drawing.Size(107, 35);
            this.iBtnProductsearch.TabIndex = 77;
            this.iBtnProductsearch.Text = "Search";
            this.iBtnProductsearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnProductsearch.UseVisualStyleBackColor = false;
            this.iBtnProductsearch.Click += new System.EventHandler(this.iBtnProductsearch_Click_1);
            // 
            // cmbBrandSearch
            // 
            this.cmbBrandSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBrandSearch.FormattingEnabled = true;
            this.cmbBrandSearch.Location = new System.Drawing.Point(459, 144);
            this.cmbBrandSearch.Name = "cmbBrandSearch";
            this.cmbBrandSearch.Size = new System.Drawing.Size(198, 27);
            this.cmbBrandSearch.TabIndex = 76;
            this.cmbBrandSearch.Text = "By Brand";
            // 
            // cmbCategoriesSearch
            // 
            this.cmbCategoriesSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoriesSearch.FormattingEnabled = true;
            this.cmbCategoriesSearch.Location = new System.Drawing.Point(281, 144);
            this.cmbCategoriesSearch.Name = "cmbCategoriesSearch";
            this.cmbCategoriesSearch.Size = new System.Drawing.Size(159, 27);
            this.cmbCategoriesSearch.TabIndex = 75;
            this.cmbCategoriesSearch.Text = "By Categories";
            // 
            // cmbProductSearch
            // 
            this.cmbProductSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProductSearch.FormattingEnabled = true;
            this.cmbProductSearch.Location = new System.Drawing.Point(98, 144);
            this.cmbProductSearch.Name = "cmbProductSearch";
            this.cmbProductSearch.Size = new System.Drawing.Size(168, 27);
            this.cmbProductSearch.TabIndex = 74;
            this.cmbProductSearch.Text = "by products name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RosyBrown;
            this.label4.Location = new System.Drawing.Point(7, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 73;
            this.label4.Text = "Search:";
            // 
            // dgvProductList
            // 
            this.dgvProductList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductList.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvProductList.Location = new System.Drawing.Point(0, 290);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.Size = new System.Drawing.Size(820, 124);
            this.dgvProductList.TabIndex = 1;
            this.dgvProductList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductList_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 414);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(820, 32);
            this.panel2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RosyBrown;
            this.label3.Location = new System.Drawing.Point(312, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 25);
            this.label3.TabIndex = 86;
            this.label3.Text = "Transaction Table";
            // 
            // dgvTransactionList
            // 
            this.dgvTransactionList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.dgvTransactionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactionList.Location = new System.Drawing.Point(0, 446);
            this.dgvTransactionList.Name = "dgvTransactionList";
            this.dgvTransactionList.Size = new System.Drawing.Size(820, 147);
            this.dgvTransactionList.TabIndex = 3;
            // 
            // Sell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(820, 594);
            this.ControlBox = false;
            this.Controls.Add(this.dgvTransactionList);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvProductList);
            this.Controls.Add(this.panel1);
            this.Name = "Sell";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iBtnBrandSearch;
        private FontAwesome.Sharp.IconButton iBtnCategoriesSearch;
        private FontAwesome.Sharp.IconButton iBtnProductsearch;
        private System.Windows.Forms.ComboBox cmbBrandSearch;
        private System.Windows.Forms.ComboBox cmbCategoriesSearch;
        private System.Windows.Forms.ComboBox cmbProductSearch;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton iBtnSell;
        private System.Windows.Forms.TextBox txtSellingQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBrandName2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCategoriesName2;
        private System.Windows.Forms.Label lblCategoriesName;
        private System.Windows.Forms.ComboBox cmbProductName2;
        private System.Windows.Forms.Label lblProductName2;
        private System.Windows.Forms.DataGridView dgvProductList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblrow;
        private System.Windows.Forms.DateTimePicker dtpSoldDate;
        private System.Windows.Forms.Label Date;
        private FontAwesome.Sharp.IconButton iBtnDateSearch;
        private System.Windows.Forms.ComboBox cmbDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvTransactionList;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblQty;
    }
}