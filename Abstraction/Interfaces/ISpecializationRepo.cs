using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interfaces
{
    public interface ISpecializationRepo
    {
        List<ISpecialization> GetAllSpecialization();

        ISpecialization GetSpecialization(int specializationId);

        void AddSpecialization(ISpecialization specialization);

        void EditSpecialization(ISpecialization specialization);

        void DeleteSpecialization(ISpecialization specialization);
    }
}
