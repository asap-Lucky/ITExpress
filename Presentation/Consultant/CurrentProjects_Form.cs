using Abstraction.Interfaces;
using BLL.Facader;
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
    public partial class CurrentProjects_Form : Form
    {
        private IConsultant loggedInConsultant;
        private IProjectService projectService = new BLL.Services.ProjectService();
        private ProjectService facadeService;
        private Dictionary<string, int> statusMapping = new Dictionary<string, int>
        {
            { "Open", 1 },
            { "In work", 4 },
            { "Closed - Pending", 2 }
        };

        public CurrentProjects_Form(IConsultant loggedInConsultant, IProjectService projectService)
        {
            this.loggedInConsultant = loggedInConsultant;
            this.projectService = projectService;
            InitializeComponent();
            InitializeDataGridView();
            facadeService = new ProjectService(projectService);
        }

        // Initializes the DataGridView with the projects for the logged-in consultant
        public void InitializeDataGridView()
        {
            List<IProject> projects = projectService.GetProjectsByConsultant(loggedInConsultant.Id)
                .Where(p => p.Status == 1 || p.Status == 2)
                .ToList();

            dgv_existingProjectsCustomer.AutoGenerateColumns = false;
            dgv_existingProjectsCustomer.DataSource = projects;
            dgv_existingProjectsCustomer.CellValidating += dgv_existingProjectsCustomer_CellValidating;
            dgv_existingProjectsCustomer.CurrentCellDirtyStateChanged += dgv_existingProjectsCustomer_CurrentCellDirtyStateChanged;

            DGVPopulate();
        }

        // Handles the validation of the Status column in the DataGridView
        private void dgv_existingProjectsCustomer_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dgv_existingProjectsCustomer.Columns[e.ColumnIndex].Name == "Status" && e.RowIndex >= 0)
            {
                DataGridViewComboBoxCell cell = dgv_existingProjectsCustomer.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewComboBoxCell;
                object newValue = cell.Value;
                object currentValue = cell.Tag; // Use the Tag property to store the original value

                if (!newValue.Equals(currentValue))
                {
                    string selectedStatus = cell.FormattedValue.ToString(); // Use FormattedValue to get the displayed text

                    IProject project = dgv_existingProjectsCustomer.Rows[e.RowIndex].DataBoundItem as IProject;
                    project.Status = statusMapping[selectedStatus];
                    int projectId = project.Id;
                    int newStatus = project.Status;

                    facadeService.EditProjectStatus(projectId, newStatus);

                    // Update the Tag property to store the new value
                    cell.Tag = newValue;
                }
            }
        }

        // Commits the changes in the DataGridView when the cell value changes
        private void dgv_existingProjectsCustomer_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgv_existingProjectsCustomer.IsCurrentCellDirty)
            {
                dgv_existingProjectsCustomer.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        // Refreshes the DataGridView with the latest projects for the logged-in consultant
        private void bt_Refresh_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        // Refreshes the DataGridView by updating the data source
        private void RefreshDataGridView()
        {
            List<IProject> projects = projectService.GetProjectsByConsultant(loggedInConsultant.Id)
                .Where(p => p.Status == 1 || p.Status == 2)
                .ToList();

            dgv_existingProjectsCustomer.DataSource = null; // Clear the current data source
            dgv_existingProjectsCustomer.Rows.Clear(); // Clear the existing rows
            dgv_existingProjectsCustomer.Columns.Clear(); // Clear the existing columns

            dgv_existingProjectsCustomer.DataSource = projects; // Assign the updated data source

            DGVPopulate();
        }

        // Opens the selected project for viewing
        private void bt_OpenProject_Click(object sender, EventArgs e)
        {
            ViewCompletedProject();
        }

        // Displays the selected project in a new form for viewing (read-only mode)
        private void ViewCompletedProject()
        {
            if (dgv_existingProjectsCustomer.SelectedRows.Count > 0)
            {
                IProject selectedProject = dgv_existingProjectsCustomer.SelectedRows[0].DataBoundItem as IProject;

                EditProjectConsultant_Form openProjectForm = new EditProjectConsultant_Form(loggedInConsultant as ICustomer, selectedProject);
                openProjectForm.DisableEditing();
                openProjectForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a project to view.", "No Project Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Populates the DataGridView with the required columns
        private void DGVPopulate()
        {
            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.DataPropertyName = "Name";
            nameColumn.HeaderText = "Project name";
            nameColumn.ReadOnly = true;
            dgv_existingProjectsCustomer.Columns.Add(nameColumn);

            DataGridViewTextBoxColumn totalSumColumn = new DataGridViewTextBoxColumn();
            totalSumColumn.DataPropertyName = "TotalSum";
            totalSumColumn.HeaderText = "Total Sum";
            totalSumColumn.ReadOnly = true;
            dgv_existingProjectsCustomer.Columns.Add(totalSumColumn);

            DataGridViewTextBoxColumn startDateColumn = new DataGridViewTextBoxColumn();
            startDateColumn.DataPropertyName = "StartDate";
            startDateColumn.HeaderText = "Start Date";
            startDateColumn.ReadOnly = true;
            dgv_existingProjectsCustomer.Columns.Add(startDateColumn);

            DataGridViewTextBoxColumn endDateColumn = new DataGridViewTextBoxColumn();
            endDateColumn.DataPropertyName = "EndDate";
            endDateColumn.HeaderText = "End Date";
            endDateColumn.ReadOnly = true;
            dgv_existingProjectsCustomer.Columns.Add(endDateColumn);

            DataGridViewTextBoxColumn customerIdColumn = new DataGridViewTextBoxColumn();
            customerIdColumn.DataPropertyName = "GetCustomerFullName";
            customerIdColumn.HeaderText = "Customer";
            customerIdColumn.ReadOnly = true;
            dgv_existingProjectsCustomer.Columns.Add(customerIdColumn);

            DataGridViewTextBoxColumn languageColumn = new DataGridViewTextBoxColumn();
            languageColumn.DataPropertyName = "GetLangauge";
            languageColumn.HeaderText = "Language";
            languageColumn.ReadOnly = true;
            dgv_existingProjectsCustomer.Columns.Add(languageColumn);

            DataGridViewTextBoxColumn endTypeColumn = new DataGridViewTextBoxColumn();
            endTypeColumn.DataPropertyName = "GetEndType";
            endTypeColumn.HeaderText = "End Type";
            endTypeColumn.ReadOnly = true;
            dgv_existingProjectsCustomer.Columns.Add(endTypeColumn);

            DataGridViewComboBoxColumn statusColumn = new DataGridViewComboBoxColumn();
            statusColumn.DataPropertyName = "Status";
            statusColumn.HeaderText = "Status";
            statusColumn.Name = "Status";
            statusColumn.ValueType = typeof(int);
            statusColumn.ValueMember = "Value";
            statusColumn.DisplayMember = "Key";
            statusColumn.DataSource = new BindingSource(statusMapping, null);
            dgv_existingProjectsCustomer.Columns.Add(statusColumn);

            DataGridViewTextBoxColumn totalHoursColumn = new DataGridViewTextBoxColumn();
            totalHoursColumn.DataPropertyName = "TimeUsed";
            totalHoursColumn.HeaderText = "Billable hours";
            totalHoursColumn.ReadOnly = true;
            dgv_existingProjectsCustomer.Columns.Add(totalHoursColumn);
        }
    }
}
