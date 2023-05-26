using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Abstraction.Interfaces;
using BLL.Models;
using Presentation.Customer;

namespace Presentation.Admin
{
    /// <summary>
    /// Marcel
    /// </summary>
    
    public partial class EditSpecialization_Form : Form
    {
        //Fields
        private BLL.Services.CodeLanguageService codeLanguageService {  get; set; }
        private BLL.Models.CodeLanguage CodeLanguage { get; set; }

        //Constructor
        public EditSpecialization_Form()
        {
            InitializeComponent();
            this.codeLanguageService = new BLL.Services.CodeLanguageService();
            UpdateLanguagesData();
            LoadLanguagesData();
        }

        //Method for loading the data from the database
        private void LoadLanguagesData()
        {
            List<ICodeLanguage> languages = this.codeLanguageService.GetAllCodeLanguages();
            dgv_allLanguages.DataSource = languages;
        }

        //Method for updating the data from the database
        private void UpdateLanguagesData()
        {
            dgv_allLanguages.DataSource = codeLanguageService.GetAllCodeLanguages();
            dgv_allLanguages.Refresh();
        }


        /// <summary>
        /// Method for saving the changes made to the data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="id"></param> - The id of the language
        private void bt_SaveChanges_Click(object sender, EventArgs e)
        {
            if (dgv_allLanguages.SelectedCells.Count > 0)
            {
                // Get the selected row index
                var rowIndex = dgv_allLanguages.SelectedCells[0].RowIndex;

                // Retrieve the data from the selected row
                var id = dgv_allLanguages.Rows[rowIndex].Cells["Id"].Value; // Assuming the column name is "Id"
                var language = dgv_allLanguages.Rows[rowIndex].Cells["Language"].Value; // Assuming the column name is "Name"

                // Create an instance of ICodeLanguage and populate its properties
                ICodeLanguage codeLanguage = new CodeLanguage();
                codeLanguage.Id = Convert.ToInt32(id);
                codeLanguage.Language = language.ToString();

                // Call the service method to edit the code language
                codeLanguageService.EditCodeLanguage(codeLanguage);

                foreach (DataGridViewColumn column in dgv_allLanguages.Columns)
                {
                    if (column.Index == rowIndex)
                    {
                        column.Visible = true;
                    }
                    else
                    {
                        column.Visible = true;
                    }
                }

                dgv_allLanguages.ReadOnly = true;
            }
        }

        //Button for allowing the admin to edit the languages in the database
        private void bt_EditLanguages_Click(object sender, EventArgs e)
        {
            dgv_allLanguages.ReadOnly = false;
            if (dgv_allLanguages.SelectedCells.Count > 0)
            {
                // Get the selected cell's column index
                int columnIndex = dgv_allLanguages.SelectedCells[0].ColumnIndex;

                // Show only the selected column, hide others
                foreach (DataGridViewColumn column in dgv_allLanguages.Columns)
                {
                    if (column.Index == columnIndex)
                    {
                        column.Visible = false;
                    }
                    else
                    {
                        column.Visible = true;
                    }
                }
            }
        }

        //Button for adding a new language to the database
        private void bt_AddLanguage_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddSpecialization_Form addSpecialization_Form = new AddSpecialization_Form();
            addSpecialization_Form.ShowDialog();
        }

        //Button for deleting a language from the database (Only the ones that are not assigned to a consultant/project)
        private void bt_delete_Click(object sender, EventArgs e)
        {
            if (dgv_allLanguages.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dgv_allLanguages.SelectedRows[0];
                var language = selectedRow.DataBoundItem;
                ICodeLanguage selectedLanguage = (ICodeLanguage)language;

                // Call the LanguageService.Delete() method

                try
                {
                    codeLanguageService.DeleteCodeLanguage(selectedLanguage);
                }

                catch(SqlException SqlException)
                {
                    MessageBox.Show(("The language is in use and cannot be deleted"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                UpdateLanguagesData();
                LoadLanguagesData();
                
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }

        }
    }
}
