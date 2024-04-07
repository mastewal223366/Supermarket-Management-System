using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarketManagementSystem
{
    public partial class ManageCategories : Form
    {
        public ManageCategories()
        {
            InitializeComponent();
            Table.populateTable(dgvCategories, "categories");
            Combo.addToCombobox("categories", cmbCategoriesName2, "catName");
        }
        private void iBtnAddCategories_Click(object sender, EventArgs e)
        {
            if (cmbCategoriesName2.Text == "" || cmbCategoriesName2.Text == "Categories")
            {
                MessageBox.Show("pleae enter the category name you want to add");
            }
            else
            {

                if (MessageBox.Show("Are you sure to add this category?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    MySqlConnection con = null;
                    try
                    {
                        con = DataBase.connectDB();
                        con.Open();
                        string query = "INSERT INTO categories (catName) VALUES (@name);";
                        MySqlCommand cmd = new MySqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@name", cmbCategoriesName2.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("you added the " + cmbCategoriesName2.Text + " Category successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Table.populateTable(dgvCategories, "categories");
                        cmbCategoriesName2.Text = "Categories";
                        cmbCategoriesName2.Items.Add(cmbCategoriesName2.Text);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("You have already this Category before please add new? ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.Close();
                    }

                }
                else
                {
                    cmbCategoriesName2.Text = "Categories";
                }

            }
            Table.populateTable(dgvCategories, "categories");
        }

        private void iBtnDeleteCategories_Click(object sender, EventArgs e)
        {
            if (lblCatId.Text == "")
            {
                MessageBox.Show("Please select the cateogries you want to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure to delete this category?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    MySqlConnection con = null;
                    try
                    {
                        con = DataBase.connectDB();
                        con.Open();
                        string query = "DELETE FROM categories WHERE id=@iid;";
                        MySqlCommand cmd = new MySqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@iid", lblCatId.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("you deleted the "+cmbCategoriesName2.Text+" Category successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                        cmbCategoriesName2.Items.Clear();
                        Combo.addToCombobox("categories", cmbCategoriesName2, "catName");
                        Table.populateTable(dgvCategories, "categories");
                        cmbCategoriesName2.Text = "categories";
                        
                        lblCatId.Visible = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("unable to delete this category ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
                else
                {
                    cmbCategoriesName2.Text = "Categories";
                }
            }
        }

        private void dgvCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvCategories.Rows[e.RowIndex];

                cmbCategoriesName2.Text = row.Cells["catName"].Value.ToString();
                lblCatId.Text = row.Cells["id"].Value.ToString();
            }
        }

        private void iBtnUpdateCategories_Click(object sender, EventArgs e)
        {
            if (lblCatId.Text == ""||cmbCategoriesName2.Text=="Categories")
            {
                MessageBox.Show("Please select the product you want to update","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure to update this category?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    if (cmbCategoriesName2.Text == "")
                    {
                        MessageBox.Show("please fill the name of your category");
                    }
                    else
                    {
                        MySqlConnection con = null;
                        try
                        {
                            con = DataBase.connectDB();
                            con.Open();
                            string query = "UPDATE categories SET catName=@name WHERE id=@id;";
                            MySqlCommand cmd = new MySqlCommand(query, con);
                            cmd.Parameters.AddWithValue("@name", cmbCategoriesName2.Text);
                            cmd.Parameters.AddWithValue("@id", lblCatId.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("you update the name of your Category to "+cmbCategoriesName2.Text+"  successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Table.populateTable(dgvCategories, "categories");
                            lblCatId.Visible = false;
                            cmbCategoriesName2.Items.Clear();
                            Combo.addToCombobox("categories", cmbCategoriesName2, "catName");
                            cmbCategoriesName2.Text = "Categories";


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("You have already this Category before please add new? ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            con.Close();
                        }
                    }                   

                }
                else
                {
                    cmbCategoriesName2.Text = "Brands";
                }
            }
            
        }

        private void cmbCategoriesName2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;// Prevent the character from being entered
            }
        }
    }
}
