using Abstraction.Interfaces;
using BLL.Services;
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
    public partial class SearchProjects : Form
    {
        private CodeLanguageService codeLanguageService = new CodeLanguageService();

        private EndtypeService endtypeService = new EndtypeService();

        private BLL.Services.ProjectService projectService = new BLL.Services.ProjectService();

        public IProject MyProject { get; set; }

        public SearchProjects()
        {
            InitializeComponent();
            InitializeComboboxes();
        }

        public void InitializeComboboxes()
        {
            cb_CodeLanguage.DataSource = codeLanguageService.GetAllCodeLanguages();
            cb_CodeLanguage.DisplayMember = "Language";
            cb_CodeLanguage.SelectedIndex = -1;

            cb_EndType.DataSource = endtypeService.GetAllEndTypes();
            cb_EndType.DisplayMember = "EndType1";
            cb_EndType.SelectedIndex = -1;
        }

        public void FilterSearch()
        {
            var projects = projectService.GetAllProjects();

            try
            {
                int codeLanguage = cb_CodeLanguage.SelectedIndex +1;
                int endType = cb_EndType.SelectedIndex +1;
                int projectStatus = 1; 

                var result = (from i in projects
                              where i.Language.Id == codeLanguage && i.EndType.Id == endType && i.Status == projectStatus
                              select i).ToList();

                dgv_Projects.DataSource = result;
                dgv_Projects.Refresh();

                if (cb_CodeLanguage.SelectedIndex == -1)
                {
                    MessageBox.Show("Please pick a coding language to filter your search!", "Error!");
                }

                if (cb_EndType.SelectedIndex == -1)
                {
                    var resultWithoutEndType = (from i in projects where i.Language.Id == codeLanguage & i.Status == projectStatus select i).ToList();
                    dgv_Projects.DataSource = resultWithoutEndType;
                    dgv_Projects.Refresh();
                }

            }
            catch
            {
                MessageBox.Show("An error has occured, please try again later!", "Error!");
            }
        }

        private void bt_ResetSearch_Click(object sender, EventArgs e)
        {
            cb_CodeLanguage.SelectedIndex = -1;
            cb_EndType.SelectedIndex = -1;

            dgv_Projects.DataSource = null;
        }

        private void bt_Search_Click(object sender, EventArgs e)
        {
            FilterSearch();
        }

        private void bt_OpenProject_Click(object sender, EventArgs e)
        {
            if (dgv_Projects.SelectedRows.Count > 0)
            {
                IProject selectedProject = dgv_Projects.SelectedRows[0].DataBoundItem as IProject;

            }
            else
            {
                MessageBox.Show("Please select a project you want to apply to.", "No Project Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
