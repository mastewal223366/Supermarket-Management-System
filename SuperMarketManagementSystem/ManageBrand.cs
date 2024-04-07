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
    public partial class ManageBrand : Form
    {
        public ManageBrand()
        {
            InitializeComponent();
            Table.populateTable(dgvBrand, "brand");
            Combo.addToCombobox("brand", cmbBrandName2, "brandName");
        }

        private void iBtnAddBrand_Click(object sender, EventArgs e)
        {
            if (cmbBrandName2.Text == ""||cmbBrandName2.Text=="Brands")
            {
                MessageBox.Show("please eneter the name of brand you want to add","Error",MessageBoxButtons.YesNo,MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure to add this brand?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    MySqlConnection con = null;
                    try
                    {
                        con = DataBase.connectDB();
                        con.Open();
                        string query = "INSERT INTO brand (brandName) VALUES (@name);";
                        MySqlCommand cmd = new MySqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@name", cmbBrandName2.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("you added  "+cmbBrandName2.Text+" brand Name successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Table.populateTable(dgvBrand, "brand");
                        cmbBrandName2.Items.Add(cmbBrandName2.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("you have this brand before","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
                else
                {
                    cmbBrandName2.Text = "Brand";
                }
            }
            
        }

        private void iBtnUpdateBrand_Click(object sender, EventArgs e)
        {
            if (lblBId.Text == "" || cmbBrandName2.Text == "Brand")
            {
                MessageBox.Show("Please select the brand you want to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure to update this brand?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    if (cmbBrandName2.Text == "")
                    {
                        MessageBox.Show("please fill the name of your brand");
                    }
                    else
                    {
                        MySqlConnection con = null;
                        try
                        {
                            con = DataBase.connectDB();
                            con.Open();
                            string query = "UPDATE brand SET brandName=@name WHERE bId=@id;";
                            MySqlCommand cmd = new MySqlCommand(query, con);
                            cmd.Parameters.AddWithValue("@name", cmbBrandName2.Text);
                            cmd.Parameters.AddWithValue("@id", lblBId.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("you update the name of your brand to " + cmbBrandName2.Text + "  successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Table.populateTable(dgvBrand, "brand");
                            lblBId.Visible = false;
                            cmbBrandName2.Items.Clear();
                            Combo.addToCombobox("brand", cmbBrandName2, "brandName");
                            cmbBrandName2.Text = "Brands";


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("You have already this brand name before please enter new brand name ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            con.Close();
                        }
                    }

                }
                else
                {
                    cmbBrandName2.Text = "Brands";
                }
            }

        }

        private void dgvBrand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvBrand.Rows[e.RowIndex];

                cmbBrandName2.Text = row.Cells["brandName"].Value.ToString();
                lblBId.Text = row.Cells["bId"].Value.ToString();
            }
        }

        private void iBtnDeleteBrand_Click(object sender, EventArgs e)
        {
            if (lblBId.Text == ""||cmbBrandName2.Text=="Brands")
            {
                MessageBox.Show("Please select the brand you want to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure to delete this brand?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    MySqlConnection con = null;
                    try
                    {
                        con = DataBase.connectDB();
                        con.Open();
                        string query = "DELETE FROM brand WHERE bId=@iid;";
                        MySqlCommand cmd = new MySqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@iid", lblBId.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("you deleted the " + cmbBrandName2.Text + " Brand successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        cmbBrandName2.Items.Clear();
                        Combo.addToCombobox("brand", cmbBrandName2, "brandName");
                        Table.populateTable(dgvBrand, "brand");
                        cmbBrandName2.Text = "Brands";
                        lblBId.Visible = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("unable to delete this brand ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
                else
                {
                    cmbBrandName2.Text = "Categories";
                }
            }
        }

        private void cmbBrandName2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;// Prevent the character from being entered
            }
        }
    }
}
