using Abstraction.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class Project : Abstraction.Interfaces.IProject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Requirements { get; set; }
        public decimal TotalSum { get; set; }
        public decimal HourWage { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public int TimeUsed { get; set; }
        public int Status { get; set; }
        public int CustomerId { get; set; }
        public int ConsultantId { get; set; }
    }
}
