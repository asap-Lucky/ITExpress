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
using BLL.Models;

namespace UI.Consultant
{
    public partial class SignUpConsultant_Form : Form
    {
        IConsultantService consultantService = new BLL.Services.ConsultantService();

        BLL.Facader.ConsultantService FacadeService;

        public SignUpConsultant_Form()
        {
            InitializeComponent();
            FacadeService = new BLL.Facader.ConsultantService(consultantService);
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
                FacadeService.RegisterConsultant(tb_firstName.Text, tb_lastName.Text, tb_address.Text, zipcode, phonenumber, tb_email.Text, tb_userName.Text, tb_passWord.Text, tb_City.Text);
            }
        }
   
        private void bt_SignUpAsCostumer_Click(object sender, EventArgs e)
        {
            this.Close();
            RegisterConsultant();
        }
    }
}
