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
    public partial class Seller : Form
    {
        public static String sellerName;
        public Seller(String loginName)
        {
            InitializeComponent();
            lblTitleOfFrame.Text = btnSell.Text;        

            sellerName = loginName;
            lblSellerName.Text = sellerName;
            Sell se = new Sell();
            formMerger(se);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
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
            form.FormBorderStyle = FormBorderStyle.None;
            pnlMergedForm.Controls.Add(form);
            form.Show();
            this.Dock = DockStyle.Fill;
        }

        
        
        
        private void iBtnProfile_Click(object sender, EventArgs e)
        {
            lblTitleOfFrame.Text = iBtnProfile.Text;
            Profile pr = new Profile();
            formMerger(pr);

        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            lblTitleOfFrame.Text = btnSell.Text;
            Sell se = new Sell();
            formMerger(se);
        }

        private void Seller_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

       
    }
}
