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

        // Create a dictionary to map status text values to corresponding integer values
        private Dictionary<string, int> statusMapping = new Dictionary<string, int>
        {
            { "Open", 1 },               // Map "Open" to 1
            { "Pending review", 2 },     // Map "Pending review" to 2
            { "Closed", 3 }              // Map "Closed" to 3
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

            DataGridViewTextBoxColumn descriptionColumn = new DataGridViewTextBoxColumn();
            descriptionColumn.DataPropertyName = "Description";
            descriptionColumn.HeaderText = "Description";
            dgv_existingProjectsCustomer.Columns.Add(descriptionColumn);

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

            // Set the value type of the column explicitly as int
            statusColumn.ValueType = typeof(int);

            // Set the value member to "Value" to represent the integer values in the dictionary
            statusColumn.ValueMember = "Value";

            // Set the display member to "Key" to represent the text values in the dictionary
            statusColumn.DisplayMember = "Key";

            // Set the data source of the column to a BindingSource initialized with the statusMapping dictionary
            statusColumn.DataSource = new BindingSource(statusMapping, null);

            // Add the status column to the DataGridView
            dgv_existingProjectsCustomer.Columns.Add(statusColumn);

        }

        /// <summary>
        /// Event handler for the DataError event of the dgv_existingProjectsCustomer DataGridView.
        /// This event is triggered when there is an error in the data entered in the DataGridView.
        /// The purpose of this event handler is to handle the error specific to DataGridViewComboBoxCell.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">A DataGridViewDataErrorEventArgs that contains the event data.</param>
        private void dgv_existingProjectsCustomer_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Check if the error is due to an invalid DataGridViewComboBoxCell value
            if (e.Exception.Message == "DataGridViewComboBoxCell value is not valid.")
            {
                // Retrieve the DataGridViewComboBoxCell that triggered the error
                DataGridViewComboBoxCell cell = dgv_existingProjectsCustomer.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewComboBoxCell;

                // Retrieve the value that caused the error
                object value = cell.Value;

                // Check if the value exists in the statusMapping dictionary
                if (statusMapping.ContainsValue((int)value))
                {
                    // Find the corresponding key for the value in the statusMapping dictionary
                    string key = statusMapping.FirstOrDefault(x => x.Value == (int)value).Key;

                    // Set the value of the cell to the corresponding key
                    cell.Value = key;

                    // Set ThrowException to false to indicate that the error has been handled
                    e.ThrowException = false;
                }
            }
        }
    }
}
