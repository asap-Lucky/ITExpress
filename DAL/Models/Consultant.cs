using Abstraction.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Consultant : IConsultant
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int ZipCode { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public ICodeLanguage Language { get; set; }
        public IEndType EndType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
