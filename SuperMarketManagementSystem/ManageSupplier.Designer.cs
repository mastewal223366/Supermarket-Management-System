namespace SuperMarketManagementSystem
{
    partial class ManageSupplier
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
            this.pnlSupplierManager = new System.Windows.Forms.Panel();
            this.lblValid = new System.Windows.Forms.Label();
            this.lblSId = new System.Windows.Forms.Label();
            this.txtCantactPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbManageSupplier = new System.Windows.Forms.ComboBox();
            this.iBtnAddSupplier = new FontAwesome.Sharp.IconButton();
            this.iBtnUpdateSupplier = new FontAwesome.Sharp.IconButton();
            this.iBtnDeleteCategories = new FontAwesome.Sharp.IconButton();
            this.lblCategoriesName = new System.Windows.Forms.Label();
            this.dgvSupplierTable = new System.Windows.Forms.DataGridView();
            this.pnlSupplierManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplierTable)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSupplierManager
            // 
            this.pnlSupplierManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.pnlSupplierManager.Controls.Add(this.lblValid);
            this.pnlSupplierManager.Controls.Add(this.lblSId);
            this.pnlSupplierManager.Controls.Add(this.txtCantactPhone);
            this.pnlSupplierManager.Controls.Add(this.label1);
            this.pnlSupplierManager.Controls.Add(this.cmbManageSupplier);
            this.pnlSupplierManager.Controls.Add(this.iBtnAddSupplier);
            this.pnlSupplierManager.Controls.Add(this.iBtnUpdateSupplier);
            this.pnlSupplierManager.Controls.Add(this.iBtnDeleteCategories);
            this.pnlSupplierManager.Controls.Add(this.lblCategoriesName);
            this.pnlSupplierManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSupplierManager.Location = new System.Drawing.Point(0, 0);
            this.pnlSupplierManager.Name = "pnlSupplierManager";
            this.pnlSupplierManager.Size = new System.Drawing.Size(820, 237);
            this.pnlSupplierManager.TabIndex = 2;
            // 
            // lblValid
            // 
            this.lblValid.AutoSize = true;
            this.lblValid.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValid.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblValid.Location = new System.Drawing.Point(468, 58);
            this.lblValid.Name = "lblValid";
            this.lblValid.Size = new System.Drawing.Size(0, 25);
            this.lblValid.TabIndex = 61;
            // 
            // lblSId
            // 
            this.lblSId.AutoSize = true;
            this.lblSId.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSId.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblSId.Location = new System.Drawing.Point(362, 90);
            this.lblSId.Name = "lblSId";
            this.lblSId.Size = new System.Drawing.Size(0, 25);
            this.lblSId.TabIndex = 60;
            // 
            // txtCantactPhone
            // 
            this.txtCantactPhone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantactPhone.Location = new System.Drawing.Point(235, 59);
            this.txtCantactPhone.Name = "txtCantactPhone";
            this.txtCantactPhone.Size = new System.Drawing.Size(215, 27);
            this.txtCantactPhone.TabIndex = 59;
            this.txtCantactPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantactPhone_KeyPress);
            this.txtCantactPhone.MouseHover += new System.EventHandler(this.txtCantactPhone_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RosyBrown;
            this.label1.Location = new System.Drawing.Point(57, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 58;
            this.label1.Text = "Contact phone:";
            // 
            // cmbManageSupplier
            // 
            this.cmbManageSupplier.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbManageSupplier.FormattingEnabled = true;
            this.cmbManageSupplier.IntegralHeight = false;
            this.cmbManageSupplier.Location = new System.Drawing.Point(235, 24);
            this.cmbManageSupplier.Name = "cmbManageSupplier";
            this.cmbManageSupplier.Size = new System.Drawing.Size(215, 27);
            this.cmbManageSupplier.TabIndex = 57;
            this.cmbManageSupplier.Text = "Supplier";
           
            this.cmbManageSupplier.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbManageSupplier_KeyPress);
            // 
            // iBtnAddSupplier
            // 
            this.iBtnAddSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.iBtnAddSupplier.FlatAppearance.BorderSize = 0;
            this.iBtnAddSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnAddSupplier.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnAddSupplier.ForeColor = System.Drawing.Color.White;
            this.iBtnAddSupplier.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.iBtnAddSupplier.IconColor = System.Drawing.Color.White;
            this.iBtnAddSupplier.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnAddSupplier.IconSize = 30;
            this.iBtnAddSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnAddSupplier.Location = new System.Drawing.Point(114, 118);
            this.iBtnAddSupplier.Name = "iBtnAddSupplier";
            this.iBtnAddSupplier.Size = new System.Drawing.Size(92, 35);
            this.iBtnAddSupplier.TabIndex = 38;
            this.iBtnAddSupplier.Text = "Add";
            this.iBtnAddSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnAddSupplier.UseVisualStyleBackColor = false;
            this.iBtnAddSupplier.Click += new System.EventHandler(this.iBtnAddSupplier_Click);
            // 
            // iBtnUpdateSupplier
            // 
            this.iBtnUpdateSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.iBtnUpdateSupplier.FlatAppearance.BorderSize = 0;
            this.iBtnUpdateSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnUpdateSupplier.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnUpdateSupplier.ForeColor = System.Drawing.Color.White;
            this.iBtnUpdateSupplier.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.iBtnUpdateSupplier.IconColor = System.Drawing.Color.White;
            this.iBtnUpdateSupplier.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnUpdateSupplier.IconSize = 30;
            this.iBtnUpdateSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnUpdateSupplier.Location = new System.Drawing.Point(223, 118);
            this.iBtnUpdateSupplier.Name = "iBtnUpdateSupplier";
            this.iBtnUpdateSupplier.Size = new System.Drawing.Size(107, 35);
            this.iBtnUpdateSupplier.TabIndex = 37;
            this.iBtnUpdateSupplier.Text = "Update";
            this.iBtnUpdateSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnUpdateSupplier.UseVisualStyleBackColor = false;
            this.iBtnUpdateSupplier.Click += new System.EventHandler(this.iBtnUpdateSupplier_Click_1);
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
            this.iBtnDeleteCategories.Location = new System.Drawing.Point(353, 118);
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
            this.lblCategoriesName.Location = new System.Drawing.Point(57, 23);
            this.lblCategoriesName.Name = "lblCategoriesName";
            this.lblCategoriesName.Size = new System.Drawing.Size(169, 25);
            this.lblCategoriesName.TabIndex = 14;
            this.lblCategoriesName.Text = "Supplier Name:";
            // 
            // dgvSupplierTable
            // 
            this.dgvSupplierTable.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvSupplierTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplierTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSupplierTable.Location = new System.Drawing.Point(0, 237);
            this.dgvSupplierTable.Name = "dgvSupplierTable";
            this.dgvSupplierTable.Size = new System.Drawing.Size(820, 334);
            this.dgvSupplierTable.TabIndex = 3;
            this.dgvSupplierTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSupplierTable_CellContentClick);
            // 
            // ManageSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(820, 571);
            this.ControlBox = false;
            this.Controls.Add(this.dgvSupplierTable);
            this.Controls.Add(this.pnlSupplierManager);
            this.Name = "ManageSupplier";
            this.pnlSupplierManager.ResumeLayout(false);
            this.pnlSupplierManager.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplierTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSupplierManager;
        private System.Windows.Forms.ComboBox cmbManageSupplier;
        private FontAwesome.Sharp.IconButton iBtnAddSupplier;
        private FontAwesome.Sharp.IconButton iBtnUpdateSupplier;
        private FontAwesome.Sharp.IconButton iBtnDeleteCategories;
        private System.Windows.Forms.Label lblCategoriesName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantactPhone;
        private System.Windows.Forms.DataGridView dgvSupplierTable;
        private System.Windows.Forms.Label lblSId;
        private System.Windows.Forms.Label lblValid;
    }
}