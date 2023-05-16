using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraction.Interfaces;
using BLL.Models;
using DAL.Repository;

namespace BLL.Services
{
    public class AdminService : IAdminService
    {
        IAdminRepo _adminRepo;

        public AdminService()
        {
            _adminRepo = new DAL.Repository.AdminRepo();
        }

        /// <summary>
        /// Gets a consultant by login.
        /// </summary>
        /// <param name="login">The admin's login.</param>
        /// <param name="password">The admins's password.</param>
        /// <returns>The admin.</returns>
        public IAdmin GetAdmin(string login, string password)
        {
            return _adminRepo.GetAdmin(login, password);
        }

        public bool IsValidAdmin(string login, string password)
        {
            return _adminRepo.IsValidAdmin(login, password);
        }
    }
}
