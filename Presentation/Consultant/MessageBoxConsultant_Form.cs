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

        private Abstraction.Interfaces.IMessage selectedMessage;

        public MessageBoxConsultant()
        {
            InitializeComponent();
            MessageService = new BLL.Services.MessageService();
            Messages = MessageService.GetMessagesByConsultant(ConsultantSingleton.Instance().User);
            UnreadMessages = Messages.Where(m => m.IsRead == true).ToList();
            ReadMessages = Messages.Where(m => m.IsRead == false).ToList();
            BreedUnreadDGV(dgv_MessageDisplay);
            DisplayreadMessagesInDGV();
        }

        private void BreedUnreadDGV(DataGridView dataGridView)
        {
            dgv_MessageDisplay.AutoGenerateColumns = false;
            dgv_MessageDisplay.RowHeadersVisible = false;
            dgv_MessageDisplay.MultiSelect = false;
            dgv_MessageDisplay.CellContentClick += dgv_newMessages_CellContentClick;
            dgv_MessageDisplay.CellBeginEdit += dgv_newMessages_CellBeginEdit;
            dgv_MessageDisplay.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView.Columns.Clear();

            DataGridViewTextBoxColumn subjectHeader = new DataGridViewTextBoxColumn();
            subjectHeader.Name = "Header";
            subjectHeader.DataPropertyName = "Header";
            subjectHeader.HeaderText = "Header";
            subjectHeader.ReadOnly = true;
            dgv_MessageDisplay.Columns.Add(subjectHeader);

            DataGridViewTextBoxColumn subjectCustomer = new DataGridViewTextBoxColumn();
            subjectCustomer.DataPropertyName = "GetCustomerName";
            subjectCustomer.HeaderText = "From";
            subjectCustomer.ReadOnly = true;
            dgv_MessageDisplay.Columns.Add(subjectCustomer);

            DataGridViewCheckBoxColumn subjectIsRead = new DataGridViewCheckBoxColumn();
            subjectIsRead.Name = "IsRead";
            subjectIsRead.DataPropertyName = "IsRead";
            subjectIsRead.HeaderText = "IsRead";
            subjectIsRead.ReadOnly = false;
            dgv_MessageDisplay.Columns.Add(subjectIsRead);
        }

        private void dgv_newMessages_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            int allowedColumnIndex = 0;

            // Cancel the edit operation for other columns
            if (e.ColumnIndex != allowedColumnIndex)
            {
                e.Cancel = false;
            }
        }

        //This does work partially. It does not display the messages in the dgv because the on line 64 it takes an input of an object and not an int value. Do stuff about it.

        private void DisplayreadMessagesInDGV()
        {
            dgv_MessageDisplay.DataSource = ReadMessages;
        }

        private void dgv_newMessages_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgv_MessageDisplay.Columns["IsRead"].Index)
            {
                if (e.RowIndex < dgv_MessageDisplay.Rows.Count)
                {
                    DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)dgv_MessageDisplay.Rows[e.RowIndex].Cells["IsRead"];
                    if (checkBoxCell != null)
                    {
                        bool isChecked = (bool)checkBoxCell.Value;
                        IMessage message = (IMessage)dgv_MessageDisplay.Rows[e.RowIndex].DataBoundItem;
                        if (message != null)
                        {
                            // Update the IsRead property of the message based on the checkbox value
                            message.IsRead = isChecked;

                            if (isChecked)
                            {
                                // Move the message from UnreadMessages to ReadMessages
                                UnreadMessages.Remove(message);
                                ReadMessages.Add(message);

                                // Reset the DataSource of dgv_newMessages to update the displayed messages
                                dgv_MessageDisplay.DataSource = null;
                                dgv_MessageDisplay.DataSource = UnreadMessages;
                            }

                            // Refresh dgv_currentConversations to update the displayed messages
                            dgv_MessageDisplay.Refresh();
                        }
                    }
                }
            }
        }

        private void SaveChangesOnUnopenedMessages()
        {
            foreach (DataGridViewRow row in dgv_MessageDisplay.Rows)
            {
                if (!row.IsNewRow && row.Cells["IsRead"].Value != null && Convert.ToBoolean(row.Cells["IsRead"].Value))
                {
                    var messageDto = this.Messages.FirstOrDefault(m => m.MessageId == ((IMessage)row.DataBoundItem).MessageId);

                    if (messageDto != null)
                    {
                        // Update the message properties based on the DataGridView values
                        messageDto.IsRead = Convert.ToBoolean(row.Cells["IsRead"].Value);
                    }
                }
            }
        }

        private void bt_SaveChanges_Click(object sender, EventArgs e)
        {
            SaveChangesOnUnopenedMessages();

            foreach (IMessage message in Messages)
            {
                MessageService.GetMessage(selectedMessage); // This is where the error is. It is not getting the message.
            }
        }

        private void bt_openMessage_Click(object sender, EventArgs e)
        {
            IsReadShowForm();
        }

        private void IsReadShowForm()
        {
            if (dgv_MessageDisplay.SelectedRows.Count > 0)
            {
                IMessage selectedMessage = (IMessage)dgv_MessageDisplay.SelectedRows[0].DataBoundItem;

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
