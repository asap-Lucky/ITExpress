using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interfaces
{
    public interface IMessageRepo
    {
        List<IMessage> GetAllMessages();

        void AddMessage(IMessage dto);

        void DeleteMessage(IMessage dto);

        void EditMessage(IMessage message);

        List<IMessage> GetMessagesByCostumer(IMessage message);
    }
  
}
