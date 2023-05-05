
namespace BL.Models
{
    //Represents a customer. 
    public class Customer : Abstractions.Interfaces.IPerson, Abstractions.Interfaces.IUser
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

        //Constructors
        public Customer(int id, string firstName, string lastName, string login, string password, string email, int zipCode, string address, int phoneNumber)
        {
            Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Login = login;
            this.Email = email;
            this.ZipCode = zipCode;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
        }

        public Customer(string firstName, string lastName, string login, string password, string email, int zipCode, string address, int phoneNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Login = login;
            this.Email = email;
            this.ZipCode = zipCode;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
        }
    }
}