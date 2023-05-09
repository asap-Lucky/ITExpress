
namespace BLL.Models
{
    //Represents a customer. 
    public class Customer : Abstraction.Interfaces.ICustomer
    {        
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
        public int PhoneNumber { get; set; }
    }
}