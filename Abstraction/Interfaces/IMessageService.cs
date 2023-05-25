using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interfaces
{
    public interface IMessageService
    {
        List<IMessage> GetAllMessages();

        void AddMessage(IMessage message);

        List<IMessage> GetMessagesByCustomer(ICustomer customer);

        List<IMessage> GetMessagesByConsultant(IConsultant consultant);

        List<IMessage> EditIsReadMessages (IMessage message);

        IMessage GetMessage(int id);

    }
}
