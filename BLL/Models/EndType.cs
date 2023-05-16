using Abstraction.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class EndType : IEndType
    {
        public int Id { get; set; }
        string IEndType.EndType { get; set; }
    }
}
