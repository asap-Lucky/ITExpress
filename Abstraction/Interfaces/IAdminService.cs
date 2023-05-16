using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interfaces
{
    public interface IAdminService
    {
        IAdmin GetAdmin(string login, string password);

        bool IsValidAdmin(string login, string password);
    }
}
