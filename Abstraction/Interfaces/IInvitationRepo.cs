using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interfaces
{
    public interface IInvitationRepo
    {
        void AddInvitation(IInvitation invitation);

        bool IsSend(IInvitation invitation);
        List<IInvitation> GetPendingInvitationsForConsultant(IConsultant consultant);
        List<IInvitation> GetAcceptedInvittationsForConsultant(IConsultant consultant);
        List<IInvitation> GetPendingInvitationsForCustomer(ICustomer customer);
        void EditInvitation(IInvitation invitation);
        List<IInvitation> GetAllInvitationsViaCostumer(ICustomer customer);
        void DeleteInvitation(IInvitation invitation);
    }
}
