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

namespace UI.Consultant
{
    public partial class SignUpConsultant_Form : Form
    {
        public Abstraction.Interfaces.IConsultant MyConsultant { get; set; }

        BLL.Services.ConsultantService ConsultantService = new BLL.Services.ConsultantService();

        public SignUpConsultant_Form()
        {
            InitializeComponent();
            MyConsultant = new BLL.Models.Consultant();
        }

        private void bt_GoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegisterConsultant()
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
            // If all checks are passed, set the values of MyConsultant properties and add it to the database.
            else
            {
                MyConsultant.FirstName = tb_firstName.Text;
                MyConsultant.LastName = tb_lastName.Text;
                MyConsultant.Address = tb_address.Text;
                MyConsultant.ZipCode = zipcode;
                MyConsultant.PhoneNumber = phonenumber;
                MyConsultant.Email = tb_email.Text;
                MyConsultant.Login = tb_userName.Text;
                MyConsultant.Password = tb_passWord.Text;
                MyConsultant.City = tb_City.Text;

                // Call the AddCustomer method of the CustomerService object and pass in MyConsultant object.
                ConsultantService.AddConsultant(MyConsultant);
            }
        }
   

        private void bt_SignUpAsCostumer_Click(object sender, EventArgs e)
        {
            this.Close();
            RegisterConsultant();
        }
    }
}
