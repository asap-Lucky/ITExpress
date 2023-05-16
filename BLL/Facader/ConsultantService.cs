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
    public class ConsultantService
    {
        public IConsultantService consultantService { get; set; }

        public ICodeLangaugeService codeLanguageService { get; set; }

        public IEndtypeService endtypeService { get; set; }

        public Abstraction.Interfaces.IConsultant MyConsultant { get; set; }

        public ConsultantService(IConsultantService consultantService, ICodeLangaugeService codeLanguageService, IEndtypeService endtypeService)
        { 
            this.consultantService = consultantService;
            this.codeLanguageService = codeLanguageService;
            this.endtypeService = endtypeService;
        }

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

        public void EditConsultantLoginInfo(int Id, string Login, string Password)
        {
            // Initialize MyConsultant with a new instance of the Consultant class.
            MyConsultant = consultantService.GetConsultant(Id);
            MyConsultant.Login = Login;
            MyConsultant.Password = Password;

            // Call the EditConsultant method of the ConsultantService object and pass in MyConsultant object.
            consultantService.EditConsultant(MyConsultant);
        }

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

        public IConsultant GetConsultant(int Id)
        {
            return consultantService.GetConsultant(Id);
        }
    }
}
