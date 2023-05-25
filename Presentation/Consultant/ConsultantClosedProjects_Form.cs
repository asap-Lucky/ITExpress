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
    public partial class ConsultantClosedProjects : Form
    {
        IConsultant loggedInConsultant;
        IProjectService projectService = new BLL.Services.ProjectService();
        BLL.Facader.ProjectService facadeService;

        private Dictionary<string, int> statusMapping = new Dictionary<string, int>
        {
            { "Open", 1 },
            { "Pending review", 2 },
            { "Closed", 3 }
        };

        /// <summary>
        /// Initializes a new instance of the ConsultantClosedProjects form.
        /// </summary>
        /// <param name="loggedInConsultant">The logged-in consultant.</param>
        /// <param name="projectService">The project service.</param>
        public ConsultantClosedProjects(IConsultant loggedInConsultant, IProjectService projectService)
        {
            InitializeComponent();
            this.loggedInConsultant = loggedInConsultant;
            this.projectService = projectService;
            facadeService = new BLL.Facader.ProjectService(projectService);
            InitializeDataGridView();
        }

        /// <summary>
        /// Initializes the DataGridView with closed projects of the consultant.
        /// </summary>
        public void InitializeDataGridView()
        {
            List<IProject> projects = projectService.GetProjectsByConsultant(loggedInConsultant.Id)
                .Where(p => p.Status == 3)
                .ToList();

            dgv_closedProjects.AutoGenerateColumns = false;
            dgv_closedProjects.DataSource = projects;

            DGVPopulate();
        }

        /// <summary>
        /// Event handler for the Open Project button click.
        /// Opens the selected completed project for viewing.
        /// </summary>
        private void bt_OpenProject_Click(object sender, EventArgs e)
        {
            ViewCompletedProject();
        }

        /// <summary>
        /// Opens the selected completed project for viewing.
        /// </summary>
        private void ViewCompletedProject()
        {
            if (dgv_closedProjects.SelectedRows.Count > 0)
            {
                IProject selectedProject = dgv_closedProjects.SelectedRows[0].DataBoundItem as IProject;

                EditProjectConsultant_Form openProjectForm = new EditProjectConsultant_Form(loggedInConsultant as ICustomer, selectedProject);
                openProjectForm.DisableEditing();
                openProjectForm.DisableHours();
                openProjectForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a project to view.", "No Project Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Event handler for the Refresh button click.
        /// Refreshes the DataGridView with the latest closed projects.
        /// </summary>
        private void bt_Refresh_Click(object sender, EventArgs e)
        {
            RefreshDGV();
        }

        /// <summary>
        /// Refreshes the DataGridView with the latest closed projects.
        /// </summary>
        private void RefreshDGV()
        {
            List<IProject> projects = projectService.GetProjectsByConsultant(loggedInConsultant.Id)
                .Where(p => p.Status == 3)
                .ToList();

            dgv_closedProjects.DataSource = null; // Clear the current data source
            dgv_closedProjects.Rows.Clear(); // Clear the existing rows
            dgv_closedProjects.Columns.Clear(); // Clear the existing columns

            dgv_closedProjects.DataSource = projects; // Assign the updated data source

            DGVPopulate();
        }

        /// <summary>
        /// Populates the DataGridView with the necessary columns.
        /// </summary>
        private void DGVPopulate()
        {
            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.DataPropertyName = "Name";
            nameColumn.HeaderText = "Project Name";
            nameColumn.ReadOnly = true;
            dgv_closedProjects.Columns.Add(nameColumn);

            DataGridViewTextBoxColumn totalSumColumn = new DataGridViewTextBoxColumn();
            totalSumColumn.DataPropertyName = "TotalSum";
            totalSumColumn.HeaderText = "Total Sum";
            dgv_closedProjects.Columns.Add(totalSumColumn);

            DataGridViewTextBoxColumn startDateColumn = new DataGridViewTextBoxColumn();
            startDateColumn.DataPropertyName = "StartDate";
            startDateColumn.HeaderText = "Start Date";
            dgv_closedProjects.Columns.Add(startDateColumn);

            DataGridViewTextBoxColumn endDateColumn = new DataGridViewTextBoxColumn();
            endDateColumn.DataPropertyName = "EndDate";
            endDateColumn.HeaderText = "End Date";
            dgv_closedProjects.Columns.Add(endDateColumn);

            DataGridViewTextBoxColumn customerIdColumn = new DataGridViewTextBoxColumn();
            customerIdColumn.DataPropertyName = "GetCustomerFullName";
            customerIdColumn.HeaderText = "Customer";
            dgv_closedProjects.Columns.Add(customerIdColumn);

            DataGridViewTextBoxColumn languageColumn = new DataGridViewTextBoxColumn();
            languageColumn.DataPropertyName = "GetLangauge";
            languageColumn.HeaderText = "Language";
            dgv_closedProjects.Columns.Add(languageColumn);

            DataGridViewTextBoxColumn endTypeColumn = new DataGridViewTextBoxColumn();
            endTypeColumn.DataPropertyName = "GetEndType";
            endTypeColumn.HeaderText = "End Type";
            dgv_closedProjects.Columns.Add(endTypeColumn);

            DataGridViewComboBoxColumn statusColumn = new DataGridViewComboBoxColumn();
            statusColumn.DataPropertyName = "Status";
            statusColumn.HeaderText = "Status";
            statusColumn.Name = "Status";
            statusColumn.ValueType = typeof(int);
            statusColumn.ValueMember = "Value";
            statusColumn.DisplayMember = "Key";
            statusColumn.DataSource = new BindingSource(statusMapping, null);
            dgv_closedProjects.Columns.Add(statusColumn);

            DataGridViewTextBoxColumn totalHoursColumn = new DataGridViewTextBoxColumn();
            totalHoursColumn.DataPropertyName = "TimeUsed";
            totalHoursColumn.HeaderText = "Billable hours";
            dgv_closedProjects.Columns.Add(totalHoursColumn);
        }
    }
}
