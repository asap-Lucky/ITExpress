using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interfaces
{
    public interface IInvitation
    {
        int Id { get; set; }
        string Message { get; set; }
        ICustomer Customer { get; set; }
        IConsultant Consultant { get; set; }
    }
}
