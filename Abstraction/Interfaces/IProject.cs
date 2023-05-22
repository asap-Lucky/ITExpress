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
        decimal TotalSum { get; set; }
        decimal HourWage { get; set; }
        DateTime StartDate { get; set; }
        string GetStartDate { get; }
        DateTime EndDate { get; set; }
        string Description { get; set; }
        int TimeUsed { get; set; }
        int Status { get; set; }
        ICustomer Customer { get; set; }
        IConsultant Consultant { get; set; }
        ICodeLanguage Language { get; set; }
        string GetLangauge { get; }
        IEndType EndType { get; set; }
        string GetEndType { get; }
        string GetCustomerFullName { get; }
        string GetConsultantFullName { get; }
    }
}
