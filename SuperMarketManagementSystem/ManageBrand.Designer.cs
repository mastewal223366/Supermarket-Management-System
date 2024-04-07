namespace SuperMarketManagementSystem
{
    partial class ManageBrand
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
            this.lblBId = new System.Windows.Forms.Label();
            this.cmbBrandName2 = new System.Windows.Forms.ComboBox();
            this.lblBrandName = new System.Windows.Forms.Label();
            this.dgvBrand = new System.Windows.Forms.DataGridView();
            this.iBtnAddBrand = new FontAwesome.Sharp.IconButton();
            this.iBtnUpdateBrand = new FontAwesome.Sharp.IconButton();
            this.iBtnDeleteBrand = new FontAwesome.Sharp.IconButton();
            this.pnlBrandManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrand)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBrandManager
            // 
            this.pnlBrandManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.pnlBrandManager.Controls.Add(this.lblBId);
            this.pnlBrandManager.Controls.Add(this.cmbBrandName2);
            this.pnlBrandManager.Controls.Add(this.iBtnAddBrand);
            this.pnlBrandManager.Controls.Add(this.iBtnUpdateBrand);
            this.pnlBrandManager.Controls.Add(this.iBtnDeleteBrand);
            this.pnlBrandManager.Controls.Add(this.lblBrandName);
            this.pnlBrandManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBrandManager.Location = new System.Drawing.Point(0, 0);
            this.pnlBrandManager.Name = "pnlBrandManager";
            this.pnlBrandManager.Size = new System.Drawing.Size(820, 237);
            this.pnlBrandManager.TabIndex = 0;
            // 
            // lblBId
            // 
            this.lblBId.AutoSize = true;
            this.lblBId.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBId.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblBId.Location = new System.Drawing.Point(375, 81);
            this.lblBId.Name = "lblBId";
            this.lblBId.Size = new System.Drawing.Size(0, 25);
            this.lblBId.TabIndex = 45;
            // 
            // cmbBrandName2
            // 
            this.cmbBrandName2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBrandName2.FormattingEnabled = true;
            this.cmbBrandName2.Location = new System.Drawing.Point(228, 46);
            this.cmbBrandName2.Name = "cmbBrandName2";
            this.cmbBrandName2.Size = new System.Drawing.Size(215, 27);
            this.cmbBrandName2.TabIndex = 44;
            this.cmbBrandName2.Text = "Brands";
            this.cmbBrandName2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbBrandName2_KeyPress);
            // 
            // lblBrandName
            // 
            this.lblBrandName.AutoSize = true;
            this.lblBrandName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrandName.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblBrandName.Location = new System.Drawing.Point(75, 48);
            this.lblBrandName.Name = "lblBrandName";
            this.lblBrandName.Size = new System.Drawing.Size(147, 25);
            this.lblBrandName.TabIndex = 14;
            this.lblBrandName.Text = "Brand Name:";
            // 
            // dgvBrand
            // 
            this.dgvBrand.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvBrand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBrand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBrand.Location = new System.Drawing.Point(0, 237);
            this.dgvBrand.Name = "dgvBrand";
            this.dgvBrand.Size = new System.Drawing.Size(820, 380);
            this.dgvBrand.TabIndex = 2;
            this.dgvBrand.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBrand_CellContentClick);
            // 
            // iBtnAddBrand
            // 
            this.iBtnAddBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.iBtnAddBrand.FlatAppearance.BorderSize = 0;
            this.iBtnAddBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnAddBrand.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnAddBrand.ForeColor = System.Drawing.Color.White;
            this.iBtnAddBrand.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.iBtnAddBrand.IconColor = System.Drawing.Color.White;
            this.iBtnAddBrand.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnAddBrand.IconSize = 30;
            this.iBtnAddBrand.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnAddBrand.Location = new System.Drawing.Point(143, 110);
            this.iBtnAddBrand.Name = "iBtnAddBrand";
            this.iBtnAddBrand.Size = new System.Drawing.Size(92, 35);
            this.iBtnAddBrand.TabIndex = 38;
            this.iBtnAddBrand.Text = "Add";
            this.iBtnAddBrand.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnAddBrand.UseVisualStyleBackColor = false;
            this.iBtnAddBrand.Click += new System.EventHandler(this.iBtnAddBrand_Click);
            // 
            // iBtnUpdateBrand
            // 
            this.iBtnUpdateBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.iBtnUpdateBrand.FlatAppearance.BorderSize = 0;
            this.iBtnUpdateBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnUpdateBrand.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnUpdateBrand.ForeColor = System.Drawing.Color.White;
            this.iBtnUpdateBrand.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.iBtnUpdateBrand.IconColor = System.Drawing.Color.White;
            this.iBtnUpdateBrand.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnUpdateBrand.IconSize = 30;
            this.iBtnUpdateBrand.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnUpdateBrand.Location = new System.Drawing.Point(246, 110);
            this.iBtnUpdateBrand.Name = "iBtnUpdateBrand";
            this.iBtnUpdateBrand.Size = new System.Drawing.Size(107, 35);
            this.iBtnUpdateBrand.TabIndex = 37;
            this.iBtnUpdateBrand.Text = "Update";
            this.iBtnUpdateBrand.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnUpdateBrand.UseVisualStyleBackColor = false;
            this.iBtnUpdateBrand.Click += new System.EventHandler(this.iBtnUpdateBrand_Click);
            // 
            // iBtnDeleteBrand
            // 
            this.iBtnDeleteBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.iBtnDeleteBrand.FlatAppearance.BorderSize = 0;
            this.iBtnDeleteBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnDeleteBrand.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnDeleteBrand.ForeColor = System.Drawing.Color.White;
            this.iBtnDeleteBrand.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.iBtnDeleteBrand.IconColor = System.Drawing.Color.White;
            this.iBtnDeleteBrand.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnDeleteBrand.IconSize = 30;
            this.iBtnDeleteBrand.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnDeleteBrand.Location = new System.Drawing.Point(359, 109);
            this.iBtnDeleteBrand.Name = "iBtnDeleteBrand";
            this.iBtnDeleteBrand.Size = new System.Drawing.Size(97, 35);
            this.iBtnDeleteBrand.TabIndex = 36;
            this.iBtnDeleteBrand.Text = "Delete";
            this.iBtnDeleteBrand.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnDeleteBrand.UseVisualStyleBackColor = false;
            this.iBtnDeleteBrand.Click += new System.EventHandler(this.iBtnDeleteBrand_Click);
            // 
            // ManageBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(820, 617);
            this.ControlBox = false;
            this.Controls.Add(this.dgvBrand);
            this.Controls.Add(this.pnlBrandManager);
            this.Name = "ManageBrand";
            this.pnlBrandManager.ResumeLayout(false);
            this.pnlBrandManager.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrand)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBrandManager;
        private System.Windows.Forms.Label lblBrandName;
        private FontAwesome.Sharp.IconButton iBtnAddBrand;
        private FontAwesome.Sharp.IconButton iBtnUpdateBrand;
        private FontAwesome.Sharp.IconButton iBtnDeleteBrand;
        private System.Windows.Forms.ComboBox cmbBrandName2;
        private System.Windows.Forms.DataGridView dgvBrand;
        private System.Windows.Forms.Label lblBId;
    }
}