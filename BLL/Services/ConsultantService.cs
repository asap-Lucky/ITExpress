using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraction.Interfaces;
using BLL.Models;

namespace BLL.Services
{
    /// <summary>
    /// The ConsultantService class implements the IConsultantService interface and serves as the business logic layer for the consultant-related operations.
    /// </summary>
    public class ConsultantService : IConsultantService
    {

        IConsultantRepo _consultantRepo;

        /// <summary>
        /// Initializes a new instance of the ConsultantService class that provides an implementation for the IConsultantService interface.
        /// </summary>
        public ConsultantService()
        {
            _consultantRepo = new DAL.Repository.ConsultantRepo();
        }

        /// <summary>
        /// Adds a new consultant.
        /// </summary>
        /// <param name="consultant">The consultant to be added.</param>
        public void AddConsultant(IConsultant consultant)
        {
            _consultantRepo.AddConsultant(consultant);
        }

        /// <summary>
        /// Deletes a consultant.
        /// </summary>
        /// <param name="consultant">The consultant to be deleted.</param>
        public void DeleteConsultant(IConsultant consultant)
        {
            _consultantRepo.DeleteConsultant(consultant);
        }

        /// <summary>
        /// Gets all consultants.
        /// </summary>
        /// <returns>A list of all consultants.</returns>
        public List<IConsultant> GetAllConsultants()
        {
            return _consultantRepo.GetAllConsultants();
        }

        /// <summary>
        /// Edits a consultant.
        /// </summary>
        /// <param name="consultant">The consultant to be edited.</param>
        public void EditConsultant(IConsultant consultant)
        {
            _consultantRepo.EditConsultant(consultant);
        }

        /// <summary>
        /// Checks if a consultant is valid.
        /// </summary>
        /// <param name="login">The consultant's login.</param>
        /// <param name="password">The consultant's password.</param>
        /// <returns>True if the consultant is valid, false otherwise.</returns>
        public bool IsValidConsultant(string login, string password)
        {
            return _consultantRepo.IsValidConsultant(login, password);
        }

        /// <summary>
        /// Gets a consultant by login.
        /// </summary>
        /// <param name="login">The consultant's login.</param>
        /// <param name="password">The consultant's password.</param>
        /// <returns>The consultant.</returns>
        public IConsultant GetConsultant(string login, string password)
        {
            return _consultantRepo.GetConsultant(login, password);
        }

        /// <summary>
        /// Gets a consultant by id.
        /// </summary>
        /// <param name="id">The consultant's id.</param>
        /// <returns>The consultant.</returns>
        public IConsultant GetConsultant(int id)
        {
            return _consultantRepo.GetConsultant(id);
        }

        //Warning: MAY RETURN AN EMPTY LIST!
        public List<IConsultant> CodeLangaugeBinarySearch(List<IConsultant> consultants, string searchTerm)
        {
            List<IConsultant> result = new List<IConsultant> ();
            for(int i = 0; i < consultants.Count; i++)
            {
                if (consultants[i].Language.Language.StartsWith(searchTerm, StringComparison.OrdinalIgnoreCase))
                {
                    result.Add(consultants[i]);
                }
            }
            return result;
        }
    }
}