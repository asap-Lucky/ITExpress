namespace BL.Models
{
    //Represents a customer. 
    public class Customer : Abstractions.Interfaces.IPerson, Abstractions.Interfaces.IUser
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Login { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }

        public Customer(string firstName, string lastName, string login, string password, string email, string address, string phoneNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Login = login;
            this.Email = email;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
        }
    }
}