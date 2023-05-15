using Abstraction.Interfaces;
using DAL.Database;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
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
        private ISpecializationRepo SpecializationRepo { get; set; }

        /// <summary>
        /// Constructs a new instance of ConsultantRepo.
        /// </summary>
        public ConsultantRepo()
        {
            DataContext = new ITExpressDataClassesDataContext();
            SpecializationRepo = new SpecializationRepo();
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
                Models.Consultant consultant = new Models.Consultant();

                consultant.Id = dto.ConsultantId;
                consultant.FirstName = dto.Consultant_FirstName;
                consultant.LastName = dto.Consultant_LastName;
                consultant.Login = dto.Consultant_Login;
                consultant.Password = dto.Consultant_Password;
                consultant.Email = dto.Consultant_Email;
                consultant.ZipCode = dto.Consultant_ZipCode;
                consultant.Address = dto.Consultant_Address;
                consultant.PhoneNumber = dto.Consultant_PhoneNumber;

                List<Models.Specialization> specialization = new List<Models.Specialization>();

                result.Add(consultant);
            }
            return result;
        }

        /// <summary>
        /// Adds a new consultant to the database.
        /// </summary>
        /// <param name="dto">The consultant to add.</param>
        public void AddConsultant(IConsultant dto)
        {
            var con = new Database.Consultant()
            {
                ConsultantId = dto.Id,
                Consultant_FirstName = dto.FirstName,
                Consultant_LastName = dto.LastName,
                Consultant_Login = dto.Login,
                Consultant_Password = dto.Password,
                Consultant_Email = dto.Email,
                Consultant_Address = dto.Address,
                Consultant_City = dto.City,
                Consultant_ZipCode = dto.ZipCode,
                Consultant_PhoneNumber = dto.PhoneNumber,
            };
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
                targetConsultant.Consultant_ZipCode = consultant.ZipCode;
                targetConsultant.Consultant_Password = consultant.Password;
                targetConsultant.Consultant_Login = consultant.Login;

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
            var consultant = DataContext.Consultants.FirstOrDefault(c => c.Consultant_Login == login &&  c.Consultant_Password == password);
            return consultant != null;
        }

        public IConsultant GetConsultant(int id)
        {
            var dataConsultant = DataContext.Consultants.FirstOrDefault(c => c.ConsultantId == id);
            Models.Consultant consultant = new Models.Consultant()
            {
                Id = dataConsultant.ConsultantId,
                FirstName = dataConsultant.Consultant_FirstName,
                LastName = dataConsultant.Consultant_LastName,
                Login = dataConsultant.Consultant_Login,
                Password = dataConsultant.Consultant_Password,
                Email = dataConsultant.Consultant_Email,
                ZipCode = dataConsultant.Consultant_ZipCode,
                City = dataConsultant.Consultant_City,
                Address = dataConsultant.Consultant_Address,
                PhoneNumber = dataConsultant.Consultant_PhoneNumber,
                Specialization = SpecializationRepo.GetSpecialization(dataConsultant.SpecializationID)
            };

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
            Models.Consultant consultant = new Models.Consultant()
            {
                Id = dataConsultant.ConsultantId,
                FirstName = dataConsultant.Consultant_FirstName,
                LastName = dataConsultant.Consultant_LastName,
                Login = dataConsultant.Consultant_Login,
                Password = dataConsultant.Consultant_Password,
                Email = dataConsultant.Consultant_Email,
                ZipCode = dataConsultant.Consultant_ZipCode,
                City = dataConsultant.Consultant_City,
                Address = dataConsultant.Consultant_Address,
                PhoneNumber = dataConsultant.Consultant_PhoneNumber,
                Specialization = SpecializationRepo.GetSpecialization(dataConsultant.SpecializationID)
            };

            return consultant;
        }
    }
}
