using Abstraction.Interfaces;
using DAL.Database;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class EndtypeRepo : IEndtypeRepo
    {
        private ITExpressDataClassesDataContext DataContext { get; set; }

        public EndtypeRepo()
        {
            DataContext = new ITExpressDataClassesDataContext();
        }

        public void AddEndtype(IEndType endtype)
        {
            var end = new Database.EndType()
            {
                Id = endtype.Id,
                EndType1 = endtype.EndType1
            };
            DataContext.EndTypes.InsertOnSubmit(end);
            DataContext.SubmitChanges();
        }

        public IEndType GetEndtype(int id)
        {
            var dataEndtype = DataContext.EndTypes.FirstOrDefault(e => e.Id == id);
            IEndType endType = new Models.EndType()
            {
                Id = dataEndtype.Id,
                EndType1 = dataEndtype.EndType1
            };
            return endType;
        }

        public List<IEndType> GetAllEndTypes()
        {
            var result = new List<IEndType>();

            // Retrieve all endtype data transfer objects (DTOs) from the database
            var AllDToEndType = DataContext.EndTypes;

            // Convert each end type DTO to a end type model object and add to the result list
            foreach (var dto in AllDToEndType)
            {
                IEndType endType = new Models.EndType();

                endType.Id = dto.Id;
                endType.EndType1 = dto.EndType1;

                result.Add(endType);
            }
            return result;
        }
    }
}
