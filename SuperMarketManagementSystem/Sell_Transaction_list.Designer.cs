namespace SuperMarketManagementSystem
{
    partial class Sell_Transaction_list
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
            this.iBtnProductsearch = new FontAwesome.Sharp.IconButton();
            this.cmbProductSearch = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvTransactionTable = new System.Windows.Forms.DataGridView();
            this.iBtnDateSearch = new FontAwesome.Sharp.IconButton();
            this.cmbDateSearch = new System.Windows.Forms.ComboBox();
            this.cmbCashierSearch = new System.Windows.Forms.ComboBox();
            this.iBtnCashierSearch = new FontAwesome.Sharp.IconButton();
            this.lblTId = new System.Windows.Forms.Label();
            this.lblrow = new System.Windows.Forms.Label();
            this.iBtnDeleteCategories = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionTable)).BeginInit();
            this.SuspendLayout();
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
            this.iBtnProductsearch.Location = new System.Drawing.Point(176, 42);
            this.iBtnProductsearch.Name = "iBtnProductsearch";
            this.iBtnProductsearch.Size = new System.Drawing.Size(102, 35);
            this.iBtnProductsearch.TabIndex = 77;
            this.iBtnProductsearch.Text = "Search";
            this.iBtnProductsearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnProductsearch.UseVisualStyleBackColor = false;
            this.iBtnProductsearch.Click += new System.EventHandler(this.iBtnProductsearch_Click);
            // 
            // cmbProductSearch
            // 
            this.cmbProductSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProductSearch.FormattingEnabled = true;
            this.cmbProductSearch.Location = new System.Drawing.Point(150, 11);
            this.cmbProductSearch.Name = "cmbProductSearch";
            this.cmbProductSearch.Size = new System.Drawing.Size(128, 27);
            this.cmbProductSearch.TabIndex = 74;
            this.cmbProductSearch.Text = "by products name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RosyBrown;
            this.label4.Location = new System.Drawing.Point(27, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 25);
            this.label4.TabIndex = 73;
            this.label4.Text = "Search by:";
            // 
            // dgvTransactionTable
            // 
            this.dgvTransactionTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.dgvTransactionTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactionTable.Location = new System.Drawing.Point(-7, 292);
            this.dgvTransactionTable.Name = "dgvTransactionTable";
            this.dgvTransactionTable.Size = new System.Drawing.Size(830, 276);
            this.dgvTransactionTable.TabIndex = 80;
            this.dgvTransactionTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransactionTable_CellContentClick);
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
            this.iBtnDateSearch.Location = new System.Drawing.Point(498, 42);
            this.iBtnDateSearch.Name = "iBtnDateSearch";
            this.iBtnDateSearch.Size = new System.Drawing.Size(107, 35);
            this.iBtnDateSearch.TabIndex = 90;
            this.iBtnDateSearch.Text = "Search";
            this.iBtnDateSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnDateSearch.UseVisualStyleBackColor = false;
            this.iBtnDateSearch.Click += new System.EventHandler(this.iBtnDateSearch_Click);
            // 
            // cmbDateSearch
            // 
            this.cmbDateSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDateSearch.FormattingEnabled = true;
            this.cmbDateSearch.Location = new System.Drawing.Point(456, 9);
            this.cmbDateSearch.Name = "cmbDateSearch";
            this.cmbDateSearch.Size = new System.Drawing.Size(159, 27);
            this.cmbDateSearch.TabIndex = 89;
            this.cmbDateSearch.Text = "Date";
            // 
            // cmbCashierSearch
            // 
            this.cmbCashierSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCashierSearch.FormattingEnabled = true;
            this.cmbCashierSearch.Location = new System.Drawing.Point(312, 9);
            this.cmbCashierSearch.Name = "cmbCashierSearch";
            this.cmbCashierSearch.Size = new System.Drawing.Size(122, 27);
            this.cmbCashierSearch.TabIndex = 76;
            this.cmbCashierSearch.Text = "By Cashier";
            // 
            // iBtnCashierSearch
            // 
            this.iBtnCashierSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.iBtnCashierSearch.FlatAppearance.BorderSize = 0;
            this.iBtnCashierSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnCashierSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnCashierSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iBtnCashierSearch.IconChar = FontAwesome.Sharp.IconChar.SearchLocation;
            this.iBtnCashierSearch.IconColor = System.Drawing.Color.White;
            this.iBtnCashierSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnCashierSearch.IconSize = 30;
            this.iBtnCashierSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnCashierSearch.Location = new System.Drawing.Point(327, 42);
            this.iBtnCashierSearch.Name = "iBtnCashierSearch";
            this.iBtnCashierSearch.Size = new System.Drawing.Size(107, 35);
            this.iBtnCashierSearch.TabIndex = 79;
            this.iBtnCashierSearch.Text = "Search";
            this.iBtnCashierSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnCashierSearch.UseVisualStyleBackColor = false;
            this.iBtnCashierSearch.Click += new System.EventHandler(this.iBtnCashierSearch_Click);
            // 
            // lblTId
            // 
            this.lblTId.AutoSize = true;
            this.lblTId.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTId.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblTId.Location = new System.Drawing.Point(739, 11);
            this.lblTId.Name = "lblTId";
            this.lblTId.Size = new System.Drawing.Size(0, 25);
            this.lblTId.TabIndex = 92;
            // 
            // lblrow
            // 
            this.lblrow.AutoSize = true;
            this.lblrow.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrow.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblrow.Location = new System.Drawing.Point(707, 264);
            this.lblrow.Name = "lblrow";
            this.lblrow.Size = new System.Drawing.Size(54, 25);
            this.lblrow.TabIndex = 93;
            this.lblrow.Text = "Row";
            // 
            // iBtnDeleteCategories
            // 
            this.iBtnDeleteCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.iBtnDeleteCategories.FlatAppearance.BorderSize = 0;
            this.iBtnDeleteCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnDeleteCategories.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnDeleteCategories.ForeColor = System.Drawing.Color.White;
            this.iBtnDeleteCategories.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.iBtnDeleteCategories.IconColor = System.Drawing.Color.White;
            this.iBtnDeleteCategories.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnDeleteCategories.IconSize = 30;
            this.iBtnDeleteCategories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnDeleteCategories.Location = new System.Drawing.Point(712, 42);
            this.iBtnDeleteCategories.Name = "iBtnDeleteCategories";
            this.iBtnDeleteCategories.Size = new System.Drawing.Size(97, 35);
            this.iBtnDeleteCategories.TabIndex = 94;
            this.iBtnDeleteCategories.Text = "Delete";
            this.iBtnDeleteCategories.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnDeleteCategories.UseVisualStyleBackColor = false;
            this.iBtnDeleteCategories.Click += new System.EventHandler(this.iBtnDeleteCategories_Click);
            // 
            // Sell_Transaction_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(820, 571);
            this.ControlBox = false;
            this.Controls.Add(this.iBtnDeleteCategories);
            this.Controls.Add(this.lblrow);
            this.Controls.Add(this.lblTId);
            this.Controls.Add(this.iBtnDateSearch);
            this.Controls.Add(this.cmbDateSearch);
            this.Controls.Add(this.dgvTransactionTable);
            this.Controls.Add(this.iBtnCashierSearch);
            this.Controls.Add(this.iBtnProductsearch);
            this.Controls.Add(this.cmbCashierSearch);
            this.Controls.Add(this.cmbProductSearch);
            this.Controls.Add(this.label4);
            this.Name = "Sell_Transaction_list";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton iBtnProductsearch;
        private System.Windows.Forms.ComboBox cmbProductSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvTransactionTable;
        private FontAwesome.Sharp.IconButton iBtnDateSearch;
        private System.Windows.Forms.ComboBox cmbDateSearch;
        private System.Windows.Forms.ComboBox cmbCashierSearch;
        private FontAwesome.Sharp.IconButton iBtnCashierSearch;
        private System.Windows.Forms.Label lblTId;
        private System.Windows.Forms.Label lblrow;
        private FontAwesome.Sharp.IconButton iBtnDeleteCategories;
    }
}