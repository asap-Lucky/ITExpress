using BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Services
{
    internal class ConsultantService
    {
        public Models.Consultant Consultant { get; set; }

        //Empty constructor.
        public ConsultantService()
        {
        }

        //Constructor
        public ConsultantService(Consultant consultant)
        {
            Consultant = consultant;
        }
    }
}
