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
using BLL.Services;
using BLL.Models;
using BLL.Singleton;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Presentation.Customer
{
    public partial class CustomerMessage : Form
    {
        Abstraction.Interfaces.IMessage MyMessage { get; set; }
        BLL.Services.MessageService MessageService { get; set; }
        List<IConsultant> AllConsultants { get; set; }
        BLL.Services.ConsultantService ConsultantService { get; set; }
        List<string> Emails { get; set; }

        ICustomer CurrentUser { get; set; }

        public CustomerMessage(ICustomer customer)
        {
            InitializeComponent();
            MessageService = new BLL.Services.MessageService();
            ConsultantService = new ConsultantService();
            MyMessage = new BLL.Models.Message();
            CurrentUser = BLL.Singleton.CustomerSingleton.Instance().User;
            AllConsultants = ConsultantService.GetAllConsultants();
            Emails = new List<string>();
            foreach(var consultant in AllConsultants)
            {
                Emails.Add(consultant.Email);
            }
        }

        private void bt_Send_Click(object sender, EventArgs e)
        {
            StoreMessage();
            MessageBox.Show("Your message has been send");
            this.Close();
        }

        //Select consultant that the message has to be sent to
        public IConsultant SelectConsultant(string email)
        {
            IConsultant consultant = new BLL.Models.Consultant();
            List<IConsultant> allConsultants = ConsultantService.GetAllConsultants();

            string reCieveremail = tb_SendToReciever.Text;
            

            if (allConsultants != null)
            {
                //Remember to specify that it has to look through the tb_EmailTextBox as a reciever
                
                
                consultant = allConsultants.FirstOrDefault(c => c.Email == email);
              
            }
            return consultant = SelectConsultant(email);
        }

        //Stores the message that has to be saved using the "SelectConsultant" method as an identification of the foreign key to the consultant that the message has to be sent to
        public void StoreMessage()
        {
            if (Emails.Contains(tb_SendToReciever.Text))
            {
                BLL.Models.Message message = new BLL.Models.Message();
                message.Header = tb_TitleOfMessage.Text;
                message.Body = tb_BodyMessage.Text;
                message.Customer = CurrentUser;
                message.Consultant = AllConsultants.First(c => c.Email == tb_SendToReciever.Text);
                //Add "IsRead/NotRead" bool that is either true or false since it is something that has to be taken further
                MessageService.AddMessage(message);
            }

        }
    }
}
