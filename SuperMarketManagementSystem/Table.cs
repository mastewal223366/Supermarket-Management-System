using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarketManagementSystem
{
    internal class Table
    {
        public static void populateTable(System.Windows.Forms.DataGridView dgv,String tableName)
        {
            MySqlConnection con = DataBase.connectDB();
            con.Open();

            String query = "SELECT * FROM " + tableName + ";";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgv.DataSource = table;
        }
        public static void mergeTable(DataGridView dgv,String query)
        {
            MySqlConnection con = DataBase.connectDB();
            con.Open();

            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgv.DataSource = table;
        }
    }
}
