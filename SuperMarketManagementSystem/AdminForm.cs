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
    public partial class AdminForm : Form
    {
        public AdminForm(String name)
        {
            InitializeComponent();
            lblAdminName.Text = name;
            lblTitleOfFrame.Text = iBtnDashboard.Text;
            Dashboard board = new Dashboard();
            formMerger(board);
            manageVisibility();
        }

        private void lblTitleOfFrame_Click(object sender, EventArgs e)
        {

        }
        private void manageVisibility()
        {
            pnlProductSubMenu.Visible = false;
            pnlCategoriesSubMenu.Visible = false;
            pnlBrandSubMenu.Visible = false;
            pnlCahsierSubMenu.Visible = false;

        }
        
        private void showMenu(Panel panel)
        {
            if (panel.Visible == true)
            {
                panel.Visible = false;
            }
            else
            {
                manageVisibility();
                panel.Visible = true;
            }
        }

        private void iBtnProduct_Click(object sender, EventArgs e)
        {
            showMenu(pnlProductSubMenu);
            lblTitleOfFrame.Text = iBtnProduct.Text;
        }

        private void iBtnCategories_Click(object sender, EventArgs e)
        {
            showMenu(pnlCategoriesSubMenu);
            lblTitleOfFrame.Text = iBtnCategories.Text;
        }

        private void iBtnBrand_Click(object sender, EventArgs e)
        {
            showMenu(pnlBrandSubMenu);
            lblTitleOfFrame.Text = iBtnBrand.Text;
        }

        private void iBtnCashier_Click(object sender, EventArgs e)
        {
            showMenu(pnlCahsierSubMenu);
            lblTitleOfFrame.Text = iBtnCashier.Text;
        }

        private void iBtnDashboard_Click(object sender, EventArgs e)
        {
            lblTitleOfFrame.Text = iBtnDashboard.Text;
            Dashboard board = new Dashboard();
            formMerger(board);

        }

        private void iBtnProductList_Click(object sender, EventArgs e)
        {
            lblTitleOfFrame.Text = iBtnProductList.Text;
            Product_List list = new Product_List();
            formMerger(list);
        }

        private void iBtnManageProduct_Click(object sender, EventArgs e)
        {
            lblTitleOfFrame.Text = iBtnManageProduct.Text;
            Add_Products product = new Add_Products();
            formMerger(product);
        }

        

        private void iBtnManageCategories_Click(object sender, EventArgs e)
        {
            lblTitleOfFrame.Text = iBtnManageCategories.Text;
            ManageCategories categories = new ManageCategories();
            formMerger(categories);
        }

        

        private void iBtnManageBrand_Click(object sender, EventArgs e)
        {
            lblTitleOfFrame.Text = iBtnManageBrand.Text;
            ManageBrand brand = new ManageBrand();
            formMerger(brand);

        }

        private void iBtnCashierList_Click(object sender, EventArgs e)
        {
            lblTitleOfFrame.Text = iBtnSellTransactionList.Text;
            Sell_Transaction_list stl = new Sell_Transaction_list();
            formMerger(stl);          
             
        }

        private void iBtnManageCashier_Click(object sender, EventArgs e)
        {
            lblTitleOfFrame.Text = iBtnManageCashier.Text;
            ManageAccounts cashier = new ManageAccounts();
            formMerger(cashier);
        }
        List<Form> forms = new List<Form>();
        private void formMerger(Form form)
        {
            if (forms.Count == 0)
            { forms.Add(form); }
            else
            {
                Form f = forms.ElementAt(forms.Count - 1);
                f.Hide();
                forms.Add(form);
            }
            form.TopLevel = false;
            //form.TopMost = true;
            form.FormBorderStyle = FormBorderStyle.None;
            pnlMergedForm.Controls.Add(form);
            form.Show();
            this.Dock = DockStyle.Fill;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void iBtnSupplier_Click(object sender, EventArgs e)
        {
            lblTitleOfFrame.Text = iBtnSupplier.Text;
            ManageSupplier supplier = new ManageSupplier();
            formMerger(supplier);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            lblTitleOfFrame.Text = iBtnCriticalProducts.Text;
            Critical_Prodcuts cProducts = new Critical_Prodcuts();
            formMerger(cProducts);
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
