using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public string ProjectRequirements { get; set; }
        public decimal ProjectTotalSum { get; set; }
        public decimal ProjectHourWage { get; set; }
        public DateTime ProjectStartDate { get; set; }
        public DateTime ProjectEndDate { get; set; }
        public int ProjectTimeUsed { get; set; }
        public int ProjectStatus { get; set; }
        public int CustomerId { get; set; }
        public int ConsultantId { get; set; }
    }
}
