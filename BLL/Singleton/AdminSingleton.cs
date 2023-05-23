using Abstraction.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Singleton
{
    public class AdminSingleton
    {
        static AdminSingleton instance;
        public IAdmin User { get; set; }

        protected AdminSingleton() { }
        public static AdminSingleton Instance()
        {
            if (instance == null)
            {
                instance = new AdminSingleton();
            }
            return instance;
        }
    }
}
