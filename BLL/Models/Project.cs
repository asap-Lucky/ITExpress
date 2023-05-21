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
        public decimal TotalSum { get; set; }
        public decimal HourWage { get; set; }
        public DateTime StartDate { get; set; }
        public string GetStartDate { get {  return StartDate.ToString(); } }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public int TimeUsed { get; set; }
        public int Status { get; set; }
        public ICustomer Customer { get; set; }
        public IConsultant Consultant { get; set; }
        public ICodeLanguage Language { get; set; }
        public IEndType EndType { get; set; }

        public string GetLangauge { get { return Language.Language; } }

        public string GetEndType { get { return EndType.EndType1; } }

        public string GetCustomerFullName { get { return Customer.GetFullName; } }

        public string GetConsultantFullName { get { return Consultant.GetFullName; } }
    }
}
