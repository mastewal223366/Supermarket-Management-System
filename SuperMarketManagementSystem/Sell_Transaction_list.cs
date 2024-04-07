using MySql.Data.MySqlClient;
using System;
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
    public partial class Sell_Transaction_list : Form
    {
        int amountOfRow;
        String query2 = "SELECT t.tId, u.username, p.ProductName, t.Quantity, t.tDate, t.Price, t.total FROM transaction t JOIN product p ON t.pId=p.pId JOIN users u ON t.uId=u.uId;";

        public Sell_Transaction_list()
        {
            InitializeComponent();
            Combo.addToCombobox("product", cmbProductSearch, "ProductName");
            Combo.addToCombobox("users", cmbCashierSearch, "username");
            cmbCashierSearch.Items.Remove("maste");
            Table.mergeTable(dgvTransactionTable, query2);
            Combo.addComboDate("product_supplier", cmbDateSearch, "date");

        }
        private int searchDate(String table, String column, DateTime comboValue)
        {
            MySqlConnection con = null;

            int rows = 0;
            try
            {
                
                String suppliedTable = "SELECT t.tId, u.username, p.ProductName, t.Quantity, t.tDate, t.Price FROM transaction t JOIN product p ON t.pId=p.pId JOIN users u ON t.uId=u.uId WHERE t." + column + "=@x;";
                con = DataBase.connectDB();
                con.Open();

                MySqlCommand command = new MySqlCommand(suppliedTable, con);
                command.Parameters.AddWithValue("@x", comboValue);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvTransactionTable.DataSource = dataTable;


                String row = "SELECT COUNT(*) FROM transaction t JOIN product p ON t.pId = p.pId JOIN users u ON t.uId = u.uId WHERE t." + column + "=@y;";
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

        private void iBtnProductsearch_Click(object sender, EventArgs e)
        {
            amountOfRow = searchTable("product", "ProductName", cmbProductSearch.Text);
            lblrow.Text = amountOfRow.ToString();
        }
        private void iBtnCashierSearch_Click(object sender, EventArgs e)
        {
            amountOfRow = searchTable("users", "username", cmbCashierSearch.Text);
            lblrow.Text = amountOfRow.ToString();
        }
        private int searchTable(String table, String column, String comboValue)
        {
            MySqlConnection con = null;
            String c = "";
            if (String.Equals(table, "product"))
            {
                c = "p";
            }
            else
            {
                c = "u";
            }
        
            int rows = 0;

            try
            { 

                String psearch = "SELECT t.tId, u.username, p.ProductName, t.Quantity, t.tDate, t.Price, t.total FROM transaction t JOIN product p ON t.pId=p.pId JOIN users u ON t.uId=u.uId WHERE "+c+"."+column + "=@x;";
                con = DataBase.connectDB();
                con.Open();

                MySqlCommand command = new MySqlCommand(psearch, con);
                command.Parameters.AddWithValue("@x", comboValue);

               
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvTransactionTable.DataSource = dataTable;

                String row = "SELECT COUNT(*) FROM" +
                                " transaction t JOIN product p"+
                                "  ON t.pId = p.pId JOIN users u ON t.uId = u.uId WHERE " + c + "." + column + "=@y;";

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

        private void iBtnDateSearch_Click(object sender, EventArgs e)
        {

            if (cmbDateSearch.Text == "Date"&&cmbDateSearch.Text=="Date")
            {
                MessageBox.Show("plese enter the date ");
            }
            else
            { DateTime time1=DateTime.Parse(cmbDateSearch.Text);
            searchDate("transaction", "tDate", time1);
                
                lblrow.Text = amountOfRow.ToString();
            }
           


        }

        private void iBtnDeleteCategories_Click(object sender, EventArgs e)
        {
            if (lblTId.Text == "")
            {
                MessageBox.Show("Please enter the transaction you want to delete", "Error", MessageBoxButtons.OK);

            }
            else
            {
                if (MessageBox.Show("Are you sure to delete this transaction", "Question", MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    MySqlConnection con = null;
                    try
                    {
                        con = DataBase.connectDB();
                        con.Open();
                        String q = "DELETE FROM transaction WHERE tId=@id;";
                        MySqlCommand com = new MySqlCommand(q, con);
                        com.Parameters.AddWithValue("@id", lblTId.Text);
                        com.ExecuteNonQuery();
                        MessageBox.Show("You have deleted this transaction", "Success", MessageBoxButtons.OK);
                        Table.mergeTable(dgvTransactionTable, query2);


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

        private void dgvTransactionTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvTransactionTable.Rows[e.RowIndex];

                lblTId.Text = row.Cells["tId"].Value.ToString();
               
            }
        }
    }
}
