namespace SuperMarketManagementSystem
{
    partial class Profile
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbUserName = new System.Windows.Forms.ComboBox();
            this.gBoxSex = new System.Windows.Forms.GroupBox();
            this.rBtnFemale = new System.Windows.Forms.RadioButton();
            this.rBtnMale = new System.Windows.Forms.RadioButton();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtSecondName = new System.Windows.Forms.TextBox();
            this.lblSecondName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iBtnUpdateCashiers = new FontAwesome.Sharp.IconButton();
            this.dgvPersonsProfile = new System.Windows.Forms.DataGridView();
            this.lblValid = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.gBoxSex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonsProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(367, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 80;
            // 
            // cmbUserName
            // 
            this.cmbUserName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUserName.FormattingEnabled = true;
            this.cmbUserName.Location = new System.Drawing.Point(296, 33);
            this.cmbUserName.Name = "cmbUserName";
            this.cmbUserName.Size = new System.Drawing.Size(214, 27);
            this.cmbUserName.TabIndex = 78;
            this.cmbUserName.Text = "username";
            this.cmbUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbUserName_KeyPress);
            // 
            // gBoxSex
            // 
            this.gBoxSex.Controls.Add(this.rBtnFemale);
            this.gBoxSex.Controls.Add(this.rBtnMale);
            this.gBoxSex.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.gBoxSex.ForeColor = System.Drawing.Color.White;
            this.gBoxSex.Location = new System.Drawing.Point(186, 211);
            this.gBoxSex.Name = "gBoxSex";
            this.gBoxSex.Size = new System.Drawing.Size(329, 68);
            this.gBoxSex.TabIndex = 75;
            this.gBoxSex.TabStop = false;
            this.gBoxSex.Text = "Sex";
            // 
            // rBtnFemale
            // 
            this.rBtnFemale.Location = new System.Drawing.Point(158, 23);
            this.rBtnFemale.Name = "rBtnFemale";
            this.rBtnFemale.Size = new System.Drawing.Size(108, 29);
            this.rBtnFemale.TabIndex = 1;
            this.rBtnFemale.TabStop = true;
            this.rBtnFemale.Text = "Female";
            this.rBtnFemale.UseVisualStyleBackColor = true;
            // 
            // rBtnMale
            // 
            this.rBtnMale.Location = new System.Drawing.Point(43, 23);
            this.rBtnMale.Name = "rBtnMale";
            this.rBtnMale.Size = new System.Drawing.Size(84, 29);
            this.rBtnMale.TabIndex = 0;
            this.rBtnMale.TabStop = true;
            this.rBtnMale.Text = "Male";
            this.rBtnMale.UseVisualStyleBackColor = true;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(297, 176);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(215, 27);
            this.txtPhoneNumber.TabIndex = 74;
            this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNumber_KeyPress);
            this.txtPhoneNumber.MouseHover += new System.EventHandler(this.txtPhoneNumber_MouseHover);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblPhoneNumber.Location = new System.Drawing.Point(119, 177);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(171, 25);
            this.lblPhoneNumber.TabIndex = 73;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // txtSecondName
            // 
            this.txtSecondName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecondName.Location = new System.Drawing.Point(296, 141);
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size(215, 27);
            this.txtSecondName.TabIndex = 72;
            this.txtSecondName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSecondName_KeyPress);
            // 
            // lblSecondName
            // 
            this.lblSecondName.AutoSize = true;
            this.lblSecondName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondName.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblSecondName.Location = new System.Drawing.Point(126, 143);
            this.lblSecondName.Name = "lblSecondName";
            this.lblSecondName.Size = new System.Drawing.Size(164, 25);
            this.lblSecondName.TabIndex = 71;
            this.lblSecondName.Text = "Second Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblFirstName.Location = new System.Drawing.Point(166, 107);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(124, 25);
            this.lblFirstName.TabIndex = 70;
            this.lblFirstName.Text = "First Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(296, 104);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(215, 27);
            this.txtFirstName.TabIndex = 69;
            this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstName_KeyPress);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(296, 67);
            this.txtPassword.MaxLength = 4;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(215, 27);
            this.txtPassword.TabIndex = 67;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblPassword.Location = new System.Drawing.Point(178, 66);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(119, 25);
            this.lblPassword.TabIndex = 66;
            this.lblPassword.Text = "Password: ";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblUsername.Location = new System.Drawing.Point(170, 33);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(120, 25);
            this.lblUsername.TabIndex = 65;
            this.lblUsername.Text = "username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RosyBrown;
            this.label1.Location = new System.Drawing.Point(1, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 25);
            this.label1.TabIndex = 81;
            this.label1.Text = "FILL YOUR PERSONAL IFNO:";
            // 
            // iBtnUpdateCashiers
            // 
            this.iBtnUpdateCashiers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.iBtnUpdateCashiers.FlatAppearance.BorderSize = 0;
            this.iBtnUpdateCashiers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnUpdateCashiers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnUpdateCashiers.ForeColor = System.Drawing.Color.White;
            this.iBtnUpdateCashiers.IconChar = FontAwesome.Sharp.IconChar.Recycle;
            this.iBtnUpdateCashiers.IconColor = System.Drawing.Color.White;
            this.iBtnUpdateCashiers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnUpdateCashiers.IconSize = 30;
            this.iBtnUpdateCashiers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnUpdateCashiers.Location = new System.Drawing.Point(333, 285);
            this.iBtnUpdateCashiers.Name = "iBtnUpdateCashiers";
            this.iBtnUpdateCashiers.Size = new System.Drawing.Size(109, 35);
            this.iBtnUpdateCashiers.TabIndex = 79;
            this.iBtnUpdateCashiers.Text = "Update";
            this.iBtnUpdateCashiers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnUpdateCashiers.UseVisualStyleBackColor = false;
            this.iBtnUpdateCashiers.Click += new System.EventHandler(this.iBtnUpdateCashiers_Click);
            // 
            // dgvPersonsProfile
            // 
            this.dgvPersonsProfile.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.dgvPersonsProfile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonsProfile.Location = new System.Drawing.Point(-3, 370);
            this.dgvPersonsProfile.Name = "dgvPersonsProfile";
            this.dgvPersonsProfile.Size = new System.Drawing.Size(825, 180);
            this.dgvPersonsProfile.TabIndex = 82;
            this.dgvPersonsProfile.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonsProfile_CellContentClick);
            // 
            // lblValid
            // 
            this.lblValid.AutoSize = true;
            this.lblValid.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValid.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblValid.Location = new System.Drawing.Point(552, 178);
            this.lblValid.Name = "lblValid";
            this.lblValid.Size = new System.Drawing.Size(0, 25);
            this.lblValid.TabIndex = 83;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblUserID.Location = new System.Drawing.Point(283, 289);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(0, 25);
            this.lblUserID.TabIndex = 84;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(820, 548);
            this.ControlBox = false;
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.lblValid);
            this.Controls.Add(this.dgvPersonsProfile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.iBtnUpdateCashiers);
            this.Controls.Add(this.cmbUserName);
            this.Controls.Add(this.gBoxSex);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.txtSecondName);
            this.Controls.Add(this.lblSecondName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Name = "Profile";
            this.gBoxSex.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonsProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iBtnUpdateCashiers;
        private System.Windows.Forms.ComboBox cmbUserName;
        private System.Windows.Forms.GroupBox gBoxSex;
        private System.Windows.Forms.RadioButton rBtnFemale;
        private System.Windows.Forms.RadioButton rBtnMale;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtSecondName;
        private System.Windows.Forms.Label lblSecondName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPersonsProfile;
        private System.Windows.Forms.Label lblValid;
        private System.Windows.Forms.Label lblUserID;
    }
}