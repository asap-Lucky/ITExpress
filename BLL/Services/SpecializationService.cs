using Abstraction.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class SpecializationService : ISpecializationService
    {
        ISpecializationRepo _SpecializationRepo;

        public SpecializationService()
        {
            _SpecializationRepo = new DAL.Repository.SpecializationRepo();
        }

        public void AddSpecialization(ISpecialization specialization)
        {
            _SpecializationRepo.AddSpecialization(specialization);
        }

        public void DeleteSpecialization(ISpecialization specialization)
        {
            _SpecializationRepo.DeleteSpecialization(specialization);
        }

        public List<ISpecialization> GetAllSpecializations()
        {
            return _SpecializationRepo.GetAllSpecialization();
        }

        public void EditSpecialization(ISpecialization specialization)
        {
            _SpecializationRepo.EditSpecialization(specialization);
        }

    }
}
