using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Models
{
    public class Message
    {
        public int MessageId { get; set; }
        public string MessageHeader { get; set; }
        public string MessageContent { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int ConsultantId { get; set; }
        public Consultant Consultant { get; set; }
    }
}
