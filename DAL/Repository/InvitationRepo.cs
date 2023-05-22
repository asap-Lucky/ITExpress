using Abstraction.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class InvitationRepo : IInvitationRepo
    {
        private Database.ITExpressDataClassesDataContext DataContext { get; set; }

        public InvitationRepo()
        {
            DataContext = new Database.ITExpressDataClassesDataContext();
        }

        public void AddInvitation(IInvitation invitation)
        {
            Database.Invitation invitaionData = MapToData(invitation);
            DataContext.Invitations.InsertOnSubmit(invitaionData);
            DataContext.SubmitChanges();
        }

        public bool IsSend(IInvitation invitation)
        {
            bool isSend = false;
            var dataInvitations = DataContext.Invitations.Where(i => i.Invitation_CustomerId == invitation.Customer.Id).Where(i => i.Invitation_ProjectId == invitation.Project.Id);
            if(dataInvitations.Count() > 0)
            {
                isSend = true;
            }
            return isSend;
        }

        private Database.Invitation MapToData(IInvitation invitationModel)
        {
            Database.Invitation invitationData = new Database.Invitation()
            {
                Invitation_CustomerId = invitationModel.Customer.Id,
                Invitaiton_ConsultantId = invitationModel.Consultant.Id,
                Invitation_ProjectId = invitationModel.Project.Id,
                Inivitaion_AcceptStatus = invitationModel.AcceptStatus
            };
            return invitationData;
        }
    }
}
