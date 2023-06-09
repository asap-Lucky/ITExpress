using Abstraction.Interfaces;
using BLL.Models;
using BLL.Services;
using BLL.Singleton;
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
    /// <summary>
    ///Code Behind: Mikkel
    //Visual: Marcel
    /// </summary>
    public partial class SearchConsultant : Form
    {
        private ICustomer CustomerUser { get; set; }
        private ProjectService ProjectService { get; set; }
        private BLL.Services.ConsultantService ConsultantService { get; set; }
        private InvitationService InvitationService { get; set; }
        private List<IProject> DefaultProjectList { get; set; }
        private List<IConsultant> DefaultConsultantList { get; set; }
        private List<IConsultant> SortedConsultantsList { get; set; }

        /// <summary>
        /// MikkeL: Constructor for the SearchConsultantForm.
        /// This one uses a user send as a argument instead of singleton cause it's old.
        /// Service are instansiated, and list of project is created with items from the database.
        /// It proceeds to remove project where the status is set to not started yet or the equivalent.
        /// And sets the datasource of the project datagrid.
        /// </summary>
        /// <param name="customerUser"></param>
        public SearchConsultant(ICustomer customerUser)
        {
            InitializeComponent();
            IntializeDataGridView1();
            IntializeDataGridView2();
            this.CustomerUser = customerUser;
            this.ProjectService = new ProjectService();
            this.ConsultantService = new BLL.Services.ConsultantService();
            this.InvitationService = new InvitationService();
            DefaultProjectList = ProjectService.GetProjectsByCostumer(CustomerUser);
            DefaultProjectList.RemoveAll(p => p.Status != 1);
            DefaultConsultantList = this.ConsultantService.GetAllConsultants(); 
            dataGridView1.DataSource = DefaultProjectList;            
            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
        }

        /// <summary>
        /// Mikkel: Intialize the project related datagrid
        /// </summary>
        public void IntializeDataGridView1()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.DataPropertyName = "Name";
            nameColumn.HeaderText = "Project Name";
            dataGridView1.Columns.Add(nameColumn);

            DataGridViewTextBoxColumn languageColumn = new DataGridViewTextBoxColumn();
            languageColumn.DataPropertyName = "GetLangauge";
            languageColumn.HeaderText = "Language";
            dataGridView1.Columns.Add(languageColumn);

            DataGridViewTextBoxColumn endTypeClumn = new DataGridViewTextBoxColumn();
            endTypeClumn.DataPropertyName = "GetEndType";
            endTypeClumn.HeaderText = "End Type";
            dataGridView1.Columns.Add(endTypeClumn);

            DataGridViewTextBoxColumn totalSumColumn = new DataGridViewTextBoxColumn();
            totalSumColumn.DataPropertyName = "TotalSum";
            totalSumColumn.Name = "Total Sum";
            dataGridView1.Columns.Add(totalSumColumn);

            DataGridViewTextBoxColumn startDateColumn = new DataGridViewTextBoxColumn();
            startDateColumn.DataPropertyName = "GetStartDate";
            startDateColumn.HeaderText = "Start Date";
            dataGridView1.Columns.Add(startDateColumn);
        }

       /// <summary>
       /// Mikkel: Intialize the consultant related datagrid
       /// </summary>
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
                IProject selectedProject = (IProject)dataGridView1.SelectedRows[0].DataBoundItem;
                List<IConsultant> targetConsultants = ConsultantService.CodeLangaugeBinarySearch(DefaultConsultantList, selectedProject.Language.Language);
                targetConsultants = ConsultantService.EndTypeBinarySearch(targetConsultants, selectedProject.EndType.EndType1);
                dataGridView2.DataSource = targetConsultants;
            }
        }

        /// <summary>
        /// Mikkel: Functionality for the send invite buton.
        /// It first check if the user has selected a row in each datagrid, notify if the statement is false.
        /// If it passes it creates a new invitation the customer can send to the qualified consulant.
        /// After the creation, another check is made to make sure that project dosen't already have a invitation pending, notify if is.
        /// If all that gets pass, it sends the invitation and updates the datagrid
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_OpenProject_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select A Valid Project", "No Project", MessageBoxButtons.OK);
                return;
            }
            if (dataGridView2.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select A Valid Consultant", "No Consultant", MessageBoxButtons.OK);
                return;
            }            
            Invitation invitation = new Invitation()
            {
                Customer = CustomerSingleton.Instance().User,
                Consultant = (IConsultant)dataGridView2.SelectedRows[0].DataBoundItem,
                Project = (IProject)dataGridView1.SelectedRows[0].DataBoundItem,
                AcceptStatus = false
            };
            if (InvitationService.IsSend(invitation))
            {
                MessageBox.Show("The project already have an invitation pending", "ERROR");
                return;
            }
            InvitationService.AddInvitation(invitation);
            List<IConsultant> consultants = (List<IConsultant>)dataGridView2.DataSource;
            consultants.RemoveAll(c => c == dataGridView2.SelectedRows[0].DataBoundItem as BLL.Models.Consultant);
            dataGridView2.Refresh();
            MessageBox.Show("Invitation Send", "SUCCESS");
        }
    }
}
