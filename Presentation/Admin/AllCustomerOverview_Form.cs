using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Windows.Forms;
using Abstraction.Interfaces;
using BLL.Models;
using Presentation.Consultant;
using UI.Costumer;

namespace Presentation.Customer
{
    /// <summary>
    /// Marcel
    /// </summary>

    public partial class AllCustomerOverview_Form : Form
    {
        //Fields
        private BLL.Facader.CustomerService customerService { get; set; }

        //Constructor
        public AllCustomerOverview_Form()
        {
            InitializeComponent();
            this.customerService = new BLL.Facader.CustomerService(new BLL.Services.CustomerService());
            UpdateCustomerOnUI();
            LoadCustomerData();

        }

        //Method which is called to load the customer data from the database
        private void LoadCustomerData()
        {
            List<ICustomer> customers = this.customerService.GetAllCustomers();
            dgv_AllCustomersOverview.DataSource = customers;
        }

        //method which is called to update the customer on the UI
        private void UpdateCustomerOnUI()
        {
            dgv_AllCustomersOverview.DataSource = customerService.GetAllCustomers();
            dgv_AllCustomersOverview.Refresh();
        }

        /// <summary>
        /// Button which takes the users selected Customer as a row and opens a new form with the Customer information.
        /// It takes the selected Customer and sends it to the new form as a parameter called "selectedCustomer"
        /// </summary>
        /// <param name="selectedCustomer"></param> - Selected Customer from the datagridview
        private void bt_ViewCustomer_Click(object sender, EventArgs e)
        {
            if (dgv_AllCustomersOverview.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_AllCustomersOverview.SelectedRows[0];
                var customer = selectedRow.DataBoundItem;
                ICustomer selectedCustomer = (ICustomer)customer;

                //Hides this childform and opens another one on top of this. 
                CustomerInfo customerInfo = new CustomerInfo(selectedCustomer);
                customerInfo.Show();
                this.Hide();
            }

        }

        //Button logic for creating a new Customer. Redirects the user to the signup Customer form from the 
        // Customer folder in the UI project for when a new Customer is to sign up.
        private void bt_AddCustomer_Click(object sender, EventArgs e)
        {
            SignUpCustomer_Form sign = new SignUpCustomer_Form();
            sign.Show();
            this.Hide();
        }
    }

}

