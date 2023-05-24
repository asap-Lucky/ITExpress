using Abstraction.Interfaces;
using BLL;
using BLL.Singleton;
using Presentation.Consultant;
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
    public partial class CustomerInvitationBox_Form : Form
    {
        List<IInvitation> PendingInvitations { get; set; }
        List<IInvitation> AcceptedInvitations { get; set; }
        Abstraction.Interfaces.ICustomer currentUser;
        BLL.Services.InvitationService invitationService;
        BLL.Services.ProjectService projectService;
        CustomerOverviewWindow_Form customerOverviewWindow_Form = new CustomerOverviewWindow_Form();

        public CustomerInvitationBox_Form()
        {
            InitializeComponent();
            currentUser = CustomerSingleton.Instance().User;
            invitationService = new BLL.Services.InvitationService();
            projectService = new BLL.Services.ProjectService();

            List<IInvitation> invitations = invitationService.GetInvitationsViaCostumer(BLL.Singleton.CustomerSingleton.Instance().User);
            PendingInvitations = invitations.Where(i => i.AcceptStatus == false).ToList(); ;
            AcceptedInvitations = invitations.Where(i => i.AcceptStatus == true).ToList();
            IntializeDGV(dgv_newInvitations);
            IntializeDGV(dgv_AcceptedInvitations);
            dgv_newInvitations.Refresh();
            dgv_AcceptedInvitations.Refresh();
            dgv_newInvitations.ClearSelection();
            dgv_AcceptedInvitations.ClearSelection();
        }

        private void bt_acceptInvitation_Click(object sender, EventArgs e)
        {
            if (dgv_newInvitations.SelectedRows[0].DataBoundItem == null)
            {
                MessageBox.Show("Please Select a New Invitation", "No Selected Invite");
            }
            if (dgv_newInvitations.SelectedRows[0].DataBoundItem != null)
            {
                IInvitation invitation = (IInvitation)dgv_newInvitations.SelectedRows[0].DataBoundItem;
                invitation.AcceptStatus = true;
                PendingInvitations.Remove(invitation);
                AcceptedInvitations.Add(invitation);
                IProject project = invitation.Project;                
                project.Status = 2;
                projectService.EditProject(project);
                invitationService.EditInvitation(invitation);
                dgv_newInvitations.Refresh();
                dgv_AcceptedInvitations.Refresh();
                dgv_AcceptedInvitations.ClearSelection();
                dgv_newInvitations.ClearSelection();
                customerOverviewWindow_Form.InvitationNotification();
                MessageBox.Show("SUCCESS", "SUCCESS");
            }
        }

        private void IntializeDGV(DataGridView targetDataGridView)
        {
            targetDataGridView.AutoGenerateColumns = false;
            targetDataGridView.RowHeadersVisible = false;
            targetDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DataGridViewTextBoxColumn projectNameColumn = new DataGridViewTextBoxColumn();
            projectNameColumn.DataPropertyName = "GetProjectName";
            projectNameColumn.HeaderText = "Project Name";
            targetDataGridView.Columns.Add(projectNameColumn);

            DataGridViewTextBoxColumn customerNameColumn = new DataGridViewTextBoxColumn();
            customerNameColumn.DataPropertyName = "GetCustomerName";
            customerNameColumn.HeaderText = "Customer";
            targetDataGridView.Columns.Add(customerNameColumn);

            DataGridViewTextBoxColumn languageColumn = new DataGridViewTextBoxColumn();
            languageColumn.DataPropertyName = "GetProjectLanguage";
            languageColumn.HeaderText = "Langauge";
            targetDataGridView.Columns.Add(languageColumn);

            DataGridViewTextBoxColumn endTypeColumn = new DataGridViewTextBoxColumn();
            endTypeColumn.DataPropertyName = "GetProjectEndtype";
            endTypeColumn.HeaderText = "End Type";
            targetDataGridView.Columns.Add(endTypeColumn);
        }
    }
}
