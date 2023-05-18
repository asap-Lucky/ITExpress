using Abstraction.Interfaces;
using Presentation.Consultant;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentation.Admin;
using BLL.Services;

namespace Presentation.Customer
{
    public partial class CustomerInfo : Form
    {

        private Abstraction.Interfaces.ICustomer selectedCustomer { get; set; }

        private BLL.Services.CustomerService customerService { get; set; }

        public CustomerInfo(ICustomer selectedCustomer)
        {
            InitializeComponent();
            this.selectedCustomer = selectedCustomer;
            GetCustomerData();
        } 

        // This method retrieves the data for the customer choosen in the "AllCustomerOverview_Form"
        public void GetCustomerData()
        {
            tb_firstName.Text = selectedCustomer.FirstName;
            tb_lastName.Text = selectedCustomer.LastName;
            tb_address.Text = selectedCustomer.Address;
            tb_city.Text = selectedCustomer.City;
            tb_phoneNumber.Text = selectedCustomer.PhoneNumber.ToString();
            tb_email.Text = selectedCustomer.Email;
            tb_zipCode.Text = selectedCustomer.ZipCode.ToString();
            tb_userName.Text = selectedCustomer.Login;
            tb_passWord.Text = selectedCustomer.Password;

            // Code that retrives the closed projects for the customer 
            // Code that retrives the current projects for the customer
        }

        // This button deletes the choosen user
        private void bt_DeleteCustomer_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you wish to delete the selected customer?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                customerService = new BLL.Services.CustomerService();
                customerService.DeleteCustomer(selectedCustomer);
                this.Hide();
            }
            else if (result == DialogResult.No)
            {
                
            }
        }

        private void bt_GoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bt_EditCustomerInfo_Click(object sender, EventArgs e)
        {
            //Hides this childform and opens another one on top of this
            EditCustomerInfo editCustomerInfo = new EditCustomerInfo(selectedCustomer);//<-- Remember to take the selectedCustomer variable and put it in the constructor on the EditCustomerInfo_Form.
            editCustomerInfo.Show();
            this.Hide();
        }
    }
}
