using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interfaces
{
    public interface ISpecialization
    {
        int ID { get; set; }
        string CodeLanguage { get; set; }
        string EndType { get; set; }
        string Description { get; set; }
    }
}
