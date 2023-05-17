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
    public partial class CustomerInfo : Form
    {

        public ICustomer customerId { get; set; }

        public CustomerInfo(BLL.Models.Customer customerId)
        {
            InitializeComponent();
            this.customerId = customerId;
        }
    }
}
