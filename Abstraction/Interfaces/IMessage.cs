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

        int CustomerId { get; set; }

        int ConsultantId { get; set; }
    }
}
