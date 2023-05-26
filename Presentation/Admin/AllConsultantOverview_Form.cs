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
    /// <summary>
    /// Marcel
    /// </summary>

    public partial class AllConsultantOverview_Form : Form
    {
        //Fields
        private BLL.Facader.ConsultantService consultantService { get; set; }

        //Constructor
        public AllConsultantOverview_Form()
        {
            InitializeComponent();
            this.consultantService = new BLL.Facader.ConsultantService(new BLL.Services.ConsultantService());
            UpdateConsultantOnUI();
            LoadConsultantData();
        }

        //Method which is called to load the consultant data from the database
        private void LoadConsultantData()
        {
            List<IConsultant> consultants = this.consultantService.consultantService.GetAllConsultants();
            dgv_AllConsultantsOverview.DataSource = consultants;
        }

        //method which is called to update the consultant on the UI
        private void UpdateConsultantOnUI()
        {
            dgv_AllConsultantsOverview.DataSource = consultantService.consultantService.GetAllConsultants();
            dgv_AllConsultantsOverview.Refresh();
        }


        //Buttons for the form

        /// <summary>
        /// Button which takes the users selected consultant as a row and opens a new form with the consultant information.
        /// It takes the selected consultant and sends it to the new form as a parameter called "selectedConsultant"
        /// </summary>
        /// <param name="selectedConsultant"></param> - Selected consultant from the datagridview
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

        //Button logic for creating a new consultant. Redirects the user to the signup consultant form from the 
        // consultant folder in the UI project for when a new consultant is to sign up.
        private void bt_AddConsultant_Click(object sender, EventArgs e)
        {
            SignUpConsultant_Form sign = new SignUpConsultant_Form();
            sign.Show();
            this.Hide();
        }
    }
}
