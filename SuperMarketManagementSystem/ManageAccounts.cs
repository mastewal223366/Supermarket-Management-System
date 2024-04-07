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
    public partial class ManageAccounts : Form
    {
        
        public ManageAccounts()
        {
            InitializeComponent();
            addToCombobox("users", cmbUserName, "username","Cashier");
            cashierTable();
           

        }
       private void addToCombobox(String tName, System.Windows.Forms.ComboBox comboBox, String cName,String role)
       {
            MySqlConnection con = null;
            try
            {
                con = DataBase.connectDB();
                con.Open();
                String query = "SELECT * FROM " + tName+" WHERE role=@role";
                MySqlCommand command = new MySqlCommand(query, con);
                command.Parameters.AddWithValue("@role", role);

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

            String role = "Cashier";
            String cash = "SELECT uId, username, FirstName, SecondName, PhoneNumber, RegistrationDate, Sex FROM users;";

            MySqlConnection con = null;
            try
            {
                con = DataBase.connectDB();
                con.Open();
                MySqlCommand com = new MySqlCommand(cash, con);
                com.Parameters.AddWithValue("@role", role);

                MySqlDataAdapter adapter = new MySqlDataAdapter(com);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvCashier.DataSource = table;

                String no = "SELECT COUNT(*) FROM users WHERE role=@rolee;";
                MySqlCommand co = new MySqlCommand(no, con);
                co.Parameters.AddWithValue("@rolee", "Cashier");
                int noCashier=Convert.ToInt32( co.ExecuteScalar());
                lblNoCashier.Text = noCashier.ToString();



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
        private void iBtnAddCashier_Click(object sender, EventArgs e)
        {
            String sex;
            DateTime selectedDate = dtpEmployedDate.Value.Date;
            String formattedDate = selectedDate.ToString("yyyy-MM-dd");
            if (rBtnFemale.Checked)
            {
                sex = "Female";
            }
            else if(rBtnMale.Checked)
            {
                sex = "Male";
            }
            else
            {
                sex = "";
            }
            if (cmbUserName.Text == "" || txtPassword.Text == "" || txtFirstName.Text == "" || txtPassword.Text == "" || txtPhoneNumber.Text == ""|| sex=="")
            {
                MessageBox.Show("please fill the form in right way");
                cmbUserName.Text = "";
                txtFirstName.Text = "";
                txtSecondName.Text = "";
                txtPhoneNumber.Text = "";
                txtPassword.Text = "";
                rBtnMale.Checked = false;
                rBtnFemale.Checked = false;

            }
            else
            {
                if (MessageBox.Show("Are you sure to add this person? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    MySqlConnection con = null;
                    try
                    {

                        
                        con = DataBase.connectDB();
                        con.Open();
                        String query = "INSERT INTO users (username,password,FirstName,SecondName,PhoneNumber,RegistrationDate,Sex) VALUES (@name,@password,@fname,@sname,@pnumber,@rdate,@sex);";
                        MySqlCommand cmd = new MySqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@name", cmbUserName.Text);
                        cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                        cmd.Parameters.AddWithValue("@fname", txtFirstName.Text);
                        cmd.Parameters.AddWithValue("@sname", txtSecondName.Text);
                        cmd.Parameters.AddWithValue("@pnumber", txtPhoneNumber.Text);
                        cmd.Parameters.AddWithValue("@rdate", formattedDate);
                        cmd.Parameters.AddWithValue("@sex", sex);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("you have added person");
                        cmbUserName.Items.Add(cmbUserName.Text);
                        cashierTable();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("This username already exist please change you username","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        cmbUserName.Text = "";
                        txtFirstName.Text = "";
                        txtSecondName.Text = "";
                        txtPhoneNumber.Text = "";
                        txtPassword.Text = "";
                        rBtnMale.Checked = false;
                        rBtnFemale.Checked = false;
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

        private void iBtnDeleteCashier_Click(object sender, EventArgs e)
        {
            if (cmbUserName.Text == "")
            {
                MessageBox.Show("please select the user you wnat to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure to delete this product", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MySqlConnection con = null;
                    try
                    {
                        String delete = "DELETE FROM users WHERE username=@user;";

                        con = DataBase.connectDB();
                        con.Open();
                        MySqlCommand com = new MySqlCommand(delete, con);
                        com.Parameters.AddWithValue("@user", cmbUserName.Text);
                        com.ExecuteNonQuery();
                        MessageBox.Show("You have deleted the user succefully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        cashierTable();
                        lblUserID.Visible = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }
                    finally
                    {
                        con.Close();
                    }
                    cmbUserName.Items.Remove(cmbUserName.Text);
                }
            }                    
        }

        private void dgvCashier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvCashier.Rows[e.RowIndex];

                cmbUserName.Text = row.Cells["username"].Value.ToString();
                txtFirstName.Text = row.Cells["FirstName"].Value.ToString();
                txtSecondName.Text = row.Cells["SecondName"].Value.ToString();
                txtPhoneNumber.Text = row.Cells["PhoneNumber"].Value.ToString();
                dtpEmployedDate.Text = row.Cells["RegistrationDate"].Value.ToString();
                lblUserID.Text = row.Cells["uId"].Value.ToString();
            }
        }

        private void rBtnMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void iBtnUpdateCashiers_Click(object sender, EventArgs e)
        {
            String sex;
            if (rBtnFemale.Checked)
            {
                sex = "Female";
            }
            else if(rBtnMale.Checked)
            {
                sex = "Male";
            }
            else
            {
                sex = "";
            }
            if (lblUserID.Text == "")
            {
                MessageBox.Show("please select the user you want to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cmbUserName.Text == "" || txtPassword.Text == "" || txtFirstName.Text == "" || txtPassword.Text == "" || txtPhoneNumber.Text == "" || sex == "")
                {
                    MessageBox.Show("please fill the form in right way");
                    cmbUserName.Text = "";
                    txtFirstName.Text = "";
                    txtSecondName.Text = "";
                    txtPhoneNumber.Text = "";
                    txtPassword.Text = "";
                    rBtnMale.Checked = false;
                    rBtnFemale.Checked = false;

                }
                else
                {
                    if (MessageBox.Show("Are you sure to update this user's property?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DateTime selectedDate = dtpEmployedDate.Value.Date;
                        String formattedDate = selectedDate.ToString("yyyy-MM-dd");
                        int uId = Convert.ToInt32(lblUserID.Text);
                        MySqlConnection con = null;
                        try
                        {
                            con = DataBase.connectDB();
                            con.Open();
                            String updateUser = "UPDATE users SET username=@uname, password=@upass, FirstName=@fname, SecondName= @sename, Sex=@sex, PhoneNumber=@phnum,RegistrationDate=@date WHERE uId=@id;";
                            MySqlCommand upcom = new MySqlCommand(updateUser, con);
                            upcom.Parameters.AddWithValue("@uname", cmbUserName.Text);
                            upcom.Parameters.AddWithValue("@upass", txtPassword.Text);
                            upcom.Parameters.AddWithValue("@fname", txtFirstName.Text);
                            upcom.Parameters.AddWithValue("@sename", txtSecondName.Text);
                            upcom.Parameters.AddWithValue("@sex", sex);
                            upcom.Parameters.AddWithValue("@phnum", txtPhoneNumber.Text);
                            upcom.Parameters.AddWithValue("@date", formattedDate);
                            upcom.Parameters.AddWithValue("@id", uId);
                            upcom.ExecuteNonQuery();
                            txtPassword.Text = "";

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
                    }
                }
               
                
            }
                       
        }

        private void cmbUserName_TextChanged(object sender, EventArgs e)
        {
            string input = cmbUserName.Text;

            // Regular expression pattern for a valid user name
            string pattern = @"^[a-zA-Z0-9_\-]+$";

            // Validate input using regular expression
            bool isValid = Regex.IsMatch(input, pattern);

            if (isValid)
            {
                cmbUserName.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                cmbUserName.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void cmbUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            string input = cmbUserName.Text+e.KeyChar;

            // Regular expression pattern for a valid user name
            string pattern = @"^[a-zA-Z0-9_\-]+$";

            // Validate input using regular expression
            bool isValid = Regex.IsMatch(input, pattern);

            if (!isValid && e.KeyChar!='\b')
            {e.Handled = true;
                cmbUserName.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                
                cmbUserName.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\b')
            {
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

        private void txtPhoneNumber_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(txtPhoneNumber, "click enter key after  you enterd valid phone number");
        }

     
    }
}
