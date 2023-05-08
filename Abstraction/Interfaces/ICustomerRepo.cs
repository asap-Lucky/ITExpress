using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interfaces
{
    public interface ICustomerRepo
    {
        List<ICustomer> GetAllCustomers();

        void AddCustomer(ICustomer dto);

        void DeleteCustomer(ICustomer dto);

        void EditCustomer(ICustomer customer);

        bool IsValidCustomer(string login, string password);
    }
}
