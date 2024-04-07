using FontAwesome.Sharp;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarketManagementSystem
{
    public partial class Sell : Form
    {
        String cashier = Seller.sellerName;

        int amountOfRow = 0;
        String query = "SELECT p.pId, p.ProductName, p.price, p.Quantity, b.brandName, c.catName FROM product p JOIN brand b ON p.BrandId = b.bId JOIN categories c ON p.CategoriesId = c.id;";
        static String query2 = $"SELECT t.tId, u.username, p.ProductName, t.Quantity, t.tDate, t.Price, t.total FROM transaction t JOIN product p ON t.pId=p.pId JOIN users u ON t.uId=u.uId WHERE u.username='{Seller.sellerName}';";
        public Sell()
        {

            InitializeComponent();
           
            Table.mergeTable(dgvTransactionList, query2);
            try 
            {  
                Table.mergeTable(dgvProductList, query);
                Table.mergeTable(dgvTransactionList, query2);
            }
            
            
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           
            Combo.addToCombobox("product", cmbProductName2, "ProductName");
            Combo.addToCombobox("categories", cmbCategoriesName2, "catName");
            Combo.addToCombobox("brand", cmbBrandName2, "brandName");

            Combo.addToCombobox("product", cmbProductSearch, "ProductName");
            Combo.addToCombobox("categories", cmbCategoriesSearch, "catName");
            Combo.addToCombobox("brand", cmbBrandSearch, "brandName");
            Combo.addComboDate("product_supplier", cmbDate, "date");



        }
        private int searchTable(String table, String column, String comboValue)
        {
            MySqlConnection con = null;
            String c = "";
            int rows = 0;
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
                MessageBox.Show("please enter the table you want to select column", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void iBtnProductsearch_Click_1(object sender, EventArgs e)
        {
            amountOfRow = searchTable("product", "ProductName", cmbProductSearch.Text);
            lblrow.Text = amountOfRow.ToString();
            String pro = "Products";
            cmbProductSearch.Text = pro;

        }

        private void iBtnCategoriesSearch_Click_1(object sender, EventArgs e)
        {
            amountOfRow = searchTable("categories", "catName", cmbCategoriesSearch.Text);
            lblrow.Text = amountOfRow.ToString();
            String pro = "Categories";
            cmbCategoriesSearch.Text = pro;
        }

        private void iBtnBrandSearch_Click_1(object sender, EventArgs e)
        {
            amountOfRow = searchTable("brand", "brandName", cmbBrandSearch.Text);
            lblrow.Text = amountOfRow.ToString();
            String pro = "Brands";
            cmbBrandSearch.Text = pro;
        }

        private void iBtnDateSearch_Click(object sender, EventArgs e)
        {
            if (cmbDate.Text == "Date")
            {
                MessageBox.Show("plese enter the date ");
            }
            else
            {
                DateTime date = DateTime.Parse(cmbDate.Text);
                amountOfRow = searchDate("product_supplier", "date", date);
                lblrow.Text = amountOfRow.ToString();
            }
        }
        private int searchDate(String table, String column, DateTime comboValue)
        {
            MySqlConnection con = null;

            int rows = 0;
            try
            {
                String suppliedTable = "SELECT sp.spId, p.pId, p.ProductName, p.price, p.Quantity, s.sName, date FROM" +
                                       " product_supplier sp JOIN product p ON sp.pId = p.pId" +
                                       " JOIN supplier s ON sp.sId = s.sId WHERE sp." + column + "=@x;";
                con = DataBase.connectDB();
                con.Open();

                MySqlCommand command = new MySqlCommand(suppliedTable, con);
                command.Parameters.AddWithValue("@x", comboValue);


                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvProductList.DataSource = dataTable;


                String row = "SELECT COUNT(*) FROM" +
                                       " product_supplier sp JOIN product p ON sp.pId = p.pId" +
                                       " JOIN supplier s ON sp.sId = s.sId WHERE  sp." + column + "=@y;";
                MySqlCommand com = new MySqlCommand(row, con);
                com.Parameters.AddWithValue("@y", comboValue);
                rows = Convert.ToInt32(com.ExecuteScalar());

            }
            catch (Exception ex)
            {
                MessageBox.Show("succefully");
            }
            finally
            {
                con.Close();
            }
            return rows;
        }
        private void iBtnSell_Click(object sender, EventArgs e)
        {
            if (cmbBrandName2.Text == "" || cmbCategoriesName2.Text == "" || cmbProductName2.Text == "" || txtSellingQuantity.Text == "")
            {
                MessageBox.Show("Please Eneter all  importat informations","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if(MessageBox.Show("Are you sure to sell this product this action will not be undone ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (Convert.ToInt32(txtSellingQuantity.Text) > Convert.ToInt32(lblQty.Text))
                    {
                        MessageBox.Show("you have no sufficient number of product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSellingQuantity.Text = "";
                    }
                    else
                    {
                        MySqlConnection con = null;
                        try
                        {
                            int proId = Convert.ToInt32(lblId.Text);
                            int qty = Convert.ToInt32(lblQty.Text);
                            int amount = Convert.ToInt32(txtSellingQuantity.Text);
                            double price = Convert.ToDouble(lblPrice.Text);
                            double total = price * amount;
                            con = DataBase.connectDB();
                            con.Open();
                            String qtyUpdate = "UPDATE product SET Quantity=@qty WHERE pId=@id;";
                            MySqlCommand updatcom = new MySqlCommand(qtyUpdate, con);
                            updatcom.Parameters.AddWithValue("@qty", qty - amount);
                            updatcom.Parameters.AddWithValue("@id", proId);
                            updatcom.ExecuteNonQuery();


                            String cashier = Seller.sellerName;
                            int uId;
                            String user = "SELECT * FROM users WHERE username=@na;";
                            MySqlCommand c = new MySqlCommand(user, con);
                            c.Parameters.AddWithValue("@na", cashier.Trim());
                            MySqlDataReader r = c.ExecuteReader();
                            if (r.Read())
                            {
                                uId = Convert.ToInt32(r["uid"]);
                                r.Close();
                                String tran = "INSERT INTO transaction (uId ,pId, Quantity, tDate, Price, total) VALUES (@uId, @pId, @qty, @d, @p,@tot)";
                                MySqlCommand tcom = new MySqlCommand(tran, con);
                                tcom.Parameters.AddWithValue("@uid", uId);
                                tcom.Parameters.AddWithValue("@pId", proId);
                                tcom.Parameters.AddWithValue("@qty", amount);
                                tcom.Parameters.AddWithValue("@d", dtpSoldDate.Value.Date);
                                tcom.Parameters.AddWithValue("@p", price);
                                tcom.Parameters.AddWithValue("@tot", total);
                                tcom.ExecuteNonQuery();


                            }
                            double outPut = price * amount;
                            lblTotal.Text = lblTotal.Text + " " + outPut.ToString();
                            MessageBox.Show("Transaction successful","Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            Table.mergeTable(dgvProductList, query);
                            Table.mergeTable(dgvTransactionList, query2);



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

        private void dgvProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvProductList.Rows[e.RowIndex];

                cmbProductName2.Text = row.Cells["ProductName"].Value.ToString();
                cmbBrandName2.Text = row.Cells["brandName"].Value.ToString();
                cmbCategoriesName2.Text = row.Cells["catName"].Value.ToString();
                txtSellingQuantity.Text = row.Cells["Quantity"].Value.ToString();
                lblQty.Text = row.Cells["Quantity"].Value.ToString();
                lblPrice.Text = row.Cells["price"].Value.ToString();
                lblId.Text = row.Cells["pId"].Value.ToString();
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

        private void txtSellingQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar !='\b')
            {
                e.Handled = true;// Prevent the character from being entered
            }
        }

        
    }
    
}
