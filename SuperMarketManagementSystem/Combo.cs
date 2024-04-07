using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace SuperMarketManagementSystem
{
    public class Combo
    {
        public static void addToCombobox(String tName, System.Windows.Forms.ComboBox comboBox, String cName)
        {
            MySqlConnection con = null;
            try
            {
                con = DataBase.connectDB();
                con.Open();
                String query = "SELECT * FROM " + tName;
                MySqlCommand command = new MySqlCommand(query, con);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBox.Items.Add(reader[cName].ToString());
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
        public static void addComboDate(String tName, System.Windows.Forms.ComboBox comboBox, String cName)
        {
            MySqlConnection con = null;
            try
            {
                con = DataBase.connectDB();
                con.Open();
                String query = "SELECT "+cName+" FROM " + tName;
                MySqlCommand command = new MySqlCommand(query, con);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBox.Items.Add(reader.GetDateTime(0).Date.ToString("MM/dd/yyyy"));
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

}


