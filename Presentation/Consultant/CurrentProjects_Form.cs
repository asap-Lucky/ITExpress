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
        public partial class CurrentProjects_Form : Form
        {
            private IConsultant loggedInConsultant;

            IProjectService projectService = new BLL.Services.ProjectService();

            BLL.Facader.ProjectService FacadeService;
            
            private Dictionary<string, int> statusMapping = new Dictionary<string, int>
            {
                { "Open", 1 },
                { "Closed - Pending", 2 },
            };

            public CurrentProjects_Form(IConsultant loggedInConsultant, IProjectService projectService)
            {
                this.loggedInConsultant = loggedInConsultant;
                this.projectService = projectService;
                InitializeComponent();
                InitializeDataGridView();
                FacadeService = new ProjectService(projectService);
            }

            public void InitializeDataGridView()
            {
                List<IProject> projects = projectService.GetProjectsByConsultant(loggedInConsultant.Id)
                .Where(p => p.Status == 1 || p.Status == 2)
                .ToList();
                
                dgv_existingProjectsCustomer.AutoGenerateColumns = false;
                dgv_existingProjectsCustomer.DataSource = projects;
                dgv_existingProjectsCustomer.CellValidating += dgv_existingProjectsCustomer_CellValidating;
                dgv_existingProjectsCustomer.CurrentCellDirtyStateChanged += dgv_existingProjectsCustomer_CurrentCellDirtyStateChanged;


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
                customerIdColumn.DataPropertyName = "CustomerId";
                customerIdColumn.HeaderText = "Customer ID";
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

            private void dgv_existingProjectsCustomer_DataError(object sender, DataGridViewDataErrorEventArgs e)
            {
                if (e.Exception.Message == "DataGridViewComboBoxCell value is not valid.")
                {
                    DataGridViewComboBoxCell cell = dgv_existingProjectsCustomer.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewComboBoxCell;
                    object value = cell.Value;
                    if (statusMapping.ContainsValue((int)value))
                    {
                        string key = statusMapping.FirstOrDefault(x => x.Value == (int)value).Key;
                        cell.Value = key;
                        e.ThrowException = false;
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

        private void bt_Refresh_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            List<IProject> projects = projectService.GetProjectsByConsultant(loggedInConsultant.Id)
                .Where(p => p.Status == 1 || p.Status == 2)
                .ToList();

            dgv_existingProjectsCustomer.DataSource = null; // Clear the current data source
            dgv_existingProjectsCustomer.Rows.Clear(); // Clear the existing rows
            dgv_existingProjectsCustomer.Columns.Clear(); // Clear the existing columns

            dgv_existingProjectsCustomer.DataSource = projects; // Assign the updated data source

            // Re-add the columns to the DataGridView
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
            customerIdColumn.DataPropertyName = "CustomerId";
            customerIdColumn.HeaderText = "Customer ID";
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

        private void bt_OpenProject_Click(object sender, EventArgs e)
        {
            ViewCompletedProject();
        }

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
    }

}
