namespace SuperMarketManagementSystem
{
    partial class Critical_Prodcuts
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
            this.dgvCriticalProdut = new System.Windows.Forms.DataGridView();
            this.pnlBrandManager = new System.Windows.Forms.Panel();
            this.iBtnDisplay = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCriticalProdut)).BeginInit();
            this.pnlBrandManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCriticalProdut
            // 
            this.dgvCriticalProdut.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.dgvCriticalProdut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCriticalProdut.Location = new System.Drawing.Point(160, 155);
            this.dgvCriticalProdut.Name = "dgvCriticalProdut";
            this.dgvCriticalProdut.Size = new System.Drawing.Size(529, 391);
            this.dgvCriticalProdut.TabIndex = 5;
            //
            // pnlBrandManager
            // 
            this.pnlBrandManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.pnlBrandManager.Controls.Add(this.iBtnDisplay);
            this.pnlBrandManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBrandManager.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlBrandManager.Location = new System.Drawing.Point(0, 0);
            this.pnlBrandManager.Name = "pnlBrandManager";
            this.pnlBrandManager.Size = new System.Drawing.Size(820, 162);
            this.pnlBrandManager.TabIndex = 4;
            // 
            // iBtnDisplay
            // 
            this.iBtnDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.iBtnDisplay.FlatAppearance.BorderSize = 0;
            this.iBtnDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnDisplay.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnDisplay.ForeColor = System.Drawing.Color.White;
            this.iBtnDisplay.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iBtnDisplay.IconColor = System.Drawing.Color.White;
            this.iBtnDisplay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnDisplay.IconSize = 30;
            this.iBtnDisplay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnDisplay.Location = new System.Drawing.Point(372, 64);
            this.iBtnDisplay.Name = "iBtnDisplay";
            this.iBtnDisplay.Size = new System.Drawing.Size(105, 35);
            this.iBtnDisplay.TabIndex = 39;
            this.iBtnDisplay.Text = "Display";
            this.iBtnDisplay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnDisplay.UseVisualStyleBackColor = false;
            this.iBtnDisplay.Click += new System.EventHandler(this.iBtnDisplay_Click);
            // 
            // Critical_Prodcuts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(820, 548);
            this.ControlBox = false;
            this.Controls.Add(this.dgvCriticalProdut);
            this.Controls.Add(this.pnlBrandManager);
            this.Name = "Critical_Prodcuts";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCriticalProdut)).EndInit();
            this.pnlBrandManager.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCriticalProdut;
        private System.Windows.Forms.Panel pnlBrandManager;
        private FontAwesome.Sharp.IconButton iBtnDisplay;
    }
}