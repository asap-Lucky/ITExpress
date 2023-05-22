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
using BLL.Facader;
using BLL.Models;
using BLL.Services;

namespace Presentation.All
{
    private Abstraction.Interfaces.ICustomer loggedInCustomer;

    public partial class SendMessage_Form : Form
    {
        public SendMessage_Form(ICustomer loggedincustomer)
        {
            InitializeComponent();
            this.loggedInCustomer = loggedincustomer;
            MyMessage = new Message();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
