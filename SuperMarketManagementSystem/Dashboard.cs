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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();       
            int q=totalqty();
            int b=totalResult("brand",lblTotalBrand);
            int u=totalResult("users", lblNoCashier);
            int s=totalResult("supplier", lblSupplier);
            int c=totalResult("categories", lblTotalCategories);
            chart1.Series["chartOverView"].Points.AddXY("product quantity", q);
            chart1.Series["chartOverView"].Points.AddXY("Brand", b);
            chart1.Series["chartOverView"].Points.AddXY("Categoris",c);
            chart1.Series["chartOverView"].Points.AddXY("Supplier", s);
            chart1.Series["chartOverView"].Points.AddXY("Users", u);
        }
        private int totalResult(String table,Label lable)
        {
            int x=0;
            MySqlConnection con = null;
            try
            {
                con = DataBase.connectDB();
                con.Open();
                String query = "SELECT COUNT(*) FROM "+table+";";
                MySqlCommand cm = new MySqlCommand(query, con);
                lable.Text = Convert.ToInt32(cm.ExecuteScalar()).ToString();
                x= Convert.ToInt32(cm.ExecuteScalar());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return x;
        }
        private int totalqty()
        {
            int x = 0;
            MySqlConnection con = null;
            try
            {
                int total=0;
                con = DataBase.connectDB();
                con.Open();
                String query = "SELECT Quantity FROM product;";
                MySqlCommand cm = new MySqlCommand(query, con);
                MySqlDataReader dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    total += Convert.ToInt32(dr["Quantity"]);
                }
                dr.Close();
                lblNoOfProducts.Text = total.ToString();
                x = total;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return x;

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
