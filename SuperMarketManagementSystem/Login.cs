using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace SuperMarketManagementSystem
{    
    public partial class Login : Form
    {  
        public Login()
        {
            InitializeComponent();
            CmbAccount.SelectedItem = "Cashier";

        }

        
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = null;
            try
            {
                conn = DataBase.connectDB();
                conn.Open();
                String query = "SELECT password,role FROM users WHERE username=@username";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", txtUsers.Text);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (String.Equals(reader["role"], CmbAccount.Text))
                        {
                            if (String.Equals(reader["password"], txtPassword.Text))
                            {
                                if (CmbAccount.Text== "Admin")
                                {
                                   AdminForm form = new AdminForm(txtUsers.Text);
                                   form.Show();
                                   this.Hide();
                                }
                                else
                                {
                                    Seller seller = new Seller(txtUsers.Text);
                                    seller.Show();
                                    this.Hide();
                                }
                            }
                            else
                            {
                                MessageBox.Show("please enter the correct  password","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                                txtPassword.Text = "";
                            }
                        }
                        else
                        {
                            MessageBox.Show("Make sure you selected the right role","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Username not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }
                reader.Close();

            }

            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void txtUsers_KeyPress(object sender, KeyPressEventArgs e)
        {
            string input = txtUsers.Text+e.KeyChar;

            // Regular expression pattern for a valid user name
            string pattern = @"^[a-zA-Z0-9_\-]+$";

            // Validate input using regular expression
            bool isValid = Regex.IsMatch(input, pattern);

            if (!isValid&&e.KeyChar!='\b')
            {
                txtUsers.ForeColor = System.Drawing.Color.Red;
                e.Handled = true;
               
            }
            else
            {
                txtUsers.ForeColor = System.Drawing.Color.Black;
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {   //Customizing the panel
            panel1.BackColor = Color.FromArgb(215, 255, 255, 255);
            int borderRadius = 20; // Adjust the radius as needed
            panel1.Region = GetRoundedRegion(panel1, borderRadius);
            //customizing the boxes
            borderRadius = 10;
            txtUsers.Region = GetRoundedRegion(txtUsers, borderRadius);
            txtPassword.Region = GetRoundedRegion(txtPassword, borderRadius);
            BtnLogin.Region = GetRoundedRegion(BtnLogin, borderRadius);
           
        }
        private Region GetRoundedRegion(Control control, int borderRadius)
        {
            GraphicsPath path = new GraphicsPath();
            Rectangle bounds = new Rectangle(0, 0, control.Width, control.Height);
            int diameter = borderRadius * 2;

            // Top-left corner
            path.AddArc(bounds.Left, bounds.Top, diameter, diameter, 180, 90);

            // Top-right corner
            path.AddArc(bounds.Right - diameter, bounds.Top, diameter, diameter, 270, 90);

            // Bottom-right corner
            path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);

            // Bottom-left corner
            path.AddArc(bounds.Left, bounds.Bottom - diameter, diameter, diameter, 90, 90);

            path.CloseFigure();
            return new Region(path);
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure you want to reset?","Reset the form",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtUsers.Text = "";
                txtPassword.Text = "";
            }
            


        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnLogin.PerformClick();
            }
        }
    }
}
