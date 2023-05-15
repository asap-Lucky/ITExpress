using Abstraction.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Customer
{
    public partial class EditProfileConsultant : Form
    {
        private Abstraction.Interfaces.IConsultant loggedInConsultant;

        IConsultantService consultantService = new BLL.Services.ConsultantService();

        BLL.Facader.CustomerService FacadeService;


        public EditProfileConsultant(Abstraction.Interfaces.IConsultant loggedInConsultant)
        {
            InitializeComponent();
            this.loggedInConsultant = loggedInConsultant;
            //FacadeService = new BLL.Facader.ConsultantService(consultantService);
        }
    }
}
