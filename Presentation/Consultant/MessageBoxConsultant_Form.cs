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
using BLL.Singleton;

namespace Presentation.Customer
{
    public partial class MessageBoxConsultant : Form
    {
        private List<IMessage> UnreadMessages { get; set; }
        private List<IMessage> ReadMessages { get; set; }

        private BLL.Services.MessageService MessageService;

        private BLL.Singleton.ConsultantSingleton CurrentConsultant;


        public MessageBoxConsultant()
        {
            InitializeComponent();
            MessageService = new BLL.Services.MessageService();
            List<IMessage> messages = MessageService.GetMessagesByConsultant(ConsultantSingleton.Instance().User);
            var UnreadMessages = messages.Where(m => m.IsRead == false).ToList();
            var ReadMessages = messages.Where(m => m.IsRead == true).ToList();
            DisplayReadMessagesInDGV();
            DisplayUnreadMessagesInDGV();
        }

        private void BreedDGV()
        {
            dgv_currentConversations.AutoGenerateColumns = false;
            dgv_currentConversations.RowHeadersVisible = false;
            dgv_currentConversations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DataGridViewTextBoxColumn subjectHeader = new DataGridViewTextBoxColumn();
            subjectHeader.DataPropertyName = "Message_Header";
            subjectHeader.HeaderText = "Header";
            dgv_currentConversations.Columns.Add(subjectHeader);

            DataGridViewTextBoxColumn subjectConsultant = new DataGridViewTextBoxColumn();
            subjectConsultant.DataPropertyName = "GetSubject";
            subjectConsultant.HeaderText = "Consultant";
            dgv_currentConversations.Columns.Add(subjectConsultant);

            DataGridViewTextBoxColumn subjectIsRead = new DataGridViewTextBoxColumn();
            subjectIsRead.DataPropertyName = "Message_IsRead";
            subjectIsRead.HeaderText = "IsRead";
            dgv_currentConversations.Columns.Add(subjectIsRead);
        }

        // Create a method called DisplayReadMessagesInDGV that displays the read messages in the dgv_readMessages using the CurrentConsultant property
        private void DisplayReadMessagesInDGV()
        {
            BreedDGV();
            dgv_currentConversations.DataSource = ReadMessages;
        }
        

        private void DisplayUnreadMessagesInDGV()
        {
            BreedDGV();
            dgv_newMessages.DataSource = UnreadMessages;
        }
        

    }
}
