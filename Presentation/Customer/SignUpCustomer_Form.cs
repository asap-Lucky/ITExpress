using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Models;

namespace UI.Costumer
{
    public partial class SignUpCustomer_Form : Form
    {
        // Create an interface of type ICustomer.
        public Abstraction.Interfaces.ICustomer MyCustomer { get; set; }

        // Create an instance of the CustomerService class to use its methods.
        BLL.Services.CustomerService CustomerService = new BLL.Services.CustomerService();

        public SignUpCustomer_Form()
        {
            InitializeComponent();

            // Initialize MyCustomer with a new instance of the Customer class.
            MyCustomer = new Customer();
        }

        private void bt_GoBack_Click(object sender, EventArgs e)
        {
            // Close the current window.
            this.Close();
        }

        private void RegisterCustomer()
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
            // Check if the email and repeated email match.
            else if (tb_email.Text != tb_repeatEmail.Text)
            {
                MessageBox.Show("The emails did not match, please type it out again", "Email didnt match!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Check if the password and repeated password match.
            else if (tb_passWord.Text != tb_RepeatPassWord.Text)
            {
                MessageBox.Show("The passwords did not match, please type it out again", "Password didnt match!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // If all checks are passed, set the values of MyCustomer properties and add it to the database.
            else
            {
                MyCustomer.FirstName = tb_firstName.Text;
                MyCustomer.LastName = tb_lastName.Text;
                MyCustomer.Address = tb_address.Text;
                MyCustomer.ZipCode = zipcode;
                MyCustomer.PhoneNumber = phonenumber;
                MyCustomer.Email = tb_email.Text;
                MyCustomer.Login = tb_userName.Text;
                MyCustomer.Password = tb_passWord.Text;
                MyCustomer.City = tb_City.Text;

                // Call the AddCustomer method of the CustomerService object and pass in MyCustomer object.
                CustomerService.AddCustomer(MyCustomer);
            }
        }

        private void bt_SignUpAsCostumer_Click(object sender, EventArgs e)
        {
            // Call the RegisterCustomer method and close the current window.
            RegisterCustomer();
            this.Close();
        }
    }

}
