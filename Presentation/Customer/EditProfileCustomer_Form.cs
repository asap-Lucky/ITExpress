using Abstraction.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Customer
{
    public partial class EditProfileCustomer : Form
    {
        private Abstraction.Interfaces.ICustomer loggedInCustomer;

        ICustomerService customerService = new BLL.Services.CustomerService();

        BLL.Facader.CustomerService FacadeService;

        public EditProfileCustomer(Abstraction.Interfaces.ICustomer loggedInCustomer)
        {
            InitializeComponent();
            this.loggedInCustomer = loggedInCustomer;
            FacadeService = new BLL.Facader.CustomerService(customerService);
        }

        private void bt_DiscardProfileChanges_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to discard changes? All changes WILL BE LOST!", "DISCARD CHANGES?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            { 
                LoadCustomerData();
                tb_newUserName.Text = null;
                tb_newPassWord.Text = null;
                tb_repeatNewPassword.Text = null;
            }
        }

        private void EditProfileCustomer_Load(object sender, EventArgs e)
        {
            LoadCustomerData();
        }

        private void LoadCustomerData() 
        {
            loggedInCustomer = FacadeService.GetCustomer(loggedInCustomer.Id);

            tb_currentFirstName.Text = loggedInCustomer.FirstName;
            tb_currrentLastName.Text = loggedInCustomer.LastName;
            tb_currentAddress.Text = loggedInCustomer.Address;
            tb_currentCity.Text = loggedInCustomer.City;
            tb_currentZipCode.Text = loggedInCustomer.ZipCode.ToString();
            tb_currentPhoneNumber.Text = loggedInCustomer.PhoneNumber.ToString();
            tb_currentEmail.Text = loggedInCustomer.Email;
        }

        private void SaveChanges()
        {
            // Check if the values of the zipcode and phonenumber can be converted to an integer.
            bool CanParseZipcode = int.TryParse(tb_currentZipCode.Text, out int zipcode);
            bool CanParsePhonenumber = int.TryParse(tb_currentPhoneNumber.Text, out int phonenumber);


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
            // Check if the password and repeated password match.
            else if (tb_newPassWord.Text != tb_repeatNewPassword.Text)
            {
                MessageBox.Show("The passwords did not match, please type it out again", "Password didnt match!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Check if username and password textboxes are empty
                if (string.IsNullOrEmpty(tb_newUserName.Text) && string.IsNullOrEmpty(tb_newPassWord.Text) && string.IsNullOrEmpty(tb_repeatNewPassword.Text))
                {
                    FacadeService.EditCustomer(loggedInCustomer.Id, tb_currentFirstName.Text, tb_currrentLastName.Text, tb_currentAddress.Text, zipcode, phonenumber, tb_currentEmail.Text, tb_currentCity.Text);
                }
                else
                {
                    FacadeService.EditCustomer(loggedInCustomer.Id, tb_currentFirstName.Text, tb_currrentLastName.Text, tb_currentAddress.Text, zipcode, phonenumber, tb_currentEmail.Text, tb_currentCity.Text);

                    // Check if the new username and password are not empty before updating them.
                    if (!string.IsNullOrEmpty(tb_newUserName.Text) && !string.IsNullOrEmpty(tb_newPassWord.Text))
                    {
                        FacadeService.EditCustomerLoginInfo(loggedInCustomer.Id, tb_newUserName.Text, tb_newPassWord.Text);
                    }
                }

                loggedInCustomer = FacadeService.GetCustomer(loggedInCustomer.Id);
            }
        }

        private void bt_saveChangesOnProfile_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }
    }
}
