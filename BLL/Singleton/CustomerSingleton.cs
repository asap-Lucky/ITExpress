using System;
using Abstraction.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Singleton
{
    public class CustomerSingleton
    {
        static CustomerSingleton instance;
        public ICustomer User { get; set; }

        protected CustomerSingleton() { }

        public static CustomerSingleton Instance()
        {
            if( instance == null)
            {
                instance = new CustomerSingleton();
            }
            return instance;
        }
    }
}
