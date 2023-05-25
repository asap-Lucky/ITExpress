using Abstraction.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Singleton
{
    /// <summary>
    /// Mikkel: A Singleton for a Consultant object.
    /// It was made because we were tired of setting the user around the program as a argument.
    /// It is lazy, and thereby not threadsafe. 
    /// </summary>
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
