using BLL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Abstraction.Interfaces;
using BLL.Models;
using BLL.Singleton;
using Presentation.All;
using Presentation.Consultant;

namespace Presentation.Customer
{
    /// <summary>
    /// Djoan og Marcel
    /// </summary>
    public partial class MessageBoxConsultant : Form
    {
        List<IMessage> Messages { get; set; }
        private List<IMessage> UnreadMessages { get; set; }
        private List<IMessage> ReadMessages { get; set; }

        BLL.Services.MessageService MessageService;

        public MessageBoxConsultant()
        {
            InitializeComponent();
            MessageService = new BLL.Services.MessageService();
            Messages = MessageService.GetMessagesByConsultant(ConsultantSingleton.Instance().User);
            UnreadMessages = Messages.Where(m => m.IsRead == false).ToList();
            ReadMessages = Messages.Where(m => m.IsRead == true).ToList();
            BreedUnreadDGV(dgv_newMessages);
            BreedReadDGV(dgv_currentConversations);
            DisplayUnreadMessagesInDGV();
            DisplayReadMessagesInDGV();

            dgv_newMessages.ClearSelection();
            dgv_currentConversations.ClearSelection();
        }

        // Opens the form to write a new message
        private void bt_writeMessage_Click(object sender, EventArgs e)
        {
            CustomerMessage customerMessage = new CustomerMessage();
            customerMessage.ShowDialog();
        }

        // Configures the DataGridView for displaying read messages
        private void BreedReadDGV(DataGridView dataGridView)
        {
            dgv_currentConversations.AutoGenerateColumns = false;
            dgv_currentConversations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView.Columns.Clear();

            DataGridViewTextBoxColumn subjectHeader = new DataGridViewTextBoxColumn();
            subjectHeader.DataPropertyName = "Header";
            subjectHeader.HeaderText = "Header";
            dgv_currentConversations.Columns.Add(subjectHeader);

            DataGridViewTextBoxColumn subjectCustomer = new DataGridViewTextBoxColumn();
            subjectCustomer.DataPropertyName = "GetCustomerName";
            subjectCustomer.HeaderText = "From";
            dgv_currentConversations.Columns.Add(subjectCustomer);
        }

        // Configures the DataGridView for displaying unread messages
        private void BreedUnreadDGV(DataGridView dataGridView)
        {
            dgv_newMessages.AutoGenerateColumns = false;

            dataGridView.Columns.Clear();

            DataGridViewTextBoxColumn subjectHeader = new DataGridViewTextBoxColumn();
            subjectHeader.DataPropertyName = "Header";
            subjectHeader.HeaderText = "Header";
            dgv_newMessages.Columns.Add(subjectHeader);

            DataGridViewTextBoxColumn subjectCustomer = new DataGridViewTextBoxColumn();
            subjectCustomer.DataPropertyName = "GetCustomerName";
            subjectCustomer.HeaderText = "From";
            dgv_newMessages.Columns.Add(subjectCustomer);
        }

        // Displays unread messages in the DataGridView
        private void DisplayUnreadMessagesInDGV()
        {
            dgv_newMessages.DataSource = UnreadMessages;
            dgv_newMessages.Refresh();
            dgv_newMessages.ClearSelection();
        }

        // Displays read messages in the DataGridView
        private void DisplayReadMessagesInDGV()
        {
            dgv_currentConversations.DataSource = ReadMessages;
            dgv_currentConversations.Refresh();
            dgv_currentConversations.ClearSelection();
        }

        // Handles the event when the "Open Message" button is clicked
        private void bt_openMessage_Click(object sender, EventArgs e)
        {
            if (dgv_currentConversations.SelectedRows.Count > 0)
            {
                IsReadShowForm();
            }
            else if (dgv_newMessages.SelectedRows.Count > 0)
            {
                IsNotReadShowForm();
            }
            else
            {
                MessageBox.Show("Please select a message to view.", "No message Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Displays the form for a read message
        private void IsReadShowForm()
        {
            if (dgv_currentConversations.SelectedRows.Count > 0)
            {
                // Get the selected row index
                int selectedIndex = dgv_currentConversations.SelectedRows[0].Index;

                // Check if the index is valid
                if (selectedIndex >= 0 && selectedIndex < dgv_currentConversations.Rows.Count)
                {
                    // Access the selected item
                    IMessage selectedMessage = (IMessage)dgv_currentConversations.Rows[selectedIndex].DataBoundItem;

                    ConsultantMessage_Form openMessageForm = new ConsultantMessage_Form(selectedMessage);
                    openMessageForm.ShowDialog();
                }
            }
        }

        // Displays the form for an unread message
        private void IsNotReadShowForm()
        {
            if (dgv_newMessages.SelectedRows.Count > 0)
            {
                // Get the selected row index
                int selectedIndex = dgv_newMessages.SelectedRows[0].Index;

                // Check if the index is valid
                if (selectedIndex >= 0 && selectedIndex < UnreadMessages.Count)
                {
                    // Access the selected item
                    IMessage selectedMessage = UnreadMessages[selectedIndex];

                    ConsultantMessage_Form openMessageForm = new ConsultantMessage_Form(selectedMessage);
                    selectedMessage.IsRead = true;
                    MessageService.UpdateMessageStatus(selectedMessage);
                    openMessageForm.ShowDialog();

                    // Remove the item from the list after displaying the form
                    UnreadMessages.Remove(selectedMessage);
                    ReadMessages.Add(selectedMessage);

                    // Rebind the updated lists to the DataGridViews
                    dgv_newMessages.DataSource = UnreadMessages.ToList();
                    dgv_currentConversations.DataSource = ReadMessages.ToList();

                    // Clear the selection and refresh the DataGridViews
                    dgv_newMessages.ClearSelection();
                    dgv_currentConversations.ClearSelection();
                    dgv_newMessages.Refresh();
                    dgv_currentConversations.Refresh();
                }
            }
        }

        // Clears the selection in the "Unread Messages" DataGridView
        private void dgv_newMessages_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_currentConversations.ClearSelection();
        }

        // Clears the selection in the "Current Conversations" DataGridView
        private void dgv_currentConversations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_newMessages.ClearSelection();
        }

        // Clears the selection and refreshes the "Unread Messages" DataGridView
        private void dgv_newMessages_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgv_newMessages.ClearSelection();
            dgv_newMessages.Refresh();
        }

        // Clears the selection and refreshes the "Current Conversations" DataGridView
        private void dgv_currentConversations_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgv_currentConversations.ClearSelection();
            dgv_currentConversations.Refresh();
        }
    }
}
