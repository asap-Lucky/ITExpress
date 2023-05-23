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
    public partial class MessageBoxCustomer : Form
    {
        

        public MessageBoxCustomer()
        {
            InitializeComponent();
        }

        private void bt_writeMessage_Click(object sender, EventArgs e)
        {
            CustomerMessage customerMessage = new CustomerMessage(BLL.Singleton.CustomerSingleton.Instance().User);
            customerMessage.ShowDialog();
        }
    }
}
