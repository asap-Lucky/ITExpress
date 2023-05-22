using Abstraction.Interfaces;
using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class MessageRepo : IMessageRepo 
    {
        private ITExpressDataClassesDataContext DataContext { get; set; }

        public MessageRepo()
        {
            DataContext = new ITExpressDataClassesDataContext();
        }

        public List<IMessage> GetAllMessages()
        {
            var result = new List<IMessage>();

            var AllDtoItem = DataContext.Messages;

            foreach (var dto in AllDtoItem)
            {
                Models.Message message = new Models.Message();

               
                Message.MessageId = dto.MessageId;
                Message.Header = dto.MessageHeader;
                Message.Body = dto.Message_content;
                Message.CustomerId = dto.Message_CustomerId;
                Message.ConsultantId = dto.Message_ConsultantId;




                result.Add(message);
            }
            return result;
        }

        public void Addmessage(IMessage dto)
        {
            var message = new Database.Message()
            {

                MessageId = dto.MessageId,
                Message_Header = dto.Header,
                Message_content = dto.Body,
                Message_ConsultantId = dto.ConsultantId,
                Message_CustomerId = dto.CustomerId,
                
            };
            DataContext.Messages.InsertOnSubmit(message);
            DataContext.SubmitChanges();
        }

        public void DeleteMessage(IMessage dto)
        {
            var targetMessage = DataContext.Messages.FirstOrDefault(i => i.MessageId == dto.Id);

            DataContext.Projects.DeleteOnSubmit(targetMessage);

            DataContext.SubmitChanges();
        }

        public void EditProject(IProject project)
        {
            var targetProject = DataContext.Projects.FirstOrDefault(p => p.ProjectId == project.Id);
            if (targetProject != null)
            {
                // Update the Project object with the new values.
                targetProject.Project_Name = project.Name;
                targetProject.Project_CustomerId = project.CustomerId;
                targetProject.Project_ConsultantId = project.ConsultantId;
                targetProject.Project_StartDate = project.StartDate;
                targetProject.Project_EndDate = project.EndDate;
                targetProject.Project_Status = project.Status;
                targetProject.Project_EndType = project.EndType.Id;
                targetProject.Project_CodeLanguageId = project.Language.Id;

                // Save the changes to the database.
                DataContext.SubmitChanges();
            }
        }

        public List<IMessage> GetMessagesByCostumer(IMessage message)
        {
            List<IMessage> messageModels = new List<IMessage>();
            var dataMessages = DataContext.Messages.Where(c => c.Message_CustomerId == customer.Id).ToList();
            foreach (var dataProject in dataMessages)
            {
                messagesModels.Add(MapToModel(dataMessage));
            }
            return messageModels;
        }

        
    }
}

