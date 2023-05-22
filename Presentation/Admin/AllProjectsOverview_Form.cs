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
    public partial class AllProjectsOverview_Form : Form
    {
        IProjectService projectService = new BLL.Services.ProjectService();

        BLL.Facader.ProjectService FacadeService;

        private Dictionary<string, int> statusMapping = new Dictionary<string, int>
            {
                { "Open", 1 },
                { "Closed - Pending", 2 },
                { "Closed", 3 },
            };

        public AllProjectsOverview_Form(IProjectService projectService)
        {
            this.projectService = projectService;
            InitializeComponent();
            InitializeDGV();
            FacadeService = new ProjectService(projectService);
        }

        private void InitializeDGV()
        {
            List<IProject> projects = projectService.GetAllProjects().ToList();

            dgv_AllProjectsOverview.AutoGenerateColumns = false;
            dgv_AllProjectsOverview.DataSource = projects;

            PopulateDGV();
        }

        private void RefreshDGV()
        {
            List<IProject> projects = projectService.GetAllProjects().ToList();

            dgv_AllProjectsOverview.DataSource = null; // Clear the current data source
            dgv_AllProjectsOverview.Rows.Clear(); // Clear the existing rows
            dgv_AllProjectsOverview.Columns.Clear(); // Clear the existing columns

            dgv_AllProjectsOverview.DataSource = projects; // Assign the updated data source

            PopulateDGV();
        }

        private void PopulateDGV()
        {
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

        private void bt_Refresh_Click(object sender, EventArgs e)
        {
            RefreshDGV();
        }

        private void bt_ViewProject_Click(object sender, EventArgs e)
        {

        }

        private void bt_EditProject_Click(object sender, EventArgs e)
        {

        }
    }

}

