using BLL.Services;
using Presentation.Customer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Costumer;

namespace UI.All
{
    public partial class LogInAdmin_Form : Form
    {
        
        private BLL.Services.CustomerService customerService = new BLL.Services.CustomerService();

        public LogInAdmin_Form()
        {
            InitializeComponent();
        }
        /*
        private void bt_GoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ll_SignUpAsCostumer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignUpCustomer_Form signInCostumer_Form = new SignUpCustomer_Form();
            signInCostumer_Form.ShowDialog();
            this.Show();
        }

        private void bt_LogInAsCostumer_Click(object sender, EventArgs e)
        {
            This method of verifying logins is vulnerable to SQL Injections, could be fixed with parameterized queries or an ORM framework like Entity Framework.
            if (customerService.IsValidCustomer(tb_userNameCustomer.Text, tb_passWordCustomer.Text))
            {
                Abstraction.Interfaces.ICustomer customer = (Abstraction.Interfaces.ICustomer) customerService.GetCustomer(tb_userNameCustomer.Text, tb_passWordCustomer.Text);

                this.Hide();
                CustomerOverviewWindow_Form overViewWindow_Form = new CustomerOverviewWindow_Form(customer);
                overViewWindow_Form.ShowDialog();
                this.Show();
                tb_passWordCustomer.Clear();
                tb_userNameCustomer.Clear();
            }
            else
            {
                MessageBox.Show("The credentials entered does not match any Customer, try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        */
    }
}

