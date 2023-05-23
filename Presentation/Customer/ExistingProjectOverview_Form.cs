using Abstraction.Interfaces;
using BLL.Facader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Customer
{
    public partial class ExistingProjectOverview_Forn : Form
    {
        private ICustomer loggedInCustomer;

        IProjectService projectService = new BLL.Services.ProjectService();

        BLL.Facader.ProjectService FacadeService;

        private Dictionary<string, int> statusMapping = new Dictionary<string, int>
            {
                { "New", 1 },
                { "In work", 4 },
                { "Closed - Pending", 2 },
                { "Closed", 3 },
            };
        public ExistingProjectOverview_Forn(ICustomer loggedInCustomer, IProjectService projectService)
        {
            this.loggedInCustomer = loggedInCustomer;
            this.projectService = projectService;
            InitializeComponent();
            InitializeDataGridView();
            FacadeService = new ProjectService(projectService);
        }

        public void InitializeDataGridView()
        {
            List<IProject> projects = projectService.GetProjectsByCostumer(loggedInCustomer)
                .Where(p => p.Status == 1 || p.Status == 2)
                .ToList();

            dgv_existingProjectsCustomer.AutoGenerateColumns = false;
            dgv_existingProjectsCustomer.DataSource = projects;
            dgv_existingProjectsCustomer.CellValidating += dgv_existingProjectsCustomer_CellValidating;
            dgv_existingProjectsCustomer.CurrentCellDirtyStateChanged += dgv_existingProjectsCustomer_CurrentCellDirtyStateChanged;

            DGVPopulate();
        }

        private void RefreshDataGridView()
        {
            List<IProject> projects = projectService.GetProjectsByCostumer(loggedInCustomer)
                .Where(p => p.Status == 1 || p.Status == 2)
                .ToList();

            dgv_existingProjectsCustomer.DataSource = null; // Clear the current data source
            dgv_existingProjectsCustomer.Rows.Clear(); // Clear the existing rows
            dgv_existingProjectsCustomer.Columns.Clear(); // Clear the existing columns

            dgv_existingProjectsCustomer.DataSource = projects; // Assign the updated data source

            DGVPopulate();
        }

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
            customerIdColumn.DataPropertyName = "GetConsultantFullName";
            customerIdColumn.HeaderText = "Consultant";
            customerIdColumn.ReadOnly = true;
            dgv_existingProjectsCustomer.Columns.Add(customerIdColumn);

            // Iterate through the rows and set the cell value to an empty string if it's null
            foreach (DataGridViewRow row in dgv_existingProjectsCustomer.Rows)
            {
                DataGridViewCell cell = row.Cells[customerIdColumn.Index];
                if (cell.Value == null)
                {
                    cell.Value = string.Empty;
                }
            }

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

                    FacadeService.EditProjectStatus(projectId, newStatus);

                    // Update the Tag property to store the new value
                    cell.Tag = newValue;
                }
            }
        }

        private void dgv_existingProjectsCustomer_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgv_existingProjectsCustomer.IsCurrentCellDirty)
            {
                dgv_existingProjectsCustomer.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void bt_Refresh_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void bt_OpenProject_Click(object sender, EventArgs e)
        {
            if (dgv_existingProjectsCustomer.SelectedRows.Count > 0)
            {
                IProject selectedProject = dgv_existingProjectsCustomer.SelectedRows[0].DataBoundItem as IProject;

                EditProjectConsultant_Form openProjectForm = new EditProjectConsultant_Form(loggedInCustomer, selectedProject);
                openProjectForm.DisableEditing();
                openProjectForm.DisableHours();
                openProjectForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a project to view.", "No Project Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bt_EditProject_Click(object sender, EventArgs e)
        {
            if (dgv_existingProjectsCustomer.SelectedRows.Count > 0)
            {
                IProject selectedProject = dgv_existingProjectsCustomer.SelectedRows[0].DataBoundItem as IProject;

                EditProjectConsultant_Form openProjectForm = new EditProjectConsultant_Form(loggedInCustomer, selectedProject);
                openProjectForm.DisableHours();
                openProjectForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a project to view.", "No Project Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bt_DeleteProject_Click(object sender, EventArgs e)
        {
            IProject selectedProject = (IProject)dgv_existingProjectsCustomer.SelectedRows[0].DataBoundItem;
            var confirmResult = MessageBox.Show("Are you sure to delete this project?", "Confirm Delete!", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                projectService.DeleteProject(selectedProject);
                RefreshDataGridView();
            }
        }
    }
}
