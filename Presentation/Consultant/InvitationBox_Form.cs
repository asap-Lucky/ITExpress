﻿using Abstraction.Interfaces;
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
    public partial class InvitationBox_Form : Form
    {
        List<IInvitation> PendingInvitations { get; set; }
        List<IInvitation> AcceptedInvitations { get; set; }
        IConsultant currentUser;
        BLL.Services.InvitationService invitationService;
        BLL.Services.ProjectService projectService;
        ConsultantOverviewWindow_Form consultantOverviewWindow_Form = new ConsultantOverviewWindow_Form();

        public InvitationBox_Form()
        {
            InitializeComponent();
            currentUser = ConsultantSingleton.Instance().User;
            invitationService = new BLL.Services.InvitationService();
            projectService = new BLL.Services.ProjectService();
            PendingInvitations = invitationService.GetPendingInvitationsForConsultant(currentUser);
            AcceptedInvitations = invitationService.GetAcceptedInvittationsForConsultant(currentUser);
            IntializeDGV(dgv_newInvitations);
            IntializeDGV(dgv_AcceptedInvitations);
            dgv_newInvitations.DataSource = PendingInvitations;
            dgv_AcceptedInvitations.DataSource = AcceptedInvitations;
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

        private void bt_acceptInvitation_Click(object sender, EventArgs e)
        {
            if (dgv_newInvitations.SelectedRows[0].DataBoundItem == null)
            {
                MessageBox.Show("Please Select a New Invitation", "No Selected Invite");
            }
            if(dgv_newInvitations.SelectedRows[0].DataBoundItem != null)
            {
                IInvitation invitation = (IInvitation)dgv_newInvitations.SelectedRows[0].DataBoundItem;
                invitation.AcceptStatus = true;
                PendingInvitations.Remove(invitation);
                AcceptedInvitations.Add(invitation);
                IProject project = invitation.Project;
                project.Consultant = currentUser;
                project.Status = 2;
                projectService.EditProject(project);
                invitationService.EditInvitation(invitation);
                dgv_newInvitations.DataSource = PendingInvitations;
                dgv_AcceptedInvitations.DataSource = AcceptedInvitations;
                dgv_AcceptedInvitations.ClearSelection();
                consultantOverviewWindow_Form.InvitationNotification();
                MessageBox.Show("SUCCESS","SUCCESS");
            }
        }
    }
}
