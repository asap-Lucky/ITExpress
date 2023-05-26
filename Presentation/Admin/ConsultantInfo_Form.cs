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
    /// <summary>
    /// Marcel
    /// </summary>

    public partial class ConsultantInfo : Form
    {
        //Fields
        private Abstraction.Interfaces.IConsultant selectedConsultant { get; set; }
        private BLL.Services.ConsultantService consultantService { get; set; }

        //Constructor which takes the parameter selectedConsultant from the AllConsultantOverview_Form
        public ConsultantInfo(IConsultant selectedConsultant)
        {
            InitializeComponent();
            this.selectedConsultant = selectedConsultant;
            GetConsultantData();
        }

        //Method which is called to get the consultant data from the database and display it on the UI
        private void GetConsultantData()
        {
            tb_id.Text = selectedConsultant.Id.ToString();
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
        }


        //Buttons for the form

        /// <summary>
        /// Delete button which takes the parameter selectedConsultant and deletes it from the database using a call
        /// to the BLL.Services.ConsultantService.DeleteConsultant method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="selectedConsultant"></param> - Viewed Consultant from the datagridview
        private void bt_DeleteConsultant_Click(object sender, EventArgs e)
        {
                DialogResult result = MessageBox.Show("Do you wish to delete this consultant?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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

        //Button which takes the user back to the previous form
        private void bt_GoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Edit button which takes the users selectedConsultant as a row and opens a new form with the editable information.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="selectedConsultant"></param> - Viewed Consultant from the datagridview
        private void bt_EditConsultantInfo_Click(object sender, EventArgs e)
        {
            //Hides this childform and opens another one on top of this
            EditConsultantInfo editConsultantInfo = new EditConsultantInfo(selectedConsultant);//<-- Remember to take the selectedCustomer variable and put it in the constructor on the EditCustomerInfo_Form.
            editConsultantInfo.Show();
            this.Hide();
        }
    }
}
