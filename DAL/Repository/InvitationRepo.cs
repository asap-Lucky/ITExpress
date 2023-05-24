using Abstraction.Interfaces;
using DAL.Models;
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
        public List<IInvitation> GetPendingInvitationsForConsultant(IConsultant consultant)
        {
            List<IInvitation> invitationModels = new List<IInvitation>();
            var invitationData = DataContext.Invitations.Where(i => i.Invitaiton_ConsultantId == consultant.Id);
            invitationData = invitationData.Where(i => i.Inivitaion_AcceptStatus == false);
            foreach (var invitation in invitationData)
            {
                invitationModels.Add(MapToModel(invitation));
            }
            return invitationModels;
        }
        public List<IInvitation> GetAcceptedInvittationsForConsultant(IConsultant consultant)
        {
            List<IInvitation> invitationModels = new List<IInvitation>();
            var invitationData = DataContext.Invitations.Where(i => i.Invitaiton_ConsultantId == consultant.Id);
            invitationData = invitationData.Where(i => i.Inivitaion_AcceptStatus == true);
            foreach (var invitation in invitationData)
            {
                invitationModels.Add(MapToModel(invitation));
            }
            return invitationModels;
        }

        public void EditInvitation(IInvitation invitation)
        {
            var targetInvitation = DataContext.Invitations.First(i => i.InvitationId == invitation.Id);
            if(targetInvitation != null)
            {
                targetInvitation.InvitationId = invitation.Id;
                targetInvitation.Invitation_ProjectId = invitation.Project.Id;
                targetInvitation.Invitation_CustomerId = invitation.Customer.Id;
                targetInvitation.Invitaiton_ConsultantId = invitation.Customer.Id;
                targetInvitation.Inivitaion_AcceptStatus = invitation.AcceptStatus;
            }
            DataContext.SubmitChanges();
        }

        private IInvitation MapToModel(Database.Invitation invitationData) 
        {
            Models.CodeLanguage invitationLanguage = new Models.CodeLanguage()
            {
                Id = invitationData.Consultant.CodeLanguage.Id,
                Language = invitationData.Consultant.CodeLanguage.LanguageName
            };
            Models.EndType invitationEndtype = new Models.EndType()
            {
                    Id = invitationData.Consultant.EndType.Id,
                    EndType1 = invitationData.Consultant.EndType.EndType1
            };
            IProject invitationProject = new Models.Project();
            invitationProject.Id = invitationData.Project.ProjectId;
            invitationProject.Name = invitationData.Project.Project_Name;
            if (invitationData.Project.Project_TotalSum != null)
            {
                invitationProject.TotalSum = (decimal)invitationData.Project.Project_TotalSum;
            }
            invitationProject.HourWage = invitationData.Project.Project_HourWage;
            invitationProject.StartDate = invitationData.Project.Project_StartDate;
            invitationProject.EndDate = invitationData.Project.Project_EndDate;
            invitationProject.Description = invitationData.Project.Project_Description;
            if (invitationData.Project.Project_TimeUsed != null)
            {
                invitationProject.TimeUsed = (int)invitationData.Project.Project_TimeUsed;
            }
            invitationProject.Status = invitationData.Project.Project_Status;
            invitationProject.Language = invitationLanguage;
            invitationProject.EndType = invitationEndtype;
            invitationProject.Customer = new Models.Customer()
            {
                Id = invitationData.Customer.CustomerId,
                FirstName = invitationData.Customer.Customer_FirstName,
                LastName = invitationData.Customer.Customer_LastName,
                Login = invitationData.Customer.Customer_Login,
                Password = invitationData.Customer.Customer_Password,
                Email = invitationData.Project.Customer.Customer_Email,
                ZipCode = invitationData.Project.Customer.Customer_ZipCode,
                City = invitationData.Project.Customer.Customer_City,
                Address = invitationData.Project.Customer.Customer_Address,
                PhoneNumber = invitationData.Customer.Customer_PhoneNumber,
            };
            invitationProject.Consultant = new Models.Consultant()
            {
                Id = invitationData.Consultant.ConsultantId,
                FirstName = invitationData.Consultant.Consultant_FirstName,
                LastName = invitationData.Consultant.Consultant_LastName,
                Login = invitationData.Consultant.Consultant_Login,
                Password = invitationData.Consultant.Consultant_Password,
                Email = invitationData.Consultant.Consultant_Email,
                ZipCode = invitationData.Consultant.Consultant_ZipCode,
                City = invitationData.Consultant.Consultant_City,
                Address = invitationData.Consultant.Consultant_Address,
                PhoneNumber = invitationData.Consultant.Consultant_PhoneNumber,
                Language = invitationLanguage,
                EndType = invitationEndtype
            };

            IInvitation invitationModel = new Models.Invitation()
            {
                Id = invitationData.InvitationId,
                Project = invitationProject,
                Consultant = invitationProject.Consultant,
                Customer = invitationProject.Customer,
                AcceptStatus = invitationData.Inivitaion_AcceptStatus
            };
            return invitationModel;
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
