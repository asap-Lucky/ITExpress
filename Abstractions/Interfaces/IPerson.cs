using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions.Interfaces
{
    //Allows a class to be a person
    public interface IPerson
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }       
        string PhoneNumber { get; set; }
        string Address { get; set; }
    }
}
