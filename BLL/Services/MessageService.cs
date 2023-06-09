using Abstraction.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class MessageService : IMessageService
    {
        IMessageRepo _messageRepo;

        public MessageService()
        {
            _messageRepo = new DAL.Repository.MessageRepo();
        }

        public List<IMessage> GetAllMessages()
        {
            return _messageRepo.GetAllMessages();
        }

        public void AddMessage(IMessage message)
        {
            _messageRepo.AddMessage(message);
        }

        public List<IMessage> GetMessagesByCustomer(ICustomer customer)
        {
            return _messageRepo.GetMessagesByCustomer(customer);
        }

        public List<IMessage> GetMessagesByConsultant(IConsultant consultant)
        {
            return _messageRepo.GetMessagesByConsultant(consultant);
        }

        public void DeleteMessage(IMessage message)
        {
            _messageRepo.DeleteMessage(message);
        }

        public void UpdateMessageStatus(IMessage message)
        {
            _messageRepo.UpdateMessageStatus(message);
        }

        public List<IMessage> GetUnreadMessagesByCustomer(ICustomer customer)
        {
            return _messageRepo.GetUnreadMessagesByCustomer(customer);
        }

        public List<IMessage> GetUnreadMessagesByConsultant(IConsultant consultant)
        {
            return _messageRepo.GetUnreadMessagesByConsultant(consultant);
        }

    }
}
