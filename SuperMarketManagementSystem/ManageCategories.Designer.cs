namespace SuperMarketManagementSystem
{
    partial class ManageCategories
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
            this.pnlBrandManager = new System.Windows.Forms.Panel();
            this.lblCatId = new System.Windows.Forms.Label();
            this.cmbCategoriesName2 = new System.Windows.Forms.ComboBox();
            this.iBtnAddCategories = new FontAwesome.Sharp.IconButton();
            this.iBtnUpdateCategories = new FontAwesome.Sharp.IconButton();
            this.iBtnDeleteCategories = new FontAwesome.Sharp.IconButton();
            this.lblCategoriesName = new System.Windows.Forms.Label();
            this.dgvCategories = new System.Windows.Forms.DataGridView();
            this.pnlBrandManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBrandManager
            // 
            this.pnlBrandManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.pnlBrandManager.Controls.Add(this.lblCatId);
            this.pnlBrandManager.Controls.Add(this.cmbCategoriesName2);
            this.pnlBrandManager.Controls.Add(this.iBtnAddCategories);
            this.pnlBrandManager.Controls.Add(this.iBtnUpdateCategories);
            this.pnlBrandManager.Controls.Add(this.iBtnDeleteCategories);
            this.pnlBrandManager.Controls.Add(this.lblCategoriesName);
            this.pnlBrandManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBrandManager.Location = new System.Drawing.Point(0, 0);
            this.pnlBrandManager.Name = "pnlBrandManager";
            this.pnlBrandManager.Size = new System.Drawing.Size(820, 237);
            this.pnlBrandManager.TabIndex = 1;
            // 
            // lblCatId
            // 
            this.lblCatId.AutoSize = true;
            this.lblCatId.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatId.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblCatId.Location = new System.Drawing.Point(392, 90);
            this.lblCatId.Name = "lblCatId";
            this.lblCatId.Size = new System.Drawing.Size(0, 25);
            this.lblCatId.TabIndex = 58;
            // 
            // cmbCategoriesName2
            // 
            this.cmbCategoriesName2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoriesName2.FormattingEnabled = true;
            this.cmbCategoriesName2.Location = new System.Drawing.Point(258, 50);
            this.cmbCategoriesName2.Name = "cmbCategoriesName2";
            this.cmbCategoriesName2.Size = new System.Drawing.Size(215, 27);
            this.cmbCategoriesName2.TabIndex = 57;
            this.cmbCategoriesName2.Text = "Categories";
            this.cmbCategoriesName2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCategoriesName2_KeyPress);
            // 
            // iBtnAddCategories
            // 
            this.iBtnAddCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.iBtnAddCategories.FlatAppearance.BorderSize = 0;
            this.iBtnAddCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnAddCategories.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnAddCategories.ForeColor = System.Drawing.Color.White;
            this.iBtnAddCategories.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.iBtnAddCategories.IconColor = System.Drawing.Color.White;
            this.iBtnAddCategories.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnAddCategories.IconSize = 30;
            this.iBtnAddCategories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnAddCategories.Location = new System.Drawing.Point(150, 118);
            this.iBtnAddCategories.Name = "iBtnAddCategories";
            this.iBtnAddCategories.Size = new System.Drawing.Size(92, 35);
            this.iBtnAddCategories.TabIndex = 38;
            this.iBtnAddCategories.Text = "Add";
            this.iBtnAddCategories.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnAddCategories.UseVisualStyleBackColor = false;
            this.iBtnAddCategories.Click += new System.EventHandler(this.iBtnAddCategories_Click);
            // 
            // iBtnUpdateCategories
            // 
            this.iBtnUpdateCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.iBtnUpdateCategories.FlatAppearance.BorderSize = 0;
            this.iBtnUpdateCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnUpdateCategories.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnUpdateCategories.ForeColor = System.Drawing.Color.White;
            this.iBtnUpdateCategories.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.iBtnUpdateCategories.IconColor = System.Drawing.Color.White;
            this.iBtnUpdateCategories.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnUpdateCategories.IconSize = 30;
            this.iBtnUpdateCategories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnUpdateCategories.Location = new System.Drawing.Point(258, 118);
            this.iBtnUpdateCategories.Name = "iBtnUpdateCategories";
            this.iBtnUpdateCategories.Size = new System.Drawing.Size(107, 35);
            this.iBtnUpdateCategories.TabIndex = 37;
            this.iBtnUpdateCategories.Text = "Update";
            this.iBtnUpdateCategories.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnUpdateCategories.UseVisualStyleBackColor = false;
            this.iBtnUpdateCategories.Click += new System.EventHandler(this.iBtnUpdateCategories_Click);
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
            this.iBtnDeleteCategories.Location = new System.Drawing.Point(376, 118);
            this.iBtnDeleteCategories.Name = "iBtnDeleteCategories";
            this.iBtnDeleteCategories.Size = new System.Drawing.Size(97, 35);
            this.iBtnDeleteCategories.TabIndex = 36;
            this.iBtnDeleteCategories.Text = "Delete";
            this.iBtnDeleteCategories.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnDeleteCategories.UseVisualStyleBackColor = false;
            this.iBtnDeleteCategories.Click += new System.EventHandler(this.iBtnDeleteCategories_Click);
            // 
            // lblCategoriesName
            // 
            this.lblCategoriesName.AutoSize = true;
            this.lblCategoriesName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriesName.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblCategoriesName.Location = new System.Drawing.Point(45, 51);
            this.lblCategoriesName.Name = "lblCategoriesName";
            this.lblCategoriesName.Size = new System.Drawing.Size(197, 25);
            this.lblCategoriesName.TabIndex = 14;
            this.lblCategoriesName.Text = "Categories Name:";
            // 
            // dgvCategories
            // 
            this.dgvCategories.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCategories.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvCategories.Location = new System.Drawing.Point(0, 237);
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.Size = new System.Drawing.Size(820, 357);
            this.dgvCategories.TabIndex = 2;
            this.dgvCategories.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategories_CellContentClick);
            // 
            // ManageCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(820, 594);
            this.ControlBox = false;
            this.Controls.Add(this.dgvCategories);
            this.Controls.Add(this.pnlBrandManager);
            this.Name = "ManageCategories";
            this.pnlBrandManager.ResumeLayout(false);
            this.pnlBrandManager.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBrandManager;
        private FontAwesome.Sharp.IconButton iBtnAddCategories;
        private FontAwesome.Sharp.IconButton iBtnUpdateCategories;
        private FontAwesome.Sharp.IconButton iBtnDeleteCategories;
        private System.Windows.Forms.Label lblCategoriesName;
        private System.Windows.Forms.ComboBox cmbCategoriesName2;
        private System.Windows.Forms.DataGridView dgvCategories;
        private System.Windows.Forms.Label lblCatId;
    }
}