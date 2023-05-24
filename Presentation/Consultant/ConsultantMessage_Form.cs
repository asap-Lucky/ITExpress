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
using BLL.Facader;
using BLL.Models;
using BLL.Services;

namespace Presentation.All
{
    public partial class ConsultantMessage_Form : Form
    {
        private Abstraction.Interfaces.ICustomer loggedInCustomer;
        private BLL.Services.ProjectService projectService;
        public Abstraction.Interfaces.IMessage MyMessage { get; set; }
        public ConsultantMessage_Form()
        {
            InitializeComponent();
            this.loggedInCustomer = BLL.Singleton.CustomerSingleton.Instance().User;

            IMessage MyMessage = new BLL.Models.Message();
            this.projectService = new BLL.Services.ProjectService();
            List<IProject> CustomerProjects = this.projectService.GetProjectsByCostumer(this.loggedInCustomer);
            List<IConsultant> consultants = new List<IConsultant>();
            foreach (IProject project in CustomerProjects)
            {
                consultants.Add(project.Consultant);

            }
        }

        public void SendMessage()
        {
           
            MyMessage.Header = textBox2.Text;
            MyMessage.Body = textBox1.Text;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
