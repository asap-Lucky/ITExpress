using Abstraction.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class CustomerService : ICustomerService
    {
        ICustomerRepo _customerRepo;

        public CustomerService() 
        {
            //Inversion of Control is the correct way to solve the independancy of the repository
            _customerRepo = new DAL.Repository.CustomerRepo();   
        }

        public void AddCustomer(ICustomer customer)
        {
            _customerRepo.AddCustomer(customer);
        }

        public void DeleteCustomer(ICustomer customer)
        {
            _customerRepo.DeleteCustomer(customer);
        }

        public List<ICustomer> GetAllCustomers()
        {
            return _customerRepo.GetAllCustomers();
        }

        public bool IsValidCustomer(string login, string password)
        {
            return _customerRepo.IsValidCustomer(login, password);
        }

        public void UpdateCustomer(ICustomer customer)
        {
            _customerRepo.EditCustomer(customer);
        }
    }
}
