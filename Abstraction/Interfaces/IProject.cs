using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interfaces
{
    public interface IProject
    {
        int Id { get; set; }
        string Name { get; set; }
        string Requirements { get; set; }
        decimal TotalSum { get; set; }
        decimal HourWage { get; set; }
        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }
       string Description { get; set; }
        int TimeUsed { get; set; }
        int Status { get; set; }
        int CustomerId { get; set; }
        int ConsultantId { get; set; }
    }
}
