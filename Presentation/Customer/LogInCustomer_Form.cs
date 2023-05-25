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
    /// <summary>
    /// Djoan
    /// </summary>
    public partial class LogInCustomer_Form : Form
    {
        // CustomerService object from the BLL namespace
        private BLL.Services.CustomerService customerService = new BLL.Services.CustomerService();

        public LogInCustomer_Form()
        {
            InitializeComponent();
        }

        // Event handler for the "Go Back" button
        private void bt_GoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Event handler for the "Sign Up as Customer" link label
        private void ll_SignUpAsCostumer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            // Open the SignUpCustomer_Form for customer sign-up
            SignUpCustomer_Form signInCostumer_Form = new SignUpCustomer_Form();
            signInCostumer_Form.ShowDialog();
            this.Show();
        }

        // Event handler for the "Log In as Customer" button
        private void bt_LogInAsCostumer_Click(object sender, EventArgs e)
        {
            // This method of verifying logins is vulnerable to SQL Injections
            // Could be fixed with parameterized queries or an ORM framework like Entity Framework.

            // Validate customer's login credentials
            if (customerService.IsValidCustomer(tb_userNameCustomer.Text, tb_passWordCustomer.Text))
            {
                // Get the customer object
                Abstraction.Interfaces.ICustomer customer = (Abstraction.Interfaces.ICustomer)customerService.GetCustomer(tb_userNameCustomer.Text, tb_passWordCustomer.Text);

                // Store the customer object in a CustomerSingleton instance for future use
                BLL.Singleton.CustomerSingleton customerSingleton = BLL.Singleton.CustomerSingleton.Instance();
                customerSingleton.User = customer;

                // Hide the current form
                this.Hide();

                // Open the CustomerOverviewWindow_Form
                CustomerOverviewWindow_Form overViewWindow_Form = new CustomerOverviewWindow_Form();
                overViewWindow_Form.ShowDialog();

                // Show the current form again when the overview form is closed
                this.Show();

                // Clear the username and password fields
                tb_passWordCustomer.Clear();
                tb_userNameCustomer.Clear();
            }
            else
            {
                // Display an error message for invalid credentials
                MessageBox.Show("The credentials entered do not match any Customer, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
