﻿using Abstraction.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class Invitation : IInvitation
    {
        public int Id { get; set; }
        public ICustomer Customer { get; set; }
        public IConsultant Consultant { get; set; }
        public IProject Project { get; set; }
        public bool AcceptStatus { get; set; }

        public string GetProjectName { get { return Project.Name; } }
        public string GetProjectLanguage { get { return Project.GetLangauge; } }
        public string GetEndType { get { return Project.GetEndType; } }
        public string GetCustomerName { get { return Customer.GetFullName; } }
    }
}
