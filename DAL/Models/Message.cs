﻿using Abstraction.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    internal class Message : IMessage
    {
        public int MessageId { get; set; } 
        public string Header { get; set; }
        public string Body { get; set; }
        
        public ICustomer Customer { get; set; } 

        public IConsultant Consultant { get; set; }   

        public bool IsRead { get; set; }
        public string GetCustomerName { get { return Customer.Login; } }
    }
}
