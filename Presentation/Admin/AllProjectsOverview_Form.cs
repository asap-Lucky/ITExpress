using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;
using Abstraction.Interfaces;
using BLL.Facader;
using BLL.Models;
using Presentation.Consultant;
using UI.Costumer;

namespace Presentation.Customer
{
    /// <summary>
    /// Djoan
    /// </summary>
    public partial class AllProjectsOverview_Form : Form
    {
        // Service for managing projects
        IProjectService projectService = new BLL.Services.ProjectService();

        // Customer object
        private ICustomer customer;

        // Facade service for project-related operations
        private BLL.Facader.ProjectService facadeService;

        /// <summary>
        /// Mapping of status names to their corresponding numeric values
        /// </summary>
        private Dictionary<string, int> statusMapping = new Dictionary<string, int>
    {
        { "New", 1 },
        { "In work", 4 },
        { "Closed - Pending", 2 },
        { "Closed", 3 },
    };

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="projectService"></param>
        /// <param name="customer"></param>
        public AllProjectsOverview_Form(IProjectService projectService, ICustomer customer)
        {
            this.projectService = projectService;
            this.customer = customer;
            InitializeComponent();
            InitializeDGV();
            facadeService = new ProjectService(projectService);
        }

        /// <summary>
        /// Initializes the DataGridView (DGV) for displaying project data
        /// </summary>
        private void InitializeDGV()
        {
            // Retrieve the list of all projects
            List<IProject> projects = projectService.GetAllProjects().ToList();

            // Configure DGV settings
            dgv_AllProjectsOverview.AutoGenerateColumns = false;
            dgv_AllProjectsOverview.DataSource = projects;
            dgv_AllProjectsOverview.CellValidating += dgv_AllProjectsOverview_CellValidating;
            dgv_AllProjectsOverview.CurrentCellDirtyStateChanged += dgv_AllProjectsOverview_CurrentCellDirtyStateChanged;

            // Populate the DGV with columns and data
            PopulateDGV();
        }

        /// <summary>
        /// Refreshes the DGV with updated project data
        /// </summary>
        private void RefreshDGV()
        {
            // Retrieve the updated list of all projects
            List<IProject> projects = projectService.GetAllProjects().ToList();

            // Clear the current data source, existing rows, and columns
            dgv_AllProjectsOverview.DataSource = null;
            dgv_AllProjectsOverview.Rows.Clear();
            dgv_AllProjectsOverview.Columns.Clear();

            // Assign the updated list of projects as the data source
            dgv_AllProjectsOverview.DataSource = projects;

            // Populate the DGV with columns and data
            PopulateDGV();
        }

        /// <summary>
        /// Populates the DGV with columns and data
        /// </summary>
        private void PopulateDGV()
        {
            // Create and configure columns for project information
            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.DataPropertyName = "Name";
            nameColumn.HeaderText = "Project name";
            nameColumn.ReadOnly = true;
            dgv_AllProjectsOverview.Columns.Add(nameColumn);

            DataGridViewTextBoxColumn totalSumColumn = new DataGridViewTextBoxColumn();
            totalSumColumn.DataPropertyName = "TotalSum";
            totalSumColumn.HeaderText = "Total Sum";
            totalSumColumn.ReadOnly = true;
            dgv_AllProjectsOverview.Columns.Add(totalSumColumn);

            DataGridViewTextBoxColumn startDateColumn = new DataGridViewTextBoxColumn();
            startDateColumn.DataPropertyName = "StartDate";
            startDateColumn.HeaderText = "Start Date";
            startDateColumn.ReadOnly = true;
            dgv_AllProjectsOverview.Columns.Add(startDateColumn);

            DataGridViewTextBoxColumn endDateColumn = new DataGridViewTextBoxColumn();
            endDateColumn.DataPropertyName = "EndDate";
            endDateColumn.HeaderText = "End Date";
            endDateColumn.ReadOnly = true;
            dgv_AllProjectsOverview.Columns.Add(endDateColumn);

            DataGridViewTextBoxColumn consultantColumn = new DataGridViewTextBoxColumn();
            consultantColumn.DataPropertyName = "GetConsultantFullName";
            consultantColumn.HeaderText = "Consultant";
            consultantColumn.ReadOnly = true;
            dgv_AllProjectsOverview.Columns.Add(consultantColumn);

            // Iterate through the rows and set the cell value to an empty string if it's null
            foreach (DataGridViewRow row in dgv_AllProjectsOverview.Rows)
            {
                DataGridViewCell cell = row.Cells[consultantColumn.Index];
                if (cell.Value == null)
                {
                    cell.Value = string.Empty;
                }
            }

            DataGridViewTextBoxColumn customerIdColumn = new DataGridViewTextBoxColumn();
            customerIdColumn.DataPropertyName = "GetCustomerFullName";
            customerIdColumn.HeaderText = "Customer";
            customerIdColumn.ReadOnly = true;
            dgv_AllProjectsOverview.Columns.Add(customerIdColumn);

            DataGridViewTextBoxColumn languageColumn = new DataGridViewTextBoxColumn();
            languageColumn.DataPropertyName = "GetLangauge";
            languageColumn.HeaderText = "Language";
            languageColumn.ReadOnly = true;
            dgv_AllProjectsOverview.Columns.Add(languageColumn);

            DataGridViewTextBoxColumn endTypeColumn = new DataGridViewTextBoxColumn();
            endTypeColumn.DataPropertyName = "GetEndType";
            endTypeColumn.HeaderText = "End Type";
            endTypeColumn.ReadOnly = true;
            dgv_AllProjectsOverview.Columns.Add(endTypeColumn);

            DataGridViewComboBoxColumn statusColumn = new DataGridViewComboBoxColumn();
            statusColumn.DataPropertyName = "Status";
            statusColumn.HeaderText = "Status";
            statusColumn.Name = "Status";
            statusColumn.ValueType = typeof(int);
            statusColumn.ValueMember = "Value";
            statusColumn.DisplayMember = "Key";
            statusColumn.DataSource = new BindingSource(statusMapping, null);
            dgv_AllProjectsOverview.Columns.Add(statusColumn);

            DataGridViewTextBoxColumn totalHoursColumn = new DataGridViewTextBoxColumn();
            totalHoursColumn.DataPropertyName = "TimeUsed";
            totalHoursColumn.HeaderText = "Billable hours";
            totalHoursColumn.ReadOnly = true;
            dgv_AllProjectsOverview.Columns.Add(totalHoursColumn);
        }

