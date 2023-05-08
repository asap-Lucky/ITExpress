using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class Invitation
    {
        public int InvitationId { get; set; }
        public string InvitationContent { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int ConsultantId { get; set; }
        public Consultant Consultant { get; set; }
    }
}
