using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interfaces
{
    public interface IConsultantService
    {
        List<IConsultant> GetAllConsultants();

        void AddConsultant(IConsultant consultant);

        void EditConsultant(IConsultant consultant);

        void DeleteConsultant(IConsultant consultant);
    }
}
