using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Abstraction.Interfaces;
using BLL.Models;

namespace Presentation.Customer
{
    public partial class AllCustomerOverview_Form : Form
    {
        private BLL.Facader.CustomerService customerService { get; set; }

        public AllCustomerOverview_Form()
        {
            InitializeComponent();
            this.customerService = new BLL.Facader.CustomerService(new BLL.Services.CustomerService());
            UpdateCustomerOnUI();
            LoadCustomerData();
            
        }

        private void LoadCustomerData()
        {
            List<ICustomer> customers = this.customerService.GetAllCustomers();
            dgv_AllCustomersOverview.DataSource = customers;
        }

        private void UpdateCustomerOnUI()
        {
            dgv_AllCustomersOverview.DataSource = customerService.GetAllCustomers();
            dgv_AllCustomersOverview.Refresh();
        }
        
        private void bt_ViewCustomer_Click(object sender, EventArgs e)
        {   
            if (dgv_AllCustomersOverview.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_AllCustomersOverview.SelectedRows[0];
                var selectedCustomer = selectedRow.DataBoundItem;
                BLL.Models.Customer newCustomer = new BLL.Models.Customer();
                

                //Put argument in constructor
                CustomerInfo customerInfo = new CustomerInfo();
                customerInfo.Show();
                this.Hide();
            }
        }
    }
}
