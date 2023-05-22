using Abstraction.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    internal class Message : IMessage
    {
        public int MessageId { get; set; } 
        public string Header { get; set; }
        public string Body { get; set; }
        
        public int CustomerId { get; set; } 

        public int ConsultantId { get; set; }   

    }
}
