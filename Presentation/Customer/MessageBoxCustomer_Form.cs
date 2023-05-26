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
    public partial class MessageBoxCustomer : Form
    {
        List<IMessage> Messages { get; set; }
        private List<IMessage> UnreadMessages { get; set; }
        private List<IMessage> ReadMessages { get; set; }

        BLL.Services.MessageService MessageService;

        public MessageBoxCustomer()
        {
            InitializeComponent();
            MessageService = new BLL.Services.MessageService();
            Messages = MessageService.GetMessagesByCustomer(CustomerSingleton.Instance().User);
            UnreadMessages = Messages.Where(m => m.IsRead == false).ToList();
            ReadMessages = Messages.Where(m => m.IsRead == true).ToList();
            BreedUnreadDGV(dgv_newMessages);
            BreedReadDGV(dgv_currentConversations);
            DisplayUnreadMessagesInDGV();
            DisplayreadMessagesInDGV();

            dgv_newMessages.ClearSelection();
            dgv_currentConversations.ClearSelection();
        }

        private void bt_writeMessage_Click(object sender, EventArgs e)
        {
            CustomerMessage customerMessage = new CustomerMessage(BLL.Singleton.CustomerSingleton.Instance().User);
            customerMessage.ShowDialog();
        }

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

        private void DisplayUnreadMessagesInDGV()
        {
            dgv_newMessages.DataSource = UnreadMessages;
            dgv_newMessages.Refresh();
            dgv_newMessages.ClearSelection();
        }

        private void DisplayreadMessagesInDGV()
        {
            dgv_currentConversations.DataSource = ReadMessages;
            dgv_currentConversations.Refresh();
            dgv_currentConversations.ClearSelection();
        }

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

                    RecieveMessage_Form openMessageForm = new RecieveMessage_Form(selectedMessage);
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

                    RecieveMessage_Form openMessageForm = new RecieveMessage_Form(selectedMessage);
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
            dgv_currentConversations.ClearSelection();
        }

        private void dgv_currentConversations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_newMessages.ClearSelection();
        }

        private void dgv_newMessages_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgv_newMessages.ClearSelection();
            dgv_newMessages.Refresh();
        }

        private void dgv_currentConversations_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgv_currentConversations.ClearSelection();
            dgv_currentConversations.Refresh();
        }
    }
}
