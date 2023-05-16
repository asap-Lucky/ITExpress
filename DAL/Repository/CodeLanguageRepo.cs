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
    public class CodeLanguageRepo : ICodeLanguageRepo
    {
        private ITExpressDataClassesDataContext DataContext { get; set; }

        public CodeLanguageRepo()
        {
            DataContext = new ITExpressDataClassesDataContext();
        }

        public void AddCodeLanguage(ICodeLanguage dto)
        {
            var lan = new CodeLanguage()
            {
                Id = dto.Id,
                LanguageName = dto.Language
            };
            DataContext.CodeLanguages.InsertOnSubmit(lan);
            DataContext.SubmitChanges();
        }
        
        public void DeleteCodeLanguage(ICodeLanguage dto)
        {
            // Find the CodeLanguage DTO in the database by ID and delete it
            var targetCodeLanguage = DataContext.CodeLanguages.FirstOrDefault(i => i.Id == dto.Id);
            DataContext.CodeLanguages.DeleteOnSubmit(targetCodeLanguage);

            // Save the changes to the database
            DataContext.SubmitChanges();
        }
        
        public void EditCodeLanguage(ICodeLanguage dto)
        {
            var targetCodeLanguage = DataContext.CodeLanguages.FirstOrDefault(c => c.Id == dto.Id);

            targetCodeLanguage.Id = dto.Id;
            targetCodeLanguage.LanguageName = dto.Language;

            DataContext.SubmitChanges();
        }

        public List<ICodeLanguage> GetAllCodeLanguages()
        {
            var result = new List<ICodeLanguage>();

            // Retrieve all code language data transfer objects (DTOs) from the database
            var AllDToCodeLanguage = DataContext.CodeLanguages;

            // Convert each code language DTO to a code language model object and add to the result list
            foreach (var dto in AllDToCodeLanguage)
            {
                Models.CodeLanguage codeLanguage = new Models.CodeLanguage();

                codeLanguage.Id = dto.Id;
                codeLanguage.Language = dto.LanguageName;

                result.Add(codeLanguage);
            }
            return result;
        }

        public ICodeLanguage GetCodeLanguage(int id)
        {
            var dataCodeLanguage = DataContext.CodeLanguages.FirstOrDefault(x => x.Id == id);
            Models.CodeLanguage codeLanguage = new Models.CodeLanguage()
            {
                Id = dataCodeLanguage.Id,
                Language = dataCodeLanguage.LanguageName

            };
            return codeLanguage;
        }
    }
}
