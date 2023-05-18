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

namespace Presentation.Customer
{
    public partial class CustomerInfo : Form
    {
        public Form currentChildForm;
        
        private AdminsOverviewWindow_Form parentForm;

        private ICustomer selectedCustomer { get; set; }

        public CustomerInfo(ICustomer selectedCustomer)
        {
            InitializeComponent();
            this.selectedCustomer = selectedCustomer;
            GetCustomerData();
        } 

        // This method retrieves the data for the customer choosen in the "AllCustomerOverview_Form"
        private void GetCustomerData()
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
                // User clicked Yes, perform the desired action
            }
            else if (result == DialogResult.No)
            {
                
            }
        }

        private void bt_GoBack_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            OpenChildForm(new AllCustomerOverview_Form());
        }

        public void OpenChildForm(Form childform)
        {
            if (currentChildForm != null)
            {
                // Opems only one instance of the form
                currentChildForm.Close();
            }
            currentChildForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            //ParentForm.panelAdminDesktop.Controls.Add(childform);
            //ParentForm.panelAdminDesktop.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }
    }
}
