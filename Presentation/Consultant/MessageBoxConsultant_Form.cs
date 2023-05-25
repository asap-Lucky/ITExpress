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
        private Abstraction.Interfaces.IMessage selectedMessage { get; set; }
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
            BreedUnreadDGV(dgv_MessageDisplay);
            DisplayreadMessagesInDGV();
        }


        //Methods used in the constructor


        private void BreedUnreadDGV(DataGridView dataGridView)
        {
            dgv_MessageDisplay.AutoGenerateColumns = false;
            dgv_MessageDisplay.RowHeadersVisible = false;
            dgv_MessageDisplay.MultiSelect = false;

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

        private void DisplayreadMessagesInDGV()
        {
            dgv_MessageDisplay.DataSource = ReadMessages;
        }


        //Click events and methods used in the click events

     


        //Changes the checkbox emediatly on the DGV
        private void dgv_MessageDisplay_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgv_MessageDisplay.Rows[e.RowIndex];
                var messageDto = Messages.FirstOrDefault(m => m.MessageId == ((IMessage)row.DataBoundItem).MessageId);

                if (messageDto != null)
                {
                    if (dgv_MessageDisplay.Columns[e.ColumnIndex].Name == "IsRead")
                    {
                        bool isRead = Convert.ToBoolean(row.Cells["IsRead"].Value);
                        messageDto.IsRead = isRead;
                    }
                }
            }

        }

        private void SaveChangesOnUnopenedMessage()
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
            SaveChangesOnUnopenedMessage();
            {
               foreach (var messageDto in Messages)
               {
                   MessageService.EditIsReadMessages(messageDto);  // <--- This is where the error is (The method returns a nullreference)
               }
            }
        }

        //Opens the message in a new form
        private void bt_openMessage_Click(object sender, EventArgs e)
        {
            IsReadShowForm();
        }

        //Logic behund the bt_openMessage_Click
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