        /// <summary>
        /// Event handler for the Refresh button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_Refresh_Click(object sender, EventArgs e)
        {
            RefreshDGV();
        }

        /// <summary>
        /// Event handler for the View Project button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_ViewProject_Click(object sender, EventArgs e)
        {
            // Retrieve the selected project from the DGV
            IProject selectedProject = dgv_AllProjectsOverview.SelectedRows[0].DataBoundItem as IProject;

            // Open the project form in view-only mode
            EditProjectConsultant_Form openProjectForm = new EditProjectConsultant_Form(customer, selectedProject);
            openProjectForm.DisableEditing();
            openProjectForm.DisableHours();
            openProjectForm.ShowDialog();
        }

        /// <summary>
        /// Event handler for the Edit Project button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_EditProject_Click(object sender, EventArgs e)
        {
            // Retrieve the selected project from the DGV
            IProject selectedProject = dgv_AllProjectsOverview.SelectedRows[0].DataBoundItem as IProject;

            // Open the project form in edit mode
            EditProjectConsultant_Form openProjectForm = new EditProjectConsultant_Form(customer, selectedProject);
            openProjectForm.ShowDialog();
        }

        /// <summary>
        /// Event handler for validating the cell value in the Status column
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_AllProjectsOverview_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dgv_AllProjectsOverview.Columns[e.ColumnIndex].Name == "Status" && e.RowIndex >= 0)
            {
                DataGridViewComboBoxCell cell = dgv_AllProjectsOverview.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewComboBoxCell;
                object newValue = cell.Value;
                object currentValue = cell.Tag; // Use the Tag property to store the original value

                if (!newValue.Equals(currentValue))
                {
                    string selectedStatus = cell.FormattedValue.ToString(); // Use FormattedValue to get the displayed text

                    IProject project = dgv_AllProjectsOverview.Rows[e.RowIndex].DataBoundItem as IProject;
                    project.Status = statusMapping[selectedStatus];
                    int projectId = project.Id;
                    int newStatus = project.Status;

                    // Update the project status using the facade service
                    facadeService.EditProjectStatus(projectId, newStatus);

                    // Update the Tag property to store the new value
                    cell.Tag = newValue;
                }
            }
        }

        /// <summary>
        /// Event handler for handling the current cell dirty state change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_AllProjectsOverview_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgv_AllProjectsOverview.IsCurrentCellDirty)
            {
                dgv_AllProjectsOverview.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        /// <summary>
        /// Event handler for the Delete button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_Delete_Click(object sender, EventArgs e)
        {
            // Retrieve the selected project from the DGV
            IProject selectedProject = (IProject)dgv_AllProjectsOverview.SelectedRows[0].DataBoundItem;

            // Confirm the deletion with a message box
            var confirmResult = MessageBox.Show("Are you sure you want to delete this project?", "Confirm Delete!", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                // Delete the project using the project service
                projectService.DeleteProject(selectedProject);
                RefreshDGV();
            }
        }
    }
}
