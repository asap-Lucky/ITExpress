using Abstraction.Interfaces;
using DAL.Database;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    /// <summary>
    /// Implementation of IConsultantRepo using LINQ to SQL.
    /// </summary>
    public class ConsultantRepo : IConsultantRepo
    {
        /// <summary>
        /// The data context used to access the database.
        /// </summary>
        private ITExpressDataClassesDataContext DataContext { get; set; }

        /// <summary>
        /// Constructs a new instance of ConsultantRepo.
        /// </summary>
        public ConsultantRepo()
        {
            DataContext = new ITExpressDataClassesDataContext();
        }

        /// <summary>
        /// Gets all consultants from the database.
        /// </summary>
        /// <returns>A list of all consultants.</returns>
        public List<IConsultant> GetAllConsultants()
        {
            var result = new List<IConsultant>();

            var AllDtoItem = DataContext.Consultants;

            foreach (var dto in AllDtoItem) 
            {               
                result.Add(MapToModel(dto));
            }
            return result;
        }

        /// <summary>
        /// Adds a new consultant to the database.
        /// </summary>
        /// <param name="dto">The consultant to add.</param>
        public void AddConsultant(IConsultant dto)
        {
            var con = MapToData(dto);
            
            DataContext.Consultants.InsertOnSubmit(con);
            DataContext.SubmitChanges();
        }

        /// <summary>
        /// Deletes a consultant from the database.
        /// </summary>
        /// <param name="dto">The consultant to delete.</param>
        public void DeleteConsultant(IConsultant dto)
        {
            var targetConsultant = DataContext.Consultants.FirstOrDefault(i => i.ConsultantId == dto.Id);

            DataContext.Consultants.DeleteOnSubmit(targetConsultant);

            DataContext.SubmitChanges();
        }

        /// <summary>
        /// Updates a consultant in the database.
        /// </summary>
        /// <param name="consultant">The consultant to update.</param>
        public void EditConsultant(IConsultant consultant)
        {
            var targetConsultant = DataContext.Consultants.FirstOrDefault(c => c.ConsultantId == consultant.Id);
            if (targetConsultant != null)
            {
                // Update the Consultant object with the new values.
                targetConsultant.Consultant_Address = consultant.Address;
                targetConsultant.Consultant_PhoneNumber = consultant.PhoneNumber;
                targetConsultant.Consultant_FirstName = consultant.FirstName;
                targetConsultant.Consultant_LastName = consultant.LastName;
                targetConsultant.Consultant_Address = consultant.Address;
                targetConsultant.Consultant_City = consultant.City;
                targetConsultant.Consultant_ZipCode = consultant.ZipCode;
                targetConsultant.Consultant_Password = consultant.Password;
                targetConsultant.Consultant_Login = consultant.Login;

                // Update the relationships with CodeLanguage and EndType
                targetConsultant.CodeLanguage = DataContext.CodeLanguages.FirstOrDefault(cl => cl.Id == consultant.Language.Id);
                targetConsultant.EndType = DataContext.EndTypes.FirstOrDefault(et => et.Id == consultant.EndType.Id);

                // Save the changes to the database. 
                DataContext.SubmitChanges();
            }
        }

        /// <summary>
        /// Validates if the consultant with the given login and password exists in the data context.
        /// </summary>
        /// <param name="login">The login of the consultant to validate.</param>
        /// <param name="password">The password of the consultant to validate.</param>
        /// <returns>Returns true if the consultant exists, otherwise false.</returns>
        public bool IsValidConsultant(string login, string password)
        {
            var consultant = DataContext.Consultants.FirstOrDefault(c => c.Consultant_Login == login);

            if (consultant != null && consultant.Consultant_Password == password)
            {
                // Performs a case-sensitive string comparison
                return true;
            }

            return false;
        }

        public IConsultant GetConsultant(int id)
        {
            var dataConsultant = DataContext.Consultants.FirstOrDefault(c => c.ConsultantId == id);
            Models.Consultant consultant = MapToModel(dataConsultant);

            return consultant;
        }

        /// <summary>
        /// Retrieves the consultant with the given login and password from the data context.
        /// </summary>
        /// <param name="login">The login of the consultant to retrieve.</param>
        /// <param name="password">The password of the consultant to retrieve.</param>
        /// <returns>Returns the consultant object if found, otherwise returns null.</returns>
        public IConsultant GetConsultant(string login, string password)
        {
            var dataConsultant = DataContext.Consultants.FirstOrDefault(c => c.Consultant_Login == login && c.Consultant_Password == password);
            Models.Consultant consultant = MapToModel(dataConsultant);

            return consultant;
        }

        private Models.Consultant MapToModel(Database.Consultant dataConsultant)
        {
            Models.Consultant consultantModel = new Models.Consultant();

            consultantModel.Id = dataConsultant.ConsultantId;
            consultantModel.FirstName = dataConsultant.Consultant_FirstName;
            consultantModel.LastName = dataConsultant.Consultant_LastName;
            consultantModel.Login = dataConsultant.Consultant_Login;
            consultantModel.Password = dataConsultant.Consultant_Password;
            consultantModel.Email = dataConsultant.Consultant_Email;
            consultantModel.City = dataConsultant.Consultant_City;
            consultantModel.ZipCode = dataConsultant.Consultant_ZipCode;
            consultantModel.Address = dataConsultant.Consultant_Address;
            consultantModel.PhoneNumber = dataConsultant.Consultant_PhoneNumber;

            consultantModel.EndType = new Models.EndType();
            consultantModel.EndType.Id = dataConsultant.EndType.Id;
            consultantModel.EndType.EndType1 = dataConsultant.EndType.EndType1;

            consultantModel.Language = new Models.CodeLanguage();
            consultantModel.Language.Id = dataConsultant.CodeLanguage.Id;
            consultantModel.Language.Language = dataConsultant.CodeLanguage.LanguageName;

            return consultantModel;
        }

        private Database.Consultant MapToData(IConsultant consultantModel)
        {
            Database.Consultant dataConsultant = new Database.Consultant();

            dataConsultant.Consultant_FirstName = consultantModel.FirstName;
            dataConsultant.Consultant_LastName = consultantModel.LastName;
            dataConsultant.Consultant_Login = consultantModel.Login;
            dataConsultant.Consultant_Password = consultantModel.Password;
            dataConsultant.Consultant_Email = consultantModel.Email;
            dataConsultant.Consultant_City = consultantModel.City;
            dataConsultant.Consultant_ZipCode = consultantModel.ZipCode;
            dataConsultant.Consultant_Address = consultantModel.Address;
            dataConsultant.Consultant_PhoneNumber = consultantModel.PhoneNumber;

            dataConsultant.Contsultant_EndType = consultantModel.EndType.Id;

            dataConsultant.Consultant_CodeLangaugeId = consultantModel.Language.Id;

            return dataConsultant;
        }
    }
}
