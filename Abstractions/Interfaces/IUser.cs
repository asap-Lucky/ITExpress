using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions.Interfaces
{
    // Allow a class to be a user
    public interface IUser
    {
        string Login { get; set; }
        string Password { get; set; }
    }
}
