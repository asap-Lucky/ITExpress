using Abstraction.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class EndtypeService : IEndtypeService
    {
        IEndtypeRepo _endtypeRepo;

        public EndtypeService()
        {
            _endtypeRepo = new DAL.Repository.EndtypeRepo();
        }

        public void AddEndtype(IEndType endtype)
        {
            _endtypeRepo.AddEndtype(endtype);
        }

        public List<IEndType> GetAllEndTypes()
        {
            return _endtypeRepo.GetAllEndTypes();
        }

        public IEndType GetEndtype(int id)
        {
            return _endtypeRepo.GetEndtype(id);
        }


    }
}
