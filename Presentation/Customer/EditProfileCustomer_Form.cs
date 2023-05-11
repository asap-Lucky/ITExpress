using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Costumer
{
    public partial class EditProfileCustomer : Form
    {
        private Abstraction.Interfaces.ICustomer loggedInCustomer;

        private BLL.Services.CustomerService customerService = new BLL.Services.CustomerService();

        public EditProfileCustomer(Abstraction.Interfaces.ICustomer loggedInCustomer)
        {
            InitializeComponent();
            this.loggedInCustomer = loggedInCustomer;
        }

        private void bt_DiscardProfileChanges_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to discard changes? All changes WILL BE LOST!", "DISCARD CHANGES?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            { 
              LoadCustomerData();
            }
        }

        private void EditProfileCustomer_Load(object sender, EventArgs e)
        {
            LoadCustomerData();
        }

        private void LoadCustomerData() 
        {
            tb_currentFirstName.Text = loggedInCustomer.FirstName;
            tb_currrentLastName.Text = loggedInCustomer.LastName;
            tb_currentAddress.Text = loggedInCustomer.Address;
            tb_currentCity.Text = loggedInCustomer.City;
            tb_currentZipCode.Text = loggedInCustomer.ZipCode.ToString();
            tb_currentPhoneNumber.Text = loggedInCustomer.PhoneNumber.ToString();
            tb_currentEmail.Text = loggedInCustomer.Email;
        }

        private void bt_saveChangesOnProfile_Click(object sender, EventArgs e)
        {

        }
    }
}
