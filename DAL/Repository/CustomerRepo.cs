using DAL.LinqToSQL;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class CustomerRepo
    {
        public ITExpressDataClassesDataContext DataContext { get; set; }

        public CustomerRepo(ITExpressDataClassesDataContext dataContext)
        {
            DataContext = dataContext;
        }

        public Table<Customer> GetAllCustomer()
        {
            return DataContext.Customers;
        }

        public void CreateCustomer(Customer customer)
        {
            DataContext.Customers.InsertOnSubmit(customer);
            DataContext.SubmitChanges();
        }

        public void DeleteCustomer(Customer customer)
        {
            DataContext.Customers.DeleteOnSubmit(customer);
            DataContext.SubmitChanges();
        }

        public void UpdateCustomer(Customer customer) 
        {
            Customer dataCustomer = (from c in DataContext.Customers
                                     where c.CustomerId == customer.CustomerId
                                     select c).FirstOrDefault();
            if (dataCustomer != null)
            {
                dataCustomer.Customer_Address = customer.Customer_Address;
                dataCustomer.Customer_PhoneNumber = customer.Customer_PhoneNumber;
                dataCustomer.Customer_FirstName = customer.Customer_FirstName;
                dataCustomer.Customer_LastName = customer.Customer_LastName;
                dataCustomer.Customer_Address = customer.Customer_Address.ToString();
                dataCustomer.Customer_ZipCodee = customer.Customer_ZipCodee;
                dataCustomer.Customer_Password = customer.Customer_Password;
                dataCustomer.Customer_Login = customer.Customer_Login;
            }
            DataContext.SubmitChanges();
        }
    }
}
