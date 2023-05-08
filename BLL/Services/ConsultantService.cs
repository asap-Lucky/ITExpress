using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraction.Interfaces;
using BLL.Models;

namespace BLL.Services
{
    public class ConsultantService : IConsultantService
    {
        IConsultantRepo _consultantRepo;

        public ConsultantService()
        {
            _consultantRepo = new DAL.Repository.ConsultantRepo();
        }

        public void AddConsultant(IConsultant consultant)
        {
            _consultantRepo.AddConsultant(consultant);
        }

        public void DeleteConsultant(IConsultant consultant)
        {
            _consultantRepo.DeleteConsultant(consultant);
        }

        public List<IConsultant> GetAllConsultants()
        {
            return _consultantRepo.GetAllConsultants();   
        }

        public void EditConsultant(IConsultant consultant)
        {
            _consultantRepo.EditConsultant(consultant);
        }

        public bool IsValidConsultant(string login, string password)
        {
            return _consultantRepo.IsValidConsultant(login, password);
        }

        public IConsultant GetConsultant(string login, string password)
        {
            return _consultantRepo.GetConsultant(login, password);
        }
    }
}
