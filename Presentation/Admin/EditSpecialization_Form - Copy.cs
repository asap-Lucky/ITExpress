using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Abstraction.Interfaces;
using Presentation.Customer;

namespace Presentation.Admin
{
    public partial class EditSpecialization_Form : Form
    {
        //Fields
        private BLL.Services.CodeLanguageService codeLanguageService {  get; set; }

        public EditSpecialization_Form()
        {
            InitializeComponent();
            this.codeLanguageService = new BLL.Services.CodeLanguageService();
            UpdateLanguagesData();
            LoadLanguagesData();
        }

        private void LoadLanguagesData()
        {
            List<ICodeLanguage> languages = this.codeLanguageService.GetAllCodeLanguages();
            dgv_allLanguages.DataSource = languages;
        }

        private void UpdateLanguagesData()
        {
            dgv_allLanguages.DataSource = codeLanguageService.GetAllCodeLanguages();
            dgv_allLanguages.Refresh();
        }

        private void bt_SaveChanges_Click(object sender, EventArgs e)
        {
            dgv_allLanguages.ReadOnly = true;
            if (dgv_allLanguages.SelectedCells.Count > 0)
            {
                // Get the selected cell's column index
                int columnIndex = dgv_allLanguages.SelectedCells[0].ColumnIndex;

                // Show only the selected column, hide others
                foreach (DataGridViewColumn column in dgv_allLanguages.Columns)
                {
                    if (column.Index == columnIndex)
                    {
                        column.Visible = true;
                    }
                    else
                    {
                        column.Visible = true;
                    }
                }
            }
        }

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

        private void bt_AddLanguage_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddSpecialization_Form addSpecialization_Form = new AddSpecialization_Form();
            addSpecialization_Form.ShowDialog();
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            if (dgv_allLanguages.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dgv_allLanguages.SelectedRows[0];
                var language = selectedRow.DataBoundItem;
                ICodeLanguage selectedLanguage = (ICodeLanguage)language;

                // Call the LanguageService.Delete() method
                codeLanguageService.DeleteCodeLanguage(selectedLanguage); 
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }

        }
    }
}
