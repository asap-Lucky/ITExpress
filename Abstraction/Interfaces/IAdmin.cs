using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interfaces
{
    public interface IAdmin
    {
        int Id { get; set; }
        string Login { get; set; }
        string Password { get; set; }
    }
}
