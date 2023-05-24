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

            DataGridViewTextBoxColumn subjectCustomer = new DataGridViewTextBoxColumn();
            subjectCustomer.DataPropertyName = "GetSubject";
            subjectCustomer.HeaderText = "Consultant";
            dgv_currentConversations.Columns.Add(subjectCustomer);

            DataGridViewTextBoxColumn subjectIsRead = new DataGridViewTextBoxColumn();
            subjectIsRead.DataPropertyName = "Message_IsRead";
            subjectIsRead.HeaderText = "IsRead";
            dgv_currentConversations.Columns.Add(subjectIsRead);
        }
        
        
        //This does work partially. It does not display the messages in the dgv because the on line 64 it takes an input of an object and not an int value. Do stuff about it.
        private void DisplayUnreadMessagesInDGV()
        {
            BreedDGV();
            BLL.Models.Consultant consultant = ConsultantSingleton.Instance().User as BLL.Models.Consultant;
            List<IMessage> newMessages = MessageService.GetMessagesByConsultant(consultant);

           
            UnreadMessages = new List<IMessage>();
            foreach (IMessage message in newMessages)
            {
                IMessage displayMessage = new BLL.Models.Message
                {
                    Header = message.Header,
                    Body = message.Body,
                    IsRead = message.IsRead,
                    Customer = message.Customer
                };
                UnreadMessages.Add(displayMessage);
            }

            dgv_newMessages.DataSource = UnreadMessages;
        }
        

    }
}
