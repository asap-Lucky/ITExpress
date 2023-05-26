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
    /// <summary>
    /// Marcel
    /// </summary>

    public partial class CustomerInfo : Form
    {
        //Fields
        private Abstraction.Interfaces.ICustomer selectedCustomer { get; set; }
        private BLL.Services.CustomerService customerService { get; set; }

        //Constructor which takes the parameter selectedConsultant from the AllConsultantOverview_Form
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
        }

        /// <summary>
        /// Delete button which takes the parameter selectedCustomer and deletes it from the database using a call
        /// to the BLL.Services.CustomerService.DeleteCustomer method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="selectedCustomer"></param> - Viewed Customer from the datagridview
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


        //Button which takes the user back to the previous form
        private void bt_GoBack_Click(object sender, EventArgs e)
        {
            this.Close();

        }


        /// <summary>
        /// Edit button which takes the users selectedCustomer as a row and opens a new form with the editable information.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="selectedCustomer"></param> - Viewed Customer from the datagridview
        private void bt_EditCustomerInfo_Click(object sender, EventArgs e)
        {
            //Hides this childform and opens another one on top of this
            EditCustomerInfo editCustomerInfo = new EditCustomerInfo(selectedCustomer);
            editCustomerInfo.Show();
            this.Hide();
        }
    }
}
