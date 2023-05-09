using Abstraction.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    //Represents a consultant.
    public class Consultant : Abstraction.Interfaces.IConsultant
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int ZipCode { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public string City { get; set; }
    }
}
