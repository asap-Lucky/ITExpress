using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interfaces
{
    public interface IMessageService
    {
        void AddMessage(IMessage message);

        IMessage GetMesaage(IMessage message);

        List<IMessage> GetAllMessages();
    }
}
