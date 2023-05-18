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
using UI.Consultant;
using UI.Costumer;

namespace Presentation.Customer
{
    public partial class AllConsultantOverview_Form : Form
    {
        //Fields
        private BLL.Facader.ConsultantService consultantService { get; set; }

        public AllConsultantOverview_Form()
        {
            InitializeComponent();
            this.consultantService = new BLL.Facader.ConsultantService(new BLL.Services.ConsultantService());
            UpdateCustomerOnUI();
            LoadCustomerData();

        }

        private void LoadCustomerData()
        {
            List<IConsultant> consultants = this.consultantService.consultantService.GetAllConsultants();
            dgv_AllConsultantsOverview.DataSource = consultants;
        }

        private void UpdateCustomerOnUI()
        {
            dgv_AllConsultantsOverview.DataSource = consultantService.consultantService.GetAllConsultants();
            dgv_AllConsultantsOverview.Refresh();
        }

        private void bt_ViewConsultant_Click(object sender, EventArgs e)
        {
            if (dgv_AllConsultantsOverview.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_AllConsultantsOverview.SelectedRows[0];
                var consultant = selectedRow.DataBoundItem;
                IConsultant selectedConsultant = (IConsultant)consultant;


                //Hides this childform and opens another one on top of this. 
                ConsultantInfo consultantInfo = new ConsultantInfo(selectedConsultant);
                consultantInfo.Show();
                this.Hide();
            }
        }

        private void bt_AddConsultant_Click(object sender, EventArgs e)
        {
            SignUpConsultant_Form sign = new SignUpConsultant_Form();
            sign.Show();
            this.Hide();
        }
    }
}
