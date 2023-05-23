using Abstraction.Interfaces;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class InvitationService : IInvitationService
    {
        private InvitationRepo InvitationRepo { get; set; }

        public InvitationService()
        {
            InvitationRepo = new InvitationRepo();
        }
        public void AddInvitation(IInvitation invitation)
        {
            InvitationRepo.AddInvitation(invitation);
        }

        public bool IsSend(IInvitation invitation)
        {
            return InvitationRepo.IsSend(invitation);
        }

        public List<IInvitation> GetPendingInvitationsForConsultant(IConsultant consultant)
        {
            return InvitationRepo.GetPendingInvitationsForConsultant(consultant);
        }

        public List<IInvitation> GetAcceptedInvittationsForConsultant(IConsultant consultant)
        {
            return InvitationRepo.GetAcceptedInvittationsForConsultant(consultant);
        }

        public void EditInvitation(IInvitation invitation)
        {
            InvitationRepo.EditInvitation(invitation);
        }
    }
}
