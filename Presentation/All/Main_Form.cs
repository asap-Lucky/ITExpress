using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.All;
using UI.Consultant;

namespace UI
{
    //Author: All from the group

    public partial class Main_Form : Form
    {

        //Constructor
        public Main_Form()
        {
            InitializeComponent();
            ToolTip customerTip = new ToolTip();
            customerTip.SetToolTip(bt_LogInAsCostumer, "Pick this if you want to login as a customer");
            ToolTip consultantTip = new ToolTip();
            consultantTip.SetToolTip(bt_LogInAsConsultant, "Pick this if you want to login as a consultant");
        }


        //Buttons for the form

        //Button which takes the user to the customer login form
        private void bt_LogInAsCostumer_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInCustomer_Form logInCustumer_Form = new LogInCustomer_Form();
            logInCustumer_Form.ShowDialog();
            this.Show();
        }

        //Button which takes the user to the consultant login form
        private void bt_LogInAsConsultant_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInConsultant_Form logInConsultant = new LogInConsultant_Form();
            logInConsultant.ShowDialog();
            this.Show();
        }

        //Button which takes the user to the admin login form
        private void bt_LogInAsAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInAdmin_Form logInConsultant = new LogInAdmin_Form();
            logInConsultant.ShowDialog();
            this.Show();
        }
    }
}
