using Abstraction.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class Specialization : ISpecialization
    {
        public int ID { get; set; }
        public string CodeLanguage { get; set; }
        public string EndType { get; set; }
        public string Description { get; set; }
    }
}
