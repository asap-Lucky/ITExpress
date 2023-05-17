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

        // Retrieve all customers from the database
        public List<ICustomer> GetAllCustomers()
        {
            var result = new List<ICustomer>();

            // Retrieve all customer data transfer objects (DTOs) from the database
            var AllDToCustomer = DataContext.Customers;

            // Convert each customer DTO to a customer model object and add to the result list
            foreach (var dto in AllDToCustomer)
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
                customer.City = dto.Customer_City;

                result.Add(customer);
            }
            return result;
        }

        // Add a new customer to the database
        public void AddCustomer(ICustomer dto)
        {
            // Convert the customer model object to a customer DTO
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

            // Insert the new customer DTO into the database and save changes
            DataContext.Customers.InsertOnSubmit(cus);
            DataContext.SubmitChanges();
        }

        // Delete a customer from the database
        public void DeleteCustomer(ICustomer dto)
        {
            // Find the customer DTO in the database by ID and delete it
            var targetCustomer = DataContext.Customers.FirstOrDefault(i => i.CustomerId == dto.Id);
            DataContext.Customers.DeleteOnSubmit(targetCustomer);

            // Save the changes to the database
            DataContext.SubmitChanges();
        }

        // Update a customer in the database
        public void EditCustomer(ICustomer customer)
        {
            // Find the customer DTO in the database by ID
            var targetCustomer = DataContext.Customers.FirstOrDefault(c => c.CustomerId == customer.Id);

            // Update the customer DTO with the new values from the customer model object
                targetCustomer.Customer_Address = customer.Address;
                targetCustomer.Customer_PhoneNumber = customer.PhoneNumber;
                targetCustomer.Customer_FirstName = customer.FirstName;
                targetCustomer.Customer_LastName = customer.LastName;
                targetCustomer.Customer_Address = customer.Address;
                targetCustomer.Customer_City = customer.City;
                targetCustomer.Customer_ZipCode = customer.ZipCode;
                targetCustomer.Customer_Password = customer.Password;
                targetCustomer.Customer_Login = customer.Login;

            // Save the changes to the database
            DataContext.SubmitChanges();
            
        }

        //Checks the the customer table for the login and password information
        public bool IsValidCustomer(string login, string password)
        {
            var customer = DataContext.Customers.FirstOrDefault(c => c.Customer_Login == login && c.Customer_Password == password);
            return customer != null;
        }

        public ICustomer GetCustomer(int id)
        {
            var dataCustomer = DataContext.Customers.FirstOrDefault(c => c.CustomerId == id);
            Models.Customer customer = new Models.Customer()
            {
                Id = dataCustomer.CustomerId,
                FirstName = dataCustomer.Customer_FirstName,
                LastName = dataCustomer.Customer_LastName,
                Login = dataCustomer.Customer_Login,
                Password = dataCustomer.Customer_Password,
                Email = dataCustomer.Customer_Email,
                ZipCode = dataCustomer.Customer_ZipCode,
                City = dataCustomer.Customer_City,
                Address = dataCustomer.Customer_Address,
                PhoneNumber = dataCustomer.Customer_PhoneNumber
            };
            return customer;
        }

        public ICustomer GetCustomer(string login, string password)
        {
            var dataCustomer = DataContext.Customers.FirstOrDefault(c => c.Customer_Login == login && c.Customer_Password == password);
            Models.Customer customer = new Models.Customer()
            {
                Id = dataCustomer.CustomerId,
                FirstName = dataCustomer.Customer_FirstName,
                LastName = dataCustomer.Customer_LastName,
                Login = dataCustomer.Customer_Login,
                Password = dataCustomer.Customer_Password,
                Email = dataCustomer.Customer_Email,
                ZipCode = dataCustomer.Customer_ZipCode,
                City = dataCustomer.Customer_City,
                Address = dataCustomer.Customer_Address,
                PhoneNumber = dataCustomer.Customer_PhoneNumber
            };
            return customer;
        }
    }
}
