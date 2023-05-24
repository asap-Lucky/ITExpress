using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interfaces
{
    public interface  IInvitationService
    {
        void AddInvitation(IInvitation invitation);
        bool IsSend(IInvitation invitation);
        List<IInvitation> GetPendingInvitationsForConsultant(IConsultant consultant);
        List<IInvitation> GetAcceptedInvittationsForConsultant(IConsultant consultant);
        void EditInvitation(IInvitation invitation);

        List<IInvitation> GetInvitationsViaCostumer(ICustomer customer);
    }
}
