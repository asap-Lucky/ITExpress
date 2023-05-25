using System;
using Abstraction.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Singleton
{
    /// <summary>
    /// Mikkel: A Singleton for a Costumer object.
    /// It was made because we were tired of setting the user around the program as a argument.
    /// It is lazy, and thereby not threadsafe. 
    /// </summary>
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
