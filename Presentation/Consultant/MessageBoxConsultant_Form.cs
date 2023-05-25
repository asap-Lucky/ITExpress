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
    public partial class MessageBoxConsultant : Form
    {
        List<IMessage> Messages { get; set; }
        private List<IMessage> UnreadMessages { get; set; }
        private List<IMessage> ReadMessages { get; set; }

        private BLL.Services.MessageService MessageService;

        public MessageBoxConsultant()
        {
            InitializeComponent();
            MessageService = new BLL.Services.MessageService();
            Messages = MessageService.GetMessagesByConsultant(ConsultantSingleton.Instance().User);
            UnreadMessages = Messages.Where(m => m.IsRead == true).ToList();
            ReadMessages = Messages.Where(m => m.IsRead == false).ToList();
            BreedUnreadDGV(dgv_newMessages);
            BreedReadDGV(dgv_currentConversations);
            DisplayUnreadMessagesInDGV();
            DisplayreadMessagesInDGV();
        }

        private void BreedReadDGV(DataGridView dataGridView)
        {
            dgv_currentConversations.AutoGenerateColumns = false;
            dgv_currentConversations.RowHeadersVisible = false;
            dgv_currentConversations.MultiSelect = false;
            dgv_currentConversations.ReadOnly = true;
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

            DataGridViewCheckBoxColumn subjectIsRead = new DataGridViewCheckBoxColumn();
            subjectIsRead.DataPropertyName = "IsRead";
            subjectIsRead.HeaderText = "IsRead";
            dgv_currentConversations.Columns.Add(subjectIsRead);
        }

        private void BreedUnreadDGV(DataGridView dataGridView)
        {
            dgv_newMessages.AutoGenerateColumns = false;
            dgv_newMessages.RowHeadersVisible = false;
            dgv_newMessages.MultiSelect = false;
            dgv_newMessages.ReadOnly = false;
            dgv_newMessages.CellContentClick += dgv_newMessages_CellContentClick;
            dgv_newMessages.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView.Columns.Clear();

            DataGridViewTextBoxColumn subjectHeader = new DataGridViewTextBoxColumn();
            subjectHeader.DataPropertyName = "Header";
            subjectHeader.HeaderText = "Header";
            dgv_newMessages.Columns.Add(subjectHeader);

            DataGridViewTextBoxColumn subjectCustomer = new DataGridViewTextBoxColumn();
            subjectCustomer.DataPropertyName = "GetCustomerName";
            subjectCustomer.HeaderText = "From";
            dgv_newMessages.Columns.Add(subjectCustomer);

            DataGridViewCheckBoxColumn subjectIsRead = new DataGridViewCheckBoxColumn();
            subjectIsRead.Name = "IsRead";
            subjectIsRead.DataPropertyName = "IsRead";
            subjectIsRead.HeaderText = "IsRead";
            dgv_newMessages.Columns.Add(subjectIsRead);
        }

        //This does work partially. It does not display the messages in the dgv because the on line 64 it takes an input of an object and not an int value. Do stuff about it.
        private void DisplayUnreadMessagesInDGV()
        {
            dgv_newMessages.DataSource = UnreadMessages;
        }

        private void DisplayreadMessagesInDGV()
        {
            dgv_newMessages.DataSource = ReadMessages;
        }

        private void dgv_newMessages_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgv_newMessages.Columns["IsRead"].Index)
            {
                if (e.RowIndex < dgv_newMessages.Rows.Count)
                {
                    DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)dgv_newMessages.Rows[e.RowIndex].Cells["IsRead"];
                    if (checkBoxCell != null)
                    {
                        bool isChecked = (bool)checkBoxCell.Value;
                        IMessage message = (IMessage)dgv_newMessages.Rows[e.RowIndex].DataBoundItem;
                        if (message != null)
                        {
                            // Update the IsRead property of the message based on the checkbox value
                            message.IsRead = !isChecked;

                            if (!isChecked)
                            {
                                // Move the message from UnreadMessages to ReadMessages
                                UnreadMessages.Remove(message);
                                ReadMessages.Add(message);

                                // Reset the DataSource of dgv_newMessages to update the displayed messages
                                dgv_newMessages.DataSource = null;
                                dgv_newMessages.DataSource = UnreadMessages;

                                // Add the message to the dgv_currentConversations DataGridView
                                dgv_currentConversations.Rows.Add(message.Header, message.GetCustomerName, message.IsRead);
                            }

                            // Refresh dgv_currentConversations to update the displayed messages
                            dgv_currentConversations.Refresh();
                        }
                    }
                }
            }
        }

        private void bt_SaveChanges_Click(object sender, EventArgs e)
        {

        }

        private void bt_openMessage_Click(object sender, EventArgs e)
        {
            IsReadShowForm();
            IsNotReadShowForm();
        }

        private void IsReadShowForm()
        {
            if (dgv_currentConversations.SelectedRows.Count > 0)
            {
                IMessage selectedMessage = (IMessage)dgv_currentConversations.SelectedRows[0].DataBoundItem;

                RecieveMessage_Form openMessageForm = new RecieveMessage_Form(selectedMessage);
                openMessageForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a message to view.", "No message Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void IsNotReadShowForm()
        {
            if (dgv_newMessages.SelectedRows.Count > 0)
            {
                IMessage selectedMessage = (IMessage)dgv_newMessages.SelectedRows[0].DataBoundItem;

                RecieveMessage_Form openMessageForm = new RecieveMessage_Form(selectedMessage);
                openMessageForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a message to view.", "No message Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
