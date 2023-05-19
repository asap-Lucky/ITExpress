using Abstraction.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Invitation : IInvitation
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public ICustomer Customer { get; set; }
        public IConsultant Consultant { get; set; }
    }
}
