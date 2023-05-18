using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Abstraction.Interfaces;

namespace Presentation.Customer
{
    public partial class EditCustomerInfo : Form
    {
        private ICustomer SelectedCustomer { get; set; }

        private BLL.Services.CustomerService customerService { get; set; }

        public EditCustomerInfo(ICustomer selectedCustomer)
        {
            InitializeComponent();
            SelectedCustomer = selectedCustomer;
            InitialiseControl();
            
        }


        public void InitialiseControl()
        {
            tb_firstName.Text = SelectedCustomer.FirstName;
            tb_lastName.Text = SelectedCustomer.LastName;
            tb_address.Text = SelectedCustomer.Address;
            tb_city.Text = SelectedCustomer.City;
            tb_phoneNumber.Text = SelectedCustomer.PhoneNumber.ToString();
            tb_email.Text = SelectedCustomer.Email;
            tb_zipCode.Text = SelectedCustomer.ZipCode.ToString();
            tb_userName.Text = SelectedCustomer.Login;
            tb_passWord.Text = SelectedCustomer.Password;

            // Code that retrives the closed projects for the customer 
            // Code that retrives the current projects for the customer
        }

        private void bt_SaveChanges_Click(object sender, EventArgs e)
        {
            customerService = new BLL.Services.CustomerService();
            SaveChanges();
            MessageBox.Show("Your changes have now been saved", "Successfully changed", MessageBoxButtons.OK);
            this.Hide();
        }

        private void SaveChanges()
        {
            // Check if the values of the zipcode and phonenumber can be converted to an integer.
            bool CanParseZipcode = int.TryParse(tb_zipCode.Text, out int zipcode);
            bool CanParsePhonenumber = int.TryParse(tb_phoneNumber.Text, out int phonenumber);


            // Check if the zipcode only consists of numbers.
            if (!CanParseZipcode)
            {
                MessageBox.Show("Please only use numbers for the zipcode!", "Invalid Zipcode!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Check if the phonenumber only consists of numbers.
            else if (!CanParsePhonenumber)
            {
                MessageBox.Show("Please only use numbers for the phonenumber!", "Invalid Phonenumber!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                // 
                if (string.IsNullOrEmpty(tb_firstName.Text) && string.IsNullOrEmpty(tb_lastName.Text) && string.IsNullOrEmpty(tb_address.Text) && string.IsNullOrEmpty(tb_city.Text) && string.IsNullOrEmpty(tb_email.Text) && string.IsNullOrEmpty(tb_phoneNumber.Text) && string.IsNullOrEmpty(tb_userName.Text) && string.IsNullOrEmpty(tb_passWord.Text) && string.IsNullOrEmpty(tb_zipCode.Text))
                {
                    MessageBox.Show("Please fill out all the textboxes before procedding further", "Missing data",  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    SelectedCustomer.FirstName = tb_firstName.Text;
                    SelectedCustomer.LastName = tb_lastName.Text;
                    SelectedCustomer.Address = tb_address.Text;
                    SelectedCustomer.City = tb_city.Text;
                    SelectedCustomer.Email = tb_email.Text;
                    SelectedCustomer.Login = tb_userName.Text;
                    SelectedCustomer.Password = tb_passWord.Text;
                    SelectedCustomer.ZipCode = zipcode;
                    SelectedCustomer.PhoneNumber = phonenumber;

                    customerService.EditCustomer(SelectedCustomer);
                }


            }
        }
    }
}
