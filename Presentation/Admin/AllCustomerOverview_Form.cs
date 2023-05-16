using DAL.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;

namespace Presentation.Customer
{
    public partial class AllCustomerOverview_Form : Form
    {
        private ITExpressDataClassesDataContext DataContext { get; set; }

        public AllCustomerOverview_Form()
        {
            InitializeComponent();
        }

        private void GetAllCustomers()
        {
            var query = from customer in DataContext.Customers
                        select new
                        {
                            customer.Customer_FirstName,
                            customer.Customer_LastName,
                            customer.Customer_Address,
                            customer.Customer_City,
                            customer.CustomerId,
                            customer.Customer_Email,
                            customer.Customer_ZipCode,
                            customer.Customer_PhoneNumber
                        };

            dgv_AllCustomersOverview.DataSource = query.ToList();
        }

      
    }
}
