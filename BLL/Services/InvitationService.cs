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
    }
}
