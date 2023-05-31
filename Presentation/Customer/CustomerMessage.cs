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
using System.Reflection.Emit;

namespace Presentation.Customer
{
    public partial class CustomerMessage : Form
    {
        BLL.Services.MessageService MessageService { get; set; }
        List<IConsultant> Consultants { get; set; }
        BLL.Facader.ConsultantService ConsultantService { get; set; }
        List<string> Emails { get; set; }
        IMessage ConsultantMessage { get; set; }

        /// <summary>
        /// Use this constructor when writing a new message
        /// </summary>
        public CustomerMessage()
        {
            InitializeComponent();
            MessageService = new MessageService();
            ConsultantService = new BLL.Facader.ConsultantService(new BLL.Services.ConsultantService());
            buttonRespond.Visible = false;
            labelFrom.Visible = false;
            tb_From.Visible = false;
            Consultants = ConsultantService.GetAllConsultants();
            Consultants = Consultants.OrderBy(c => c.Email).ToList();
            comboBoxTo.DisplayMember = "Email";
            comboBoxTo.ValueMember = "Consultant";
            comboBoxTo.DataSource = Consultants;
        }

        /// <summary>
        /// Use this constructor when opening a message
        /// </summary>
        /// <param name="message"></param>
        public CustomerMessage(IMessage message)
        {
            InitializeComponent();
            MessageService = new MessageService();
            ConsultantService = new BLL.Facader.ConsultantService(new BLL.Services.ConsultantService());
            ConsultantMessage = message;
            buttonSend.Enabled = false;
            labelTo.Visible = false;
            comboBoxTo.Visible = false;
            tb_Title.Text = message.Header;
            tb_Title.Enabled = false;
            tb_Title.Text = message.Body;
            tb_Title.Enabled = false;
            tb_From.Text = message.Customer.GetFullName;
            tb_From.Enabled = false;
            tb_BodyMessage.Text = message.Body;
            tb_BodyMessage.Enabled = false;
        }
        
        private void bt_GoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            IConsultant messageConsultant = ConsultantService.GetAllConsultants().FirstOrDefault(c => c.Email == comboBoxTo.Text);
            IMessage messageSend = new BLL.Models.Message()
            {
                Header = tb_Title.Text,
                Body = tb_BodyMessage.Text,
                Customer = BLL.Singleton.CustomerSingleton.Instance().User,
                Consultant = messageConsultant,
                IsRead = false
            };
            MessageService.AddMessage(messageSend);
            MessageBox.Show("The Message Was Sent", "Confirmation");
            this.Close();
        }

        private void buttonRespond_Click(object sender, EventArgs e)
        {
            buttonRespond.Enabled = false;
            buttonSend.Enabled = true;
            labelFrom.Visible = false;
            tb_From.Visible = false;
            comboBoxTo.Visible = true;
            comboBoxTo.Enabled = false;
            comboBoxTo.Text = ConsultantMessage.Consultant.Email;
            tb_Title.Text = "Re: " + tb_Title.Text;
            tb_BodyMessage.Enabled = true;
            tb_BodyMessage.Clear();
        }
    }
}
