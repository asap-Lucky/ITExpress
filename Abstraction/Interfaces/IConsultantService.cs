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

        IConsultant GetConsultant(string login, string password);

        void AddConsultant(IConsultant consultant);

        void EditConsultant(IConsultant consultant);

        void DeleteConsultant(IConsultant consultant);

        bool IsValidConsultant(string login, string password);
    }
}
