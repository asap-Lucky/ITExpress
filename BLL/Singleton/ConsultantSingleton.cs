using Abstraction.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Singleton
{
    public class ConsultantSingleton
    {
        static ConsultantSingleton instance;
        public IConsultant User { get; set; }

        protected ConsultantSingleton() { }
        public static ConsultantSingleton Instance()
        {
            if(instance == null)
            {
                instance = new ConsultantSingleton();
            }
            return instance;
        }
    }
}
