using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interfaces
{
    public interface ICustomer
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Login { get; set; }
        string Password { get; set; }
        string Email { get; set; }
        string Address { get; set; }
        int ZipCode { get; set; }
        string City { get; set; }
        int PhoneNumber { get; set; }
        string GetFullName { get; }
    }
}
