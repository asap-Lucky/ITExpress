using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interfaces
{
    public interface ISpecializationService
    {
        void AddSpecialization(ISpecialization specialization);

        void DeleteSpecialization(ISpecialization specialization);

        List<ISpecialization> GetAllSpecializations();

        void EditSpecialization(ISpecialization specialization);
    }
}
