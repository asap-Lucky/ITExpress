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

        /// <summary>
        /// Mikkel: Constructor for the CustomerInvitaitonBox_Form.
        /// It first uses the CustomerSingleton to get the current user which is a customer and the instiatate the relevent services.
        /// Using that, it gets the relevant invitations as list and proceeds to sort the list depending on the acceptstatus.
        /// It the intialize each of the two datagrids, set the source, and clear the selection because we had index problems with the datagrid.
        /// </summary>
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
            dgv_newInvitations.DataSource = PendingInvitations;
            dgv_AcceptedInvitations.DataSource = AcceptedInvitations;
            dgv_newInvitations.ClearSelection();
            dgv_AcceptedInvitations.ClearSelection();
        }

        /// <summary>
        /// Mikkel: Click event for the accept invitation button.
        /// It first checks if there is a selected row in the datagrid, and notifies the user if there isn't
        /// If there is, it starts off by taking the selected row databunditem as a invitation.
        /// It proceeds to set the invitation AcceptStatus to true, 
        /// removes the invitation from the new datagrid datasource and adds to the accepted datagrid's source.
        /// Edits the relevant project status to in progress, edits it in the database using projectService.
        /// Then over to the invitation and edit that in the database.
        /// Refresh the form and notifiy the user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_acceptInvitation_Click(object sender, EventArgs e)
        {
            if (dgv_newInvitations.SelectedRows[0].DataBoundItem == null)
            {
                MessageBox.Show("Please Select a New Invitation", "No Selected Invite");
            }
            if (dgv_newInvitations.SelectedRows[0].DataBoundItem != null)
            {
                IInvitation invitation = (IInvitation)dgv_newInvitations.SelectedRows[0].DataBoundItem;
                dgv_newInvitations.ClearSelection();
                invitation.AcceptStatus = true;
                PendingInvitations.Remove(invitation);
                AcceptedInvitations.Add(invitation);
                IProject project = invitation.Project;                
                project.Status = 4;
                projectService.EditProject(project);
                invitationService.EditInvitation(invitation);
                dgv_newInvitations.DataSource = PendingInvitations;
                dgv_AcceptedInvitations.DataSource = dgv_AcceptedInvitations;
                customerOverviewWindow_Form.InvitationNotification();
                dgv_newInvitations.DataSource = null;
                dgv_AcceptedInvitations.DataSource = null;
                dgv_newInvitations.DataSource = PendingInvitations;
                dgv_AcceptedInvitations.DataSource = AcceptedInvitations;
                MessageBox.Show("SUCCESS", "SUCCESS");
            }
        }

        /// <summary>
        /// Mikkel: Does what it says on tint. That is Intializing the datagrids.
        /// </summary>
        /// <param name="targetDataGridView"></param>
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

        /// <summary>
        /// Mikkel: the decline button function.
        /// Does some of the same as the accept button, but removes the invitation instead.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDecline_Click(object sender, EventArgs e)
        {
            if (dgv_newInvitations.SelectedRows[0].DataBoundItem == null)
            {
                MessageBox.Show("Please Select a New Invitation", "No Selected Invite");
            }
            if (dgv_newInvitations.SelectedRows[0].DataBoundItem != null)
            {
                IInvitation invitation = (IInvitation)dgv_newInvitations.SelectedRows[0].DataBoundItem;
                dgv_newInvitations.ClearSelection();
                invitationService.DeleteInvitation(invitation);
                PendingInvitations.Remove(invitation);
                dgv_newInvitations.Refresh();
                customerOverviewWindow_Form.InvitationNotification();
                MessageBox.Show("Invitation Was Decline And Deleted", "DECLINE");
            }
        }

        /// <summary>
        /// Mikkel: Refresh button goes brrr
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            dgv_AcceptedInvitations.Refresh();
            dgv_newInvitations.Refresh();
        }
    }
}
