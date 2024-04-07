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
    public partial class Critical_Prodcuts : Form
    {
        public Critical_Prodcuts()
        {
            InitializeComponent();
        }
        private void iBtnDisplay_Click(object sender, EventArgs e)
        {
            int critical=10;
            MySqlConnection con = null;
            try
            {
                con = DataBase.connectDB();
                con.Open();
                String query = "SELECT ProductName, Quantity FROM product WHERE Quantity<=" + critical + ";";
                Table.mergeTable(dgvCriticalProdut,query);
                
            }
            catch(Exception ex)
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
