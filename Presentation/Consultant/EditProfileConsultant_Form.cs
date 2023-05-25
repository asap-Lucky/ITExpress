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
    /// <summary>
    /// Djoan
    /// </summary>
    public partial class EditProfileConsultant : Form
    {
        private Abstraction.Interfaces.IConsultant loggedInConsultant;
        IConsultantService consultantService = new BLL.Services.ConsultantService();
        ICodeLangaugeService codeLanguageService = new BLL.Services.CodeLanguageService();
        IEndtypeService endtypeService = new BLL.Services.EndtypeService();
        BLL.Facader.ConsultantService FacadeService;

        public EditProfileConsultant(Abstraction.Interfaces.IConsultant loggedInConsultant)
        {
            InitializeComponent();
            this.loggedInConsultant = loggedInConsultant;
            FacadeService = new BLL.Facader.ConsultantService(consultantService);
        }

        // Discards the changes made on the profile by resetting the form fields
        private void bt_DiscardProfileChanges_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to discard changes? All changes WILL BE LOST!", "DISCARD CHANGES?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                InitializeCombobox();
                LoadConsultantData();
                tb_newUserName.Text = null;
                tb_newPassWord.Text = null;
                tb_repeatNewPassword.Text = null;
            }
        }

        // Loads the consultant data into the form fields when the form is loaded
        private void EditProfileConsultant_Load(object sender, EventArgs e)
        {
            InitializeCombobox();
            LoadConsultantData();
        }

        // Loads the consultant data into the form fields
        private void LoadConsultantData()
        {
            loggedInConsultant = FacadeService.GetConsultant(loggedInConsultant.Id);

            tb_currentFirstName.Text = loggedInConsultant.FirstName;
            tb_currrentLastName.Text = loggedInConsultant.LastName;
            tb_currentAddress.Text = loggedInConsultant.Address;
            tb_currentCity.Text = loggedInConsultant.City;
            tb_currentZipCode.Text = loggedInConsultant.ZipCode.ToString();
            tb_currentPhoneNumber.Text = loggedInConsultant.PhoneNumber.ToString();
            tb_currentEmail.Text = loggedInConsultant.Email;

            cb_Language.Text = loggedInConsultant.Language.Language;
            cb_Endtype.Text = loggedInConsultant.EndType.EndType1;
        }

        // Initializes the comboboxes with code languages and end types
        private void InitializeCombobox()
        {
            cb_Language.DataSource = codeLanguageService.GetAllCodeLanguages();
            cb_Language.DisplayMember = "Language";

            cb_Endtype.DataSource = endtypeService.GetAllEndTypes();
            cb_Endtype.DisplayMember = "Endtype1";
        }

        // Saves the changes made on the profile
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
                    FacadeService.EditConsultant(loggedInConsultant.Id, tb_currentFirstName.Text, tb_currrentLastName.Text, tb_currentAddress.Text, zipcode, phonenumber, tb_currentEmail.Text, tb_currentCity.Text);
                    FacadeService.EditConsultantSpecialization(loggedInConsultant.Id, (ICodeLanguage)cb_Language.SelectedItem, (IEndType)cb_Endtype.SelectedItem);
                }
                else
                {
                    FacadeService.EditConsultant(loggedInConsultant.Id, tb_currentFirstName.Text, tb_currrentLastName.Text, tb_currentAddress.Text, zipcode, phonenumber, tb_currentEmail.Text, tb_currentCity.Text);
                    FacadeService.EditConsultantSpecialization(loggedInConsultant.Id, (ICodeLanguage)cb_Language.SelectedItem, (IEndType)cb_Endtype.SelectedItem);

                    // Check if the new username and password are not empty before updating them.
                    if (!string.IsNullOrEmpty(tb_newUserName.Text) && !string.IsNullOrEmpty(tb_newPassWord.Text))
                    {
                        FacadeService.EditConsultantLoginInfo(loggedInConsultant.Id, tb_newUserName.Text, tb_newPassWord.Text);
                    }
                }

                loggedInConsultant = FacadeService.GetConsultant(loggedInConsultant.Id);
            }
        }

        // Handles the click event of the Save Changes button
        private void bt_saveChangesOnProfile_Click(object sender, EventArgs e)
        {
            SaveChanges();
            MessageBox.Show("Changes have been saved succesfully, you may now close this window safely!", "Saved succesfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
