using Abstraction.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Customer
{
    public partial class CustomerInfo : Form
    {
        // Remember to put "BLL.Models.Customer customerId" in the constructor 
        public CustomerInfo()
        {
            InitializeComponent();
        }

        // This method retrieves the data for the customer choosen in the "AllCustomerOverview_Form"
        private void GetCustomerData()
        {
            tb_firstName.Text = string.Empty;
            tb_lastName.Text = string.Empty;
            tb_address.Text = string.Empty;
            tb_city.Text = string.Empty;
            tb_phoneNumber.Text = string.Empty;
            tb_email.Text = string.Empty;
            tb_zipCode.Text = string.Empty;
            tb_userName.Text = string.Empty;
            tb_passWord.Text = string.Empty;
        }

        // This button deletes the choosen user
        private void bt_DeleteCustomer_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you wish to delete the selected customer?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // User clicked Yes, perform the desired action
            }
            else if (result == DialogResult.No)
            {
                
            }
        }
    }
}
