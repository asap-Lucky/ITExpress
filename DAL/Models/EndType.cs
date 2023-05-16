using Abstraction.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class EndType : IEndType
    {
        public int Id { get; set; }
        public string EndType1 { get; set; }
    }
}
