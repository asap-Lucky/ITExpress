using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Costumer;

namespace UI.All
{
    public partial class LogInCustomer_Form : Form
    {
        public LogInCustomer_Form()
        {
            InitializeComponent();
        }

        private void bt_GoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ll_SignUpAsCostumer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignUpCustomer_Form signInCostumer_Form = new SignUpCustomer_Form();
            signInCostumer_Form.ShowDialog();
            this.Show();
        }
    }
}
