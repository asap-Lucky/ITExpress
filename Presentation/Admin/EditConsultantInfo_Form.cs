using Abstraction.Interfaces;
using BLL.Models;
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
    public partial class EditConsultantInfo : Form
    {
        //Fields
        private IConsultant SelectedConsultant { get; set; }

        private BLL.Services.ConsultantService consultantService { get; set; }

        public EditConsultantInfo(IConsultant selectedConsultant)
        {
            InitializeComponent();
            SelectedConsultant = selectedConsultant;
            InitialiseControl();
        }

        private void InitialiseControl()
        {
            tb_firstName.Text = SelectedConsultant.FirstName;
            tb_lastName.Text = SelectedConsultant.LastName;
            tb_address.Text = SelectedConsultant.Address;
            tb_city.Text = SelectedConsultant.City;
            tb_phoneNumber.Text = SelectedConsultant.PhoneNumber.ToString();
            tb_email.Text = SelectedConsultant.Email;
            tb_zipCode.Text = SelectedConsultant.ZipCode.ToString();
            tb_login.Text = SelectedConsultant.Login;
            tb_passWord.Text = SelectedConsultant.Password;
            cb_language.Text = SelectedConsultant.Language.Language;
            cb_endType.Text = SelectedConsultant.EndType.EndType1;
            //tb_languageDescript_1 = SelectedConsultant.LanguageDescript_1.ToString();
            // Code that retrives the closed projects for the customer 
            // Code that retrives the current projects for the customer
        }

        private void bt_EditConsultant_Click(object sender, EventArgs e)
        {
            consultantService = new BLL.Services.ConsultantService();
            SaveChanges();
            MessageBox.Show("Your changes have now been saved", "Successfully changed", MessageBoxButtons.OK);
            this.Hide();
        }

        private void SaveChanges()
        {
            // Check if the values of the zipcode and phonenumber can be converted to an integer.
            bool CanParseZipcode = int.TryParse(tb_zipCode.Text, out int zipcode);
            bool CanParsePhonenumber = int.TryParse(tb_phoneNumber.Text, out int phonenumber);
            // Cast from cb to String? -------------->        cb_language.Text = ComboBox.SelectedItem.ToString(); 
            // Cast from cb to String? -------------->        cb_language.Text = ComboBox.SelectedItem.ToString(); 
            // Dont know tb_Discription for consultant? -------------->    ???????????????????????????????????????

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
                if (string.IsNullOrEmpty(tb_firstName.Text) && string.IsNullOrEmpty(tb_lastName.Text) && string.IsNullOrEmpty(tb_address.Text) && string.IsNullOrEmpty(tb_city.Text) && string.IsNullOrEmpty(tb_email.Text) && string.IsNullOrEmpty(tb_phoneNumber.Text) && string.IsNullOrEmpty(tb_login.Text) && string.IsNullOrEmpty(tb_passWord.Text) && string.IsNullOrEmpty(tb_zipCode.Text))
                {
                    MessageBox.Show("Please fill out all the textboxes before procedding further", "Missing data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    SelectedConsultant.FirstName = tb_firstName.Text;
                    SelectedConsultant.LastName = tb_lastName.Text;
                    SelectedConsultant.Address = tb_address.Text;
                    SelectedConsultant.City = tb_city.Text;
                    SelectedConsultant.Email = tb_email.Text;
                    SelectedConsultant.Login = tb_login.Text;
                    SelectedConsultant.Password = tb_passWord.Text;
                    SelectedConsultant.ZipCode = zipcode;
                    SelectedConsultant.PhoneNumber = phonenumber;
                    // --------------> Linje 60 SelectedConsultant.Language = cb_language.Text;
                    // --------------> Linje 61 SelectedConsultant.EndType = cb_endType.Text;
                    //tb_languageDescript_1 = SelectedConsultant.LanguageDescript_1.ToString();

                    consultantService.EditConsultant(SelectedConsultant);
                }


            }
        }

        private void bt_DiscardChanges_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you wish to discard your changes?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                InitialiseControl();
            }
            else if (result == DialogResult.No)
            {

            }
        }
    }
}
