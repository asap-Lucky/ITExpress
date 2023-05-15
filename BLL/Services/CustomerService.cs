using Abstraction.Interfaces;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    /// <summary>
    /// This class provides the implementation of ICustomerService interface
    /// </summary>
    public class CustomerService : ICustomerService
    {
        ICustomerRepo _customerRepo;

        public CustomerService()
        {
            // Inversion of Control is used to solve the dependency of the repository
            _customerRepo = new DAL.Repository.CustomerRepo();
        }

        /// <summary>
        /// Adds a new customer
        /// </summary>
        /// <param name="customer">The customer object to add</param>
        public void AddCustomer(ICustomer customer)
        {
            _customerRepo.AddCustomer(customer);
        }

        /// <summary>
        /// Deletes a customer
        /// </summary>
        /// <param name="customer">The customer object to delete</param>
        public void DeleteCustomer(ICustomer customer)
        {
            _customerRepo.DeleteCustomer(customer);
        }

        public void EditCustomer(ICustomer customer)
        {
            _customerRepo.EditCustomer(customer);
        }

        /// <summary>
        /// Retrieves a list of all customers
        /// </summary>
        /// <returns>A list of ICustomer objects</returns>
        public List<ICustomer> GetAllCustomers()
        {
            return _customerRepo.GetAllCustomers();
        }

        public ICustomer GetCustomer(int id)
        {
            return _customerRepo.GetCustomer(id);
        }

        public ICustomer GetCustomer(string login, string password)
        {
            return _customerRepo.GetCustomer(login, password);
        }

        /// <summary>
        /// Validates if a customer with the provided login and password exists
        /// </summary>
        /// <param name="login">The customer login</param>
        /// <param name="password">The customer password</param>
        /// <returns>True if a matching customer exists, false otherwise</returns>
        public bool IsValidCustomer(string login, string password)
        {
            return _customerRepo.IsValidCustomer(login, password);
        }
    }
}
