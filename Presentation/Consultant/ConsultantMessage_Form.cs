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

namespace Presentation.All
{
    public partial class ConsultantMessage_Form : Form
    {
        Abstraction.Interfaces.IMessage MyMessage { get; set; }
        BLL.Services.MessageService MessageService { get; set; }
        List<ICustomer> AllCustomers { get; set; }
        BLL.Services.CustomerService CustomerService { get; set; }
        List<string> Emails { get; set; }

        IConsultant CurrentUser { get; set; }

        public  ConsultantMessage_Form(IConsultant consultant)
        {
            InitializeComponent();
            MessageService = new BLL.Services.MessageService();
            CustomerService = new CustomerService();
            MyMessage = new BLL.Models.Message();
            CurrentUser = BLL.Singleton.ConsultantSingleton.Instance().User; 
            AllCustomers = CustomerService.GetAllCustomers();
            Emails = new List<string>();
            foreach (var customer in AllCustomers)
            {
                Emails.Add(customer.Email);
            }

            tb_FromSenderEmail.Text = CurrentUser.Email;
           
        }


        //Select consultant that the message has to be sent to

        public ICustomer SelectCustomer2(string email)
        {
            ICustomer customer = new BLL.Models.Customer();
            List<ICustomer> allCustomers = CustomerService.GetAllCustomers(); 

            string reCieveremail = tb_SendToReciever.Text;
            customer = allCustomers.FirstOrDefault(c => c.Email == reCieveremail);

            if (allCustomers != null)
            {
                //Remember to specify that it has to look through the tb_EmailTextBox as a reciever


                customer = allCustomers.FirstOrDefault(c => c.Email == email);

            }

            return customer;
        }

        public void StoreMessageInDatabase()
        {
            ICustomer customer = SelectCustomer2(tb_SendToReciever.Text);
            MyMessage.Header = tb_TitleOfMessage.Text;
            MyMessage.Body = tb_BodyMessage.Text;
            MyMessage.Consultant = CurrentUser;
            MyMessage.Customer = customer;
            MyMessage.IsRead = true;
            MessageService.AddMessage(MyMessage);
        }

        private void bt_Send_Click_1(object sender, EventArgs e)
        {
            StoreMessageInDatabase();
            MessageBox.Show("Your message has been send");
            this.Close();
        }

        private void bt_GoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}



