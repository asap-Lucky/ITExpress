using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            UnreadMessages = messages.Where(m => m.IsRead == false).ToList();
            ReadMessages = messages.Where(m => m.IsRead == true).ToList();
            DisplayReadMessagesInDGV();
            DisplayUnreadMessagesInDGV();
        }

        // Create a method called DisplayReadMessagesInDGV that displays the read messages in the dgv_readMessages using the CurrentConsultant property
        private void DisplayReadMessagesInDGV()
        {
            dgv_currentConversations.AutoGenerateColumns = false;
            dgv_currentConversations.RowHeadersVisible = false;
            dgv_currentConversations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DataGridViewTextBoxColumn senderColumn = new DataGridViewTextBoxColumn();
            senderColumn.DataPropertyName = "GetSenderName";
            senderColumn.HeaderText = "Sender";
            dgv_currentConversations.Columns.Add(senderColumn);

            DataGridViewTextBoxColumn subjectColumn = new DataGridViewTextBoxColumn();
            subjectColumn.DataPropertyName = "GetSubject";
            subjectColumn.HeaderText = "Subject";
            dgv_currentConversations.Columns.Add(subjectColumn);

            DataGridViewTextBoxColumn dateColumn = new DataGridViewTextBoxColumn();
            dateColumn.DataPropertyName = "GetDate";
            dateColumn.HeaderText = "Date";
            dgv_currentConversations.Columns.Add(dateColumn);

            dgv_currentConversations.DataSource = ReadMessages;
        }
        

        private void DisplayUnreadMessagesInDGV()
        {
            
        }



        private void MessageBoxConsultant_Load(object sender, EventArgs e)
        {
            dgv_currentConversations.AutoGenerateColumns = false;
            dgv_currentConversations.RowHeadersVisible = false;
            dgv_currentConversations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DataGridViewTextBoxColumn senderColumn = new DataGridViewTextBoxColumn();
            senderColumn.DataPropertyName = "GetSenderName";
            senderColumn.HeaderText = "Sender";
            dgv_currentConversations.Columns.Add(senderColumn);

            DataGridViewTextBoxColumn subjectColumn = new DataGridViewTextBoxColumn();
            subjectColumn.DataPropertyName = "GetSubject";
            subjectColumn.HeaderText = "Subject";
            dgv_currentConversations.Columns.Add(subjectColumn);

            DataGridViewTextBoxColumn dateColumn = new DataGridViewTextBoxColumn();
            dateColumn.DataPropertyName = "GetDate";
            dateColumn.HeaderText = "Date";
            dgv_currentConversations.Columns.Add(dateColumn);

            dgv_currentConversations.DataSource = UnreadMessages;

            dgv_newMessages.AutoGenerateColumns = false;
            dgv_newMessages.RowHeadersVisible = false;
            dgv_newMessages.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DataGridViewTextBoxColumn senderColumn2 = new DataGridViewTextBoxColumn();
            senderColumn2.DataPropertyName = "GetSenderName";
            senderColumn2.HeaderText = "Sender";
            dgv_newMessages.Columns.Add(senderColumn2);

            DataGridViewTextBoxColumn subjectColumn2 = new DataGridViewTextBoxColumn();
            subjectColumn2.DataPropertyName = "GetSubject";
            subjectColumn2.HeaderText = "Subject";
            dgv_newMessages.Columns.Add(subjectColumn2);

            DataGridViewTextBoxColumn dateColumn2 = new DataGridViewTextBoxColumn();
            dateColumn2.DataPropertyName = "GetDate";
            dateColumn2.HeaderText = "Date";
            dgv_newMessages.Columns.Add(dateColumn2);

            dgv_newMessages.DataSource = ReadMessages;
        }
        
        

    }
}
