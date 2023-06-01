using Abstraction.Interfaces;
using BLL.Singleton;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.All
{
    /// <summary>
    /// Viljo
    /// </summary>
    public partial class RecieveMessage_Form : Form
    {
        Abstraction.Interfaces.IMessage selectedMessage;

        BLL.Services.MessageService MessageService;
        private ICustomer loggedInCustomer;
        private IConsultant loggedInConsultant;
        public RecieveMessage_Form(IMessage selectedMessage)
        {
            InitializeComponent();
            this.selectedMessage = selectedMessage;
            tb_Header.Text = selectedMessage.Header;
            tb_Body.Text = selectedMessage.Body;
            loggedInCustomer = CustomerSingleton.Instance().User;
            loggedInConsultant = ConsultantSingleton.Instance().User;
            DisplayMessageInfo();
        }

        private void DisplayMessageInfo()
        {
            if (selectedMessage.Customer != null && selectedMessage.Consultant != null)
            {
                // Determine the sender and receiver based on the logged-in user
                string senderEmail;
                string receiverEmail;

                if (loggedInCustomer != null && selectedMessage.Customer.Id == loggedInCustomer.Id)
                {
                    // Logged-in user is the customer, assign customer as sender and consultant as receiver
                    senderEmail = loggedInCustomer.Email;
                    receiverEmail = selectedMessage.Consultant.Email;
                }
                else if (loggedInConsultant != null && selectedMessage.Consultant.Id == loggedInConsultant.Id)
                {
                    // Logged-in user is the consultant, assign consultant as sender and customer as receiver
                    senderEmail = loggedInConsultant.Email;
                    receiverEmail = selectedMessage.Customer.Email;
                }
                else
                {
                    // No logged-in user found, display empty sender and receiver
                    senderEmail = "";
                    receiverEmail = "";
                }

                tb_Reciver.Text = receiverEmail;
                tb_Sender.Text = senderEmail;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}