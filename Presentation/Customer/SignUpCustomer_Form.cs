using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Costumer
{
    public partial class SignUpCustomer_Form : Form
    {
        public SignUpCustomer_Form()
        {
            InitializeComponent();
        }

        private void bt_GoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveCustomer()
        {
            
        }

        private void bt_SignUpAsCostumer_Click(object sender, EventArgs e)
        {
            SaveCustomer();
            this.Close();
        }
    }
}
