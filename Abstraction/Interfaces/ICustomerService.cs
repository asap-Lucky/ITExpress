using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interfaces
{
    public interface ICustomerService
    {
        List<ICustomer> GetAllCustomers();

        void AddCustomer(ICustomer customer);

        void EditCustomer(ICustomer customer);

        void UpdateCustomer(ICustomer customer);

        void DeleteCustomer(ICustomer customer);

        bool IsValidCustomer(string login, string password);

        ICustomer GetCustomer(string login, string password);

        ICustomer GetCustomer(int id);
    }
}
