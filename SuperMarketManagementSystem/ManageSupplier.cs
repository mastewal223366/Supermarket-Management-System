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
    public partial class ManageSupplier : Form
    {
        public ManageSupplier()
        {
            InitializeComponent();

            Table.populateTable(dgvSupplierTable, "supplier");
            cmbAddSupplier();
        }        
        private void cmbAddSupplier()
        {
            MySqlConnection con = DataBase.connectDB();
            con.Open();
            String query = "select *from supplier";
            MySqlCommand command = new MySqlCommand(query, con);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbManageSupplier.Items.Add(reader["sName"].ToString());
            }

        }

        private void dgvSupplierTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvSupplierTable.Rows[e.RowIndex];

                cmbManageSupplier.Text = row.Cells["sName"].Value.ToString();
                lblSId.Text = row.Cells["sId"].Value.ToString();
                txtCantactPhone.Text = row.Cells["contactPhoneNumberr"].Value.ToString();
            }
        }
        private void iBtnAddSupplier_Click(object sender, EventArgs e)
        {
            if (cmbManageSupplier.Text == "" || cmbManageSupplier.Text == "Supplier" || txtCantactPhone.Text == "")
            {
                MessageBox.Show("please enter the Name and the phone number of the supplier company first ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (MessageBox.Show("Are you sure to add this supplier to your supermarket?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MySqlConnection con = null;
                    try
                    {
                        con = DataBase.connectDB();
                        con.Open();
                        string query = "INSERT INTO supplier (sName,contactPhoneNumberr) VALUES (@name,@phone);";
                        MySqlCommand cmd = new MySqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@name", cmbManageSupplier.Text);
                        cmd.Parameters.AddWithValue("@phone", txtCantactPhone.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("You added new supplier to you supermarket", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmbManageSupplier.Items.Add(cmbManageSupplier.Text);
                        cmbManageSupplier.Text = "Supplier";
                        txtCantactPhone.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("This supplier exist please chage the name of supplier you want to add", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        con.Close();
                    }
                }
                else
                {
                    cmbManageSupplier.Text = "Supplier";
                    txtCantactPhone.Text = "";
                }

            }
        }      
        private void iBtnUpdateSupplier_Click_1(object sender, EventArgs e)
        {
            if (lblSId.Text == "" || cmbManageSupplier.Text == "Supplier")
            {
                MessageBox.Show("Please select the supplier information you want to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure to update this supplier?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    if (cmbManageSupplier.Text == "")
                    {
                        MessageBox.Show("please fill the name of your supplier company");
                    }
                    else
                    {
                        MySqlConnection con = null;
                        try
                        {
                            con = DataBase.connectDB();
                            con.Open();
                            string query = "UPDATE supplier SET sName=@name, contactPhoneNumberr=@phone WHERE sId=@id;";
                            MySqlCommand cmd = new MySqlCommand(query, con);
                            cmd.Parameters.AddWithValue("@name", cmbManageSupplier.Text);
                            cmd.Parameters.AddWithValue("@phone", txtCantactPhone.Text);
                            cmd.Parameters.AddWithValue("@id", lblSId.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("update  successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Table.populateTable(dgvSupplierTable, "supplier");
                            lblSId.Visible = false;
                            cmbManageSupplier.Items.Clear();
                            Combo.addToCombobox("supplier", cmbManageSupplier, "sName");
                            cmbManageSupplier.Text = "Brands";
                            cmbManageSupplier.Text = "Supplier";
                            txtCantactPhone.Text = "";


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            //MessageBox.Show("You have already this supplier please enter new supplier name? ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            con.Close();
                        }
                    }

                }
                else
                {
                    cmbManageSupplier.Text = "Brands";
                }
            }
        }      
        private void iBtnDeleteCategories_Click(object sender, EventArgs e)
        {
            if (lblSId.Text == "" || cmbManageSupplier.Text == "Brands")
            {
                MessageBox.Show("Please select the Supplier you want to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure to delete this Supplier?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    MySqlConnection con = null;
                    try
                    {
                        con = DataBase.connectDB();
                        con.Open();
                        string query = "DELETE FROM supplier WHERE sId=@iid;";
                        MySqlCommand cmd = new MySqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@iid", lblSId.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("you deleted the " + cmbManageSupplier.Text + " supplier successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        cmbManageSupplier.Items.Clear();
                        Combo.addToCombobox("supplier", cmbManageSupplier, "sName");
                        Table.populateTable(dgvSupplierTable, "supplier");
                        cmbManageSupplier.Text = "Supplier";
                        txtCantactPhone.Text = "";
                        lblSId.Visible = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("unable to delete this suppiler ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
                else
                {
                    cmbManageSupplier.Text = "Supplier";
                    txtCantactPhone.Text = "";
                }
            }
        }

        private void cmbManageSupplier_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)&&e.KeyChar!=' ')
            {
                e.Handled = true;// Prevent the character from being entered
            }
        }

        private void txtCantactPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string phoneNumber = txtCantactPhone.Text;

                bool isValid = Regex.IsMatch(phoneNumber, @"^\+251\d{9}$");

                if (isValid)
                {

                    lblValid.Text = "";
                }
                else
                {
                    txtCantactPhone.Text = "";
                    lblValid.Text = "please enter valid phone";
                }

            }
        }

        private void txtCantactPhone_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(txtCantactPhone, "click enter key after  you enterd valid phone number");

        }

       
    }

}
