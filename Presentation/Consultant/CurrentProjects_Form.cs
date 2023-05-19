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
                { "Pending review", 2 },
                { "Closed", 3 }
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
                dgv_existingProjectsCustomer.Columns.Add(nameColumn);

                DataGridViewTextBoxColumn totalSumColumn = new DataGridViewTextBoxColumn();
                totalSumColumn.DataPropertyName = "TotalSum";
                totalSumColumn.HeaderText = "Total Sum";
                dgv_existingProjectsCustomer.Columns.Add(totalSumColumn);

                DataGridViewTextBoxColumn startDateColumn = new DataGridViewTextBoxColumn();
                startDateColumn.DataPropertyName = "StartDate";
                startDateColumn.HeaderText = "Start Date";
                dgv_existingProjectsCustomer.Columns.Add(startDateColumn);

                DataGridViewTextBoxColumn endDateColumn = new DataGridViewTextBoxColumn();
                endDateColumn.DataPropertyName = "EndDate";
                endDateColumn.HeaderText = "End Date";
                dgv_existingProjectsCustomer.Columns.Add(endDateColumn);

                DataGridViewTextBoxColumn customerIdColumn = new DataGridViewTextBoxColumn();
                customerIdColumn.DataPropertyName = "CustomerId";
                customerIdColumn.HeaderText = "Customer ID";
                dgv_existingProjectsCustomer.Columns.Add(customerIdColumn);

                DataGridViewTextBoxColumn languageColumn = new DataGridViewTextBoxColumn();
                languageColumn.DataPropertyName = "GetLangauge";
                languageColumn.HeaderText = "Language";
                dgv_existingProjectsCustomer.Columns.Add(languageColumn);

                DataGridViewTextBoxColumn endTypeColumn = new DataGridViewTextBoxColumn();
                endTypeColumn.DataPropertyName = "GetEndType";
                endTypeColumn.HeaderText = "End Type";
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

            private void dgv_existingProjectsCustomer_CellValueChanged(object sender, DataGridViewCellEventArgs e)
            {
                //if (dgv_existingProjectsCustomer.Columns[e.ColumnIndex].Name == "Status" && e.RowIndex >= 0)
                //{
                //    DataGridViewComboBoxCell cell = dgv_existingProjectsCustomer.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewComboBoxCell;
                //    object newValue = cell.Value;
                //    object currentValue = cell.Tag; // Use the Tag property to store the original value

                //    if (!newValue.Equals(currentValue))
                //    {
                //        string selectedStatus = cell.FormattedValue.ToString(); // Use FormattedValue to get the displayed text

                //        DialogResult result = MessageBox.Show($"Are you sure you want to change the status to '{selectedStatus}'?", "Confirm Status Change", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                //        if (result == DialogResult.Yes)
                //        {
                //            IProject project = dgv_existingProjectsCustomer.Rows[e.RowIndex].DataBoundItem as IProject;
                //            project.Status = statusMapping[selectedStatus];
                //            projectService.EditProject(project);
                //            dgv_existingProjectsCustomer.Refresh();
                //        }
                //        else
                //        {
                //            // Restore the original value in case the user cancels the change
                //            cell.Value = currentValue;
                //            dgv_existingProjectsCustomer.RefreshEdit();
                //        }
                //    }
                //}
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
        }
        
    }
