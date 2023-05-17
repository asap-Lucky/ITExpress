using DAL.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using BLL.Facader;
using System.Runtime.Remoting;
using BLL.Services;
using Abstraction.Interfaces;

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
                BLL.Models.Customer customerId = (BLL.Models.Customer)selectedRow.DataBoundItem;

                //Put argument in constructor
                CustomerInfo customerInfo = new CustomerInfo();
                customerInfo.Show();
                this.Hide();
            }
        }
    }
}
