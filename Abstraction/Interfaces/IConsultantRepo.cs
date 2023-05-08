using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interfaces
{
    public interface IConsultantRepo
    {
        List<IConsultant> GetAllConsultants();

        void AddConsultant(IConsultant dto);

        void DeleteConsultant(IConsultant dto);

        void EditConsultant(IConsultant consultant);
    }
}
