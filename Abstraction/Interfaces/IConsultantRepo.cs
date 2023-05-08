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

        IConsultant GetConsultant(string login, string password);

        void AddConsultant(IConsultant dto);

        void DeleteConsultant(IConsultant dto);

        void EditConsultant(IConsultant consultant);

        bool IsValidConsultant(string login, string password);
    }
}
