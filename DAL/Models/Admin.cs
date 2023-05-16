using Abstraction.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Admin : IAdmin
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

    }
}
