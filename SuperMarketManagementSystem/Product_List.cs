using FontAwesome.Sharp;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SuperMarketManagementSystem
{
    public partial class Product_List : Form
    {

        int amountOfRow = 0;
        String query = "SELECT p.pId, p.ProductName, p.price, p.Quantity, b.brandName, c.catName FROM product p JOIN brand b ON p.BrandId = b.bId JOIN categories c ON p.CategoriesId = c.id;";

        public Product_List()
        {
            
            InitializeComponent();
            Table.mergeTable(dgvProductList, query);
            Combo.addToCombobox("product", cmbProductName2, "ProductName");
            Combo.addToCombobox("categories", cmbCategoriesName2, "catName");
            Combo.addToCombobox("brand", cmbBrandName2, "brandName");

            Combo.addToCombobox("product", cmbProductSearch, "ProductName");
            Combo.addToCombobox("categories", cmbCategoriesSearch, "catName");
            Combo.addToCombobox("brand", cmbBrandSearch, "brandName");



        }

        private void iBtnUpdateCategories_Click(object sender, EventArgs e)
        {
            if (cmbCategoriesName2.Text == "" || cmbBrandName2.Text == "" || txtQuantity.Text == "" || txtPrice.Text == "")
            {
                MessageBox.Show("please enter all values", "EROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(MessageBox.Show("Are you sure to modify this product?","Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Boolean check = false;
                    double price = double.Parse(txtPrice.Text);
                    int qty = int.Parse(txtQuantity.Text);

                    int bId;
                    int cId;

                    MySqlConnection con = null;
                    try
                    {
                        con = DataBase.connectDB();
                        con.Open();
                        String queryy = "SELECT * FROM product WHERE pId=@id;";
                        MySqlCommand comm = new MySqlCommand(queryy, con);
                        comm.Parameters.AddWithValue("@id", lblPid.Text);
                        MySqlDataReader reader = comm.ExecuteReader();
                        while (reader.Read())
                        {
                            check = true;
                        }
                        if (check == true)
                        {
                            reader.Close();

                            cId = idProvider(cmbCategoriesName2.Text, con, "categories", "id", "catName");
                            bId = idProvider(cmbBrandName2.Text, con, "brand", "bId", "brandName");                        

                            String product = "UPDATE product SET Quantity=@pqty, price=@price, BrandId=@bId, CategoriesId=@cId WHERE pId=@id;";
                            MySqlCommand pcom = new MySqlCommand(product, con);
                            pcom.Parameters.AddWithValue("@bId", bId);
                            pcom.Parameters.AddWithValue("@cId", cId);
                            pcom.Parameters.AddWithValue("@pqty", qty);
                            pcom.Parameters.AddWithValue("@price", price);
                            pcom.Parameters.AddWithValue("@id", lblPid.Text);
                            pcom.ExecuteNonQuery();
                            MessageBox.Show("The item is updated succefully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            reader.Close();
                            MessageBox.Show("your are trying to update unknow product please put the right product", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            cmbBrandName2.Text = "";
                            cmbCategoriesName2.Text = "";
                            cmbProductName2.Text = "";
                            txtPrice.Text = "";
                            txtQuantity.Text = "";
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

            }
            
            Table.mergeTable(dgvProductList, query);
        }

        public int idProvider(String boxName,MySqlConnection con,String tableName,String idColumn,String nameColumn)
        {
            Boolean check = false;
            int id = 0 ;
            String cat = "SELECT "+idColumn+" FROM "+tableName+" WHERE "+nameColumn+"=@cname;";
            MySqlCommand com = new MySqlCommand(cat, con);
            com.Parameters.AddWithValue("@cname", boxName);
            MySqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {

                check = true;
                id = Convert.ToInt32(reader[idColumn]);
                reader.Close();
                break;
            }
            if (check == false)
            {
                reader.Close();
                String newc = "INSERT INTO "+tableName+" ("+nameColumn+") VALUES (@catName);";
                MySqlCommand ncomc = new MySqlCommand(newc, con);
                ncomc.Parameters.AddWithValue("@catName", boxName);
                ncomc.ExecuteNonQuery();

                String lastc = "SELECT LAST_INSERT_ID();";
                MySqlCommand lc = new MySqlCommand(lastc, con);
                id = Convert.ToInt32(lc.ExecuteScalar());
                if (String.Equals(boxName, cmbBrandName2.Text))
                {
                    cmbBrandName2.Items.Add(boxName);
                    cmbBrandSearch.Items.Add(boxName);
                    
                    
                }
                else
                {
                    cmbCategoriesName2.Items.Add(boxName);
                    cmbCategoriesSearch.Items.Add(boxName);
                }
                
            }

            return id;
        }

        private void iBtnDeleteCategories_Click(object sender, EventArgs e)
        {
            MySqlConnection con = null;
            try
            {
                con = DataBase.connectDB();
                con.Open();
                if (cmbProductName2.Text == "")
                {
                    MessageBox.Show("First enter the product name you want to delete", "ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    if(MessageBox.Show("Are you sure you want to delete this product?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        String delete = "DELETE FROM product WHERE pId=@id;";
                        MySqlCommand dcom = new MySqlCommand(delete, con);
                        dcom.Parameters.AddWithValue("@id",lblPid.Text);
                        dcom.ExecuteNonQuery();
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            Table.mergeTable(dgvProductList, query);

        }

        private void iBtnProductsearch_Click(object sender, EventArgs e)
        {
            amountOfRow=searchTable("product","ProductName", cmbProductSearch.Text);
            lblrow.Text = amountOfRow.ToString();
        }        
        private void iBtnCategoriesSearch_Click(object sender, EventArgs e)
        {
            amountOfRow=searchTable("categories","catName", cmbCategoriesSearch.Text);
            lblrow.Text = amountOfRow.ToString();
        }

        private void iBtnBrandSearch_Click(object sender, EventArgs e)
        {
            amountOfRow=searchTable("brand", "brandName", cmbBrandSearch.Text);
            lblrow.Text = amountOfRow.ToString();
        }
        private int searchTable(String table, String column, String comboValue)
        {
            MySqlConnection con = null;
            String c = "";
            int rows=0;
            if (string.Equals(table, "categories"))
            {
                c = "c";
            }
            else if (String.Equals(table, "brand"))
            {
                c = "b";
            }
            else if (String.Equals(table, "product"))
            {
                c = "p";
            }
            else
            {
                MessageBox.Show("please enter the table you want to select column","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            try
            {

                String psearch = "SELECT p.pId, p.ProductName, p.price, p.Quantity, b.brandName, c.catName FROM" +
                                 " product p JOIN brand b ON p.BrandId = b.bId" +
                                 " JOIN categories c ON p.CategoriesId = c.id WHERE " + c + "." + column + "=@x;";
                con = DataBase.connectDB();
                con.Open();

                MySqlCommand command = new MySqlCommand(psearch, con);
                command.Parameters.AddWithValue("@x", comboValue);


                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvProductList.DataSource = dataTable;

                String row = "SELECT COUNT(*) FROM" +
                                " product p JOIN brand b ON p.BrandId = b.bId" +
                                " JOIN categories c ON p.CategoriesId = c.id WHERE " + c + "." + column + "=@y;";

                MySqlCommand com = new MySqlCommand(row, con);
                com.Parameters.AddWithValue("@y", comboValue);
                rows = Convert.ToInt32(com.ExecuteScalar());


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return rows;
        }

        private void dgvProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvProductList.Rows[e.RowIndex];

                cmbProductName2.Text = row.Cells["ProductName"].Value.ToString();
                cmbBrandName2.Text = row.Cells["brandName"].Value.ToString();
                cmbCategoriesName2.Text = row.Cells["catName"].Value.ToString();
                txtQuantity.Text = row.Cells["Quantity"].Value.ToString();
                txtPrice.Text = row.Cells["price"].Value.ToString();
                lblPid.Text = row.Cells["pId"].Value.ToString();
            }
        }

        private void cmbProductName2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;// Prevent the character from being entered
            }
        }

        private void cmbCategoriesName2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;// Prevent the character from being entered
            }
        }

        private void cmbBrandName2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;// Prevent the character from being entered
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar!='\b')
            {
                e.Handled = true;// Prevent the character from being entered
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b'&& e.KeyChar!='.')
            {
                e.Handled = true;// Prevent the character from being entered
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            string input = txtPrice.Text;

            // Check if dot ('.') appears more than once
            if (input.Split('.').Length > 2)
            {
                txtPrice.Text = input.Substring(0, input.Length - 1); // Remove the extra dot
                txtPrice.SelectionStart = txtPrice.Text.Length; // Set the cursor at the end of the text
            }
        }
    }
}
