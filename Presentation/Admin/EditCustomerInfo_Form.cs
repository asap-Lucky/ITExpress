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

namespace Presentation.Customer
{
    public partial class EditCustomerInfo : Form
    {
        private ICustomer SelectedCustomer { get; set; }

        public EditCustomerInfo(ICustomer selectedCustomer)
        {
            InitializeComponent();
            SelectedCustomer = selectedCustomer;
            InitialiseControl();
        }


        public void InitialiseControl()
        {
            tb_firstName.Text = SelectedCustomer.FirstName;
            tb_lastName.Text = SelectedCustomer.LastName;
            tb_address.Text = SelectedCustomer.Address;
            tb_city.Text = SelectedCustomer.City;
            tb_phoneNumber.Text = SelectedCustomer.PhoneNumber.ToString();
            tb_zipCode.Text = SelectedCustomer.ZipCode.ToString();
            tb_userName.Text = SelectedCustomer.Login;
            tb_passWord.Text = SelectedCustomer.Password;

        }

        private void bt_EditCustomerInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
