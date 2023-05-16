using Abstraction.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class CodeLanguageService : ICodeLangaugeService
    {
        ICodeLanguageRepo _codeLanguageRepo;

        public CodeLanguageService()
        {
            // Inversion of Control is used to solve the dependency of the repository
            _codeLanguageRepo = new DAL.Repository.CodeLanguageRepo();
        }

        public void AddCodeLanguage(ICodeLanguage dto)
        {
            _codeLanguageRepo.AddCodeLanguage(dto);
        }

        public void DeleteCodeLanguage(ICodeLanguage dto)
        {
            _codeLanguageRepo.DeleteCodeLanguage(dto);
        }

        public void EditCodeLanguage(ICodeLanguage dto)
        {
            _codeLanguageRepo.EditCodeLanguage(dto);
        }

        public List<ICodeLanguage> GetAllCodeLanguages()
        {
            return _codeLanguageRepo.GetAllCodeLanguages();
        }

        public ICodeLanguage GetCodeLanguage(int id)
        {
            return _codeLanguageRepo.GetCodeLanguage(id);
        }
    }
}
