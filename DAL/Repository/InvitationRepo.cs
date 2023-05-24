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

        InvitationRepo()
        {
            DataContext = new Database.ITExpressDataClassesDataContext();
        }

        public void AddInvitationToDB(IInvitation invitation)
        {
            Database.Invitation invitaionData = MapToData(invitation);
            DataContext.Invitations.InsertOnSubmit(invitaionData);
            DataContext.SubmitChanges();
        }

        private Database.Invitation MapToData(IInvitation invitationModel)
        {
            Database.Invitation invitationData = new Database.Invitation()
            {
                InvitationId = invitationModel.Id,
                Invitation_CustomerId = invitationModel.Customer.Id,
                Invitaiton_ConsultantId = invitationModel.Consultant.Id,
            };
            return invitationData;
        }
    }
}
