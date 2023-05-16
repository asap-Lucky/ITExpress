using Abstraction.Interfaces;
using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class AdminRepo : IAdminRepo
    {
        //Fields
        private ITExpressDataClassesDataContext DataContext { get; set; }

        //Constructor
        public AdminRepo()
        {
            DataContext = new ITExpressDataClassesDataContext();
        }

        public bool IsValidAdmin(string login, string password)
        {
            var admin = DataContext.Admins.FirstOrDefault(c => c.Admin_UserName == login && c.Admin_Password == password);
            return admin != null;
        }

        public IAdmin GetAdmin(int id)
        {
            var dataAdmin = DataContext.Admins.FirstOrDefault(c => c.AdminID == id);
            Models.Admin admin = new Models.Admin()
            {
                Id = dataAdmin.AdminID,
                Login = dataAdmin.Admin_UserName,
                Password = dataAdmin.Admin_Password
            };

            return admin;
        }

        public IAdmin GetAdmin(string login, string password)
        {
            var dataAdmin = DataContext.Admins.FirstOrDefault(c => c.Admin_UserName == login && c.Admin_Password == password);
            Models.Admin admin = new Models.Admin()
            {
                Id = dataAdmin.AdminID,
                Login = dataAdmin.Admin_UserName,
                Password = dataAdmin.Admin_Password
            };

            return admin;
        }
    }
}
