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
    public partial class ConsultantInfo : Form
    {
        private Abstraction.Interfaces.IConsultant selectedConsultant { get; set; }

        private BLL.Services.ConsultantService consultantService { get; set; }

        public ConsultantInfo(IConsultant selectedConsultant)
        {
            InitializeComponent();
            this.selectedConsultant = selectedConsultant;
            GetConsultantData();
        }



        private void GetConsultantData()
        {
            tb_firstName.Text = selectedConsultant.FirstName;
            tb_lastName.Text = selectedConsultant.LastName;
            tb_address.Text = selectedConsultant.Address;
            tb_city.Text = selectedConsultant.City;
            tb_phoneNumber.Text = selectedConsultant.PhoneNumber.ToString();
            tb_email.Text = selectedConsultant.Email;
            tb_zipCode.Text = selectedConsultant.ZipCode.ToString();
            tb_login.Text = selectedConsultant.Login;
            tb_passWord.Text = selectedConsultant.Password;
            tb_language.Text = selectedConsultant.Language.Language;
            tb_endType.Text = selectedConsultant.EndType.EndType1;
            // Code that retrives the closed projects for the customer 
            // Code that retrives the current projects for the customer
        }

        private void bt_DeleteConsultant_Click(object sender, EventArgs e)
        {
                DialogResult result = MessageBox.Show("Do you wish to delete the selected customer?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    consultantService = new BLL.Services.ConsultantService();
                    consultantService.DeleteConsultant(selectedConsultant);
                    this.Hide();
                }
                else if (result == DialogResult.No)
                {

                }
        }

        private void bt_GoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bt_EditConsultantInfo_Click(object sender, EventArgs e)
        {
            //Hides this childform and opens another one on top of this
            EditConsultantInfo editConsultantInfo = new EditConsultantInfo(selectedConsultant);//<-- Remember to take the selectedCustomer variable and put it in the constructor on the EditCustomerInfo_Form.
            editConsultantInfo.Show();
            this.Hide();
        }
    }
}
