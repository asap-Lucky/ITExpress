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
    public partial class CurrentProjects_Form : Form
    {
        private IConsultant loggedInConsultant;
        private IProjectService projectService;
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
        }

        public void InitializeDataGridView()
        {
            List<IProject> projects = projectService.GetProjectsByConsultant(loggedInConsultant.Id);

            dgv_existingProjectsCustomer.AutoGenerateColumns = false;
            dgv_existingProjectsCustomer.DataSource = projects;
            dgv_existingProjectsCustomer.CellValidating += dgv_existingProjectsCustomer_CellValidating;

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

        private void dgv_existingProjectsCustomer_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dgv_existingProjectsCustomer.Columns[e.ColumnIndex].Name == "Status")
            {
                DataGridViewComboBoxCell cell = dgv_existingProjectsCustomer.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewComboBoxCell;
                object newValue = e.FormattedValue;
                object currentValue = cell.Value;

                if (!newValue.Equals(currentValue))
                {
                    string selectedStatus = newValue.ToString();
                    DialogResult result = MessageBox.Show($"Are you sure you want to change the status to '{selectedStatus}'?", "Confirm Status Change", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        IProject project = dgv_existingProjectsCustomer.Rows[e.RowIndex].DataBoundItem as IProject;
                        project.Status = statusMapping[selectedStatus];
                        projectService.EditProject(project);
                        dgv_existingProjectsCustomer.Refresh();
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
            }
        }
    }
}
