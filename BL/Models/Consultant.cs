using Abstractions.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Models
{
    //Represents a consultant.
    public class Consultant : Abstractions.Interfaces.IPerson, Abstractions.Interfaces.IUser
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public Consultant(string firstName, string lastName, string login, string password, string email, string address, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Login = login;
            Password = password;
            Email = email;
            Address = address;
            PhoneNumber = phoneNumber;
        }
    }
}
