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
        IProject Project { get; set; }
        ICustomer Customer { get; set; }
        IConsultant Consultant { get; set; }
        bool AcceptStatus { get; set; }
    }
}
