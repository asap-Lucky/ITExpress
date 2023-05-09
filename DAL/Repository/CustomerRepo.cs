using Abstraction.Interfaces;
using DAL.Database;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class CustomerRepo : ICustomerRepo
    {
        private ITExpressDataClassesDataContext DataContext { get; set; }

        public CustomerRepo()
        {
            DataContext = new ITExpressDataClassesDataContext();
        }

        public List<ICustomer> GetAllCustomers()
        {
            var result = new List<ICustomer>();

            var AllDtoItem = DataContext.Customers;

            foreach (var dto in AllDtoItem)
            {
                Models.Customer customer = new Models.Customer();

                customer.Id = dto.CustomerId;
                customer.Email = dto.Customer_Email;
                customer.FirstName = dto.Customer_FirstName;
                customer.LastName = dto.Customer_LastName;
                customer.Address = dto.Customer_Address;
                customer.ZipCode = dto.Customer_ZipCode;
                customer.PhoneNumber = dto.Customer_PhoneNumber;
                customer.Login = dto.Customer_Login;
                customer.Password = dto.Customer_Password;


                result.Add(customer);
            }
            return result;
        }

        public void AddCustomer(ICustomer dto)
        {
            var cus = new Customer()
            {
                CustomerId = dto.Id,
                Customer_FirstName = dto.FirstName,
                Customer_LastName = dto.LastName,
                Customer_Login = dto.Login,
                Customer_Password = dto.Password,
                Customer_Email = dto.Email,
                Customer_Address = dto.Address,
                Customer_ZipCode = dto.ZipCode,
                Customer_City = dto.City,
                Customer_PhoneNumber = dto.PhoneNumber,
            };
            DataContext.Customers.InsertOnSubmit(cus);
            DataContext.SubmitChanges();
        }

        public void DeleteCustomer(ICustomer dto)
        {
            var targetCustomer = DataContext.Customers.FirstOrDefault(i => i.CustomerId == dto.Id);

            DataContext.Customers.DeleteOnSubmit(targetCustomer);

            DataContext.SubmitChanges();
        }

        public void EditCustomer(ICustomer customer) 
        {
            var targetCustomer = DataContext.Customers.FirstOrDefault(c =>  c.CustomerId == customer.Id);
            if (targetCustomer != null)
            {
                // Update the customer object with the new values.
                targetCustomer.Customer_Address = customer.Address;
                targetCustomer.Customer_PhoneNumber = customer.PhoneNumber;
                targetCustomer.Customer_FirstName = customer.FirstName;
                targetCustomer.Customer_LastName = customer.LastName;
                targetCustomer.Customer_Address = customer.Address;
                targetCustomer.Customer_ZipCode = customer.ZipCode;
                targetCustomer.Customer_City = customer.City;
                targetCustomer.Customer_Password = customer.Password;
                targetCustomer.Customer_Login = customer.Login;

                // Save the changes to the database.
                DataContext.SubmitChanges();
            }
        }

        //Checks the the customer table for the login and password information
        public bool IsValidCustomer(string login, string password)
        {
            var customer = DataContext.Customers.FirstOrDefault(c => c.Customer_Login == login && c.Customer_Password == password);
            return customer != null;
        }
    }
}
