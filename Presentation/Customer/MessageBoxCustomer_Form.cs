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

namespace Presentation.Customer
{
    /// <summary>
    /// Djoan
    /// </summary>
    public partial class MessageBoxCustomer : Form
    {
        // Properties to store the messages and their status
        List<IMessage> Messages { get; set; }
        private List<IMessage> UnreadMessages { get; set; }
        private List<IMessage> ReadMessages { get; set; }

        BLL.Services.MessageService MessageService;

        public MessageBoxCustomer()
        {
            InitializeComponent();

            ToolTip newTip = new ToolTip();
            newTip.SetToolTip(bt_writeMessage, "Write a new message");
            ToolTip openTip = new ToolTip();
            openTip.SetToolTip(bt_openMessage, "Open a selected message");

            // Initialize the MessageService
            MessageService = new BLL.Services.MessageService();

            // Retrieve all messages for the current customer
            Messages = MessageService.GetMessagesByCustomer(CustomerSingleton.Instance().User);

            // Separate messages into unread and read categories
            UnreadMessages = Messages.Where(m => m.IsRead == false).ToList();
            ReadMessages = Messages.Where(m => m.IsRead == true).ToList();

            // Configure the DataGridViews
            BreedUnreadDGV(dgv_newMessages);
            BreedReadDGV(dgv_currentConversations);

            // Display the messages in the DataGridViews
            DisplayUnreadMessagesInDGV();
            DisplayReadMessagesInDGV();

            // Clear the selection in DataGridViews
            dgv_newMessages.ClearSelection();
            dgv_currentConversations.ClearSelection();
        }

        private void bt_writeMessage_Click(object sender, EventArgs e)
        {
            // Open the customer message form to compose a new message
            CustomerMessage customerMessage = new CustomerMessage();
            customerMessage.ShowDialog();
        }

        private void BreedReadDGV(DataGridView dataGridView)
        {
            // Configure the DataGridView for read messages
            dgv_currentConversations.AutoGenerateColumns = false;
            dgv_currentConversations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Clear existing columns
            dataGridView.Columns.Clear();

            // Add columns for header and sender name
            DataGridViewTextBoxColumn subjectHeader = new DataGridViewTextBoxColumn();
            subjectHeader.DataPropertyName = "Header";
            subjectHeader.HeaderText = "Header";
            dgv_currentConversations.Columns.Add(subjectHeader);

            DataGridViewTextBoxColumn subjectCustomer = new DataGridViewTextBoxColumn();
            subjectCustomer.DataPropertyName = "GetCustomerName";
            subjectCustomer.HeaderText = "From";
            dgv_currentConversations.Columns.Add(subjectCustomer);
        }

        private void BreedUnreadDGV(DataGridView dataGridView)
        {
            // Configure the DataGridView for unread messages
            dgv_newMessages.AutoGenerateColumns = false;

            // Clear existing columns
            dataGridView.Columns.Clear();

            // Add columns for header and sender name
            DataGridViewTextBoxColumn subjectHeader = new DataGridViewTextBoxColumn();
            subjectHeader.DataPropertyName = "Header";
            subjectHeader.HeaderText = "Header";
            dgv_newMessages.Columns.Add(subjectHeader);

            DataGridViewTextBoxColumn subjectCustomer = new DataGridViewTextBoxColumn();
            subjectCustomer.DataPropertyName = "GetCustomerName";
            subjectCustomer.HeaderText = "From";
            dgv_newMessages.Columns.Add(subjectCustomer);
        }

        private void DisplayUnreadMessagesInDGV()
        {
            // Display the unread messages in the DataGridView
            dgv_newMessages.DataSource = UnreadMessages;
            dgv_newMessages.Refresh();
            dgv_newMessages.ClearSelection();
        }

        private void DisplayReadMessagesInDGV()
        {
            // Display the read messages in the DataGridView
            dgv_currentConversations.DataSource = ReadMessages;
            dgv_currentConversations.Refresh();
            dgv_currentConversations.ClearSelection();
        }

        private void bt_openMessage_Click(object sender, EventArgs e)
        {
            if (dgv_currentConversations.SelectedRows.Count > 0)
            {
                // If a read message is selected, open the message form
                IsReadShowForm();
            }
            else if (dgv_newMessages.SelectedRows.Count > 0)
            {
                // If an unread message is selected, open the message form and mark it as read
                IsNotReadShowForm();
            }
            else
            {
                MessageBox.Show("Please select a message to view.", "No message Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

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

                    // Open the message form for the selected read message
                    CustomerMessage openMessageForm = new CustomerMessage(selectedMessage);
                    openMessageForm.ShowDialog();
                }
            }
        }

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

                    // Open the message form for the selected unread message
                    CustomerMessage openMessageForm = new CustomerMessage(selectedMessage);

                    // Mark the message as read and update its status
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

        private void dgv_newMessages_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Clear the selection in the read messages DataGridView
            dgv_currentConversations.ClearSelection();
        }

        private void dgv_currentConversations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Clear the selection in the unread messages DataGridView
            dgv_newMessages.ClearSelection();
        }

        private void dgv_newMessages_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Clear the selection and refresh the unread messages DataGridView
            dgv_newMessages.ClearSelection();
            dgv_newMessages.Refresh();
        }

        private void dgv_currentConversations_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Clear the selection and refresh the read messages DataGridView
            dgv_currentConversations.ClearSelection();
            dgv_currentConversations.Refresh();
        }
    }
}
