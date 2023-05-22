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
    public partial class AllProjectsOverview_Form : Form
    {

        //Fields
        private BLL.Facader.CustomerService customerService { get; set; }

        public AllProjectsOverview_Form()
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
                var customer = selectedRow.DataBoundItem;
                ICustomer selectedCustomer = (ICustomer)customer;


                //Hides this childform and opens another one on top of this. 
                CustomerInfo customerInfo = new CustomerInfo(selectedCustomer);
                customerInfo.Show();
                this.Hide();
            }

        }

        private void bt_AddCustomer_Click(object sender, EventArgs e)
        {
            SignUpCustomer_Form sign = new SignUpCustomer_Form();
            sign.Show();
            this.Hide();
        }
    }

}

