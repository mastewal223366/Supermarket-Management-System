using FontAwesome.Sharp;
using Google.Protobuf;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Documents;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace SuperMarketManagementSystem
{
    public partial class Add_Products : Form
    {
        int amountOfRow = 0;
        String psearch = "SELECT sp.spId, p.pId, p.ProductName, p.price, sp.suppliedQuantity, s.sName, date FROM" +
                                 " product_supplier sp JOIN product p ON sp.pId = p.pId" +
                                 " JOIN supplier s ON sp.sId = s.sId;";

        public Add_Products()
        {
            
            InitializeComponent();
            product_supplierTable();
            Combo.addToCombobox("categories", cmbCategoriesName,"catName");
            Combo.addToCombobox("brand", cmbBrandName, "brandName");
            Combo.addToCombobox("supplier", cmbSupplierName, "sName");
            Combo.addToCombobox("product", cmbProductName, "ProductName");

            Combo.addToCombobox("supplier", cmbSupplierSearch, "sName");
            Combo.addToCombobox("product", cmbProductSearch, "ProductName");
            Combo.addComboDate("product_supplier", cmbDateSearch, "date");



        }
        private void product_supplierTable()
        {
            MySqlConnection con = null;
            try
            {
                con = DataBase.connectDB();
                con.Open();

                MySqlDataAdapter adapter = new MySqlDataAdapter(psearch, con);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvSuppliedProduct.DataSource = table;
                
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
       
      

        private void iBtnAddNewProduct_Click(object sender, EventArgs e)
        {
            
            if (cmbProductName.Text == ""||cmbProductName.Text=="Products" || txtBuyingPrice.Text == "" || txtQuantity.Text == ""||cmbBrandName.Text==""||cmbCategoriesName.Text==""||cmbCategoriesName.Text=="Categories"||cmbBrandName.Text=="Brands"||cmbSupplierName.Text==""||cmbSupplierName.Text=="Supplier")
            {
                MessageBox.Show("Please enter all appropriate values");
            }
            else
            {
                if (MessageBox.Show("Are you sure to add this product to your supermarket?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int sId, cId=-1, bId=-1, pId;
                    double enterdPrice=double.Parse(txtBuyingPrice.Text);
                    int enterdAmount =Convert.ToInt32(txtQuantity.Text);
                    double changedPrice=Convert.ToDouble(txtBuyingPrice.Text);
                    DateTime selectedDate = dtpSuppliedDate.Value.Date;

                    MySqlConnection con =null;
                    try
                    {
                        con = DataBase.connectDB();
                        con.Open();

                        String query = "SELECT * FROM categories WHERE catName=@name;";
                        MySqlCommand com = new MySqlCommand(query, con);
                        com.Parameters.AddWithValue("@name", cmbCategoriesName.Text);
                        int c = Convert.ToInt32(com.ExecuteScalar());
                        Console.WriteLine(c);
                      
                        String query1 = "SELECT * FROM brand WHERE brandName=@bname;";
                        MySqlCommand bcom = new MySqlCommand(query1, con);
                        bcom.Parameters.AddWithValue("@bname", cmbBrandName.Text);
                        int b = Convert.ToInt32(bcom.ExecuteScalar());

                        String query2 = "SELECT * FROM supplier WHERE sName=@sname;";
                        MySqlCommand scom = new MySqlCommand(query2, con);
                        scom.Parameters.AddWithValue("@sname", cmbSupplierName.Text);
                        int s = Convert.ToInt32(scom.ExecuteScalar());

                        String query0 = "SELECT * FROM product WHERE ProductName=@name;";
                        MySqlCommand cmdd = new MySqlCommand(query0, con);
                        cmdd.Parameters.AddWithValue("@name", cmbProductName.Text);
                        MySqlDataReader reader = cmdd.ExecuteReader();
                        Boolean check = false;
                        while (reader.Read())
                        {

                            if (c == Convert.ToInt32(reader["CategoriesId"]) && b == Convert.ToInt32(reader["brandId"]))
                            {
                                check = true;
                                cId = Convert.ToInt32(reader["CategoriesId"]);
                                bId = Convert.ToInt32(reader["brandId"]);
                                break;
                            }
                           
                            check = true;
                            cId = Convert.ToInt32(reader["CategoriesId"]);
                            bId = Convert.ToInt32(reader["brandId"]);
                        }
                        if (check == true)
                        {

                            
                            reader.Close();
                                                      

                            if (cId == c)
                            {

                                if (bId == b)
                                {

                                    String qqqr = "SELECT * FROM product WHERE ProductName=@ppname AND BrandId=@bid AND CategoriesId=@cid;";
                                    MySqlCommand ccccm = new MySqlCommand(qqqr, con);
                                    ccccm.Parameters.AddWithValue("@ppname", cmbProductName.Text);
                                    ccccm.Parameters.AddWithValue("@bid", bId);
                                    ccccm.Parameters.AddWithValue("@cid", cId);
                                    MySqlDataReader yyy = ccccm.ExecuteReader();
                                    yyy.Read();
                                    int amount=Convert.ToInt32(yyy["Quantity"]);
                                    double existPrice = Convert.ToDouble(yyy["price"]);

                                    yyy.Close();
                                    if (existPrice < changedPrice)
                                    {
                                        existPrice = changedPrice;
                                    }

                                    int x=amount+enterdAmount;
                                    String qtyUpdate = "UPDATE product SET Quantity=@qty, price=@p WHERE ProductName=@pppname AND BrandId=@bbid AND CategoriesId=@ccid;";
                                    MySqlCommand updatcom = new MySqlCommand(qtyUpdate, con);
                                    updatcom.Parameters.AddWithValue("@pppname", cmbProductName.Text);
                                    updatcom.Parameters.AddWithValue("@qty", x);
                                    updatcom.Parameters.AddWithValue("@bbid", bId);
                                    updatcom.Parameters.AddWithValue("@ccid", cId);
                                    updatcom.Parameters.AddWithValue("@p", existPrice);
                                    updatcom.ExecuteNonQuery();



                                    String pupdate = "SELECT pId FROM product WHERE ProductName=@proname  AND BrandId=@d AND CategoriesId=@i";
                                    MySqlCommand procom = new MySqlCommand(pupdate, con);
                                    procom.Parameters.AddWithValue("@proname", cmbProductName.Text);                                    
                                    procom.Parameters.AddWithValue("@d", bId);
                                    procom.Parameters.AddWithValue("@i", cId);
                                    MySqlDataReader rad = procom.ExecuteReader();
                                    rad.Read();
                                    pId=Convert.ToInt32(rad["pId"]);
                                    rad.Close();

                                    sId = idProvider(cmbSupplierName.Text, con, "supplier", "sId", "sName");


                                    String suppliedQuery = "INSERT INTO product_supplier (sId,pId,price,suppliedQuantity,date) VALUES (@sId,@pId,@price,@suppliedQuantity,@date);";
                                    MySqlCommand cmd8 = new MySqlCommand(suppliedQuery, con);
                                    cmd8.Parameters.AddWithValue("@sId", sId);
                                    cmd8.Parameters.AddWithValue("@pId", pId);
                                    cmd8.Parameters.AddWithValue("@price", txtBuyingPrice.Text);
                                    cmd8.Parameters.AddWithValue("@suppliedQuantity", enterdAmount);
                                    cmd8.Parameters.AddWithValue("@date", selectedDate);
                                    cmd8.ExecuteNonQuery();




                                }
                                else
                                {

                                    Boolean brandExist = false;
                                    String bquery = "SELECT * FROM brand WHERE brandName=@nameb;";
                                    MySqlCommand combrand = new MySqlCommand(bquery, con);
                                    combrand.Parameters.AddWithValue("@nameb", cmbBrandName.Text);
                                    MySqlDataReader reder = combrand.ExecuteReader();
                                    while (reder.Read())
                                    {
                                        brandExist = true;
                                    }
                                    if (brandExist == true)
                                    {
                                        reder.Close();
                                        String addProduct = "INSERT INTO product (ProductName, Quantity, price, BrandId, CategoriesId) VALUES (@pname, @qty, @price, @bId, @cId);";
                                        MySqlCommand addcom = new MySqlCommand(addProduct, con);
                                        addcom.Parameters.AddWithValue("@pname", cmbProductName.Text);
                                        addcom.Parameters.AddWithValue("@qty", enterdAmount);
                                        addcom.Parameters.AddWithValue("@price", enterdPrice);
                                        addcom.Parameters.AddWithValue("@bId", b);
                                        addcom.Parameters.AddWithValue("@cId", cId);
                                        addcom.ExecuteNonQuery();

                                        String pikIdProduct = "SELECT LAST_INSERT_ID();";
                                        MySqlCommand pikcom = new MySqlCommand(pikIdProduct, con);
                                        pId = Convert.ToInt32(pikcom.ExecuteScalar());

                                        sId = idProvider(cmbSupplierName.Text, con, "supplier", "sId", "sName");


                                        String suppliedQuery = "INSERT INTO product_supplier (sId,pId,price,suppliedQuantity,date) VALUES (@sId,@pId,@price,@suppliedQuantity,@date);";
                                        MySqlCommand cmd8 = new MySqlCommand(suppliedQuery, con);
                                        cmd8.Parameters.AddWithValue("@sId", sId);
                                        cmd8.Parameters.AddWithValue("@pId", pId);
                                        cmd8.Parameters.AddWithValue("@price", txtBuyingPrice.Text);
                                        cmd8.Parameters.AddWithValue("@suppliedQuantity", enterdAmount);
                                        cmd8.Parameters.AddWithValue("@date", selectedDate);
                                        cmd8.ExecuteNonQuery();


                                    }
                                    else
                                    {
                                        reder.Close();
                                        String createBrand = "INSERT INTO brand (brandName) VALUES(@brandName);";
                                        MySqlCommand createbr = new MySqlCommand(createBrand, con);
                                        createbr.Parameters.AddWithValue("@brandName", cmbBrandName.Text);
                                        createbr.ExecuteNonQuery();

                                        String lastAdd = "SELECT LAST_INSERT_ID();";
                                        MySqlCommand lastadd = new MySqlCommand(lastAdd, con);
                                        int createdId = Convert.ToInt32(lastadd.ExecuteScalar());

                                        String addProduct = "INSERT INTO product (ProductName, Quantity, price, BrandId, CategoriesId) VALUES (@cpname, @cqty, @cprice, @cbId, @ccId);";
                                        MySqlCommand addcom = new MySqlCommand(addProduct, con);
                                        addcom.Parameters.AddWithValue("@cpname", cmbProductName.Text);
                                        addcom.Parameters.AddWithValue("@cqty", enterdAmount);
                                        addcom.Parameters.AddWithValue("@cprice", enterdPrice);
                                        addcom.Parameters.AddWithValue("@cbId", createdId);
                                        addcom.Parameters.AddWithValue("@ccId", cId);
                                        addcom.ExecuteNonQuery();

                                        String pikIdProduct = "SELECT LAST_INSERT_ID();";
                                        MySqlCommand pikcom = new MySqlCommand(pikIdProduct, con);
                                        pId = Convert.ToInt32(pikcom.ExecuteScalar());

                                        sId = idProvider(cmbSupplierName.Text, con, "supplier", "sId", "sName");


                                        String suppliedQuery = "INSERT INTO product_supplier (sId,pId,price,suppliedQuantity,date) VALUES (@sId,@pId,@price,@suppliedQuantity,@date);";
                                        MySqlCommand cmd8 = new MySqlCommand(suppliedQuery, con);
                                        cmd8.Parameters.AddWithValue("@sId", sId);
                                        cmd8.Parameters.AddWithValue("@pId", pId);
                                        cmd8.Parameters.AddWithValue("@price", txtBuyingPrice.Text);
                                        cmd8.Parameters.AddWithValue("@suppliedQuantity", enterdAmount);
                                        cmd8.Parameters.AddWithValue("@date", selectedDate);
                                        cmd8.ExecuteNonQuery();

                                    }
                                }

                            }
                            else
                            {

                                Boolean catExist = false;
                                String cquery = "SELECT * FROM categories WHERE catName=@namec;";
                                MySqlCommand comcat = new MySqlCommand(cquery, con);
                                comcat.Parameters.AddWithValue("@namec", cmbCategoriesName.Text);
                                MySqlDataReader redcat = comcat.ExecuteReader();
                                while (redcat.Read())
                                {
                                    catExist = true;
                                }
                                if (catExist == true)
                                {
                                    redcat.Close();
                                    if (bId == b)
                                    {
                                        String addProduct = "INSERT INTO product (ProductName, Quantity, price, BrandId, CategoriesId) VALUES (@ccpname, @ccqty, @ccprice, @ccbId, @cccId);";
                                        MySqlCommand addcom = new MySqlCommand(addProduct, con);
                                        addcom.Parameters.AddWithValue("@ccpname", cmbProductName.Text);
                                        addcom.Parameters.AddWithValue("@ccqty", enterdAmount);
                                        addcom.Parameters.AddWithValue("@ccprice", enterdPrice);
                                        addcom.Parameters.AddWithValue("@ccbId", bId);
                                        addcom.Parameters.AddWithValue("@cccId", c);
                                        addcom.ExecuteNonQuery();

                                        String pikIdProduct = "SELECT LAST_INSERT_ID();";
                                        MySqlCommand pikcom = new MySqlCommand(pikIdProduct, con);
                                        pId = Convert.ToInt32(pikcom.ExecuteScalar());

                                        sId = idProvider(cmbSupplierName.Text, con, "supplier", "sId", "sName");


                                        String suppliedQuery = "INSERT INTO product_supplier (sId,pId,price,suppliedQuantity,date) VALUES (@sId,@pId,@price,@suppliedQuantity,@date);";
                                        MySqlCommand cmd8 = new MySqlCommand(suppliedQuery, con);
                                        cmd8.Parameters.AddWithValue("@sId", sId);
                                        cmd8.Parameters.AddWithValue("@pId", pId);
                                        cmd8.Parameters.AddWithValue("@price", txtBuyingPrice.Text);
                                        cmd8.Parameters.AddWithValue("@suppliedQuantity", enterdAmount);
                                        cmd8.Parameters.AddWithValue("@date", selectedDate);
                                        cmd8.ExecuteNonQuery();

                                    }
                                    else
                                    {

                                        /*if ()
                                        {

                                        }
                                        else
                                        {

                                        }*/
                                        redcat.Close();
                                        bId = idProvider(cmbBrandName.Text, con, "brand", "bId", "brandName");

                                        
                                       /* String createBrand = "INSERT INTO brand (brandName) VALUES(@branddName);";
                                        MySqlCommand createbr = new MySqlCommand(createBrand, con);
                                        createbr.Parameters.AddWithValue("@branddName", cmbBrandName.Text);
                                        createbr.ExecuteNonQuery();

                                        String lastAdd = "SELECT LAST_INSERT_ID();";
                                        MySqlCommand lastadd = new MySqlCommand(lastAdd, con);
                                        int createdId = Convert.ToInt32(lastadd.ExecuteScalar());*/

                                        String addProduct = "INSERT INTO product (ProductName, Quantity, price, BrandId, CategoriesId) VALUES (@cpname, @cqty, @cprice, @cbId, @ccId);";
                                        MySqlCommand addcom = new MySqlCommand(addProduct, con);
                                        addcom.Parameters.AddWithValue("@cpname", cmbProductName.Text);
                                        addcom.Parameters.AddWithValue("@cqty", enterdAmount);
                                        addcom.Parameters.AddWithValue("@cprice", enterdPrice);
                                        addcom.Parameters.AddWithValue("@cbId", bId);
                                        addcom.Parameters.AddWithValue("@ccId", c);
                                        addcom.ExecuteNonQuery();

                                        String pikIdProduct = "SELECT LAST_INSERT_ID();";
                                        MySqlCommand pikcom = new MySqlCommand(pikIdProduct, con);
                                        pId = Convert.ToInt32(pikcom.ExecuteScalar());

                                        sId = idProvider(cmbSupplierName.Text, con, "supplier", "sId", "sName");


                                        String suppliedQuery = "INSERT INTO product_supplier (sId,pId,price,suppliedQuantity,date) VALUES (@sId,@pId,@price,@suppliedQuantity,@date);";
                                        MySqlCommand cmd8 = new MySqlCommand(suppliedQuery, con);
                                        cmd8.Parameters.AddWithValue("@sId", sId);
                                        cmd8.Parameters.AddWithValue("@pId", pId);
                                        cmd8.Parameters.AddWithValue("@price", txtBuyingPrice.Text);
                                        cmd8.Parameters.AddWithValue("@suppliedQuantity", enterdAmount);
                                        cmd8.Parameters.AddWithValue("@date", selectedDate);
                                        cmd8.ExecuteNonQuery();

                                    }

                                }
                                else
                                {
                                    redcat.Close();
                                    String createCat = "INSERT INTO categories (catName) VALUES(@catName);";
                                    MySqlCommand createca = new MySqlCommand(createCat, con);
                                    createca.Parameters.AddWithValue("@catName", cmbCategoriesName.Text);
                                    createca.ExecuteNonQuery();

                                    String lastAddc = "SELECT LAST_INSERT_ID();";
                                    MySqlCommand lastaddc = new MySqlCommand(lastAddc, con);
                                    int createdIdc = Convert.ToInt32(lastaddc.ExecuteScalar());

                                    if (bId == b)
                                    {
                                        String addProduct = "INSERT INTO product (ProductName, Quantity, price, BrandId, CategoriesId) VALUES (@ccpname, @ccqty, @ccprice, @ccbId, @cccId);";
                                        MySqlCommand addcom = new MySqlCommand(addProduct, con);
                                        addcom.Parameters.AddWithValue("@ccpname", cmbProductName.Text);
                                        addcom.Parameters.AddWithValue("@ccqty", enterdAmount);
                                        addcom.Parameters.AddWithValue("@ccprice", enterdPrice);
                                        addcom.Parameters.AddWithValue("@ccbId", bId);
                                        addcom.Parameters.AddWithValue("@cccId", createdIdc);
                                        addcom.ExecuteNonQuery();

                                        String pikIdProduct = "SELECT LAST_INSERT_ID();";
                                        MySqlCommand pikcom = new MySqlCommand(pikIdProduct, con);
                                        pId = Convert.ToInt32(pikcom.ExecuteScalar());

                                        sId = idProvider(cmbSupplierName.Text, con, "supplier", "sId", "sName");


                                        String suppliedQuery = "INSERT INTO product_supplier (sId,pId,price,suppliedQuantity,date) VALUES (@sId,@pId,@price,@suppliedQuantity,@date);";
                                        MySqlCommand cmd8 = new MySqlCommand(suppliedQuery, con);
                                        cmd8.Parameters.AddWithValue("@sId", sId);
                                        cmd8.Parameters.AddWithValue("@pId", pId);
                                        cmd8.Parameters.AddWithValue("@price", txtBuyingPrice.Text);
                                        cmd8.Parameters.AddWithValue("@suppliedQuantity", enterdAmount);
                                        cmd8.Parameters.AddWithValue("@date", selectedDate);
                                        cmd8.ExecuteNonQuery();

                                    }
                                    else
                                    {
                                        redcat.Close();
                                        String createBrand = "INSERT INTO brand (brandName) VALUES(@branddName);";
                                        MySqlCommand createbr = new MySqlCommand(createBrand, con);
                                        createbr.Parameters.AddWithValue("@branddName", cmbBrandName.Text);
                                        createbr.ExecuteNonQuery();

                                        String lastAdd = "SELECT LAST_INSERT_ID();";
                                        MySqlCommand lastadd = new MySqlCommand(lastAdd, con);
                                        int createdId = Convert.ToInt32(lastadd.ExecuteScalar());

                                        String addProduct = "INSERT INTO product (ProductName, Quantity, price, BrandId, CategoriesId) VALUES (@cpname, @cqty, @cprice, @cbId, @ccId);";
                                        MySqlCommand addcom = new MySqlCommand(addProduct, con);
                                        addcom.Parameters.AddWithValue("@cpname", cmbProductName.Text);
                                        addcom.Parameters.AddWithValue("@cqty", enterdAmount);
                                        addcom.Parameters.AddWithValue("@cprice", enterdPrice);
                                        addcom.Parameters.AddWithValue("@cbId", createdId);
                                        addcom.Parameters.AddWithValue("@ccId", createdIdc);
                                        addcom.ExecuteNonQuery();

                                        String pikIdProduct = "SELECT LAST_INSERT_ID();";
                                        MySqlCommand pikcom = new MySqlCommand(pikIdProduct, con);
                                        pId = Convert.ToInt32(pikcom.ExecuteScalar());

                                        sId = idProvider(cmbSupplierName.Text, con, "supplier", "sId", "sName");


                                        String suppliedQuery = "INSERT INTO product_supplier (sId,pId,price,suppliedQuantity,date) VALUES (@sId,@pId,@price,@suppliedQuantity,@date);";
                                        MySqlCommand cmd8 = new MySqlCommand(suppliedQuery, con);
                                        cmd8.Parameters.AddWithValue("@sId", sId);
                                        cmd8.Parameters.AddWithValue("@pId", pId);
                                        cmd8.Parameters.AddWithValue("@price", txtBuyingPrice.Text);
                                        cmd8.Parameters.AddWithValue("@suppliedQuantity", enterdAmount);
                                        cmd8.Parameters.AddWithValue("@date", selectedDate);
                                        cmd8.ExecuteNonQuery();

                                    }
                                }

                            }
                        }
                        else
                        {

                            reader.Close();

                            cId = idProvider(cmbCategoriesName.Text, con, "categories", "id", "catName");
                            sId = idProvider(cmbSupplierName.Text, con, "supplier", "sId", "sName");
                            bId = idProvider(cmbBrandName.Text, con, "brand", "bId", "brandName");

                            String productQuery = "INSERT INTO product (ProductName,Quantity,price,BrandId,CategoriesId) VALUES (@pname,@qty,@price,@brand,@category);";
                            MySqlCommand cmd4 = new MySqlCommand(productQuery, con);
                            cmd4.Parameters.AddWithValue("@pname", cmbProductName.Text);
                            cmd4.Parameters.AddWithValue("@qty", txtQuantity.Text);
                            cmd4.Parameters.AddWithValue("@price", enterdPrice);
                            cmd4.Parameters.AddWithValue("@brand", bId);
                            cmd4.Parameters.AddWithValue("@category", cId);
                            cmd4.ExecuteNonQuery();
                            cmbProductName.Items.Add(cmbProductName.Text);
                            cmbProductSearch.Items.Add(cmbProductName.Text);

                            String query4 = "SELECT pId FROM product WHERE ProductName=@pname;";
                            MySqlCommand cmd7 = new MySqlCommand(query4, con);
                            cmd7.Parameters.AddWithValue("@pname", cmbProductName.Text);
                            pId = Convert.ToInt32(cmd7.ExecuteScalar());

                            String suppliedQuery = "INSERT INTO product_supplier (spId,sId,pId,price,suppliedQuantity,date) VALUES (NULL,@sId,@pId,@price,@suppliedQuantity,@date);";
                            MySqlCommand cmd8 = new MySqlCommand(suppliedQuery, con);
                            cmd8.Parameters.AddWithValue("@sId", sId);
                            cmd8.Parameters.AddWithValue("@pId", pId);
                            cmd8.Parameters.AddWithValue("@price", txtBuyingPrice.Text);
                            cmd8.Parameters.AddWithValue("@suppliedQuantity", txtQuantity.Text);
                            cmd8.Parameters.AddWithValue("@date", selectedDate);
                            cmd8.ExecuteNonQuery();




                            MessageBox.Show("you have added new prodcut to your supermarket", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        }
                        product_supplierTable();
                       
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        con.Close();
                    }
                    dgvSuppliedProduct.Show();




                    cmbProductName.Text = "";
                    cmbSupplierName.Text = "";
                    cmbCategoriesName.Text = "";
                    cmbBrandName.Text = "";
                    txtQuantity.Text = "";
                    txtBuyingPrice.Text = "";
                    dtpSuppliedDate.Text = "";
                }
                
            }
            
        }
                           
        public int idProvider(String boxName, MySqlConnection con, String tableName, String idColumn, String nameColumn)
        {
            Boolean check = false;
            int id = 0;
            String cat = "SELECT " + idColumn + " FROM " + tableName + " WHERE " + nameColumn + "=@cname;";
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
                String newc = "INSERT INTO " + tableName + " (" + nameColumn + ") VALUES (@catName);";
                MySqlCommand ncomc = new MySqlCommand(newc, con);
                ncomc.Parameters.AddWithValue("@catName", boxName);
                ncomc.ExecuteNonQuery();

                String lastc = "SELECT LAST_INSERT_ID();";
                MySqlCommand lc = new MySqlCommand(lastc, con);
                id = Convert.ToInt32(lc.ExecuteScalar());
                if (String.Equals(tableName, "categories"))
                {
                    cmbCategoriesName.Items.Add(boxName);
                }
                else if (String.Equals(tableName, "supplier"))
                {
                    cmbSupplierSearch.Items.Add(boxName);
                    cmbSupplierName.Items.Add(boxName);
                }
                else if (String.Equals(tableName, "brand"))
                {
                    cmbBrandName.Items.Add(boxName);
                }
                else
                {
                    
                }
            }

            return id;
        }
        private void addDateToCombo()
        {
            String d = "SELECT CONVERT(DATE, date_column) AS date_only FROM your_table_name;";
            MySqlConnection con = null;
            try
            {
                con = DataBase.connectDB();
                MySqlCommand co = new MySqlCommand(d, con);
                MySqlDataReader rrr = co.ExecuteReader();
                while (rrr.Read())
                {

                    cmbDateSearch.Items.Add(rrr.GetDateTime(0));
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void iBtnProductsearch_Click(object sender, EventArgs e)
        {
            
            amountOfRow=searchTable("product", "ProductName", cmbProductSearch.Text);
            lblrow.Text = amountOfRow.ToString();


        }
        private void iBtnSupplierSearch_Click(object sender, EventArgs e)
        {
            amountOfRow=searchTable("supplier", "sName", cmbSupplierSearch.Text);
            lblrow.Text = amountOfRow.ToString();
        }
        private void iBtnDateSearch_Click(object sender, EventArgs e)
        {
            if (cmbDateSearch.Text == "Date")
            {
                MessageBox.Show("plese enter the date ");
            }
            else
            {
                DateTime date = DateTime.Parse(cmbDateSearch.Text);
                amountOfRow = searchDate("product_supplier", "date", date);
                lblrow.Text = amountOfRow.ToString();
                Combo.addComboDate("product_supplier", cmbDateSearch, "date");

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
                dgvSuppliedProduct.DataSource = dataTable;


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


        private int searchTable(String table, String column, String comboValue)
        {
            MySqlConnection con = null;
            String c = "";
            int rows=0;
            if (string.Equals(table, "supplier"))
            {
                c = "s";
            }
            else if (String.Equals(table, "product"))
            {
                c = "p";
            }
            else if (String.Equals(table, "product_supplier"))
            {
                c = "sp";
                
            }
            else
            {
                MessageBox.Show("please enter the right info you want to see the table","ERROR",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            }
            
            try
            {
                String suppliedTable = "SELECT sp.spId, p.pId, p.ProductName, p.price, p.Quantity, s.sName, date FROM" +
                                       " product_supplier sp JOIN product p ON sp.pId = p.pId" +
                                       " JOIN supplier s ON sp.sId = s.sId WHERE "+c+"."+column+"=@x;";
                con = DataBase.connectDB();
                con.Open();

                MySqlCommand command = new MySqlCommand(suppliedTable, con);
                command.Parameters.AddWithValue("@x", comboValue);


                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvSuppliedProduct.DataSource = dataTable;

                
                String row = "SELECT COUNT(*) FROM" +
                                       " product_supplier sp JOIN product p ON sp.pId = p.pId" +
                                       " JOIN supplier s ON sp.sId = s.sId WHERE " + c + "." + column + "=@y;";
                MySqlCommand com = new MySqlCommand(row, con);
                com.Parameters.AddWithValue("@y",comboValue);
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

        private void iBtnDeleteProduct_Click(object sender, EventArgs e)
        {

            MySqlConnection con = null;
            try
            {
                con = DataBase.connectDB();
                con.Open();
                if (txtIdDelete.Text=="")
                {
                    MessageBox.Show("First select the history you want to delete", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to delete this product supplication history?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        String delete = "DELETE sp FROM" +
                                 " product_supplier sp JOIN product p ON sp.pId = p.pId" +
                                 " JOIN supplier s ON sp.sId = s.sId WHERE sp.spId=@id;";
                        MySqlCommand dcom = new MySqlCommand(delete, con);
                        dcom.Parameters.AddWithValue("@id", txtIdDelete.Text);
                        dcom.ExecuteNonQuery();
                        MessageBox.Show("History cleared successfully","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }

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

            product_supplierTable();

        }
        private void dgvSuppliedProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int productid;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvSuppliedProduct.Rows[e.RowIndex];

                cmbProductName.Text = row.Cells["ProductName"].Value.ToString();
                cmbSupplierName.Text = row.Cells["sName"].Value.ToString();
                txtQuantity.Text = row.Cells["suppliedQuantity"].Value.ToString();
                txtBuyingPrice.Text = row.Cells["price"].Value.ToString();
                txtIdDelete.Text = row.Cells["spId"].Value.ToString();
                productid =Convert.ToInt32(row.Cells["pId"].Value.ToString());

                String pcb="SELECT b.brandName, c.catName FROM" +
                                 " product p JOIN brand b ON p.BrandId = b.bId" +
                                 " JOIN categories c ON p.CategoriesId = c.id WHERE pId=@pid;";
                MySqlConnection con = DataBase.connectDB();
                con.Open();
                MySqlCommand pcbcom = new MySqlCommand(pcb, con);
                pcbcom.Parameters.AddWithValue("@pid", productid);
                MySqlDataReader rrd = pcbcom.ExecuteReader();
                rrd.Read();
                cmbBrandName.Text=rrd["brandName"].ToString();
                cmbCategoriesName.Text= rrd["catName"].ToString();
                

            }
        }

        private void cmbProductName_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)&&e.KeyChar!=' '){
                e.Handled = true;// Prevent the character from being entered
            }
            
        }

        private void cmbSupplierName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;// Prevent the character from being entered
            }
        }

        private void cmbCategoriesName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;// Prevent the character from being entered
            }
        }

        private void cmbBrandName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;// Prevent the character from being entered
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true; // Prevent the character from being entered
            }
        }

        private void txtBuyingPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true; // Prevent the character from being entered
            }
        }

        private void txtBuyingPrice_TextChanged(object sender, EventArgs e)
        {
            string input = txtBuyingPrice.Text;

            // Check if dot ('.') appears more than once
            if (input.Split('.').Length > 2)
            {
                txtBuyingPrice.Text = input.Substring(0, input.Length - 1); // Remove the extra dot
                txtBuyingPrice.SelectionStart = txtBuyingPrice.Text.Length; // Set the cursor at the end of the text
            }
        }
    }
}
