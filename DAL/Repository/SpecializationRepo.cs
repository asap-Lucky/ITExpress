using Abstraction.Interfaces;
using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class SpecializationRepo : ISpecializationRepo
    {
        private ITExpressDataClassesDataContext DataContext { get; set; }

        public SpecializationRepo()
        {
            DataContext = new ITExpressDataClassesDataContext();
        }
        public void AddSpecialization(ISpecialization specialization)
        {
            var con = new Database.Specialization()
            {
                SpecializationId = specialization.ID,
                Specialization_CodeLanguage = specialization.CodeLanguage,
                Specialization_EndType = specialization.EndType,
                Specialization_Description = specialization.Description,
            };
            DataContext.Specializations.InsertOnSubmit(con);
            DataContext.SubmitChanges();
        }

        public void DeleteSpecialization(ISpecialization specialization)
        {
            var targetSpecialization = DataContext.Specializations.FirstOrDefault(i => specialization.ID == specialization.ID);

            DataContext.Specializations.DeleteOnSubmit(targetSpecialization);

            DataContext.SubmitChanges();
        }

        public void EditSpecialization(ISpecialization specialization)
        {
            var targetSpecialization = DataContext.Specializations.FirstOrDefault(i => specialization.ID == specialization.ID);
            if (targetSpecialization != null) 
            { 
                targetSpecialization.SpecializationId = specialization.ID;
                targetSpecialization.Specialization_CodeLanguage = specialization.CodeLanguage;
                targetSpecialization.Specialization_EndType = specialization.EndType;
                targetSpecialization.Specialization_Description = specialization.Description;

                DataContext.SubmitChanges();
            }

        }

        public List<ISpecialization> GetAllSpecialization()
        {
            var result = new List<ISpecialization>();

            var AllDToSpecialization = DataContext.Specializations;

            foreach (var dto in AllDToSpecialization) 
            { 
                Models.Specialization specialization = new Models.Specialization();

                specialization.ID = dto.SpecializationId;
                specialization.CodeLanguage = dto.Specialization_CodeLanguage;
                specialization.EndType = dto.Specialization_EndType;
                specialization.Description = dto.Specialization_Description;

                result.Add(specialization);
            }
            return result;
        }

        public ISpecialization GetSpecialization(int specializationId)
        {
            var dataSpecialization = DataContext.Specializations.FirstOrDefault(c => c.SpecializationId == specializationId);

            Models.Specialization specialization = new Models.Specialization()
            {
                ID = dataSpecialization.SpecializationId,
                CodeLanguage = dataSpecialization.Specialization_CodeLanguage,
                EndType = dataSpecialization.Specialization_EndType,
                Description = dataSpecialization.Specialization_Description
            };
            return specialization;
        }

    }
}
