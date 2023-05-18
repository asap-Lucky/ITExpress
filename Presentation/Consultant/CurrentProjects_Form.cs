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
        private Abstraction.Interfaces.IConsultant loggedInConsultant;

        private Abstraction.Interfaces.IProjectService projectService;

        IConsultantService consultantService = new BLL.Services.ConsultantService();

        BLL.Facader.ConsultantService FacadeService;

        public CurrentProjects_Form(IConsultant loggedInConsultant, IProjectService projectService)
        {
            this.loggedInConsultant = loggedInConsultant;
            this.projectService = projectService;
            InitializeComponent();
            InitializeDataGridView();
            FacadeService = new BLL.Facader.ConsultantService(consultantService);
        }

        public void InitializeDataGridView()
        {
            List<IProject> projects = projectService.GetProjectsByConsultant(loggedInConsultant.Id);

            // Clear any existing rows and columns in the DataGridView
            dgv_existingProjectsCustomer.Rows.Clear();
            dgv_existingProjectsCustomer.Columns.Clear();

            // Add columns to the DataGridView
            dgv_existingProjectsCustomer.Columns.Add("NameColumn", "Name");
            dgv_existingProjectsCustomer.Columns.Add("TotalSumColumn", "Total Sum");
            dgv_existingProjectsCustomer.Columns.Add("StartDateColumn", "Start Date");
            dgv_existingProjectsCustomer.Columns.Add("EndDateColumn", "End Date");
            dgv_existingProjectsCustomer.Columns.Add("DescriptionColumn", "Description");
            dgv_existingProjectsCustomer.Columns.Add("StatusColumn", "Status");
            dgv_existingProjectsCustomer.Columns.Add("CustomerIdColumn", "Customer ID");
            dgv_existingProjectsCustomer.Columns.Add("LanguageColumn", "Language");
            dgv_existingProjectsCustomer.Columns.Add("EndTypeColumn", "End Type");

            // Add the projects to the DataGridView
            foreach (IProject project in projects)
            {
                // Map the properties to the DataGridView cells
                dgv_existingProjectsCustomer.Rows.Add(
                    project.Name,
                    project.TotalSum,
                    project.StartDate,
                    project.EndDate,
                    project.Description,
                    project.Status,
                    project.CustomerId,
                    project.Language.Language,
                    project.EndType.EndType1
                );
            }
        }
    }
}
