using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarketManagementSystem
{
    public partial class Profile : Form
    {
        String cashier = Seller.sellerName;
        public Profile()
        {
            InitializeComponent();
            addToCombobox("users", cmbUserName, "username", cashier);
            cashierTable();
        }
        private void addToCombobox(String tName, System.Windows.Forms.ComboBox comboBox, String cName, String role)
        {
            MySqlConnection con = null;
            try
            {
                con = DataBase.connectDB();
                con.Open();
                String query = "SELECT * FROM " + tName + " WHERE username=@name";
                MySqlCommand command = new MySqlCommand(query, con);
                command.Parameters.AddWithValue("@name", role);

                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBox.Items.Add(reader[cName].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
        private void cashierTable()
        {

            String cash = "SELECT uId, username, FirstName, SecondName, password, PhoneNumber, RegistrationDate, Sex FROM users WHERE username=@name;";

            MySqlConnection con = null;
            try
            {
                con = DataBase.connectDB();
                con.Open();
                MySqlCommand com = new MySqlCommand(cash, con);
                com.Parameters.AddWithValue("@name", cashier);

                MySqlDataAdapter adapter = new MySqlDataAdapter(com);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvPersonsProfile.DataSource = table;

                



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void cmbUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            string input = cmbUserName.Text + e.KeyChar;

            // Regular expression pattern for a valid user name
            string pattern = @"^[a-zA-Z0-9_\-]+$";

            // Validate input using regular expression
            bool isValid = Regex.IsMatch(input, pattern);

            if (!isValid && e.KeyChar != '\b')
            {
                e.Handled = true;
                cmbUserName.ForeColor = System.Drawing.Color.Red;
            }
            else
            {

                cmbUserName.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)&&e.KeyChar!=' '){
                e.Handled = true;// Prevent the character from being entered
            }
        }

        private void txtSecondName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;// Prevent the character from being entered
            }
        }

        private void txtPhoneNumber_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(txtPhoneNumber, "click enter key after  you enterd valid phone number");

        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string phoneNumber = txtPhoneNumber.Text;

                bool isValid = Regex.IsMatch(phoneNumber, @"^\+251\d{9}$");

                if (isValid)
                {

                    lblValid.Text = "";
                }
                else
                {
                    txtPhoneNumber.Text = "";
                    lblValid.Text = "please enter valid phone";
                }

            }
        }

        private void iBtnUpdateCashiers_Click(object sender, EventArgs e)
        {
            String sex;
            if (rBtnFemale.Checked)
            {
                sex = "Female";
            }
            else if (rBtnMale.Checked)
            {
                sex = "Male";
            }
            else
            {
                sex = "";
            }
            if (lblUserID.Text == "")
            {
                MessageBox.Show("please select the user you want to make update form the bellow table", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cmbUserName.Text == "" || txtPassword.Text == "" || txtFirstName.Text == "" || txtPassword.Text == "" || txtPhoneNumber.Text == "" || sex == "")
                {
                    MessageBox.Show("Pleasse Select you sex","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);                  

                }
                else
                {
                    if (MessageBox.Show("Are you sure to update your personal information property?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                       int uId = Convert.ToInt32(lblUserID.Text);
                        MySqlConnection con = null;
                        try
                        {
                            con = DataBase.connectDB();
                            con.Open();
                            String updateUser = "UPDATE users SET username=@uname, password=@upass, FirstName=@fname, SecondName= @sename, Sex=@sex, PhoneNumber=@phnum WHERE uId=@id;";
                            MySqlCommand upcom = new MySqlCommand(updateUser, con);
                            upcom.Parameters.AddWithValue("@uname", cmbUserName.Text);
                            upcom.Parameters.AddWithValue("@upass", txtPassword.Text);
                            upcom.Parameters.AddWithValue("@fname", txtFirstName.Text);
                            upcom.Parameters.AddWithValue("@sename", txtSecondName.Text);
                            upcom.Parameters.AddWithValue("@sex", sex);
                            upcom.Parameters.AddWithValue("@phnum", txtPhoneNumber.Text);
                            upcom.Parameters.AddWithValue("@id", uId);
                            upcom.ExecuteNonQuery();
                            cashierTable();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            con.Close();
                        }
                        cmbUserName.Text = "";
                        txtFirstName.Text = "";
                        txtSecondName.Text = "";
                        txtPhoneNumber.Text = "";
                        txtPassword.Text = "";
                        rBtnMale.Checked = false;
                        rBtnFemale.Checked = false;

                    }
                }


            }
        }

        private void dgvPersonsProfile_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvPersonsProfile.Rows[e.RowIndex];

                cmbUserName.Text = row.Cells["username"].Value.ToString();
                txtFirstName.Text = row.Cells["FirstName"].Value.ToString();
                txtSecondName.Text = row.Cells["SecondName"].Value.ToString();
                txtPhoneNumber.Text = row.Cells["PhoneNumber"].Value.ToString();
                txtPassword.Text = row.Cells["password"].Value.ToString();
                lblUserID.Text = row.Cells["uId"].Value.ToString();
            }
        }
    }
}
