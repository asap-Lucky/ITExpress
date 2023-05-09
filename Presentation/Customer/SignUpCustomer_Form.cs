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
        public Abstraction.Interfaces.ICustomer MyCustomer { get; set; }

        BLL.Services.CustomerService CustomerService = new BLL.Services.CustomerService();

        public SignUpCustomer_Form()
        {
            InitializeComponent();
            MyCustomer = new Customer();
        }

        private void bt_GoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegisterCustomer()
        {
            bool CanParseZipcode = int.TryParse(tb_zipCode.Text, out int zipcode);
            bool CanParsePhonenumber = int.TryParse(tb_phoneNumber.Text, out int phonenumber);

            if (!CanParseZipcode)
            {
                MessageBox.Show("Please only use numbers for the zipcode!", "Invalid Zipcode!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!CanParsePhonenumber) 
            {
                MessageBox.Show("Please only use numbers for the phonenumber!", "Invalid Phonenumber!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tb_email.Text != tb_repeatEmail.Text)
            {
                MessageBox.Show("The emails did not match, please type it out again", "Email didnt match!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tb_passWord.Text != tb_RepeatPassWord.Text)
            {
                MessageBox.Show("The passwords did not match, please type it out again", "Password didnt match!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

                CustomerService.AddCustomer(MyCustomer);
            }
        }

        private void bt_SignUpAsCostumer_Click(object sender, EventArgs e)
        {
            RegisterCustomer();
            this.Close();
        }
    }
}
