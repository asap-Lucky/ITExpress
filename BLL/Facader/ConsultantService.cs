using Abstraction.Interfaces;
using BLL.Models;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Facader
{
    /// <summary>
    /// Djoan
    /// </summary>
    public class ConsultantService
    {
        public IConsultantService consultantService { get; set; }

        public ICodeLangaugeService codeLanguageService { get; set; }

        public IEndtypeService endtypeService { get; set; }

        public Abstraction.Interfaces.IConsultant MyConsultant { get; set; }


        public ConsultantService(IConsultantService consultantService)
        {
            this.consultantService = consultantService;
            this.codeLanguageService = new CodeLanguageService();
            this.endtypeService = new EndtypeService();
        }

        public List<IConsultant> GetAllConsultants()
        {
            return consultantService.GetAllConsultants();
        }

        // RegisterConsultant method
        // Registers a new consultant with the provided information.
        public void RegisterConsultant(string FirstName, string LastName, string Adress, int Zipcode, int Phonenumber, string Email, string Login, string Password, string City, ICodeLanguage CodeLanguage, IEndType Endtype)
        {
            MyConsultant = new Consultant
            {
                FirstName = FirstName,
                LastName = LastName,
                Address = Adress,
                ZipCode = Zipcode,
                PhoneNumber = Phonenumber,
                Email = Email,
                Login = Login,
                Password = Password,
                City = City,

                Language = codeLanguageService.GetCodeLanguage(CodeLanguage),
                EndType = endtypeService.GetEndtype(Endtype)
            };

            // Call the AddConsultant method of the ConsultantService object and pass in MyConsultant object.
            consultantService.AddConsultant(MyConsultant);
        }

        // EditConsultantLoginInfo method
        // Updates the login information (username and password) of a consultant with the given ID.
        public void EditConsultantLoginInfo(int Id, string Login, string Password)
        {
            // Initialize MyConsultant with a new instance of the Consultant class.
            MyConsultant = consultantService.GetConsultant(Id);
            MyConsultant.Login = Login;
            MyConsultant.Password = Password;

            // Call the EditConsultant method of the ConsultantService object and pass in MyConsultant object.
            consultantService.EditConsultant(MyConsultant);
        }

        // EditConsultant method
        // Updates the general information (first name, last name, address, zipcode, phone number, email, city) of a consultant with the given ID.
        public void EditConsultant(int Id, string FirstName, string LastName, string Adress, int Zipcode, int Phonenumber, string Email, string City)
        {
            // Initialize MyConsultant with a new instance of the Consultant class.
            MyConsultant = consultantService.GetConsultant(Id);

            MyConsultant.FirstName = FirstName;
            MyConsultant.LastName = LastName;
            MyConsultant.Address = Adress;
            MyConsultant.ZipCode = Zipcode;
            MyConsultant.PhoneNumber = Phonenumber;
            MyConsultant.Email = Email;
            MyConsultant.City = City;

            // Call the EditConsultant method of the ConsultantService object and pass in MyConsultant object.
            consultantService.EditConsultant(MyConsultant);
        }

        // EditConsultantSpecialization method
        // Updates the code language and end type specializations of a consultant with the given ID.
        public void EditConsultantSpecialization(int id, ICodeLanguage language, IEndType endType)
        {
            MyConsultant = consultantService.GetConsultant(id);

            MyConsultant.Language = language;
            MyConsultant.EndType = endType;

            consultantService.EditConsultant(MyConsultant);
        }

        // GetConsultant method
        // Retrieves a consultant with the given ID.
        public IConsultant GetConsultant(int Id)
        {
            return consultantService.GetConsultant(Id);
        }

        // DuplicateEmailChecker method
        // Checks if a consultant with the provided email address already exists.
        public IConsultant DuplicateEmailChecker(string email)
        {
            return consultantService.GetAllConsultants().FirstOrDefault(c => c.Email == email);
        }

        // DuplicateUsernameChecker method
        // Checks if a consultant with the provided login username already exists.
        public IConsultant DuplicateUsernameChecker(string username)
        {
            return consultantService.GetAllConsultants().FirstOrDefault(c => c.Login == username);
        }
    }
}
