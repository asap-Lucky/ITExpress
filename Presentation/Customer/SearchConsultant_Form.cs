using Abstraction.Interfaces;
using BLL.Models;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace Presentation.Customer
{
    //Code Behind: Mikkel
    //Visual: Marcel
    public partial class SearchConsultant : Form
    {
        private ICustomer CustomerUser { get; set; }
        private ProjectService ProjectService { get; set; }
        private BLL.Services.ConsultantService ConsultantService { get; set; }
        private List<IProject> DefaultProjectList { get; set; }
        private List<IConsultant> DefaultConsultantList { get; set; }
        private List<IConsultant> SortedConsultantsList { get; set; }
        public SearchConsultant(ICustomer customerUser)
        {
            InitializeComponent();
            IntializeDataGridView1();
            IntializeDataGridView2();
            this.CustomerUser = customerUser;
            this.ProjectService = new ProjectService();
            this.ConsultantService = new BLL.Services.ConsultantService();
            DefaultProjectList = ProjectService.GetProjectsByCostumer(CustomerUser);
            DefaultConsultantList = this.ConsultantService.GetAllConsultants(); 
            dataGridView1.DataSource = DefaultProjectList;
            dataGridView2.DataSource = DefaultConsultantList;
        }

        //Intialize the project related datagrid
        public void IntializeDataGridView1()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.DataPropertyName = "Name";
            nameColumn.HeaderText = "Project Name";
            dataGridView1.Columns.Add(nameColumn);

            DataGridViewTextBoxColumn totalSumColumn = new DataGridViewTextBoxColumn();
            totalSumColumn.DataPropertyName = "TotalSum";
            totalSumColumn.Name = "Total Sum";
            dataGridView1.Columns.Add(totalSumColumn);

            DataGridViewTextBoxColumn startDateColumn = new DataGridViewTextBoxColumn();
            startDateColumn.DataPropertyName = "GetStartDate";
            startDateColumn.HeaderText = "Start Date";
            dataGridView1.Columns.Add(startDateColumn);
        }

        //Intialize the consultant related datagrid
        public void IntializeDataGridView2()
        {
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DataGridViewTextBoxColumn firstNameColumn = new DataGridViewTextBoxColumn();
            firstNameColumn.DataPropertyName = "FirstName";
            firstNameColumn.HeaderText = "Firstname";
            dataGridView2.Columns.Add(firstNameColumn);

            DataGridViewTextBoxColumn lastNameColumn = new DataGridViewTextBoxColumn();
            lastNameColumn.DataPropertyName = "LastName";
            lastNameColumn.HeaderText = "Lastname";
            dataGridView2.Columns.Add(lastNameColumn);

            DataGridViewTextBoxColumn languageColumn = new DataGridViewTextBoxColumn();
            languageColumn.DataPropertyName = "GetLanguage";
            languageColumn.HeaderText = "Specialization";
            dataGridView2.Columns.Add(languageColumn);

            DataGridViewTextBoxColumn endTypeColumn = new DataGridViewTextBoxColumn();
            endTypeColumn.DataPropertyName = "GetEndType";
            endTypeColumn.HeaderText = "EndType";
            dataGridView2.Columns.Add(endTypeColumn);

            DataGridViewTextBoxColumn emailColumn = new DataGridViewTextBoxColumn();
            emailColumn.DataPropertyName= "Email";
            emailColumn.HeaderText = "Email";
            dataGridView2.Columns.Add(emailColumn);
        }

        private void bt_SearchMatchingConsultant_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                IProject selectedProject = (IProject)dataGridView1.SelectedRows[0];
                List<IConsultant> targetConsultants = ConsultantService.CodeLangaugeBinarySearch(DefaultConsultantList, selectedProject.Language.Language);
                targetConsultants = ConsultantService.EndTypeBinarySearch(targetConsultants, selectedProject.EndType.EndType1);
                dataGridView2.DataSource = targetConsultants;
            }
        }
    }
}
