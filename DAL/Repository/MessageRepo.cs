using Abstraction.Interfaces;
using DAL.Database;
using DAL.Models;
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
                result.Add(MapToModel(dto));
            }
            return result;
        }

        public void AddMessage(IMessage message)
        {
            Database.Message messageData = MapToData(message);
            DataContext.Messages.InsertOnSubmit(messageData);
            DataContext.SubmitChanges();
        }

        
        private Database.Message MapToData(IMessage messageModel)
        {
            Database.Message messageData = new Database.Message()
            {                
                Message_Header = messageModel.Header,
                Message_Content = messageModel.Body,
                Message_CustomerId = messageModel.Customer.Id,
                Message_ConsultantId = messageModel.Consultant.Id
            };            
            return messageData;
        }

        public List<IMessage> GetMessagesByCustomer(ICustomer customer)
        {
            List<IMessage> messageModels = new List<IMessage>();
            var dataMessages = DataContext.Messages.Where(m => m.Message_CustomerId == customer.Id).ToList();
            foreach (var dataMessage in dataMessages)
            {
                messageModels.Add(MapToModel(dataMessage));
            }
            return messageModels;
        }

        public List<IMessage> GetMessagesByConsultant(IConsultant consultant)
        {
            List<IMessage> messageModels = new List<IMessage>();
            var messageData = DataContext.Messages.Where(m => m.Message_ConsultantId == consultant.Id).ToList();

            foreach (var message in messageData)
            {
                messageModels.Add(MapToModel(message));
            }
            return messageModels;
        }

        public void DeleteMessage(IMessage message)
        {
            var messageData = DataContext.Messages.Where(m => m.MessageId == message.MessageId).FirstOrDefault();
            DataContext.Messages.DeleteOnSubmit(messageData);
            DataContext.SubmitChanges();
        }

        public void UpdateMessageStatus(IMessage message)
        {
            var messageData = DataContext.Messages.Where(m => m.MessageId == message.MessageId).FirstOrDefault();
            messageData.Message_IsRead = message.IsRead;
            DataContext.SubmitChanges();
        }
    }
}

