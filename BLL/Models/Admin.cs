﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class Admin : Abstraction.Interfaces.IAdmin
    {
        //Does Admin need an ID in the code?
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public Admin(string login, string password)
        {            
            Login = login;
            Password = password;
        }
    }
}
