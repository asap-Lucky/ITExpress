using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interfaces
{
    public interface IMessage
    {
        int MessageId { get; set; }
        string Header { get; set; }
        string Body { get; set; }
        ICustomer Customer { get; set; }
        IConsultant Consultant { get; set; }
        bool IsRead { get; set; }
    }
}
