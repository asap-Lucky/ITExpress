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
using BLL.Services;

namespace Presentation.Admin
{
    /// <summary>
    /// Marcel
    /// </summary>

    //Fields
    public partial class AddSpecialization_Form : Form
    {
        private BLL.Services.CodeLanguageService LanguageService;

        private Abstraction.Interfaces.ICodeLanguage IcodeLanguage;

        private BLL.Models.CodeLanguage CodeLanguage;

        //Constructor
        public AddSpecialization_Form()
        {
            InitializeComponent();
            this.LanguageService = new CodeLanguageService();
        }


        //Buttons for the form


        //Buttons for going back to the previous form
        private void bt_GoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditSpecialization_Form editspecia = new EditSpecialization_Form();
            editspecia.Show();
        }

        //Button for saving the new language
        private void bt_SaveChanges_Click(object sender, EventArgs e)
        {
            var textInput = tb_EnterNewLanguage.Text;

            try
            {
                ICodeLanguage codeLanguage = new CodeLanguage();
                codeLanguage.Language = textInput;

                LanguageService.AddCodeLanguage(codeLanguage);
                this.Hide();
                MessageBox.Show("Your new language have been added");
            }

            catch (Exception ex)
            {
                MessageBox.Show(("Error: Could not save the new language") + ex.Message);
            }
           
        }
    }
}
