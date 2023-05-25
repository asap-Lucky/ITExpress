using Abstraction.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Singleton
{
    /// <summary>
    /// Djoan
    /// </summary>
    public class AdminSingleton
    {
        static AdminSingleton instance;
        public IAdmin User { get; set; }

        protected AdminSingleton() { }

        // Instance method
        // Gets the singleton instance of the AdminSingleton class.
        // If an instance doesn't exist, a new instance is created.
        // Returns:
        // - The singleton instance of the AdminSingleton class.
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
